KPN-NEC Eclipse IDE
celio|2010/01/22 14:40:35
##PAGE##
{TOC}

== Eclipse general==
(((summary: Eclipse IDE, projects, plugins & related stuff)))

<pre>
 source code      : D:\projects\Eclipse
 Local Repository : D:\projects\Maven\repository\mvsd
 Remote Repository: \\joshua4\maven\mvsd
 Source Control Management: svn://joshua4/KPN/NEC
</pre>

=== Plugins===
<pre>
Maven -> [http://mevenide.codehaus.org/release/eclipse/update/site.xml]
Subversion -> [http://subclipse.tigris.org/update]
</pre>

=== Projects(trunks)===
<pre>
# KPN-NEC-Applet
# KPN-NEC-Application	
# KPN-NEC-Client-API.............communication between the applet/scripting client and server
# KPN-NEC-ReleaseBundle
# KPN-NEC-Scripting 
# KPN-NEC-Server
# KPN-NEC-Shared.................classes used for the Applet & Web interfaces
# KPN-NEC-Web		 
# KPN-NEC-WebService
# KPN-NEC-Security
# KPN-NEC-NECGIS.................needs to be imported from old CVSNT & MAVENized 
# MVSD-Utilities
</pre>

=== Config files===
<pre>
 C:\Users\Celio\'''build.properties'''(local)
 Ecplise under projects/trunks: '''maven.xml''', '''project.xml'''  &  '''build.properties'''(overruled through the Local version)
</pre>

=== JavaDocs ===
summary: generate documentation from the java code existing in the project/trunk

<pre>
* '''1.Generate javadoc''' (per project) 
   eg: clean javadoc:deploy

 {| cellspacing="0" cellpadding="2" border="1" 
 ! Goal !! Description 
 |-
 | javadoc                  || The default goal. This goal simply executes the javadoc:generate goal
 |-
 | javadoc:generate         || Generates documentation using Java's built-in Javadoc tool
 |-
 | javadoc:install          || Installs the jar containing javadoc documentation in the local repository
 |-
 | javadoc:install-snapshot || Installs the jar containing javadoc documentation of the snapshot version in the local repository  
 |-
 | javadoc:deploy           || Deploys the jar containing javadoc documentation the remote repository(ies) 
 |-
 | javadoc:deploy-snapshot  || Deploys the jar containing javadoc documentation of the snapshot version to the remote repository(ies)  
 |}

* '''2.Define the javadocs dependencies''' (in the desired projects)

@@
 D:\projects\Eclipse\KPN-NEC-Server\project.xml
 <dependencies>
   <dependency>
      <properties>
         <javadoc>'''nec-shared'''</javadoc>
      </properties>
	...
   </dependency>
 </dependencies>
@@

* '''3.Finish with the maven goal...'''
** eclipse:generate-classpath

</pre>
== Maven commando's==

:'''examples'''	
<pre>
 clean jar:install-snapshot -> local Repository '''__D:\projects\Maven\repository\mvsd__'''
 clean jar:deploy-snaphot -> remote Repository '''__\\joshua4\maven\mvsd__'''
 clean  -> if the file "project.xml" is changed
 eclipse:generate-classpath
----
#'''KPN-NEC-Shared'''
#* clean jar:install-snapshot
#'''KPN-NEC-Server''' 
#* clean ejb:install-snapshot- installs a snapshot of Server Project/trunk. Creates one JAR(Java ARchive) file.
#'''KPN-NEC-Web''' 
#* clean war:install-snapshot - installs a snapshot of the Web(fb). Creates one WAR(Web ARchive) file
#'''KPN-NEC-WebService'''
#* clean war:install-snapshot - installs a snapshot of the AX(Opus) webservice. Creates one WAR(Web ARchive) file
#'''KPN-NEC-Application'''
#* clean ear weblogic:appc ejb-stubs-installsnapshot
#** clean................ deletes/cleans the target folder(classes, etc.) 
#** ear.................. creates de EAR(Enterprise ARchive) file to deploy, for the WebLogic Application server. 
#** weblogic:appc.............. compiles application, [^http://e-docs.bea.com/wls/docs81/ejb/appc_ejbc.html|Weblogic doc.]
#** ejb-stubs-installsnapshot... add this when '''__KPN-NEC-Server__''' trunk changes to create stubs(specially session beans) that comuunicate from de client to the server.
#'''KPN-NEC-Client-API''' 
#* clean jar:install-snapshot
#'''KPN-NEC-Scripting''' 
#* clean jar:install-snapshot - installs a snapshot of the Scripting Tool(JavaScript Rhino)
#'''KPN-NEC-Applet''' 
#* clean eclipse:generate-classpath... set classpath for the "Applet" project. TODO: when version numbers changed
#* clientsite:localdeploy.. om een directory te maken met de site  
#* clientsite:deploy....... om daar een zip van te maken die dan via de releasebundle opgehaald wordt
</pre>



			