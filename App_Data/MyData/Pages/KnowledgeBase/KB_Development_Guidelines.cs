KB Development Guidelines 
procm|2014/02/11 16:53:00|(((KB,kennis,knowledge)))(((Knowledge Base)))
##PAGE##
{TOC}

==Model View Controller==

===Resources===
<PRE>
* '''M'''odel '''V'''iew '''C'''ontroller 3
  [http://www.asp.net/mvc/mvc3|MVC]
  [http://www.matlus.com/asp-net-mvc3-razor-view-engine/|Razor ViewEngine]
  [http://www.hanselman.com/blog/LinkRollupNewDocumentationAndTutorialsFromWebPlatformAndTools.aspx|Link Rollup: New Documentation & Tutorials, Web Platform and Tools]

* '''Security'''
  [http://www.britishdeveloper.co.uk/2010/08/hide-http-headers-server-x-powered-by.html|Hide http-headers-server-x-powered-by]
  [http://dotnetslackers.com/articles/aspnet/Protect-ASP-NET-MVC-3-Applications-Using-AntiForgery-Helpers.aspx|MVC Using AntiForgery Helpers in Forms]
** iFrames
    [https://www.tinfoilsecurity.com/blog/protect-your-website-from-embedded-content-iframe-security|Protect Your Website From Iframes]
    [http://security.stackexchange.com/questions/17412/how-to-protect-against-clickjacking-attack-but-allow-legit-iframes|How to protect against clickjacking attack but allow legit iframes?]

* '''Troubleshooting'''
  [http://stackoverflow.com/questions/4136703/razor-mvc-3-rc-htmlhelper-extensions-not-found|Globally defining namespace '''imports''' for Views]
</PRE>


==Microsoft ASP.NET==

===Aspx pages (presentation layer)===
* Make sure that the '''file names''' of the web pages are consistent.

* --Always use '''C#''' as the programming language.--

*'''Don't repeat layout''' in different web pages. Store all shared layout in the master page.

*'''Use panels''' or '''&LT;div&GT;''' to cluster the web controls that should be treated as one section on the page.

* Only use ASP.NET '''web controls''' for all page elements that will be dynamically controlled through code. (However, it is better to use &LT;table&GT; instead of &LT;asp:Table&GT; when creating static layouts because &LT;asp:Table&GT; creates problems in two-way binding scenario's.)

* Apply ID="name" runat="server" to create '''programmable HTML controls''' when you want to manipulate them from the code-behind file. For example: hide/show html elements depending on form values.

* Apply '''neutral names''' to web controls that might be copied often to other pages, like TheForm instead of OrderForm and TheData instead of CustomerDataSource. For web controls names that cannot be neutral you should use a '''consistent naming scheme'''

* Apply '''consistent formating''' on the attributes of web controls. This enables you to quickly evaluate differences between attributes values. For example: make sure that the '''horizontal alignment''' of columns in GridViews is the same in headers, items en footers.

* Use FormViews only in '''Edit Mode'''. (Using other modes requires duplication of aspx code, which is undesirable.)

* '''Use skins''' or '''style classes''' to define the layout of all web controls.

* Try to position pages elements using only '''relative positioning'''. Don't use absolute positioning when this is not essential.

* Add client-side '''confirmation popups''' to all buttons that, when clicked by accident, would cause problems to the user. Use the OnClientClick property for this.

* Make sure that the '''page title''' is defined in the &LT;title&GT; tag.

* Check the number of cells and the '''colspan''' attributes in all table rows. The number of columns in a table should be the same in each row.

* Create '''user controls''' for distinct sections of a page that can easily be isolated and might be repeated over different pages. (You may also wish to do this with large pages, to make them more readable.) Place the user controls in theis own separate folder called ''controls''. Note: communication between the user controls and the web page will have to take place using, for example, the PageVariable class.

* Set the '''MaxLength''' property of each TexBox, either directly or via its skin. (this is especial relevant for integer values that are edited in textboxes.)

* Make sure that the code is properly '''indented'''.

* Place all '''non-visual controls''' (like datasource controls) at the bottom of the page.

* Use '''validation controls''' to check user input on the client, whenever possible. You need ''two'' validation controls if a field in not only required but also requires a certain format. You should also assign '''validation groups''' if there are different sections in the user interface(like an ''edit'' row & an ''insert'' row in the same form.)

* Check the '''CausesValidation''' property of all buttons, and maken sure that it is set to False where needed.

* Use '''Eval()''' and '''Bind()''' for binding controls to datasource objects. Note: using Bind() is preferred over manually copying web control values to parameters in the code-behind file. Use event handlers in the code-behind file only to handle special situations.

* Use '''command names''' (and optionally command arguments) for all buttons inside GridViews & FormViews.

* Do not use '''default dropdownlist items''' (with AppendDataBoundItems="false") on dropdownlist that will be bound to their datasource more than once.

*'''Format dates & times''' explicitly. Do not rely on the server settings, unless you are sure the server settings will match the formats that are needed in the application.

*'''Do not use querystring parameters''' as input parameters in datasources. Use hidden fields that you can set & manipulate from the code-behind file.

* Check all static texts(labels, tooltips, column headers, buttons, etc...) for correct '''spelling''', or else the texts should be configurable as '''content items'''.

* Check that each graphic element has an '''alternative text'''.

* Set the '''default width''' of tables to width="100%" to maken sure that they always fill the containers they are placed in.

* Use '''zero-width borders''' (border="0" cellpadding="0") on tables when they are used for positioning web controls in a grid layout.

* Perform '''paging in the database''' when you are working with large datasets.

* Do not set '''EnableViewState''' to False on a web control, unless you are absolutely sure that it is needed, or that it will significantly boost the performance of the page and will do no harm to the web control. 

*'''Enable/disable buttons''' and input controls on the page depending on the state of the data or on '''user authorization'''.

* Check the page for '''HTML''' & '''CSS''' correcteness and compatibility. 

{TOP}

===Code-Behind classes===
* Always '''use querystrings''' to pass information from other pages, when you want to set the page into a certain state, or bind it to certain data. (Never use Session state!). This enables users, email messages and other applications to use hyperlinks to jump directly to specific pages in the application. Always try to use '''neutral query parameter names'''.

* Try to use the aspx file to '''initialize web controls attributes'''.

*'''Don't repeat methods''' in different web pages. Store all shared code in the-behind files of the master page.

* All '''business logic exceptions''' should be caught and displayed to the user in a friendly way. This applies both to explicit calls and implicit call into the business layer through DataSource objects. (Use __BeautifyExceptionMessage__ to make database error more readable.)

* Catching errors also applies to '''page logic exceptions''' in the other page events.<br/>And in this latter case, '''error logging''' should take place.

* Place the event handlers in the order that they are fired.

* --Never do a '''Response.Redirect''' directly from an event handler. You should set a variable that is checked in the Page.PreRender event. Use __GoToNextPage__ to navigate to another page. Make sure that the intended current URL(which may not be the actual URL) is stored in session state.--

*'''Restore form values''' when the business layer throws an exception. Use __RestoreFormValues__ to set form values back to their submitted value.

* Give '''update feedback''' when an insert, update or delete has succeeded, by presenting the new data to the user, (You can bind the FormView to the new record ID, which is returned from the business layer, or you can switch to a GridView that fetches the new data from the database.)

* Never navigate to a specific page using a '''"back" button'''. Give the button another name so that the user perceives it as forward navigation--, or else use __ReturnToPreviousPage__ to the previous page(which should be stored in a session variable using __GoToNextPage__).--

* Try using '''type-safe''' code when working with entities and typed list.

*'''Validate the page''' before inserting and updating data in the database. Take validation groups into account, if needed.

* Make sure that '''rendering changes'''(like setting controls to invisible or read-only) are performed in the PreRender event of the control itself, or its container. Do not change these properties in other events, like button clicks, because these are fired too early. Likewise, you should not use Page_PreRender event applying changes to controls in GridViews and FormViews.

* Make sure that '''event handler names''' correspond to the controls and events that they are handeling.

* There should be comments to explain code, but only in places where an explanation is needed. For the most part, the code should be clear enough to explain itself.

* Do not use '''Session''' variables when it's not really needed. And if you do, clean them up as soon as possible. Keep the scope of session variables to a single page.<br/>Never use session variables to pass information from one page to another.

* One good reason to use session variables is for '''storing page state''' before living a page, so that the page can be restored to its previous state when the user returns.<br/>Create '''unique session variables''' by prefixing the variable names with the name of the page.

* Temporarily '''assign result set to page-level variables''' when you retrieve them from the business layer in the Selected event of a DataSource object. This way you are able to use the data later in other expressions, like in PreRendering events.

* For all other requirements: see the checklist for C# code.

{TOP}

===Business classes===

* Put each class inside a '''namespace'''.

* Assign '''default values''' new records that are created and supplied to the web pages.

* Perform '''paging in the database''' when you are working with large datasets.

* Keep an '''open connection''' when you fetch or store information multiple times inside one method. Use a Try...Finally construct to ensure that the connection will be closed.

* Use a '''transaction''' when you perform multiple inserts, updates and/or deletes inside one method. Use a Try...Finally construct to ensure that the transation will be closed.

*'''Throw an exception''' when any method is unable to complete its instructions, like saving an entity to the database or fetching a record with specific ID number.

*'''Correct input values'''(for example: using trimming, changing the case and/or removing extra characters) to make sure that the database will accept the data.

* Make sure that the '''correctness of values''' is checked before they are saved to the database(in Update & Insert methods).

* Update the '''created, modified and user fields''', if they are available.

* Protect the data against invalid updates & deletes by performing '''concurrency checks'''.(An easy way to do this is to generate random numbers & save them in an int column in the database.)

* Always '''return the ID''' of the data you have been inserting, updating or deleting.

* Catch and re-throw all exceptions, while logging the errors to the '''error log'''.

* Check for '''user authorization''' at the beginning of each method, where needed.

* There should be '''comments''' to explain the code, but only in places where an explanation is needed. For the most the most part, the code should be clear enough to explain itself.

* Be sure that the methods in the business class form a '''consistent set'''. They should all deal with just one part of the database(often exactly one table).

* For all other requirements: see the checklist for C# code.

{TOP}


===Master Pages===
* Always use '''C#''' as the programming language

* Always use '''master pages''' to share layout and code among web pages. Even when you don't think you're going to use master pages for sharing layout, you could still use them to share code.

* Consider distinguishing different '''page types''', like overview pages and detail pages, and make master pages for them, zo that you can share layout and code amoung the pages of the same page type. (Note: web controls cannot refer to other webcontrols when they reside in different content controls. This means that visual controls must be put together with their datasource objects inside the same content controls.

* Place all master pages together in a subfolder called masters.

* Use the '''meta tags:''' http-equiv="Page-Enter" & http-equiv="Page-Exit" to supress the flickering of page transitions. (These meta tags are supported by Internet Explorer & Firefox)

* Try to put all '''shared page elements''', like menu panels, page headers and page footers, in the master page.

* Consider placing an '''error panel''' in the master page, so that there is a consistent way of showing error messages.

* Consider placing an '''feedback panel''' in the master page, so that there is a consistent way of showing normal feedback messages.

* Consider placing a '''validation summary''' in the master page, so that there is a consistent way of showing validation messages.(You may need to use multiple validation summaries when there are multiple validation groups).

* For all other requirements: see the checklist for aspx pages.

{TOP}

===Themes/skins===
* Always try to '''use skins''' to share styles & settings among web controls.

* Always '''use a SkinID''' to distinguish between different standard versions of the web controls.

* Use skins to assign values to the '''CssClass''' properties of the web controls.

{TOP}

===Web.config===
* Set maintainScrollPositionOnPostBack to true in the &LT;pages&GT; section

* Specify the theme in the &LT;pages&GT; section

* Specify the typed lists namespace from the Business Layer in the &LT;namespaces&GT; section

{TOP}




== Code Analysis==
<PRE>
 [http://msdn.microsoft.com/en-us/library/bb429476(VS.80).aspx|Microsoft '''FxCop''']
 [http://code.msdn.microsoft.com/sourceanalysis|Microsoft '''StyleCop'''(C# source code)]
</PRE>