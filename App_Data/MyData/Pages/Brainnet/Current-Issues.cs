Current Issues
celio|2012/09/28 13:09:20
##PAGE##
'''Documentatie & Kennis overdacht'''
* patch/bekabeling
* inrichting/instellingen
* Backup Exec inrichting
** AD account(s)
** access/communication with Off-site Bk02
** 1st All Brainnet data, afterwards deltas(embedded deduplication?)

'''Backup & Disaster Recovery'''
* Status Release optimized for bare metal recovery?
* Archiving strategy ??
* Plan Restore Proof of Concept Scenario
** Are we able to be up&running within 48h after server failure?

(((
* evaluation:
** [http://wiki.r1soft.com/display/TP/Backup+Software+Evaluated]
** [http://www.ahsay.com]
** [http://www.appassure.com/switching-to-appassure-gives-msp-fast-and-reliable-backup-and-replication]
 )))

'''Firewall '''(Juniper SRX220h)
* Reduntant Internet connection (ICT concepts & KPN )
** Email delivery (ICT concepts & KPN )
* disconnect Zyxel ADSL Modem & --Cisco ASA--
* extra options:
** Turn On UPM(Unified Protection Management)
*** AV/Malware updates: license costs(monthly, anually?)

'''Network'''
* Servers Update: Windows, Exchange, Backup Exec + agents  
* iLO's re-activation
* --Standardize Patch cable colors--
* KVM switch USB om oude PS/2 te vervangen
* SAN 9x HD 140GB ULTRA320 15K/ upg. 5x HD ca. €160eur p/disk
* UPS status 2x HP R3000XR - Test Batteries & replace them if needed!!

'''Free-up servers'''
* --'''Brainnet-ex02''' (Exchange DAG, Cluster)-- Done by Célio!!
** Check if primary Exchange2010 ex01 server works properly without the ex02 dependencies
* --'''Brainnet-srv03''' (spam filter)--
** Possibilities
*** '''SpamTitan under --VMware-- or Hyper-V''' Done by Célio!!
*** Firewall Juniper UPM 
*** TrendMicro Hosted Email Security
'''
'''Advies:'''
* --Direct Access from Outside to Brainnet e-mail--
* upgrade AD to Windows 2008R2
** Exchange 2010 veranderingen?
** Small Business Server bundel of afzonderlijk producten??
** SQL2012 in productie nemen icm Software Assurance? Kosten & varianten?
* Load balancing oplossingen??
* Virtualization

'''Group Policy Objects''' (profile path/local path)
* --ING Payment (IE settings)--
* --Outlook signatures--
* Deployment printers
* Storage Quotas (user level)
** Fileserver 
** Exchange Mailboxes 
