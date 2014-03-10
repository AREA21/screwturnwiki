IIS 6 Deploying an url-forward
robvdkamp|2010/03/09 09:09:36
##PAGE##
{toc}

===A. Open IIS 6===
* Log on to the Web server computer as an administrator.
* Click Start, point to '''Settings''', and then click '''Control Panel'''.
* Double-click '''Administrative Tools''', and then double-click '''Internet Services Manager'''.

===1. Deploying and configuring a new website===
Follow the tutorial [IIS-6-Deploying-and-configuring-a-new-website|IIS 6 Deploying and configuring a new website], to create a new website, but skip steps '''9''' and '''10'''.

===2. Enter url to redirect to(Website url)===
[image||{UP(KnowledgeBase.IIS-6-Deploying-an-url-forward)}iis6_redirect_01.gif]

* Open tab '''Home Directory'''
* Click radiobutton '''A redirection to a URL'''
* Enter the url you wish to redirect to.
* Leave the checkboxes unchecked.



===Finished===





===B. Url-forward part II===
* Log on to '''TransIp.nl''' as an administrator.
* Select the domainname you want to forward.
* Click on the '''"DNS instellen"''' button.
* '''Change the ip''' into the Webserver2 ip (87.253.140.61)
* '''Save''' the changes

* Log on to '''webserver2''' as an administrator
* If the website doesn't exist on the webserver (and only needs an url-forward), create an empty folder in D:\Data\Websites\Live\projectname
* Open IIS and follow the tutorial [IIS-6-Deploying-and-configuring-a-new-website|IIS 6 Deploying and configuring a new website], to create a new website, but skip steps '''9''' and '''10'''.

* Open tab '''Home Directory'''
* Click radiobutton '''A redirection to a URL'''
* Enter the url you wish to redirect to.
* Leave the checkboxes unchecked
* Open tab '''Web site'''
* Click on the '''"Advanced" button''' (Website identification)
* '''Add all the identities''' for the website (projectname.com and www.projectname.com)


===Finished===