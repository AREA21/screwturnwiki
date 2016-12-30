JavaScript (JS)
procm|2016/11/21 14:27:22
##PAGE##
{TOC}

=== '''J'''ava'''S'''cript===
<PRE>
* Douglas Crockford:
** [http://javascript.crockford.com/survey.html|JavaScript Programming Language]
** [http://javascript.crockford.com/code.html|JavaScript Code Conventions]
** [https://www.youtube.com/watch?v=taaEzHI9xyY|Crockford on JavaScript - Section 8: Programming Style & Your Brain]

</PRE>{TOP}

==== Angular (Niels Gerritsen)====
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
{TOP}
