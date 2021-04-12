
namespace cs_wf_core_json_merger
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.oFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSourceFolder = new System.Windows.Forms.Button();
            this.linkOutput = new System.Windows.Forms.LinkLabel();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkCreateDiffFile = new System.Windows.Forms.CheckBox();
            this.rbArray = new System.Windows.Forms.RadioButton();
            this.rbObject = new System.Windows.Forms.RadioButton();
            this.btnMerge = new System.Windows.Forms.Button();
            this.grpProcess = new System.Windows.Forms.GroupBox();
            this.rbNewGuid = new System.Windows.Forms.RadioButton();
            this.rbNewId = new System.Windows.Forms.RadioButton();
            this.rbNoIdChange = new System.Windows.Forms.RadioButton();
            this.chkSortFull = new System.Windows.Forms.CheckBox();
            this.chkDuplicate = new System.Windows.Forms.CheckBox();
            this.chkSort = new System.Windows.Forms.CheckBox();
            this.grpDemo = new System.Windows.Forms.GroupBox();
            this.txtPrimary = new System.Windows.Forms.TextBox();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.lblPrimary = new System.Windows.Forms.Label();
            this.lblRoot = new System.Windows.Forms.Label();
            this.txtProgress = new System.Windows.Forms.RichTextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpOptions.SuspendLayout();
            this.grpProcess.SuspendLayout();
            this.grpDemo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // oFolder
            // 
            this.oFolder.Description = "Select Source Folder";
            // 
            // btnSourceFolder
            // 
            this.btnSourceFolder.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSourceFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSourceFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSourceFolder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSourceFolder.Location = new System.Drawing.Point(12, 12);
            this.btnSourceFolder.Name = "btnSourceFolder";
            this.btnSourceFolder.Size = new System.Drawing.Size(155, 30);
            this.btnSourceFolder.TabIndex = 0;
            this.btnSourceFolder.Text = "Select Source Folder";
            this.btnSourceFolder.UseVisualStyleBackColor = true;
            this.btnSourceFolder.Click += new System.EventHandler(this.BtnSourceFolder_Click);
            // 
            // linkOutput
            // 
            this.linkOutput.AutoSize = true;
            this.linkOutput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkOutput.Location = new System.Drawing.Point(613, 17);
            this.linkOutput.Name = "linkOutput";
            this.linkOutput.Size = new System.Drawing.Size(109, 20);
            this.linkOutput.TabIndex = 1;
            this.linkOutput.TabStop = true;
            this.linkOutput.Text = "(View  Output) ";
            this.linkOutput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOutput_LinkClicked);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkCreateDiffFile);
            this.grpOptions.Controls.Add(this.rbArray);
            this.grpOptions.Controls.Add(this.rbObject);
            this.grpOptions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpOptions.Location = new System.Drawing.Point(12, 49);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(371, 120);
            this.grpOptions.TabIndex = 2;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // chkCreateDiffFile
            // 
            this.chkCreateDiffFile.AutoSize = true;
            this.chkCreateDiffFile.Location = new System.Drawing.Point(16, 85);
            this.chkCreateDiffFile.Name = "chkCreateDiffFile";
            this.chkCreateDiffFile.Size = new System.Drawing.Size(270, 24);
            this.chkCreateDiffFile.TabIndex = 4;
            this.chkCreateDiffFile.Text = "Generate different files for each step";
            this.chkCreateDiffFile.UseVisualStyleBackColor = true;
            // 
            // rbArray
            // 
            this.rbArray.AutoSize = true;
            this.rbArray.Location = new System.Drawing.Point(16, 56);
            this.rbArray.Name = "rbArray";
            this.rbArray.Size = new System.Drawing.Size(193, 24);
            this.rbArray.TabIndex = 5;
            this.rbArray.Tag = "2";
            this.rbArray.Text = "Has Root Object Defined";
            this.rbArray.UseVisualStyleBackColor = true;
            this.rbArray.CheckedChanged += new System.EventHandler(this.RbObject_CheckedChanged);
            // 
            // rbObject
            // 
            this.rbObject.AutoSize = true;
            this.rbObject.Checked = true;
            this.rbObject.Location = new System.Drawing.Point(16, 26);
            this.rbObject.Name = "rbObject";
            this.rbObject.Size = new System.Drawing.Size(171, 24);
            this.rbObject.TabIndex = 4;
            this.rbObject.TabStop = true;
            this.rbObject.Tag = "1";
            this.rbObject.Text = "Has Direct Array Root";
            this.rbObject.UseVisualStyleBackColor = true;
            this.rbObject.CheckedChanged += new System.EventHandler(this.RbObject_CheckedChanged);
            // 
            // btnMerge
            // 
            this.btnMerge.Enabled = false;
            this.btnMerge.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMerge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMerge.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMerge.Location = new System.Drawing.Point(12, 540);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(155, 30);
            this.btnMerge.TabIndex = 3;
            this.btnMerge.Text = "Process Documents";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.BtnMerge_Click);
            // 
            // grpProcess
            // 
            this.grpProcess.Controls.Add(this.rbNewGuid);
            this.grpProcess.Controls.Add(this.rbNewId);
            this.grpProcess.Controls.Add(this.rbNoIdChange);
            this.grpProcess.Controls.Add(this.chkSortFull);
            this.grpProcess.Controls.Add(this.chkDuplicate);
            this.grpProcess.Controls.Add(this.chkSort);
            this.grpProcess.Location = new System.Drawing.Point(12, 378);
            this.grpProcess.Name = "grpProcess";
            this.grpProcess.Size = new System.Drawing.Size(371, 156);
            this.grpProcess.TabIndex = 5;
            this.grpProcess.TabStop = false;
            this.grpProcess.Text = "Steps";
            // 
            // rbNewGuid
            // 
            this.rbNewGuid.AutoSize = true;
            this.rbNewGuid.Location = new System.Drawing.Point(241, 86);
            this.rbNewGuid.Name = "rbNewGuid";
            this.rbNewGuid.Size = new System.Drawing.Size(92, 24);
            this.rbNewGuid.TabIndex = 5;
            this.rbNewGuid.TabStop = true;
            this.rbNewGuid.Tag = "C";
            this.rbNewGuid.Text = "New Guid";
            this.rbNewGuid.UseVisualStyleBackColor = true;
            this.rbNewGuid.CheckedChanged += new System.EventHandler(this.RbPrimary_CheckedChanged);
            // 
            // rbNewId
            // 
            this.rbNewId.AutoSize = true;
            this.rbNewId.Location = new System.Drawing.Point(161, 86);
            this.rbNewId.Name = "rbNewId";
            this.rbNewId.Size = new System.Drawing.Size(74, 24);
            this.rbNewId.TabIndex = 4;
            this.rbNewId.Tag = "B";
            this.rbNewId.Text = "New Id";
            this.rbNewId.UseVisualStyleBackColor = true;
            this.rbNewId.CheckedChanged += new System.EventHandler(this.RbPrimary_CheckedChanged);
            // 
            // rbNoIdChange
            // 
            this.rbNoIdChange.AutoSize = true;
            this.rbNoIdChange.Checked = true;
            this.rbNoIdChange.Location = new System.Drawing.Point(41, 86);
            this.rbNoIdChange.Name = "rbNoIdChange";
            this.rbNoIdChange.Size = new System.Drawing.Size(118, 24);
            this.rbNoIdChange.TabIndex = 3;
            this.rbNoIdChange.TabStop = true;
            this.rbNoIdChange.Tag = "A";
            this.rbNoIdChange.Text = "No Id Change";
            this.rbNoIdChange.UseVisualStyleBackColor = true;
            this.rbNoIdChange.CheckedChanged += new System.EventHandler(this.RbPrimary_CheckedChanged);
            // 
            // chkSortFull
            // 
            this.chkSortFull.AutoSize = true;
            this.chkSortFull.Checked = true;
            this.chkSortFull.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSortFull.Location = new System.Drawing.Point(16, 56);
            this.chkSortFull.Name = "chkSortFull";
            this.chkSortFull.Size = new System.Drawing.Size(353, 24);
            this.chkSortFull.TabIndex = 2;
            this.chkSortFull.Text = "Sort All Elements (Complete Sort By Primary Key)";
            this.chkSortFull.UseVisualStyleBackColor = true;
            // 
            // chkDuplicate
            // 
            this.chkDuplicate.AutoSize = true;
            this.chkDuplicate.Checked = true;
            this.chkDuplicate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDuplicate.Location = new System.Drawing.Point(16, 26);
            this.chkDuplicate.Name = "chkDuplicate";
            this.chkDuplicate.Size = new System.Drawing.Size(311, 24);
            this.chkDuplicate.TabIndex = 1;
            this.chkDuplicate.Text = "Remove Duplicates (Based on Primary key)";
            this.chkDuplicate.UseVisualStyleBackColor = true;
            // 
            // chkSort
            // 
            this.chkSort.AutoSize = true;
            this.chkSort.Checked = true;
            this.chkSort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSort.Location = new System.Drawing.Point(16, 116);
            this.chkSort.Name = "chkSort";
            this.chkSort.Size = new System.Drawing.Size(343, 24);
            this.chkSort.TabIndex = 0;
            this.chkSort.Text = "Sort Element Keys (Internal Sort Based On Keys)";
            this.chkSort.UseVisualStyleBackColor = true;
            // 
            // grpDemo
            // 
            this.grpDemo.Controls.Add(this.txtPrimary);
            this.grpDemo.Controls.Add(this.txtRoot);
            this.grpDemo.Controls.Add(this.lblPrimary);
            this.grpDemo.Controls.Add(this.lblRoot);
            this.grpDemo.Location = new System.Drawing.Point(12, 183);
            this.grpDemo.Name = "grpDemo";
            this.grpDemo.Size = new System.Drawing.Size(371, 175);
            this.grpDemo.TabIndex = 6;
            this.grpDemo.TabStop = false;
            this.grpDemo.Text = "Variables";
            // 
            // txtPrimary
            // 
            this.txtPrimary.Location = new System.Drawing.Point(19, 122);
            this.txtPrimary.MaxLength = 25;
            this.txtPrimary.Name = "txtPrimary";
            this.txtPrimary.PlaceholderText = "id";
            this.txtPrimary.Size = new System.Drawing.Size(331, 27);
            this.txtPrimary.TabIndex = 3;
            this.txtPrimary.Text = "id";
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(19, 56);
            this.txtRoot.MaxLength = 25;
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.PlaceholderText = "elements";
            this.txtRoot.Size = new System.Drawing.Size(331, 27);
            this.txtRoot.TabIndex = 2;
            this.txtRoot.Text = "elements";
            // 
            // lblPrimary
            // 
            this.lblPrimary.AutoSize = true;
            this.lblPrimary.Location = new System.Drawing.Point(16, 99);
            this.lblPrimary.Name = "lblPrimary";
            this.lblPrimary.Size = new System.Drawing.Size(87, 20);
            this.lblPrimary.TabIndex = 1;
            this.lblPrimary.Text = "Primary Key";
            // 
            // lblRoot
            // 
            this.lblRoot.AutoSize = true;
            this.lblRoot.Location = new System.Drawing.Point(16, 33);
            this.lblRoot.Name = "lblRoot";
            this.lblRoot.Size = new System.Drawing.Size(99, 20);
            this.lblRoot.TabIndex = 0;
            this.lblRoot.Text = "Root Element";
            // 
            // txtProgress
            // 
            this.txtProgress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProgress.Location = new System.Drawing.Point(400, 49);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtProgress.Size = new System.Drawing.Size(322, 336);
            this.txtProgress.TabIndex = 7;
            this.txtProgress.Text = "";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAuthor.Location = new System.Drawing.Point(551, 545);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(171, 20);
            this.lblAuthor.TabIndex = 9;
            this.lblAuthor.Text = "Created By Nhilesh Baua";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::cs_wf_core_json_merger.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(594, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 582);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.grpDemo);
            this.Controls.Add(this.grpProcess);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.linkOutput);
            this.Controls.Add(this.btnSourceFolder);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Json Merge";
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpProcess.ResumeLayout(false);
            this.grpProcess.PerformLayout();
            this.grpDemo.ResumeLayout(false);
            this.grpDemo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog oFolder;
        private System.Windows.Forms.Button btnSourceFolder;
        private System.Windows.Forms.LinkLabel linkOutput;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.RadioButton rbArray;
        private System.Windows.Forms.RadioButton rbObject;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.GroupBox grpProcess;
        private System.Windows.Forms.CheckBox chkDuplicate;
        private System.Windows.Forms.CheckBox chkSort;
        private System.Windows.Forms.GroupBox grpDemo;
        private System.Windows.Forms.TextBox txtPrimary;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.Label lblPrimary;
        private System.Windows.Forms.Label lblRoot;
        private System.Windows.Forms.CheckBox chkSortFull;
        private System.Windows.Forms.CheckBox chkCreateDiffFile;
        private System.Windows.Forms.RichTextBox txtProgress;
        private System.Windows.Forms.RadioButton rbNewGuid;
        private System.Windows.Forms.RadioButton rbNewId;
        private System.Windows.Forms.RadioButton rbNoIdChange;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

