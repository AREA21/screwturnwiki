Dynamics CRM: How-to
procm|2017/03/22 14:12:18
##PAGE##
{TOC}

=== Monitor & Troubleshooting (Microsoft Dynamics CRM/365)===
<PRE>
* '''Monitor and troubleshoot Microsoft Dynamics 365''': [https://technet.microsoft.com/en-us/library/hh699694.aspx]

* '''Logging'''
** [https://community.dynamics.com/crm/b/salimadamondynamicscrm/archive/2013/08/14/error-logging-options-in-crm]
** [http://www.stunnware.com] or [http://www.donaubauer.com]
** [http://www.cobalt.net/what-server-logs-are-useful-for-troubleshooting-dynamics-crm]
** [http://www.langalaxy.de/2009/09/crm-log-file-locations]
</PRE>

=== Plugins===
<PRE>
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
* Plugin profiler (Plugin Registration tool)
* Remote Debugging (on the CRM server)

==== Tracing & Logging====
* [http://www.magnetismsolutions.com/blog/ahmed-anwar's-blog/2015/06/04/tracing-and-logging-plugins-in-dynamics-crm-2015-online|Dynamics CRM 2015 Online]
* Dynamics CRM 2016 Online:
** Settings -> Administration -> System Settings 
** Customization(tab) -> Plug-in and custom workflow activity tracing -> Enable logging to plug-in log choose {Off|'''All'''|'''Exception'''}
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

=== FetchXML Querying===
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

