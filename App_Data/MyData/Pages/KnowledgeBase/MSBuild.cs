MSBuild
devid|2010/03/17 12:47:26
##PAGE##
{TOC}

==Important! Read the page [Building-And-Publishing-Projects|Building And Publishing Projects] first!==

==Introduction==
MSBuild acts on MSBuild project files which have a similar XML syntax to NAnt. Even though the syntax is based upon well-defined XML schema, the fundamental structure and operation is comparable to the traditional Unix make utility: the user specifies what will be used (typically source code files) and what the result should be (typically an application), but the utility itself decides what to do and the order in which to do it.

The MSBuild Community Tasks are used to add more functionality to the build-scripts. The MSBuild Community Tasks Project is an open source project for MSBuild tasks. The goal of the project is to provide a collection of open source tasks for MSBuild. 

The build-script provided on this page is very basic. Unlike the [Build-NAnt|NAnt]-script it doesn't retrieve the project files from the SVN-repository. However, it can be modified to do this.

'''The build-script is executed on the developers workstation containing the webapplication.'''


==Usefull keywords for searching information on the internet==
* MSBuild
* MSBuild Community Tasks
* aspnet_compiler.exe
* aspnet_merge.exe
* csc.exe
* msbuild.exe


==MSBuild keywords==
====Project====
The root node of a build script. Each script has one project.

====Target====
A subdivision of a project. A target is a discrete piece of work that can consist of zero or more tasks. Targets can be dependent on each other. A Target is typically an action executed on a file, set of files or directory.

====Task====
A Task is a command which is executed in order to complete a Target. A Task is typically implemented in a .NET assembly as a class which inherits from the Task class or implements the ITask interface. Many great, ready-to-use Tasks exist, with basic tasks being shipped as part of .NET Framework, and community developed tasks freely available.

====Properties and Items====
In addition the MSBuild provides Properties and Items, which are conceptually equivalent to make's macros. An XML key/value pair that can be used to configure tasks and targets in a more dynamic fashion. Property values can be overridden from the command line. Specifying files on Items is made easy by the support of wildcards.


==Build-script description==
====Running build-script====
The build-script can be started from commandline and has been put in an executable batch-file.
This command consist of the executable MSBuild and two parameters:
* Full path to MSBuild.exe (extension not required).
** C:\Windows\Microsoft.NET\Framework\v3.5\MSBuild 
* 1st parameter: Full path to the build-script
** D:\Projects\EasyShop\Reconstruction-Rotterdam\Build\easyshop.build 
* 2nd parameter: The target to be executed in the build-script. (This target will be the main target that calls the other targets)
** /t:Main 

====Import Targets====
The first thing that needs to be done in the build-script is to import the MSBuild.Community.Tasks.Targets file that defines the available tasks. If you use the msi installer to install the MSBuild Community Tasks, you can use the path "$(MSBuildExtensionsPath)\MSBuildCommunityTasks\MSBuild.Community.Tasks.Targets".  

====PropertyGroup====
Contains a set of user-defined Property elements. Every Property element used in an MSBuild project must be a child of a '''PropertyGroup''' element.

====Target: Main====
* Calls the next target: Clean.

====Target: Clean====
* Removes any existing build output folders and (re)creates them. 
* Calls the next target: Build.

====Target: Build====
* Executes the aspnet_compiler.exe with parameters. This will create the precompiled files needed bij IIS to run the webapplication.
* Calls the next target: Merge.

====Target: Merge====
* Executes the aspnet_merge.exe with parameters. This will cleanup the precompiled files generated in the Build task. This ASP.NET Merge Tool creates a single assembly for just the Web site user interface (UI) elements, such as pages and controls. 
* Calls the next target: DeleteDebugFiles.

====Target: DeleteDebugFiles====
* Deletes all the debug files generated in the Build task.  
* Calls the next target: PrepareDeploymentFiles.

====Target: PrepareDeploymentFiles====
* Moves the web.config and CuteEditor.lic to another folder and removes the uploads folder.
** The tasks in this target aren't required but make deploying a webapplication easier.
* Calls the next target: PrepareDeploymentFiles.

====Target: Package====
* Creates a ZIP-file of the precompiled files and configuration files.


==Example build-script==
====Batch file====
<pre>C:\Windows\Microsoft.NET\Framework\v3.5\MSBuild D:\Projects\EasyShop\Reconstruction-Rotterdam\Build\easyshop.build /t:Main</pre>

====Build-script====
<code xml><?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="3.5" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  
  <Import Project="$(MSBuildExtensionsPath)\MSBuildCommunityTasks\MSBuild.Community.Tasks.Targets"/>

  <PropertyGroup>
    <ProjectName>Reconstruction-Rotterdam</ProjectName>
    <FinalDeployDllName>Mvsd.EasyShop.Web.UI.dll</FinalDeployDllName>
    <DirApplication>D:\Projects\EasyShop\Reconstruction-Rotterdam</DirApplication>

    <DirArchive>$(DirApplication)\Build\Deployment\Archive</DirArchive>
    <DirConfiguration>$(DirApplication)\Build\Deployment\PrecompiledWeb\Configuration</DirConfiguration>
    <DirDeployment>$(DirApplication)\Build\Deployment</DirDeployment>
    <DirExternalBin>$(DirApplication)\ExternalBin</DirExternalBin>
    <DirPrecompiledWeb>$(DirApplication)\Build\Deployment\PrecompiledWeb</DirPrecompiledWeb>

    <DotNetFrameworkDir>C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727</DotNetFrameworkDir>
  </PropertyGroup>

  <Target Name="Main">
    <CallTarget Targets="Clean" />
  </Target>

  <Target Name="Clean">
    <RemoveDir Directories="$(DirArchive)" Condition="Exists($(DirArchive))"/>
    <RemoveDir Directories="$(DirConfiguration)" Condition="Exists($(DirConfiguration))"/>
    <RemoveDir Directories="$(DirPrecompiledWeb)" Condition="Exists($(DirPrecompiledWeb))"/>
    <MakeDir Directories="$(DirArchive)" Condition="!Exists($(DirArchive))"/>
    <MakeDir Directories="$(DirConfiguration)" Condition="!Exists($(DirConfiguration))"/>
    <MakeDir Directories="$(DirPrecompiledWeb)" Condition="!Exists($(DirPrecompiledWeb))"/>
    <CallTarget Targets="Build" />
  </Target>

  <Target Name="Build">
    <Exec Command="$(DotNetFrameworkDir)\aspnet_compiler.exe -nologo -v website -p $(DirApplication)\Website $(DirPrecompiledWeb)\Website" />
    <CallTarget Targets="Merge" />
  </Target>

  <Target Name="Merge">
    <Exec Command="D:\MSBuild\aspnet_merge.exe $(DirPrecompiledWeb)\Website -o $(FinalDeployDllName) -xmldocs -copyattrs " />
    <CallTarget Targets="DeleteDebugFiles" />
  </Target>

  <Target Name="DeleteDebugFiles">
    <ItemGroup>
      <DebugFilesToDelete Include="$(DirPrecompiledWeb)\Website\bin\*Test*.dll"/>
      <DebugFilesToDelete Include="$(DirPrecompiledWeb)\Website\bin\**\*.pdb"/>
      <DebugFilesToDelete Include="$(DirPrecompiledWeb)\Website\bin\*.xml"/>
    </ItemGroup>
    <Delete Files="@(DebugFilesToDelete)" ContinueOnError="false"/>
    <CallTarget Targets="PrepareDeploymentFiles" />
  </Target>
  
  <Target Name="PrepareDeploymentFiles">
    <Move SourceFiles="$(DirPrecompiledWeb)\Website\Web.Config" DestinationFiles="$(DirConfiguration)\Web.Config" />
    <Copy SourceFiles="$(DirExternalBin)\CuteEditor.lic" DestinationFiles="$(DirPrecompiledWeb)\Website\bin\CuteEditor.lic" />
    <RemoveDir Directories="$(DirPrecompiledWeb)\Website\UserUploads"/>
    <CallTarget Targets="Package" />
  </Target>

  <Target Name="Package">
    <ItemGroup>
      <ZipFiles Include="$(DirPrecompiledWeb)\**\*.*" />
    </ItemGroup>
    <Zip Files="@(ZipFiles)"
         WorkingDirectory="$(DirDeployment)"
         ZipFileName="$(DirArchive)\$(ProjectName)-Deployment.zip"/>
    <Message Text="$(DirArchive)\$(ProjectName)-Deployment.zip"/>
  </Target>

</Project></code>