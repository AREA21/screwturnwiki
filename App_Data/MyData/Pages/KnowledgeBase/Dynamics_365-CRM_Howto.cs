Dynamics CRM: How-to
procm|2019/03/26 16:42:53
##PAGE##
{TOC}

=== How to check .NET versions installed?===
<PRE>
 dir /b /ad /o-n %systemroot%\Microsoft.NET\Framework\v?.* 
</PRE>

=== How to Ping a port using C#?===
<PRE>
 System.Net.Sockets.TcpClient tcpClient = new System.Net.Sockets.TcpClient(endpoint, 5672);
</PRE>

=== How to handle JSON messages===
<PRE>
* [http://json2csharp.com|Generate C# classes from json]
* [https://www.jsonschema.net|Generates JSON schema from JSON]
* [https://www.newtonsoft.com/json/help/html/Introduction.htm|Json.NET Documentation]
* ...
</PRE>

=== What's new: Dynamics 365 v9.0===
<PRE>
==== Customer Engagement====
* [https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/developer-guide|Dynamics 365 Customer Engagement Developer Guide (formerly referred to as the Dynamics 365 SDK)]
** [https://docs.microsoft.com/en-us/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming|Some Client API's are deprecated!]
** [https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/clientapi/understand-clientapi-object-model|Understand the Client API object model]
** [https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/clientapi/reference/controls|Controls (Client API reference)]

((('''Customer Engagement''':
* Sales
* Customer Service
* Field Service
* '''P'''roject '''S'''ervice '''A'''utomation
* ...and their related services.
)))

==== --Finance & Operations--====

</PRE>

=== Monitor & Troubleshooting (Microsoft Dynamics CRM/365)===
<PRE>
* '''Monitor and troubleshoot Microsoft Dynamics 365''': [https://technet.microsoft.com/en-us/library/hh699694.aspx]

* '''Logging'''
** [https://community.dynamics.com/crm/b/salimadamondynamicscrm/archive/2013/08/14/error-logging-options-in-crm|Error logging options in CRM]
*** [http://www.stunnware.com] or [http://www.donaubauer.com]
** [http://www.cobalt.net/what-server-logs-are-useful-for-troubleshooting-dynamics-crm|What server logs are useful for troubleshooting Dynamics CRM]
** [http://www.langalaxy.de/2009/09/crm-log-file-locations|CRM Log file locations]

* '''deDuplication: Preventing Duplicates'''
** [http://eimagine.com/preventing-duplicate-contacts-in-dynamics-crm-and-outlook|Preventing duplicate Contacts in Dynamics CRM & Outlook]
** [https://www.magnetismsolutions.com/blog/colinmaitland/2013/08/04/deduplication-of-data-during-import-using-data-import-wizard-and-duplicate-detection-rules|deDuplication using data Import wizard and Duplicate Detection Rules]
** [http://crmbook.powerobjects.com/basics/data-management-in-microsoft-dynamics-crm/keeping-data-clean-in-microsoft-dynamics-crm|Keeping Data Clean in Microsoft Dynamics 365]
</PRE>

=== Demystifying Dynamics WebAPI===
<PRE>
* [https://docs.microsoft.com/en-us/previous-versions/dynamicscrm-2016/developers-guide/mt607829(v=crm.8)|WebAPI Action Reference]
* [https://community.dynamics.com/crm/b/debajitcrm/archive/2016/11/02/new-feature-get-the-created-object-after-creating-a-record-using-web-api-in-dynamics-365|+++Get the created object after creating a record using Web API in Dynamics 365]
</PRE>

=== Improve performance===
<PRE>

==== Using Parallelism====
* Foreach loop:
** Iterations takes place sequentially, one by one
** foreach loop is run from a single Thread.
** foreach loop is defined in every framework of .NET
** Execution of slow processes can be slower, as they're run serially
*** Process 2 can't start until 1 is done. Process 3 can't start until 2 & 1 are done...
** Execution of quick processes can be faster, as there is no threading overhead

* Parallel.ForEach:
** Execution takes place in parallel way.
** Parallel.ForEach uses multiple Threads.
** Parallel.ForEach is defined in .Net 4.0 and above frameworks.
** Execution of slow processes can be faster, as they can be run in parallel
*** Processes 1, 2, & 3 may run concurrently (see reused threads in example, below)
** Execution of quick processes can be slower, because of additional threading overhead

{@code-csharp:
// Code syntax:
Parallel.ForEach(collection, item => 
{
	// code
});
@}

==== Using Batch Requests====


</PRE>

=== Plugins===
<PRE>
==== Overview====
* [https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/process-architecture|Process Architecture]
* [https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/process-categories|Process Categories]
* [https://docs.microsoft.com/en-us/dynamics365/customer-engagement/developer/workflow/use-iorganization-web-service-custom-workflow-activity|Use the IOrganization web service in a custom workflow activity]
* [https://docs.microsoft.com/en-us/previous-versions/dynamicscrm-2016/developers-guide/mt607829(v=crm.8)|Web API Action Reference]

==== Create==== 
* Download & Install Dynamics CRM SDK20xx

* Create Visual Studio "Class Library" project 
** naming convention: CBR.{projectname}.Plugins ??

* Add References to CRM SDK libraries (here the SDK was installed in the '''BIN''' folder)
** Microsoft.Crm.Sdk.Proxy
** Microsoft.Xrm.Sdk
** System.ServiceModel
** System.Runtime.Serialization

* Add the following '''Using'''s:
** Using Microsoft.Xrm.SDK

* Signing the (project) assembly

* Change the (project) '''Target framework'''  to '''.NET Framework 4.5.2'''

* In this plugin Class implement IPlugin
** eg.: Public void Execute(ServiceProvider svc)

((('''Resources''':
* [https://crmbusiness.wordpress.com/2015/07/01/stopping-infinite-plugins-with-parameters-depth-and-parentcontext|Stopping infinite loops & understanding '''PluginExecutionContext.Depth'''] 
* [https://www.youtube.com/watch?v=eYHIwfYGZOM|Writing a Plugin in MS CRM 2015]
* [https://msdn.microsoft.com/en-us/library/gg328574.aspx|Debug a plug-in]
* [https://msdn.microsoft.com/en-us/library/gg309620.aspx|Register and Deploy Plug-Ins]
)))

==== Custom actions====
* [http://www.powerobjects.com/2014/07/23/4-important-concepts-helpful-understand-actions-dynamics-crm|Four Important Concepts Helpful in Understanding Actions in Dynamics CRM]
* [http://blogs.microsoft.co.il/rdt/2016/01/13/executing-custom-action-via-javascript|Web API: Executing Custom Action via JavaScript]
* [http://missdynamicscrm.blogspot.nl/2014/05/crm-2013-register-custom-action-as.html|Register custom action]

==== Debug code====
* '''Plugin profiler''' (Plugin Registration tool)
** [https://dynamics365blocks.wordpress.com/2016/12/06/how-to-debug-a-plugin-in-dynamics-365-online-using-plugin-profiler|How to debug a plugin in Dynamics 365 online using Plugin Profiler]
* or '''Remote Debugging''' (on the CRM server)

* [https://crmdynamicsblog.wordpress.com/2016/01/09/create-log-in-plug-in-using-custom-entity|Create log in Plug-in using Custom Entity]
* [https://community.dynamics.com/crm/b/crmeventexecutionpipeline/archive/2016/04/17/plugin-error-to-entity-microsoft-dynamics-crm|Plugin Error to Entity Microsoft Dynamics CRM]

==== Tracing & Logging====
* [http://www.magnetismsolutions.com/blog/ahmed-anwar's-blog/2015/06/04/tracing-and-logging-plugins-in-dynamics-crm-2015-online|Dynamics CRM 2015 Online]
* Dynamics CRM 2016 Online:
** Settings -> Administration -> System Settings 
** Customization(tab) -> Plug-in and custom workflow activity tracing -> Enable logging to plug-in log choose {Off|'''All'''|'''Exception'''}
</PRE>

=== Localization, Multiple languages===
<PRE>
* [https://msdn.microsoft.com/library/hh670609.aspx|Create solutions that support multiple languages] 
</PRE>

=== Workflows, proccess===
<PRE>
==== [https://ribbonworkbench.uservoice.com/knowledgebase/articles/132235-create-a-workflow-short-cut-ribbon-button-no-code|How to run a Workflow on a Ribbon button]====
</PRE>

=== Webservices===
<PRE>
* [http://www.karthikscorner.com/sharepoint/svcutil-exe-vs-wsdl-exe-proxy-generation-tools|Proxy generation tools: '''svcutil.exe''' vs '''wsdl.exe''']
</PRE>

=== CRM JavaScript===
<PRE>
==== Read the GUID's====
<PRE>
'''Entity record'''
* using the browser console execute
** <nowiki>frames[0].Xrm.Page.data.entity.getId();</nowiki>
* or create a favorite with the following code inside it:
**  <nowiki>javascript:(function() {window.prompt('Record ID:',frames[0].Xrm.Page.data.entity.getId())})();</nowiki> 

'''Logged User ID'''
* <nowiki>frames[0].Xrm.Page.context.getUSerId;</nowiki>
</PRE>

==== [https://msdn.microsoft.com/nl-nl/en-en/library/hh771584(v=crm.7).aspx|Use JavaScript within Microsoft Dynamics CRM]==== 
==== [https://dynamicscrmgirl.wordpress.com/2014/01/04/crm-2013-javascript-retrieve-record-using-odatarest-endpoint-without-jquery|Retrieve record using OData/REST endpoint using JavaScript without jQuery]====

==== CRM WebAPI/ODATA:====
<PRE>
{@code-javascript:
// SingleRetrieve: <nowiki>

var req = new XMLHttpRequest();
req.open("GET", Xrm.Page.context.getClientUrl() + "/api/data/v8.0/ten_configuraties()?$select=ten_postcodecheck", false);
req.setRequestHeader("OData-MaxVersion", "4.0");
req.setRequestHeader("OData-Version", "4.0");
req.setRequestHeader("Accept", "application/json");
req.setRequestHeader("Content-Type", "application/json; charset=utf-8");
req.setRequestHeader("Prefer", "odata.include-annotations=\"OData.Community.Display.V1.FormattedValue\"");
req.onreadystatechange = function () {
    if (this.readyState === 4) {
        req.onreadystatechange = null;
        if (this.status === 200) {
            var result = JSON.parse(this.response);
            var ten_postcodecheck = result["ten_postcodecheck"];
            var ten_postcodecheck_formatted = result["ten_postcodecheck@OData.Community.Display.V1.FormattedValue"];
        }
        else {
            alert(this.statusText);
        }
    }
};
req.send();
//EOF: </nowiki>
@}

{@code-javascript:
// MultipleRetrieve: <nowiki>

req.open("GET", Xrm.Page.context.getClientUrl() + "/api/data/v8.0/ten_configuraties?$select=ten_postcodecheck", false);
req.onreadystatechange = function () {
    if (this.readyState === 4) {
        req.onreadystatechange = null;
        if (this.status === 200) {
            var results = JSON.parse(this.response);
            for (var i = 0; i < results.value.length; i++) {
                 var ten_postcodecheck = results.value[i]["ten_postcodecheck"];
                 var ten_postcodecheck_formatted = results.value[i]["ten_postcodecheck@OData.Community.Display.V1.FormattedValue"];
            }
        }
        else {
            alert(this.statusText);
        }
    }
};
req.send();
//EOF: </nowiki>
@}
</PRE>{TOP}

</PRE>


=== Adding a custom '''ASPX''' page to Dynamics CRM===
<PRE>
* Export solution: Settings>Customizations>Export Customizations
* You can add custom aspx pages into any forms or new ones. 
** Create an iframe and set the source as your aspx page which should reside in CRM server itself. You have to do it by yourself as their is no provision for CRM to do by itself.
</PRE>

=== Querying: FetchXML===
<PRE>
==== [https://msdn.microsoft.com/en-us/library/dn531006.aspx|Use a Left '''Outer''' Join in FetchXML to query for records "not in"]====
===== Find all accounts that have no leads=====
{@code-xml:
<fetch mapping='logical'>
  <entity name='account'>
    <attribute name='name'> </attribute>
    <link-entity name='lead' from='leadid' to='originatingleadid' link-type='outer'> </link-entity>
    <filter type='and'>
      <condition entityname='lead' attribute='leadid' operator='null'> </condition>
    </filter>
  </entity>
</fetch>
@}

===== Find all leads that have no tasks, using an alias=====
{@code-xml:
<fetch version="1.0" output-format="xml-platform" mapping="logical" distinct="true">
  <entity name="lead">
    <attribute name="fullname"> </attribute>
    <link-entity name="task" from="regardingobjectid" to="leadid" alias="ab" link-type="outer">
       <attribute name="regardingobjectid"></attribute>
    </link-entity>
    <filter type="and">
       <condition entityname="ab" attribute="regardingobjectid" operator="null"> </condition>
    </filter>
  </entity>
</fetch>
@}

===== This is equivalent to the following SQL=====
{@code-sql:
SELECT lead.FullName
FROM Leads as lead
LEFT OUTER JOIN Tasks as ab
ON (lead.leadId  =  ab.RegardingObjectId)
WHERE ab.RegardingObjectId is null
@}
</PRE>

