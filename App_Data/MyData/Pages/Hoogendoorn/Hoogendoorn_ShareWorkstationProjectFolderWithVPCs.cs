Share Workstation Project Folder with VPC's
procm|2015/03/31 10:49:29
##PAGE##
'''info:''' Share Workstation Project Folder with VPC's/Virtual Machines

<PRE>
* Open explorer & right click the (project)folder you to share, choose “Eigenschappen”   
** [image||{UP}/Hoogendoorn/ShareProjectFolder/Share Project Folder 1-5.jpg] 
&nbsp;

* Click on the tab “Delen” & choose “Geavanceerd delen”
** [image||{UP}/Hoogendoorn/ShareProjectFolder/Share Project Folder 2-5.jpg]  

* Check the option “Deze map delen” & give a name to your share. 
note: the $ at the end of the share name makes the it invisible 
After this choose “Machtingen”  
** [image||{UP}/Hoogendoorn/ShareProjectFolder/Share Project Folder 3-5.jpg]  

* Click on the button “Toevoegen” & add your (domain)name in the white box.
After that click OK
** [image||{UP}/Hoogendoorn/ShareProjectFolder/Share Project Folder 4-5.jpg]  
 

* Now grant write access to yourself, selecting your name from the list “Namen van groepen of gebruikers:”, check the checkbox “Wijzigen” & click the OK button.   
** [image||{UP}/Hoogendoorn/ShareProjectFolder/Share Project Folder 5-5.jpg]  

* Mount the share on your desired VPC machine
Execute this command in the command prompt: '''NET USE h: \\"computername"\"sharename" /user:bbinst\"username" /PERSISTENT:YES'''
</PRE>