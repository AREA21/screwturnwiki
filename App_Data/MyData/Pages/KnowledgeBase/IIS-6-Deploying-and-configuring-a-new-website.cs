IIS 6 Deploying and configuring a new website
devid|2010/02/26 10:23:42
##PAGE##
{toc}

===A. Open IIS 6===
* Log on to the Web server computer as an administrator.
* Click Start, point to '''Settings''', and then click '''Control Panel'''.
* Double-click '''Administrative Tools''', and then double-click '''Internet Services Manager'''.

===1. Creating a new Web Site in IIS 6===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website)}iis6_aspnet_01.gif]

* Right-click on '''Web Sites''' in the left-hand pane and select '''New''' and '''Web Site…'''.
* After the "Welcome to the Web Site creation Wizard" screen appears, click '''Next'''.

===2. Name your Web Site===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website)}iis6_aspnet_02.gif]

* Enter in a name for your site in the box and press '''Next'''. This name is for reference only and should help you locate your site in IIS Manager.

===3. Set IP address, port setting, host header===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website)}iis6_aspnet_03.gif]

* Select the IP address to use for the Web Site.
If you select '''All (unassigned)''', the Web Site is accessible on all interfaces and all configured IP addresses.
* Type the TCP port number to publish the site on. (Default: 80)
* Type the Host Header name (the real name that is used to access this site Example: www.mvsd.nl).
* Click '''Next'''

===4. Web Site Home Directory===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website)}iis6_aspnet_04.gif]

* Either type the path to the folder that is holding the Web site documents or click Browse to select the folder.
* To allow all internet users to visit this website, check '''Allow anonymous access to this Web Site'''
* Click '''Next'''

===5. Web Site Access Permissions===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website)}iis6_aspnet_05.gif]

* Select the access permissions for the Web site(default: '''Read, Run scripts''').
* Click '''Next'''

===6. Web Site Creation Wizard Completed===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website)}iis6_aspnet_06.gif]

* Click '''Finish'''

===7. Configure Website properties===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website)}iis6_aspnet_07.gif]

* Right click the Website and click '''Properties'''
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website)}iis6_aspnet_11.gif]

* Open tab '''Home Directory'''
* Check: '''Read, Log visits, Index this resource'''.
* Choose the preferred Aplication pool from the dropdown.
* To add wildcard mappings press '''Configuration'''

===8. Add Host Headers (Website urls)===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website)}iis6_aspnet_08.gif]

* Open tab '''Web Site'''
* Click '''Advanced'''
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website)}iis6_aspnet_09.gif]

* Click Add
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website)}iis6_aspnet_10.gif]

* Select the IP address to use for the Web Site.
If you select '''All (unassigned)''', the Web Site is accessible on all interfaces and all configured IP addresses.
* Type the TCP port number to publish the site on. (Default: 80)
* Type the Host Header name (the real name that is used to access this site Example: www.mvsd.nl).
* Click '''OK'''

===9. Set Default Page===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website)}iis6_aspnet_12.gif]

* Open tab '''Documents'''
* Click '''Add''' to add default pages.

===10. Set Framework (ASP.NET websites only)===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website)}iis6_aspnet_13.gif]

* Open tab '''ASP.NET'''
* For ASP.NET 2.0 or higher pick 2.xxx from the dropdown

===11. Set Website Permissions===
[image||{UP(KnowledgeBase.IIS-6-Deploying-and-configuring-a-new-website)}iis6_aspnet_14.gif]

* Right click the Website and click '''Permissions'''
* Make sure the '''IIS User''' has sufficient Read and Write Permissions on the Website folder.




===Finished===




