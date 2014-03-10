MVSD Infrastructuur
celio|2009/11/02 17:37:59|(((Mvsd,infra)))(((Mvsd Infrastructuur)))
##PAGE##
{TOC}


== general==	
<pre>
'''Windows AD'''(Active Directory) domain account 
 [^https://owa.mvsd.nl|Webmail OWA(Outlook web Access)]
 email(msn).: [{user}@mvsd.nl]
 username...: mvsd\{user}
 password...: {password}

'''VPN'''
 *vpn.mvsd.nl*
 username...: mvsd\{user}
 password...: {password}

'''IssueTracker & ProjectManagement'''
 Atlassian Jira: [http://jira.intranet.mvsd.nl]

'''Portal & Intranet'''
 MsSharepoint: [http://intranet.mvsd.nl] 

'''Local account'''(Werkstations)
 username...: Admin
 password...: l**11***k

'''Microsoft- Software & Keys'''
MAPS(Microsoft Action Pack Subscription) : [https://partners.microsoft.com/partnerprogram/IndividualHome.aspx]
SPLA(Services Provider License Agreement) : [https://www.microsoft.com/serviceproviders/licensing/default.mspx]

'''Network'''
 [image||{UP:ScrewTurn.Wiki.FilesStorageProvider}/MVSD/ICTinfra/MVSD.Netwerk.02.Celio.png]
 other formats:
 [App_Data/MyData/Upload//MVSD/ICTinfra/MVSD.Netwerk.02.Celio.vsd|MVSD ICT Infrastructuur(Visio&copy;)]
 sharepoint: [http://intranet.mvsd.nl/sites/beheer/Shared%20Documents/Netwerk/]

 [image|Network Scan:|{UP:ScrewTurn.Wiki.FilesStorageProvider}/MVSD/ICTinfra/MVSD.NetworkScan.01.Celio.jpg]


'''Firewall Web Interface(Slackware Linux)'''
 [https://vpn.mvsd.nl:10000]
 [\\Joshua3\mvsd\Domeinen|see: KeePass(Password Manager)]

'''Mail Servers:'''
Joshua3(Ms.Exchange) -> smtp.mvsd.nl 
Webserver1(MDaemon) -> smtp1.mvsd.nl 
Webserver2([http://www.hmailserver.com/documentation/v5.1/?page=overview |hMailServer])-> smtp2.mvsd.nl 

'''Netwok Shares'''
[\\maniac\orig|Maniac(Marc)]
[\\insights\shared|Insights(Célio)] 

'''WebDAV, Windows WebFolders'''
 Open this URL: [http://testserver/WebDAV] as an WebFolder 

'''[\\Joshua3\mvsd\Domeinen|KeePass(Password Manager)]'''
 [\\joshua3\mvsd\Domeinen]
 R*****H***

'''[^http://www.opendns.com|OpenDns]''' 
 DNS1: 208.67.222.222 
 DNS2: 208.67.220.220
</pre>

== [++KPN-NEC.KPN-NEC_Infrastructuur|KPN-NEC specific]==
(((summary: servers, links, accounts, etc used on NEC Java project)))

== Servers overview==

=== Virtual===

(((summary: all virtual servers, Ms VirtualPC 2005 R2 images)))

<pre>
 [http://virtualserver.intranet.mvsd.nl| Ms Virtual PC 2005 R2(TestServer)]
</pre>

=== Physical===

(((summary: all non-virtual machines)))

==== Local: MVSD HeadQuarter====

:'''non-Development but general ICT''' 
<pre>
 {| cellspacing="0" cellpadding="2" border="1" 
 ! Service !! Port !! UserName !! Password    !! Notes
 |-
 | colspan="5" bgcolor="lightgrey" | '''Ghost3'''.mvsd.nl - MVSD - Backup Server: 
 |-
 | RDP     || std || Administrator  || **** ||  [\\joshua3\mvsd\Domeinen|see in KeyPass]
 |-
 | colspan="5" bgcolor="lightgrey" | '''TELCO2'''.mvsd.nl - MVSD - Swyx VoIP, Ms Sharepoint... 
 |-
 | RDP     || std || Administrator  || **** || [\\joshua3\mvsd\Domeinen|see in KeyPass]
 |-
 | colspan="5" bgcolor="lightgrey" | '''JOSHUA3'''.mvsd.nl - MVSD - Domain(AD), Exchange(mail server), DNS, Users, Project, Subversion, IssuaTracker(jira)...
 |-
 | RDP     || std || *** || **** || [\\joshua3\mvsd\Domeinen|see in KeyPass]
 |}
</pre>

:'''Development(dev) Fase'''
<pre>
 {| cellspacing="0" cellpadding="2" border="1" 

 ! Service !! Hostname/Ip        !! Port !! UserName !! Password    !! Notes
 |-
 | colspan="6" bgcolor="lightgrey" | '''TESTSERVER'''.mvsd.nl - MVSD - Local Application(Bea Weblogic)server + Database(MSSQL & Oracle) server
 |-
 | RDP     || testserver.mvsd.nl   || std  || Administrator || R*****H*** || Remote Desktop
 |-
 | WebDav  || http://testserver.mvsd.nl/WebDAV-Dev  || std || *** || *** || [\\joshua3\mvsd\Domeinen|see in KeyPass]
 |}
</pre>

==== Remote/Hosting====

:'''Test/Beta Fase'''
<pre>
 {| cellspacing="0" cellpadding="2" border="1" 
 ! Service !! WebSite/virtual dir./instance !! Port !! UserName !! Password    !! Notes
 |-
 | colspan="6" bgcolor="lightgrey" | '''WEBSERVER1.mvsd.nl((80.69.87.136))''' - TRANSIP - Beta & Live(Web, Database) server...(will be repaced by Numlock Webserver1)
 |-
 | RDP     || n.a.      || std || Administrator || see keePass!! || Remote Desktop
 |-
 | FTP     || n.a.      || std || Administrator || see keePass!! || Remote Desktop
 |-
 | IIS     || test.mvsd.nl || std || Administrator || see keePass!! || Microsoft WebServer IIS6
 |-
 | SQL     || ??? || std || Administrator || see keePass!! || Microsoft SQL2005
 |-
 | colspan="6" bgcolor="lightgreen" | WEBSERVER1(87.253.140.61) - NUMLOCK - Beta & Live(Web, Database) server...
 |-
 | RDP     ||   || std || Administrator || R*****H*** || Remote Desktop
 |-
 | FTP     ||  || std || Administrator || R*****H***  || File Transfer Protocol
 |-
 | sFTP    ||  || 990(TLS) || Administrator || R*****H*** || Secure FTP
 |-
 | WebDAV  || http://87.253.140.61/WebDAV-Beta  || std      || Administrator || R*****H*** || WebFolder(d:\TestWebsites)
 |-
 | IIS    ||   || std || Administrator || R*****H*** || Microsoft WebServer IIS7
 |-
 | SQL    ||    || std || Administrator || R*****H*** || Microsoft SQL2008(express)
 |}
</pre>

:'''Live Fase'''
<pre>
 {| cellspacing="0" cellpadding="2" border="1" 
 ! Service !! WebSite/virtual dir./instance !! Port !! UserName !! Password    !! Notes
 |-
 | colspan="6" bgcolor="lightgrey" | WEBSERVER1.mvsd.nl(80.69.87.136) - TRANSIP - Beta & Live(Web, Database) server...(will be repaced by Numlock Webserver1)
 |-
 | RDP     || n.a.      || std || Administrator || see keePass!! || Remote Desktop
 |-
 | FTP     || n.a.      || std || Administrator || see keePass!! || Remote Desktop
 |-
 | IIS     || test.mvsd.nl || std || Administrator || see keePass!! || Microsoft WebServer IIS6
 |-
 | SQL     || ??? || std || Administrator || see keePass!! || Microsoft SQL2005
 |-
 | colspan="6" bgcolor="lightgrey" | WEBSERVER1(87.253.140.61) - NUMLOCK - Beta & Live(Web, Database) server...
 |-
 | RDP     || n.a. || std || Administrator || R*****H*** || Remote Desktop
 |-
 | FTP     || n.a.  || std || Administrator || R*****H***  || File Transfer Protocol
 |-
 | sFTP    || n.a.  || 990(TLS) || Administrator || R*****H*** || Secure FTP
 |-
 | WebDAV  || http://87.253.140.61/WebDAV-Beta  || std      || Administrator || R*****H*** || WebFolder(d:\TestWebsites)
 |-
 | IIS    || {sitename}.{domain}.{tld}  || std || Administrator || R*****H*** || Microsoft WebServer IIS7
 |-
 | SQL || ???  || std || Administrator || R*****H*** || Microsoft SQL2008(express)
 |}
</pre>

----
§§(Celio,2009/02/27 14:00:22)§§ 