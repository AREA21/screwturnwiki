Accomplishments
procm|2019/12/20 22:23:36
##PAGE##
{TOC}

=== Ongoing (eInsights, enhanced Insights)===
<PRE>
'''Project/Hackathon ideas:'''

* '''Personal xRM enhancer(tool''')- Relations, Personal Branding Acumen/Maven
** Social Media Bundle {LinkedIn, Facebook, Email, Personal Phone}

* '''Microsoft UWP- Universal Windows Platform'''
** Raspberry Pi 2 running Windows 10 core, .NET core, Remote Debugging
((( [http://www.mono-project.com|--Mono Project- Run .NET MVC app in a LowerPower Device (NAS/Raspberry Pi)--]
...open source implementation of Microsoft's .Net Framework based on the ECMA standards for C# and the Common Language Runtime.)))
* Leap Controller (demo)
** Demo PlasticSCM + Unity3D navigation through code using LeapMotion Controller 

* Port/replicate Sony Ericson K750i Presenter to Android
** [http://developer.sonymobile.com/knowledge-base/archives/bluetooth-remote-control]
** [http://seamonkey420.tech-recipes.com/k750i/myhid.html|'''Jimmy Selix''', K750/W800i HID Profiles i made for PowerDVD, SageTV, and more...]
** [http://www.mobiles24.com/downloads/d/dqEZRzYSuk|Nokia Wireless Presenter]
** [http://forum.xda-developers.com/showthread.php?t=2325619|Install Java apps(.jar files) on Android]

'''Hardware:'''
* NAS Zyxel NSA352 v2
* Smartphone Oneplus One Android (Cyanogen mod)
* Cubieboard v3 aka Cubietruck
* Raspberry Pi: 
** Mobel B+ & 
** Model 2
** Camera module 
* Leap controller
* SmartTV Samsung UE40D6750
</PRE>

=== ScrewturnWiki migration to the Cloud===
<PRE>
* [http://sueetie.com/documentation/screwturn-file-to-sql|ScrewTurn Wiki- Local/File to SQL, Provider Migration Guide]

(((Publish changes
* git add . -A
* git commit -m "{comment}"
* git push -u origin master)))


* [http://appharbor.com|evaluation: AppHarbor (GIT, Heroku)]
** [http://cmo-wiki.apphb.com|My ScrewTurnWiki on AppHarbor]
** issue SQLCE support: [http://support.appharbor.com/discussions/problems/519-sql-server-compact]
** Load Testing: [https://appharbor.com/addons/loaderio]

* Available Repo's, docs & info:
** [https://bitbucket.org/screwturn|Bitbucket ScrewTurn Wiki 4]
** [https://stw.codeplex.com/releases/view/108727|Codeplex ScrewTurn Wiki 3.0.5.600]
** [http://blogs.msdn.com/b/windowsazure/archive/2011/06/17/real-world-windows-azure-interview-with-dario-solera-cofounder-of-threeplicate.aspx|Interview with Dario Solera, Cofounder of Threeplicate]
</PRE>

=== High Availability (Private Cloud) Proof of Concept (@Brainnet, 2012)===
<PRE>
(((steps: 
* AD migration
* FaseOut: Windows 2003 servers
* Enable Jumbo Frames (TCP MTU=9014)
* Enable Multipath I/O (MPIO) 
* POC MS. Exchange 2010 VM
* Fine Tune Virtual Environment)))

* [++KnowledgeBase.AD_Migration|'''A'''ctive '''D'''irectory migration 2003 to 2008]
* [++KnowledgeBase.ServersAndServices_Migration|Servers & Services migration]
* [++KnowledgeBase.Exchange_Virtualization|Exchange Virtualization] 

(((shopping list:
* Windows 2008 R2 50x CALS

* MS SQL 2012

* Memory Upgrade (2x HP Proliant DL360 G7)
** [http://insightsgtd.nl/UVMOtG|Shop Crucial® Memory Advisor HP DL360 G7 Server]
** [http://insightsgtd.nl/RFu1mH|HP ProLiant DL360 G7 Server Configuring Memory]
** [http://insightsgtd.nl/VFrF5A|HP ProLiant Server Memory Configuration Tool]
 
* [http://insightsgtd.nl/UB85LU|HP iLO Advanced License(Brainnet-EX01,EX02,BK01, BK02)] 

* SAN
** [http://insightsgtd.nl/WIHAPx|upgrade SAN MSA1500 with 5x HDs HP300GB 15K ULTRA320(€169 ex btw) partnrs: BF30084971, BF3008AFEC, BF3008B26C]
*** [http://insightsgtd.nl/WtuoO0|HP Storageworks MSA30 Modular San Array 3U (302970-B21)]
** --StarWind Native vSAN for Hyper-V (instead of vSAN we prefer to upgrade the storage of MSA1500)-- 
)))
</PRE>{TOP}

=== Recreate KPN-NEC environment (@AREA21, 2012)===
<PRE>
* Install Windows 2003 server (32bits)
** Install Microsoft Loopback Network Adapter, this should be our primary NIC, to avoid problems with Oracle env.
*** Setup (fixed) IP address: '''192.168.1.7'''
*** Add entries in '''{SYSTEMROOT}\System32\drivers\etc\hosts''' file  
eg.:
(((#Loopback NIC 
192.168.1.7	nec-testserver nec-testserver.area21.local)))

* Install Oracle 10gR2
** Create database (Global Name & SID = '''NEC''')
** Create user '''NEC'''
*** ALTER USER '''nec''' QUOTA UNLIMITED ON users
** @command prompt run: IMP PARFILE=D:\MyProjects\MVSD\KPN\NEC\EnvironmentInstallation\Oracle_NECPROD_export\Imp_NECPROD.par 
** Import NECPROD.exp file (Oracle exported Production DB). Please use the user '''SYSMAN''' which have Oracle DBA admin privileges. 

* Install Bea Weblogic 8.1
** SetUp/Recreate Configuration

* Install Eclipse IDE
** reconfigure KPN-NEC projects
** install Plugins:
*** Maven, to build projects
*** Amateras, XML/HTML highlighter
** Optional:
** import file: CodeFormaterMVSDprofile.xml

* Install CollabNet Subversion Edge
** restore Repositories

* Install Atlassian Jira
** Import Projects Data
** Install Sventon (SVN WebClient)
</PRE>{TOP}

=== Upgrade Oracle 10gR1 to R2 (@MVSD, 2010)===
<PRE>
cmo 26/03/2010

- Upgrade Oracle to match the version running at the client Oracle10gR2. 
This was desired because our client was using a different Oracle release(10gR1) to run NEC¹ but in our developement/test environment we still using 10gR1. 
Long away this need was identified but our product(NEC¹) was worked smothelly no one had the know-how, time, courage, initiative to do change the situation.
Besides this i also sucessfull migratie the KPN Baseline data to our enviroment. This will make possible to simulate real life situations when testing our product before 
this was not possible to fully garantee that all the solved isssues, releases, patches, scripts would work.  

¹ NEC is the managementsystem of the KPN Telecom for the 0800/0900 calls.   

cmo 18/03/2010

upgrade (MVSD OracleDB version)
	Oracle Database 10g Release 10.1.0.2.0 - Production
	PL/SQL Release 10.1.0.2.0 - Production
	"CORE	10.1.0.2.0	Production"
	TNS for 32-bit Windows: Version 10.1.0.2.0 - Production
	NLSRTL Version 10.1.0.2.0 - Production

to (at least KPN OracleDB version)
	Oracle Database 10g Enterprise Edition Release 10.2.0.2.0 - Prod
	PL/SQL Release 10.2.0.2.0 - Production
	"CORE	10.2.0.2.0	Production"
	TNS for 32-bit Windows: Version 10.2.0.2.0 - Production
	NLSRTL Version 10.2.0.2.0 - Production
	
	
* d:\oracle\product\10.1.0\Db_1\BIN\oradim -NEW -SID NECOLD -SRVC OracleServiceNECOLD -STARTMODE auto -PFILE "d:\oracle\product\10.1.0\admin\nec\pfile\init.ora"
 
* STARTUP MOUNT PFILE='d:\oracle\product\10.1.0\admin\nec\pfile\init.ora'
 
*Give New ID to a existing database
** d:\oracle\product\10.1.0\Db_1\BIN\nid TARGET=sys/lam11biek@NEC DBNAME=NECOLD
 
* ALTER DATABASE OPEN RESETLOGS; 

</PRE>{TOP}


=== Security===
<PRE>
* [http://www.4guysfromrolla.com/articles/083105-1.aspx|Tamper_Proof URLs- Oneway hashes querystring (@Xipio, 2008)]
</PRE>{TOP}