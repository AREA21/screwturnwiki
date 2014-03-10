KPN-NEC HowTo's
procm|2012/12/10 14:18:55
##PAGE##
{TOC}

== Installation & Deployments==
* [KPN-Nec_NewRelease|How to deploy a new Release]
* [KPN-NEC_InstallWebforms|Install Webforms]
* NEC3- Server installatie en beheer handleiding (look '''@nec-testserver'''\d\MyProjects\MVSD\KPN\Docs)

== Job Scheduler ==
*[http://en.wikipedia.org/wiki/CRON_expression|Cron Expressions(wiki)]
*[http://wiki.pentaho.com/display/ServerDoc1x/05.+CRON+Expressions+in+Detail?showComments=false|Cron Expressions in Detail]


== Debug==

 [http://www.ibm.com/developerworks/library/os-ecbug|Debugging with the Eclipse Platform (IBM)]

 [http://ramakrsna.wordpress.com/2008/08/27/using-tcpip-monitor-with-weblogic-webservice-clients|Using '''TCP/IP Monitor''' with Weblogic Webservice Clients]

=== Remote debug===
 Java Platform Debugger Architecture (JPDA)
<pre> 
* '''Weblogic configuration'''  
::  @rem JVM remote debugging *cmo 17/11/2008
::  '''set DEBUG_OPTS'''= -Xdebug -Xnoagent -Xrunjdwp:transport=dt_socket,address=1044,server=y,suspend=n

::  @rem Set JAVA_OPTIONS to the java flags you want to pass to the vm. i.e.: 
::  set JAVA_OPTIONS=-Dweblogic.Stdout="%USERDOMAIN_HOME%\logs\stdout.log" '''%DEBUG_OPTS%'''
::  ...


* '''Eclipse client configuration'''
 [image||{UP:ScrewTurn.Wiki.FilesStorageProvider}/MVSD/KPN-NEC/Remote Debug/Java Remote Debug- Eclipse(client).jpg]
</pre>

== Bea Weblogic==

=== Upgrade BEA WLS 8.1 to ORACLE WLS 11g(10.3.1)===
<pre>
 [https://visualvm.dev.java.net/|All-in-One Java Troubleshooting Tool]
 
 [http://download.oracle.com/docs/cd/E12839_01/web.1111/e13718/atn.htm#i1154044|Developing Security Providers for Oracle WLS]

 [http://download.oracle.com/docs/cd/E13179_01/common/docs90/upgrade/viewlet/upgrade/upgrade.viewlet/upgrade_viewlet_swf.html|Upgrading a Weblogic Application Environment to 9.0]

 [http://www.oracle.com/technology/documentation/bea.html|Bea Product Documentation]

 [http://download.oracle.com/docs/cd/E12839_01/web.1111/e13754/toc.htm|Upgrade Guide for Oracle WebLogic Server 11g Release 1 (10.3.1)]
</pre>

:'''Performance Tools & Information:''' [http://e-docs.bea.com/wls/docs81/perform/appa_reading.html#1042349]

:'''Start Jrockit Management console(testserver.mvsd.nl)'''

::summary: usefull to monitor WebLogic application server, performance, status, memory, etc..

<pre>
* Launch Weblogic Service with parameter '''-Xmanagement''' in the MEM_ARGS  
*<sup>(lock at testserver\bea\weblogic\user_projects\domains\test\installServiceCmo.cmd)</sup>
* java -jar z:\bea\jrockit81sp6_142_10/console/ManagementConsole.jar

* Create a new connection
** server name: testserver.mvsd.nl
** port: 7090(default)
** fig.: [image||{UP:ScrewTurn.Wiki.FilesStorageProvider}/MVSD/KPN-NEC/Management/Weblogic JRockit Management Console.jpg]
</pre>


== Oracle Database==

Modified: §§(celio,2010/01/16 15:58:51)§§

=== Oracle Terminology===
<pre>
 '''EMCA''' - '''E'''ntreprise '''M'''anager '''C'''onfiguration '''A'''ssistant
 '''EMCTL''' - '''E'''nterprise '''M'''anager '''C'''on'''T'''ro'''L'''
 '''DBCA''' - Oracle '''D'''ata'''B'''ase '''C'''onfiguration '''A'''ssistant
</pre>

=== Resources===
<pre>
==== General====
:: '''Oracle Wiki:''' [http://www.orafaq.com/wiki/Main_Page]

:: '''Online Documentation 10g Release 2(10.2):''' [http://www.oracle.com/pls/db102/homepage]

:: '''Advanced functions of SQL Developer:''' [http://www.andschulte.de/sql-developer-miration-workbench-plsql-user-defined-reports-with-gauges.htm]

==== Installation, Configuration & Licensing====
:: '''Drop, Create And Recreate DB Control In 10g Database:''' [http://arjudba.blogspot.com/2008/04/how-to-drop-create-and-recreate-db.html]
:: '''Oracle Licensing:''' [http://www.orafaq.com/wiki/Oracle_licensing]

==== Performance====
:: '''Partitioning:''' 
::: '''What-Why-When-Who-Where-How:''' [http://www.devarticles.com/showblog/36043/Partitioning-in-Oracle-What-Why-When-Who-Where-How]
::: '''A question of the right strategy:''' [http://www.andschulte.de/oracle-11g-reference-interval-virtual-column-partitioning.htm]

:: '''Large Database Features In Oracle:''' [http://www.devshed.com/c/a/Oracle/Large-Database-Features-In-Oracle]

:: '''Oracle detect & diagnose performance problems:''' [http://www.oracle.com/technology/oramag/oracle/04-may/o34tech_talking.html]

==== Programming ====
:: '''Format SQL or PL/SQL online:''' [http://www.dpriver.com/pp/sqlformat.htm]

:: '''Oracle-PLSQL Topics Functions (By Category):''' [http://www.techonthenet.com/oracle/functions/] 

:: '''Generating random numbers & strings(PL/SQL):''' [http://www.databasejournal.com/features/oracle/article.php/3341051/Generating-random-numbers-and-strings-in-Oracle.htm]
</pre>

=== [http://www.oracledistilled.com/windows/configuring-the-loopback-adapter-on-microsoft-windows|How to configure Loopback Network adapter in Windows]===

=== Start Oracle Enterprise Manager=== 
:[http://localhost:1158/em] 
<pre>
 SET ORACLE_SID = &lt;database_sid&gt;
 emctl start dbconsole
 
 OC4J(Oracle Containers For Java) 
 [http://dbataj.blogspot.com/2007/01/oc4j-configuration-issue.html]
</pre>
=== Start Oracle Enterprise Manager=== 
:[http://localhost:1158/em] 
<pre>
 SET ORACLE_SID = &lt;database_sid&gt;
 emctl start dbconsole
 
 OC4J(Oracle Containers For Java) 
 [http://dbataj.blogspot.com/2007/01/oc4j-configuration-issue.html]
</pre>
=== Oracle Database Migration using Export/Import Dump files===

[http://www.orafaq.com/wiki/Import_Export_FAQ], we can also use this to Upgrade Oracle Databases 

=== Load Flat Files (SQL Loader)===
<pre>
summary: SQL*Loader is the primary method for quickly populating Oracle tables with data from external files. 
It has a powerful data parsing engine that puts little limitation on the format of the data in the datafile. 
SQL*Loader is invoked when you specify the sqlldr command or use the Enterprise Manager interface. 

[http://www.oracle.com/technology/products/database/utilities/htdocs/sql_loader_overview.html|'''Overview''']
[http://www.orafaq.com/wiki/SQL%2ALoader_FAQ |'''FAQ''']
[http://www-it.desy.de/systems/services/databases/oracle/sqlload/sqlload.html.en|'''SQL LOADER''']
[http://oreilly.com/catalog/orsqlloader/chapter/ch01.html|'''SQL Loader Command Line(SQLLDR)''']  

==== SQL Loader GUI====
:: GoTO-> '''Enterprise Manager'''(eg: [http://testserver:1158/em]) under '''Maintenance''' then '''Load Data from User Files''' 

==== SQL Loader Commandline====
:: run the command(command prompt)- D:\temp> SQLLDR nec30/nec123@nec CONTROL='''{filename.ctl}''' LOG='''{filename.log}''' ERRORS='''{number}'''
</pre>


=== Create Formated Output===
<pre>
'''CSV example:'''
  SET LINESIZE 2000;
  SET PAGESIZE 5000;
  SET LINES 32767;
  SET PAGES 0;
  SET TRIMSPOOL ON;
  SET FEEDBACK OFF;
  SET COLSEP ';';
  SPOOL d:\temp\nec\SN+NECID.csv;

  SELECT p.name,p.xmlid, p.version_1
  FROM NEC30.pack p
  WHERE documenttype=3 AND layer=3 
  AND(statusid='a28adc827903150a0002d5ecae436a20' OR statusid='a28c17057903150a0002d5ec64b115c6' 
  OR statusid='fe629b6b7903150a0538559ec43b0dc0') 
  ORDER By p.name, p.version_1;

  SPOOL OFF;
</pre>

<pre>
'''HTML example:'''
    SET MARKUP HTML on
    SPOOL index.html
    SELECT * FROM tab;
    SPOOL OFF
    SET MARKUP HTML OFF
</pre>

=== Others===
<pre>
==== Find the current DB_NAME & ORACLE_SID====
   Net Manager (x:\oracle\products\10.x.x\db_1\bin\launch.exe)

==== Run SQL script====
   At the SQLplus prompt> type eg. @d:\temp\SN+NECID.SQL

==== Show Date columns with different format/mask====
   TO_CHAR(createdatetime, 'DD/MM/YYYY HH24:MI:SS')
</pre>

== Code Signing (Java)==
:'''Resource(s)'''
<pre>
[http://en.wikipedia.org/wiki/Code_signing|'''Code Signing'''(Wiki)]
[http://search.thawte.com/thawte/solutionDisplay.do?clusterName=DefaultCluster&groupId=1&docType=1006&docProp=$solution_id&docPropValue=vs30621&gotoLink=0&resultType=5002&directSolutionLink=1|'''Generate Keystore & CSR for Sun Java™ Certificate''']
[http://search.thawte.com/thawte/solutionDisplay.do?clusterName=DefaultCluster&groupId=1&docType=1006&docProp=$solution_id&docPropValue=vs17991&gotoLink=0&resultType=5002&directSolutionLink=1|'''Import Certificate into Keystore - Sun Java™ Certificate''']
</pre>

:'''Generate/renew a Code-Signing certificate'''
<pre>
* '''1.use the existing KEYSTORE file''' (KPN-NEC-Applet\nec\keystore- to keep all granted certificates in one place)

* '''2.Generating a CSR for a Public Key Certificate''' *'''x''' is each year incremented!! 
** JAVA_HOME\bin\keytool -certreq -keystore keystore -alias mvsd'''x'''_thawte -storepass lam11biek -file mvsd2010.csr
*** the content of this new generated file will be copied to the renew form in the request renewal process(Thawte CA)  

* '''3.Importing the Certificate Reply from the CA''' *'''x '''is each year incremented!!
** JAVA_HOME\bin\keytool -import -keystore keystore -alias mvsd'''x'''_thawte -storepass lam11biek  -file mvsd2010.pkcs 

* '''Howto(s)''' 
** generate a new '''keystore''' file?
*** note: password for '''mvsdx_thawte''' should be the same as the keystore. (just give an enter when you get to the prompt)
**** JAVA_HOME\bin\keytool -genkey -keystore keystore -alias mvsd5_thawte -keyalg RSA -storepass lam11biek -dname "cn=www.mvsd.nl, ou=MVSD B.V., o=MVSD B.V., L=Rotterdam, S=Zuid-Holland, c=NL" 
** How to view the certificate information in the '''keystore''' file?
*** JAVA_HOME\bin\keytool -list -v -keystore keystore -storepass lam11biek

* '''Eclipse trunk'''(file location)
**  KPN-NEC-Applet
*** keystore (keeps all granted certificates!!) 
*** mvsdxxxx.CSR ALIAS: mvsdx_thawte *'''x''' is each year incremented!!
*** mvsdxxxx.pkcs

* '''Jargon'''
** '''CA''' - '''C'''ertificate '''A'''uthority
** '''CSR''' - '''C'''ertificate '''S'''igning '''R'''equest
** '''PKCS''' - '''P'''ublic-'''K'''ey '''C'''ryptography '''S'''tandards
</pre>

:'''Sign JAR files (manually)''' *'''x''' is each year incremented!!
<pre>
 JAVA_HOME\bin\jarsigner '''-keystore''' d:\projects\Eclipse\KPN-NEC-Applet\nec\keystore '''-storepass''' lam11biek '''JARFILE''' mvsdx_thawte
</pre>

:'''UnSign previously signed JAR files'''
<pre>
 Open the JAR file with Winzip (Izarc can corrupt the file) & delete:
 META-INF\MVSD?_TH.SF
 META-INF\MVSD?_TH.RSA 
</pre>

== Troubleshooting==			
summary: Debug, Tracing, Error handeling...

=== Create Scripting Tool shortcut===
<pre>
* Config '''Java(plugin)''' to allow the creation of shorcuts.
*# Got to Windows Control Planel, Java icon under Shortcut Creation(Advanced Tab) choose '''Always allow'''.
*# In IE go to the URL '''http://{server}/scripting'''  to load the Scripting Tool and create the shortcuts

* If the Scripting tool has been executed previously we have to (re)create the shortcut manually. 
*# Go to Windows Control Panel, open the Java(plugin) icon.
*# Next in the General tab in de Temporary Internet Files group click on the View button.
*# Finally in the “application” kolom click on the NEC xxx scripting Tool item with the right mouse button en choose Install Shortcuts.

</pre>

=== TraceLogs files ===
<pre>
: \\testserver\d$\Projects\KPN\NEC\test\Server\logs\...
: \\testserver\d$\bea\user_projects\domains\test\logs\... stdout.log - for JSPexceptions 
: C:\Users\Celio\AppData\Roaming\Sun\Java\Deployment\log -> Applet/client log
</pre>

=== Client cannot connect to NEC===
cause: Weblogic '''development license''' only permits 5(max) connections/IP address
<pre>
 Restart the bea windows service to reset the Ip address/connection status
 [http://e-docs.bea.com/platform/docs81/install/license.html#1046001|Weblogic Licenses Overview]
</pre>

=== JDBC not starting after Server restart===
<pre>
:'''important logs:(Test omgeving)'''
:: C:\bea81\user_projects\domains\Nec\logs
::: stdout.log
::: stderr.log 

:'''JDBC- recreate new connection'''
* MS-DOS command line, in the machine, write the following:
** sqlplus "sys/lam11biek as sysdba"

* Sql command prompt
** startup
** quit
</pre>


== Best pratices/tips==
<pre>
Performance: in Quartz jobs always use "usertransactions".
  test without: Total time needed to export 252747ms.
  test with: Total time needed to export 12719ms.
</pre>

== FAQ's==
<pre>
* How the NEC projects are build? How Maven/Ant/Jelly are working & also to which directory/file are the compiled code going?
**...answer

* What is the role of the POM(Project Objec Model) files?
**...answer

* What are the differences (in WebWork) between tags %{}, ${}, #xx.yy, @xx.yy ? Are this comming from the Template language (freemarker, velocity)?
**...answer 

* What are the roles of "FrontDoor" and "FrontDoorRemote" ?
** FrontDoorRemote is used to communicate from the CLIENT-API to the SERVER. 
** FrontDoor is a FrontDoorRemote instance, everthing called from FrontDoor must be declared in the FrontDoorRemote. 

* How to get rid of the following exception? ...happens with the Packs(ServiceDocuments) with ServiceData.
:(((Exception: {br}Incoming message header or abbreviation processing failed ; nested exception is: java.io.InvalidClassException: {BR} nl.mvsd.nec.service.ServiceDataValue; local class incompatible: stream classdesc serialVersionUID = -1926541914233786035, local {BR} class serialVersionUID = 231155198854267000 Stacktrace: java.rmi.UnmarshalException: Incoming message header or abbreviation {BR} processing failed ; nested exception is: java.io.InvalidClassException: nl.mvsd.nec.service.ServiceDataValue; local class {BR} incompatible: stream classdesc serialVersionUID = -1926541914233786035, local class serialVersionUID = 231155198854267000 at {BR} weblogic.rjvm.ConnectionManager.dispatch(ConnectionManager.&lt;java:7...)))

::'''Solution''': We have to create the Stubs using the command (KPN-NEC-Application):  ejb-stubs-installsnapshot.
</pre>