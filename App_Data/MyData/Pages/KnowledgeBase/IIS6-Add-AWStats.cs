IIS6 Add AWStats
devid|2010/02/18 14:40:42
##PAGE##
=== AWSTATS (web)log analyser===
(((sumary: AWStats is an open source Web analytics reporting tool, suitable for analyzing data from Internet services such as web, streaming media, mail and FTP servers. AWStats parses and analyzes server log files, producing HTML reports. Data is visually presented within reports by tables and bar graphs. Static reports can be created through a command line interface, and on-demand reporting is supported through a web browser CGI program.)))

==== Setup for Microsoft's IIS server====
<pre>

* Step 1:

Configure IIS to create logs in the "Extended W3C log format" 
(You can still use your own custom log format but setup is easier if you use the standard extended format). 
To do so, start the IIS management console snap-in, select the appropriate web site and open its Properties. 
Choose "W3C Extended Log Format", then Properties, then the Tab "Extended Properties" & uncheck everything under Extended Properties. 
Once they are all cleared, check just the following fields:
(((date
time
c-ip
cs-username
cs-method
cs-uri-stem
cs-uri-query
sc-status
sc-bytes
cs-version
cs(User-Agent)
cs(Referer) )))
 

To be sure the log format change is effective, you must stop IIS, backup it up (if you desire) and remove all of the old log files,
restart IIS and go to your homepage. This is an example of the type of records you should find in the new log file:
2000-07-19 14:14:14 62.161.78.73 - GET / 200 1234 HTTP/1.1 Mozilla/4.0+(compatible;+MSIE+5.01;+Windows+NT+5.0) http://www.from.com/from.htm  

* Step 2:

Copy the contents of the AWStats provided cgi-bin folder, from where the AWStats package put it on your local hard drive, 
to your server's cgi-bin directory (this includes awstats.pl, awstats.model.conf, and the lang, lib and plugins sub-directories).

* Step 3:

Move AWStats icon sub-directories and its content into a directory readable by your web server, for example C:\yourwwwroot\icon.

* Step 4:

Create a configuration file by copying awstats.model.conf to a new file named awstats.mysite.conf where "mysite" is a value of your
choice but usually is the domain or virtual host name. This new file must be saved in the same directory as awstats.pl (i.e. cgi-bin).

* Step 5:

Edit your new awstats.mysite.conf file to match your specific environment:

- Change the LogFile value to the full path of your web server log file (You can also use a relative path from your awstats.pl (cgi-bin) directory).

- Change the LogType value to "W" for analyzing web log files.

- Change the LogFormat to 2 if you are using the "Extended W3C log format" described in step 1; in the case of a custom format, list the IIS fields being logged, for example: 
LogFormat="date time c-ip cs-username cs-method cs-uri-stem cs-uri-query sc-status sc-bytes cs-version cs(User-Agent) cs(Referer)"

- Change the DirIcons parameter to reflect relative path of icon directory.

- Set the SiteDomain parameter to the main domain name or the intranet web server name used to reach the web site being analyzed(Example: www.mydomain.com).

- Set the AllowToUpdateStatsFromBrowser parameter to 1 if you don't have command line access and have only cgi access.

- Review and change other parameters if appropriate.

Installation and configuration is finished. You can jump to the Process logs: Building/Updating statistics database section

</pre>

====How implement it on MVSD'sites?====

* Copy the folder "D:\Data\Websites\Components\stats" into the website folder.
* Open the file "D:\Data\Websites\Logs\awstats_update.bat" with notepad++. Add the following line to the bottom of the file.
c:\Perl\bin\perl.exe "D:\Data\Websites\Live\&#60;websitenaam&#62;\website\stats\cgi-bin\awstats.pl" -config=&#60;websiteurl&#62; -update &#62; d:\IISlogfiles\&#60;websiteurl&#62;_update.log
Example:
c:\Perl\bin\perl.exe "D:\Data\Websites\Live\ariafritta\Website\stats\cgi-bin\awstats.pl" -config=www.ariafritta.nl -update &#62; D:\Data\Websites\Logs\www.ariafritta.nl_update.log

* Rename file D:\Data\Websites\Live\&#60;websitenaam&#62;\Website\stats\cgi-bin\awstats.www.websiteurl.nl.conf to stats\cgi-bin\awstats.&#60;websiteurl&#62;.conf
Example:
D:\Data\Websites\Live\ariafritta\Website\stats\cgi-bin\awstats.www.websiteurl.nl.conf to stats\cgi-bin\awstats.www.ariafritta.nl.conf

* GO to IIS and expand the website so you can see it's folders.
* Rightmouse on the "stats" folder and select "Properties". 
* Go to tab "Directory".
* Press on button "Create".
* Change the "Execute permissions" dropdownmenu to "Scripts only".
* Check the radiobutton "A redirection to a URL".
* Write "/stats/cgi-bin/awstats.pl" in the textbox.
* Check the checkbox "A directory below URL entered".
* Press on button "Apply".
* Press rightmouse on the website and select "Properties".
* Go to tab "Web Site".
* In the "Logging" section press button "Properties".
* Write down the "Log file name". (Example: W3SVC287048403)

* Edit the file "D:\Data\Websites\Live\&#60;websitenaam&#62;\Website\stats\cgi-bin\awstats.www.websiteurl.nl.conf" with notepad++.
* Edit the following lines:
** Linenumber  51: Change &#60;logfiledir&#62; to the log file name you have written down in the previous step.
** Linenumber 149: Change &#60;websiteurl&#62; tot the url of the website.(Example: SiteDomain="www.ariafritta.nl")
** Linenumber 162: If the website has multiple headers you can add them between the accolades seperated with a single space.(Example: HostAliases="www.gebakkenlucht.nl www.pizza.nl")
** Linenumber 662: If the website works with URLQueries then set "URLWithQuery=1" else set "URLWithQuery=0".
** Linenumber 462: If you want to exclude certain IP addresses you can add them here. By default all MVSD IP addresses have been excluded


<pre>
'''NOTE'''<br />
When the applications web.config contains HttpHandlers/HttpModules -sections the awstat will show an error page.
* Rightmouse on the webapp and select "Properties". 
* Go to tab "Home Directory".
* Press on button "Configuration".
* Go to tab "Mappings".
* Insert new wildcard with filepath: "C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\aspnet_isapi.dll"
** Make sure the checkbox "Verify that file exists" is unchecked. (If this is checked, webresources will not work.)
* Press on button "OK/Apply".
</pre>
 
That's it! To view the stats just browse to "http://&#60;websiteurl&#62;/stats"&#62;http://&#60;websiteurl&#62;/stats".


{TOP} 