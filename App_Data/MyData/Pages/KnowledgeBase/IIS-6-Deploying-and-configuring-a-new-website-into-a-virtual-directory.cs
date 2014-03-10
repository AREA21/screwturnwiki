IIS 6 Deploying and configuring a new website into a virtual directory
devid|2010/02/18 10:16:22
##PAGE##
{toc}


===A. Open IIS 6===
* Log on to the Web server computer as an administrator.
* Click Start, point to '''Settings''', and then click '''Control Panel'''.
* Double-click '''Administrative Tools''', and then double-click '''Internet Services Manager'''.

===1. Creating a new Virtual Directory in IIS 6===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website-into-a-virtual-directory)}iis6_aspnet_01.gif]

* Right-click the '''Web Site''' in the left-hand pane you wish to add a virtual directory and select '''New''' and '''Virtual Directory…'''.

[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website-into-a-virtual-directory)}iis6_aspnet_02.gif]
* After the "Welcome to the Virtual Directory Creation Wizard" screen appears, click '''Next'''.

===2. Name your Virtual Directory===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website-into-a-virtual-directory)}iis6_aspnet_03.gif]

* Enter in a name for your Virtual Directory in the box and press '''Next'''. This name is for reference only and should help you locate your site in IIS Manager.
* Click '''Next'''

===3. Virtual Directory Home Directory===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website-into-a-virtual-directory)}iis6_aspnet_04.gif]

* Either type the path to the folder that is holding the Web site documents or click Browse to select the folder.
* Click '''Next'''

===4. Virtual Directory Access Permissions===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website-into-a-virtual-directory)}iis6_aspnet_05.gif]

* Select the access permissions for the Web site(default: '''Read, Run scripts''').
* Click '''Next'''

===5. Virtual Directory Creation Wizard Completed===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website-into-a-virtual-directory)}iis6_aspnet_06.gif]

* Click '''Finish'''

===6. Configure Virtual Directory properties===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website-into-a-virtual-directory)}iis6_aspnet_07.gif]

* Right click the Virtual Directory and click '''Properties'''

[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website-into-a-virtual-directory)}iis6_aspnet_11.gif]

* Open tab '''Virtual Directory'''
* Check: '''Read, Log visits, Index this resource'''.
* Choose the preferred Aplication pool from the dropdown.
* To add wildcard mappings press '''Configuration'''

===7. Set Default Page===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website-into-a-virtual-directory)}iis6_aspnet_12.gif]

* Open tab '''Documents'''
* Click '''Add''' to add default pages.

===8. Set Framework (ASP.NET websites only)===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website-into-a-virtual-directory)}iis6_aspnet_13.gif]

* Open tab '''ASP.NET'''
* For ASP.NET 2.0 or higher pick 2.xxx from the dropdown

===9. Set Website Permissions===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website-into-a-virtual-directory)}iis6_aspnet_14.gif]

* Right click the Website and click '''Permissions'''
* Make sure the '''IIS User''' has sufficient Read and Write Permissions on the Website folder.





===Finished===




