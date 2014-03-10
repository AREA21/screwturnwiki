Deployment bestaande EasyWebEditNet website
robvdkamp|2010/03/08 11:41:14
##PAGE##
===De stappen===
<pre>
# Commit alles op SVN
# Log in op testserver. '''Logingegevens in Keepass'''.
# Ga naar D:\projects\EasyWebEditNet\projectnaam\Build
# Dubbelklik EasyWebEditNet.build.bat
# Als de build succesvol is:
#* Ga naar D:\projects\EasyWebEditNet\projectnaam\build\Archive
#* Upload .zip bestand naar webserver2 (dev, test of live)
# Log uit op testserver
# Log in op webserver2. '''Logingegevens in Keepass'''.
# Open map FTP_Shared
# Pak .zip bestand uit
# Open de map waarop de website moet draaien (Websites_dev, Websites_test of Websites_live)
#* Open projectnaam\Website
#* Verwijder (of overschrijf) alles, behalve: /log, /templates, /uploads, /uploadsalbum, 
de database en alle overige mappen/bestanden die de klant aan kan passen (geldt alleen voor de test en live omgeving)
#* Kopieer de uitgepakte website naar de D:\projects\EasyWebEditNet\projectnaam\Website map
# Pas de web.config aan als dat nodig is
</pre>

LET OP:
<pre>
Als de database aangepast is, dan moeten de wijzigingen ook doorgevoerd worden in de live database.
# Haal daarom de live database op en sla hem lokaal op (live database in Shared_FTP map, met FileZilla ophalen)
'''Lokaal'''
# Open zowel de live database als de database waarin de aanpassingen al zijn gemaakt
# Delete alle queries in de live versie
# Kopieer alle queries van de aangepaste versie
# Pak alle gekopieerde queries in de live versie
# Controleer in de live versie of alle tabellen overeenkomen met de aangepaste versie
# Sla de database op
# Windows button (bestand) -> Manage -> Compact and Repair Database
# Upload de aangepaste live versie naar de webserver
'''Webserver'''
# Back-up de huidige live database
# Overschrijf de live database met de nieuwe live versie
# Controleer of de website draait
# Verwijder de database back-up
</pre>

'''Na het volgen van bovenstaande stappen zal de website online staan op http://''omgeving''.mvsd.nl/projectnaam!'''
<br/>''omgeving = dev of test3. Live websites: projectnaam.nl''