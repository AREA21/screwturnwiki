Build NAnt
devid|2010/03/18 13:36:05
##PAGE##
{TOC}

==Important! Read the page [Building-And-Publishing-Projects|Building And Publishing Projects] first!==

==Introduction==
NAnt is a useful tool for automating the build process. The build process can include tasks such as compiling source code and resource files into assemblies, running unit tests, configuring build-specific settings, and so on. The benefit of tools like NAnt is that they help automate the build process by providing enough power and flexibility to highly customize build actions for specific applications.

The NAnt-script retrieves the project files from the SVN-repository, builds them, ZIP's them and sends an e-mail with the build information.

'''The build-script is executed on the TESTSERVER.'''


==Usefull keywords for searching information on the internet==
* NAnt
* aspnet_compiler.exe
* aspnet_merge.exe
* csc.exe
* nant.exe

==Modifications made in NAnt configuration==
* Current used version is NAnt 0.85.
* Added a section for .NET Framework 3.5 in '''\\testserver\c$\Program Files\nant-0.85\bin\NAnt.exe.config'''


==NAnt keywords==
====NAnt====
The physical executable (and the associated tasks) that form the application.

====Project====
The root node of a build script. Each script has one project.

====Target====
A subdivision of a project. A target is a discrete piece of work that can consist of zero or more tasks. Targets can be dependent on each other. A Target is typically an action executed on a file, set of files or directory.

====Task====
A task is a defined activity that NAnt will execute; for example, creating a directory or zipping a file. There are many built-in tasks to NAnt.

====Property====
An XML key/value pair that can be used to configure tasks and targets in a more dynamic fashion. Property values can be overridden from the command line.
 

==Build-script description==
====Running build-script====
The build-script can be started from commandline and has been put in an executable batch-file. This command consist of the executable NAnt and six parameters which overwrite some properties defined in the build-script:
* Full path to NAnt.exe   (extension not required, don't forget to surround a filepath with quotes if it contains spaces).
** "C:\Program Files\nant-0.85\bin\nant.exe"
* 1st parameter: Path to the build-script (Full path not required if it's located in the same folder as the batch-file).
** -buildfile:EasyWebEdit.build 
* 2nd parameter: Path for the build logfile (Full path not required if it's located in the same folder as the batch-file).
** -logfile:EasyWebEdit.build.log  
* 3rd parameter: The library used for logging.
** -logger:NAnt.Core.MailLogger 
* 4th parameter: Full path to the project build directory.
** -D:LocalPath.Dir="D:\Projects\EasyWebEditNet\MVSD\Website\Build\\" 
* 5th parameter: The e-mailaddress where the build logfile should be send to. (Multiple e-mailaddresses are separated with a semicolon)
** -D:Mail.Recipients="build@mvsd.nl"
* 6th parameter: Full path to the .NET Framework dir.
** -D:DotNetFramework.Dir="C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\\"

====Running build-script====
The build-script roughtly consist out of four parts.

====Properties====
The property part contains all of the necessary variables needed for the build such as SMTP server, folderpaths, SVN urls etc...

====Target: ExecuteAll====
This target is called in the '''default''' attribute of the '''project''' element of the buil-file. This target calls all other targets in the right order. It contains a try/catch block to revert the build in case of a build failure.

====Target: TestParameters====
This target tests the validity of the values of some of the most important properties (defined in the beginning).

====Target: Clean====
Removes any existing build output folders and (re)creates them.

====Target: Get====
This target calls (sub)targets which are used to retrieve the project-files from the SVN-Repository. These project-files are debugged, released and zipped in the following targets.

====Target: Build====
This target calls the debug and release targets. These targets will debug the project-files and then combine and prepare them for use in IIS.

====Target: Deployment====
This target creates a deployment directory containing all that is needed for a deployment.

====Target: Zip====
This targets zips the files in the deployment directory.

==Example build-script==
====Batch file====
<pre>@echo off
echo Use the -verbose+ option to retrieve additional information.
"C:\Program Files\nant-0.85\bin\nant.exe" -buildfile:EasyWebEdit.build -logfile:EasyWebEdit.build.log -logger:NAnt.Core.MailLogger -D:LocalPath.Dir="D:\Projects\EasyWebEditNet\AriaFritta\Build\\" -D:Mail.Recipients="build@mvsd.nl" -D:DotNetFramework.Dir="C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\\"
pause</pre>

====Build-script====
<code xml><?xml version="1.0" ?>
<project name="AriaFritta" default="ExecuteAll" basedir="." xmlns="http://intranet.mvsd.nl/schemas/nant2.xsd">
  <!-- Build script version 1.0.1 -->
  <!-- LocalPath.Dir
	The directory containing the local path.
	Specify this folder in the calling batch file. 
	Syntax: -D:LocalPath.Dir="[local path]"
	Don't forget the escape character in the last backslash ('\\' instead of '\').
	Example:
	"C:\Program Files\Nant\bin\nant.exe" [options] -D:LocalPath.Dir="C:\My localpath folder\\" [targets] //-->
  <property name="LocalPath.Dir" value="" readonly="false" overwrite="false" />
  <!-- Mail.Recipients
	The semicolon seperated mail recipients of the success or failure of the build
	Specify these recipients in the calling batch file. 
	Syntax: -D:Mail.Recipients="[recipientlist]"
	Example:
	"C:\Program Files\Nant\bin\nant.exe" [options] -D:Mail.Recipients="jeroen@mvsd.nl;build@microsoft.com" [targets] //-->
  <property name="Mail.Recipients" value="" readonly="false" overwrite="false" />
  <!-- DotNetFramework.Dir
	The directory containing the .NET framework.
	Specify this folder in the calling batch file. 
	Syntax: -D:DotNetFramework.Dir="[DotNetFramework path]"
	Don't forget the escape character in the last backslash ('\\' instead of '\').
	Example:
	"C:\Program Files\Nant\bin\nant.exe" [options] -D:DotNetFramework.Dir="C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\\" [targets] //-->
  <property name="DotNetFramework.Dir" value="" readonly="false" overwrite="false" />

  <property name="WebDeploymentExePath" value="C:\Program Files\MSBuild\Microsoft\WebDeployment\v8.0" />

  <property name="debug" value="true" overwrite="false" />
  <property name="Build.Success" value="true"></property>

  <property name="ProjectName" value="AriaFritta build"></property>
  <property name="FinalDeployDllName" value="Mvsd.EasyWebEdit.UI.dll" />
  
  <property name="Svn.Trunk" value="svn://joshua4/EasyWebEditNET/AriaFritta/trunk/" />
  <property name="Base.Svn.Dir" value="svn://joshua4/EasyWebEditNET/AriaFritta/trunk/" />
  <property name="ExternalBin.Dir" value="${LocalPath.Dir}ExternalBin\" />
  <property name="Configuration.Dir" value="${LocalPath.Dir}Configuration\" />
  <property name="Database.Dir" value="${LocalPath.Dir}Database\" />
  <property name="Deployment.Dir" value="${LocalPath.Dir}Deployment\" />
  <property name="Archive.Dir" value="${LocalPath.Dir}Archive\" />
  <property name="SVNUser" value="build" />
  <property name="SVNPassword" value="!!lam11biek!!" />
  <property name="MailLogger.mailhost" value="joshua4" />
  <property name="MailLogger.from" value="build@mvsd.nl" />
  <property name="MailLogger.failure.to" value="${Mail.Recipients}" />
  <property name="MailLogger.failure.subject" value="${ProjectName} failure" />
  <property name="MailLogger.success.to" value="${Mail.Recipients}" />
  <property name="MailLogger.success.subject" value="${ProjectName} succes" />
  <property name="Source.Base.Dir" value="${LocalPath.Dir}Source\" />
  <property name="Build.Base.Dir" value="${LocalPath.Dir}Compiled\" />

  <property name="Module.PhotoAlbum.BaseDir" value="${Source.Base.Dir}FotoAlbum\" />
  <property name="Module.PhotoAlbum.Dir" value="${Module.PhotoAlbum.BaseDir}" />
  <property name="Module.Website.BaseDir" value="${Source.Base.Dir}Website\" />
  <property name="Module.Website.Dir" value="${Module.Website.BaseDir}" />
  
  
  <property name="Svn.RetrieveDir" value=""></property>
  <property name="Svn.LocalDir" value=""></property>
  <!--
	
	Execute section
	==============================================================================================================
	Calls all targets in the correct order.
	
	//-->
  <target name="ExecuteAll">
    <trycatch>
      <try>
        <call target="TestParameters" />
        <call target="Clean" />
        <call target="Get" />
        <call target="Build" />
        <call target="Deployment" />
        <call target="Zip" />
      </try>
      <catch property="failure">
        <echo message="Caught failure ${failure}" />
        <call target="Zip.Revert" />
        <fail message="${failure}"></fail>
      </catch>
    </trycatch>
  </target>
  <target name="ExecuteGet">
    <call target="TestParameters" />
    <call target="Clean" />
    <call target="Get" />
  </target>
  <target name="ExecuteBuild">
    <call target="TestParameters" />
    <call target="Build" />
  </target>
  <target name="ExecuteTests">
    <call target="TestParameters" />
    <call target="Test" />
  </target>
  <!-- 
	Test parameter section
	=========================================================================================
	Tests the parameters used in the build script.
	//-->
  <target name="TestParameters">
    <if test="${LocalPath.Dir == ''}">
      <fail message="The local path is not specified. To do this, specify parameter 'LocalPath.Dir' in the call to NAnt. See the documentation in the current build file." />
    </if>
    <if test="${Mail.Recipients == ''}">
      <fail message="The mail recipients are not specified. To do this, specify parameter 'Mail.Recipients' in the call to NAnt. See the documentation in the current build file." />
    </if>
    <if test="${DotNetFramework.Dir == ''}">
      <fail message="The .Net framework dir is not specified. To do this, specify parameter 'DotNetFramework.Dir' in the call to NAnt. See the documentation in the current build file." />
    </if>
  </target>
  <!--
	
	Clean section
	=============
	Cleans up all files and folders that will be used for the build.
	
	//-->
  <target name="Clean" description="remove all files that are retrieved from source code control">
    <delete dir="${Source.Base.Dir}" if="${directory::exists(Source.Base.Dir)}" />
    <delete dir="${Build.Base.Dir}" if="${directory::exists(Build.Base.Dir)}" />
    <delete dir="${ExternalBin.Dir}" if="${directory::exists(ExternalBin.Dir)}" />
    <delete dir="${Deployment.Dir}" if="${directory::exists(Deployment.Dir)}" />
    <delete dir="${Configuration.Dir}" if="${directory::exists(Configuration.Dir)}" />
    <delete dir="${Database.Dir}" if="${directory::exists(Database.Dir)}" />

    <mkdir dir="${Source.Base.Dir}" />
    <mkdir dir="${Build.Base.Dir}" />
    <mkdir dir="${ExternalBin.Dir}" />
    <mkdir dir="${Configuration.Dir}" />
    <mkdir dir="${Database.Dir}" />
    <mkdir dir="${Deployment.Dir}" />
  </target>
  <!--
	
	Get section
	===========
	Retrieves the files needed for the build.
	
	//-->
  <target name="Get">
    <call target="Get.ExternalBin" />
    <call target="Get.Configuration" />
    <call target="Get.Database" />
    <call target="Get.PhotoAlbum" />
    <call target="Get.Website" />
  </target>
  <target name="Get.ExternalBin">
    <property name="Svn.RetrieveDir" value="${Base.Svn.Dir}ExternalBin" />
    <property name="Svn.LocalDir" value="${ExternalBin.Dir}" />
    <call target="Get.SVN" />
  </target>
  <target name="Get.Configuration">
    <property name="Svn.RetrieveDir" value="${Base.Svn.Dir}Configuration" />
    <property name="Svn.LocalDir" value="${Configuration.Dir}" />
    <call target="Get.SVN" />
  </target>
  <target name="Get.Database">
    <property name="Svn.RetrieveDir" value="${Base.Svn.Dir}Database" />
    <property name="Svn.LocalDir" value="${Database.Dir}" />
    <call target="Get.SVN" />
  </target>
  <target name="Get.PhotoAlbum">
    <property name="Svn.RetrieveDir" value="${Base.Svn.Dir}FotoAlbum" />
    <property name="Svn.LocalDir" value="${Module.PhotoAlbum.BaseDir}" />
    <call target="Get.SVN" />
  </target>
  <target name="Get.Website">
    <property name="Svn.RetrieveDir" value="${Base.Svn.Dir}Website" />
    <property name="Svn.LocalDir" value="${Module.Website.BaseDir}" />
    <call target="Get.SVN" />
  </target>
  <target name="Get.SVN">
    <svn-checkout
        destination="${Svn.LocalDir}"
	uri="${Svn.RetrieveDir}"
	username="${SVNUser}"
	password="${SVNPassword}"
		/>
  </target>
  <!--
	
	Build section
	=============
	Performs the build.
	
	//-->
  <target name="Build">
    <call target="Build.Release" />
  </target>

  <target name="Build.Release">
    <property name="Build.Dir" value="${Build.Base.Dir}Release\" />
    <mkdir dir="${Build.Dir}" />
    <property name="debug" value="false" />
    <property name="define" value="TRACE" />
    <call target="Build.PhotoAlbum" />
    <call target="Build.Website" />
  </target>

  <target name="Build.PhotoAlbum">
    <property name="output" value="${Build.Dir}Mvsd.PhotoAlbum.Business.dll" />
    <property name="doc" value="${Build.Dir}Mvsd.PhotoAlbum.Business.xml" />
    <csc target="library" output="${output}" debug="${debug}" doc="${doc}" define="${define}">
      <sources>
        <include name="${Module.PhotoAlbum.Dir}**.cs" />
      </sources>
      <references>
        <include asis="true" frompath="true" name="${DotNetFramework.Dir}System.dll" />
        <include asis="true" frompath="true" name="${DotNetFramework.Dir}System.Configuration.dll" />
        <include asis="true" frompath="true" name="${DotNetFramework.Dir}System.Data.dll" />
        <include asis="true" frompath="true" name="${DotNetFramework.Dir}System.Drawing.dll" />
        <include asis="true" frompath="true" name="${DotNetFramework.Dir}System.Web.dll" />
        <include asis="true" frompath="true" name="${DotNetFramework.Dir}System.XML.dll" />
        <include asis="true" frompath="true" name="${ExternalBin.Dir}Microsoft.Practices.EnterpriseLibrary.Common.dll" />
        <include asis="true" frompath="true" name="${ExternalBin.Dir}Microsoft.Practices.EnterpriseLibrary.Data.dll" />
        <include asis="true" frompath="true" name="${ExternalBin.Dir}Mvsd.EasyWebEdit.Business.dll" />
      </references>
    </csc>
  </target>
  
  
  <target name="Build.Website">
    <!-- To build the website copy the compiled dlls to the bin dir of the website -->
    <copy todir="${Module.Website.Dir}\bin\" flatten="true">
      <fileset basedir="${Build.Dir}">
        <include name="**.dll" />
      </fileset>
    </copy>

    <!-- Copy external dlls for the website -->
    <copy todir="${Module.Website.Dir}\bin\" flatten="true">
      <fileset basedir="${ExternalBin.Dir}">
        <include name="CuteEditor.dll" />
        <include name="CuteEditor.ImageEditor.dll" />
	<include name="CuteEditor.lic" />
        <include name="Microsoft.ApplicationBlocks.ExceptionManagement.Interfaces2.dll" />
        <include name="Microsoft.ApplicationBlocks.ExceptionManagement2.dll" />
        <include name="Microsoft.Practices.EnterpriseLibrary.Common.dll" />
        <include name="Microsoft.Practices.EnterpriseLibrary.Data.dll" />
        <include name="Microsoft.Practices.ObjectBuilder.dll" />
        <include name="Mvsd.Components.Exception.ExceptionRouter2.dll" />
        <include name="Mvsd.Components.Exceptions.ExceptionManagement2.dll" />
        <include name="Mvsd.Components.Exceptions.Publishers2.dll" />
        <include name="NetSpell.SpellChecker.dll" />
        <include name="Mvsd.EasyWebEdit.Business.dll" />
	<include name="Mvsd.Newsletter.Business.dll" />
      </fileset>
    </copy>

    <exec basedir="."
          program="${DotNetFramework.Dir}\aspnet_compiler.exe"
          commandline="-nologo -v website -p ${Module.Website.Dir} ${Build.Dir}\Precompiled"
          workingdir="."
          failonerror="true" />

    <exec program="${WebDeploymentExePath}/aspnet_merge.exe"
          commandline="${Build.Dir}\Precompiled -o ${FinalDeployDllName} -xmldocs -copyattrs"/>

    <!-- Copy license files -->
    <copy todir="${Build.Dir}\Precompiled">
      <fileset basedir="${Configuration.Dir}">
        <include name="**.lic" />
      </fileset>
    </copy>

    
    <delete>
      <!--Remove unnecessary files from the build.-->
      <fileset>
        <include name="${Build.Dir}\Precompiled\*.build" />
        <include name="${Build.Dir}\Precompiled\*.scc" />
        <include name="${Build.Dir}\Precompiled\*.sln" />
        <include name="${Build.Dir}\Precompiled\build.*" />
      </fileset>
    </delete>
  </target>

  <!--
		Deployment section
		============================================================================================================================================
		Creates a deployment directory containing all that is needed for a deployment.
	//-->
  <target name="Deployment">
    <copy todir="${Deployment.Dir}\Website" flatten="false">  
      <fileset basedir="${Build.Dir}\Precompiled">
        <include name="**.*" />
        <exclude name="nunit.framework.dll" />
      </fileset>
    </copy>

    <copy todir="${Deployment.Dir}\Configuration" flatten="false">
      <fileset basedir="${Configuration.Dir}">
        <include name="**.*" />
      </fileset>
    </copy>

    <copy todir="${Deployment.Dir}\Database" flatten="false">
      <fileset basedir="${Database.Dir}">
        <include name="**.*" />
      </fileset>
    </copy>

  </target>

  <!--
    Zip section
    ============================================================================================================================================
    Performs the Release zip and adds a timestamp to the zip's filename.
    -->
    <script language="C#" prefix="format">
        <cod e><![CDATA[[Function("format-date")]
        public static string FormatDate(DateTime date)
        {
            return date.ToString("yyyy-MM-dd_HH.mm");
        }
        ]]></co de>
    </script>
  <property name="TimeStamp" value="_${format::format-date(datetime::now())}" />
	
  <target name="Zip">
    <zip zipfile="${LocalPath.Dir}${ProjectName}${TimeStamp}.zip" includeemptydirs="true" ziplevel="6">
      <fileset basedir="${LocalPath.Dir}">
        <include name="${Deployment.Dir}**" />
      </fileset>
    </zip>
    <move todir="${Archive.Dir}">
      <fileset basedir="${LocalPath.Dir}">
        <include name="*.zip" />
      </fileset>
    </move>
  </target>
  
  <target name="Zip.Revert">
    <property name="ZipFileName" value="${LocalPath.Dir}${ProjectName}${TimeStamp}.zip" />
    <delete file="${ZipFileName}" if="${file::exists(ZipFileName)}" />
    <property name="ZipFileName" value="${Archive.Dir}${ProjectName}${TimeStamp}.zip" />
    <delete file="${ZipFileName}" if="${file::exists(ZipFileName)}" />
  </target>
</project></code>
