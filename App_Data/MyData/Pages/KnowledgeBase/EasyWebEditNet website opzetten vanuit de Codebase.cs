EasyWebEditNet website opzetten vanuit de Codebase
mineke|2010/04/29 14:06:44
##PAGE##
==EasyWebEditNet website opzetten==

# Maak lokaal een nieuwe project map (vb. D:\projecten\projectnaam)
# Haal de EasyWebEditNet Codebase op uit Subversion (SVN)
#* Rechtermuis klik op de nieuwe project map
#* Klik op SVN Checkout
#** Repository URL: svn://joshua4/CodeBase/EasyWebEditNet/trunk 
#** Checkout directory, voorbeeld: D:\projecten\projectnaam
#** Vink "Head revision" aan
#** Klik op OK
#** Login met je eigen SVN account
# Verwijder SVN ([{UP(KnowledgeBase.EasyWebEditNet website opzetten vanuit de Codebase)}remove .svn.bat.zip|remove.svn.bat])
# Gooi de databases weg die je niet gaat gebruiken (/projectnaam/Database/)
#* Guestbook.mdb
#* News.mdb
#* Newsletter.mdb
#* PhotoAlbum.mdb
# Gooi de modules (mappen) weg die je niet gaat gebruiken (/projectnaam/Guestbook, /projectnaam/News, /projectnaam/NewsLetter of /projectnaam/PhotoAlbum)
#* GuestBook
#* News
#* NewsLetter
#* PhotoAlbum
# Kopieer uit de configuration-map de 'bin' map en web.config naar de Website map
# Kopieer alle bestanden uit de mappen /projectnaam/Guestbook/Website/*, /projectnaam/News/Website/*, /projectnaam/NewsLetter/Website/* of /projectnaam/PhotoAlbum/Website/* naar de juiste mappen in de /projectnaam/Website map
#* Admin
#* Images
#* CSS
#* App_code
#* Controls
#* UserUploads
#* JS (javascipt)

====Bepaal of je DDL's gaat gebruiken of de modules/projecten. Volg 1 van de 2 blokken hieronder!====

===DLL's gebruiken (als je de modules niet hoeft aan te passen)===
<pre>
# Gooi de module mappen weg (/projectnaam/Guestbook, /projectnaam/News, /projectnaam/NewsLetter of /projectnaam/PhotoAlbum)
# Kopieer uit de ReleaseBin de benodigde .dll bestanden en plak ze in de map ExternalBin - NIET de MVSD.EasyWebEdit.Business.dll kopieeren!
#* Mvsd.Guestbook.Business.dll
#* Mvsd.News.Business.dll
#* Mvsd.Newsletters.Business.dll
#* Mvsd.PhotoAlbum.Business.dll
# Gooi de ReleaseBin map weg
# Open de solution in Visual Studio
# Voeg de DLL's toe als reference aan de website map (Visual Studio -> rechtermuis op Website -> Add Reference -> tabblad Browse -> open de ExternalBin map -> voeg .dll's toe)
# Voeg het Business project toe als reference aan de website map (Visual Studio -> rechtermuis op Website -> Add Reference -> tabblad Projects -> selecteer Business -> klik op OK)
# Controleer of er in de ExternalBin, ReleaseBin en Website/Bin mappen een bestand bestaat genaamd: mvsd.easywebedit.business.dll
#* JA? Verwijder deze!
#* NEE? Doe niks, ga naar de volgende stap
</pre>

===Projecten gebruiken ipv DLL's (als je de modules moet aanpassen)===
<pre>
# Verwijder de Website map in de module mappen (/projectnaam/Guestbook/Website, /projectnaam/News/Website, /projectnaam/NewsLetter/Website 
of /projectnaam/PhotoAlbum/Website)<br/> - Verwijder de Business map NIET
# Voeg de modules toe aan de solution (Visual Studio -> rechtermuis op Solution 
'EasyWebEdit' -> Add -> Existing project -> Browse naar de module map /projectnaam/Guestbook/Business,<br/> /projectnaam/News/Business, /projectnaam/NewsLetter/Business 
of /projectnaam/PhotoAlbum/Business, selecteer het .csproj bestand -> Klik op Open - het project is nu toegevoegd aan de solution
#* projectnaam/GuestBook/Business/Guestbook.csproj
#* projectnaam/News/Business.News.csproj
#* projectnaam/Newsletter/Business/Newsletters.csproj
#* projectnaam/PhotoAlbum/Business/PhotoAlbum.csproj
# Voeg aan elke module/project een reference toe naar het Business project 
(Visual Studio -> rechtmuis op module/project -> Add Reference -> 
tabblas Projects -> selecteer Business -> klik op OK)
# Voeg de modules/projecten toe als reference aan de website map 
(Visual Studio -> rechtermuis op Website -> Add Reference -> tabblad Projects -> 
selecteer de modules/projecten *1-voor-1* -> klik op OK)
# Voeg ook het Business project toe als reference aan de Website map (zie bovenstaande regel)
# Controleer of er in de ExternalBin, ReleaseBin en Website/Bin mappen een bestand bestaat 
genaamd: mvsd.easywebedit.business.dll
#* JA? Verwijder deze!
#* NEE? Doe niks, ga naar de volgende stap
# Maar je moet iig nog:
Website > add reference > tabblad browse > ExternalBin > alle DLL's toevoegen

</pre>

====Klaar met het toevoegen van de DLL's of de modules/projecten?! Volg in beide gevallen deze laatste 3 stappen!====

# Pas de web.config aan (values en paths):
@@<add key="TitlePrefix" value="MVSD"/>
<add key="RegisterTo" value="rob@mvsd.nl"></add>
<add key="RegisterFrom" value="rob@mvsd.nl"></add>
<add key="EasyMail_UserLoginName" value="test"></add>
<add name="EasyWebEdit" connectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\projecten\EasyWebEditNet\Database\EasyWebEdit.mdb;" providerName="System.Data.OleDb"/>
<add name="PhotoAlbum" connectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\projecten\EasyWebEditNet\Database\PhotoAlbum.mdb;" providerName="System.Data.OleDb"/>
<add name="Newsletter" connectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\projecten\EasyWebEditNet\Database\Newsletter.mdb;" providerName="System.Data.OleDb"/>
<add name="Guestbook" connectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\projecten\EasyWebEditNet\Database\Guestbook.mdb;" providerName="System.Data.OleDb"/>
<add name="News" connectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\projecten\EasyWebEditNet\Database\News.mdb;" providerName="System.Data.OleDb"/>@@
# Sla de web.config op
# '''Klaar! Customize de website!'''