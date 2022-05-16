{"cells":[{"type":"springcm.Link","source":{"id":"1644fae3-125a-4cc9-8aee-f42979ba41ad","port":"e","selector":"> g:nth-child(1) > g:nth-child(5) > circle:nth-child(5)"},"target":{"id":"42c44e84-f15e-4828-b4a6-8c278d1868ad","port":"w","selector":"> g:nth-child(1) > g:nth-child(3) > circle:nth-child(5)"},"router":{"name":"manhattan","args":{"excludeTypes":["springcm.Group","springcm.Lane"]}},"id":"5c75f653-674b-4689-8686-df8a2d6e906c","z":1000001,"name":{"type":"String","value":"Link 1"},"attrs":{}},{"type":"springcm.Link","source":{"id":"42c44e84-f15e-4828-b4a6-8c278d1868ad","port":"e","selector":"> g:nth-child(1) > g:nth-child(3) > circle:nth-child(8)"},"target":{"id":"1f921b17-515e-4708-b496-8b56a753ecc5","port":"w","selector":"> g:nth-child(1) > g:nth-child(3) > circle:nth-child(5)"},"router":{"name":"manhattan","args":{"excludeTypes":["springcm.Group","springcm.Lane"]}},"id":"59c2212f-ebdc-49d3-84bc-0b36c825f59b","z":1000003,"name":{"type":"String","value":"Link 2"},"attrs":{}},{"type":"springcm.Link","source":{"id":"1f921b17-515e-4708-b496-8b56a753ecc5","port":"e","selector":"> g:nth-child(1) > g:nth-child(3) > circle:nth-child(8)"},"target":{"id":"b505cc51-3b14-428a-8326-69c93226cd2d","port":"w","selector":"> g:nth-child(1) > g:nth-child(3) > circle:nth-child(5)"},"router":{"name":"manhattan","args":{"excludeTypes":["springcm.Group","springcm.Lane"]}},"id":"330e6780-b624-4b9c-aaf6-555c210f252a","z":1000004,"name":{"type":"String","value":"Link 3"},"attrs":{}},{"type":"springcm.Link","source":{"id":"b505cc51-3b14-428a-8326-69c93226cd2d","port":"e","selector":"> g:nth-child(1) > g:nth-child(3) > circle:nth-child(8)"},"target":{"id":"ea3a8243-1f07-417c-a9ae-0d2b9941d19c","port":"w","selector":"> g:nth-child(1) > g:nth-child(3) > circle:nth-child(5)"},"router":{"name":"manhattan","args":{"excludeTypes":["springcm.Group","springcm.Lane"]}},"id":"183890eb-9cef-4839-8657-770354af7681","z":1000005,"name":{"type":"String","value":"Link 4"},"attrs":{}},{"type":"springcm.Link","source":{"id":"ea3a8243-1f07-417c-a9ae-0d2b9941d19c","port":"e"},"target":{"id":"f8587ba0-7640-4455-b257-228e271694a8","port":"w","selector":"> g:nth-child(1) > g:nth-child(3) > circle:nth-child(5)"},"router":{"name":"manhattan","args":{"excludeTypes":["springcm.Group","springcm.Lane"]}},"id":"bad8a835-8083-4665-bcd4-67bf115845a8","z":1000006,"name":{"type":"String","value":"Link 5"},"attrs":{}},{"type":"springcm.Link","source":{"id":"f8587ba0-7640-4455-b257-228e271694a8","port":"n","selector":"> g:nth-child(1) > g:nth-child(3) > circle:nth-child(2)"},"target":{"id":"96e158b0-e19d-4038-87f0-d2b3e357562a","port":"e","selector":"> g:nth-child(1) > g:nth-child(3) > circle:nth-child(8)"},"router":{"name":"manhattan","args":{"excludeTypes":["springcm.Group","springcm.Lane"]}},"id":"cc8c534d-077f-4453-bfda-53a0982e54ba","z":1000008,"name":{"type":"String","value":"Link 6"},"vertices":[],"description":{"type":"String","value":""},"output":{"type":"Reference","value":"de6638c9-80af-4dc4-93d1-5425278b5772"},"attrs":{}},{"type":"springcm.Link","source":{"id":"f8587ba0-7640-4455-b257-228e271694a8","port":"e","selector":"> g:nth-child(1) > g:nth-child(3) > circle:nth-child(8)"},"target":{"id":"c34b95df-ecbd-41ec-96d9-383645671d39","port":"w","selector":"> g:nth-child(1) > g:nth-child(5) > circle:nth-child(4)"},"router":{"name":"manhattan","args":{"excludeTypes":["springcm.Group","springcm.Lane"]}},"id":"2dd8a54e-4e41-4bef-8f1f-70aaff43ab58","z":1000010,"name":{"type":"String","value":"Link 8"},"vertices":[],"description":{"type":"String","value":""},"output":{"type":"Reference","value":"7a8453dc-646d-4111-bbda-d037146d3921"},"attrs":{}},{"size":{"width":100,"height":100},"content":"","type":"springcm.Circle","position":{"x":86,"y":70},"angle":0,"activityName":"StartActivity","group":"hidden","icon":{"path":"start.svg#Dark","color":"white"},"z":2000001,"id":"1644fae3-125a-4cc9-8aee-f42979ba41ad","name":{"type":"String","value":"Start"},"definedVariables":{"type":"Variable","value":[{"type":"User","value":{"name":"SubmittedBy","displayName":"Submitted By","description":"","displayType":"Actor","schema":{"name":"UserAccount","nodes":[{"name":"Name","dataType":"string","type":"element","guid":"a2efbce4-d1c5-4044-80fb-4b9d1c0d127d"},{"name":"CreatedDate","dataType":"dateTime","type":"element","guid":"2cd2ff12-4a61-428c-990b-adad02760dc8"},{"name":"Email","dataType":"string","type":"element","guid":"6760360b-c56c-4072-a12f-b1d1c1d767e1"},{"name":"FirstName","dataType":"string","type":"element","guid":"f8a1dee1-7214-48f5-9701-541ccacbe0ab"},{"name":"LastName","dataType":"string","type":"element","guid":"a3002636-62e2-496a-b993-886b1ecf0230"},{"name":"ManagerUid","dataType":"string","type":"element","guid":"d4dbc52c-7b87-4a68-bfe0-5fdf35deb2ff"},{"name":"Role","dataType":"string","type":"element","guid":"c64c945c-f3f4-45bc-bd1e-31fa6d0e11b0"},{"name":"Uid","dataType":"string","type":"element","guid":"d043a374-fde2-4126-a9c1-59d6cac5fa3c"},{"name":"Language","dataType":"string","type":"element","guid":"0163f1a8-324c-402f-bb02-eacf3f3db474"},{"name":"Region","dataType":"string","type":"element","guid":"4e3449b3-7f34-4e39-a1d4-d6930cd8a8f5"}]},"sortable":false,"editable":false,"editableValue":false,"deletable":false,"draggable":true,"preDefined":true}},{"type":"String","value":{"name":"Comments","displayName":"Comments","description":"","displayType":"Text","schema":{},"sortable":false,"editable":false,"editableValue":true,"deletable":false,"draggable":true,"preDefined":false}},{"type":"System","value":{"name":"Date","displayName":"Current Date","description":"","displayType":"System","schema":{},"sortable":false,"editable":false,"editableValue":false,"deletable":false,"draggable":true,"preDefined":true}},{"type":"System","value":{"name":"Time","displayName":"Current Time","description":"","displayType":"System","schema":{},"sortable":false,"editable":false,"editableValue":false,"deletable":false,"draggable":true,"preDefined":true}},{"type":"System","value":{"name":"Link","displayName":"Current Step Link","description":"","displayType":"System","schema":{},"sortable":false,"editable":false,"editableValue":false,"deletable":false,"draggable":true,"preDefined":true}},{"type":"System","value":{"name":"LastAbortEmail","displayName":"Last Abort Email","description":"","displayType":"System","schema":{},"sortable":false,"editable":false,"editableValue":false,"deletable":false,"draggable":true,"preDefined":true}},{"type":"Xml","value":{"name":"ParentFolder","displayName":"ParentFolder","description":"","displayType":"Folder","schema":{"nodes":[{"name":"Folders","nodes":[{"name":"Folder","nodes":[{"name":"Id","dataType":"string","type":"element","guid":"879be288-8665-4659-8315-0c4bfa6e34c0"},{"name":"Description","dataType":"string","type":"element","guid":"3c2f8d5c-b853-4103-9a8a-ff8446c1891d"},{"name":"Name","dataType":"string","type":"element","guid":"5156ae5e-5ab1-49c4-88ec-5db0af45fadf"},{"name":"ParentFolderId","dataType":"string","type":"element","guid":"c11c663b-a990-481a-8b53-79db860c686d"},{"name":"CreatedBy","dataType":"string","type":"element","guid":"cf7fdc27-4f21-4643-9cd0-9acdf6f82b8b"},{"name":"CreatedDate","dataType":"dateTime","type":"element","guid":"5f77e28a-03ec-4a8d-aae4-95d644930356"},{"name":"BrowseFolderURL","dataType":"string","type":"element","guid":"4ecded15-6249-4dbf-900d-11971e71c049"}],"guid":"164851fd-1b5a-48ca-8a5f-c3f8cf1da089"}],"guid":"94ad113a-4aeb-40fd-bc15-d26c54b75399"}]},"sortable":true,"editable":true,"editableValue":true,"deletable":true,"draggable":true,"preDefined":false,"isContent":false,"isLocal":false}},{"type":"String","value":{"name":"FolderName","displayName":"FolderName","description":"","displayType":"Text","schema":{},"sortable":true,"editable":true,"editableValue":true,"deletable":true,"draggable":true,"preDefined":false}},{"type":"Number","value":{"name":"ROWID","displayName":"ROWID","description":"","displayType":"Number","schema":{},"sortable":true,"editable":true,"editableValue":true,"deletable":true,"draggable":true,"preDefined":false}}]},"workflowName":{"type":"String","value":"Bulk Folder Creation"},"sendNotification":{"type":"Bool","value":false},"trackActivity":{"type":"Bool","value":true},"attrs":{".steptext":{"ref-y":".66","y-alignment":"middle","text":"Start","lineHeight":"1.4em"},"use":{"xlink:href":"/atlassupport/scripts/jointjs/svg/start.svg#Dark"},"svg":{"color":"white"},"circle":{"fill":"#A0CC23"}}},{"size":{"width":100,"height":100},"content":"","type":"springcm.Step","position":{"x":261,"y":73},"angle":0,"activityName":"FindFolderActivity","group":"engineActivities","icon":{"path":"find_folder.svg#Dark","color":"#E98824"},"id":"42c44e84-f15e-4828-b4a6-8c278d1868ad","z":2000002,"name":{"type":"String","value":"Find Folder 1"},"stepDescription":{"type":"String","value":""},"folders":{"type":"Folder","value":[{"type":"Guid","value":"a1f6e006-4ad5-ec11-b823-48df378a7098"}]},"outputFolders":{"type":"Variable","value":{"type":"Xml","value":"ParentFolder"}},"attrs":{".steptext":{"ref-y":".66","y-alignment":"middle","text":"Find Folder 1","lineHeight":"1.4em"},".description":{"opacity":0,"ref":".step-container","ref-x":0.5,"ref-dy":0},".descriptionbox":{"width":0,"height":0,"rx":0,"ry":0,"x":0,"y":0},".descriptiontext":{"text":""},"use":{"xlink:href":"/atlassupport/scripts/jointjs/svg/find_folder.svg#Dark"},"svg":{"color":"#E98824","fill":"#fff"},"rect":{"fill":"#E98824"},".step-container":{"data-error-state":false}}},{"size":{"width":100,"height":100},"content":"","type":"springcm.Step","position":{"x":649,"y":74},"angle":0,"activityName":"UpdateVariableFromCSVActivity","group":"engineActivities","icon":{"path":"update_xml_variable_from_csv.svg#Dark","color":"#d13393"},"id":"b505cc51-3b14-428a-8326-69c93226cd2d","z":2000003,"name":{"type":"String","value":"Update Variable From CSV 1"},"stepDescription":{"type":"String","value":""},"documents":{"type":"Document","value":[{"type":"Guid","value":"786168fd-70d5-ec11-b823-48df378a7098"}]},"fieldId":{"type":"String","value":"Name"},"fieldValue":{"type":"Expression","value":{"code":"GetVariableValue(\"ROWID\");","returnType":"System.Object","additionalCode":""}},"variableUpdates":{"type":"VariableUpdate","value":[{"variableToConfigure":{"type":"Variable","value":{"type":"String","value":"FolderName"}},"variableValue":{"type":"Variable"}}]},"attrs":{".steptext":{"ref-y":".66","y-alignment":"middle","text":"Update Variable\nFrom CSV 1","lineHeight":"1.4em"},".description":{"opacity":0,"ref":".step-container","ref-x":0.5,"ref-dy":0},".descriptionbox":{"width":0,"height":0,"rx":0,"ry":0,"x":0,"y":0},".descriptiontext":{"text":""},"use":{"xlink:href":"/atlassupport/scripts/jointjs/svg/update_xml_variable_from_csv.svg#Dark"},"svg":{"color":"#d13393","fill":"#fff"},"rect":{"fill":"#d13393"},".step-container":{"data-error-state":false}}},{"size":{"width":100,"height":100},"content":"","type":"springcm.Step","position":{"x":450,"y":74},"angle":0,"activityName":"UpdateVariableActivity","group":"engineActivities","icon":{"path":"update_variable_value.svg#Dark","color":"#d13393"},"id":"1f921b17-515e-4708-b496-8b56a753ecc5","z":2000004,"name":{"type":"String","value":"Update Variable Value 1"},"stepDescription":{"type":"String","value":""},"notifyOnException":{"type":"Bool","value":true},"variableUpdates":{"type":"VariableUpdate","value":[{"variableToConfigure":{"type":"Variable","value":{"type":"Number","value":"ROWID"}},"variableValue":{"type":"String","value":"1"}}]},"attrs":{".steptext":{"ref-y":".66","y-alignment":"middle","text":"Update Variable\nValue 1","lineHeight":"1.4em"},".description":{"opacity":0,"ref":".step-container","ref-x":0.5,"ref-dy":0},".descriptionbox":{"width":0,"height":0,"rx":0,"ry":0,"x":0,"y":0},".descriptiontext":{"text":""},"use":{"xlink:href":"/atlassupport/scripts/jointjs/svg/update_variable_value.svg#Dark"},"svg":{"color":"#d13393","fill":"#fff"},"rect":{"fill":"#d13393"},".step-container":{"data-error-state":false}}},{"size":{"width":100,"height":100},"content":"","type":"springcm.Step","position":{"x":854,"y":75},"angle":0,"activityName":"CreateFolderActivity","group":"engineActivities","icon":{"path":"create_folder.svg#Dark","color":"#e98824"},"id":"ea3a8243-1f07-417c-a9ae-0d2b9941d19c","z":2000005,"name":{"type":"String","value":"Create Folder 1"},"stepDescription":{"type":"String","value":""},"newFolder":{"type":"Expression","value":{"code":"GetVariableValue(\"FolderName\");","returnType":"System.Object","additionalCode":""}},"description":{"type":"String","value":""},"parentFolder":{"type":"Folder","value":[{"type":"Variable","value":{"type":"Xml","value":"ParentFolder"}}]},"returnExisting":{"type":"Bool","value":true},"inheritLimitedAttributeGroups":{"type":"Bool","value":false},"outputFolders":{"type":"Variable"},"limitedAttributeGroups":{"type":"MetadataGroup"},"attrs":{".steptext":{"ref-y":".66","y-alignment":"middle","text":"Create Folder 1","lineHeight":"1.4em"},".description":{"opacity":0,"ref":".step-container","ref-x":0.5,"ref-dy":0},".descriptionbox":{"width":0,"height":0,"rx":0,"ry":0,"x":0,"y":0},".descriptiontext":{"text":""},"use":{"xlink:href":"/atlassupport/scripts/jointjs/svg/create_folder.svg#Dark"},"svg":{"color":"#e98824","fill":"#fff"},"rect":{"fill":"#e98824"},".step-container":{"data-error-state":false}}},{"size":{"width":93,"height":93},"type":"springcm.Diamond","content":"","position":{"x":1034,"y":82},"angle":0,"activityName":"DecisionActivity","group":"engineActivities","icon":{"path":"rule.svg#Dark","color":"#29bdbe"},"id":"f8587ba0-7640-4455-b257-228e271694a8","z":2000008,"name":{"type":"String","value":"Decision 1"},"stepDescription":{"type":"String","value":""},"decisions":{"type":"Decisions","value":{"decisions":[{"condition":{"conditions":[{"leftOperand":{"type":"Variable","value":{"type":"String","value":"FolderName"}},"comparisonOperator":"equals","guid":"7e62d4a7-f516-4643-9eb7-8cefea88c326"}],"logicalOperator":"","guid":"983888ff-1e1b-489c-a5cf-d5126674ac0a"},"output":{"type":"Output","value":{"name":"Complete","referenceKey":"7a8453dc-646d-4111-bbda-d037146d3921"}}}],"elseOutput":{"type":"Output","value":{"name":"Incomplete","referenceKey":"de6638c9-80af-4dc4-93d1-5425278b5772"}}}},"outputDecision":{"type":"Variable"},"attrs":{".step-container":{"data-error-state":false},".steptext":{"ref-y":".66","y-alignment":"middle","text":"Decision 1","lineHeight":"1.4em"},".description":{"opacity":0,"ref":".step-container","ref-x":0.5,"ref-dy":0},".descriptionbox":{"width":0,"height":0,"rx":0,"ry":0,"x":0,"y":0},".descriptiontext":{"text":""},"use":{"xlink:href":"/atlassupport/scripts/jointjs/svg/rule.svg#Dark"},"svg":{"color":"#29bdbe","fill":"#fff"},"rect":{"fill":"#29bdbe"}}},{"size":{"width":100,"height":100},"content":"","type":"springcm.Step","position":{"x":651,"y":-122},"angle":0,"activityName":"UpdateVariableActivity","group":"engineActivities","icon":{"path":"update_variable_value.svg#Dark","color":"#d13393"},"id":"96e158b0-e19d-4038-87f0-d2b3e357562a","z":2000009,"name":{"type":"String","value":"Update Variable Value 2"},"stepDescription":{"type":"String","value":""},"notifyOnException":{"type":"Bool","value":true},"variableUpdates":{"type":"VariableUpdate","value":[{"variableToConfigure":{"type":"Variable","value":{"type":"Number","value":"ROWID"}},"variableValue":{"type":"Expression","value":{"code":"GetVariableValue(\"ROWID\") + 1;","returnType":"System.Object","additionalCode":""}}}]},"attrs":{".steptext":{"ref-y":".66","y-alignment":"middle","text":"Update Variable\nValue 2","lineHeight":"1.4em"},".description":{"opacity":0,"ref":".step-container","ref-x":0.5,"ref-dy":0},".descriptionbox":{"width":0,"height":0,"rx":0,"ry":0,"x":0,"y":0},".descriptiontext":{"text":""},"use":{"xlink:href":"/atlassupport/scripts/jointjs/svg/update_variable_value.svg#Dark"},"svg":{"color":"#d13393","fill":"#fff"},"rect":{"fill":"#d13393"},".step-container":{"data-error-state":false}}},{"size":{"width":100,"height":100},"content":"","type":"springcm.Circle","position":{"x":1279,"y":79},"angle":0,"activityName":"EndActivity","group":"engineActivities","icon":{"path":"finish.svg#Dark","color":"white"},"id":"c34b95df-ecbd-41ec-96d9-383645671d39","z":2000010,"name":{"type":"String","value":"Finish 1"},"stepDescription":{"type":"String","value":""},"attrs":{".circle-container":{"fill":"#29bdbe","class":"circle-container theme_primary_fill"},".steptext":{"ref-y":".66","y-alignment":"middle","text":"Finish 1","lineHeight":"1.4em"},"use":{"xlink:href":"/atlassupport/scripts/jointjs/svg/finish.svg#Dark"},"svg":{"color":"white"}}},{"type":"springcm.Link","source":{"id":"96e158b0-e19d-4038-87f0-d2b3e357562a","port":"s","selector":"> g:nth-child(1) > g:nth-child(3) > circle:nth-child(11)"},"target":{"id":"b505cc51-3b14-428a-8326-69c93226cd2d","port":"n","selector":"> g:nth-child(1) > g:nth-child(3) > circle:nth-child(2)"},"router":{"name":"manhattan","args":{"excludeTypes":["springcm.Group","springcm.Lane"]}},"id":"5737dee5-085c-4f30-8e77-e738795903e2","z":3000001,"name":{"type":"String","value":"Link 7"},"vertices":[],"description":{"type":"String","value":""},"output":{"type":"String","value":""},"attrs":{}}]}
