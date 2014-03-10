Virtualization & High Availabilty
procm|2013/10/31 15:52:10
##PAGE##
{TOC}

=== Intro===
<PRE>
summary: VMware vs Windows 2008 R2(Enterprise edition)!

'''Comparison VMware vs Hyper-V'''
: [imageauto|fig. vmWare vs Hyper-v|{UP}/Brainnet/Virtualization/VMware vs Hyper-V.jpg]

'''SAN solutions'''
* HP MSA 2000
* HP Lefthand P4300
* HP VSA 
* DELL Equalogic PS4100xv
* StarWind iSCSI vSAN (software based!)
** StarWind vs Microsoft iSCSI
*** [http://insightsgtd.nl/LYwAxh|StarWind iSCSI vs. Microsoft iSCSI - Part 1]
*** [http://insightsgtd.nl/T0KSOt|Compare StarWind Free to Microsoft iSCSI Target]
</PRE>{TOP}

=== Resources:===
<PRE>
* [http://insightsgtd.nl/SVpev4|Getting started with Microsoft Cluster Services]
* [http://insightsgtd.nl/MffU4Q|Introduction to Cluster Shared Volumes]
* [http://insightsgtd.nl/P2HAWe|Deploying Cluster Shared Volumes (CSV) Windows Server 2008 R2 Failover Clustering]

* '''Technet'''
** [http://insightsgtd.nl/MKB9c5 |High Availability Scenarios]
** [http://insightsgtd.nl/MCDpEc|Failover Clustering Win2k8 Hyper-V with File Server Storage]
** [http://insightsgtd.nl/OdEjby|Failover Clustering Options in Win2k8 Hyper-V]
** [http://insightsgtd.nl/NY52rA|SNW Demo: Win2k8 Core, Hyper-V & Failover Clustering - with screenshots]

* [http://insightsgtd.nl/O1ycTZ|Review: StarWind Enterprise Server]
</PRE>{TOP}

=== High Availability (HA) Virtualization===
<PRE>
'''Design Overview'''
: [imageauto||{UP}/Brainnet/Virtualization/StarWind HA Configuration.jpg] 

==== Configuration====
 '''Windows 2008 R2 Failover Clustering''' configuration with Cluster Shared Volume(s)
* '''Cluster:''' ID: '''Hyper-V''' IP: '''10.0.0.20'''
** Node 1 - Brainnet-ex02
*** iSCSI Sync Channel 1 -> 192.168.110.17
*** iSCSI Sync Channel 2 -> 192.168.120.17
*** Heartbeat + Backup LAN -> 192.168.100.17
** Node 2 - Brainnet-ex01
*** iSCSI Sync Channel 1 -> 192.168.110.16
*** iSCSI Sync Channel 2 -> 192.168.120.16
*** Heartbeat + Backup LAN -> 192.168.100.16


 '''Storage with HA'''
* Quorum volume
** Main '''\\brainnet-ex02\d$\Data\iscsi-storage\StarWind\Quorum.img'''
** Partner '''\\brainnet-ex01\d$\Data\iscsi-storage\StarWind\Quorum.img'''
* --Quorum location '''\\brainnet-bk01\Cluster_Hyper-V\'''--
* Generic volume
** Main '''\\brainnet-ex02\d$\Data\iscsi-storage\StarWind\Generic.img'''
** Partner '''\\brainnet-ex01\d$\Data\iscsi-storage\StarWind\Generic.img'''

* Cluster Shared Storage 
** '''C:\ClusterStorage'''\Volume1 (mounting point) note: every VM(files & configuration) must be located within this folder!! 

((( StarWind Native SAN for Hyper-V 
* evaluation period 1 month!!
* new version (6) just arrived!! support for HA with deDeplication. WAN Remote Replication (not stable yet!) )))

 '''Network, Mappings'''
* virtualized interface(s):
** '''HOST:''' Office LAN '''HYPER-V:''' Office LAN virtual
** '''HOST:''' Backup LAN '''HYPER-V:''' Backup LAN virtual
* Cluster Network(s)
** Cluster Network 1 - Office LAN
** Cluster Network 2 - Backup LAN/Heartbeat
** Cluster Network 3 - iSCSI Sync Channel 1
** Cluster Network 4 - iSCSI Sync Channel 2
</PRE>{TOP}

=== Monitoring & other Tools===
<PRE>
* Virtualization Reporting
** [http://www.veeam.com|Veeam ONE]

* I/O capacity
** SQLIO (nothing to do with SQL)

* Monitor Server & Services
** PRTG
** Uptrends (only from Outside)
** Big Brother
</PRE>{TOP}

=== Terminology===
<PRE>
* SAN - '''S'''torage '''A'''rea '''N'''etwork
** VSA - '''V'''irtual '''SAN''' '''A'''ppliance
** iSCSI - 
*** Target - act as the '''server'''.
*** Initiator - act as the '''client'''.

* Cluster - group of 2 or more nodes.
** Node -
** Cluster Failover- 
** CSV - '''C'''luster '''S'''hared '''V'''olumes
** HA - High Availability
** Heartbeat- feature used by both nodes for constant monitoring each other and automatic fail-over in case of a failure without any assistance from the side of an administrator.

* Network
** '''N'''etwork '''L'''oad '''B'''alancing-
** '''TCP''' '''O'''ffload '''E'''ngine-  

* Virtual Machines
** VMM - Virtual Machine Manager
** SCVMM - System Center Virtual Machine Manager
** Synchronous Mirroring 
** Remote Replication
** CDP- '''C'''ontinuous '''D'''ata '''P'''rotection
** VSS- '''V'''olume '''S'''napshot '''S'''ervice
</PRE>{TOP}
