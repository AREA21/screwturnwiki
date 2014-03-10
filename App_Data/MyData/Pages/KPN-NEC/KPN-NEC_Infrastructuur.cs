KPN-NEC Infrastructuur 
celio|2010/04/26 15:50:11
##PAGE##
	
:'''Login codes & also Knowledgebase'''

<pre>
* Ms Outlook \\Public Folders\All Public Folders\MVSD - notes\Operations\Accounts\SLA\SNT NEC\...
* [\\Joshua3\mvsd\Domeinen|KeePass(Password Manager)]
** R*****H***
</pre>

:'''Bea WebLogic''' Server (admin console)
<pre>
 [^http://testserver:7003/console]		
 Login: [\\Joshua3\mvsd\Domeinen|KeePass(Password Manager)]
</pre>

:'''NEC FB'''(Funcioneel Beheer) &amp; NEC applet
<pre>
 [^http://testserver:7001/fb]
 [^http://testserver:7003/fb]
</pre>	 

:'''Continuous Integration and Build Server''': [http://testserver:8080/continuum/]
<pre>
[http://en.wikipedia.org/wiki/Apache_Continuum|Apache Continuum] is an enterprise-ready continuous integration server with features such as automated builds, release management,
role-based security, and integration with popular build tools and source control management systems. Whether you have a centralized
build team or want to put control of releases in the hands of developers, Continuum can help you improve quality and maintain a
consistent build environment. 
</pre>

:'''Oracle''' DB tools
<pre>
 [http://testserver:5500/em]
 Login: [\\Joshua3\mvsd\Domeinen|KeePass(Password Manager)]

 [http://testserver:5560/isqlplus]
 Login: [\\Joshua3\mvsd\Domeinen|KeePass(Password Manager)]
</pre>

:'''OMS Server'''
<pre>
 Test-> 10.1.64.1:1526
 Productie-> 10.1.64.108:1527
</pre>

:'''Documentation'''
<pre>
 [http://intranet.mvsd.nl/sites/necsla/default.aspx|NEC SLA & Technical Documentation]
 [http://intranet.mvsd.nl/sites/necscripting/Shared%20Documents/Forms/AllItems.aspx|NEC Scripting Tool]
 [http://intranet.mvsd.nl/sites/KPN088/default.aspx|KPN 088-bedrijfsnummers] 
</pre>

:'''Test Links''' 
<pre>
 '''Applet                   ''': [http://test.nec.intranet.mvsd.local/nec3.htm]
 '''Scripting Tool           ''': [http://test.nec.intranet.mvsd.local/scripting]
 '''Functioneel Beheer       ''': [http://testserver:7003/fb]
 '''NEC-AX(Opus) Web Service ''': [http://testserver:7003/webservice/Command?WSDL] 
</pre>

:'''Sharepoint KPN Change Requests''' 
<pre>
 [https://connect-nl.getronics.com/sites/OOMS]
 [\\Joshua3\mvsd\Domeinen|KeePass(Password Manager)]

 [http://intranet.promentum.nl/KPN/Lists/Change%20requests/AllItems.aspx]
 [\\Joshua3\mvsd\Domeinen|KeePass(Password Manager)]
</pre>

:''' CheckPoint VPN + KPN token'''
<pre>
* open start folder: '''[\\insights\shared\Software\ICTAdmin\Network & communication\KPN-VPN\04B]'''
* run VPN client file: '''VPN-1_SecureClient_NGX_R60_HFA_02_Supplement_3_630002002(VISTA SP1).msi''' 
* copy configuration file: '''userc.C''' to '''[C:\Program Files\CheckPoint\SecuRemote\database]'''
* close VPN Client software(via taskbar yellow icon) & start it again to pick up the correct KPN-VPN settings.

:'''Token:''' [\\Joshua3\mvsd\Domeinen|KeePass(Password Manager)]
</pre>