Research(s)
celio|2012/08/17 12:17:30
##PAGE##
{TOC}

=== Ideas===
<PRE>
* Investigate Business Case: [http://en.wikipedia.org/wiki/Microsoft_Analysis_Services|Ms Analysis Services (BI-DW-Data mining)] 
* Implement BoaBaas DB Replication strategy between PROD-DEV environments maybe also for Backup
* Improve Business Alignment & Data Quality 
* Improve Application performance eg. using Caching
* Proof of concepts: 
** Parallel Computing(multi Cores & Threads) using Best practices & standards.
</PRE>

=== '''ASP.NET MVC Charting solution''' (done!)===
((('''Application with legacy Chart we wanted to improve''': 
 D:\Projecten\Brainnet Portal\SourceSafe\Extern\Brainnet.Portal\Classes\Charting.cs

Questions:
* Is there a better technique to insure a proper MVC chart? 
* Existing component(Telerik, MS, Other)? If not how should we create an wrapper to make it a reusable component? 

Answers:
* Telerik -> has no Reporting/Chart MVC variant
* Dundas -> see: [++KnowledgeBase.DotNET-Chart-Controls|Using the Chart Controls with ASP.NET]
* Crystal Reports (reporting tool) -> replaced after VS2008 with Microsoft own '''S'''QL '''S'''erver '''R'''eporting '''S'''ervices
* ??helpers MVC wrappers?? -> see: [++KnowledgeBase.ASP_DotNET-MVC|ASP.NET MVC]
)))

=== '''Mail migratie Infrastructuur solutions''' (done!)===
(((Huidige situatie: Ms Exchange 2007 server in Win2003 DC omgeving
Gewenste situatie: schaalbaar & kostbesparend mailoplossing 
Problemen:
 
* '''RAC'''
* '''UPS'''
* '''Server'''(s):
** 2x '''HP Servers''' Proliant DL?
** HP E5000 Messaging System: 
*** [http://www.stevieg.org/2011/01/hp-to-release-the-hp-e5000-exchange-appliances-what-are-the-offerings-and-why-do-you-need-them/|HP E5000 Messaging System (2xBlades) Review]
*** [http://h20195.www2.hp.com/V2/GetPDF.aspx/4AA3-3433ENW.pdf|Load balancing best practices for the HP E5000]

* '''Opslag:'''
** [http://h71016.www7.hp.com/dstore/ctoBases.asp?oi=E9CED&BEID=19701&SBLID=&ProductLineId=450&FamilyId=2394&LowBaseId=28070&LowPrice=$419.00&familyviewgroup=2640&viewtype=Matrix|'''NAS''' HP StorageWorks] 
** '''SAN''' >= 50x50Gb RAID 10

* '''Backup''' with De-duplication
** [http://h71028.www7.hp.com/enterprise/us/en/solutions/storage-data-protection-with-deduplication.html]
** [http://h10010.www1.hp.com/wwpc/us/en/sm/WF25a/12169-304616-3755723-3755723-3755723-3896393.html]

* '''Artikelen''' 
** [http://technet.microsoft.com/en-us/exchange/cc671168%28EXCHG.80%29.aspx|Planning for Large Mailboxes for Exchange2007]
** [http://www.microsoft.com/belux/technet/fr/chopsticks/default.aspx?id=658|HP-oplossingen rond virtualisatie]
** Mailbox Storage Design? 
*** [http://www.simple-talk.com/sysadmin/exchange/upgrade-exchange-2003-to-exchange-2010/|Upgrade Exchange2003 to 2010]
*** [http://www.simple-talk.com/sql/performance/high-performance-storage-systems-for-sql-server/|High performance storage systems for SQL server]
*** [http://www.simple-talk.com/sql/database-administration/planning-for-disaster/|Planning for disaster]
*** [http://wikibon.org/wiki/v/Managing_Archiving_and_Retention_Risk|Managing Archiving and Retention Risk]

* '''Software & services'''
** Windows 2008 R2 x64
** Exchange 2010 50x50GB p/mailbox (without mail Attachments redundancy!)
** Cloud Based (GMAIL/Exchange BPOS- Office 365) ?
*** [http://www.microsoft.com/exchange/en-us/exchange-online.aspx]
*** [http://office365.microsoft.com/en-US/online-services.aspx]
)))


