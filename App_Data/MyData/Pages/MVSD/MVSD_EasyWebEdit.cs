MVSD EasyWebEdit(EWE)
celio|2009/04/24 13:32:46
##PAGE##
{TOC}

== [MVSD_EasyWebEditSites|Sites Overview]==

== Product development==

summary: information specific to EasyWebEdit(EWE)

=== Add newsletter module to a website=== 
<pre>
 '''Add newsletter module to an existing EasyWebEdit.NET website'''
# Copy newsletter module
#* ..\EasyWebEditNet \Standaard\Nieuwsbrief\Website\*.* 
#* Copy to a temp directory, e.g. c:\temp\newsletter
# Remove .svn directories of copied photoalbum module
#* Create the file remove.svn.bat in  c:\temp\newsletter\
#* (for the contents of this file see addendum A)
#* After execution delete the file.
# Copy cleaned module
#* c:\temp\newsletter\
#* Copy to
#* ..\EasyWebEditNet\solutionname\Website\

 4 Copy newsletter business dll, xml
 ..\EasyWebEditNet \Standaard\Releasebin\Mvsd.Newsletter.Business.dll
 ..\EasyWebEditNet \Standaard\Releasebin\Mvsd.Newsletter.Business.xml
 Copy to
 ..\EasyWebEditNet\solutionname\Externalbin\

 5 Copy newsletter database
 .. \EasyWebEditNet \Standaard\Database\Newsletter.mdb
 Copy to
 ..\EasyWebEditNet\solutionname\Database\

 6 Copy connectionstring & keys
 ..\EasyWebEditNet \Standaard\Configuration\Newsletterweb.config
 Open
 Copy connectionstring & keys
 ..\EasyWebEditNet\solutionname\Website\Web.config
 Open
 Save connectionstring & keys

 7 Add newsletter admin module
 ..\EasyWebEditNet\solutionname\Controls\EditControl.ascx
 OPEN
 ADD LINE 
 <asp:ListItem Value=”Newsletter/NewsletterGroupMaintainance.aspx”>
 NieuwsGroepBeheer</asp:ListItem>

 9 Update InsertHyperlink.aspx.cs
 Copy NewsletterLinks region from InsertHyperLink.update.cs 
 paste into Page_Load below comment from InsertHyperlink.cs

 10
 Check imports (For Example: InsertHyperlink.cs)

 11 Edit build script
 EasyWebEdit.build     
 Open
 Add include line to Build.Website target  at the fileset below
 <!--Copy external dlls for the website -->
 <include name="Mvsd.Newsletters.Business.dll" />
 A) Contents of remove.svn.bat
 FOR /F "tokens=*" %%G IN ('DIR /B /AD /S *.svn*') DO RMDIR /S /Q "%%G"
 pause
</pre>
{TOP}

=== Add photo album module to a website===  
<pre>  
 Add photoalbum module to an existing EasyWebEdit.NET website

 1 Copy photoalbum module
 ..\EasyWebEditNet\Standaard\Fotoalbum\Website\Album\*.*
 Copy to a temp directory, e.g. c:\temp\photoalbum

 2 Remove .svn directories of copied photoalbum module
 Create the file remove.svn.bat in  c:\temp\photoalbum\
 (for the contents of this file see addendum A)
 After execution delete the file.

 3 Copy cleaned module
 c:\temp\photoalbum\
 Copy to
 ..\EasyWebEditNet\solutionname\Website\

 4 Copy photoalbum business dll, xml
 ..\EasyWebEditNet \Standaard\Releasebin\Mvsd.PhotoAlbum.Business.dll
 ..\EasyWebEditNet \Standaard\Releasebin\Mvsd. PhotoAlbum.Business.xml
 Copy To
 ..\EasyWebEditNet\solutionname\Externalbin\

 5 Copy photoalbum database
 ..\EasyWebEditNet \Standaard\Database\Album.mdb
 Copy To
 .\EasyWebEditNet\solutionname\Database\

 6 Copy connectionstring & keys
 ..\EasyWebEditNet \Standaard\Configuration\ PhotoAlbumWeb.Config
 Open
 Copy connectionstring & keys
 ..\EasyWebEditNet\solutionname\Website\Web.config
 Open
 Save connectionstring & keys

 7 Add photoalbum admin module
 ..\EasyWebEditNet\solutionname\Controls\EditControl.ascx
 Open
 Add Line 
 <asp:ListItem Value="Album/Admin.aspx" target="_self">Fotogalerijbeheer</asp:ListItem> 
 
 8 Add new page to create a navigation link to the photoalbum page
 Run Website
 Login
 Add Empty Page 
 Title=”Desired pagename for photoalbum link”

 9 Edit database
 ..\EasyWebEditNet\solutionname\Database\ EasyWebEdit.mdb
 Open
 tblPage
 Find last created page, add following Href
 ~/Album/Default.aspx

 10 Edit build script
 EasyWebEdit.build     
 Open
 Add include line to Build.Website target  at the fileset below
 <!--Copy external dlls for the website -->
 <include name="Mvsd. PhotoAlbum.Business.dll" /> 

 A) Contents of remove.svn.bat
 FOR /F "tokens=*" %%G IN ('DIR /B /AD /S *.svn*') DO RMDIR /S /Q "%%G"
 pause
</pre>
{TOP}

=== Build EasyWebEdit Website and deploy===
<pre>
 Website builden en deployen

 1
 ..\EasyWebEditNet\solutionname\*.*
 Exclude
 ..\EasyWebEditNet\solutionname\Website\web.config
 Commit all changes

 2
 ..\EasyWebEditNet\similar solutionname\Build\*.*
 ..\EasyWebEditNet\similar solutionname\Configuration\*.*
 COPY TO
 ..\EasyWebEditNet\solutionname\

 3 FIRST TIME BUILD ONLY
 ..\EasyWebEditNet\solutionname\Build\svn\
 ..\EasyWebEditNet\solutionname\Configuration\svn\
 ..\EasyWebEditNet\solutionname\Configuration\Bin\svn\
 DELETE 
 svn directories

 4
 ..\EasyWebEditNet\solutionname\Configuration\Bin\web.config
 EDIT LINE
 mailto=”Exception@emailadres.nl”
 from=”Exception@solutionname.nl”
 subject=”solutionname Exception”
 key=”LoginRedirectPage” value=”Main.aspx”
 key=”TitlePrefix” value=”Desired Explorer Header Title”

 5 FIRST TIME BUILD ONLY
 ..\EasyWebEditNet \solutionname\Build\build.number
 EDIT DATA TO
 0.1.0.0

 6
 ..\EasyWebEditNet \solutionname\Build\EasyWebEdit.build
 EDIT
 project name=”desired project name”
 property name=” desired project name” value=”projectnameBuild”
 property name=’FinalDeployprojectname’ value=”mvsd.projectname.ui.dll”
 3-5 lines farther down EDIT svn filepaths

 7
 ..\EasyWebEditNet \solutionname\
 COMMIT 
 only builds & configs
 
 8
 ..\EasyWebEditNet\solutionname\Build\*.*
 EXCLUDE 
 ..\EasyWebEditNet\solutionname\Build\svn\
 ..\EasyWebEditNet\solutionname\Build\build.number
 COPY TO
 testserver\d$\Projects\EasyWebEditNet\solutionname\Build\

 9
 testserver\d$\Projects\EasyWebEditNet\solutionname\Build\
 EDIT
 localpath & mail recipients
 END LINES WITH “\\”

 10 LOGIN REMOTE ADMIN SERVER: MVSD
 D:\ Projects\EasyWebEditNet\solutionname\Build\EasyWebEdit.build.bat
 EXECUTE

 11
 D:\ Projects\EasyWebEditNet\solutionname\Build\Archive\latestbuild.zip
 UNPACK TO 
 D:\ Projects\EasyWebEditNet\solutionname\Build\Archive\unpackedzip\

 12
 D:\ Projects\EasyWebEditNet\solutionname\Build\Archive\ unpackedzip \Website\*.*
 COPY TO 
 D:\ Projects\EasyWebEditNet\solutionname\Test\

 13
 ..\EasyWebEditNet\solutionname\Database\*.*
 ..\EasyWebEditNet\solutionname\Website\*.*
 COPY TO
 D:\ Projects\EasyWebEditNet\solutionname\Test\

 14
 D:\ Projects\EasyWebEditNet\solutionname\Build\Archive\unpackedzip\Deployment
 \Configuration\web.config
 COPY TO
 D:\ Projects\EasyWebEditNet\solutionname\Test\Website\

 16
 D:\ Projects\EasyWebEditNet\solutionname\Test\Website\ web.config
 EDIT
 source=”Complete path\Test\Database\EasyWebEdit.mdb”

 17
 D:\ Projects\EasyWebEditNet\solutionname\Test\
 D:\ Projects\EasyWebEditNet\solutionname\Test\Website\Uploads\
 D:\ Projects\EasyWebEditNet\solutionname\ Database \
 EACH FOLDER RIGHTMOUSECLICK PROPERTIES 
 TAB “SECURITY”
 ADD ‘NETWORK SERVICE’
 GRANT PERMISSION TO “MODIFY” 

 18 OPEN IIS
 NEW VIRTUAL DIRECTORY
 NAME “solutionname”
 GRANT PERMISSION TO “READ” & “RUN SCRIPT” 
 ENABLE “ASP.NET 2.0”

 19
 TEST ALL SITE FUNCTIONS
 http://testserver/solutionname
</pre>  
{TOP}

=== Create new default EasyWebEdit.NET website===   
<pre> 
'''Create a new default EasyWebEdit.NET website'''
# SVN Update standard EasyWebEdit.NET website
#* Use Tortoise SVN to update the standard EasyWebEdit.NET webiste
# Copy needed files from standard EasyWebEdit.NET website
#* ..\EasyWebEditNet \Standaard\ Database\EasyWebEdit.mdb and other required databases
#* ..\EasyWebEditNet \Standaard\Externalbin\*.* 
#* ..\EasyWebEditNet \Standaard\ Website \*.* 
#* Copy To 
#* ..\EasyWebEditNet\solutionname\
# Remove .svn directories of new website
#* Create the file remove.svn.bat in ..\EasyWebEditNet\solutionname\
#* (for the contents of this file see addendum A)
#* After execution delete the file.
# Copy business dll and xml to externalbin
#* ..\EasyWebEditNet \Standaard\Releasebin\ Mvsd.EasyWebEdit.Business.dll
#* ..\EasyWebEditNet \Standaard\Releasebin\ Mvsd.EasyWebEdit.Business.xml
#* Copy To
#* ..\EasyWebEditNet\solutionname\ Externalbin\
# Add/update the target attributes of navigation links
#* Add / update the target attribute of the navigation links so that the pages open in the correctwindow/frame according to the website layout.
#* ..\EasyWebEditNet\solutionname\Website\App_Code\PageController.cs
#* Open
#* METHOD GetNavigationMenu()
#* Add Line	(Or change line if line: link.Target is already present)
#* link.Target = "_self";
#* UNDER FOLLOWING LINE
#* link.NavigateUrl = page.Href;

'''A) Contents of remove.svn.bat'''
* FOR /F "tokens=*" %%G IN ('DIR /B /AD /S *.svn*') DO RMDIR /S /Q "%%G"
* pause
</pre> 
{TOP}

=== EasyWebEdit Cute Editor - Best Practices===  
<pre>
</pre>
{TOP}

=== EasyWebEdit ESF - Implementatiedetails===  
<pre>
</pre>
{TOP}

=== Checklist voor live EasyWebEdit=== 
<pre>
* Kun je plaatjes opladen?
* Kun je links maken?
* kun je templates toevoegen?
* Kun je vanuit alle EWE-componenten terug naar website?
* Zijn de stijlen in de editor gelijk aan de stijlen als je doorvoert?
* Is het een intranet en zo niet, is die keuze ook weg?
* Verwijzen de plaatjes nog naar test.mvsd.nl?
* De volgende knoppen moeten standaard NIET in de toolbar verschijnen:
** spellingscontrole
** paste as html
** regeleinde
** paragraaf
** nieuwe pagina
** datum van vandaag toevoegen
** huidige tijd toevoegen
** hoofdstuk toevoegen
** De eerste "eigen afbeelding toevoegen", die zonder potloodje
** Onderstrepen
** tekstkleur
** Markeren
** doorhalen
** afbeeldingmap maken
* Als er een talenmodule is, kun je dan een link maken naar een andere pagina, zonder dat de knoppenbalk naar de verkeerde taal schiet.
* Blijven de taalvlaggetjes goed staan, ook in beheer?
* Bij het verwijderen van een nieuwsbrief wordt de goede tabelrij rood gekleurd? 

</pre>

{TOP}

=== Suggesties mbt verbeteringen EasyWebEdit=== 
<pre>
</pre>
{TOP}
