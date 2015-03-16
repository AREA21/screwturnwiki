Motorola RhoMobile
procm|2014/09/15 14:09:45|(((mobile,mobile apps)))(((Motorola RhoMobile)))
##PAGE##
{TOC}

=== '''Resource'''(s)===
<PRE>
[http://edgedocs.rhomobile.com/api|'''Motorola RhoMobile docs, NEW!''']
[http://docs.rhomobile.com|'''Motorola RhoMobile docs''']
* [http://developer.motorolasolutions.com|Launchpad Developer Community]
** [http://docs.rhomobile.com/en/4.1.0/guide/kitchensink#partials|Reuse HTML code]
** [http://docs.rhomobile.com/en/4.0.0/rhoconnect/metadata|Building Dynamic Views with Metadata (RhoConnect)]
* [http://rhomobile-suite.s3.amazonaws.com/4.1/4.1.1/RMS_0401xx_ReleaseNotes.html|RhoMobile Suite v4.1.0 Release Notes]
* [https://s3.amazonaws.com/rhomobile-suite/2.1/RMS_0201xx_ReleaseNotes.html|RhoMobile Suite v2.1.1 Release Notes]
* [http://docs.rhomobile.com/en/2.2.0/rhodes/device-caps|Device Capabilities]
** [http://docs.rhomobile.com/en/2.2.0/rhoelements/apicompatibility|API compatibility]
* [http://www.pinterest.com/motosolutions/rhomobile-apps|Apps Public Gallery]
* [http://www.youtube.com/user/rmswebinarstemp|RhoMobile Suite Dev Talks]
* [http://vimeo.com/channels/rhomobile|Training videos on Vimeo]

* Platforms
** Android -> SDK/NDK
** [http://msdn.microsoft.com/en-us/library/sa69he4t%28v=vs.100%29.aspx|Windows CE /.NET Compact Edition ]
** Windows Mobile
** Windows Phone
** iPhone IOS -> needed to register as IOS developer, not free 
** Win32

* Hardware
** [http://www.youtube.com/watch?v=-P2IBSRdXLg|MC40 (android) video]
</PRE>

=== '''Modules'''===

==== [http://www.motorolasolutions.com/US-EN/RhoMobile+Suite/Rhodes|Rhodes (consumer apps)]====
<PRE>
'''summary:''' the basic application framework for RhoMobile, open-source framework based on '''Ruby''' & '''M'''odel-'''V'''iew-'''C'''ontroller architecture.

'''rake - Project Build command'''

(((examples:
* rake -+-trace config:android  #'''Debug''' building process
* rake -T  #'''Full List'''s available Targets/Options)

'''Full List:'''
rake build:android:eclipsebundle         # Build RhoBundle for Eclipse project
rake build:android:extensions            # Building native extensions
rake build:android:rhobundle             # Build RhoBundle for android
rake build:osx:rhosim_qt_version         # prints Qt version is required by Mac RhoSimulator
rake build:symbian:rhobundle             # Build symbian rhobundle
rake build:win32:rhosim_qt_version       # prints Qt version is required by Windows RhoSimulator
rake build:win32:rhosim_toolchain        # prints toolchain is required by Windows RhoSimulator
rake build:wp8:rhobundle_noext           # Build WP8 rhobundle

'''rake clean:android                       # Clean Android'''
rake clean:bb                            # Clean bb
rake clean:bbsim                         # Clean bb and simulator
rake clean:iphone                        # Clean iphone
rake clean:win32                         # Clean win32
rake clean:wince                         # Clean windows ce
rake clean:winxpe                        # Clean winxpe
rake clean:wm                            # Clean wm
rake clean:wp8                           # Clean wp

rake config:checkbb                      # Check local blackberry configuration

rake device:android:debug                # Build debug self signed for device
rake device:android:production           # Build production signed for device
rake device:bb:debug                     # Build debug for device
rake device:bb:production                # Build production for device
rake device:iphone:production            # Builds and signs iphone for production
rake device:symbian:production           # Build production for device
rake device:win32:production             # Build installer for Windows
rake device:wince:production             # Build production for device or emulator
rake device:winxpe:production            # Build installer for Windows XP Embedded
rake device:wm:production{exclude_dirs}  # Build production for device or emulator

rake device:wp8:production               # Build production for device
rake emulator:wp8:production             # Build production for device

rake package:bb:production_sim           # Package all production (all parts in one package) for simulator

'''rake run:android                         # build and launch emulator'''
'''rake run:android:device                  # build and install on device'''
rake run:android:rhosimulator            # Run application on RhoSimulator

rake run:bb                              # Builds everything, loads and starts bb sim and mds
rake run:bb:rhosimulator                 # Run application on RhoSimulator
rake run:bb:startsim                     # Start Blackberry simulator
rake run:bbapp                           # Builds everything and loads application on simulator
rake run:bbdev                           # Same as run:bb, but only supports one app at a time and works faster

rake run:iphone                          # Builds everything, launches iphone simulator
rake run:iphone:rhosimulator             # Run application on RhoSimulator
rake run:webrickrhologserver{app_path}   # start rholog(webrick) server

rake run:win32                           # Run win32
rake run:win32:rhosimulator              # Run application on RhoSimulator
rake run:wince:device                    # Build and run on the Windows CE device
rake run:wince:device:cab                # Build, install .cab and run on the Windows CE device
rake run:wince:rhosimulator              # Run application on RhoSimulator

rake run:wm                              # Build and run on WM6 emulator
rake run:wm:cab                          # Build, install .cab and run on WM6 emulator
rake run:wm:device                       # Build and run on the Windows Mobile device
rake run:wm:device:cab                   # Build, install .cab and run on the Windows Mobile device
rake run:wm:rhosimulator                 # Run application on RhoSimulator

rake run:wp8                             # Build, install .xap and run on WP8 emulator
rake run:wp8:device                      # Build, install .xap and run on WP8 device
rake run:wp8:rhosimulator                # Run application on RhoSimulator

rake uninstall:android                   # uninstall from emulator
rake uninstall:android:device            # uninstall from device
rake update_rho_modules_js{platform}     # Generate rhoapi-modules.js file with coreapi and javascript parts of extensions
)))

</PRE>{TOP}

==== [http://www.motorolasolutions.com/US-EN/Business+Product+and+Services/Software+and+Applications/RhoMobile+Suite/RhoElements|RhoElements (Enterprise apps)]====
(((
RhoElements provides a set of Application Programming Interfaces (APIs) that allow you to easily incorporate any function present on any mobile device into your applications regardless of whether that function is native to the device or provided through an add-on accessory.
)))



==== RhoConnect (old RhoSync)====
<PRE>
'''summary:''' Manages connections to your enterprise data sources. Using RhoConnect, a single application can connect to multiple data sources easily. Its principal function is to serve up data to mobile devices.

# '''Start Redis server'''
#* cd {app-directory}
#* rake redis:start
# '''Start RhoSync''' (after '''Redis''' is Running!)
#* rake rhosync:start '''or''' rackup config.ru –p {port number}

[http://docs.rhomobile.com/en/2.2.0/rhoconnect/migration|Migrating RhoSync application to RhoConnect]
[http://stackoverflow.com/questions/11095213/how-to-use-rhodes-without-rhosync-or-rhoconnect|How to use Rhodes without Rhosync or RhoConnect?]
</PRE>

==== [http://app.rhohub.com|RhoHub] & RhoGallery ====
<PRE>
'''summary''': RhoHub & RhoGallery are web-based tools that support deployment of RhoMobile applications.
* RhoHub allows a developer to create the application locally in RhoStudio then build for each platform (iOS, Android, Blackberry, etc.)
* RhoGallery is best described as a private "application store" for each organization that automates application provisioning and deprovisioning. 

((('''RhoHub'''- Build developed apps in the Cloud, hassle free build process.
'''Sync app''' (source code)
* Test SSH access 
** ssh -T -p 22 git@firewall.git.rhohub.com (not working)

'''Clone (git) Project eg. ScanClient app'''
* GIT Bash:
** $ git clone git@git.rhohub.com:procm/ScanClient.git ScanClientClone
*** [http://docs.rhomobile.com/en/2.2.0/rhohub/tutorial#creating-a-rhoconnect-app|How-to setup Git]

- Clone = CheckOut)))

((('''RhoGallery (Hosted Management)'''
* [https://gallery.rhohub.com|'''RhoGallery (new)''']
* [https://app.rhohub.com/procm/galleries|'''RhoGallery (classic)'''])))
</PRE>{TOP}

==== Licenses====
<PRE>
* [http://docs.rhomobile.com/en/4.0.0/guide/licensing|Licensing Guide]

</PRE>

=== '''Competencies'''===
<PRE>
* '''M'''odel '''V'''iew '''C'''ontrol
* [http://git-scm.com/book|'''Git''' version control Book]

* '''Ruby''' [https://www.ruby-lang.org/en/] [http://rubygems.org] [https://www.ruby-toolbox.com] [http://rubydoc.info]
** Rhodes framework, similar to the popular Rails framework
*** Rhom, ORM-mapper
** Heroku, Ruby Cloud

* HTML 5
* CSS 3
* JavaScript (jQuery Mobile)
** [https://developer.mozilla.org/en-US/docs/AJAX/Getting_Started|JavaScript Mozilla]
** [http://jquerymobile.com|jQuery Mobile]

* Database
** '''SQLite''' in all platforms & '''HSQL''' as exception for BlackBerry

* Device API (access device capabilities!)
** GPS, PIM(contracts & calendar), Camera, Native mapping, Push, Signature capture, Barcode, Bluetooth  

* Rest API
** RhoConnect

* Redis- NoSQL Sync Server
** Scalable Key-Value Store

* [https://www.sslshopper.com/article-most-common-openssl-commands.html|'''SSL''' (certificate) common commands]

* '''Testing & (remote) Debugging'''
** [http://docs.rhomobile.com/en/4.0.0/guide/remote-debug|Remote Debugging Your RhoMobile JavaScript using Weinre]
** [http://developer.android.com/tools/help/adb.html|'''A'''ndroid '''D'''ebug '''B'''ridge]
** Eclipse/RhoMobile Suite
*** [http://developer.android.com/sdk/index.html|Google Android Developer Tools, Eclipse plugin] 
*** Dalvik Debug Monitor Server (DDMS)
(((DDMS is a GUI debugging application shipped with the Android SDK that provides screen capture, log dump and process examination capabilities.)))
** '''J'''ava'''Script'''
*** [http://jsfiddle.net|JSFiddle.net]
*** [http://jsbin.tumblr.com|JSBin] 
**** [http://www.youtube.com/watch?v=rXGUesjAi9g#t=62|JSbin video(s)]
*** [http://jslinterrors.com/bad-escapement-of-eol-use-option-multistr-if-needed|JSLint Error Explanations]

</PRE>{TOP}


=== '''My apps'''===
<PRE>
RhoMobile(IDE) '''workspace''': D:\Transfer.cmo\Dropbox\MyProjects\ICTNL\RhoMobile\workspace

'''ScanClientClone SOAP demo'''
* Location : %workspace%\ScanclientClone
* App URL  : [https://app.rhohub.com/procm/apps/scanclientclone_sdk4]
* Git repo : git@git.rhohub.com:procm/ScanClientClone_sdk4.git

* resources:
** [https://www.youtube.com/watch?feature=player_detailpage&v=Btbsgm-xPi8|Barcode API with RhoMobile 4.0]
** [http://www.codeproject.com/Articles/349598/Introduction-to-using-jQuery-with-Web-Services|Using jQuery with WebServices] 
** [http://www.spritle.com/blogs/2011/12/26/consume-soap-service-from-rhomobile-iphone-android-wm-and-so-on-apps|Consume WebServices (SOAP) from RhoMobile]

'''SmartTrack demo'''
Customer   : TNT Fashion
Contact    : Roel.van.Geffen@ict.nl

* Location : %workspace%\SmartTrack
* App URL  : [https://app.rhohub.com/schiej/apps/smarttrack] (Joost Schie)
* Git repo : git@git.rhohub.com:schiej/SmartTrack.git

'''ScanClient demo'''
Customer   : PostNL
Contact    : Jan.Mulder@ict.nl

* Location : %workspace%\ScanClient
* App URL  : [https://app.rhohub.com/procm/apps/scanclient]
* Git repo : git@git.rhohub.com:procm/ScanClient.git
</PRE>{TOP}

=== '''Backlog(s)'''===
<PRE>
==== Disable MC40 Scan (hardware) button/DataEdge standard functionality ====
* [https://developer.motorolasolutions.com/docs/DOC-1928#disablingdatawedge| Disabling DataWedge]

==== What to do when Motorola MC40 can't connect to WIFI?====
* Tap on Menu Button
* Select '''Settings / Wireless & networks'''
* Tap on the Menu Button again and select '''Advanced'''
* Deselect the '''Enable 802.11d''' checkbox
* Re-connect to the wireless network

==== How-to fix Git (clone) permission denied?====
* Check for SSH keys
** folder Path: %USERPROFILE%\.ssh eg: c:\users\insights\.ssh
* Generate a new SSH key (if none exists!)
** ssh-keygen -t rsa
* Add SSH (public) key in RhoHub
** Copy the contents of the file id_rsa.pub 
* eg.: [image||{UP}/ICTA/RhoMobile/RhoHub Adding SSH key.jpg]

: (((p.s.: use Git Bash to execute the commands)))

==== How to produce smaller Windows builds/CAB files?====
* [https://developer.motorolasolutions.com/thread/4869|CAB file compression]

==== Build prerequisites for '''Windows Mobile'''==== 
* Make sure you have installed the following software:
** Visual Studio 2008 Professional 
** .NET Compact Framework
** For Windows Mobile 6: Windows Mobile 6 Professional SDK Refresh
** For Windows Mobile 6.5.3: Windows Mobile 6.5.3 Professional DTK
** For Windows CE 5.0: MC3000c50b PSDK from Motorola Support Central
** Microsoft Active Sync 4.5 for Windows XP; Windows Mobile Device Center for Windows Vista or higher
*** Microsoft Device Emulator 3.0 for Windows Vista or higher

(((
* [http://docs.rhomobile.com/en/2.2.0/rhodes/build#build-for-windows|Build for Windows Mobile] 
Note that Windows Mobile versions of your Rhodes application must be built in a Windows environment.)))

==== How-to generate '''Windows Phone''' (WP8) builds?====
* Within '''VS2013''' installer install the following optional features:
** Tools for Maintaining Store apps for Windows 8
** Windows Phone 8.0 SDK
** {RhodesAppPath}>rake:wp8:production

==== RhoHub no support for Rhodes v.4 (but until v.3.5.1)==== 
* Solution: create your own (local) builds.
* update: '''...the site already supports the latest Rhodes version''' §§(procm,2014/06/03)§§ 

==== How-to deal with the JavaScript Cross-domain security feature?====
* issue: Most web developers have encountered the "same-origin" policy enforced by all browsers—your pages and applications can't access data from domains other 
than the one that serves them. This limitation means that you need complex server-side code to share data between different domains. CORS, Cross-Origin Resource 
Sharing, is a new web standard that provides a safe method for cross-domain access.

* Solution(s): Configure the web server to return back specific "custom" headers
** Enable the following "custom" headers in the Webserver:
*** Access-Control-Allow-Origin value=*
*** Access-Control-Allow-Methods value=GET,PUT,POST,DELETE,OPTIONS 
*** Access-Control-Allow-Headers value=SOAPAction,Content-Type,transition-enabled

==== How-to get client MAC address with javascript?====
* Javascript has almost no access whatever to anything outside of the web page it is attached into unless you use some other language 
running on the server to pass that information to the Javascript. This is deliberate as there are major security issues with being able 
to obtain ANY information about the setup of your visitor's computer.
** [http://codingresource.blogspot.nl/2010/02/get-client-mac-address-ip-address-using.html|Read client MAC address using '''Javascript & ActiveX''']

* Solution(s): Within ScanclientClone the MAC address is obtained through the RhoElements API using the SignalIndicators (WIFI) module.

==== How-to read RhoMobile/Rhodes configurations?====
* the '''app'''lication run-time configurations are defined in '''{appname}\rhoconfig.txt''', if needed create new/custom entry(ies) eg: ScanClientVersion = 1.0.3
* read the configuration values using eg.: var softwareVersion = "<%= Rho::RhoConfig.ScanClientVersion %>"; ('''JavaScript''')

==== How-to read only the version of the Rhodes app running?====
* Rho::RhoConfig.app_version ('''Ruby''')

==== How-to enable JavaScript '''Remote debugging''' on a Real Device?==== 
* Update NodeJS Package Manager, to solve its own self signed SSL errors: '''npm update npm -g'''
* Install WeinRE: '''npm -g install weinre'''
(((* <nowiki>start webserver: weinre --httpPort 8181 --boundHost -all- </nowiki> '''...boundHost''': -> local '''IP Address''' of '''-All-''' for every internal interface)))
* [http://docs.rhomobile.com/en/4.0.0/guide/remote-debug#enabling-weinre-in-your-app|Enable Weinre in the Client (your App)]

==== ++specific for Android platform====
* How to fix when SDK Android Manager is not opening?
** fix: Computer -> Advanced system settings -> Environment variables -> PATH -> make sure "C:\Program Files\Java\{JDK-version}\bin" became the 1st entry.

* DDMS vs Monitor tool?
** They are actually the same tool, DDMS was deprecated and replaced by Monitor tool in the latest Android SDK release. 
They can work on an emulator in order to access the file system on an actual device, but root access will be needed.

* '''android''' command
** avd ...launch Android Virtual Device Manager
** list targets ... show available targets
** create avd 
*** '''-n''' {name}, '''-t''' {targetID}, '''-c''' {size}K|M
eg.: {ADT path}\sdk\tools>android create avd -n testavd -t 1 -c 32M

* '''emulator''' command
** -avd {virtual devicename}
eg.: D:\Transfer.cmo\Software\Eclipse\Eclipse_ADT\sdk\tools> emulator -avd testavd &

* '''adb''', Android Debug Bridge command
** -s {name} ...to specify "device/emulator"
** devices ...to list available "devices/emulators", start its "daemon" if needed
** install {filename.apk} ...install apk file
** install -r {filename.apk} ...reinstall apk file 
*** eg.: {ADT path}\sdk\platform-tools> adb -s 4df1ef5c36ef5f4d install -r d:\temp\scanclientclone_signed.apk
** shell ...to get access to the (Linux Operating System) Shell
*** eg.: {ADT path}\sdk\platform-tools> adb -s 4df1ef5c36ef5f4d shell
</PRE>{TOP}

=== '''Installation RhoMobile Suite (custom)'''===
<PRE>
* Steps to build RhoStudio
** download latest '''J'''ava '''D'''evelopment '''K'''it
** download & install Eclipse for RCP and RAP Developers eg.: [https://www.eclipse.org/downloads/packages/eclipse-rcp-and-rap-developers/keplerr|Ecplise RCP and RAP Kepler x64]
** install '''D'''ynamic '''L'''anguages '''T'''ool'''K'''it using Eclipse Update Manager & next URL: [http://download.eclipse.org/technology/dltk/updates]
** clone RhoStudio sources from git repository
** import project into Eclipse workspace (menu item File/Import)
** build project (menu item Project/Build). If this menu item disabled then uncheck 'build automatically' located below
**export jar package: open export dialog (menu item File/Export); in open window select tree item 'Plugin Development/Deployable plugin and fragments'; 
in wizard you can assign destination directory for plugin jar package and his file name
** copy created plugin into you eclipse (in subfolder /plugins/) and reboot Eclipse

* Eclipse, 
** set JDK path, Window -> Preferences -> RhoMobile -> Java bin path: C:/Program Files/Java/jdk1.7.0_45/bin
*** [http://developer.android.com/sdk/installing/installing-adt.html|installing '''A'''ndroid '''D'''eveloper '''T'''ools Eclipse Plugin]

* install a stable but current '''Ruby''' eg.: v.1.9.3 [http://rubyinstaller.org|Rubby Installer for Windows]
** install Rhodes using command '''gem install Rhodes'''
** [http://rubyinstaller.org/downloads|install Ruby DEVELOPMENT KIT] 
</PRE>{TOP}

