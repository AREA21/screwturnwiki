Email Clients & Servers
procm|2016/06/10 11:36:39
##PAGE##
{TOC}
=== Exchange===
==== Search SMTP address in AD====
<PRE>
*Go to '''AD Users & Computers''', 
** right-click on your Domain | Find | 
** change the Find drop-down to '''Custom Search''' 
(((you can also change the '''IN''' drop-down to '''Entire Directory'''
if you have more than 1 domain | go to Advanced tab | type)))
** type for eg. '''proxyAddresses=smtp:celio@area21.nl''' into "Enter LDAP query" box (under  Advanced tab): 
</PRE>

=== Test DNS MX record(s)===
<PRE>
* At the command prompt, type '''NSLOOKUP''', and then press '''ENTER'''
* Type the external '''DNS <IP address>''' and press '''ENTER'''
* Type '''SET Q=MX''', and then press '''ENTER'''
* Type '''<domain name>''', where domain name is the name of your domain, and then press '''ENTER'''

The MX record for the domain you entered should be displayed. If the MX record is not displayed, DNS is not configured properly.
</PRE>

=== Outlook 2003-2010===
==== Unblock attachments====
<PRE>
message: "Outlook blocked access to the following potentially unsafe attachments"
* Modify Windows registry (regedit):
** Navigate to '''HKEY_CURRENT_USER\Software\Microsoft\Office\16.0\Outlook\Security''' (Outlook version 13) 
** edit/create a new '''String Value''' named '''Level1Remove'''
** fill this entry with the file extentions allowed eg.: '''.crt;.zip''' 
</PRE>

==== Clear Email Auto Complete cache!====
<PRE>
* Background: Outlook 2003 and Outlook 2007 has a feature called Email Address Auto Complete. As you type in an email address 
into the TO: or CC: field (and BCC: field I imagine) outlook will display a list of matching email addresses from the outlook auto-complete cache.
As convenient as the Auto Complete feature is, there are times when you need to remove these cached email addresses from the cache.
Perhaps you just sent an email and you found out you made a typo…..Unfortunately that typo will remain in you cache until you delete it.
** '''Solution 1''': The fix is easy:
**# Type the email address you wish to clear from the cache until outlook displays it as shown above. 
**# Press the down arrow key to select the email address and press the delete button.  
** '''Solution 2''' : Another option if you want to delete all addresses in the cache file (outlook.nk2): 
**# Close Outlook 
**# Open Windows Explorer or IE and Paste %APPDATA%\Microsoft\Outlook into the address bar. 
**# Delete the file Outlook.nk2 file in this folder  
* '''Solution 2''' is comparable to the the “Nuclear Bomb” being that it will delete ALL your cached email addresses.  
It should only be used if you want to wipe the file clean or if you have corruption issues with your .nk2 file.  Once you delete 
the .nk2 file, the next time you open Outlook it will automatically create a new .nk2 cache file and Outlook will once again begin
caching the email addresses you use.

:: [http://www.nirsoft.net/utils/outlook_nk2_edit.html|NK2View, Tool to Manage Ms.Outlook Autocomplete cache] 
</PRE>