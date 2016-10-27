Dynamics CRM: How-to
procm|2016/10/27 11:33:41
##PAGE##
{TOC}

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

==== Debug code====
* Plugin profiler (Plugin Registration tool)
* Remote Debugging (on the CRM server)

==== Tracing & Logging====
* [http://www.magnetismsolutions.com/blog/ahmed-anwar's-blog/2015/06/04/tracing-and-logging-plugins-in-dynamics-crm-2015-online|Dynamics CRM 2015 Online]
* Dynamics CRM 2016 Online:
** Settings -> Administration -> System Settings 
** Customization(tab) -> Plug-in and custom workflow activity tracing -> Enable logging to plug-in log choose {Off|'''All'''|'''Exception'''}
</PRE>

=== CRM JavaScript===
<PRE>
==== [https://msdn.microsoft.com/nl-nl/en-en/library/hh771584(v=crm.7).aspx|Use JavaScript within Microsoft Dynamics CRM]==== 
==== [https://dynamicscrmgirl.wordpress.com/2014/01/04/crm-2013-javascript-retrieve-record-using-odatarest-endpoint-without-jquery|Retrieve record using OData/REST endpoint using JavaScript without jQuery]==== 
==== Read the GUID of an Entity record====
* using the browser console execute
** <nowiki>frames[0].Xrm.Page.data.entity.getId()</nowiki>
*Or create a favorite with the following code inside it:
**  <nowiki>javascript:(function() {window.prompt('Record ID:',frames[0].Xrm.Page.data.entity.getId())})();</nowiki> 
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