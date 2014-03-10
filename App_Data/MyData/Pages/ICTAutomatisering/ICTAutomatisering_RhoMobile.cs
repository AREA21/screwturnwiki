Motorola RhoMobile
procm|2014/03/03 11:58:19|(((mobile,mobile apps)))(((Motorola RhoMobile)))
##PAGE##
{TOC}

=== '''Resource'''(s)===
<PRE>
[http://docs.rhomobile.com|Motorola RhoMobile]
* [http://www.pinterest.com/motosolutions/rhomobile-apps|Apps]
* [http://www.youtube.com/user/rmswebinarstemp|RhoMobile Suite Dev Talks]
* [http://vimeo.com/channels/rhomobile/12214213|Training videos on Vimeo]
</PRE>

=== '''Modules'''===


==== Rhodes====
<PRE>
'''rake - Project Build command'''

(((examples:
* rake -T  #'''List'''s all available Targets/Options) 
* rake run:android
* rake clean:android
* rake device:android:production
* rake --trace config:android  #'''Debug''' building process)))
</PRE>

==== RhoConnect (old RhoSync)====
<PRE>
# '''Start Redis server'''
#* cd {app-directory}
#* rake redis:start
# '''Start RhoSync''' (after '''Redis''' is Running!)
#* rake rhosync:start '''or''' rackup config.ru –p {port number}

[http://docs.rhomobile.com/en/2.2.0/rhoconnect/migration|Migrating RhoSync application to RhoConnect]
[http://stackoverflow.com/questions/11095213/how-to-use-rhodes-without-rhosync-or-rhoconnect|How to use Rhodes without Rhosync or RhoConnect?]
</PRE>

==== [http://app.rhohub.com|RhoHub]====
<PRE>
'''summary''': Build developed apps in the Cloud, hassle free build process.

'''Sync app''' (source code)
* Test SSH access 
** ssh -T -p 22 git@firewall.git.rhohub.com (not working)

'''Clone (git) Project eg. ScanClient app'''

* GIT Bash:
** $ git clone git@git.rhohub.com:procm/ScanClient.git ScanClientClone
*** [http://docs.rhomobile.com/en/2.2.0/rhohub/tutorial#creating-a-rhoconnect-app|How-to setup Git]

(((Clone = CheckOut)))
</PRE>

==== [https://app.rhohub.com/procm/galleries|RhoGallery (procm)]====


=== '''Competencies'''===
<PRE>
* '''M'''odel '''V'''iew '''C'''ontrol
* [http://git-scm.com/book|'''Git''' version control Book]

* Ruby
** Rhodes framework, similar to the popular Rails framework
*** Rhom, ORM-mapper
** Heroku, Ruby Cloud

* HTML 5
* CSS 3

* Database
** '''SQLite''' in all platforms & '''HSQL''' as exception for BlackBerry

* Device API (access device capabilities!)
** GPS, PIM(contracts & calendar), Camera, Native mapping, Push, Signature capture, Barcode, Bluetooth  

* Rest API
** RhoConnect

* Redis- NoSQL Sync Server
** Scalable Key Value Store

</PRE>{TOP}


=== '''My apps'''===
<PRE>
RhoMobile(IDE) '''workspace''': D:\Transfer.cmo\Dropbox\MyProjects\ICTNL\RhoMobile\workspace

'''SmartTrack demo'''
Customer       : TNT Fashion
Contact person : Roel.van.Geffen@ict.nl

* Location : %workspace%\SmartTrack
* App URL  : [https://app.rhohub.com/schiej/apps/smarttrack] (Joost Schie)
* Git repo : git@git.rhohub.com:schiej/SmartTrack.git

'''ScanClient demo'''
Customer       : TNT Fashion
Contact person : Jan.Mulder@ict.nl

* Location : %workspace%\ScanClient
* App URL  : [https://app.rhohub.com/procm/apps/scanclient]
* Git repo : git@git.rhohub.com:procm/ScanClient.git
</PRE>