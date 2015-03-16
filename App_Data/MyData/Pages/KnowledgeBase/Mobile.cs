Mobile: hardware, apps (tips & tricks)
procm|2014/12/03 10:36:43
##PAGE##
{TOC}
<PRE>
=== Samsung S3, Mobile Tips & tricks===
* 10. Clear the device temporarily files to free up memory
** Turn off the device, press simultaneously the '''Volume Up''', '''Home''' and '''Power''' keys. 
*** When the device vibrates, let go only the '''Power''' key and keep holding the other two. 
** When the Android recovery appears, let go of all other keys. 
*** Navigate through the menu using the volume keys and use the power key to select a menu. Highlight the "Wipe Cache Partition" by using the volume key and then select it. 
*** After the process, the "Reboot Phone Now" will become highlighted, press the power key to select it and wait till the device reboots.

* Enable developer mode (Cyanogen >10.xx) by tapping on Build Number 7 times under Settings -> About Phone.
(((The hidden menu is actually from Google starting with either Android 4.1 or 4.2)))

* Problem exists for all Nexus device with Android 4.3+, when the tower signal is poor, lose signals from time to time.
** Try to Dial '''*#*#4636#*#*'''
** Choose phone information
** Change the first selection option (default: WCDMA preferred) to WCDMA only
** Or use GSM only, this setting will lose after you reboot the device!
** '''Reference'''(s):
*** [http://jingyan.baidu.com/article/e4d08ffddcd65e0fd2f60d0f.html]
*** [http://code.google.com/p/android/issues/detail?id=63524]

* [http://wiki.cyanogenmod.org/w/SMSC_Updates|SMS (Short Message Service) issues]
** KPN SMSC: '''+31653131313''' PDU(notation): '''07911356131313F3'''

((('''Updating your Phone/Tablet'''

* Open Dialer
* Type the following sequence '''*#*#4636#*#*'''
* Open Device Information/Phone Information/Tablet Information
* Scroll down to SMSC
** Optional: Hit Refresh to see current SMSC number used
** Enter in your carrier's gateway number in one of the following formats:
*** The 12 character gateway number including '+' (ex. +12063130004)
*** The 12 character gateway number in quotes (ex. "+12063130004")
*** The 16 character PDU formatted SMSC number as described below (ex. 07912160130300f4)
*** Press Update

Once entered, it can take up to 10 minutes for the phone to 'handshake' with the new gateway. A reboot is also suggested to power 
cycle the radio. If the format you entered does not work, attempt one of the other formats. Assuming everything worked, 
you should now be able to send and receive SMS properly.))) 

'''Resources'''(s):

* '''NEW'''! [http://www.sammobile.com/2013/11/04/android-4-3-jelly-bean-update-now-rolling-out-for-samsung-galaxy-s-iii-gt-i9300|Force update to Jelly Bean/Android v.4.3]

* [http://gs3.wonderhowto.com/how-to/tweak-your-samsung-galaxy-s3s-performance-with-these-build-prop-android-hacks-0142434|How-To tweak your Samsung Galaxy]
* [http://galaxys3-jellybeans.blogspot.nl/2013/02/how-to-improve-samsung-galaxy-s3.html|How-To improve Samsung Galaxy S3]
* [http://www.ibtimes.co.uk/articles/465286/20130507/samsung-galaxy-s3-boost-speed-performance-instantly.htm|Samsung Galaxy S3 boost-speed-performance instantly**]
* [http://au.ibtimes.com/articles/440292/20130228/samsung-galaxy-s3-10-tips-tricks-more.htm|Samsung Galaxy S3, 10 Tips & Tricks]
</PRE>{TOP}
