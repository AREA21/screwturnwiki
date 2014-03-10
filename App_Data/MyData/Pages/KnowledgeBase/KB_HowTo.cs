KB Howto's
robvdkamp|2010/02/17 15:54:11
##PAGE##
{TOC}

== Troubleshooting==
summary: relevant information when troubleshoot problems about servers, services and other infrasctruur issues.  

=== Servers & services===
* [http://en.wikipedia.org/wiki/RAID#RAID_0| RAID]
* [http://support.microsoft.com/kb/243330| Well-Known Security Identifiers in Windows OS'es]

=== Client PC's===
<PRE>
* MsOutlook
** Clear the MsOutlook Email address Auto Complete cache!
*** Background: Outlook 2003 and Outlook 2007 has a feature called Email Address Auto Complete. As you type in an email address 
into the TO: or CC: field (and BCC: field I imagine) outlook will display a list of matching email addresses from the outlook auto-complete cache.
As convenient as the Auto Complete feature is, there are times when you need to remove these cached email addresses from the cache.
Perhaps you just sent an email and you found out you made a typo…..Unfortunately that typo will remain in you cache until you delete it.
**** '''Solution 1''': The fix is easy:
****# Type the email address you wish to clear from the cache until outlook displays it as shown above. 
****# Press the down arrow key to select the email address and press the delete button.  
**** '''Solution 2''' : Another option if you want to delete all addresses in the cache file (outlook.nk2): 
****# Close Outlook 
****# Open Windows Explorer or IE and Paste %APPDATA%\Microsoft\Outlook into the address bar. 
****# Delete the file Outlook.nk2 file in this folder  
*** '''Solution 2''' is comparable to the the “Nuclear Bomb” being that it will delete ALL your cached email addresses.  
It should only be used if you want to wipe the file clean or if you have corruption issues with your .nk2 file.  Once you delete 
the .nk2 file, the next time you open Outlook it will automatically create a new .nk2 cache file and Outlook will once again begin
caching the email addresses you use.

::: [\\joshua4\Shared\Software\Infractructuur\ICTAdmin\NK2view v.1.43\nk2view.exe|Tool to Manage Ms.Outlook Autocomplete cache] 
</PRE>


<PRE>
* Windows update Problems
** ...execute this command as Administrator: fsutil resource setautoreset true C:\
</PRE>

== WebServers==

=== Emailadressen op de Numloq server aanmaken ===
<pre>
Het ip adres is 87.253.140.61, die moet je dus opgeven bij transip.
Email adressen toevoegen doe je in de hMailServer Administrator (in de hMailServer groep van het 
startmenu).
Als wachtwoord gebruik je Rood42Haar, dan kom je in dit scherm:


Vervolgens, voor een niew domain voeg je deze toe onder de menu optie domains.
1. domains aan klikken en "Add..." doen.
2. domain naam opgeven.
3. Eventueel in advanced een extern catchall adres aangeven

Dan klik je op save (rechts onder) en is deze toegevoegd in de lijst links en meteen geselecteerd
Als je het domain links aan klinkt kan je instellingen (zoals catchall en domain naam zelf) nog 
veranderen.

Adressen toevoegen doe je vervolgens in accounts, waar je een email adres opgeeft en een password 
in tikt.
Ook hier kan je wat extra opties op geven (mailbox limiet en bv. autoreply bij vakantie, of forwards).

Dan hebben we nog aliases, waar je redirections kan toevoegen, bv. een info@ laten forwarden naar een 
bepaalde gebruiker (kan ook een gebruiker zijn op een ander domain).
En als laatste hebben we distribution lists, waar je maillists kan toevoegen (bv. een info@ naar meerdere 
gebruikers. deze voeg je toe bij members)
</pre>
{TOP}



=== FTP account aanmaken (Remote/Hosting)===
<pre>
'''FTP account aanmaken'''
* Ga met Remote desktop naar Webserver1
* Open Filezilla
* Kies Edit > users
* Klik onder users op Add
* Vul een naam in en klik op enter
* In shared folders klik op add
* Kies de juiste map
* Zet de rechten goed
* Ga naar Account settings en vink password aan
* Vul een wachtwoord in en klik op Ok.
</pre>
{TOP}

=== Toevoegen nieuwe website (Remote/Hosting)===
<pre>
#'''Transip'''
#* Ga naar www.Transip.nl en log in
#* Kies domeinen
#* Kies het domein waar je een website voor wil aanmaken
#* Kies achter diensten: primary DNS
#* Pas het A record aan
#* Vervang het ip-adres door ons ip-adres: 80.69.87.136
#* Klik op Ok en klik op Bevestig
#* Sluit Transip af.
#'''Webserver1'''
#* Ga met Remote Desktop naar Webserver1
#* inloggen
#* Windows explorer
#* Ga met Windows explorer naar D:websites
#* Maak een nieuwe map aan met als naam de URL
#* Plaats in die map twee nieuwe mappen: website  en  database
#* Kopieer alles uit de map D:website/placeholder naar de website map in de nieuwe website.
#* Sluit windows explorer
#* Console.msc
#* Ga via Desktop naar Console.msc
#* Kies IIS manager > websites
#* Klik op websites op de rechtermuisknop en kies “new website”
#* In het dialoogscherm:
#* Next > naam invullen > domein.nl > next >
#* Kies browse bij Path en kies de juiste directory
#* Next > next > zet bij permissions run scripts aan
#* Next > finish
#* Klik op de naam van de website de rechter muisknop en kies properties
#* Ga naar tab ASP.NET en kies 2.0 versie
#* Kies dan het tab web site
#* Klik op advanced
#* Klik op Add vul bij TCP 80 in en plaats bij Hostheader: www.domein.nl
#* Klik op Add vul bij TCP 80 in en plaats bij Hostheader: domein.nl
#* Lege header weghalen.
</pre>
{TOP}

=== Site live zetten (Remote/Hosting)===
<pre>
* Kopieer database en website van testsites naar de nieuwe webplek.
* Zet de rechten van de mappen Database, uploads en templates goed
* Pas de webconfig aan.
* Om te testen of het werkt, ga naar: C:\WINDOWS\system32\drivers\etc\hosts
* En vul in: 80.69.87.136 www.domein.com
* Ga naar de cmd-prompt en vul in: ipconfig /flushdns
* Start de nieuwe browser op en test.
</pre>
{TOP}

=== Site deployment (incl. SQL database) op test3.mvsd.nl===
<pre>
[Deployment-van-een-nieuwe-website-incl-SQL-database-op-test3-mvsd-nl|Deployment nieuwe website incl. SQL database op test3.mvsd.nl]
</pre>
{TOP}

=== Deployment bestaande EasyWebEditNet website===
<pre>
[Builden-en-Online-zetten-van-een-bestaande-EasyWebEditNet-website|Deployment bestaande EasyWebEditNet website]
</pre>
{TOP}

=== EasyWebEditNet website opzetten vanuit de Codebase===
<pre>
[zzzzzzzzzzzz|EasyWebEditNet website opzetten vanuit de Codebase]
</pre>
{TOP}


=== IIS support for Ms Office2007===
<pre>
Steps:  
   1. Open Computer Management. (Right-click My Computer... Manage...)
   2. Right-click Internet Information Services (IIS) Management... Properties...
   3. Click MIME Types...
   4. Click New... and add the followings:

Extension       MIME Type
.xlsx       application/vnd.openxmlformats-officedocument.spreadsheetml.sheet
.xltx       application/vnd.openxmlformats-officedocument.spreadsheetml.template
.potx       application/vnd.openxmlformats-officedocument.presentationml.template
.ppsx       application/vnd.openxmlformats-officedocument.presentationml.slideshow
.pptx       application/vnd.openxmlformats-officedocument.presentationml.presentation
.sldx       application/vnd.openxmlformats-officedocument.presentationml.slide
.docx       application/vnd.openxmlformats-officedocument.wordprocessingml.document
.dotx       application/vnd.openxmlformats-officedocument.wordprocessingml.template
.xlam       application/vnd.ms-excel.addin.macroEnabled.12
.xlsb       application/vnd.ms-excel.sheet.binary.macroEnabled.12

N.B.:[http://support.microsoft.com/kb/936496/en-us|These MIME types were added to IIS7 as noted in KB936496.] 
</pre>
{TOP}

=== AWSTATS (web)log analyser===
(((sumary: AWStats is an open source Web analytics reporting tool, suitable for analyzing data from Internet services such as web, streaming media, mail and FTP servers. AWStats parses and analyzes server log files, producing HTML reports. Data is visually presented within reports by tables and bar graphs. Static reports can be created through a command line interface, and on-demand reporting is supported through a web browser CGI program.)))

==== Setup for Microsoft's IIS server====
<pre>

* Step 1:

Configure IIS to create logs in the "Extended W3C log format" 
(You can still use your own custom log format but setup is easier if you use the standard extended format). 
To do so, start the IIS management console snap-in, select the appropriate web site and open its Properties. 
Choose "W3C Extended Log Format", then Properties, then the Tab "Extended Properties" & uncheck everything under Extended Properties. 
Once they are all cleared, check just the following fields:
(((date
time
c-ip
cs-username
cs-method
cs-uri-stem
cs-uri-query
sc-status
sc-bytes
cs-version
cs(User-Agent)
cs(Referer) )))
 

To be sure the log format change is effective, you must stop IIS, backup it up (if you desire) and remove all of the old log files,
restart IIS and go to your homepage. This is an example of the type of records you should find in the new log file:
2000-07-19 14:14:14 62.161.78.73 - GET / 200 1234 HTTP/1.1 Mozilla/4.0+(compatible;+MSIE+5.01;+Windows+NT+5.0) http://www.from.com/from.htm  

* Step 2:

Copy the contents of the AWStats provided cgi-bin folder, from where the AWStats package put it on your local hard drive, 
to your server's cgi-bin directory (this includes awstats.pl, awstats.model.conf, and the lang, lib and plugins sub-directories).

* Step 3:

Move AWStats icon sub-directories and its content into a directory readable by your web server, for example C:\yourwwwroot\icon.

* Step 4:

Create a configuration file by copying awstats.model.conf to a new file named awstats.mysite.conf where "mysite" is a value of your
choice but usually is the domain or virtual host name. This new file must be saved in the same directory as awstats.pl (i.e. cgi-bin).

* Step 5:

Edit your new awstats.mysite.conf file to match your specific environment:

- Change the LogFile value to the full path of your web server log file (You can also use a relative path from your awstats.pl (cgi-bin) directory).

- Change the LogType value to "W" for analyzing web log files.

- Change the LogFormat to 2 if you are using the "Extended W3C log format" described in step 1; in the case of a custom format, list the IIS fields being logged, for example: 
LogFormat="date time c-ip cs-username cs-method cs-uri-stem cs-uri-query sc-status sc-bytes cs-version cs(User-Agent) cs(Referer)"

- Change the DirIcons parameter to reflect relative path of icon directory.

- Set the SiteDomain parameter to the main domain name or the intranet web server name used to reach the web site being analyzed(Example: www.mydomain.com).

- Set the AllowToUpdateStatsFromBrowser parameter to 1 if you don't have command line access and have only cgi access.

- Review and change other parameters if appropriate.

Installation and configuration is finished. You can jump to the Process logs: Building/Updating statistics database section

</pre>

====How implement it on MVSD'sites?====

* Copy the folder "D:\Data\Websites\Components\stats" into the website folder.
* Open the file "D:\Data\Websites\Logs\awstats_update.bat" with notepad++. Add the following line to the bottom of the file.
c:\Perl\bin\perl.exe "D:\Data\Websites\Live\<websitenaam>\website\stats\cgi-bin\awstats.pl" -config=<websiteurl> -update > d:\IISlogfiles\<websiteurl>_update.log
Example:
c:\Perl\bin\perl.exe "D:\Data\Websites\Live\ariafritta\Website\stats\cgi-bin\awstats.pl" -config=www.ariafritta.nl -update > D:\Data\Websites\Logs\www.ariafritta.nl_update.log

* Rename file D:\Data\Websites\Live\<websitenaam>\Website\stats\cgi-bin\awstats.www.websiteurl.nl.conf to stats\cgi-bin\awstats.<websiteurl>.conf
Example:
D:\Data\Websites\Live\ariafritta\Website\stats\cgi-bin\awstats.www.websiteurl.nl.conf to stats\cgi-bin\awstats.www.ariafritta.nl.conf

* GO to IIS and expand the website so you can see it's folders.
* Rightmouse on the "stats" folder and select "Properties". 
* Go to tab "Directory".
* Press on button "Create".
* Change the "Execute permissions" dropdownmenu to "Scripts only".
* Check the radiobutton "A redirection to a URL".
* Write "/stats/cgi-bin/awstats.pl" in the textbox.
* Check the checkbox "A directory below URL entered".
* Press on button "Apply".

'''NOTE'''<br />
When the applications web.config contains HttpHandlers/HttpModules -sections the awstat will show an error page.
* Rightmouse on the webapp and select "Properties". 
* Go to tab "Home Directory".
* Press on button "Configuration".
* Go to tab "Mappings".
* Insert new wildcard with filepath: "C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\aspnet_isapi.dll"
** Make sure the checkbox "Verify that file exists" is unchecked. (If this is checked, webresources will not work.)
* Press on button "OK/Apply".

* Press rightmouse on the website and select "Properties".
* Go to tab "Web Site".
* In the "Logging" section press button "Properties".
* Write down the "Log file name". (Example: W3SVC287048403)

* Edit the file "D:\Data\Websites\Live\<websitenaam>\Website\stats\cgi-bin\awstats.www.websiteurl.nl.conf" with notepad++.
* Edit the following lines:
** Linenumber  51: Change <logfiledir> to the log file name you have written down in the previous step.
** Linenumber 149: Change <websiteurl> tot the url of the website.(Example: SiteDomain="www.ariafritta.nl")
** Linenumber 162: If the website has multiple headers you can add them between the accolades seperated with a single space.(Example: HostAliases="www.gebakkenlucht.nl www.pizza.nl")
** Linenumber 662: If the website works with URLQueries then set "URLWithQuery=1" else set "URLWithQuery=0".
** Linenumber 462: If you want to exclude certain IP addresses you can add them here. By default all MVSD IP addresses have been excluded
 
That's it! To view the stats just browse to "http://<websiteurl>/stats">http://<websiteurl>/stats".



{TOP} 
=== WebDAV(Web-based Distributed Authoring and Versioning)===
<pre>
 [http://www.microsoft.com/netherlands/ondernemers/techniek_techniek/webdav.aspx|WebDAV protocol]
 [http://www.windowsnetworking.com/articles_tutorials/WebDAV-IIS.html|Using WebDAV with IIS]
</pre>
{TOP}

=== IIS(Internet Information Services) version 6 & 7===
<pre>
 '''IIS extentions''': [http://www.iis.net/expand/All]
 '''IIS7'''- Sites, Applications & Virtual dirs: [http://learn.iis.net/page.aspx/150/understanding-sites-apps-and-vdirs-in-iis-7/]
</pre>
===IIS 6 Deploying and configuring a new website===
[IIS-6-Deploying-and-configuring-a-new-website|IIS 6 Deploying and configuring a new website]
{TOP}

=== hMailServer ===
<pre>
handleiding: [http://www.hmailserver.com/documentation/v5.1/?page=overview]
{br}{br}
'''In het kort:'''
Na inloggen heb je links de "domains" die actief zijn, en in het welcome scherm 
kan je een niew domain toevoegen via Add domain... 
(uiteraard na het goed zetten van MX records in dns).
{br}{br}

In de domains lijst heb ik 1 test domain toegevoegd (mvsd.numloq.nl) met 
daaronder 1 user (test@mvsd.numloq.nl met password test).
Users toevoegen gebeurt in de accounts lijst onder een domain met de "add" knop,
waarna je een naam en wachtwoord op kan geven voor die user.
Hierna is de user meteen beschikbaar via pop3 en imap4 met als username dus 
het hele email adres en het wachtwoord als opgegeven.
Aliases geef je op in de aliases lijst (heb er een voorbeeld in staan, 
test2@ die naar test@ gaat).{br}{br}
Overige zaken als anti spam, blacklists, grey lists of antivirus kunnen we aan 
zetten als er een noodzaak voor is.
Voorlopig heb ik alleen de zenhaus en spamcop blacklists aan staan, deze houden 
90 a 95% tegen (op numloq zelf gebruik ik alleen die).
</pre>


{TOP}


== Version Control==

=== Subversion Repository aanmaken===
<pre>
*'''Ga naar Joshua via Remote Desktop'''
** Inlognaam: Administrator
** Wachtwoord: Rood42Haar
*'''SVN Root'''
**Klik op de shortcut SvnRoot
**Maak een map aan (bijvoorbeeld in Websites)
**Klik op de nieuwe map op de rechtermuisknop
** TortoiseSVN
*** Make repository here
*** Klik op “Ok”
*'''Kopieer de standaard layout'''
**Ga naar de map Default repository layout
**Klik op je rechtermuisknop
**TortoiseSVN
*** Import
** Klik op puldown om een voorbeeld url te krijgen
** Pas het pad aan en klik op “Ok”
** Ga naar de map Default Config en kopieer de inhoud naar de “Conf” map van je nieuwe repository.

:Klaar!
{TOP}
</pre>

=== Sventon===
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
</pre>

== Database server==
<pre>
 [http://en.wikipedia.org/wiki/Microsoft_SQL_Server|Microsoft SQL Server Release History]
 [http://www.microsoft.com/sqlserver/2008/en/us/editions.aspx|Microsoft SQL server 2008 versions]
</pre>

=== SQL Server Orphaned Users===
'''summary''': Bij het verplaatsen van een database op SQL Server ontstaan er problemen met de gebruikers
<pre>
'''SQL script voor het detecteren van de orphaned users'''
(((USE &lt;database_name&gt;;
GO; 
sp_change_users_login @Action='Report';
GO;)))

'''SQL script voor het herstellen van de orphaned users'''
(((USE &lt;database_name&gt;;
GO;
sp_change_users_login @Action='update_one', @UserNamePattern='&lt;database_user&gt;', 
   @LoginName='&lt;login_name&gt;';
GO;
)))

'''SQL script voor het wijzigen van het wachtwoord de zojuist herstelde orphaned users'''
(((USE master; 
GO;
sp_password @old=NULL, @new='password', @loginame='&lt;login_name&gt;';
GO;)))

'''Aanbevolen script voor het herstel'''

EXEC sp_change_users_login 'Auto_Fix', 'loginnaam', NULL, 'nieuwwachtwoord';


'''Bron:''' [^http://msdn.microsoft.com/en-us/library/ms175475.aspx]

{TOP}
</pre>

=== Migrate SQL2000 to SQL2008 (batch)===
<pre>
 ::SET VARIABLES
 set DBNAME=NAMEOFDATABASEBEINGRESTORED
 set DBDIRECTORY=C:\Program Files\Microsoft SQL Server\MSSQL\Data

 TITLE Restoring %DBNAME% Database

 ::PUT DATABASE IN SINGLE USER MODE TO ALLOW RESTORE
 osql -E -d master -Q "alter database %DBNAME% set single_user with rollback immediate"

 ::RESTORE DATABASE
 osql -E -d master -Q "restore database %DBNAME% from disk='%~dp0\%DBNAME%.bak' WITH MOVE '%DBNAME%_Data' TO  '%DBDIRECTORY%\%DBNAME%_Data.MDF',  MOVE '%DBNAME%_Log' TO '%DBDIRECTORY%\%DBNAME%_Log.LDF'"

 ::GRANT PERMISSION TO ASPNET USER
 osql -E -d %DBNAME% -Q "sp_grantdbaccess '%COMPUTERNAME%\ASPNET'"
 osql -E -d %DBNAME% -Q "sp_addrolemember 'db_owner', '%COMPUTERNAME%\ASPNET'"

 ::RESTORE TO MULTI USER
 osql -E -d master -Q "alter database %DBNAME% set multi_user"

 pause

</pre>


== Windows SharePoint Services(WSS)==
<sup>summary: sharepoint services provided in Windows Server 2003</sup> 

=== activate Single Sign-On (SSO)===
<pre>
'''1. manually configure Kerberos authentication for the virtual sharepoint server''' [http://intranet.mvsd.nl]
* To use a script to enable Kerberos authentication on the virtual server, follow these steps: 
**On the server that is running IIS, click Start, click Run, type cmd in the Open box, and then click OK.
**Change to the Inetpub\Adminscripts folder.

* Type the following command, and then press ENTER:
** cd Drive:\inetpub\adminscripts
**Note In this command, Drive is the drive where Microsoft Windows is installed.

*Type the following command, and then press ENTER:
**cscript adsutil.vbs get w3svc/##/root/NTAuthenticationProviders
**Note In this command, ## is the virtual server ID number. The virtual server ID number of the Default Web site in IIS is 1. {br}(for the site: '''intranet.mvsd.nl''' the ##='''561119538''')

* To enable Kerberos authentication on the virtual server, type the following command, and then press ENTER:
** cscript adsutil.vbs set w3svc/##/root/NTAuthenticationProviders "Negotiate,NTLM"
** Note In this command, ## is the virtual server ID number.

* Restart IIS. To do this, follow these steps: 
** Click Start, click Run, type cmd in the Open box, and then click OK.
** At the command prompt, type iisreset, and then press ENTER
**Type exit, and then press ENTER to close the Command Prompt window.

'''2. Configure a Service Principal Name(SPN) for the domain user account'''
:: because the application pool identities are domain user accounts. CentralAdminAppPool & MSSSharepointPortalAppPool {br}are using ''MVSD\sharepointadmin'' as indentity. (see ApplicationPool properties, tab Indentity under IIS6.0 at TELCO2)

* Download and install the Setspn.exe command-line tool. To do this, visit one of the following Microsoft Web sites.
** [http://support.microsoft.com/kb/892777|Windows Server 2003 Service Pack 1 Support Tools] 
* Use the Setspn.exe tool to add an SPN for the domain account. To do this, follow these steps: 
** Type the following line at the command prompt, and then press ENTER: 
*** Setspn -A HTTP/telco2 MVSD\sharepointadmin 
*** Setspn -A HTTP/telco2:10673 MVSD\sharepointadmin
** Type the following line at the command prompt, and then press ENTER: 
*** Setspn -A HTTP/intranet.mvsd.nl MVSD\sharepointadmin

'''3. Configure trust for delegation for Web parts'''
* On the domain controller, start Active Directory Users and Computers.
* In the left pane, click Users.
* In the right pane, right-click the name of the user account, and then click Properties. 
* Click the Account tab, under Account Options, click to select the Account is trusted for delegation check box, and then click OK. 
* Quit Active Directory Users and Computers.

resource: [http://support.microsoft.com/kb/832769]
</pre>
{TOP}


== Swyx ==

=== Swyx doet het niet, wat nu?===
<pre>
'''Swyx herstarten'''
* Ga naar telco2 via remote desktop
** Ga naar Keepass voor inlog
* Open Swyxware Administration
* Ga naar Swyxware en klik dan op Swyxserver Telco2
* Ga naar Trunks
* Als een Trunk een rood bolletje heeft, er op staan, rechtermuisknop en refreshen.
** Succes! Dan swyxware afsluiten en lekker aan het werk.
* Geen succes? Ga verder
* Ga naar “Services (local)”
* Zoek “Swyxgate”.
** Rechtermuisknop en kies “restart”
* Werkt dat niet, zoek “Swyxserver”
** Rechtermuisknop en kies “restart”

{TOP}
</pre>
