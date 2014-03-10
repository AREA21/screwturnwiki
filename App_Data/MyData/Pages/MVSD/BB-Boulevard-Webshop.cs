BB-Boulevard Webshop
devid|2010/03/23 10:08:41
##PAGE##
{toc}

==Introduction==
BB-Boulevard Webshop runs on a highly customized version of [^http://www.vevocart.com|VevoCart]

==VevoCart Version==
2.5.0.0 

==Project version==
1.0.0.2

==Modules==
* ShoppingCart

==Customizations==
* Fixed all bugs in v2.5.0.0
* ...

==Webserver1 Folders==
* D:\TestWebsites\BB-Boulevard-Webshop
* D:\WebSites\BB-boulevard\Webshop
* D:\WebSites\BB-boulevard-pointer

==SVN Repository Url==
svn://joshua4/EasyWebEditNET/BB-Boulevard-ShoppingCart/trunk

==Test locations==
* http://test.mvsd.nl/bbb-webshop

==User accounts==
Super Administrator<br/>
admin - l*m11b**k

Administrator<br/>
mineke - l*m11b**k

==Url==
* http://www.bbboulevard.nl/webshop
* http://www.bb-boulevard.nl/webshop
* http://www.baby-boulevard.nl/webshop

==Ogone Settings==
* All values are loaded from the AppSettings section in de Web.config.
* Ogone production account: bbboulevard (check keepass for login data/url)
* Ogone test account: mvsd001 (check keepass for login data/url)

==Notes==
===Note 1. Database===
In the product-table, the column RetailPrice is used to store the DiscountPrice.

===Note 2. Languages===
The labels (buttontext/descriptions/messagetext/etc.) are partly retrieved from the database and partly from the language-files.

===Note 3. Adding a new admin user===
* Log in with the SuperAdministrator account
* Navigate to page "Admin Users"
* Specify a name and password and give access to the following items '''ONLY''':
** Categorieën
** Produkten
** Produkt Opties
** Produkten Bewerken
** Orders
** Klanten
** Produkt Zoek Instellingen
** Produkten Importeren
** Pagina's

===Note 4. Editing Company Name-Address-E-mailaddress/SMTP Server-Port/SuperAdministrator Password===
* Log in with the SuperAdministrator account
* Navigate to "Website Setup" or "Website Configuration"
* '''Editing other values/items than the ones stated below can or will result in webshop operation failures.'''
** Company Name
** Company Address
** Company E-mailaddress
** SMTP ServerPort
** SMTP Port
** SuperAdministrator Password
