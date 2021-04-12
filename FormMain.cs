using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_wf_core_json_merger
{
    public partial class FormMain : Form
    {
        #region CONSTANT AND VARIABLES

        private const string FILE_PATTERN = "*.json";
        private const string BASE_EXTN = ".json";
        private const string OUTPUT_PATH = "output";
        private const string OUTPUT_FILENAME = "merged.json";
        private const string DEFAULT_PRIMARY_KEY = "id";
        private const string DEFAULT_ROOT_NODE = "elements";

        private const string REPLACED_FILENAME_STEP_1 = "_step_1.json";
        private const string REPLACED_FILENAME_STEP_2 = "_step_2.json";
        private const string REPLACED_FILENAME_STEP_3 = "_step_3.json";


        private Stopwatch stopwatch;
        private string sourceFolder = "";
        private string destinationFolder = "";
        private string[] filesToProcess;
        private string selectedMode = "1";
        private string primaryKey = DEFAULT_PRIMARY_KEY;
        private string rootElement = DEFAULT_ROOT_NODE;
        private string updatePrimaryKeyMode = "A";

        #endregion 

        public FormMain()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
        }

        #region EVENTS
        private void linkOutput_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenOutputFolder();
        }

        private void BtnSourceFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = oFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                SetFolderPaths(oFolder.SelectedPath);
                CollectJSONFilesToProcessAndUpdateUI();
            }
        }

        private void BtnMerge_Click(object sender, EventArgs e)
        {
            txtProgress.Clear();
            GetAndSetConfigValues();
            MergeJsonFilesAndProcessElements();
        }

        private void RbObject_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            selectedMode = radioButton.Tag.ToString(); //use of enums could have been done, however it requires the value conversion to integer, which could be overkill
        }
        private void RbPrimary_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            updatePrimaryKeyMode = radioButton.Tag.ToString();
        }

        #endregion

        #region FUNCTIONS

        #region CORE FUNCTIONS

        private async void MergeJsonFilesAndProcessElements()
        {
            try
            {
                string outPutFileName = Path.Combine(destinationFolder, OUTPUT_FILENAME);
                JObject outputJson = new();

                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                    LogTextToOutput("Output directory created");
                }

                JsonMergeSettings mergeSettings = new()
                {
                    MergeArrayHandling = chkDuplicate.Checked == true ? MergeArrayHandling.Union : MergeArrayHandling.Concat
                };

                foreach (var file in filesToProcess)
                {
                    LogAndStartWatch(string.Concat(file, " is being processed."));
                    var JsonFileValues = ReadJsonFile(file);
                    if (selectedMode == "1")
                    {
                        JObject intermidiateObject = new();
                        intermidiateObject.Add(DEFAULT_ROOT_NODE, JsonFileValues);
                        outputJson.Merge(intermidiateObject, mergeSettings);
                    }
                    else
                    {
                        outputJson.Merge(JsonFileValues, mergeSettings);
                    }
                    LogAndStopWatch(string.Concat(file, " has been processed."));
                }

                string resultedJsonString = outputJson.ToString();
                await File.WriteAllTextAsync(outPutFileName, resultedJsonString);

                if (chkDuplicate.Checked)
                {
                    LogAndStartWatch("Duplicate removal has been started.");
                    await Task.Run(() => RemoveDuplicates(outPutFileName, outPutFileName)); //same as merged json
                    LogAndStopWatch("Duplicate removal has been processed.");
                }

                if (chkSortFull.Checked)
                {
                    LogAndStartWatch("Complete sort has been started.");
                    await Task.Run(() => SortResetAndSaveJson(outPutFileName, outPutFileName));
                    LogAndStopWatch("Complete sort has been processed.");
                }

                if (chkSort.Checked)
                {
                    LogAndStartWatch("Element sort has been started.");
                    await Task.Run(() => SortElementsAndSave(outPutFileName, outPutFileName));
                    LogAndStopWatch("Element sort has been processed.");
                }

                linkOutput.Enabled = true;
                LogTextToOutput(string.Format("{0} files processed.", filesToProcess.Length));
            }
            catch (Exception ex)
            {
                linkOutput.Enabled = false;
                LogTextToOutput(string.Concat("Merge Task Failed:\n", ex.Message), Color.Red);
            }
        }

        private void RemoveDuplicates(string inputFile, string outputFile)
        {

            try
            {
                JObject jObject = ReadJsonFile(inputFile) ?? new JObject();

                var unique = jObject[rootElement].GroupBy(x => x[primaryKey]).Select(x => x.First()).ToList();

                for (int i = jObject[rootElement].Count() - 1; i >= 0; i--)
                {
                    var token = jObject[rootElement][i];
                    if (!unique.Contains(token))
                    {
                        token.Remove();
                    }
                }

                var result = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                File.WriteAllText(outputFile, result);

                var stepFileName = chkCreateDiffFile.Checked ? outputFile.Replace(BASE_EXTN, REPLACED_FILENAME_STEP_1) : outputFile;
                CreateFileCopyForStepOutput(outputFile, stepFileName);
            }
            catch (ArgumentNullException ex)
            {
                ex.HelpLink = "";
                LogTextToOutput("Root element definition missing or mismatched. Duplicates will still persist.", Color.Red);
            }
        }
        private void SortResetAndSaveJson(string inputFile, string outputFile)
        {
            JObject sourceObject = ReadJsonFile(inputFile) ?? new JObject();

            JArray details = (JArray)sourceObject[rootElement];
            sourceObject[rootElement].Replace(SortJsonArray(details, primaryKey));

            var result = JsonConvert.SerializeObject(sourceObject, Formatting.Indented);

            File.WriteAllText(outputFile, result);

            var stepFileName = chkCreateDiffFile.Checked ? outputFile.Replace(BASE_EXTN, REPLACED_FILENAME_STEP_2) : outputFile;
            CreateFileCopyForStepOutput(outputFile, stepFileName);
        }

        private void SortElementsAndSave(string inputFile, string outputFile)
        {
            try
            {
                JObject sourceObject = ReadJsonFile(inputFile) ?? new JObject();

                JArray details = (JArray)sourceObject[rootElement];

                for (int i = 0; i < details.Count; i++)
                {
                    SortElements((JObject)details[i]);
                }

                sourceObject[rootElement].Replace(details);
                var result = JsonConvert.SerializeObject(sourceObject, Formatting.Indented);

                File.WriteAllText(outputFile, result);

                var stepFileName = chkCreateDiffFile.Checked ? outputFile.Replace(BASE_EXTN, REPLACED_FILENAME_STEP_3) : outputFile;
                CreateFileCopyForStepOutput(outputFile, stepFileName);
            }
            catch (ArgumentNullException ex)
            {
                ex.HelpLink = "";
                LogTextToOutput("Element sorting interrupted," + ex.Message, Color.Red);
            }
        }

        #endregion

        #region CORE UTILTY FUNCTIONS

        private dynamic ReadJsonFile(string fileName)
        {
            if (selectedMode == "1")
            {
                var fileContent = File.ReadAllText(fileName);
                dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, Dictionary<string, string>>>>(fileContent);
                return result;
            }
            else
            {
                var fileContent = File.ReadAllText(fileName);
                dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(fileContent);
                return result;
            }

        }

        private void SortElements(JObject jObject)
        {
            try
            {
                var primaryKey = txtPrimary.Text.Trim() == "" ? DEFAULT_PRIMARY_KEY : txtPrimary.Text.Trim();

                var properties = jObject.Properties().ToList();
                foreach (var prop in properties)
                {
                    if (prop.Name != primaryKey)
                    {
                        prop.Remove();
                    }
                }

                foreach (var prop in properties.OrderBy(p => p.Name))
                {
                    if (prop.Name != primaryKey)
                    {
                        jObject.Add(prop);
                        if (prop.Value is JObject)
                            SortElements((JObject)prop.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.HelpLink = "";
                LogTextToOutput("Sorting element had issues, file saving aborted.", Color.Red);
            }
        }

        private JArray SortJsonArray(JArray jArray, string sortByKey)
        {
            try
            {
                JArray sortedArray = new JArray(jArray.OrderBy(obj => obj[sortByKey])); //costly affair

                if (updatePrimaryKeyMode != "A")
                {
                    for (int i = 0; i < sortedArray.Count; i++)
                    {
                        dynamic element = sortedArray[i];
                        element.Remove(primaryKey);
                        dynamic elementValue = updatePrimaryKeyMode == "B" ? (i + 1) : Guid.NewGuid().ToString();
                        element.Add(primaryKey, elementValue);
                    }
                }

                return sortedArray;
            }
            catch (Exception ex)
            {
                ex.HelpLink = "";
                LogTextToOutput("Sorting JSON had issues, file saving aborted.", Color.Red);
                return null;
            }
        }

        #endregion

        #region SMALL UTILTY FUNCTIONS

        private void OpenOutputFolder()
        {
            try
            {
                Process.Start(new ProcessStartInfo()
                {
                    FileName = destinationFolder,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }
            catch (InvalidOperationException ex)
            {
                ex.HelpLink = "";
            }
        }

        private void SetFolderPaths(string path)
        {
            sourceFolder = Directory.Exists(path) ? path : oFolder.SelectedPath;
            destinationFolder = Path.Combine(oFolder.SelectedPath, OUTPUT_PATH);
        }

        private void GetAndSetConfigValues()
        {
            rootElement = txtRoot.Text.Trim() == "" ? DEFAULT_ROOT_NODE : txtRoot.Text.Trim();
            primaryKey = txtPrimary.Text.Trim() == "" ? DEFAULT_PRIMARY_KEY : txtPrimary.Text.Trim();
        }

        private void CollectJSONFilesToProcessAndUpdateUI()
        {
            if (Directory.Exists(sourceFolder))
            {
                filesToProcess = Directory.GetFiles(sourceFolder, FILE_PATTERN);
                btnMerge.Enabled = filesToProcess.Length > 0;
                txtProgress.Text = (string.Format("{0} files needs to be processed.", filesToProcess.Length));
            }
        }

        private void LogAndStartWatch(string logMessage)
        {
            stopwatch.Start();
            LogTextToOutput(logMessage);
        }

        private void LogAndStopWatch(string logMessage)
        {
            stopwatch.Stop();
            LogTextToOutput(string.Concat(logMessage, " took ", stopwatch.ElapsedMilliseconds, " Milliseconds."), Color.Blue);
        }

        private void LogTextToOutput(string logMessage, Color? color = null)
        {
            txtProgress.SelectionColor = color ?? Color.Black;
            txtProgress.AppendText(string.Concat(logMessage, "\r\n", "\r\n"));
            txtProgress.ScrollToCaret();
        }

        private void CreateFileCopyForStepOutput(string outputFile, string stepFileName)
        {
            if (chkCreateDiffFile.Checked)
            {
                File.Copy(outputFile, stepFileName, true);
            }
        }
        #endregion

        #endregion

    }
}
