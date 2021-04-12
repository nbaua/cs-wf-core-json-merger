

# cs-wf-core-json-merger
### Simple .Net Core - C# Winforms Application, For Merging Multiple Large JSON files
---
<p align="center">
  <img src="https://github.com/nbaua/cs-wf-core-json-merger/blob/master/screenshots/logo.png?raw=true" alt="Sublime's custom image"/>
</p>

### Why?
Recently I built a online front-end and corresponding mobile app for a project which has a to be performant.
That naturally requires lots of test data, so I generated thousands of test records (Thanks to generatedata.com and mockaroo.com).
Like every tool these two tools also has imposed some limits on generating and downloading the test data, so I have to get them in batches and download them as different files. 

Ahh, nobody let me download 1Ml 🚀 test records for free. 
That's Why ....

``This tool is useful for just merging the JSON files, it is not a faker or random data generator.``

### Preview 
![App in Action](https://github.com/nbaua/cs-wf-core-json-merger/blob/master/screenshots/app-snap.png)

#### Features
+ Merge Multiple JSON files with same schema/structure
+ Supports merging both Object root nodes as well as Array root nodes
+ Allows identifier configuration for Root Element (node) and Primary Key (id)
+ Supports removal of duplicates based on the Primary Key configuration
	+ CAUTION: if files have different data but the primary keys are same, do NOT use this option, because the data would be lost, while merging.
+ Supports sorting of all JSON elements after merging
	+ While sorting, user can regenerate the new sequential id or a random Guid
	+ CAVEAT: While regenerating the new Guid, the sorted sequence will get distorted due to randomizer, you might want to sort the merged file once again. (see todo section).
+ Supports each element level sorting of key-value pairs based on the alphabetical ascending order. 
+ Generate different merge files for each steps performed, useful for debugging/little backup.
+ Logs time taken for each step, if you're keen.

#### BETA features (lots of testing required yet)
+ Supports merging of deeply nested JSONs with same structure (tested up to 5 levels).
+ Supports merging of different schema/structure with matching root nodes.
+ Supports each element level sorting of nested objects schema/structure.

#### TODO features
+ After regenerating Guid the sort sequence needs to be re-sorted.
+ Add more configurations for customizing the output.
+ In few tests the generated element level sorts does not work with nested objects, which works well with top level nodes (specifically with dates in JSON string format).

#### STEP to compare
![Compare Results](https://github.com/nbaua/cs-wf-core-json-merger/blob/master/screenshots/compare.PNG)


###  License

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
##### Use/Extend/Share/Distribute the project for FREE as you wish. Please retain the credits as is while doing so.
