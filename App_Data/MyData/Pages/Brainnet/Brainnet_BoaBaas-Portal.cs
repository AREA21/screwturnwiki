Brainnet BoaBaas
celio|2012/05/09 16:09:41
##PAGE##
=== Terminology===
<PRE>
summary: Terminology-Jargon-Taxonomy

* '''BVK''' - Beroepsvereniging van het Kredit
* '''VOG''' - Verklaring Omtrent Gedrag
* '''VAR''' - Verklaring Ardbeids Relatie
* '''VAR-WUO''' - VAR Winst Uit Onderneming
* '''DVO''' - Dienst Verlenings Overeenkomst
</PRE>

=== Third party components===
<PRE>
* [http://www.syncfusion.com/products/reporting-edition|'''Syncfusion''']
** Syncfusion essential DocIO is a .NET library that can read, write and modify Microsoft Word files. It features a full-fledged object
 model similar to the Microsoft Office Automation libraries. It can be used on systems that do not have Microsoft Word installed. 
** Enables users to create richly formatted Microsoft Word reports in Windows Forms, ASP.NET, WPF, ASP.NET MVC and Silverlight
 applications.

* [http://www.aspose.com/documentation/.net-components/aspose.network-for-.net/creatingsaving-outlook-message-msg-files.html|'''Aspose''']
** Aspose.Network also supports creating an outlook message (msg) files. The MailMessage class has the Save() method that can
 save the outlook msg file to disk or stream.

{TOP}
</PRE>

=== Portal===
<PRE>
Note: actively in development...
* make dates interchangeable, [http://msdn.microsoft.com/en-us/library/bb299886.aspx#intro_to_json_sidebarb|ASP.NET AJAX: Inside JSON date and time string] 
** javascript libraries: [http://code.google.com/p/datejs/|datejs] & [http://dojotoolkit.org/reference-guide/dojo/date.html|dojo.date]
*** Solution: [...\Brainnet.Portal\Scripts\Portal\Extensions\date.js] '''toISOString''' 
* replace inline '''CSS''' styles 
* --use MVC '''_Layout''' page to share code, scripts-- 
** (actionResult)'''PanelResult''' replaced with standaard '''MVC''' (done! Sander Meester & Celio Moreira)
* exclude '''Session'''(not thread-safe) usage in favor of MVC3 best practice: Action Filters?
</PRE>

=== Envolved Technologies===
<PRE>
* '''Visual C# CSharp'''
** [http://msdn.microsoft.com/en-us/library/67ef8sbd.aspx|Csharp Programming Guide]
** [http://archive.msdn.microsoft.com/cs2010samples|Csharp Samples]
** [http://en.wikipedia.org/wiki/C_Sharp_4.0|Csharp4 (wikipedia)]
** [http://www.hanselman.com/blog/C4AndTheDynamicKeywordWhirlwindTourAroundNET4AndVisualStudio2010Beta1.aspx|Csharp 4 '''D'''ynamic '''L'''anguage '''R'''untime]
* '''Core & other stuff'''
** [http://msdn.microsoft.com/en-us/vcsharp/hh124568|Introduction to Nullables (Bill Wagner)]
** [http://msdn.microsoft.com/en-us/library/ms173105.aspx|Casting & Type Conversions (C#) Programming Guide]
** [http://msdn.microsoft.com/en-us/library/yz2be5wk.aspx|Boxing & unBoxing]
((('''summary''': enables a unified view of the type system wherein a value of any type can ultimately be treated as an object. 
Converting a value type to reference type is called Boxing. Unboxing is the opposite operation and is an explicit operation.
)))
* '''MVC3''' Razor syntax
** [http://www.4guysfromrolla.com/articles/112410-1.aspx|Updating My Online Boggle Solver Using jQuery Templates and WCF]

* '''Visual Studio 2010'''
** [http://weblogs.asp.net/scottgu/archive/2010/07/19/vs-2010-productivity-power-tools-update-with-some-cool-new-features.aspx|Powertools some cool new features]
** [http://irwinj.blogspot.com/2010/07/vs2010-power-tools-extensions-are.html|Power Tools Extensions are AWESOME]
** '''Debug'''
*** [http://msdn.microsoft.com/en-us/windows/hardware/gg463028.aspx|Download Windows Symbol Packages]
*** [http://www.simple-talk.com/dotnet/.net-tools/hosting-.net-reflector-in-your-own-application/|Hosting '''.Net Reflector''' in your own Application]

* '''LINQ''' 
** [http://msdn.microsoft.com/en-us/netframework/aa904594.aspx|Official website Microsoft LINQ-project]
** [http://blogs.msdn.com/b/charlie/archive/2006/10/05/links-to-linq.aspx|List with LINQ-providers]
** [http://blogs.msdn.com/b/vbteam/archive/2007/08/29/implementing-dynamic-searching-using-linq.aspx|Implementing Dynamic Searching using LINQ]
** [http://linqpad.net/|'''LINQPad''', interactively query databases in a modern query language: LINQ. Replaces SQL Management Studio]
** Lambda (expressions)
** Generics  
*** Type Inference
** Anonymous Types
** Expression Trees(Object Graph?)

* '''E'''ntity '''F'''ramework (POCO & T4)
* '''POCO''' (Plain Old CLR Object)
** [http://msdn.microsoft.com/en-us/library/dd456853(VS.100).aspx|Working with POCO Entities]
** [http://blogs.msdn.com/b/adonet/archive/2009/05/21/poco-in-the-entity-framework-part-1-the-experience.aspx|POCO in the Entity Framework: Part 1 - The Experience]
** [http://blogs.msdn.com/b/adonet/archive/2009/05/28/poco-in-the-entity-framework-part-2-complex-types-deferred-loading-and-explicit-loading.aspx|POCO in the Entity Framework : Part 2 – Complex Types, Deferred Loading and Explicit Loading]
* '''T4'''('''T'''ext '''T'''emplate '''T'''ransformation '''T'''oolkit)
** [http://www.olegsych.com/2007/12/text-template-transformation-toolkit/|Text Template Transformation Toolkit]
** [http://blogs.msdn.com/b/adonet/archive/2009/05/19/sneak-peek-using-code-generation-templates-with-the-entity-framework-4-0.aspx|Sneak Peek – Using Code Generation Templates with the Entity Framework 4.0]

* '''jQuery'''
** [http://www.filamentgroup.com/portfolio/jquery_ui_and_themeroller/|jQuery UI & Themeroller]

* '''JSON'''(JavaScript Object Notation) 

* '''Other''''s
** [++KnowledgeBase.DotNET-Chart-Controls|'''Charts''', data visualization]

{TOP}
</PRE>