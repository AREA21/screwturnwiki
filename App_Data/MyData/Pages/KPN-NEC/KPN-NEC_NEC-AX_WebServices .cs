NEC-AX webservices
celio|2011/03/04 17:04:41
##PAGE##
{TOC}

== Technical data==
[http://jira.mvsd.nl/browse/NEC-970|Integration NEC-AX(Opus) webservices documentation]

=== Microsoft Axapta(Ax)===

==== *'''W'''indows '''I'''ntegrated '''A'''uthentication*====
<pre>
 Endpoint URL: http://quercus0551s.quercus.kpn.org:90/DynamicsWebService/PRIAifMessageService.asmx?WSDL    
 Geen firewall tussen OPUS- en NEC servers
 SourceEndpointUser(TEST): 'KPNNL\WENNI601'
 SourceEndpoint: 'InterfacePortal'
 DestinationEndpoint(TEST): 'CW3'
 
 Updated account:
  KPN Windows AD server: w0761.kpnnl.local
  - Username: deege600
  - Password: 6845ma38
</pre>

==== *NO Authentication* (new version)====
<pre>
  '''WSDL''': [http://quercus0551s.thkt.twpl.telecom.ptt.nl:90/NECWebService/NECWebService.asmx?WSDL]
</pre>
=== NEC===
<pre>
 Bea Weblogic 8.1 SP6 (Jrockit JVM)
* Admin console NEC(Opus) Testserver* 
** [http://quercus0474v.quercus.kpn.org:7001/console]
* NEC webservice(WSDL)
** [http://quercus0474v.quercus.kpn.org:7001/webservice/Command?WSDL]
</pre>

== Webservices Overview==
[image||{UP:ScrewTurn.Wiki.FilesStorageProvider}/MVSD/KPN-NEC/Web Services/webservices overview.jpg]

== NEC consuming Ax(Opus) services using Windows Integrated Authentication==
goal: consume Microsoft Axapta(Ax) webservices which uses Http authentication(IIS configured with Windows Integrated Authentication)

=== implementation steps (Bea Weblogic 8.1)===
* develop new Identity Assertion and Authentication provider MBeans. 
** There are guides on how to do this in the WebLogic SSPI documentation.20
*** [http://edocs.bea.com/wls/docs81/dvspisec/index.html]

=== Resources===
[http://www.trick77.com/2008/02/25/sso-between-bea-weblogic-and-sap-enterprise-portal-using-web-services/]

'''[klerkd@xs4all.nl|David de Klerk]:''' [http://e-docs.bea.com/wls/docs92/secmanage/sso.html]

'''Programming WebLogic Web Services:''' [http://e-docs.bea.com/wls/docs81/webserv/index.html]

=== Activities Log ===
<pre>
* NEC-948 Verzoek tot impact analyse / offerte ivm NEC - Ax webservice interface '''4uur'''
* documentatie, vergaren gegevens, overige communicatie '''22uur'''
* vergadering Lenert, Andre Hooidonk, David Klerk '''3uur'''
* telefonische overleggen in voortraject en tijdens werkzaamheden en bijhorend email verkeer David Klerk '''8uur'''
* David Klerk's Proof of concept Windows Authenticatie(Kerberos) (9/07/2009) '''6uur'''
** Aanmaken virtuele omgeving voor Proof of concept (9/07/2009) '''1uur'''
** Herstellen Oracle omgeving naar aanleiding van Proof of concept werkzaamheden (13/07/09) '''4uur'''
* uren Marc:
** besprekingen, mailen, overleggen, informatie vergaren en lezen '''12uur'''
</pre>