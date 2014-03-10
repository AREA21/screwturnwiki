ICT Administration
procm|2012/11/23 11:16:26
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

=== Windows File Junctions, Symbolic Links and Hard Links===

So in Windows what is the difference between a short-cut and symbolic link (sym-link) and a hard link?

A short cut is basically a file that points to another file. It is an antiquated, pointing system from the Windows 95 era. Shortcuts not only use up space on your hard drive, they linger around after the item they are pointing to has been deleted and may break if the destination is renamed or moved.

A symbolic link is like a short cut but instead of being saved as a file, they are registered to the file system. This means they do not use hard disk space but programs recognise and can read where the link is pointing to. A symbolic link can point to any file or folder either locally on the computer and over a network using a SMB path.

A file hard link and the directory junction are a little different. It not only points to the item but duplicates it as a copy without taking up the extra hard disk space required by a clone. If you have a hard link pointing to a file then delete the original file, the hard link will still retain a copy of the clone. One limitation of the file hard link is that the link can only be made on the same file partition as the file.

Finally a junction is a hard link for directories. To me they are the most useful and unlike their file hard links counterparts you can create junctions on different partitions. Again a junction is stored on the file system where it does not take up additional space and is treated by the operating system and programs as a local folder.

==== How to create those special links====
* Windows Vista/7 uses the command line program called mklink to create these symbolic links. It has 3 arguments and then requires both a link name and target.
**'''<nowiki> mklink /D /H /J [LINK NAME] [TARGET]</nowiki>''', there are 4 modes for '''mklink''' and they all counteract each other meaning you can only use one argument or none at all.
*** No arguments creates file symbolic link which is like a shortcut that is registered on the file system instead of stored in a file.
*** /D creates a directory symbolic link which is like a shortcut that is registered on the file system instead of stored in a file.
*** /H creates what Windows refers to as a hard file link. A hard file link is used where you need multiple copies of a file but wish to save space by keeping only one physical copy on disk.
*** /J creates a Windows Junction which is a directory hard link. If you need duplicate copies of a directory but don’t wish to use up the extra hard drive space you can create a junction. Though be careful as any changes you make to a file or folder in one of the junction will affect all the others. 
(((note: Microsoft had to keep their older Junction system within NTFS for backwards compatibility with Windows 2000/XP. But if you are not using these systems, then you are probably better off sticking with symbolic links.)))
* [http://schinagl.priv.at/nt/hardlinkshellext/hardlinkshellext.html|Link Shell Extension & documentation]

==== Behaviors when moving/copying==== 
Here is a difference between how Junctions, Symbolic Links and Volume Mountpoints are treated when performing file system operations such as move/copy etc. 

* If you create a Symbolic Link, and you then move that link it is much the same as a shortcut in that it just moves the link itself, no actual data is moved/copied.

* However, if you move a Junction or Volume Mountpoint, a new folder is created at the move destination point and the contents of the original data folder is physically moved from its source location to the new move location. The Junction or Volume Mountpoint remains where it was, and the source folder remains intact (it just becomes empty).

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
