KnowledgeBase Index
procm|2016/09/27 11:18:27
##PAGE##
{TOC}

== Infra/Systems==

=== Servers, Clients & services===
<PRE>
* [Windows_OS|Windows OS'es]
** [Workspace-Management|Workspace Management]

* [Windows-Containers_and_Docker| '''Windows Containers & Docker''']

* [Virtualization|Virtualization & High Availability]
** [PerformanceTuningAndBestPratices|Performance, Tuning & BestPratices]

* [Email_Clients-Servers|Email Clients & Servers]

* [http://www.appassure.com/recorded-demos|Dell AppAssure Backup, Replication & Recovery Product Demo Videos]
</PRE>{TOP}

=== Cloud services===
<PRE>
[http://blog.webspecia.com/cloud/iaas-paas-saas-explained-examples-comparison|Iaas Paas Saas explained!]

((('''IaaS'''('''I'''nfrastructure '''a'''s '''a''' '''S'''ervice) vs '''PaaS'''('''P'''latform '''a'''s '''a''' '''S'''ervice)

In an '''IaaS''' model, the vendor only provides the underlying infrastructure, including network, storage, compute resources and virtualization technology. 
In this model, your developers still have a whole lot of operational work. They may get an operating system, but they still have to manually configure, 
manage and update numerous components.

In a '''PaaS''' model, the vendor not only provides the underlying infrastructure resources but also the application development platform. This platform 
includes the automation to deploy, test and iterate applications. Operating systems, databases, middleware and up-to-date tools and services are all 
provided by the PaaS vendor, so time-consuming operational tasks such as configuring, optimizing and continuously updating your environment are handled 
on your behalf.)))
</PRE>
{TOP}

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
* [http://msdn.microsoft.com/en-us/library/ms537361(VS.85).aspx|Introduction to Code Signing (MSDN)]
* [KB_QualityAndService|Quality & Service(test/installation/deploymentplan)]

=== Authentication/ Authorization===
<PRE>
* [https://scotch.io/tutorials/the-ins-and-outs-of-token-based-authentication|Token based authentication is prominent everywhere on the web nowadays!]

==== SSL Certificates====
* [https://msdn.microsoft.com/en-us/library/system.exception.aspx|Exception Class]
* [https://docs.asp.net/en/latest/fundamentals/error-handling.html|Error Handling fundamentals]

* [https://blogs.msdn.microsoft.com/kaushal/2013/08/02/ssl-handshake-and-https-bindings-on-iis|'''SSL Handshake and HTTPS Bindings +++''']

* [https://www.digicert.com/ssl.htm|What is SSL (Secure Sockets Layer) & What are SSL Certificates?]

* [https://www.globalsign.com/en/ssl-information-center/types-of-ssl-certificate| SSL Certificates Types]
## '''D'''omain '''V'''alidation
## '''O'''rganization '''V'''alidation
## '''E'''xtended '''V'''alidation
## Multi Domain & Wildcard, [http://en.wikipedia.org/wiki/Server_Name_Indication|'''SNI''' (cheaper) alternative to wildcard(*) certificates]

* [https://www.sslshopper.com/article-most-common-openssl-commands.html|Common OpenSSL commands)]
* [http://serverfault.com/questions/9708/what-is-a-pem-file-and-how-does-it-differ-from-other-openssl-generated-key-file|SSL Extensions]
** PKI '''X.509''' - Public Key Infrastructure 
** PKCS 12 or P12, [http://en.wikipedia.org/wiki/PKCS_12]
*** It is commonly used to bundle a '''private key''' with its '''X.509''' certificate or to bundle all the members of a chain of trust.

((('''SSL''' (Secure Sockets Layer) is the standard security technology for establishing an encrypted link between a web server and a browser. 
This link ensures that all data passed between the web server and browsers remain private and integral. SSL is an industry standard and is 
used by millions of websites in the protection of their online transactions with their customers.

To be able to create an SSL connection a web server requires an SSL Certificate. When you choose to activate SSL on your web server you will 
be prompted to complete a number of questions about the identity of your website and your company. Your web server then creates two cryptographic 
keys - a Private Key and a Public Key.

The Public Key does not need to be secret and is placed into a Certificate Signing Request (CSR) - a data file also containing your details. 
You should then submit the CSR. During the SSL Certificate application process, the Certification Authority will validate your details and issue 
an SSL Certificate containing your details and allowing you to use SSL. Your web server will match your issued SSL Certificate to your Private Key. 
Your web server will then be able to establish an encrypted link between the website and your customer's web browser.

The complexities of the SSL protocol remain invisible to your customers. Instead their browsers provide them with a key indicator to let them know 
they are currently protected by an SSL encrypted session - the lock icon in the lower right-hand corner, clicking on the lock icon displays your SSL 
Certificate and the details about it. All SSL Certificates are issued to either companies or legally accountable individuals.

Typically an SSL Certificate will contain your domain name, your company name, your address, your city, your state and your country. 
It will also contain the expiration date of the Certificate and details of the Certification Authority responsible for the issuance of the Certificate. 
When a browser connects to a secure site it will retrieve the site's SSL Certificate and check that it has not expired, it has been issued by a 
Certification Authority the browser trusts, and that it is being used by the website for which it has been issued. If it fails on any one of these 
checks the browser will display a warning to the end user letting them know that the site is not secured by SSL.

Be sure to visit [http://www.SSLTools.com] for some great services and tools to assist in your implementation of ssl on your site or if you want to examine the 
ssl certificates of other websites.)))
</PRE>{TOP}

=== Building & Deploy===
<PRE>
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
</PRE>{TOP}

=== Version Control===
<PRE>
* [SVN-Branches|SVN Branches]
* [SVN-Sventon|SVN Sventon]
</PRE>{TOP}

=== IIS (Internet Information Services)===
<PRE>
* [http://www.iis.net/learn|IIS Learn]
** [http://www.iis.net/configreference|IIS Configuration Reference]
** [http://www.iis.net/learn/get-started/planning-your-iis-architecture/introduction-to-applicationhostconfig|Introduction to ApplicationHost.config]
** [http://www.iis.net/learn/publish/using-webdav/how-to-configure-webdav-settings-using-appcmd|How-to Configure WebDAV Settings Using AppCmd]

* [http://support.microsoft.com/kb/943891|HTTP status code in IIS 7.0, IIS 7.5, and IIS 8.0]

* [http://content5.catalog.video.msn.com/e2/ds/e4bfca63-55f2-48c0-a7d0-1fec6deb824f.mp4|'''Troubleshooting''' Unexpected Issues]
** '''Default log files location''': %systemroot%\system32\logfiles\HTTPERR

* [http://www.iis.net/expand/All|'''IIS extentions''']
* [http://learn.iis.net/page.aspx/150/understanding-sites-apps-and-vdirs-in-iis-7/|'''IIS7'''- Sites, Applications & Virtual dirs]

* older '''IIS'''
** [IIS-6-Deploying-and-configuring-a-new-website|IIS6 Deploying and configuring a new website]
** [IIS-6-Deploying-and-configuring-a-new-website-into-a-virtual-directory|IIS6 Deploying and configuring a new website into a virtual directory]
** [IIS-6-Deploying-an-url-forward|IIS6 Deploying an url-forward]
** [IIS6-Add-AWStats|IIS6 Add AWStats to a website]
** [IIS6-Support-for-Ms-Office2007|IIS6 Support for Ms Office2007]

==== What is "pass-through authentication" in IIS?====
* Normally, IIS would use the '''process identity''' (the user account it is running the worker process as) to access protected resources like file system or network.
* With '''passthrough authentication''', IIS will attempt to use the actual identity of the user when accessing protected resources.
** If the user is not authenticated, IIS will use the '''application pool''' identity instead. If pool identity is set to '''NetworkService''' or '''LocalSystem''', the actual Windows account used is the computer account.
* The actual check will be performed at execution time, and if it fails, it'll show up in the log.
</PRE>{TOP}

=== JS/Text Libraries===
<PRE>
* JavaScript 
** [http://jquery.com|JQuery]
** [http://developer.yahoo.com/yui|YUI Library]
** [http://www.huddletogether.com/projects/lightbox2/|Lightbox]
* other(s)
** [Text-Resize-javascript|Text Resize]
** [^http://www.dhtmlgoodies.com|DHTML Goodies]
** [Cufon-Fast-text-replacement-with-canvas-and-VML|Cufon - Fast text replacement with canvas and VML]
</PRE>{TOP}

</PRE>
{TOP}

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
* [https://nl.pinterest.com/pin/46443439882222412|The ultimate cheat sheet of (technical) cheat sheets]
** [http://www.gegeek.com/documents/649546B630371346316B2DAAD5D323C7F7B73A14.html|--The ultimate cheat sheet of (technical) cheat sheets--]
</PRE>

== '''FAQ'''==
(((
=== Linking Issues: the magic URL trailing Slashes===
* [http://webmasters.stackexchange.com/questions/35643/is-trailing-slash-automagically-added-on-click-of-home-page-url-in-browser|Is trailing slash automagically added on click of home page URL in browser?]
* [http://www.searchenginejournal.com/linking-issues-why-a-trailing-slash-in-the-url-does-matter/13021/|Why a Trailing Slash in the URL Does Matter]
* [http://sebastians-pamphlets.com/thou-must-not-steal-the-trailing-slash-from-my-urls/#why-stealing-slashes-is-plain-robbery|Stealing the trailing slash(/) from the URL]

* Firefox: Add a trailing slash to urls again
** Type '''about:config''' into the address bar and hit enter.
*** Confirm that you will be careful if you load the page for the first time.
** Type in the Search box: '''browser.urlbar.trimURLs'''
*** Double-click the entry to set it to false

=== How to check which IIS (Internet Information Version) version the server is using?===
* launch '''IIS Manager''' -> Help -> About Internet Information  Services
* run '''Regedit''' & look for key value: '''HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\InetStp\VersionString''' eg.: 7.5. 


=== How-to generate a Certificate Signing Request (CSR)?===
* [https://knowledge.verisign.com/support/ssl-certificates-support/index?page=content&actp=CROSSLINK&id=SO21228|Certificate Signing Request (CSR) Generation Instructions for Microsoft IIS 8]

=== How-to convert Certificates?===
* [https://www.sslshopper.com/ssl-converter.html|SSL converter with OpenSSL commands to Convert SSL Certificates on Your Machine]

=== How-to Change default self-signed-certificate for IIS Express?===
* [http://blogs.iis.net/divyaa/archive/2010/09/23/changing-the-default-self-signed-certificate-for-a-website-in-webmatrix.aspx|Changing default self-signed-certificate for IIS Express]

=== How to correctly set Java environment?===
eg:
* '''PATH'''= C:\Program Files\Java\jdk1.7.0_45\bin
* '''JAVA_HOME'''= C:\Program Files\Java\jdk1.7.0_45
* '''JRE_HOME'''= C:\Program Files\Java\jre7 '''or''' C:\Program Files\Java\jdk1.7.0_45\jre
* '''CLASSPATH'''= %JAVA_HOME%\jre\lib  (Optional! path to JAR files)
** [http://www3.ntu.edu.sg/home/ehchua/programming/howto/environment_variables.html|'''Environment Variables for Java Applications''']

=== Visual Studio IDE===
* [http://www.codeproject.com/Reference/720512/List-of-Visual-Studio-Project-Type-GUIDs|List of Visual Studio Project Type GUIDs]

==== How do I sync the Solution Explorer with the current File in Visual Studio?====
* Tools - Options - Projects and Solutions - General - Track Active Item In Solution Explorer

==== What is the difference in Visual Studio between Build, Rebuild?====
* Build means compile and link only the source files that have changed since the last build, while Rebuild means compile and link all source files regardless of whether they changed or not. Build is the normal thing to do and is faster. 
Sometimes the versions of project target components can get out of sync and rebuild is necessary to make the build successful. In practice, you never need to Clean.

* Build or Rebuild Solution builds or rebuilds all projects in the your solution, while Build or Rebuild builds or rebuilds  the StartUp project, "hello" in the screen shot above. To set the StartUp project, 
right click on the desired project name in the Solution Explorer tab and select Set as StartUp project. The project name now appears in bold. Since the homework solutions typically have only one project, 
Build or rebuild Solution is effectively the same as Build or Rebuild. 

* Compile just compiles the source file currently being edited. Useful to quickly check for errors when the rest of your source files are in an incomplete state that would prevent a successful build of the 
entire project. Ctrl-F7 is the shortcut key for Compile.

==== Where are the Visual Studio Images / icons Library?====
* The Visual Studio 2010 Image Library contains application images that appear in Microsoft Windows, the Office system, Microsoft Visual Studio, and other Microsoft software. 
You can use this set of over 1,000 images to create applications that look visually consistent with Microsoft software. 
** C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\VS2010ImageLibrary\1033\'''VS2010ImageLibrary.zip'''

==== Visual Studio Plugins/Extensions====
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
* e.g: "C:\Program Files (x86)\Mozilla Firefox\firefox.exe" '''-safe-mode''' '''-private-window'''

=== [Mobile|Mobile Hardware/apps (tips & tricks)]===
)))

{TOP}
