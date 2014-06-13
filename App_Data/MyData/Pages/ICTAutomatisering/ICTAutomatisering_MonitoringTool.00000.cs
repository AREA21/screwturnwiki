Monitoring Tool
procm|2014/06/13 14:53:24
##PAGE##
{TOC}

== Casus==
<PRE>
=== Huidige situatie===
* '''Microsoft SCOM'''
** langzaam, niet toereikend
** duur >10min om problemen te melden
** werking: Lees Performance Monitor info/counters (uit Azure Tables & Blog Storage) elke XX min  
*** Performance Monitor counters worden in een buffers geplaatst en elke ??min weggeschreven naar "durable" Azure Storage

* '''Azure Management Portal'''
** liet geen problemen zien maar sites wel gestopt(business downtime)
** te hoge-niveau zicht om (diepere) gezondheid problemen van gehosted applicaties te onderkennen

* '''Visual Studio Online'''
** Remote debugging/Load Test beperkt tot 3x regionale tests
** Zwaar pakket met afwijkende resultaten die zwaar beïnvloed zijn door niet te managen factoren 

=== Gewenste situatie===
* Proactief-monitoring [http://insightsgtd.nl/1n8QdBj|implementing '''Reactive Manifesto''']
* SLA compliance
** Responsetijd waarborgen  
</PRE>{TOP}

== Open vragen==
<PRE>
* Hoe zit de infra in elkaar?
** bijv. zijn de SAP services direct te benaderen?
** welke credentials voor Autorisatie & authenticatie?
** SSL communicatie nodig? 
* Windows Azure blokkades?
** beperkingen: tcp/ip connecties, etc
</PRE>{TOP}

== Azure Management & Health Monitoring==
<PRE>
(((The Azure Management Portal status messages may not accurately reflect all failure conditions that occur for a hosted application, and should not be used as the sole method 
of determining the health of your application. For example, a failure that manifests as a failure on a web page, or improper rendering of a web page, would not trigger a status 
message in the management portal. To obtain more detailed information on the health of your application, you should use Azure Diagnostics.)))

* Azure Diagnostics (WAD) -> diagnostic process has a '''FIFO''' buffer
** performance counters & logs
*** IIS logs, Event Viewer Log (WMI)
** custom log files (eg. Elmah, NLog, Log4NET...)
** tracing
** intrumentation output produced by own application

* Performance counters & Logs
** [http://msdn.microsoft.com/library/azure/gg433048.aspx|Collect Logging Data by Using Windows Azure Diagnostics]
** Azure Management Pack
*** If you are familiar with System Center Operations Manager (SCOM,) you may want to use the Azure Management Pack to make Azure diagnostics information available within SCOM.
</PRE>{TOP}

== Technologies==
<PRE>
* Microsoft Azure API Management / WAD- Windows Azure Diagnostics
* [http://social.technet.microsoft.com/wiki/contents/articles/17987.cloud-service-fundamentals.aspx|Telemetry in Azure]
* Microsoft CodeUI / Selenium 
* SignalR / WebRTC (websockets) / Reactive Manifesto 
* HTTP class (request, response) object
* SOAPUI?? SAP services testen

=== Resources===
* Microsoft Azure Diagnostics Part 1: Introduction http://insightsgtd.nl/1qEFDEJ 
* [http://social.technet.microsoft.com/wiki/contents/articles/18146.windows-azure-telemetry-basics-and-troubleshooting.aspx|Windows Azure: Telemetry]
** [http://msdn.microsoft.com/library/azure/hh694039.aspx|Monitoring an Azure Application]
** [http://azure.microsoft.com/en-us/documentation/services/api-management|Microsoft Windows Azure API Management]
*** [http://go.microsoft.com/fwlink/?LinkId=236191|Azure Service Management REST API Reference]

=== Tools===
* Monitoring
** System Center Operations Manager(MS SCOM)
** [http://www.manageengine.com/free-azure-performance-monitor/free-azure-performance-monitor-index.html|Manage Engine, Azure Performance Monitor]
** [http://www.newrelic.com/azure|NewRelic Azure]
** [http://www.uptrends.nl|Uptrends]
** [http://www.paraleap.com|AzureWatch]

* Testing
** [http://azurespeedtest.azurewebsites.net|Azure Speedtest (Blob Storage Latency)]
** [https://www.blitz.io|Blitz.io, Load Testing Tool from the Cloud]
** [http://loadstorm.com|Loadstorm, Load Testing Tool from the Cloud]
</PRE>{TOP}

== ToDO==
<PRE>
* Stopbordje / SOMA -> C:\t\Stopbordje

* SmartPortal -> C:\t\ESort
** TFS workitens: https://ictnv.visualstudio.com/DefaultCollection/PostNL/e-Sort/_workItems 
** Yammer: https://www.yammer.com/ict.nl/#/threads/inGroup?type=in_group&feedId=4413973
** Sharepoint wiki: https://humiqtrial.sharepoint.com/sites/LogisticsOperation/LogProductontwikkeling/SmartPortal/_layouts/15/start.aspx#/
</PRE>{TOP}