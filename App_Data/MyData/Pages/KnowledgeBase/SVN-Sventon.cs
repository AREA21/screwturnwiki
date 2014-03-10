SVN Sventon
celio|2010/03/11 14:13:44
##PAGE##
<pre>
 summary: [http://www.sventon.org/|Sventon] is a free, open source, web client for browsing Subversion repositories.

==== Add new Project====
* Create new folder in:C:\Program Files (x86)\Atlassian\JIRA 4.0\temp\sventon_config\svn\repositories
* Name of the new folder: <<Projectname>>.<<Customername>>
* Copy the file '''sventon_config.properties''' from one of the existing project and change it to the correct '''SVN URL'''

eg: '''sventon_config.properties'''
@@
 #Mon Nov 09 11:07:12 CET 2009
 useCache=false
 cacheUserPassword=
 repositoryRootUrl=<<svn URL>> i.e. svn\://joshua4/CodeBase/EasyMail
 rssTemplateFile=/rsstemplate.html
 allowZipDownloads=true
 mailTemplateFile=/mailtemplate.html
 enableEntryTray=true
 enableAccessControl=true
 repositoryDisplayRootUrl=<<svn URL>> 	i.e. svn\://joshua4/CodeBase/EasyMail
 cacheUserName=
 userName=
 enableIssueTrackerIntegration=false
 rssItemsCount=20
 userPassword=
@@

* At last, to see the changes '''Atlassian Jira''' Windows service must be restarted!! This because Sventon runs on Apache Tomcat together with Jira.

* [http://wiki.sventon.org/index.php?n=Main.FAQ#q20090119-4|Sventon FAQ]
</pre>
