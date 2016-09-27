Reporting Services (SSRS)
procm|2016/08/09 16:20:53
##PAGE##
{TOC}

=== '''S'''QL '''S'''erver '''R'''eporting '''S'''ervices===
<PRE>
HOWTO's:
* Auto. deploy report(rdl) directly to CRM2016 SSRS(online) from VS 2012?
** is this possible, how??

* Manual deploy report(rdl) file to CRM2016 SSRS online?
** Within CRM Online 
*** Sales|Service|Marketing - > Tools -> Reports
*** Search for the report & choose Edit
*** Upload de *.rdl file to CRM 

* Run the rapport which is available for Accounts?
** Within CRM Online 
*** Sales|Service|Marketing - > Accounts -> Choose one Account
*** Run Report -> Turnover

((('''NOTE''': Use '''pre-filtering''' on the report so that users could run the report from list views and advanced find but when using 
pre-filtering, FetchXML will return the max number of records allowed for a dataset (15001) unless otherwise specified and then filter 
by the pre-filter and reporting criteria after. By adding the count = `xxxx' into the header of the FetchXML, we can mitigate the issue. 
eg.: <esc><fetch count='500'...</esc>))) 
</PRE>

==== Resources:====
<PRE>
* [http://crmbook.powerobjects.com/system-administration/advanced-reporting-options|Advanced Reporting Options]
* [https://technet.microsoft.com/en-us/library/dn531183.aspx|Report writing with CRM 2016 for online and on-premises]
* [http://ronaldlemmen.blogspot.nl/2008/12/dynamics-crm-report-modification.html|Walkthrough Dynamics CRM Report Modification]
* [http://www.codeproject.com/Tips/1000276/Creating-a-SSRS-Report-With-Microsoft-Dynamics-CRM|Creating a SSRS Report With Microsoft Dynamics CRM On-line]
* [http://www.c2software.com/c2-blog/crm-online-reports-custom.aspx|Custom Reports with Microsoft Dynamics CRM Online]
* [https://blogs.msdn.microsoft.com/crminthefield/2012/11/27/custom-reporting-in-microsoft-dynamics-crm-fetch-vs-filtered-views|Custom Reporting in Microsoft Dynamics CRM – Fetch vs. Filtered Views]

'''Multi-language Reports''' (on-premise)
* [http://www.keepitsimpleandfast.com/2011/09/localization-of-your-ssrs-reports.html]
* [http://www.bdosolutions.com/ca/insights/creating-a-multi-lingual-ssrs-report-for-microsoft-dynamics-crm]
* [http://www.dutchdatadude.com/multilingual-ssrs-reports] 
</PRE>