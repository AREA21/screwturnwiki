Deployment nieuwe website incl. SQL database op test3.mvsd.nl
robvdkamp|2010/04/09 16:23:07
##PAGE##
==Deployment van een nieuwe website (incl. SQL database) op test3.mvsd.nl/projectnaam==

===Website builden===
<pre>
# Open de "Build" map in de projectmap
# Pas in beide bestanden (easyshop.build en easyshop.build.bat) de path's aan en sla ze op.
# Draai vervolgens .bat file
</pre>

===Website uploaden===
<pre>
# Als de build succesvol is, open de "Deployment" map, en vervolgens de "Archive" map.
# Upload het ingepakte bestand (.zip) naar webserver2. Gebruik FilleZilla
</pre>

===Database backup===
<pre>
# Log in op testserver (server waar de database draait)
# Open SQL Server Management Studio
# Login op de juiste server. Server name: 192.168.177.17\MSSQL2008_DEV  '''Logingegevens in Keepass'''.
# Rechtermuis op de gewenste database -> tasks -> backup
# General tabblad
#* Source, Backup type: Full
#* Destination, Back up to: disk
#* Klik op "Add" om de locatie aan te geven (D:\Data\Databases\MSSQL2008_dev\Backup\projectnaam00-00-0000.bak)
# Options tabblad
#* Overwrite media, selecteer "Overwrite all existing backup sets"
#* Reliabilty, vink "Verify backup when finished" aan
# Klik op "OK"
</pre>
{TOP}


===Database uploaden===
<pre>
# Open de verkenner
# Type in: \\testserver\d$
# Log in als administrator '''Logingegevens in Keepass'''.
# Ga naar D:\Data\Databases\MSSQL2008_dev\Backup
# Upload het juiste .bak bestand naar webserver2. Gebruik FilleZilla
</pre>


===Database restoren===
<pre>
# Open SQL Server Management Studio op webserver2
# Login op de juiste server (_test voor test, _dev voor dev)
# Rechtermuis op "Databases" -> Restore database
# General tabblad
#* Source for restore, selecteer "From device"
#* Klik op bladeren (...)
#* Backup media: File
#* Selecteer het .bak bestand (backup database) - in de "Shared_FTP" map
#* Klik op "OK"
#* Vink "Restore" aan van de database
#* Destination for restore, To database: selecteer in het dropdownmenu de juiste database (ES = EasyShop)
# Options tabblad
#* Selecteer "Overwrite existing database"
#* Controleer of "Restore as" path klopt in "Restore the database file as"
# Klik op "OK" (De database is nu succesvol ge-restored)
</pre>
{TOP}


===Website online zetten===
<pre>
# Open in webserver2 de map "Shared FTP"
# Unzip het .zip bestand
# Open de locatie/map waarin de website moet gaan draaien Website_Live, website_Test of website_Dev)
# Kopieer alles naar de juiste map (Website_Live\projectnaam\Website, Website_Test\projectnaam\Website of Website_Dev\projectnaam\Website)
</pre>


===Webconfig aanpassen===
<pre>
# Zet de "compilation debug" op "false"
# Verander alle Joshua3 of Joshua4 in localhost
# Verander de datasource value van de database (Databasesettings -> datasource). Bijvoorbeeld "webserver2\MSSQL2008_Test"
</pre>


===IIS instellen===
<pre>
# Open Internet Infomration Services Manager (IIS)
# Open Web sites -> TEST3.MVSD
# Rechtermuis op TEST3.MVSD -> New -> Virtual Directory
# Bij alias vul je de projectnaam in
# Bij path vul je het juiste path naar de "website" map van de website in (bv. D:\Data\Websites\Test\projectnaam\Website)
# Klik op "Next"
# Vink "Read and Run scripts (such as ASP)" aan
# Klik op "Finish"

# Rechtermuis op projectnaam -> properties
# In het tabblad "Documents" -> voeg je startpagina toe als default content page. Main.aspx
# Klik op "Apply", "OK"

VOOR URL REWRITE:
# Rechtermuis op projectnaam -> properties
# In het tabblad "Home Directory" klik op de knop "Configuration"
# In het tabblad "Mappings" klikken op de "Insert" knop
# Voeg dit path toe: C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\aspnet_isapi.dll
# Vink de checkbox "Verify that file exists" '''__uit__'''
# Klik op "OK"
</pre>
{TOP}

'''Na het volgen van bovenstaande stappen zal de website online staan op http://test3.mvsd.nl/projectnaam!'''