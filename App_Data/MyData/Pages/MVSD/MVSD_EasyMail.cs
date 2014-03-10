MVSD EasyMail
robvdkamp|2010/03/05 08:58:10
##PAGE##
{TOC}

== Requirements==

=== methods & techniques===
* CSS (.NET Themes/Skins)
* multilanguage (.NET resource files(resx))
* ORM mapper(NHIBERNATE+Spring)
* --breadcrumb (.net sitemap)--
* WebParts (drag&drop layouts)
* MVC (Model View Controller (design pattern) Microsoft framework)

== Project version==
1.0.0.0

== Webserver2 Folder(s)==
D:\Data\Websites\Live\MVSD_EASYMAIL\Website

== SVN Repository Url==
svn://joshua4/MVSD/EasyMail/trunk/

== Database Connectionstrings==
Testserver DEV 192.168.177.17\MSSQL2008_DEV;Initial Catalog=EasyMail;User ID=sa;pwd=!!lam11biek!!;

==Test locations==
(local) [http://ritesh/easymail|http://ritesh/easymail]


==Website URL==
[http://easymail.mvsd.nl|http://easymail.mvsd.nl]


== User accounts==

=== Types===

Three different types of user accounts:
# User with 1 newslettergroup
# User with multiple newslettergroups
# Administrator

Standard user with 1 newslettergroup gets:
* 1 newslettergroup
* 1 css file
* Unlimited number of newsletters
* Unlimited number of newslettersubscribers
* Send unlimited number of newsletters

Additional (paid?) options:
* Multiple CSS files
* Multiple newslettergroups

=== User account options===

{|
! Option !! User with 1 newslettergroup !! User with multiple newslettergroups !! Administrator
|-
| Create newsletters || X || X || X 
|-
|-
| Edit newsletters || X || X || X 
|-
|-
| Delete newsletters || X || X || X 
|-
|-
| Create newsletteritems || X || X || X 
|-
|-
| Edit newsletteritems || X || X || X 
|-
|-
| Upload images (newsletteritem) || X || X || X 
|-
|-
| Sort newsletteritems || X || X || X 
|-
|-
| Delete newsletteritems || X || X || X 
|-
|-
| Send newsletters || X || X || X 
|-
|-
| Test send newsletters || X || X || X 
|-
|-
| Save newsletters || X || X || X 
|-
|-
| Newsletter preview || X || X || X 
|-
|-
| View unsent newsletters || X || X || X 
|-
|-
| View sent newsletters || X || X || X 
|-
|-
| Create subscribers (manually) || X || X || X 
|-
|-
| Import subscribers (.csv file) || X || X || X 
|-
|-
| Edit subscribers || X || X || X 
|-
|-
| Delete subscribers || X || X || X 
|-
|-
| View unsubscribed subscribers || X || X || X 
|-
|-
| Search subscribers || X || X || X 
|-
|-
| Create newslettergroups || - || '''X''' || '''X''' 
|-
|-
| Create user accounts || - || - || '''X''' 
|-
|-
| Edit user accounts || - || - || '''X''' 
|-
|-
| Add css files to user accounts || - || - || '''X''' 
|-
|-
| Access to __all__ useraccounts and pages || - || - || '''X''' 
|-
|}

'''X''' = additional option

== Combine EasyMail with an EWE==
<pre>
KnowledgeBase: [++KnowledgeBase.Combine-an-EasyWebEditNet-website-with-EasyMail|Combine an EasyWebEditNet website with EasyMail]
</pre>

== Bugs==
<pre>
====Browser Compatibility====

IE6:
* --Login.aspx -> textboxen login worden naar de onderkant van de browser gedrukt door een groot blauw vlak--
* --NewsletterSubscriberEdit.aspx -> div van 1px hoog is nu zo'n 10px (lijn tussen textboxen en import)--

IE7:
* --Geen problemen--

IE8:
* --NewsletterEdit.aspx -> als een CSS file een a{ text-decoration: undeline } bevat, dan krijgen de knoppen onderaan de pagina ook een underline--

Firefox:
* --NewsletterEdit.aspx -> knop "Mijn nieuwsbrief is klaar, ik wil hem bewaren" is niet goed (Css foutje?)--
* --NewsletterTestSend.aspx -> knop "Mijn nieuwsbrief is klaar, ik wil hem bewaren" is niet goed--
* --NewNewsletter.aspx -> knop "Gegevens opslaan en nieuwsbrief schrijven" is niet goed--
* --NewsletterEdit.aspx -> de link/url op de knoppen onderaan de pagina loopt door totaan de zijkant van de browser (scrollbar)--

Safari:
* --NewsletterEdit.aspx -> knop "Mijn nieuwsbrief is klaar, ik wil hem bewaren" is niet goed (Css foutje?)--
* --NewsletterTestSend.aspx -> knop "Mijn nieuwsbrief is klaar, ik wil hem bewaren" is niet goed--
* --NewNewsletter.aspx -> knop "Gegevens opslaan en nieuwsbrief schrijven" is niet goed--
* --NewsletterEdit.aspx -> de link/url op de knoppen onderaan de pagina loopt door totaan de zijkant van de browser (scrollbar)--
* --NewsletterEdit.aspx -> als een CSS file een a{ text-decoration: undeline } bevat, dan krijgen de knoppen onderaan de pagina ook een underline--

Chrome:
* --NewsletterEdit.aspx -> als een CSS file een a{ text-decoration:underline } bevat, dan krijgen de knoppen onderaan de pagina ook een underline--
* --NewsletterEdit.aspx -> de link/url op de knoppen onderaan de pagina loopt door totaan de zijkant van de browser (scrollbar)--

Opera:
* --NewsletterEdit.aspx -> als een CSS file een a{ text-decoration:underline } bevat, dan krijgen de knoppen onderaan de pagina ook een underline--

MAC Firefox:
* --Geen problemen--

MAC Safari 2.0 - 2.0.4:
* Asp:Buttons maken geen gebruik van de CSS
</pre>