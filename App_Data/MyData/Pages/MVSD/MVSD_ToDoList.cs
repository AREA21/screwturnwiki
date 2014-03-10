MVSD ToDo's
celio|2011/02/11 02:43:44
##PAGE##
{TOC}
=== General===
* E-mail handtekening (MVSD huisstijl)
* --registering all(domains, servers, accounts, ...) passwords in (keePass Password Manager)-- §§(celio,2009/10/19 15:09:19)§§

=== rollouts ===

* -- Visual Studio 2008 (latest ServicePack/Hotfixes) (dev. workstations: Devid, Celio , Rithesh)-- 

* -- MsSQL2008 (latest ServicePack/Hotfixes) & SQL Managment Studio (installed on Testserver)--

=== Updagrades, Migrations===

==== APC Smart-UPS 1500(SUA1500RMI2U)====
<pre>
  battery replacement Kit #24(RBC24) : [http://tweakers.net/pricewatch/116963/apc-rbc24-originele-accu.html]
</pre>

==== Joshua3 to Joshua4 (Dell PowerEdge 2950 Gen.1 3x300GB 4GB RAM)====
<pre>
'''Services:'''
* PDC(Primary Domain Controller)
* Exchange Mail server

'''Tasks:'''   
* --BurnIn test(complete Hardware Check-Up) (dropped)-- 
* --Download last drivers (Vga, Storage Controllers) / Support CD (Celio)--
* --Update Bios/BMC >=(226/A10) firmware (Marc)--
** --Boot using DELL OPENManage CD--
** --get to Linux shell(console) press for eg. CTRL+ALT-F3--
** --mount USB stick storage run command: mount /dev/sdb1 /mnt--
** --browse to the folder were the updates are: '''cd /mnt/Dell PE2950/updates(Bios, firmwares)/Linux'''--
** --execute the files in the following order:(tip: pressing '''TAB''' key you get the file names they are case sensitive under Linux)--
**# --'''./PE2950_BIOS_LX_2.6.1.BIN'''-- 
**# --'''./BMC_FRMW_LX_R202152.BIN'''--
**# --'''./ESM_FRMW_LX_R149431.BIN'''--
**# --'''./NETW_FRMW_LX_R214709.BIN'''--
**# --'''./RAID_FRMW_LX_R189337.BIN'''--
** --follow the instructions for each file--
** --when you finish running all the updates: execute the command '''reboot'''--
* --Enable(BIOS) CPU VT(Microsoft Virtualization) (Marc)--
* --prepare HDD's for RAID 5 (Marc)-- 
* --Install Windows Server 2008 Standard (English 64bits) (Marc)--
** --create OS partition 75GB & all available storage for the second partition (Marc)--   
** --Config Network/Server--
** migration/import:
*** --Migrate Windows 2003 domain to Windows 2008 (Paul)--
**** [http://www.experts-exchange.com/OS/Microsoft_Operating_Systems/Server/Windows_Server_2008/Q_23582347.html]
*** --DNS: Joshua4 resolves domain mvsd.local | Transip resolves mvsd.nl (Paul)-- 
*** --Data(files) (Celio)--
*** IIS sites (Celio)
**** --Atlassian Jira (JOSHUA4\MSSQL2008_PROD)--
**** --Sventon (Web-based SVN viewer)- finish the Configuration of SVN projects/repositories (Ritesh/Celio)-- 
***** runs together with Jira using Apache Tomcat servlet container/app. server 
***** [http://jira/svn] or [http://joshua4:8080/svn]
**** --ScrewTurn Wiki --
**** SugarCRM (migrate MySQL to JOSHUA4\MSSQL2008_PROD db)
*** --Proxy, Firewall- change Joshua3 to Joshua4 (Paul)-- 
*** --Subversion server & projects (Celio)--
*** --upgrade Atlassian Jira (Apache/Tomcat webserver) & import old data (Celio)--
** --demote Joshua3 from PDC to member controller (Paul)-- 
* --Install MsExchange 2007 (Paul)-- 
** --Transitioning from Exchange 2003 to Exchange Server 2007 (Paul)--
*** [http://www.msexchange.org/tutorials/Transitioning-Exchange-2000-2003-Exchange-Server-2007-Part1.html]
* config/deploy Backup solution (Paul)
* Install Forefront Server Protection or similiar 
** [http://en.wikipedia.org/wiki/Microsoft_Forefront]
** [http://www.isaserver.org/tutorials/Installing-Forefront-Threat-Management-Gateway-Forefront-TMG-Beta1.html]
</pre>

==== Telco2 to Telco3(Dell PowerEdge 2950 Gen.1 3x300gb 2GB RAM)====
<PRE>
'''Services:''' 
* Cluster PDC(Joshua3) or secondary/backup '''D'''omain '''C'''ontroller
* VoIP(Swiyx)/ Microsoft '''U'''nified '''C'''omunications
* SQL 2008 database server
* Sharepoint data & ??development??

'''tasks:'''
* Swyx VoIP suite migration 
** SX2 QuadBRI PCI board
*** [http://www.swyx.com/support/knowledge-base/article-details.html?tx_swyxkbase_pi1%5Bkbid%5D=kb2471|Overview Swyx PCI cards - Slot types & combinations]
*** [http://www.swyx.com/support/knowledge-base/article-details.html?tx_swyxkbase_pi1%5Bkbid%5D=kb3159|Overview SX2 ISDN boards]
*** [http://www.swyx.com/support/knowledge-base/article-details.html?tx_swyxkbase_pi1%5Bkbid%5D=kb2867|SX2 QuadBRI configuration]
** Dell PCI-X Riser Card 2 slots for PowerEdge 2950
*** [http://www.koopkompas.nl/product_info.php?cPath=150_1558&products_id=140344]
*** [http://www.hardware-winkel.com/i57001_330-10067_dell_pci-x_riser_card_2_slots_for_poweredge_2950.html]
* troubleshoot Single Sign-On for Sharepoint(Telco2)
* upgrade Windows Sharepoint Services(WSS) v2.0 to Sharepoint 2010
</PRE>

=== Numloq Issues===
<PRE>
* Joshua3
** --DNS server (Joshua4) instellen om alleen locale machines te vertalen, de rest via internet (TransIp)--
** Make good configuration of DNS &amp; Active Directory services
** --KPN VPN-- '''TCON658 is upgraded to TPA0109''' & '''TAccess Checkpoint+Token'''
* Upgrade internet connection speed, decrease cost (KPN connection needed??)
* MVSD ICT infrastructuur documentation
** Updaten van Visio schema van het MVSD netwerk
** --Uitgebreid overzicht Virtual Machines {Win2003VS, SQL2005VM}--
*** the Virtual Machines come from HAL9000 physical server which is TURNOFF !! 
** Netwerk/kabel aansluitingen
* migratie MDaemon(Webserver1 smtp/webmail server) to http://www.hmailserver.com/ Webserver2
* --Outlook (Mobile)synchronisatie error verhelpen-- (new Joshua4 with MsExchange 2007)
</PRE>

===Operations & Services ===
<PRE>
'''Operations:'''
* fine tune of development Lifecycle/stages: dev, Test/Beta, Live/Production
* define MVSD consistent security standard (authentication/authorisation) for WebSite & SQL server(local/Hosting) + virtual directory or website
* subversion: organize projects, use a proper naming convention for the stuff. Clean old stuff if not necessary
* create Prototype(design)  using Microsoft Expression Blend 3
** the prototype could afterwards be overtaken in Visual Studio to finish the project

'''Services:'''
* --Microsoft VS Team Foundation (VS2008 + Code Versionning + IssueTracker), Best of Breed approach-- 
** --otherwise only Jira substitution (with for eg.[http://www.countersoft.com/home.aspx|Gemini])-- 
*** done!! upgrade Jira v.4.0 Enterprise (10users license)
* --WebDav support op Testserver IIS-- Open [http://testserver/WebDAV] as WebFolder!! 
** check if this is a viable channel to support & deploy MVSD sites
* --upgrade ScrewTurn Wiki (soon is version 3 finished & shining, now we are using a Beta version)-- §§(celio,2009/10/19 15:18:47)§§
* integrate Single Sign-On mechanism within this wiki
* Webserver1 (transip)
** Filter out inactive Websites/Databases (Devid)
* Webserver2 (Numloq)
** --rename Webserver1 at Numlock to Webserver2-- §§(celio,2009/04/23 12:11:56)§§
** finishing migration/testing of in production WebSites en/of databases(from TransIP server) 
** --create 2 instances of the SQLDB server TEST & LIVE. We should not mix this enviroments using confusing table names.-- 
*** second we can perform maintenance operations without affecting both environments. §§(devid,2009/04/28)§§
** --install/setup AWSTATS with the required activePERL ISAPI api-- 
* --MVSD Joshua3-- (replaced with Joshua4)
** --clean ActiveDirectory(computers, users,DNS) non-existing objects-- §§(celio,2009/04/28 19:59:43)§§Celio
** --Delete in the Active Directory Joshua & REMCO(computers)-- 
</PRE>

=== Document/gathering info===
<PRE>
* --search for a free (portable) dotNet Wiki Engine--

* --evaluate the relevant wiki engines--
<pre>
 [http://www.mindtouch.com/Community|MindTouch DekiWiki] -  very powerful but besides ASP.NET needs PHP & other opensource stuff 
 [http://www.screwturn.eu|ScrewTurn Wiki] - the choosen one!! because its very good & extrem portable
</pre>

* --install & use ScrewTurn wiki in the production enviroment--

* --create MVSD Wiki Skeleton--

* --Overview MVSD projects (Devid Kapic)--

* --Smart use existing Sharepoint info--

* --KB_BestPractices(standards, architecture & design Patterns)--

* --KB_Development_Guidelines(procedures, checklists, conventions)--  
<pre>
 eg.: 
 filename conventions -> (expressive) filename.version.author.xxx eg.: PersonalDevelopment.01.Celio.doc 
 presentation layer of the Websites are 1st develop in Firefox & afterwaards tested in IE & Safari 
 configutation stuff must be managed using, for intance, web.config  
</pre>

* KB_Quality&Service (testplan, installation/deploymentplan )
** improve/extend Devid Kapic's '''EasyWebEdit TestPlan'''
** use RichCopy(advanced RoboCopy alternative) to copy files to another location with the '''proper/tested permissions''' 

* --KB_HowTo's(Tips & Tricks)--  

§§(celio,2009/03/17 11:51:41)§§

</PRE>