Windows OS'es
procm|2016/04/10 18:29:11
##PAGE##
{TOC}

=== '''Windows Embedded'''===
<PRE>
* Command Line Logoff or Switch Users
** Lock windows: '''rundll32.exe user32.dll, LockWorkStation'''
*** resource: [http://www.thewindowsclub.com/rundll32-shortcut-commands-windows|Rundll32 commands for Windows]
** Shutdown windows: '''shutdown /r /t 0'''

* Network 
** Read IP address: 
*** eg.: netsh interface ip show config
*** eg.: netsh interface ip show config name="Local Area Connection 2"
** Set IP address to be able to communicate I/O Modules: (from with iSii & Greenbox) 
*** netsh interface ip set address "Local Area Connection 2" static 172.18.0.1 255.255.0.0 

* ewfmgr: Failed getting protected volume configuration with error 1
(((EWF is not configured correctly.
1. Run: ewfcfg /install-configuration
2. Reboot the Client
3. Run: ewfmgr c: -enable
4. Reboot the Client))) 

* [https://technet.microsoft.com/en-us/library/hh825236.aspx| What is DISM??]
(((Deployment Image Servicing and Management (DISM.exe) is a command-line tool that can be used to service a Windows® image 
or to prepare a Windows Preinstallation Environment (Windows PE) image. 
DISM can be used to service a Windows image (.wim)or a virtual hard disk (.vhd or .vhdx). DISM replaces the ImageX tool 
which was deprecated in Windows 8. DISM also replaces Package Manager (Pkgmgr.exe), PEimg, and Intlcfg that were included 
in previous deployment toolkits. DISM also adds new functionality to improve the experience for offline servicing.)))

* [https://social.msdn.microsoft.com/Forums/en-US/076a1357-dc75-4a19-80f2-315c74a0426d/configuring-iis-in-wes7|Configuring IIS in WES7]

* [http://www.microsoft.com/windowsembedded/en-us/windows-embedded.aspx|Windows Embedded]
* [http://blogs.msdn.com/b/usisvde/archive/2009/08/11/windows-embedded-development-center-updated-on-msdn.aspx|Windows Embedded Development Center Updated on MSDN]
</PRE>

=== '''Windows Desktop (XP-10)'''===
: '''sfc /scannow detected some corrupt files.. unable to fix.. what to do?'''

<PRE>
* original command(s):
** sfc /scannow
*** <nowiki>findstr /c:'[SR]' %windir%\logs\cbs\cbs.log >sfcdetails.txt</nowiki> 
** DISM /Online /Cleanup-Image /RestoreHealth /source:WIM:X:\Sources\Install.wim:1 /LimitAcces

'''Solution:'''
* Create an empty folder eg.: d:\mounted-wim
* Copy ...\sources\install.esd (or install.wim) to the desired location, from '''Win10.ISO''' (downloaded from Microsoft)
** convert the file install.esd to install.wim (i used: [https://www.winreducer.net/winreducer-es-wim-converter.html|Winreducer])

* Open Admin Command prompt, copy/paste each line and run:
** Dism /mount-wim /wimFile:{desired location}\install.wim /index:1 /MountDir:d:\mounted-wim
** Dism /Online /Cleanup-Image /CheckHealth
** Dism /Online /Cleanup-Image /RestoreHealth /Source:d:\mounted-wim\windows /LimitAccess
** Dism /unmount-wim /Mountdir:d:\mounted-wim /discard
** re-run: sfc /scannow
</PRE>

: '''Restore Boot\BCD archive (new boot mechanism since Windows Vista)'''
<PRE>
* [http://support.microsoft.com/kb/2004518]
* [http://pcsupport.about.com/od/fixtheproblem/ht/rebuild-bcd-store-windows.htm]
* [http://windowsitpro.com/systems-management/build-bootable-bcd-scratch-bcdedit]
</PRE>

: '''VMware Workstation and Hyper-V are not compatible'''. Remove the Hyper-V role from the system before running VMware Workstation.
<PRE>
This is because the Hyper-V role is installed and this conflicts with VMware Workstation. 

To disable Hyper-V from starting the following command can be used:
* bcdedit /set hypervisorlaunchtype off
** A reboot of of the Windows OS is necessary.

To enable the Hyper-V role again use the following command:
* bcdedit /set hypervisorlaunchtype auto
** A reboot of of the Windows OS is necessary.
</PRE>

: '''RES PowerFuse/Workspace Manager cannot continue because no licenses are available'''
<PRE>
Windows session was denied because the RES agent (%programfiles%\RES Software\Workspace Manager\pfwsmgr.exe) 
failure and it was not possible to disable this peace of software because Windows as inaccessible even in Safe Mode.

'''Solution''': from another Windows computer connected on the same network "remotely" edit the Windows Registry of the affected workstation. 
* run Regedit as (local)Administrator (from another computer on the network)
** In Registry Editor, on the File menu, click '''Connect Network Registry'''.
** Type the name of the computer to whose registry you want to connect in '''Enter the object name to select'''.
** Then click OK. 
*** (((Maybe a dialog box will appear asking for a username & password which must have enough rights to edit the registry on the remote PC.)))
*** (((Both computers must be running the '''Remote Registry service.''')))
* Navigate to the following key:
 '''HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon'''
[image|Shell Registry Key|{UP}/KnowledgeBase/userinit-shell.png]
** Look at the '''Shell''' key & ensure that it's value is the following:
** explorer.exe
** Look at the '''Userinit''' key & ensure that it's value is the following:
** C:\Windows\system32\userinit.exe
* Disconnect from the network registry

* Finally you can now log on to the affected workstation. 
** I recommend to completely remove the RES Workspace Manager software, afterwards you should reboot the machine to finish the process.
</PRE>

: '''Windows Updates Problems'''
: ...execute the following command as Administrator: fsutil resource setautoreset true C:\

: '''Windows File Junctions, Symbolic Links and Hard Links'''
<PRE>
So in Windows what is the difference between a short-cut and symbolic link (sym-link) and a hard link?

A short cut is basically a file that points to another file. It is an antiquated, pointing system from the Windows 95 era. 
Shortcuts not only use up space on your hard drive, they linger around after the item they are pointing to has been deleted 
and may break if the destination is renamed or moved.

A symbolic link is like a short cut but instead of being saved as a file, they are registered to the file system. 
This means they do not use hard disk space but programs recognise and can read where the link is pointing to. 
A symbolic link can point to any file or folder either locally on the computer and over a network using a SMB path.

A file hard link and the directory junction are a little different. It not only points to the item but duplicates it as a 
copy without taking up the extra hard disk space required by a clone. If you have a hard link pointing to a file then delete 
the original file, the hard link will still retain a copy of the clone. One limitation of the file hard link is that the link 
can only be made on the same file partition as the file.

Finally a junction is a hard link for directories. To me they are the most useful and unlike their file hard links counterparts 
you can create junctions on different partitions. Again a junction is stored on the file system where it does not take up additional 
space and is treated by the operating system and programs as a local folder.

==== How to create those special links====
* Windows Vista/7 uses the command line program called mklink to create these symbolic links. It has 3 arguments and then requires 
both a link name and target.
**'''<nowiki> mklink /D /H /J [LINK NAME] [TARGET]</nowiki>''', there are 4 modes for '''mklink''' and they all counteract each other 
meaning you can only use one argument or none at all.
*** No arguments creates file symbolic link which is like a shortcut that is registered on the file system instead of stored in a file.
*** /D creates a directory symbolic link which is like a shortcut that is registered on the file system instead of stored in a file.
*** /H creates what Windows refers to as a hard file link. A hard file link is used where you need multiple copies of a file but wish to 
save space by keeping only one physical copy on disk.
*** /J creates a Windows Junction which is a directory hard link. If you need duplicate copies of a directory but don’t wish to use up the 
extra hard drive space you can create a junction. Though be careful as any changes you make to a file or folder in one of the junction will 
affect all the others. 
(((note: Microsoft had to keep their older Junction system within NTFS for backwards compatibility with Windows 2000/XP. But if you are not 
using these systems, then you are probably better off sticking with symbolic links.)))
* [http://schinagl.priv.at/nt/hardlinkshellext/hardlinkshellext.html|Link Shell Extension & documentation]

==== Behaviors when moving/copying==== 
Here is a difference between how Junctions, Symbolic Links and Volume Mountpoints are treated when performing file system operations such as move/copy etc. 

* If you create a Symbolic Link, and you then move that link it is much the same as a shortcut in that it just moves the link itself, no actual data is moved/copied.

* However, if you move a Junction or Volume Mountpoint, a new folder is created at the move destination point and the contents of the original data folder is physically 
moved from its source location to the new move location. The Junction or Volume Mountpoint remains where it was, and the source folder remains intact (it just becomes empty).
</PRE>

=== '''Windows Server'''===
(((
* [http://en.wikipedia.org/wiki/RAID#RAID_0|RAID]
* [MMC_Admin_Tools|MMC Admin Tools]
* [http://support.microsoft.com/kb/243330|Well-Known Security Identifiers] 
* [Windows-SharePoint-Services-WSS|'''WSS''' (Windows SharePoint Services)]
)))

* '''Run Programs as Domain User from Non-domain Computer'''
** ...runas /netonly /user:domain\username “C:\Program Files (x86)\Microsoft SQL Server\100\Tools\Binn\VSShell\Common7\IDE\Ssms.exe”

: '''Win2003srv DSRM''' (Reset Directory Service Restore Mode password)
<PRE>
When on Windows Server 2003, the '''setpwd''' or '''NET USER''' trick won't work. If you want to change the DSRM Administrator password you'll need to use the following method:

Click, Start, click Run, type: '''ntdsutil''' & click '''OK'''
* At the Ntdsutil command prompt, type: '''set dsrm password'''
** At the DSRM command prompt, type one of the following lines:
*** To reset the password on the server on which you are working, type: '''reset password on server null'''
*** The null variable assumes that the DSRM password is being reset on the local computer. Type the new password when you are prompted. Note that no characters
 appear while you type the password.
*** '''or''' To reset the password for another server, type: '''reset password on server''', where <servername> is the DNS name for the server on which you are 
resetting the DSRM password. 
**** Finally at the DSRM command prompt, type: '''q'''
*** and at the Ntdsutil command prompt, type: '''q''' to exit.
*** You can now use the Administrator account to log on to Recovery Console or Directory Services Restore Mode using the new password.
</PRE>

=== '''Network'''===

==== How-to set Network manually in Windows====
* netsh interface ipv4 set address name="Wi-Fi" source=static address=10.0.1.251 mask=255.255.252.0 gateway=10.0.1.1
* netsh interface ipv4 add dnsserver name="DNS1" address=8.8.8.8 index=1
* netsh interface ipv4 add dnsserver name="DNS2" address=8.8.4.4 index=2	

* Show NIC names: netsh interface show interface

==== Determine existing Ports bindings====
* '''netstat -abno | findstr 1801'''
** ...From the output it will be shown all instances of the message queue driver listening on port 1801.  To see what is the instance of the driver, execute:
* '''tasklist /svc | findstr <PID>''', where PID (process ID) is listed in the output of step 1.

==== How to the read the NIC assigned GUID?====
* eg.: netsh lan show interfaces

==== How to change the NIC Network Category/Location {Private, Work, Public}?====

<PRE>
By default, the security settings will make any unknown network public to prevent file access.
If you really want the network to be private so that you can use file sharing you need to modify the security settings.

To change this on your local server , follow these steps:
* Run '''gpedit.msc''', Group Policy Object editor 
* Open Computer configration --> Windows Settings -->Security Settings --> Network List Manager Policies
** On the right side double click --> Unidentified networks 
*** Now we can select the option to consider the Unidentified networks as private and if user can change the location.
</PRE>

==== Jumbo Frames====
* How to test if Jumbo frames are properly setup?
** eg.: ping -f -l 8972 192.168.110.16 

=== '''Hyper-V'''===

==== [http://insightsgtd.nl/1hWglla|Using Your Windows 8 Wireless Connection Inside Hyper-V]====

==== Recover Virtual Machine manually====
<PRE>
* Create the Symbolic link under "C:\ProgramData\Microsoft\Windows\Hyper-V\Virtual Machines"
** MKLINK "C:\ProgramData\Microsoft\Windows\Hyper-V\Virtual Machines\BE9EE68B-B731-4798-B625-88255429717C.xml" "C:\ClusterStorage\Volume1\dev-legacy.brainnet.local\Virtual Machines\BE9EE68B-B731-4798-B625-88255429717C.xml"

* Give Permissions to the service SID to this Sysmbolic link.
** ICACLS "C:\ProgramData\Microsoft\Windows\Hyper-V\Virtual Machines\BE9EE68B-B731-4798-B625-88255429717C.xml" /GRANT "NT Virtual Machine\BE9EE68B-B731-4798-B625-88255429717C":(F) /L

* Give access permissions to the Service SID to all files in the VM (dev-legacy.brainnet.local) 
** ICACLS "C:\ClusterStorage\Volume1\dev-legacy.brainnet.local" /T /GRANT "NT Virtual Machine\BE9EE68B-B731-4798-B625-88255429717C":(F)

* If the VM has also Snapshots, we need to create the correspondent symbolic link & give the necessary permissions to the files (this process must be done to each snapshot)
** eg. MKLINK "C:\ProgramData\Microsoft\Windows\Hyper-V\Snapshots\{GUI}.xml" "C:\ClusterStorage\Volume1\dev-legacy.brainnet.local\Snapshots\{GUI}.xml"
** eg. ICACLS "C:\ProgramData\Microsoft\Windows\Hyper-V\Snapshots\{GUI}.xml" /GRANT "NT Virtual Machine\{GUID}":(F) /L
</PRE>

==== Disable '''C'''luster '''S'''hared '''V'''olumes  (Windows 2008R2)====
<PRE>
* Launch Microsoft Powershell 
** '''PS:\''' Get-Module -ListAvailable
** '''PS:\''' Import-Module FailoverClusters
*** '''PS:\''' Get-Cluster | %{$_.EnableSharedVolumes = '''"Disabled"'''}
</PRE>

