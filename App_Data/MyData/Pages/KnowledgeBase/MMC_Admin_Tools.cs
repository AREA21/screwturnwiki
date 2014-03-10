Microsoft Management Console- admin tools
procm|2012/08/03 11:26:06
##PAGE##
<msg type=information>
Most admin tools in Windows Server 2003 are MMC consoles you can access from the Start menu. But you can also open these console from the 
command line if you know their .msc filenames. This can be especially useful if you log on to your admin workstation using a limited privilege 
account and use Runas to perform admin tasks. For reference, here's a list of admin tools with their associated .msc files. You can print this 
out and tape it on the wall beside your workstation until you memorize the ones you use most commonly.
</msg>

{| 
| colspan="6" align="center" style="background-color: #000000; color: #FFFFFF;" | '''MMC commands'''
|- 
| AD Domains and Trusts || domain.msc || Event Viewer || eventvwr.msc || Resultant Set of Policy || rsop.msc
|- 
| Active Directory Management || admgmt.msc || Indexing Service Management || ciadv.msc || Schema management || schmmgmt.msc
|-
| AD Sites and Serrvices || dssite.msc || IP Address Manage || ipaddrmgmt.msc || Services Management || services.msc
|-  
| AD Users and COmputers || dsa.msc || Licensing Manager || llsmgr.exe || Shared Folders || fsmgmt.msc
|- 
| ADSI Edit || adsiedit.msc || Local Certificates Management || certmgr.msc || SID Security Migration || sidwalk.msc
|-  
| Authorization manager || azman.msc || Local Group Policy Editor || gpedit.msc || Telephony Management || tapimgmt.msc
|-  
| Certification Authority Management || certsrv.msc || Local Security Settings Manager || secpol.msc || Terminal Server Configuration || tscc.msc
|-  
| Certificate Templates || certtmpl.msc || Local Users and Groups Manager || lusrmgr.msc || Terminal Server Licensing || licmgr.exe
|-  
| Cluster Administrator || cluadmin.exe || Network Load balancing || nlbmgr.exe || Terminal Server Manager || tsadmin.exe
|-  
| Computer Management || compmgmt.msc || Performance Montior || perfmon.msc || UDDI Services Managment || uddi.msc
|-  
| Component Services || comexp.msc || PKI Viewer || pkiview.msc || Windows Mangement Instumentation || wmimgmt.msc
|-  
| Configure Your Server || cys.exe || Public Key Managment || pkmgmt.msc || WINS Server manager || winsmgmt.msc
|-  
| Device Manager || devmgmt.msc || QoS Control Management || acssnap.msc
|-  
| DHCP Managment || dhcpmgmt.msc || Remote Desktops || tsmmc.msc
|-  
| Disk Defragmenter || dfrg.msc || Remote Storage Administration || rsadmin.msc
|-  
| Disk Manager || diskmgmt.msc || Removable Storage || ntmsmgr.msc
|-  
| Distributed File System || dfsgui.msc || Removalbe Storage Operator Requests || ntmsoprq.msc
|-  
| DNS Managment || dnsmgmt.msc || Routing and Remote Access Manager || rrasmgmt.msc
|}