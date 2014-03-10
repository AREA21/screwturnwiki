HUTAC
devid|2010/03/23 09:54:20
##PAGE##
{TOC}

==CodeBase EasyWebEdit version==
3.0.0.0 

==Project version==
1.0.0.0

==Modules==
* CMSPage
* Activities
* Newsletters
* Members

==Webserver2 Folders==
* D:\Data\Websites\Dev\hutac
* D:\Data\Websites\Test\hutac
* D:\Data\Websites\Live\hutac

==SVN Repository Url==
svn://joshua4/EasyWebEditNet/Hutac/trunk/

==Database Connectionstrings==
* Testserver Server=192.168.177.17\MSSQL2008_DEV;Initial Catalog=Hutac;User ID=sa;pwd=!!lam11biek!!;
* Webserver2 DEV Server=WEBSERVER2\MSSQL2008_TEST;Initial Catalog=DEV_Hutac;User ID=sa;pwd=!!lam11biek!!;
* Webserver2 TEST Server=WEBSERVER2\MSSQL2008_LIVE;Initial Catalog=Hutac;User ID=sa;pwd=!!lam11biek!!;
* Webserver2 LIVE Server=WEBSERVER2\MSSQL2008_LIVE;Initial Catalog=Hutac;User ID=sa;pwd=!!lam11biek!!;

==Test locations==
* http://dev.mvsd.nl/hutac
* http://test3.mvsd.nl/hutac

==Url==
* http://www.hutac.com

===Backend Login===
Username : mineke@mvsd.nl<br>
Loginname: lam11biek

==Customizations==
===User Permissions===
{|
! Action !! Public !! Standard !! Premium !! Sponsor !! Administrator 
|-
| View web pages || X || X || X || X || X 
|-
| Shortened Information activities || X || X || X || X || X 
|-
| Full information activities ||   || X || X || X || X 
|-
| Subscribe to activities ||   ||   || X ||   || X 
|-
| View boardmeeting information ||   ||   ||   ||   || X 
|-
| View user profiles ||   || X || X || X || X 
|-
| Have user profile ||   || X || X || X || X 
|-
| Upload picture ||   || X || X || X || X 
|-
| Upload CV ||   || X || X ||   || X 
|-
| Send advanced newsletters ||   ||   ||   ||   || X 
|-
| Send x amount of basic newsletters ||   ||   ||   || X ||  
|-
| Receive newsletters ||   || X || X ||   || X 
|-
| Receive activity newsletters ||   ||   || X ||   || X 
|-
| Receive sponsor newsletters ||   ||   || X ||   || X 
|-
| Create/modify any type of user account ||   ||   ||   ||   || X 
|-
| Can create/modify/subscribe activities ||   ||   ||   ||   || X 
|-
| Can create/modify board meetings ||   ||   ||   ||   || X 
|-
| Can create/modify web pages ||   ||   ||   ||   || X 
|}


===Member Subscribtion Flow===
# The applicant fills in subscribtion form
# The applicant receives automated "Member subscribtion e-mail" and becomes a "Standard member" (but still has no login access).
# The applicant pays membership fee
# HUTAC changes account into "Premium member" and presses button "Send payment received e-mail".
# The applicant receives "Membership fee received e-mail"
# The applicant is now premium member (but still has no login access).
# The member clicks on activation link found in "Membership payment received e-mail".
# The member can now make full use of the website
# The premium member expiration date has passed. 
# HUTAC changes account into "Standard member" and presses button "Send membership renewment payment received e-mail"
# The member receives "Membership renewment payment received e-mail".
# The member pays membership renewment fee.
# HUTAC changes account into "Premium member" and presses button "Send membership renewment payment received e-mail".

===Database ERD===
[^{UP(MVSD.HUTAC)}Hutac.vpp|Download Visual Paradigm Project File]

[image||{UP(MVSD.HUTAC)}ERD_Hutac.png]