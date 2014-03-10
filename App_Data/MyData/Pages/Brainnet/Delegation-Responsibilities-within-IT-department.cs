Delegation Responsibilities within IT department
celio|2012/05/24 17:39:11
##PAGE##
=== Delegation Responsibilities within IT department===
<msg type=information>initiated before Robert Saxby departure!!</msg>

* resource: '''Celio Moreira'''
** --replacement defect harddisk @brainnet-ex01 RAID-- -> Done!
** Active Directory settings
*** DHCP (IP addresses Range 50-150)
*** Terminal Services
*** File-Folder(NTFS) & Print Permissions
** Network & telephony Cabling
** Network/Communication Appliances
*** HP Servers  
**** Integrity Integrated Lights-Out (iLO) Remote Management Interface
*** Network(Multifunction) Printers 
**** 2x Xerox Phaser 4510 (4xPaperTrays & Duplex)
**** 2x Xerox Phaser 4600 (4xPaperTrays & Duplex)
**** 2x Brother MFC 9120CN '''Color Print, Scan, Fax'''
**** Brother MFC-8370 DN '''Print, Scan, Fax *New Copy Machine!!'''
*** --PBX - Business telephone System Management (KPN Vox Supreme Novo/Vox NovoCompact/Telephone model D342)-- replaced with VOIP(Voizz provider & Triptel IP284 phones)
*** 1x Zyxel ADSL '''Router''' (default) Internet connection  
*** HPStorageWork Modular Smartarray 1000 '''SAN'''(4year old!)
**** HP Storage 4/8 SAN Fiber-channel '''Switch'''
**** 3x HP FC1142SR 4Gb PCI-e HBA '''NIC'''
*** World Wide Packets Lighting Edge 310 KPN '''Fiber-channel Internet''' 
**** Cisco 1800 series '''Switch ''' KPN '''Fiber-channel Internet'''
*** HPStorageWork Ultrium 920 SAS '''Backup Unit'''
*** HPStorageWork Ultrium 215 '''Backup Unit''' internal@Brainnet-DEV server 
*** --2x Cisco Catalyst 3560G series '''Switch'''-- Out of Service
*** --2x Cisco ASA 5505 series (Adaptive Security Switch) '''VPN Firewall'''-- Out of service
**** 1x (Server Rack@basement) 
**** 1x (Patch Cabinet@2nd floor)
*** new 
**** HP ProCurve 1810G - 24 GE '''Switch''' ServerRack@basement
**** 1x CISCO Wireless Lan Controller
**** 1x 3COM OfficeConnect PoE '''Switch PoE''' VOIP
**** 2x 3COM Baseline 2900 '''Switch'''
*** 2x HP R3000XR '''UPS'''
** Configuration Management
*** --ActiveX component-- (E-mail?)
**** IE8 
**** new IE9
*** Ms Office Word
**** --VSTO Brainnet Ribbon, Paper Tray configurations (Xerox Phaser 4510 & 4600)-- 
*** Ms. Outlook
**** user ISO signature
**** BoaBaas MailMove button 
** [++Brainnet.ICT-administration.ashx#Deploy_Mainstream_Base_Image_or_Create_others_21|Quick-Guide deployment new Client machines]
*** Create base PC images: Office & maybe also Development
**** Windows 7
**** Office 2007 & 2010
**** Acrobat Reader
**** CutePDF (PDF creator/printer)
**** Image software 
**** 
*** Implement Knowledge-base wiki for user support 
** Ms Licenses Audits
*** send requested Software Licenses form back to Microsoft 
** Deploy 8x new PC's to replace older machines
** Change Passwords

----
* Resource: '''Team''' 
** Backup strategy
** Disaster Recover Plan 
*** Solution Brainstorm
*** Proof of Concept  
** Implement Redundant Internet Connection
** Co-Hosting DPM Backup server '''BRAINNET-BK02''' OffSite
*** [http://technet.microsoft.com/en-us/library/cc161272.aspx|Determining Maximum Workloads]

* Resource: '''Nobel'''
** Firewalls configuration (Cisco ASAxxx) -> Ski
*** VPN & Network current settings
** E-mail search/indexing (Lookeen) -> Eelco
*** Exchange Journals, Archives  
** Troubleshooting DPM Backup server '''BRAINNET-BK01'''

* resource: '''Sander Meester'''
** Exact issues & documentation
** Cleaning Login Email 
** BoaBaas Financial module/package
** Bugtrack / Brainnet Development framework
** Tokens management

* resource: '''Niels Oostenrijk'''
** KeePass password management
** SSL Certificates
** Bugtrack / Brainnet Development framework
** Tokens management

* '''Competences''':
** Ms Exchange 2010
** Powershell
** System Center Data Protection Management (SCDPM)
** DPMRA.exe process DPM Replication Agent
** Cisco Firewall / VPN
** SAN Storage