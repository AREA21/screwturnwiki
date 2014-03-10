Building And Publishing Projects
devid|2010/03/17 15:24:43
##PAGE##
{TOC}

==Introduction==
Most of the MVSD ASP.NET projects are published by using a build file. Others are published by using the publish function in Visual Studio. Using Visual Studio publish function is concidered a quick and dirty way and isn't a best practice.

====Tips for beginning programmers====
* Carefully read the wiki page describing the build-script.
* Having read the wiki page, carefully read the build-script step by step. Try to understand each step.
** Open the project's solution in Visual Studio and it's folder in Explorer to help better understand the steps.
* Search the internet for more information about build-scripts. (Only after having followed the previous tips).

We are currently building and publishing webapplications using two types of build files.
* [Build-NAnt|Build NAnt] (Run on TESTSERVER)
* [MSBuild|MSBuild] (Run on developers workstation)


==Deciding on which type of build file to use==
====[Build-NAnt|Build NAnt]====
* If the project has a resembling project that uses a NAnt build-script. This makes modifying a NAnt-script a quick and easy task.

====[MSBuild|MSBuild]====
* If the project has an class library which contains [^http://aspalliance.com/726|embedded resources].
* If the project utilizes NHibernate.
* If the project has no resembling projects using a NAnt build-script and writing a new one is to difficult or to time consuming.


==Visit the MSBuild and NAnt pages for more information.==