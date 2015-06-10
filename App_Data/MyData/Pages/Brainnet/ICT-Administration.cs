ICT Administration
procm|2015/05/27 09:46:38
##PAGE##
{TOC}
== ITIL==
=== Security Best Practices===

==== Network shares====
* '''Authenticated Users''' in stead of '''Everyone''' user
* Security (NTFS: file/folder level) give '''Full Control''' to '''Brainnet\Administrators''' 


=== VOIP===
* [http://www.voipbuster.com/nl/hardware.html|VoIP hardware]
* '''Tiptel'''
** [http://www.tiptel.nl/doc/309229|Interoperability Overview]
** [http://www.tiptel.com/products/phones/voip|VoIP phones]

=== [http://brainnet-srv05:9675|SpiceWorks CMDB tool]===
* [http://msdn.microsoft.com/en-us/library/windows/desktop/aa822854(v=vs.85).aspx|Connecting to WMI Remotely]
** netsh advfirewall firewall set rule group="windows management instrumentation (wmi)" new enable=yes
* Enable File & Print services, ICMP (ping) responses are implcicitly enabled
** netsh advfirewall firewall set rule group="bestands- en printerdeling" new enable=Yes

=== [http://en.wikipedia.org/wiki/Group_Policy|Group Policy]===
* [http://www.microsoft.com/download/en/details.aspx?displaylang=en&id=25250|Group Policy Settings Reference for Windows]
* [http://technet.microsoft.com/nl-nl/library/cc787386(v=ws.10).aspx|Troubleshooting Group Policy Problems]

((( 
'''Link vs Enforced option''' - A "link" means that a Group Policy object is directly connected and 
applied to a OU. You can link/"connect" a given Group Policy to many OUs 
by just creating a link. You don't have to create a Group Policy for 
every OU you want to have it apply to. So the link is just the 
"connection" between a GP and a OU.

"Enforced" means that settings in the Group Policy which is set to 
"Enforced" cannot be overwritten by other Group Policies. You remember, 
the policy application goes like L-S-D-OU-SubOU, (Local, Site, Domain, 
OU, SubOUs), where "last writing policy wins the setting" applies. 
Enforce simply ensures that a policy, no matter where it is set, cannot 
get overwritten.
)))

=== Disk Quotas===
* Ownership, Viewing user files 
** FSUTIL file findbysid user directory
** eg.: fsutil file findbysid celio f: 

===Email: Exchange & Outlook===
[http://www.microsoft.com/download/en/details.aspx?displaylang=en&id=2953|Microsoft Exchange Server MAPI Editor]

=== PC audits (manually)===
[http://sydiproject.com|SYDI project- Network Documentation Made Easy]

* '''Scanning'''
** Servers
*** cscript "Y:\_Het Nieuwe Werken\ICT Exploitatie & Beheer\PC audits\SYDI-tool\tools\sydi-server.vbs" -ex -o"Y:\_Het Nieuwe Werken\ICT Exploitatie & Beheer\PC audits\xml\servers\'''{Name.xml}'''"
** Clients
*** cscript "Y:\_Het Nieuwe Werken\ICT Exploitatie & Beheer\PC audits\SYDI-tool\tools\sydi-server.vbs" -ex -o"Y:\_Het Nieuwe Werken\ICT Exploitatie & Beheer\PC audits\xml\'''{Name.xml}'''"

* '''Create overview'''(s) from previous XML(s) generated during the Scans:
** Servers
*** cscript "Y:\_Het Nieuwe Werken\ICT Exploitatie & Beheer\PC audits\SYDI-tool\tools\sydi-overview.vbs" -x"Y:\_Het Nieuwe Werken\ICT Exploitatie & Beheer\PC audits\xml\servers"
** Clients
*** cscript "Y:\_Het Nieuwe Werken\ICT Exploitatie & Beheer\PC audits\SYDI-tool\tools\sydi-overview.vbs" -x"Y:\_Het Nieuwe Werken\ICT Exploitatie & Beheer\PC audits\xml"

=== Network mappings===
* '''H:''' \\brainnet-srv01\users$\'''%USERNAME%'''
* '''G:''' \\brainnet-srv01\Gemeenschappelijk
* '''J:''' \\brainnet-srv01\BRadmin
* '''P:''' \\brainnet-srv01\Programma's
* J: ->> '''K:''' \\brainnet-srv01\directie
* '''S:''' \\brainnet-srv01\RaboTwin

==== specials====
* '''Lookeen index''' 
** \\brainnet-ex01\Standard_Index_001$\Reading
** \\brainnet-ex01\Special_Index_001$\Reading


=== [http://technet.microsoft.com/en-us/library/cc781516%28WS.10%29.aspx|User Data & Settings Management]===

* Group Policies 
** Local Group Policy Object (GPO) Editor: '''gpedit.msc'''
** Group Policy Management Console: '''gpmc.msc''' 

* Outlook
** As for signatures, you should set up Application data redirection on the user GPO. Also check if this works correctly, 
*** and the signature should be saved in %APPDATA%\Microsoft\signatures\ (variable for: \\server\share\%username%\Application Data\Microsoft). 
** Note(s): 
*** For layout options you could use something like the "Profile Custumization Wizard" in Office Resource Kit. 
*** Some view settings are stored on the exchange server.

* Resources:
** [http://en.wikipedia.org/wiki/Environment_variable#Default_Values_on_Microsoft_Windows|Windows Environment Variables]
** [http://technet.microsoft.com/en-us/library/cc731292.aspx|Deploy Printer Connections]
** [http://ss64.com/nt/syntax-security_groups.html|Windows Built-in Users and Default Groups]


=== [http://en.wikipedia.org/wiki/Windows_Preinstallation_Environment|Windows Preinstallation Environment]===

=== Windows Management Instumentation===
* [http://www.microsoft.com/download/en/details.aspx?id=24045|WMI Administrative Tools]
* [http://technet.microsoft.com/en-us/library/bb742610.aspx|WMIC - Take Command-line Control over WMI]
* [http://www.microsoft.com/download/en/details.aspx?id=8572|WMI Code Creator]
* [http://www.microsoft.com/download/en/details.aspx?id=7684|WMI Diagnosis Utility]
* [http://www.microsoft.com/download/en/details.aspx?id=24121|Windows PowerShell Scriptomatic]
* [http://www.microsoft.com/download/en/details.aspx?id=17332|Utility to help script writers create HTML Applications (HTAs)]
* [http://www.microsoft.com/download/en/details.aspx?id=7887|Remote Server Administration Tools for Windows 7 with Service Pack 1 (SP1)]

*'''How to retrieve HP Proliant server serial number?''' 
** wmic /node:{"ComputerName"} bios get serialnumber

=== Windows Software Update Service===
[http://technet.microsoft.com/en-us/library/cc720466(WS.10).aspx|'''WSUS''' Managing from the Command line]
* gpupdate /force 
* wuauclt /detectnow [http://technet.microsoft.com/en-us/library/cc720477(WS.10).aspx]

<PRE>
NET STOP wuauserv
REG DELETE "HKLM\Software\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update" /v LastWaitTimeout /f
REG DELETE "HKLM\Software\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update" /v DetectionStartTime /f
Reg Delete "HKLM\Software\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update" /v NextDetectionTime /f
NET START wuauserv
wuauclt /detectnow
</PRE>
=== Licensing check=== 
* [http://www.mydigitallife.info/slmgr-commands-and-options-with-windows-vista-product-key-activation|Windows Product Key activation]
* [http://support.microsoft.com/kb/928116|How to determine which version of a 2007/2010 Office product is installed]


=== Deploy Mainstream Base Image or Create others===
summary: how to use the powerful but free '''Hiren's CD''' tools to '''create''' and/or '''deploy''' clients with Base images!!

(((
==== Base image, software included====
* Windows 7 Professional 64bits NL
* Office 2007 Professional /'''2010''' Standard 32bits NL
* Ms Access 2003 Runtime
* Exact Globe
* TrendMicro Anti-virus
* Internet Explorer 9
* Adobe Acrobat Reader
* Piriform CCleaner
* Piriform Defragler
* Piriform Recuva
* CutePDF Writer
)))

Boot from Hiren's Boot CD/USB media
* Choose Linux base rescue environment (Parted Magic 6.7)
* Just accept the default options until u get to the Parted Magic GUI
** (((if you get problems loading the GUI try the option '''Kill Noveau''', this happens with our NVidia Dual-Head VGA's we are using to control Multiple Monitors)))
* Click the Start button (1st icon at the bottom left)
** select '''System Tools''' & then '''Clonezilla'''. (((note: Partion Editor is a good tool to manage (also shrink/extend) NTFS partitions)))
*** Choose the 1st option: '''device-image work with disks or partitions using images'''

[imageauto|Clonezilla|{UP}/Brainnet/HirensCD PartedMagic SystemTools Clonezilla1.jpg]

To Create of Use an image Clonezilla must know from or to which location the files should be written or read. 
We can choose local_dev if the files are local or samba_server to use for instance a Windows network share.
* in this case choose '''samba-server''' & pass the following parameters:
** IP address or Hostname of the computer/server eg.: '''brainnet-srv01'''
** Domain eg: '''brainnet'''
** Account eg: '''celio'''
** directory where Clonezilla image will be saved to or read from eg.: '''/deployments$'''
** Password: '''*******''' 
If the network access succeeded you just need to press enter to continue...

Continue using the Beginner mode: Accept the default options.
* if you want to create an image choose:
** savedisk - whole harddisk with all partitions within it
** saveparts - only the selected partition form the harddisk

* if you want to deploy an image choose:
** restoredisk - whole harddisk with all partitions within it
** restoreparts - only the selected partition form the harddisk

==== Important notes==== 
* its not possible to restore to disk/partitions with are smaller then the original one.
* its not possible to restore to a different partition number eg: sda1 to sda2
* when creating an image if you receive some kind of Write errors just commute to a slower networks speed. I got in to this problem when using a Gigabit switch although when deploying an image everything worked fast & smooth.     

==== Partitions====
* sda1 (System)-> 100MiB (105 MB)
* sda2 (OS)-> 97280MiB (95 GB)
* sda3 (HP Restore, swap-file + temp) -> remainder disk space

=== Add Computer (new image) to Brainnet Domain===
ToDo: ...

=== Apply Group Policies ===
ToDo: ...
