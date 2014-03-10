ICT Automatisering Hardware
procm|2014/02/07 17:58:38
##PAGE##
{TOC}

=== Installation of '''Windows 8''' on SSD<sup>1</sup> (2nd harddisk)===

==== Using an Bootloader to circumvent the BIOS password protection====
<PRE>
* '''Create an Extra Boot option''' (((using BootICE (BCD<sup>2</sup> Editor from HIRENCD's Tools) )))
&nbsp;
*# Mount HirenCD's ISO with for instance: [http://www.daemon-tools.cc/eng/products/dtLite|Daemon Tools Lite]
[image||{UP:ScrewTurn.Wiki.FilesStorageProvider}/ICTA/HirensCD/1.Mount HirenCD-ISO.jpg]
&nbsp;
*# Open HirenCD's (virtual CD) drive
[image||{UP:ScrewTurn.Wiki.FilesStorageProvider}/ICTA/HirensCD/2.HirensCD virtualCD drive.jpg]
&nbsp;
*# Start HirenCD's menu 
[image||{UP:ScrewTurn.Wiki.FilesStorageProvider}/ICTA/HirensCD/3.HirensCD Menu-Launcher.jpg]
&nbsp;
*# Run '''BootICE''' BCD<sup>2</sup> editor
[image||{UP:ScrewTurn.Wiki.FilesStorageProvider}/ICTA/HirensCD/4.HirensCD BCDEditor (BootICE).jpg]
&nbsp;
*# View/Read the current BCD<sup>2</sup> entries
[image||{UP:ScrewTurn.Wiki.FilesStorageProvider}/ICTA/HirensCD/5.HirensCD BootICE-BCD ViewEdit.jpg]
&nbsp;
*# Add an new entry (eg. Grub for Experts) such as in the next image
*#* choose '''Add -> RealMode boot entry (Grub4Dos etc.)'''
[image||{UP:ScrewTurn.Wiki.FilesStorageProvider}/ICTA/HirensCD/6.HirensCD BootICE-BCD Add.jpg]
&nbsp;
*# '''Copy Hiren'sCD files''' to the original bootdrive (C:\) 
*** HBCD (folder)
*** menu.lst
*** grldr.mbr
&nbsp;
*# Now you must '''Restart''' the System!
*#* ...and you should see the Hiren's BootCD BootLoader (GRUB) such as in the next image 
[image||{UP:ScrewTurn.Wiki.FilesStorageProvider}/ICTA/HirensCD/7.HirensCD BootLoader(GRUB)MenuList.jpg]
&nbsp;
*# Choose '''More...''' option & try to boot from the USB PenDrive & Start the OS installation
*#* option '''Boot HDD 3 MBR''', i guess! 
[image||{UP:ScrewTurn.Wiki.FilesStorageProvider}/ICTA/HirensCD/8.HirensCD BootLoader(GRUB)Menu_More.jpg]
&nbsp;
*# Final Result: 
*#* Windows 8(bootloader) preserves previous OS'es
[image||{UP:ScrewTurn.Wiki.FilesStorageProvider}/ICTA/HirensCD/9.HirensCD Final Result, Win8 BootLoader.jpg]


Legend: 
<sup>1</sup> '''SSD''' - '''S'''olid '''S'''tate '''D'''isks
<sup>2</sup> '''BCD''' - '''B'''oot '''C'''onfiguration '''D'''ata
</PRE>
