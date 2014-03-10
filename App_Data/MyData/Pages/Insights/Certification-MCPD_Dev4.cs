Microsoft Certified Professional Developer- MCPD .NET 4
procm|2014/02/20 11:56:29
##PAGE##
{TOC}
== '''70-486'''- Developing ASP.NET MVC 4 Web Applications==
<PRE>
'''Cursus avond (18/02/2014)'''
Trainer: Xander Wemmers <info@xanderwemmers.nl>

URL    : https://labs3.virsoft.net/computrain/20486/Default.asp
user   : jursley.koots@ict.nl
passw. : Student2
 

'''Resources''':
[http://asp.net/mvc|ASP.NET MVC, points to Pluralsight videos]
[http://pluralsight.com|] 
[http://www.microsoft.com/learning/en-us/exam-70-486.aspx|Requirements for Exam 70-486]
[http://microsoftvirtualacademy.com|Virtual Academy Online Resources]
[http://msftdbprodsamples.codeplex.com/releases/view/93587|Download MS Demo Database'''AdventureWorks'''(also old versions)]

'''Exams''':
[http://www.aiotestking.com|Braindumps(not official!)]
</PRE>

== '''70-515(TS)'''- Web Application Development with .NET 4.0==

=== C# Csharp===
<PRE>
resource: 4995A DeliveryGuide, Programming with the Microsoft.NET Framework

* Access levels (Scope):
** public, accessible by any code in the application
** private, accessible by code in the contained class
** internal, accessible by the current assembly
** protected, accessible by code in the containing class and in derived classes
** protected internal, accessible by the code in the current assembly and in derived classes

* default access levels when access modifier is not specified
** class - internal
** member(within a class definition)- private

* virtual (base class)- define an overridable member
* override (derived class)- to achieve overriding 
* abstract (methods & properties)- must inherit
* abstract (class) - to require Inheritance
* abstract(interfaces) - to use when a class implementing an interface does not implements all the members 
* sealed (class)- prevents inheritance

* Advanced OOP:
** Delegates- is a reference to a method in an object or class 
** hiding (p.229)- to indicate that a derived class member hides base class members in Visual C#, annotate the derived class member with
 the '''new''' keyword.
** Constructors with inheritance (p.233)- implicitly derived classes do not inherit '''Base''' class constructors

eg.:
{@code-csharp: 
 public class BankAccount
 {
  private string _name;
  private decimal _balance;
  
  public BankAccount(string name)
  {
   _name = name;
   _balance = 0;
  }
 }

 public class SavingsAccount : BankAccount
 {
  private decimal _minimumBalance;
  public SavingsAccount(string name, decimal minimum) : base(name)
  {
   _minimumBalance = minimum;
  }
 }
@}
{TOP}
</PRE>

=== .NET 4.0 changes===
<PRE>
* simpler definition of Properties Get/Set accessors
* Annotating a class with Attributes @@[name-of-attribute(attribute-parameters)] eg.: [SerializableAttribute()] or [Serializable]@@
* possible to use Optional parameters in methods before only achievable using overloads

{TOP}
</PRE>

=== JQuery===
<PRE> 
'''Shortcut character'''
* Invoke the jQuery API using '''$''' character 

'''Return control of $ back to the other library'''
* jQuery.noConflict()

'''jQuery Selector syntax''' [http://api.jquery.com/category/selectors/]
{@code-jscript:
// multiple ways to select DOM elements

//selecting by element '''Tag'''
$("body").css("background-color", "yellow"); 

// selecting by element '''ID''' 
$("#display").css("background-color", "yellow");

// selecting by CSS class
$(".divBlue").css("background-color", "yellow");
@}

'''Events''', jQuery provides an easy way to trigger and handle events from the DOM elements. 
{@code-jscript:
 <input type="button" id="btn1" value="Greetings" />
 <script language="JavaScript" type="text/JavaScript">
  $(document).ready(function () {
   $("#btn1").click(function(){
     alert("Hello World!");
    });
  });
 </script>
@}
{TOP}
</PRE>

=== Patterns===
(((
The''' Active Record Pattern''' represents a software engineering pattern where the columns of the data source are mapped into the fields of the 
model object and the table is mapped into a model class. Almost all object-relational mapping tools, including LINQ to SQL and the Entity Framework, 
use the active record pattern behind the scenes. If you are building an object-relational mapping tool, you should learn the active record pattern.

The '''Data Mapper Pattern''' is a software design pattern that allows the separation of concerns. The main task of Data Mapper Pattern is to 
communicate with the database and perform actions on the objects by persisting them to a permanent medium.

Although there are many different ways of fetching the data from the database, the '''Repository pattern''' is considered the standard when accessing data. 
The primary responsibility of the repository pattern is to fetch and persist the information to the database, but it must only fetch the information if it 
is not available in the cache. If the item is found in the cache, then it is returned from there. Otherwise, it is fetched directly from the database.
)))

=== '''Notes''', taken during Exam training===
§§(celio,2011/09/28 05:36:49)§§

==== '''Caching'''====
<PRE>
'''Application'''/Data caching
 Define a cache dependency using an {DateTime}AbsoluteExpiration or {TimeSpan}SlidingExpiration.
 Difference(s) between '''Add''' & '''Insert''' methods- insert replaces an item in the cache if that item already exists.
  Note: We can't specify both an '''absolute''' & a '''sliding''' expiration.

'''Page Output''' caching
* Defining it declaratively
** @OutputCache:
*** VaryByParam
*** VaryByControl 
* Programmatically
** Response object
</PRE>

==== '''Class Attributes''' (annotations)====
<PRE>
<nowiki>[ToolBoxData]</nowiki> allows to define the markup that should be added when a Developer drags the control to 
  the Webform from the toolbox.

<nowiki>[DefaultProperty]</nowiki> is a class-scoped attribute thus it cannot be applied to a property.

<nowiki>[ScriptService]</nowiki> attribute marks the class as one that is accessible by ASP.NET Ajax client script. ASP.NET uses this 
   attribute to dynamically generate Javascript code that serves as a proxy for the webservice. 
 If the __webservice is available__ eg.: '''http://www.bcdtrain.com/creditreportservice.asmx''' then we can access the
   Javascript implementation using for eg.: '''http://www.bcdtrain.com/creditreportservice.asmx/js'''.

<nowiki>WebService</nowiki> attribute is optional, it allows you to specify the XML namespace & a description for the WebService.

</PRE>

==== '''Methods Attributes''' (annotations)====
<PRE>
<nowiki>[ScriptMethod]</nowiki> allows you to specify the response format of a method that is invoked by client script. 
  Possible formats include '''XML''' & '''JSON'''.

<nowiki>[WebMethod]</nowiki> must be applied to methods that serve as WebMethods.

</PRE>

==== '''XML serialization'''====
<PRE>
 XMLElement we can use it to override the standard behavior & explicitly specify an element name.

</PRE>

==== '''LINQ to SQL'''====
<PRE>
When using Linq to SQL we add a record to the database by performing the following tasks:
# '''instantiate''' the Data Context
# '''create an instance''' of the Entity to Add
# '''call the InsertOnSubmit()''' method on the Table<TEntity> object
# '''call the SubmitChanges()''' method on the DataContext object

'''Attach()''' method is used when we have serialized the Data & need to __attach a disconnected Entity__ to a DataContext object.
</PRE>

==== '''Ajax client-side Scripting'''====
<PRE>
We can add Ajax client-side script to an existing ASP.NET server control by performing the following tasks:
# create an '''Extender class''' that inherits from ExtenderControl
# use '''markup to associate''' to an instance of the Extender class with the control
# create a '''Javascript file''' that inherits behavior & implements the required functionality 
# '''register the behavior'''

'''IScriptControl''' we can implement this to '''add''' Ajax capabilities to a custom control. To associate a behavior with
a control we must use an '''Extender''' class.
{@code-csharp:
<nowiki>[TargetControlType(typeof(TextBox))]</nowiki>
public class CharCountChecker: IScriptControl
{
 // this is an example
} 
@}
</PRE>

==== '''Implementing client-side Scripting & Ajax'''====
<PRE>
'''ResponseText''' property is used to retrieve the response of a synchronous query.
By default, the Ajax function issues an asynchronous query. Thefore we should include a '''CallBack''' function if we
need to process the response.
eg.
{@code-jscript:
var word=$("#txtword").val();
$.getJSON("http://fi-print.com/wordfacts.php", 
          word, 
          function(data){
            $("#synonyms").html("<ul>");
            $.each(data.synonyms, 
               function(i, synonym)
               {
                 $("#synonyms").append("<li>" + synonym + "</li>");
               }
            );
            $("#synonyms").append("</ul>");
          }
);
@}
</PRE>

==== '''Developing Webforms pages'''====
<PRE>
===== '''Page Life-Cycle'''=====
  Note: individual ASP.NET server controls have their own Life-Cycle that is similar to the page one.
* '''PreInit'''
** check: IsPostback/IsCallBack & IsCrossPagePostBack
** Create: or Recreate dynamic controls 
** Set a '''Master page''' or '''Theme property''' dynamically 
** Dynamically create controls for a page without a Master page.
* '''Init'''
** dynamically add controls to a content page. (also possible in the InitComplete stage)
** raised after all controls have been initialized & any skin settings have being applied. The init event of individual controls 
occours before the pageinit.
* '''InitComplete'''
** check if '''ViewState''' changes is turned ON. If so persist any values that are programmatically added to the ViewState 
collection & so are this values maintained accross PostBacks.
* '''PreLoad'''
** fires before ViewState has been loaded(controls & page) & before PostBack processing.
** raised after the page loads ViewState for itself & all Controls, and after it processes PostBack data that is included 
with the Request instance/object.
* '''Load'''
** checks for PostBack & then Sets control properties appropriatelly.
** page Load event is called first then the Load event for each child control is called in turn.
* '''Control Events'''... 
* '''LoadComplete'''
** here are all controls loaded.
* '''PreRender'''
** use this event to make final changes to the contents of the page or its controls before the rendering stage begins.
** happens after all regular PostBacks events have taken place.
** this event takes place before ViewState is saved.
* '''PreRenderComplete'''
* '''SaveStateComplete'''
** useful if we need to write processing that requires the ViewState to be set.
* '''Render'''
** useful in the case we are writting our own custom control. We override this method to be able to control the output for
 the desired control.
* '''Unload'''
** raised for each control & then for the page.

----
</PRE>

== '''70-516(TS)'''- Accessing Data with .NET 4.0==

== '''70-513(TS)'''- WCF development with .NET 4.0==
((( WCF - Windows Communication Foundation )))

== Selection of Learned techniques== 
<PRE>
* MVC Strong-Typed Views
* ASP.NET Dynamic Data
* MVC Model Data Validation
* IIS SEO Toolkit / Webmatrix SEO analysis
* MVC View Templates with Data Scaffolding
* WebForms Implicit localization 
** &lt;asp:Button ID="btnCategory" runat="server" Text="Submit" meta:resourcekey="btnCategoryResource1"&gt; 
* Using SQLServer mode to Store Session State
** session values are serialized & stored in a Microsoft SQL Server table. The instance of SQL Server can run either locally or remotely.
* Debugging 
** Debugging is the process of observing the run-time behavior of your application and then locating and fixing logic errors.
* Refactoring is the process of changing code to improve its structure & readability, without affecting syntax, using Refactoring commands.
</PRE>

== HowTo's==
<PRE>
=== Reduce HTTP GET's eliminating unnecessary View engines===
{@code-csharp:
protected void ApplicationStart()
{
   // add the following 2x lines somewhere in this method
   ViewEngines.Engines.Clear();
   ViewEngines.Engines.Add(new RazorViewEngine());
}
@}
=== Edit project files within Visual Studio & compile MVC Views(Aspx or Razor)===
# Right-click the MVC project and select “Unload”
# Right-click the unloaded project and select “Edit”
# Locate the <MvcBuildViews> element and set its value to “true”.
# Save the file, then right-click the unloaded project and reload.

{TOP}
</PRE>