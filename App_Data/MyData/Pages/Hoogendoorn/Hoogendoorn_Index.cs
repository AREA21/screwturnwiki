Hoogendoorn Main Page
procm|2015/03/16 17:30:10
##PAGE##
Welcome to the '''{NAMESPACE}''' namespace of '''{WIKITITLE}'''!{BR}

{TOC}

=== Infra===
<PRE>
* Shares
** NET USE M: \\10.30.1.65\Images /user:rnd /PASSWORD: '''see keepass!''' /PERSISTENT:YES
** NET USE N: \\10.30.1.65\bridge /user:rnd /PASSWORD: '''see keepass!''' /PERSISTENT:YES

* (custom)Softlinks 
** MKLINK "D:\transfer.cmo\VirtualImages" "C:\HGM\VPCs"

* Exchange Mail server 
** CL-MAIL001.bbinst.local -> URL Mobile: https://mobile.batenburgssc.nl
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

=== iSii===
<PRE>
==== Installation====
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

==== Maken CD====
* Tools
** Hoogendoorn Release Manager (MSI)
** InstallShield
** FinalBuilder - GUI to automate Windows Scripts   
* Steps Happy flow!
** New Release
** Load Files from TFS Build Output
** Build MSI Files & others
** MSI -> ISO image
* Custom eg. Add language
* Translation SDL Passolo
</PRE>

=== Naming conventions===
<PRE>
* '''C'''ActiveAirUnitDehumidificationDeviationCalculator - Class
* '''s'''ActiveAirUnitLinkedActiveAirGeneralItemId - short
* '''m_r'''ActiveAirUnitLinkedActiveAirGeneralItem.GetValue()- method_reference
</PRE>

=== Datatypes===
<PRE>
* Charts - Momentaan?
</PRE>

=== Jargon/terminology===
<PRE>
* '''iRS''' - iSii Regel Station
* '''iBS''' - iSii Bediening Station
* '''Greenbox'''/iSii Compact - small version Web variant

* '''GMP''' - Gui Management Process
</PRE>

=== FAQ===
<PRE>
* Infra overview?
* Procedures?
* Standards?
* VPN?

</PRE>

=== Methods & Techniques===
<PRE>
* SCRUM Agile
* SOLID
* DRY, Don't Repeat Yourself

* C++
* MFC
* GDI (print)
* GMP WCF
* iFrequency Graph??
</PRE>

=== ToDo===
<PRE>
* Clone Win8 systeem to SSD
* Restore Boot on SSD 
** [http://support.microsoft.com/kb/2004518]
** [http://pcsupport.about.com/od/fixtheproblem/ht/rebuild-bcd-store-windows.htm]
** [http://windowsitpro.com/systems-management/build-bootable-bcd-scratch-bcdedit]
</PRE>
