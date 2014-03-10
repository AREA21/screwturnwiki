Connect an EasyWebEditNet website with EasyMail
robvdkamp|2010/03/18 16:06:12
##PAGE##
===EasyWebEditNet===
An EasyWebEditNet website has a control called EasyMailConnector.ascx.cs which can be found in /Controls/EasyMailConnector.ascx.cs<br/>
There are 3 important variables in the AppSettings section of the web.config:
<pre>
* '''EasyMailUrl '''(Web.Config -> EasyMail_BaseUrl -> http://easymail.mvsd.nl/login.aspx)
* '''EasyMailUserLoginName '''(Web.Config -> EasyMail_UserLoginName -> Username EasyMail)
* '''Hashedstring '''(Combination of the UserLoginName + date & time)
</pre>
These variables are needed to create an unique url, which redirects the user to EasyMail. The unique url structure:
'''http://easymail.mvsd.nl/login.aspx'''?c1='''EasyMailUserLoginName'''&c2='''Hashedstring'''

===EasyMail===
If you manually want to log on onto EasyMail you need to visit [^http://easymail.mvsd.nl/login.aspx|http://easymail.mvsd.nl/login.aspx].<br/>
If you get redirected to EasyMail by an EasyWebEditNet website you automatically start at login.aspx but you don't have to log on 
manually (this prevents the user to be forced to login for a second time).


Login.aspx checks if the user enters EasyMail by an unique url:
<pre>
# Check if c1 and c2 exist in the url
# If c1 and c2 exist, compare the hashedstring and check if the EasyMailUserLoginName is a known user of EasyMail (exist in the user Database)
# If the user has an EasyMail account, check if the user account is active
#* No: Show message (inactive user account)
#* Yes: Redirect to UserList.aspx. UserList.aspx will forward the user to the correct page, depending on the user rights
#** Admin - UserList.aspx
#** User with 1 NewsletterGroup - Frontpage.aspx
#** User with multiple NewsletterGroups - NewsletterGroupList.aspx
</pre>