Monitoring Tool
procm|2014/06/13 17:03:45
##PAGE##
{TOC}

=== Casus===
<PRE>
[imageAuto|MonitoringTool brainstorm|{UP}/ICTA/MonitoringTool/MonitoringTool brainstorm.jpg]
==== Huidige situatie====
* '''Microsoft SCOM'''
** langzaam, niet toereikend
** duur >10min om problemen te melden
** '''werking''': Lees Performance Monitor info/counters (uit Azure Tables & Blog Storage) elke '''XX''' min  
*** Performance Monitor counters worden in een buffers geplaatst en elke ??min weggeschreven naar "durable" Azure Storage

* '''Azure Management Portal'''
** liet geen problemen zien maar sites wel gestopt (business downtime)
** te hoge-niveau zicht om (diepere) gezondheid problemen van gehosted applicaties te onderkennen

* '''Visual Studio Online'''
** Remote debugging/Load Test beperkt tot 3x regionale tests
** Zwaar pakket met afwijkende resultaten die zwaar beïnvloed zijn door niet te managen factoren 

==== Gewenste situatie====
* Proactief-monitoring zie: [http://insightsgtd.nl/1n8QdBj|implementing '''Reactive Manifesto''']
* SLA compliance
** Responsetijd waarborgen  
</PRE>{TOP}

=== Open vragen===
<PRE>
* Hoe zit de infra in elkaar?
** bijv. zijn de SAP services direct te benaderen?
** welke credentials voor Autorisatie & authenticatie?
** SSL communicatie nodig? 
* Windows Azure blokkades?
** beperkingen: tcp/ip connecties, etc
</PRE>{TOP}

=== Azure Management & Health Monitoring===
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
(((If you are familiar with System Center Operations Manager (SCOM,) you may want to use the Azure Management Pack to make Azure diagnostics information available within SCOM.)))
</PRE>{TOP}

=== Technologies===
<PRE>
* Microsoft Azure API Management / WAD- Windows Azure Diagnostics
* [http://social.technet.microsoft.com/wiki/contents/articles/17987.cloud-service-fundamentals.aspx|Telemetry in Azure]
** [http://aspnetresources.com/articles/aspnet_2_0_health_monitoring|Keeping Pulse on Your Site with ASP.NET 2.0 Health Monitoring]
* Microsoft CodeUI / Selenium 
* SignalR / WebRTC (websockets) / Reactive Manifesto 
* HTTP class (request, response) object
* SOAPUI?? SAP services testen

==== Resources====
* [http://insightsgtd.nl/1qEFDEJ|JustAzure, Microsoft Azure Diagnostics Part 1]
* [http://social.technet.microsoft.com/wiki/contents/articles/18146.windows-azure-telemetry-basics-and-troubleshooting.aspx|Windows Azure: Telemetry]
** [http://msdn.microsoft.com/library/azure/hh694039.aspx|Monitoring an Azure Application]
** [http://azure.microsoft.com/en-us/documentation/services/api-management|Microsoft Windows Azure API Management]
*** [http://go.microsoft.com/fwlink/?LinkId=236191|Azure Service Management REST API Reference]

==== Tools====
* Monitoring
** System Center Operations Manager(MS SCOM)
** [http://www.manageengine.com/free-azure-performance-monitor/free-azure-performance-monitor-index.html|Manage Enginer Azure]
** [http://www.newrelic.com/azure|NewRelic Azure]
** [http://www.uptrends.nl|Uptrends]
** [http://www.paraleap.com|AzureWatch]
** [www.site24x7.com|Site24x7]
** [http://www.cerebrata.com/products/azure-management-studio/features|Red-Gate Cerebrata]

* Testing
** [http://azurespeedtest.azurewebsites.net|Azure Speedtest (Blob Storage Latency)]
** [https://www.blitz.io|Blitz.io, Load Testing Tool from the Cloud]
** [http://loadstorm.com|Loadstorm, Load Testing Tool from the Cloud]

* Reviews & Blogs
** [http://www.getapp.com/azurewatch-application|AzureWatch alternative]
** [http://www.getapp.com/new-relic-application|New-relic alternative]
** [https://michaelmckeownblog.wordpress.com/2013/03/05/analysis-of-metricshub-as-as-azure-monitoring-option/comment-page-1|Analysis of MetricsHub as as Azure Monitoring Option]
** [http://techmike2kx.wordpress.com/2013/08/23/10-tools-of-the-trade-for-your-windowsazure-environment|10 tools of the trade for your '''Windows Azure''' environment]
</PRE>{TOP}

=== ToDO===
<PRE>
* Evaluate/Compare (Azure) Monitoring tools
** '''COTS''' of '''in-house''' tool bouwen??

* TFS CheckOut:
** Stopbordje / SOMA -> C:\t\Stopbordje
** SmartPortal -> C:\t\SmartPortal 
*** [https://ictnv.visualstudio.com/DefaultCollection/Logistics SmartPortal|SmartPortal on TFS]
*** [https://www.yammer.com/ict.nl/#/threads/inGroup?type=in_group&feedId=4413973|SmartPortal on Yammer]
*** [https://humiqtrial.sharepoint.com/sites/LogisticsOperation/LogProductontwikkeling/SmartPortal/_layouts/15/start.aspx|SmartPortal wiki on Sharepoint]
</PRE>{TOP}