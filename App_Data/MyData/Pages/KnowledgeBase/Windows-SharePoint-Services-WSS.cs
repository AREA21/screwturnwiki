Windows SharePoint Services(WSS)
devid|2010/02/17 17:26:41
##PAGE##
== Windows SharePoint Services(WSS)==
<sup>summary: sharepoint services provided in Windows Server 2003</sup> 

=== activate Single Sign-On (SSO)===
<pre>
'''1. manually configure Kerberos authentication for the virtual sharepoint server''' [http://intranet.mvsd.nl]
* To use a script to enable Kerberos authentication on the virtual server, follow these steps: 
**On the server that is running IIS, click Start, click Run, type cmd in the Open box, and then click OK.
**Change to the Inetpub\Adminscripts folder.

* Type the following command, and then press ENTER:
** cd Drive:\inetpub\adminscripts
**Note In this command, Drive is the drive where Microsoft Windows is installed.

*Type the following command, and then press ENTER:
**cscript adsutil.vbs get w3svc/##/root/NTAuthenticationProviders
**Note In this command, ## is the virtual server ID number. The virtual server ID number of the Default Web site in IIS is 1. {br}(for the site: '''intranet.mvsd.nl''' the ##='''561119538''')

* To enable Kerberos authentication on the virtual server, type the following command, and then press ENTER:
** cscript adsutil.vbs set w3svc/##/root/NTAuthenticationProviders "Negotiate,NTLM"
** Note In this command, ## is the virtual server ID number.

* Restart IIS. To do this, follow these steps: 
** Click Start, click Run, type cmd in the Open box, and then click OK.
** At the command prompt, type iisreset, and then press ENTER
**Type exit, and then press ENTER to close the Command Prompt window.

'''2. Configure a Service Principal Name(SPN) for the domain user account'''
:: because the application pool identities are domain user accounts. CentralAdminAppPool & MSSSharepointPortalAppPool {br}are using ''MVSD\sharepointadmin'' as indentity. (see ApplicationPool properties, tab Indentity under IIS6.0 at TELCO2)

* Download and install the Setspn.exe command-line tool. To do this, visit one of the following Microsoft Web sites.
** [http://support.microsoft.com/kb/892777|Windows Server 2003 Service Pack 1 Support Tools] 
* Use the Setspn.exe tool to add an SPN for the domain account. To do this, follow these steps: 
** Type the following line at the command prompt, and then press ENTER: 
*** Setspn -A HTTP/telco2 MVSD\sharepointadmin 
*** Setspn -A HTTP/telco2:10673 MVSD\sharepointadmin
** Type the following line at the command prompt, and then press ENTER: 
*** Setspn -A HTTP/intranet.mvsd.nl MVSD\sharepointadmin

'''3. Configure trust for delegation for Web parts'''
* On the domain controller, start Active Directory Users and Computers.
* In the left pane, click Users.
* In the right pane, right-click the name of the user account, and then click Properties. 
* Click the Account tab, under Account Options, click to select the Account is trusted for delegation check box, and then click OK. 
* Quit Active Directory Users and Computers.

resource: [http://support.microsoft.com/kb/832769]
</pre>
{TOP}

