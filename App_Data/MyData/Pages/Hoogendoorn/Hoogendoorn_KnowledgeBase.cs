KnowledgeBase
procm|2015/10/12 17:10:00
##PAGE##
{TOC}

=== Documentation===
<PRE>
* '''iSii videos:''' "N:\iSii\iSii knowledge videos RKu"
* [https://msdn.microsoft.com/en-US/library/ff793625(v=winembedded.60).aspx|Compare Standard 7 32-bit and 64-bit (Standard 7 SP1)]

=== Software Development procedures and Guidelines===
* Architectural and Design guidelines
** [https://tfs.24green.com/documentation/HGM/Product Development/T40/Architectuur/OWP T40 Architectuur.doc|iSii NG: Architecture]
** [https://tfs.24green.com/documentation/24green/G10 new and changed/Development/General Architecture/G10 Control Architecture.doc|iSii Compact: Architecture]
** [https://tfs.24green.com/documentation/24green/Guidelines and Procedures/Templates/G10 Guideline template.dot|Design Template]
** [https://tfs.24green.com/documentation/24green/Guidelines and Procedures/G10 Architectural Guidelines.doc|iSii Compact: G10 Architectural Guidelines]
** [https://tfs.24green.com/documentation/24green/Guidelines and Procedures/G10 Error handling and logging.doc|iSii Compact: G10 Error Handling and Logging]
** [https://tfs.24green.com/documentation/24green/Guidelines and Procedures/G10 General component design.doc|iSii Compact: G10 General Component Design]
** [https://tfs.24green.com/documentation/24green/Guidelines and Procedures/G10 designing namespaces and assemblies.doc|iSii Compact: G10 Designing namespaces and assemblies]
** [https://tfs.24green.com/documentation/24green/Guidelines and Procedures/IDesignWCFStandard.pdf|iSii Compact & iSii NG: WCF Guidelines]

* Implementation guidelines
** [https://tfs.24green.com/documentation/HGM/Product Development/SPI Documentatiesysteem/Hoogendoorn Guidelines v 1.0.doc|iSii Compact & iSii NG : Hoogendoorn Guidelines]
** [https://tfs.24green.com/documentation/24green/Guidelines and Procedures/How to UnitTest internal classes and members.doc|How to UnitTest internal classes and members]
** [https://tfs.24green.com/documentation/24green/Guidelines and Procedures/Howto split unit tests and integration tests.doc|Howto split unit tests and integration tests]
** [https://tfs.24green.com/documentation/24green/Guidelines and Procedures/JavaScript Guidelines.doc|JavaScript Guidelines]
** [https://tfs.24green.com/documentation/24green/Forms/AllItems.aspx?RootFolder=/documentation/24green/Guidelines and Procedures/TDD&FolderCTID=&View={0D3E9F22-1D42-49DD-A3D7-30C514B973F2}|TDD]

* Review
** [https://tfs.24green.com/documentation/24green/Guidelines and Procedures/G10 Performing a review using TFS.doc|G10 Performing a review using TFS]

</PRE>


=== Angular (Niels Gerritsen)===
<PRE>
'''Conventions'''
{@code-javascript:
// It is a good practice to avoid scope issues within a function to use: 
var self = this;
self.parameters = [];

// Anotate the function with $inject, to maintain the functionality using Bundeling & Minification
ClimateStrategyCtrl.$inject = <nowiki>['$scope', 'hierarchyUtilities', 'climateControlTypeIds', 'ParameterFactory']</nowiki>;
 function ClimateStrategyCtrl($scope, hierarchyUtilities, climateControlTypeIds, ParameterFactory) {...}
@}

The webapp Greenbox uses some establish conventions, the following choices were made by R&D team:
* Anatomy: app -> directives -> modules ??? 
* uses '''directives''' instead of '''controllers''', but in some cases we have '''controllers''' within '''directives'''   
* ...

* '''Resources''':
** [http://www.asp.net/mvc/overview/performance/recommended-resources-for-mvc|Recommended Resources for MVC]
*** [http://i1.asp.net/media/4773381/lifecycle-of-an-aspnet-mvc-5-application.pdf|Lifecycle ASP.NET MVC5 application]
*** [http://www.asp.net/mvc/overview/performance/bundling-and-minification|ASP.NET bundling & minification]
** Angular Guidelines
** [http://www.johnpapa.net|John Papa]
** [https://github.com/airbnb/javascript/tree/master/es5|AirBnb Javascript Styleguide]
* other:
** [http://knockoutjs.com|Knockout JS]
** [http://flukeout.github.io|CSS Game]

==== UI/JS Unit Testing==== 
=====  Install Chutzpah Visual Studio under Tools=====
* Add Chutzpah as External Tool in Visual Studio
** Visual Studio -> Tools -> External Tools using the following information
(((Title: Run Chutzpah &unit tests
Command: $(SolutionDir)\packages\chutzpah.4.0.3\tools\chutzpah.console.exe
Arguments: "$(ProjectDir)"
Initial directory: $(ProjectDir)
don't forget to check-in: Use Output window
)))

[imageauto|1.Add External Tool Chutzpah in Visual Studio|{UP}/Hoogendoorn/JS TestFramework/Chutzpah.001.jpg]

[imageauto|2.Add External Tools Chutzpah in Visual Studio|{UP}/Hoogendoorn/JS TestFramework/Chutzpah.002.jpg]


===== Running Chutzpah from the command prompt=====
* ...\GreenBox\Devs\Defiant\packages\chutzpah.4.0.3\tools\chutzpah.console.exe 
       ...\GreenBox\Devs\Defiant\GreenboxUserInterface\GreenboxUserInterfaceTests\Client\angular-app\control-instances\core\gb-control-instances.test.js
</PRE>

=== Which version of '''C++''' am I using?===
<PRE>
(((MSVC++ 14.0 _MSC_VER == 1900 (Visual Studio 2015)
MSVC++ 12.0 _MSC_VER == 1800 (Visual Studio 2013)
MSVC++ 11.0 _MSC_VER == 1700 (Visual Studio 2012)
MSVC++ 10.0 _MSC_VER == 1600 (Visual Studio 2010)
MSVC++ 9.0  _MSC_VER == 1500 (Visual Studio 2008)
MSVC++ 8.0  _MSC_VER == 1400 (Visual Studio 2005)
MSVC++ 7.1  _MSC_VER == 1310 (Visual Studio 2003)
MSVC++ 7.0  _MSC_VER == 1300
MSVC++ 6.0  _MSC_VER == 1200
MSVC++ 5.0  _MSC_VER == 1100)))


'''VS 2005''':
C:\program files (x86)\microsoft visual studio 8\vc\bin>'''cl /?'''
'''output''' eg.: Microsoft (R) C/C++ Optimizing Compiler Version 17.00.50727.1 for x86
        .....
</PRE>

=== [http://www.codeproject.com/Articles/28284/Installing-XP-Embedded|Installing XP Embedded (XPe)]===

=== Migration C++ projects VS2005 -> VS2010?===
<PRE>
* [http://stackoverflow.com/questions/2958694/recommended-migration-strategy-for-c-project-in-visual-studio-6|'''Recommended migration strategy for C++ projects''']
* [http://stackoverflow.com/questions/298016/is-it-really-worth-porting-from-vc6-vc2005-2008|'''Is it really worth porting from VC6'''?]
</PRE>

=== [Hoogendoorn_ShareWorkstationProjectFolderWithVPCs|Share Workstation Project Folder with VPC's]===
summary: we can among other things for instance edit PgDB files without 1st copying them to the local Workstation
 

=== How-to update IRS (XPembedded PC) with VC++ 2008===
<PRE>
* Step1
** '''Disable EWF protection'''
*** ewfmgr c: -commitanddisable -live

* Step2
** '''Install the VC++ 2008 x86 Redistributable'''
*** \\RND-NAS01\Bridge\Software\Visual Studio\Visual C++ 2008 Express Edition\VC_x86Runtime.exe

* Step3
** '''Enable EWF'''
*** ewfmgr c: -commit
*** ewfmgr c: -enable
** '''Restart iRS'''(Regel station)
*** xpepm -restart
</PRE>

=== Make iSii SystemManager service dependent on Networkservices(WMI/WBEM)===
<PRE>
(((iSII IRS - RegelStation!)))
* Step1
** '''Disable EWF protection'''
*** ewfmgr c: -commitanddisable -live

* Step2
** '''Create Windows service dependency'''
*** sc config systemmanager depend= winmgmt
((('''Remove all service dependencies'''
 sc config systemmanager depend= /)))
* Step3
** '''Enable EWF'''
*** ewfmgr c: -commit
*** ewfmgr c: -enable
** '''Reset iRS'''(Regel station)
*** xpepm -restart

* Step4
** '''Verify if the settings are O'''K
*** sc qc SystemManager
**** look in the '''Dependencies''' row
</PRE>

=== Redirecting Assembly Versions===
<PRE>
'''Add file:''' '''C:\Program Files (x86)\Hoogendoorn\T40\Explorer.Application.exe.config'''
{@code-xml:
<configuration>
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">

<dependentAssembly>
        <assemblyIdentity name="T40.Common"  publicKeyToken="9c21e7b734d59bb2" />

        <bindingRedirect oldVersion="0.66.0.0" newVersion="0.67.0.0" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
</configuration>
@}
resource(s): [https://msdn.microsoft.com/en-us/library/7wd6ex19(v=vs.110).aspx|Redirecting Assembly Versions]
</PRE>

=== Increase time by 10x when Debugging===
<PRE>
(((eg.: '''ClimateLow.config''' to the Software: E:\Program Files\Hoogendoorn\ERS)))
{@code-xml:
<?xml version="1.0" encoding="utf-8"?>
<TestConfig>
   <ProcessTiming>
      <ProcessIntervalInMilliSeconds>1000</ProcessIntervalInMilliSeconds>
      <SkipLostProcessCycles>true</SkipLostProcessCycles>
      <AutomaticTimingAdjustment>false</AutomaticTimingAdjustment>
      <StartUpCounter>-6</StartUpCounter>
   </ProcessTiming>
   <AlarmHandling>
      <SimulationAlarmHandling>false</SimulationAlarmHandling>
   </AlarmHandling>
   <ControlHandling>
      <TurnOffActionsAllowed>true</TurnOffActionsAllowed>
   </ControlHandling>
</TestConfig>
@}
</PRE>


=== Remote debugging on VPC's===
§§(procm,2015/09/16 09:49:35)§§
<PRE>
* Create on the remote PC a local (administrator)account using the same Username & Password like u are using in your Developer(Visual Studio) PC 

* Add the created user to the ""Log on as a service" within the computer Local GroupPolicies
** Ms-DOS prompt:
*** net user {account} {password} /add
*** net localgroup Administrators {account} /add
** secpol.msc -> Local Policies -> User Right Assignment -> Log on as a service
*** add the created user {account} to the list

* Restart the Remote/VPC and login using the created user account

* Run the Visual Studio Remote Debugging Monitor (msvmom.exe) on the Remote/VPC
** Tools -> Options
*** use Windows Authentication
** Tools -> Permissions 
*** Add the created local user {account} to the group

* In Visual Studio (Developer PC): Attach to Process 
** Tranport: Default
** Qualifier: {user@Computername} eg.: cmo@ECONT4854
** if needed check the checkbox(s): 
*** Show processes from all users
*** Show processes in all sessions

((( Troubleshooting:
* Force the VPC to point to the correct IP address  
** add your VPC in the {C:\Windows\System32\drivers\etc\hosts} file
** eg.:  10.30.20.0	ECONT4854

* Disable the Firewall if needed!)))

</PRE>

=== SDL Passolo: How to unmark Language Export tag===
<PRE>
 Select aLL the corresponding Languages/translation lists and 
  then Right click -> String list settings- > Un – export -> Yes.
</PRE>

=== Sharepoint: move files/folders around but preserve History===
<PRE>
* Navigate Sharepoint using Windows Explorer
** MS-DOS prompt: NET USE R: https://tfs.24green.com/documentation /user:tfs\{user}
(((the files/folder we move around will maintain its history. Attention copying will not preserve it!)))
</PRE>