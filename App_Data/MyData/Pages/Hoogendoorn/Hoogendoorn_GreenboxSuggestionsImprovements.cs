Greenbox Suggestions & Improvements
procm|2016/02/10 23:43:27
##PAGE##
{TOC}

<PRE>
==== Hackathon- Fedex day====

===== ideas=====
* ITIL- Configuration Management:
** NET Application Configuration
eg.: solve all hard-coded Paths & Settings 

* Security: 
** Role Base User Management
** SSL & Nuget Package
 
* UI
** Angular 2.0- User Feedback & Validation mechanism 
 
* DevOPs
** Remote Debugging & Lightweight footprint  
** Running iSii Compact Multiple Instances on WES7(embedded) Server
** iSii Compact x64 ready

* IOT
** Raspberry PI2 
** Windows 10 Core 
** Windows Universal App
** Profinet Protocol
** AMQP - Advanced Message Queuing Protocol
** Meteor
** Unit3D
</PRE>

<PRE>
==== Aspx pages convertion to Angular using '''Niel Gerritsen guidelines'''==== 

==== Deployments====
* WebApplications
** Use '''WebDeploy''' for de-facto deploy strategy (within VS2015 ?), to move sites {eg. Greenbox} around. Permissions & databases will be taken care off. 
*** http://weblogs.asp.net/scottgu/automating-deployment-with-microsoft-web-deploy

* The [http://wixtoolset.org/documentation/manual/v3|WiX toolset] lets developers create installers for Windows Installer, the Windows installation engine.
** [http://www.pluralsight.com/courses/wix-introduction|Pluralsight WiX introduction]

==== Pages: Manage -> '''ControlInstances'''(Controls)====
* since software v.5400 (new UI introduced by Niels), it's not possible to create multiple Control instances at once.
** This is a desired function which we should restore! 

==== Page: '''Connections'''====
* Show the "Add"" button only when the connection doesn't exists otherwise show the "edit" button. 
* Test: one-to-one connections can only be created once by the user
* Use a feedback mechanism to let the user clearly know when a connection is added or updated. 

==== Page: Manage -> '''Backup and restore'''====
* The "import backup" fails due to a DirectoryNotFoundException,
* Introduce backup (import/export) levels. 
** We do right now a Full System backup(user data & configuration + Greenbox webapp). If this system is updated to version 5397 and 
** ...we import a Hopmans configuration backup the system will be downgraded to version 5032 and we must afterwards manually update the system to the latest version.  
*** It would be nice to check if the system version is compliant with the customer configuration and if this is the case import only the evolved settings. 

==== Page: Manage -> '''Updates'''====
* Nice to have, support for multiple "update files" under the same URL/folder

==== '''Security'''====
* 2015_0625- Ftp service Customer Portal
** ftp://readonly:D2eE2d9@ftp.hoogendoorn.nl/iSii Compact/Lanner LEC-7000 V2.0.9.5032 -3- Aqua Release Image (After reseal)_full_b1_s1_v1.tib

* GreenBox- Sending passwords in Clear text. 
** setup SSL certificate?

* Social Engineering, Security through Obscurity   
** [https://dzone.com/articles/troy-hunts-ultimate-list-of-security-links-1]

==== '''Win7e''' Greenbox pre- Acronis image====
* Failing "Search program & files" see screenshoot!
* Boots up with different keyboards layout(NL/US), eg. to get the @ char we must do CTRL + SHIFT & then SHIFT - 2

==== '''Greenbox webapplication'''====
* Performance: (Front-End)
** ASP.NET Bundling + Minification

* Place specific configuration values within .NET Configuration files(xml)===== 
** The Product Owner/Functional Administrator/Technician can take care over of this and we can follow a clear way of Configuration Management. 

(((eg.: How-to simplify used file structure?
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

{@code-xml:
/* Solution: Introduce "Configuration Management"
...for: C# App.config for File Locations, keys, etc... 

Like this:
- Add a new file to your project (Add->New Item->Application Configuration File)
- The new config file will appear in Solution Explorer as App.Config.
- Add your settings into this file using the following as a template */

<configuration>
  <appSettings>
    <add key="setting1" value="key"/>
  </appSettings>
  <connectionStrings>
    <add name="prod" connectionString="YourConnectionString"/>
  </connectionStrings>
</configuration>
@} 
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
</PRE>{TOP}
