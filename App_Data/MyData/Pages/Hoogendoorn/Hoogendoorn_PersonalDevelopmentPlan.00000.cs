Personal Development Plan
procm|2015/10/12 18:21:27
##PAGE##
{TOC}

'''Summary''': (((Doelstelling is dat ik (binnen 3maanden) op basis van de ProductOwner input zelfstandig "stories" kan oppakken.
Daarnaast dat ik de geschetste functieprofiel van "medior" kan waarmaken of overtreffen.)))

=== Actie punten===
<PRE>
* verder vertalen van Greenbox naar Portugees
** vertrouwd worden met het systeem en ook met belangrijke instellingen/waardes 

* Product verbetering
** Refactoring van Greenbox
** Lezen & updaten van bestaande documentatie. 

* Zelfstudie : 
** Boeken uit boekenlijst lezen 
** Raadplegen van vakliteratuur (Kasklimaat & Regeltechniek) 

* Certificering (andere TEAM leden??)
** Doel: Microsoft Certified Solutions Developer, MCSD for WebApplications
** Microsoft Exam Ref.70-486: Developing ASP.NET MVC 4 Web Applications (behaald 2015)
** Microsoft Exam Ref.70-480: Programming in HTML5 with JavaScript and CSS3
** Microsoft Exam Ref.70-487: Developing Windows Azure and Web Services

* onderzoek/implementatie: 
** Verbeteren van Greenbox Security
*** SSL, encryption, App.config
*** Role based user authenticatie/autorisatie, voor wachtwoord beheer 
** Greenbox Front-End
*** het kunnen Updaten van een volledig regel in a Angular grid
*** Feedback mechanisme naar de gebruiker toe, met vertalingen

* bijdragen aan het promoten van: TDD / SOLID / Clean code / Design patterns/ Best Practices Guidelines 
** Procedures & Guidelines:
** '''JSHint''' vs JSLint
*** Looks definitely more community-driven rather than one-man-show
*** Seems to be more configurable that JSLint.
*** JSHint matched out code style Out Of the Box) better that JSLint.
** CssCop - FxCop for Stylesheets
*** we use Mindscape Web Workbench extention for ('''S'''yntactically '''A'''wesome '''S'''tyle '''S'''heets)  

* TFS Workitems, gebruiken als bron van KnowledgeBase?? 

* FO/TO Greenbox inzicht voor new configuratie!!
** versimpelen van de Greenhouse configuratie 

</PRE>

=== Suggestions (Greenbox improvements)===

==== Aspx pages convertion to Angular using '''Niel Gerritsen guidelines'''==== 
<PRE>
... 
</PRE>

==== Page: '''Connections'''====
<PRE>
* Show the "Add"" button only when the connection doesn't exists otherwise show the "edit" button. 
* Test: one-to-one connections can only be created once by the user
* Use a feedback mechanism to let the user clearly know when a connection is added or updated. 
</PRE>

==== Page: Manage -> '''Backup and restore'''====
<PRE>
* The "import backup" fails due to a DirectoryNotFoundException,
* Introduce backup (import/export) levels. 
** We do right now a Full System backup(user data & configuration + Greenbox webapp). If this system is updated to version 5397 and 
** ...we import a Hopmans configuration backup the system will be downgraded to version 5032 and we must afterwards manually update the system to the latest version.  
*** It would be nice to check if the system version is compliant with the customer configuration and if this is the case import only the evolved settings. 
</PRE>

==== Page: Manage -> '''Updates'''====
<PRE>
* Nice to have, support for multiple "update files" under the same URL/folder
</PRE>

==== '''Security'''====
<PRE>
* 2015_0625- Ftp service Customer Portal
** ftp://readonly:D2eE2d9@ftp.hoogendoorn.nl/iSii Compact/Lanner LEC-7000 V2.0.9.5032 -3- Aqua Release Image (After reseal)_full_b1_s1_v1.tib

* GreenBox- Sending passwords in Clear text. 
** setup SSL certificate?
</PRE>

==== '''Win7e''' Greenbox pre- Acronis image====
<PRE>
* Failing "Search program & files" see screenshoot!
* Boots up with different keyboards layout(NL/US), eg. to get the @ char we must do CTRL + SHIFT & then SHIFT - 2
</PRE>

==== '''Greenbox webapplication'''====
<PRE>
* Place specific configuration values within .NET Configuration files(xml). 
** The Product Owner/Functional Administrator/Technician can take care over of this and we can follow a clear way of Configuration Management. 
* Performance: (Front-End) 
** ASP.NET Bundling + Minification

(((How-to simplify used file structure?
* C:\inetpub\wwwroot\..
** C:\Program Files\Green\SystemInformation
*** SystemInformation.xml, SystemInformation.xsd
** D:\inetpub\wwwroot\..
** D:\Backup\..
** D:\Program Files\Green
** D:\Program Files\Green\ControlBox\..
** D:\Program Files\Hoogendoorn
** D:\Program Files\Hoogendoorn\ERS\..
** D:\Documents and Settings\All Users\Application Data\Hoogendoorn
** D:\Documents and Settings\All Users\Application Data\Hoogendoorn\ERS\...
** D:\Documents and Settings
** D:\Documents and Settings\All Users
** D:\Documents and Settings\All Users\Application Data
** D:\Documents and Settings\All Users\Application Data\Green
** D:\Documents and Settings\All Users\Application Data\Green\ControlBox {sqllite, xml}
)))

* Solution: Introduce "Configuration Management
(((for: C# App.config for File Locations, keys, etc... 
Like this:
* Add a new file to your project (Add->New Item->Application Configuration File)
* The new config file will appear in Solution Explorer as App.Config.
* Add your settings into this file using the following as a template

{@code-xml:
<configuration>
  <appSettings>
    <add key="setting1" value="key"/>
  </appSettings>
  <connectionStrings>
    <add name="prod" connectionString="YourConnectionString"/>
  </connectionStrings>
</configuration>
@} 
)))

{@code-csharp:

// Retrieve the configuration keys like this:
private void Form1_Load(object sender, EventArgs e)
{
    string setting = ConfigurationManager.AppSettings["setting1"];
    string conn = ConfigurationManager.ConnectionStrings["prod"].ConnectionString;
}

/* When built, your output folder will contain a file called <assemblyname>.exe.config This will be a copy of the App.Config file. 
   ...No further work should need to be done by the developer to create this file.
   Access the members by doing: */

System.Configuration.ConfigurationSettings.AppSettings["MyKey"];
@}

* '''Resources''': 
** [http://www.codeproject.com/KB/dotnet/mysteriesofconfiguration.aspx|Unraveling the Mysteries of .NET 2.0 Configuration]
** [http://www.codeproject.com/KB/aspnet/ConfigSections.aspx|Understanding Section Handlers - App.config File]

* Legenda:
** + RFC - Request for Change
** v RFE - - Request for Enhancement
</PRE>
