Microsoft Dynamics CRM
procm|2016/10/04 10:58:43|(((Dynamics,CRM)))((()))
##PAGE##
{TOC}
=== [Ciber_DynamicsCRM_Howto|Dynamics CRM: How-to]===

=== [Ciber_DynamicsCRM_TemplatesAndTools|Dynamics CRM: Templates & Tools]===

=== [Ciber_DynamicsCRM_TechnicalResources|Dynamics CRM: Technical Resources]===

=== [Ciber_DynamicsCRM_ConventionsAndStandards|Dynamics CRM: Conventions & Standards]===


=== CRM versions===
<PRE>
* CRM 1.0 *Tsunami
* CRM 1.2 *Danube Phase I
* CRM 3 *Danube Phase II
* CRM 4 *Kilimanjaro/Titan
* CRM 2011 *Polaris
* CRM 2013 => v.6.0.0 *Orion (Major Release)
* CRM 2013 => v.6.1.0 *Leo (Minor Release)
* CRM 2015 => v.7.1 *Vega
** CRM 2015 => v.7.1.2.1033 (CRM Online 2015 Update1) *Carina
* CRM 2016 => v.8.1.0.0452 *Ara

[https://blogs.msdn.microsoft.com/crm/2015/04/14/new-naming-conventions-for-microsoft-dynamics-crm-updates|New naming conventions] 
</PRE>

=== CRM2015 changes===
<PRE>
+ Hierarchy Security, 
+ Field Level Security, secure out-of-box fields eg.: Personal Identifiable Information
</PRE>

=== CRM2016 (Breaking) Changes===
<PRE>
* Connect to Dynamics CRM 2016
** Authenticate Users (Claims based(SAML), AD, OAuth 2.0)
*** Use Services
**** Organization service (SOAP endpoint)
(((choose this for compatability & when u don't need to support multiple platforms)))
**** OganizationData service (ODATA 2.0/REST), deprecated -> 2016 ODATA v.4  
**** WebAPI (new ODATA v.4) 
(((Future replacement of Organization service- but for now use only on client side because it is not fully ready yet)))
</PRE>

=== Security model===
<PRE>
* Users => Security Roles
* TEAMs => allow users to collaborate through TEAMS
* Business Units => Expand or Restrict Access
</PRE>

=== Plugins Creation/Registration===
<PRE>
* Event Pipeline
** Pre-Event => stage 10: Pre-Validation 
** Transation scope
*** Pre-Event => stage 20: Pre-Operation
*** Core operation => stage 30: Main Operation
*** Post-Event => stage 40: Post-Operation 

Register Plugins via Plugin Registration Tool (within CRM SDK)
</PRE>

=== Retrieving Data===
<PRE>
(((Microsoft Dynamics CRM provides two main mechanisms for querying data from Microsoft Dynamics CRM, FetchXML and QueryExpression. 
In general, it is recommended to use QueryExpression over FetchXML because of its better performance and strongly typed results.  
But, FetchXML is handy when you need attributes from multiple entities in a single query.)))

* Simple Retrieve
* Retrieve Multiple => Query Expression & FetchXML
* via LinQ => Query Expression.

* Query Expression:
** can query only one Entity type at a time
** Support Aggregate & Grouping

* FetchXML
** Query multiple Entity types at the same time as long as there is a relationship between the types.
** Support Aggregate & Grouping
</PRE>


