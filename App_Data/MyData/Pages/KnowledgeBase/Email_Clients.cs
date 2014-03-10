Email Clients
procm|2012/10/16 11:39:34
##PAGE##
{TOC}
===MS Outlook 2003-2007 ClientPC's===
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
