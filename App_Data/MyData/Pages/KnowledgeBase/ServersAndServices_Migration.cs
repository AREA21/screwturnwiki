Servers & Services migration
procm|2013/01/22 12:39:48
##PAGE##
{| border="1"
! Brainnet-SRV01 (W2k3) !! Brainnet-SRV02 (W2k3) !! BRAINNET-BK01 (W2k8)
|-
| AD 2003 || AD 2003 (Backup DC) || new AD 2008 *to decommit AD 2003 
|-
| --DNS AD integrated + '''Brainnet.nl''' zone-- || DNS AD integrated || DNS AD integrated + '''brainnet.nl''' zone
|- 
| --DHCP-- || NA || DHCP *§§(procm,2012/11/15 17:11:52)§§
|- 
| WINS || WINS || not needed?
|-
| Certication Authority || ... || migrated!!
|- 
| ... || SQL Server 2005 (PROD) || ...
|- 
| ... || ... || Backup Exec 2010
|- 
| ... || ... || WSUS
|-
| ... || Exact Globe || ...
|-
! colspan="3" ! IIS
|- 
| FTP SCANS || .. || ...
|- 
| SMTP virtual server || ... || ...
|- 
! colspan="3" ! Internet Authentication Service/RADIUS
|- 
| --'''IAS''' for Brain-FWR01 & Cisco_Wireless-- || ... || NPS for Brain-FWR01 & Cisco_Wireless
|-
! colspan="3" ! Storage
|-
| SAN disk F:- HBA FC initiator (File server) || SAN disk F:- HBA FC initiator (SQL server) || NA
|-
! colspan="3" ! Shares
|-
| ... || ... || ...
|-
! colspan="3" ! Printers
|-
| Brother MFC's: --BRAIN-PR09-- and --BRAIN-PR14-- || ... || BRAIN-PR09 and BRAIN-PR14
|- 
| Xerox ColorCube + UNIX Services: '''LPR''' || ... || ...
|- 
| Planet Press Suite v.7 '''V'''irtual '''S'''tationary 1050 || ... || ...
|- 
| ... || ... || ...
|-
|}

<PRE>
'''DHCP: migrate IPv4 scopes from W2k3 to W2k8'''

1. On the Windows Server 2003 DHCP server, go to a command prompt
2. Type the following: netsh dhcp server \\yourserver export C:\dhcp all
3. Move this file to the new Windows Server 2008 server
4. Type the following: netsh dhcp server \\yourserver import C:\dhcp all
5. Restart DHCP and verify the database has moved over properly


You can refer to KB325473 directly to migrate DHCP database.

http://support.micro....aspx/kb/325473
</PRE>

<PRE>
'''Windows 2003 IAS (RADIUS) server migration to 2008 R2 NPS'''

* Copy '''%windir%\syswow64\iasmigreader.exe''' from the 2008 server to the 2003 server. 
* run '''IasMigReader.exe''' on the W2k3 server
(((Start to convert IAS configuration.
IAS configuration is successfully saved to "C:\WINDOWS\system32\IAS\ias.txt".)))

* Copy the '''ias.txt''' file that is generated back to the Win2k8 server.

'''Import the configuration like so:'''
* At the 2008 R2 Server Command prompt:
** netsh nps import filename="path\ias.txt"
** Don’t forget to register your NPS service in AD or configuration settings be damned, NPS will just will not work.

'''IAS''' = '''I'''nternet '''A'''uthentication '''S'''ervice/'''Radius'''
'''NPS''' = '''N'''etwork '''P'''olicy '''S'''erver
</PRE>