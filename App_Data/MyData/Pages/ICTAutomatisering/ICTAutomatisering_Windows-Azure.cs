Windows Azure (MANNA)
procm|2014/02/25 17:11:10
##PAGE##
{TOC}

=== Competences===
<PRE>
* Certificates
** PKI '''X.509''' - Public Key Infrastructure 
** PKCS 12 or P12, [http://en.wikipedia.org/wiki/PKCS_12]
*** It is commonly used to bundle a '''private key''' with its '''X.509''' certificate or to bundle all the members of a chain of trust.
** [http://en.wikipedia.org/wiki/Server_Name_Indication|SNI certificates, cheaper alternative to wildcard(*) certificates]

* REST(full) API
* OAUTH
</PRE>

=== Tools===
<PRE>
==== Upgrade .NET & MVC versions====
* install '''Auto Upgrade MVC 3 To MVC 4''' plugin, run the following command (in Visual Studio '''Package Manager Console''') 
** PM> Install-Package UpgradeMvc3ToMvc4
** [http://www.dotnetexpertguide.com/2011/12/upgrade-aspnet-mvc-3-project-to-mvc-4.html|Overview: Upgrading MVC 3 Project to MVC 4]
** [http://www.asp.net/whitepapers/mvc4-release-notes#_Toc303253806|Upgrading an ASP.NET MVC 3 Project to ASP.NET MVC 4]

==== WsFederation (local) services==== 
* run: C:\T\MijnPost\Dev\Manna\Tooling\LocalSTS\start.bat

==== [http://martijn.tikkie.net/apps|Martijn Stolk apps]====
* [https://github.com/netripper/AzureLogViewer|'''Azure Log Viewer'''(GitHub)]
* [https://github.com/netripper/SvclogViewer|'''SVCLog Viewer'''(GitHub)]
</PRE>
