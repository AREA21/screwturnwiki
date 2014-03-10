Software Installation & Configuration
procm|2013/01/24 14:03:51
##PAGE##
{TOC}

=== Attachment(s)===
[{UP}/Brainnet/ConfigurationManagement.xlsx|Configuration Management Sheet]

=== Outlook===
* in Outlook 2010 disable Cache Mode 
** within Microsoft Exchange Settings -> Use Cached Exchange Mode -> Remove tick

==== Lookeen (search indexer)====
[http://www.lookeen.net/services/faq/#347]

=== Internet Explorer===

=== BoaFlex===
<PRE>
'''Copy file(s)''' 
* Y:\Het Nieuwe Werken\ICT Exploitatie & Beheer\temp\BoaFlex\BOAFLEX_Clyde\*.* 
  '''to''' C:\Program Files (x86)\Brainnet\BOAFLEX

'''Create BoaFlex shortcut''' 
* verify that Network drive '''P:''' is available!

* Type the location of the item: 
'''"C:\Program Files (x86)\Microsoft Office\Office12\MSACCESS.EXE" 
  "C:\Program Files (x86)\Brainnet\BOAFLEX\BOAFLEX_7.17.mdb” /wrkgrp "P:\BOAFLEX\BOAFLEX.MDW"'''

* Type the name for this shortcut: '''BoaFlex'''

* Use '''P:\BOAFLEX\boaflex.ico''' as the icon for the BoaFlex shortcut

'''Create ODBC connection''', type '''User D'''ata '''S'''ource '''N'''ame
* Name: BOAFLEX
* Server: Brainnet-srv02
** Change the default database to: BOAFLEX

(((Y: -> '''\\brainnet-srv01\Development'''
P: -> '''\\brainnet-srv01\Programma's''' )))
</PRE>

=== Exact Globe===
For each administratie/database repeat the next steps:

'''Bestand -> Administratie openen'''...

* Server:  '''brainnet-srv02'''
Administratie: '''001''','''002''','''003''' or '''901''' 

=== ING PKI===

run setup from the installation CD.
: Ps.: after mounting the ISO image for instance using Daemon Tools & sharing its virtual CD over the network!!

*Internet Explorer settings
** Trusted sites
*** https://*.ing.nl 
*** https://*.inginsidebusiness.com
** Advanced security
*** SSL 2.0 '''turned Off'''
*** SSL 3.0 '''turned On'''
*** TLS 1.0 '''turned On'''

* Java Plugin/Runtime
** Enable Next Generation Java Plugin '''turned Off'''


=== Printers: Xerox Phaser 4510 & 4600===

'''Installation:'''
* Install a local printer using the Xerox Phaser 4510 PS v.5.8.710 driver.  
** driver location: "Y:\_Het Nieuwe Werken\ICT Exploitatie & Beheer\Brainnet ICT Drivers & Manuals\Xerox printers”. Both 32bits & 64bits are properly tested. 
** during the installation create a standard TCP/IP port, use the printer IP address & name the port using IP_{ipaddress} eg. IP_10.0.0.41.
** Check if the papertray(s) are correct detected.
*** [imageauto||{UP}/Brainnet/XeroxPhaser_AvailableComponents.jpg]
 
** Finish the process following the existing Brainnet (name) conventions. 

'''Standard codes for paper Tray(s):''' 
* Tray1 - 260
* Tray2 - 259
* Tray3 - 258
* Tray4 - 257

'''Configuration file for use in Production:''' 
Location: ”..\Program Files (x86)\Brainnet\Brainnet Word Ribbon\Brainnet Word Ribbon.dll.config”
{@code-xml:
 <?xml version="1.0" encoding="utf-8" ?>
 <configuration>
  <appSettings>
    <add key="blancoPaperTray" value ="259"/>
    <add key="briefPaperTray" value ="258"/>
    <add key="volgPaperTray" value ="257"/>
  </appSettings>
 </configuration>
@}

==== Printing PDF's is very slow on Xerox Phaser 4600 series====

Workaround(s): 
# print PDF as Image using the Advanced option in the Print dialog of Acrobat Reader. 
[imageauto||{UP}/Brainnet/AdobeReaderX Print PDF as Image.jpg] '''OR'''
# import the following registry key file : [{UP}/Brainnet/AdobeReaderX, Print PDF as Image for Xerox4600 (BRAIN-PR12 & BRAIN-PR13).reg|Print PDF as Image for Xerox4600 (BRAIN-PR12 & BRAIN-PR13)] 

==== Xerox Maintenance Service====
If you encounter any problems with the printers, contact Xerox at '''020-6563620'''


=== VPN===
==== Juniper SRX220x====
* Download & install [http://www.ncp-e.com/en/downloads/software.html|NCP client Juniper edition]
** activate NCP Secure Client with the purchased License key
* Import file '''Brainnet.ini'''
** Configuration -> Profiles -> Add/Import -> Profile Import
* Edit Brainnet Profile adding the Shared Key (copy & paste text) 
** Configuration -> Profiles -> Edit -> Identities -> Pre-shared key-Shared Secret

(((all files needed are located '''@Y:\_Het Nieuwe Werken\ICT Exploitatie & Beheer\Infrastructuur\ITIL\VPN\JUNIPER'''
* Y: - development Network share)))

==== Cisco (old!!)====
* install '''Shrew Soft VPN Client'''
* import the file '''Brainnet.pcf'''
* set manually the Network Topology
** add entry 10.0.0.0/255.255.255.0

[imageauto||{UP}/Brainnet/Brainnet VPN.jpg]



=== Services to destroy Archives (Disks & Tapes)===
* [http://www.a-s-k.nl]
* [http://www.docucare.nl/Home.aspx]

=== HP StorageWorks 1000 Modular Smart Array===
* '''extend the logical F: drive @Brainnet-srv01 with the new 72GB spare disk.''' 
** [http://h20000.www2.hp.com/bizsupport/TechSupport/Home.jsp?lang=en&cc=us&prodTypeId=12169&prodSeriesId=377751&submit.y=5&submit.x=8&lang=en&cc=us|HP MSA1000]

=== Database backup===
{@code-sql:
 USE master;
 GO
 EXEC sp_addumpdevice 'disk', 'wks-031_dbBackup', '\\wks-031\d$\temp\Brainnet\dbBackups\2011_1219-BoaBaas.bak'

 BACKUP DATABASE boabaas 
 TO wks-031_dbBackup
 GO
@}

=== Exchange 2010 Management Shell [http://technet.microsoft.com/en-us/library/bb124413.aspx|PowerShell CommandLets]===
[http://blogs.technet.com/b/exchange/archive/2010/10/27/removing-specific-messages-from-your-exchange-server.aspx|Removing Specific Messages]

==== Microsoft Powershell====
* [http://www.powergui.org/index.jspa|Power(shell)GUI]
* [http://exchangepedia.com/stuff/exquick.html#Recipients|Exchange Management Shell Quick Reference]

(((
* create '''server-side''' rule  
** New-InboxRule -Name '''"&lt;give a name to the rule&gt;"''' -Mailbox '''"&lt;MailboxName&gt;"''' -RedirectTo '''"&lt;E-Mail address&gt;"''' 

* change (existing) rule
** Set-InboxRule -Identity '''"&lt;identity&gt;"''' '''-&lt;property to change1&gt; "&lt;value1&gt;"''' ... '''-&lt;property to changeN&gt; "&lt;valueN&gt;"''' 

* read rule(s)
** Get-InboxRule -Mailbox '''"&lt;MailboxName&gt;"''' | Select '''&lt;PropertyName1&gt;''' ... '''&lt;PropertyNameN&gt;''' 
** eg.: Get-InboxRule -Mailbox Screening | Select Name, Description, RuleIdentity|FL

* delete rule
** Remove-InboxRule -Mailbox '''"&lt;MailboxName&gt;"''' -Identity '''"&lt;RuleIdentity&gt;"'''
)))


==== Inbox rule(s) for '''Screening''' mailbox====
* --create server-side rule--  '''Rule moved to Transport layer mechanism!!'''
** email which comes in the Screening mailbox must be redirected to Brainnet(boabaas) mailbox
*** New-InboxRule -Name "Redirecting mailbox: Screening to BOABAAS" -Mailbox Screening -RedirectTo boabaas@brainnet.nl 

<msg type=caution>improvement(s)</msg>
* changing (existing) rule
** emails were correctly redirected but remained in the Screening mailbox!!
*** fix: Set-InboxRule -Identity "brainnet.local/OU - Brainnet gebruikers/Screening\8594841712394764289" -DeleteMessage 1

tip/information/note/important/caution/warning/system/error/question
==== [http://technet.microsoft.com/en-us/library/bb125138.aspx|Transport rule(s)]====
* create rule for '''Contract Admin.'''
** New-TransportRule -Name "from: connect.lokalebanken@rn.rabobank.nl to Contract Admin." -From "connect.lokalebanken@rn.rabobank.nl" -SubjectContainsWords "|" -RedirectMessageTo "contractadministratie@brainnet.nl" (((incoming mail form '''connect.lokalebanken@rn.rabobank.nl''' with a '''|(PIPE) in the Subject''' must be redirected to '''contractadministratie@brainnet.nl''' mailbox)))
** New-TransportRule -Name "Redirecting Contract Admin. email to BOABAAS" -SentTo Contract.Administratie@brainnet.nl -RedirectMessageTo boabaas@brainnet.nl 

* create rule for '''Screening'''
** New-TransportRule -Name "Redirecting Screening email to BOABAAS" -SentTo screening@brainnet.nl -RedirectMessageTo boabaas@brainnet.nl 

* read rule(s)
** Get-TransportRule | FL

