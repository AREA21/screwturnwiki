Windows OS'es
procm|2014/06/23 14:16:18
##PAGE##
{TOC}

=== '''Windows Desktop (XP-8)'''===
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

=== '''IIS''' (Internet Information Services)===

==== [http://support.microsoft.com/kb/943891|HTTP status code in IIS 7.0, IIS 7.5, and IIS 8.0]====

==== What is "pass-through authentication" in IIS?====
<PRE>
* Normally, IIS would use the '''process identity''' (the user account it is running the worker process as) to access protected resources like file system or network.
* With '''passthrough authentication''', IIS will attempt to use the actual identity of the user when accessing protected resources.
** If the user is not authenticated, IIS will use the '''application pool''' identity instead. If pool identity is set to '''NetworkService''' or '''LocalSystem''', the actual Windows account used is the computer account.
* The actual check will be performed at execution time, and if it fails, it'll show up in the log.
</PRE>
