ICT Automatisering index
procm|2014/02/21 09:36:44
##PAGE##
'''I'''ndustriële '''C'''omputing '''T'''oepassingen ('''ICT''') Automatisering
: summary:...

{TOC}

=== ICT Automatisering===
<PRE>
* [ICTAutomatisering_Infra|General]
* [ICTAutomatisering_Ideas|IDEAS]
* [ICTAutomatisering_Tools-Technologies|Tools & Technologies]
* [ICTAutomatisering_Terminology|Terminology, Systems & apps names]
* [ICTAutomatisering_Hardware|Hardware]

<msg type=caution>
  [https://intranet.ict.nl/C1256F38001F1D5D/INETPage/ykOqMUeF?open|ICT Automatisering Boeken Bestellen]
</msg>
</PRE>

=== Windows Azure===
<PRE>
==== Competences====
* Certificates
** PKI '''X.509''' - Public Key Infrastructure 
** PKCS 12 or P12, [http://en.wikipedia.org/wiki/PKCS_12]
*** It is commonly used to bundle a '''private key''' with its '''X.509''' certificate or to bundle all the members of a chain of trust.
** [http://en.wikipedia.org/wiki/Server_Name_Indication|SNI certificates, cheaper alternative to wildcard(*) certificates]

* REST(full) API
* OAUTH

==== Tools====
===== Upgrade .NET & MVC versions=====
* install '''Auto Upgrade MVC 3 To MVC 4''' plugin, run the following command (in Visual Studio '''Package Manager Console''') 
** PM> Install-Package UpgradeMvc3ToMvc4
** [http://www.dotnetexpertguide.com/2011/12/upgrade-aspnet-mvc-3-project-to-mvc-4.html|Overview: Upgrading MVC 3 Project to MVC 4]
** [http://www.asp.net/whitepapers/mvc4-release-notes#_Toc303253806|Upgrading an ASP.NET MVC 3 Project to ASP.NET MVC 4]

===== WsFederation (local) services===== 
* run: C:\T\MijnPost\Dev\Manna\Tooling\LocalSTS\start.bat

===== [http://martijn.tikkie.net/apps|Martijn Stolk apps]=====
* [https://github.com/netripper/AzureLogViewer|'''Azure Log Viewer'''(GitHub)]
* '''SVCLog Viewer'''
</PRE>

=== Motorola RhoMobile===
<PRE>
'''RhoHub'''

* Test SSH access
** ssh -T -p 22 git@firewall.git.rhohub.com (not working)

* Clone ScanClient (cloud) GIT repository (via GIT Bash):
** $ git clone git@git.rhohub.com:procm/ScanClient.git ScanClientClone
*** [http://docs.rhomobile.com/en/2.2.0/rhohub/tutorial#creating-a-rhoconnect-app|How-to setup Git]

'''Building commands''' (local):
* rake -T (Help!)
* rake run:android
* rake clean:android
* rake device:android:production

* Debug build commands 
** rake --trace config:android

==== Competencies====
* '''M'''odel '''V'''iew '''C'''ontrol
* Git, version control

* Ruby
** Rhodes framework, similar to the popular Rails framework
*** Rhom, ORM-mapper
** Heroku, Ruby Cloud

* HTML
* CSS

* Database
** '''SQLite''' in all platforms & '''HSQL''' as exception for BlackBerry

* Device API (access device capabilities!)
** GPS, PIM(contracts & calendar), Camera, Native mapping, Push, Signature capture, Barcode, Bluetooth  

* Rest API
** RhoConnect

</PRE>

=== Available courses===
* [https://intranet.ict.nl/opleiding/CURSUS.NSF/cc139b09a5f34a8ac12565f70049007a/1fc25db633640abec125722c003cade1?OpenDocument|Object Oriented Analysis & Design using UML (ANO406)]
* [https://intranet.ict.nl/opleiding/CURSUS.NSF/cc139b09a5f34a8ac12565f70049007a/92c42a6edf0ea6cbc1257403002f44f9?OpenDocument|Model-Driven Development ]
* [https://intranet.ict.nl/opleiding/CURSUS.NSF/cc139b09a5f34a8ac12565f70049007a/1fa0a6dcefb4e335c12577f9004b94ba?OpenDocument|In-company training .NET Foundation] 
* [https://intranet.ict.nl/opleiding/CURSUS.NSF/cc139b09a5f34a8ac12565f70049007a/2c1808b63d4b0cf2c12577c8002dd568?OpenDocument|In-company training .NET Intermediate]
* [https://intranet.ict.nl/opleiding/CURSUS.NSF/cc139b09a5f34a8ac12565f70049007a/9f31bb7336267733c1257a5400437bcf?OpenDocument|Gecertificeerd Software Architect]

