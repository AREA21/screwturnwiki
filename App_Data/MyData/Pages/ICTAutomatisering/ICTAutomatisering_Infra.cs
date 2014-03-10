Infrastructuur
procm|2014/02/24 11:39:41
##PAGE##
{TOC}

=== Infra, servers===
<PRE>
* Certificates : [https://ca.ict.nl/p12]

* External IP Adress(es): 
** WiFi                     : 212.203.27.13 
** LAN & VPN (Cisco client) : 212.203.27.18

* Proxy server(s):
** FQDN(s)   : proxy.ict.nl, proxy.dev.ict.nl, proxy-3.dev.ict.nl 
** IP address: 192.168.13.12
** port      : 8080

* Barendrecht Location : '''bar.ict.nl''' -  192.168.61.1

* DB server    : '''vm0123.bar.ict.nl''' ...passw. in My keepass!
** Databases   : MyTNT_'''DEV''', MyTNT_'''STS'''
*** Tables (configuraties & autorisaties)     : dbo.ConfigItemDefinition, dbo.GenericValue, dbo.ConfigItemValue - dbo.GebruikerConfigItemValue, dbo.KlantConfigItemValue

==== Sharepoint Project docs, Collaboration (new!)====
[https://humiqtrial.sharepoint.com/sites/LogisticsHome/_layouts/15/start.aspx]
[https://humiqtrial.sharepoint.com/sites/LogisticsHome/Logistics-Sales/_layouts/15/start.aspx]
* Quotations
** (Top Menu) Sales 
*** (Tree view) PostNL/Quotations/2014/201402 - OVS WR14-02

(((
* '''Technical notes''': ..\mijnpost\02-Product\14-Technical notes (old Subversion repo.!)
** ..\01- PostNL serveromgeving
** ..\03 - Site2Site verbinding.doc
** ..\04- WebService Template
** ..\05- SAP Parallelle prijsverzoeken
** ..\06- ADFS 2.0 How-To
** ..\07- Using ACS with ADFS 2.0 )))

</PRE>

=== OTAP environment===
<PRE>
* PostNL(extern)
** '''P'''rod                 : *.mijnpost.postnl.nl
** p'''A'''t/GAT (acceptatie) : *.mijnpost.pat.postnl.nl
** '''T'''/'''TST'''est       : *.mijnpost.tst.postnl.nl

* ICT Auto.(intern)
** STS (test)
*** server                    :  \\'''vm0053.bar.ict.nl''', *.tntpost.nl
** DEV 
*** server (inc. SAP STUBS)   : \\'''vm0052.bar.ict.nl'''
**** dev\agtstub\TestData\{'''computername'''}
**** dev\agtstub\LogData\{'''computername'''}

: [https://cm11.cm.ict.nl/mijnpost_trac/wiki/Testgebruikers|'''PostNL TestUsers env.''']
</PRE>

=== Visual Studio TFS Solutions===

==== '''MijnPost'''====
<PRE>
: ..\Rel\2013_R4\Humiq.MijnPost.sln
(((01- MyTNT(MijnPost): Portaal, Publiek, *PPO, Facturen, Rapportage, *PUMA, B2B, Service: OrderService, 
    GebruikersService, AutorisatieService, ConfiguratieService, BeslisboomService
* Beheer
** PUMA, '''P'''ostNL '''U'''ser '''MA'''nagement *PostNL admins
*** KlantAdmin(s) via MijnPost instellingen!
* PPO, '''P'''artijen'''P'''ost '''O'''nline)))
</PRE>

==== '''AGT+PAK'''- joined Projects(AGT + PAK + Hybride)====
<PRE>
VS Solution(path): ..\Rel\2013_R4\Humiq.MyTNT.AgtPak.Project.sln

* Tip(s): 
** We must manually choose which Project to run {AGT | PAK | Hybride}
*** editing the '''Web.config''' key '''ApplicationType''' (((in ...\Rel\2013_R4\MyTNT\AgtPak\Impl\PresentationLayer)))

(((02 - AGT-PAK
* Aangetekend, Pakketen, *OBV, Services: *AWN, Campagne service, LabelGeneratie, PartyCode, Adresboek, BarcodeBoek
* Hybride-> Print & Verzend 
* AVA, '''A'''utomatische '''V'''erwerking '''A'''ntwoordnummers
* OBV, '''O'''ntvangst '''B'''e'''V'''estiging
* Selfservice
* TarievenTool-> running on Azure cloud!
* AWN, '''A'''nt'''W'''oord'''N'''ummers)))
</PRE>

=== URL (naming conventions)===
<PRE>
'''On Premise'''
* AGT/PAK
** [https://agt.sts.tntpost.nl]
** [https://aangetekend.mijnpost.tst.postnl.nl]
** [https://aangetekend.mijnpost.pat.postnl.nl]
** [https://aangetekend.mijnpost.postnl.nl]

* MijnPost
** [https://mytnt.sts.tntpost.nl/Start]
** [https://home.mijnpost.tst.postnl.nl/Start]
** [https://home.mijnpost.pat.postnl.nl/Start]
** [https://home.mijnpost. postnl.nl/Start]

* Overige
** https://selfservice.mijnpost.tst.postnl.nl

'''Windows AZure'''
* https://{'''appname'''}.{'''waz'''}.mijnpost.{'''waz'''}.{'''TA'''}.postnl.nl
** eg.: https://tarieventool.tst.waz.mijpost.post.nl

</PRE>
