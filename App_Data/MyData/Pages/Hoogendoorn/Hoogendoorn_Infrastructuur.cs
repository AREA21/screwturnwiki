Infrastructuur
procm|2015/05/08 09:47:00
##PAGE##
{TOC}

=== Network=== 
<PRE>
* '''Shares'''
** NET USE M: \\10.30.1.65\Images /user:rnd /PASSWORD: '''see keepass!''' /PERSISTENT:YES
** NET USE N: \\10.30.1.65\bridge /user:rnd /PASSWORD: '''see keepass!''' /PERSISTENT:YES
** Translation Machine & Release Manager
*** NET USE X: \\tfs-tfs01.tfs.local\Releases /user:tfs\Cmo /PASSWORD: '''see keepass!''' /PERSISTENT:NO 
*** NET USE Y: \\tfs-tfs01.tfs.local\Deliveries /user:tfs\Cmo /PASSWORD: '''see keepass!''' /PERSISTENT:NO
** Custom
*** NET USE h: \\Hoo-pc0031\hgm$ /user:bbinst\cmo /PERSISTENT:YES 
*** Softlink: MKLINK "D:\transfer.cmo\VirtualImages" "C:\HGM\VPCs"
** Sharepoint Webfolders(WebDAV protocol)
*** NET USE S: https://tfs.24green.com/documentation/HGM /user:tfs\Cmo /PASSWORD: '''see keepass!''' /PERSISTENT:YES
*** NET USE S: https://tfs.24green.com/documentation/24green /user:tfs\Cmo /PASSWORD: '''see keepass!''' /PERSISTENT:YES
*** NET USE S: https://tfs.24green.com/documentation/Anderson/user:tfs\Cmo /PASSWORD: '''see keepass!''' /PERSISTENT:YES

(((Station Leters (Mustafa op TEST-ISIIRM)
* Bridge - F
* Images - G
* Releases - X
* Deliveries - Y)))

* '''Printers'''
** 10.30.4.12 -> Kyocera Mita FS-1800+

* '''DNS'''
** 10.30.1.65 - RND-NAS01
** 192.168.149.3 - tfs-tfs01.tfs.local
** 192.168.149.9 - tfs-translation.tfs.local
** 192.168.149.8 - TEST-ISIIRM 

* '''Exchange settings''' 
** Mail server- CL-MAIL001.bbinst.local -> URL Mobile: https://mobile.batenburgssc.nl
** Autodiscover- https://hoogexch02.hoogendoorn.nl/autodiscover/autodiscover.xml
</PRE>

=== Team Foundation Server===
<PRE>
* Repository: https://tfs.24green.com:8088/tfs
** Credentials: TFS\CMo pwd: sie keepass!!
** Collections:
*** GrowthManagement: Hier zit alles met betrekking tot het product iSii
*** Innocom: Hier zit alles mbt de iSii compact in (a.k.a. Greenbox)

'''VS2005'''
* GrowthManagement
** Development Tools
** ECONOMIC (6.9- beta version!!)
** iSii 6.00 (Prod version!!)
** iSii 5.2 

'''VS2010''' 
* Innocom 
** 24green
</PRE>

=== iSii===

==== Installation iSii VPC's====
<PRE>
* Import VPC's {iBS, iRS, PgDB}
* Mount \\10.30.1.65\Images\CDs\6.0.0.18.iso
** Run setup.exe 
*** Point to the license folder eg.: ...'''Bridge'''\PostBus\Cmo\LicenseCmo\License6.0
** Run ConnectIO 
*** Add some components eg.: Aspirator, Green House Climate
*** Create connections...

* Howto Generate license files?
** Cmo (my) config nr/id: 4971

* Howto Import licenses?
** (((regsvr32 licensing.dll)))
*** which password should be used? Check '''License.xlsx''' file.
</PRE>


=== Hardware===
<PRE>
* Greenbox + iRS v2
** [http://www.hpsindustrial.nl/shop/207-mini-pcs/143-industrial-control/1655-Lanner-LEC-7000]

* iRS v3 (Win XPe) & GreenBox –type 2 (Win 7e + SSD ipv compact flash card)
** [http://www.koningenhartman.nl/nl/webshop/industrie/industrial-computing/box-pc/fanless-pc-nise104]

* iBS- type 3 (Win7e)
** [http://www.hpsindustrial.nl/shop/207-mini-pcs/143-box-pc/2347-FPC-7700]
</PRE>