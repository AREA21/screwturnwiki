KnowledgeBase Index
procm|2014/07/09 17:12:54
##PAGE##
{TOC}

== Infra/Systems==

=== Servers, Clients & services===
<PRE>
* [Windows_OS|Windows OS'es]
** [Workspace-Management|Workspace Management]
* [Virtualization|Virtualization & High Availability]
** [PerformanceTuningAndBestPratices|Performance, Tuning & BestPratices]
* [Email_Clients-Servers|Email Clients & Servers]
* [http://www.appassure.com/recorded-demos|Dell AppAssure Backup, Replication & Recovery Product Demo Videos]
</PRE>{TOP}

== Databases==
<PRE>
=== [Database|Database development]===

=== [MS-SQL-Troubleshooting|MsSQL troubleshooting]===

=== Resources:===
* [http://en.wikipedia.org/wiki/Microsoft_SQL_Server|Microsoft SQL Server Release History]
* [http://www.microsoft.com/sqlserver/en/us/product-info/compare.aspx|Microsoft SQL Edition Comparison]
* [http://www.mssqlcity.com/Tips.htm|SQL Server Optimization Tips] 
* [http://www.databasejournal.com/features/article.php/3593466/MS-SQL-Series.htm|Database Journal, featured articles]
</PRE>{TOP}

== Development==
<PRE>
* [ASP_DotNET-MVC|ASP.NET MVC]
* [http://www.boost.org/doc/libs/1_54_0/libs/regex/doc/html/index.html|Reference: Boost, Perl based Regular Expression]
* [http://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx|Custom Date and Time Format Strings]
* [DotNET-Chart-Controls|Charts & Data Visualization in ASP.NET]
* [KB_Development_Guidelines|Web Development Guidelines ]
* [Ogone-Payment-Service-Provider|Implementing Ogone Payment Service Provider]
* [http://apparch.codeplex.com/|Application Architecture (CodePlex content)]
* [http://msdn.microsoft.com/en-us/library/ms537361(VS.85).aspx| Introduction to Code Signing (MSDN)]
* [KB_QualityAndService|Quality & Service(test/installation/deploymentplan)]

=== Building & Deploy===
* [Building-And-Publishing-Projects|Building & Publishing Projects]
** [Build-NAnt|Build NAnt]
** [MSBuild|MSBuild]
* [http://drewby.com/using-web-deploy-to-sync-your-webmatrix-site|Using WebDeploy to sync your Webmatrix site]

==== Quick start: deploying to '''AppHarbor''', Heroku cloud====
(((<nowiki>
* Getting started
 1. Download and install msysGit
 2. Start Git Bash
 3. git config --global user.name procm (or use your full name)
 4. git config --global user.email procm@hotmail.com
 5. git config --global http.postBuffer 52428800 (optional?)

* New Application?
 1. Create Visual Studio solution with Web Project (eg. ASP.NET MVC 3 template project)
 2. cd path\to\my\solution\folder
 3. git init
 4. git add .
 5. git commit -m "eg.: add template project"

* Add AppHarbor Repository and Push
 1. git remote add appharbor https://procm@appharbor.com/cmo-wiki.git
 2. git push appharbor master
 3. Refresh this page to see your code build
</nowiki>
)))

=== Version Control===
* [SVN-Branches|SVN Branches]
* [SVN-Sventon|SVN Sventon]

=== IIS (Internet Information Services)===
* [http://content5.catalog.video.msn.com/e2/ds/e4bfca63-55f2-48c0-a7d0-1fec6deb824f.mp4|'''Troubleshooting''' Unexpected Issues]
** '''Default log files location''': %systemroot%\system32\logfiles\HTTPERR
* [http://www.iis.net/expand/All|'''IIS extentions''']
* [http://learn.iis.net/page.aspx/150/understanding-sites-apps-and-vdirs-in-iis-7/|'''IIS7'''- Sites, Applications & Virtual dirs]
* older IIS
** [IIS-6-Deploying-and-configuring-a-new-website|IIS6 Deploying and configuring a new website]
** [IIS-6-Deploying-and-configuring-a-new-website-into-a-virtual-directory|IIS6 Deploying and configuring a new website into a virtual directory]
** [IIS-6-Deploying-an-url-forward|IIS6 Deploying an url-forward]
** [IIS6-Add-AWStats|IIS6 Add AWStats to a website]
** [IIS6-Support-for-Ms-Office2007|IIS6 Support for Ms Office2007]

=== JS/Text Libraries===
* JavaScript 
** [http://jquery.com|JQuery]
** [http://developer.yahoo.com/yui|YUI Library]
** [http://www.huddletogether.com/projects/lightbox2/|Lightbox]
* other(s)
** [Text-Resize-javascript|Text Resize]
** [^http://www.dhtmlgoodies.com|DHTML Goodies]
** [Cufon-Fast-text-replacement-with-canvas-and-VML|Cufon - Fast text replacement with canvas and VML]

</PRE> {TOP}

=== '''Troubleshooting'''===
<PRE>
==== [http://support.microsoft.com/kb/892277|ASP.NET using WinDbg and the SOS extension]====

====Windows '''SvcTrace''' Tools:====
* "C:\Program Files\'''Microsoft SDKs'''\Windows\v6.0\Bin"

==== [http://msdn.microsoft.com/en-us/library/ms732015(v=vs.110).aspx|Windows Communication Foundation Tools]====
* Location Path: "C:\Windows\Microsoft.NET\Framework\v3.0\'''W'''indows '''C'''ommunication '''F'''oundation"

</PRE> {TOP}

== '''References, Resources'''==
<PRE>
* [http://www.gegeek.com/documents/649546B630371346316B2DAAD5D323C7F7B73A14.html|The ultimate cheat sheet of (technical) cheat sheets]
</PRE>

== '''FAQ'''==
(((
=== How-to generate a Certificate Signing Request (CSR)?===
* [https://knowledge.verisign.com/support/ssl-certificates-support/index?page=content&actp=CROSSLINK&id=SO21228|Certificate Signing Request (CSR) Generation Instructions for Microsoft IIS 8]

=== How-to convert Certificates?===
* [https://www.sslshopper.com/ssl-converter.html|SSL converter with OpenSSL commands to Convert SSL Certificates on Your Machine]

=== How to correctly set Java environment?===
eg:
* '''PATH'''= C:\Program Files\Java\jdk1.7.0_45\bin
* '''JAVA_HOME'''= C:\Program Files\Java\jdk1.7.0_45
* '''JRE_HOME'''= C:\Program Files\Java\jre7 '''or''' C:\Program Files\Java\jdk1.7.0_45\jre
* '''CLASSPATH'''= %JAVA_HOME%\jre\lib  (Optional! path to JAR files)
** [http://www3.ntu.edu.sg/home/ehchua/programming/howto/environment_variables.html|'''Environment Variables for Java Applications''']

=== How do I sync the Solution Explorer with the current File in Visual Studio?===
* Tools - Options - Projects and Solutions - General - Track Active Item In Solution Explorer

=== What is the difference in Visual Studio between Build, Rebuild?===
* Build means compile and link only the source files that have changed since the last build, while Rebuild means compile and link all source files regardless of whether they changed or not. Build is the normal thing to do and is faster. 
Sometimes the versions of project target components can get out of sync and rebuild is necessary to make the build successful. In practice, you never need to Clean.

* Build or Rebuild Solution builds or rebuilds all projects in the your solution, while Build or Rebuild builds or rebuilds  the StartUp project, "hello" in the screen shot above. To set the StartUp project, 
right click on the desired project name in the Solution Explorer tab and select Set as StartUp project. The project name now appears in bold. Since the homework solutions typically have only one project, 
Build or rebuild Solution is effectively the same as Build or Rebuild. 

* Compile just compiles the source file currently being edited. Useful to quickly check for errors when the rest of your source files are in an incomplete state that would prevent a successful build of the 
entire project. Ctrl-F7 is the shortcut key for Compile.

=== Where are the Visual Studio Images / icons Library?===
* The Visual Studio 2010 Image Library contains application images that appear in Microsoft Windows, the Office system, Microsoft Visual Studio, and other Microsoft software. 
You can use this set of over 1,000 images to create applications that look visually consistent with Microsoft software. 
** C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\VS2010ImageLibrary\1033\'''VS2010ImageLibrary.zip'''


=== Visual Studio Plugins/Extensions===
* [http://www.oz-code.com/convince-my-boss|Road to Magical Debugging]
* [http://www.asp.net/downloads|ASP.NET Official Extentions & Tools]
* [http://visualstudiogallery.msdn.microsoft.com/dbcb8670-889e-4a54-a226-a48a15e4cace|Productivity Powertools]
(((tip: turnoff 'tabs' extension due to 'fix mixed tabs' dialog!)))
* [http://vswebessentials.com/|Web Essentials 2013]
* [http://visualstudiogallery.msdn.microsoft.com/69023d00-a4f9-4a34-a6cd-7e854ba318b5|Slowcheetah, XML Transforms]
** [http://www.hanselman.com/blog/SlowCheetahWebconfigTransformationSyntaxNowGeneralizedForAnyXMLConfigurationFile.aspx|Scott Hanselman, Web.config Transformation Syntax generalized for any XML configuration file]
* [http://vscommands.squaredinfinity.com/features|VScommands]	
	
:'''Resource''': [http://www.cs.tufts.edu/r/graphics/resources/vs_getting_started/vs_getting_started.htm|Getting Started with Visual Studio]

=== [http://developer.mozilla.org/en-US/docs/Mozilla/Command_Line_Options|Mozilla MDN, Command Line Options]===

=== [Mobile|Mobile Hardware/apps (tips & tricks)]===
)))

{TOP}
