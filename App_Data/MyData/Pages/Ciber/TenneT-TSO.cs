TenneT TSO
procm|2017/02/14 11:24:28
##PAGE##
{TOC}

=== Needs===
(((
* '''Test Laptop''' in Ciber possession 
** TU (Test User) account
** LA (Local Admin) account

* --'''AA account''', access to servers-- *works!
** Local admin rights to run: *ongoing!
*** CRM deployment manager
*** Email router
*** IIS manager
*** ...etc??

* '''Deploy Groups''' association with(main, AA, TU, LA) accounts
** [http://beheerweb.alfa.local|'''Beheerweb- Deploy Groups Management site''']

* --'''Password Manager''' access--
** --must have write access--
** --Validate that the passwords match with "MSCRM2016 admin documentation..docx" produced by Theo--

* --'''Nework Shares''' (i:, w:)--

* --Access: '''SQL servers/instances''' (SQL Studio SQL Management)--

* --Access: '''Reporting Services Reports'''--
** '''VS solution, RDL files''': ALT-CRM003 '''E:''' drive

* '''Doubts'''?? 
** Analyse latest Topdesk issues!
** '''CMDB''' ?? what, where, who is responsible for info update?
** Read Theo document en gathered info/documentation )))

=== Extra work:===
<PRE>
* '''DocumentsCorePack'''(DCP) roll-out
** Choose Server or Client Base installation!
*** with Server base the user doesn't need Microsoft Word & the options are better controlled/managed.
*** with Client base the user can modify the document after the merge! 
** Prepare Unattended Setup script
** Microsoft Windows Identity Foundation(WIF) install
*** Windows Registry File: CRM settings + Add-On license?? 
*** Group Policy (AD) Rule(s) or Batch file eg. launch.bat
*** Import/convert existing Templates

(((<nowiki>"[DocumentsCorePackInstallFolderAndFile]" /V"/qb /lvx* C:\instlog.txt
UAIREGFILE=[RegFileLocation]\uai-template.reg"</nowiki>)))
</PRE>

=== Functioneel beheer===
<PRE>
* [http://beheerweb.alfa.local|'''Beheerweb- Deploy Groups Management''']
* [http://seargeantvandeweek.alfa.local|'''Seargeant of the week''']
* [http://sp-cases.alfa.local/sites/BIM/Cases/BIM-00084 - RM - MSCRM - Migration to version 2015/MSCRM - Findings registration - Migration to MSCRM 2015.xlsx|'''--Nazorg IssuesList--''']

* [http://sp-teamsites.alfa.local/sites/CRMbeheer/default.aspx|'''Sharepoint: CRM Beheer Algemeen''']
* [http://wiki.alfa.local|'''Wiki (Atlassian Confluence)''' ]

* '''Network shares''':
** '''I:''' (\\ka-dc02.alfa.local\data$)
** '''W:''' (\\alfa.local\beheer$)\AB\MSCRM

* Important docs:
** [I:\IA\Afgeschermd\Applicaties\MSCRM\MS CRM 2015\DTO...]

=== Pending issue(s)===
* Investigate Sorting Possibilities for "Open Activities - Related View", Peter SOM: 
** [https://community.dynamics.com/crm/f/117/t/197592|Sortdate activity pointer]
** Finding(s): Sortdate property only available since Dynamics 365...

==== questions:====
* --Topdesk issue--:
** "NCR: Aanpassen CRM en Checks account", wat is "Checks" account?
- Checks, we doen niets mee! Checks moet via ander groep!

* --ToegangCodes--:
** Windows AD, Active Directory
- AA account nodig!
- Password Manager? is dat beschermd per groep. 

* --Procedures--
** Deactiveren gebruikers, disablen de gebruiker binnen CRM 
** Mapping AD/CRM users, roles?
** Restarten van servers/services

* --CRM Licenties--
** Microsoft Audit, check alle actief CRM users

* --IT Landscape/overview--
** See DTO document in Sharepoint!

* --Documentatie, waar is dat te vinden?-- 
** Topdesk
** Sharepoint
** wiki
** (i:) DTO - Technishe Detail Ontwerp, Dick Noort heeft al aangevraagd!
** (i:) Applicatie document 
** CMDB in Topdesk, deze we bij moeten houden! 

* '''Monitoring?''' *Dick Noort will ask infra!
** Analyseren van Logs, Eventviewer??
** Opslag loopt vol
** Netwerk 
** CPU Rekenkracht
** Services (Site, WebServices)

* '''Backup procedures?'''
** Change in Topdesk!
** Hoe vindt validatie van de backups plaats?
*** geen afspraak daarover!

* '''Disaster Recovery Procedures?'''
** CRM Front-End & Backup-end
** SQL Reporting Services 
** MyTennet (Sharepoint) ?? 
** DocumentConnect ??

* '''Calamiteiten''': (see ContactPersonen hieronder)!
** 1e lijns Sergeant: Mark Bekke?? 
** DBA: Remco xxx?
** Email: ???
*** CRM Email Router: ??   
** MyTenneT: Mark Bekke
** Privacy/Security/Wet Becherming Persoonlijk Gegevens (WBp): Ronald Kersten
</PRE>

=== Contactpersonen:===
<PRE>
* '''Infra structuur''' (servers – netwerk etc.)
** Evert Morren
** Paul Leenheers (lastig te benaderen, houd zich afzijdig)
** Guido Brouwer 
** Jacco Steffens
** René Bekke (firewall issues)
** René Post (certificaten, locatie software voor installaties)

* '''Netwerk issues & Speciale wachtwoorden, Microsoft Exchange, PowerShell etc.'''
** Arjen Kroon

* '''SharePoint''', MyTenneT   Techn. Applicatie beheerder
** Mark Berck

* '''DBA'''(back-ups – restore, etc.)
** Remco van der Wiel
** René Borchert
** Hans ten Boden
** Michiel van Kessel

* '''Microsoft Licenties'''
** Luc Peters

* '''MyTenneT''' application-code
** CRM site-webservices
*** Ron Scheepers
** Service factory
*** Dave Kusters
*** Jos Baan

* '''Packages, Test laptops, Shared services'''
** Michael Luteijn
** Maas van de Haar

* '''Solution architects'''
** Pim Leenders  (CRM – Sharepoint – MyTennet)
** Eric Houmes  (IT-architect  TenneT breed)

* '''CIB vragen'''(non-standard changes, etc.)
** Remco van de Wiel
** Ferry Koster

----
TEAM 
* Infra 
** Evert Morren (Team coördinator)
** Michiel Huiskamp (Team coördinator)
** Hans van Beusekom (firewall specialist)
** René Bekke (firewall specialist)
* MyTenneT (custom service)
** Ron Scheepers(Software specialist)
* Service Factor (OSB service)
** Jos Baan (Java Middleware/Integrator)
** Dave Kusters (Java Middleware/Integrator)

</PRE>