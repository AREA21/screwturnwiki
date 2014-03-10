Install Webforms
celio|2009/11/11 15:28:59
##PAGE##
{TOC}
==== Configuratie web applicaties====
<PRE>
# Verkrijg de webform files (war of zip of uitgepakt).
# Indien nodig pak de files uit, waarna er 2 directories zouden moeten zijn: Webforms en webforms_bl.
# Kopieer beide directories naar de <necserver> directory
# Kopieer de volgende 2 jar files naar de lib directories (WEB-INF\lib) van beide web applications:
    nec-ejb-2.x.y.jar (uit de nec-app-2.15.ear te halen met winzip), 
    nec-shared-2.x.y.jar (de laatste versie waarmee NEC gedeployed is), dit is nodig omdat Log4J deze wilt zien.
# Ga naar de weblogic console en log in.
#* Ga naar Web Application Modules 
#* Ga naar Deploy a new Web Application Module...
#* Selecteer de map Webforms in de <necserver> directory
#* Klik “Target Module”
#* Klik “Deploy”
# Deploy op dezelfde manier de directory webforms_bl in de <necserver> directory
# Pas index.html in de Webforms directory in <necserver> aan en laat deze in de links verwijzen 
naar de xml files zoals ze staan in de xml directory van webforms_bl in de apps directory.

{TOP}
</PRE>

==== Configuration of the '''apps''' directory====
<PRE>
# Verkrijg de apps directory als zip (hierin staan de xml files + config files voor beide applicaties).
# Pak de apps zip uit en plaats deze in: 
#* <bea_home>\user_projects\domains\<domain_name>\apps
# Maak een kopie van de directory webforms_bl en noem deze webforms_b
# Verwijder de map conf,cvs uit de directory webforms_bl
# Verwijder de map xml,cvs,log uit de directory webforms_b
# Verwijder de map cvs, log uit de directory Webforms
# Verplaats de map xsl vanuit de webforms_bl directory naar:
#* <bea_home>\user_projects\domains\<domain_name>\webapps\webforms_bl
# In de apps\webform\conf directory moet de volgende files staan:
#* webforms_bl_jfig.xml en webforms_bl_log4j.cfg
# Pas webforms_bl_jfig.xml aan:
#* catalina_home moet wijzen naar de config directory van NEC <necserver>\\config
#* businessLogicIP moet wijzen naar het ip/servernaam van de huidige server
# Hernoem webforms_bl_jfig.xml naar jfig.xml
# Hernoem webforms_bl_log4j.cfg naar log4j.cfg
# In de apps\webforms_b\conf directory moet de volgende files staan:
webforms_bl_jfig.xml en webforms_bl_log4j.cfg
# Pas webforms_bl_jfig.xml aan:
#* catalina_home moet wijzen naar de config directory van NEC <necserver>\\config
# Hernoem webforms_bl_jfig.xml naar jfig.xml
# Hernoem webforms_bl_log4j.cfg naar log4j.cfg

{TOP}
</PRE>

==== File Locations====
<PRE>
*Zie ook webformulieren_bestandslocaties.xls

{| cellspacing="0" cellpadding="2" border="1"  
! Bestand ICP-server {BR} Relative links t.o.v. de directory waar Tomcat start !! Bestand NEC server !! Omschrijving
|-
| colspan="3" bgcolor="lightgreen" | Webserver
|-
| apps/webforms/conf/log4j.xml || D:\bea\user_projects\domains\Nec\apps\webform\conf || Bepaalt de logging
|-
| apps/webforms/conf/jfig.xml || D:\bea\user_projects\domains\Nec\apps\webform\conf || Configuratie
|-
| apps/webforms/logs/webforms.log || D:\bea\user_projects\domains\Nec\apps\webforms_bl\logs || Logging van Webforms
|-
| logs/catalina.out || D:\bea\user_projects\domains\Nec\logs || Standaard uitvoer van het serverproces
|-
| logs/catalina.out || D:\bea\user_projects\domains\Nec\logs || Standaard foutenuitvoer van het serverproces
|-
| webapps/webforms/css || D:\NEC\Server\webforms\css || Directory met stylesheets, maar de stylesyeets komen nu van ICP
|-
| webapps/webforms/html || D:\NEC\Server\webforms\html || Directory met statische HTML
|-
| webapps/webforms/images || D:\NEC\Server\webforms\images || Directory met plaatjes, maar de plaatjes komen nu van ICP
|-
| webapps/webforms/js || D:\NEC\Server\webforms\js || Directory met Javascript
|-
| webapps/webforms/pdf || D:\NEC\Server\webforms\pdf || Directory met algemene PDF bestanden (voorwaarden enz)
|-
| webapps/webforms/WEB-INF || D:\NEC\Server\webforms\WEB-INF || Directory met de webapplicatie
|-		
| colspan="3" bgcolor="lightgreen" | Applicatieserver
|-	
| apps/webforms_bl/conf/log4j.xml || D:\bea\user_projects\domains\Nec\apps\webforms_b\conf || Bepaalt de logging
|-
| apps/webforms_bl/conf/jfig.xml || D:\bea\user_projects\domains\Nec\apps\webforms_b\conf || Applicatie- en site-specifieke configuratie, overschrijft zowel webapps/webforms_bl/conf/jfig_not_site_specific als apps/tomcat/jfig.xml
|-
| webapps/webforms_bl/conf/jfig_not_site_specific.xml || D:\bea\user_projects\domains\Nec\webapps\webforms_bl\conf || Applicatiespecifieke configuratie, overschrijft apps/tomcat/jfig.xml
|-
| apps/tomcat/jfig.xml || D:\bea\user_projects\domains\Nec\apps\tomcat || Sitespecifieke configuratie
|-
| apps/webforms_bl/logs/webforms.log || D:\bea\user_projects\domains\Nec\apps\webforms_bl\logs || Logging van Webforms
|-
| logs/catalina.out || D:\bea\user_projects\domains\Nec\logs || Standaard uitvoer van het serverproces
|-
| logs/catalina.out || D:\bea\user_projects\domains\Nec\logs || Standaard foutenuitvoer van het serverproces
|-
| apps/webforms_bl/xml || D:\bea\user_projects\domains\Nec\apps\webforms_bl\xml || Definitie van de webforms
|-
| apps/webforms_bl/xml/Webform_0800_3_webform.xml || D:\bea\user_projects\domains\Nec\apps\webforms_bl\xml || Webform voor 0800 - 3
|-
| apps/webforms_bl/xml/Webform_0800_3_config.xml || D:\bea\user_projects\domains\Nec\apps\webforms_bl\xml || Configuratie voor webform 0800-3. Bepaalt de schemopbouw en de uitvoerbestanden
|-
| apps/webforms_bl/xml/default_config.xml || D:\bea\user_projects\domains\Nec\apps\webforms_bl\xml || Configuratie voor een webform indien het bijbehorende config bestand ontbreekt
|-
| webapps/webforms_bl/images/logokpn.gif || D:\NEC\Server\old\Webforms\images || KPN logo voor PDF bestand
|-
| webapps/webforms_bl/contract || D:\bea\user_projects\domains\Nec\apps\webforms_bl\contract || Directory voor de gegenereerde bestanden per contract. Per contract een subdirectory met het referentienummer, daarin de gegenereerde bestanden.
|-
| webapps/webforms_bl/xsl || D:\bea\user_projects\domains\Nec\webapps\webforms_bl\xsl || Directory met XSLT transformatie bestanden
|-
| webapps/webforms_bl/xsl/contract_to_html.xsl || D:\bea\user_projects\domains\Nec\webapps\webforms_bl\xsl || Contract afbeelden als HTML
|-
| webapps/webforms_bl/xsl/xhtml-to-xslfo.xsl || D:\bea\user_projects\domains\Nec\webapps\webforms_bl\xsl || HTML converteren naar fo (input voor PDF generator)
|-
| webapps/webforms_bl/xsl/displayConditions.xsl || D:\bea\user_projects\domains\Nec\webapps\webforms_bl\xsl || Genereren tweede pagina
|-
| webapps/webforms_bl/xsl/displayThankYou.xsl || D:\bea\user_projects\domains\Nec\webapps\webforms_bl\xsl || Genereren derde pagina
|-
| webapps/webforms_bl/xsl/showVersions.xsl || D:\bea\user_projects\domains\Nec\webapps\webforms_bl\xsl || Beschikbare webforms afbeelden in ManagementController
|-
| webapps/webforms_bl/xsl/showConfig.xml || D:\bea\user_projects\domains\Nec\webapps\webforms_bl\xsl || Webform op scherm zetten in ManagementController
|-
| webapps/webforms_bl/xsl/WEB-INF || D:\bea\user_projects\domains\Nec\webapps\webforms_bl\xsl || Directory met de webapplicatie
|-
|/spare/generic/fop/fopconfig.xml || D:\bea\user_projects\domains\Nec\fop || Configuratie voor FOP (PDF genereren)
|-
|/spare/generic/metrics || D:\bea\user_projects\domains\Nec\metrics || Directory met de metrics voor de fonts voor FOP
|-
|/spare/generic/fonts || C:\WINDOWS\Fonts || Fonts (als ttf bestanden) voor FOP
|}

{TOP}
</PRE>