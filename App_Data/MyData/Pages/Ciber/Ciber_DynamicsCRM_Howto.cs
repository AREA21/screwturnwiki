Dynamics CRM: How-to
procm|2016/09/21 15:33:12
##PAGE##
{TOC}

=== Create Plugins===
<PRE>
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
§§(procm,2016/09/06 12:10:40)§§

==== Plugins: Tracing & Logging====
<PRE>
* [http://www.magnetismsolutions.com/blog/ahmed-anwar's-blog/2015/06/04/tracing-and-logging-plugins-in-dynamics-crm-2015-online|Dynamics CRM 2015 Online]
* Dynamics CRM 2016 Online:
** Settings -> Administration -> System Settings 
** Customization(tab) -> Plug-in and custom workflow activity tracing -> Enable logging to plug-in log choose {Off|'''All'''|'''Exception'''}
</PRE>
</PRE>


=== CRM JavaScript===
<PRE>
* [https://msdn.microsoft.com/nl-nl/en-en/library/hh771584(v=crm.7).aspx|JavaScript gebruiken met Microsoft Dynamics CRM]
* [https://dynamicscrmgirl.wordpress.com/2014/01/04/crm-2013-javascript-retrieve-record-using-odatarest-endpoint-without-jquery|JavaScript, Retrieve record using OData/REST endpoint without jQuery]

'''Get GUID of entity'''(record)
* using the browser console execute
** <nowiki>frames[0].Xrm.Page.data.entity.getId()</nowiki>

*Or create a favorite with the following code inside it:
**  <nowiki>javascript:(function() {window.prompt('Record ID:',frames[0].Xrm.Page.data.entity.getId())})();</nowiki> 
</PRE>

=== Debug code===
<PRE>
* Plugin profiler (Plugin Registration tool)
* Remote Debugging (on the CRM server)
</PRE>

=== Adding custom aspx page in CRM===
<PRE>
* Export solution: Settings>Customizations>Export Customizations
* You can add custom aspx pages into any forms or new ones. 
** Create an iframe and set the source as your aspx page which should reside in CRM server itself. You have to do it by yourself as their is no provision for CRM to do by itself.
</PRE>
