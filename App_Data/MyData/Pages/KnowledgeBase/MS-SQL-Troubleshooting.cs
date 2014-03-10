MS SQL troubleshooting
procm|2013/01/24 14:05:10
##PAGE##
{TOC}

=== How to enable SA account===
* '''Using SQL Management Studio:'''

<PRE>
Go to '''Security''' -> '''Logins''' -> '''SA'''
Make Changes in the Status and/or General page(s)
* Status page: Enable or Disable the account
* General page: Change account password
</PRE>

* '''Using SQLCMD command:'''

<PRE>
In the '''Command Prompt''' type: '''SQLCMD -S {ComputerName\InstanceName}'''
then pass the following SQL statements:
(((USE [master] 
GO
ALTER LOGIN [sa] WITH PASSWORD=N'{password}'
GO
ALTER LOGIN [sa] ENABLE
GO)))
</PRE>

=== What to do when the SA account password is lost in SQL Server?===
<PRE>
Open the Configuration Manager tool from the '''SQL Server Configuration Manager'''
* Stop the SQL Server Instance you need to recover
* Navigate to the '''Advanced''' tab & add '''";–m"''' to the end of the list in the '''Startup parameters''' option 
* Click the '''OK''' button & restart the SQL Server Instance 

(((After the SQL Server Instance starts in single-user mode, the Windows Administrator account is able to connect to SQL Server
using the sqlcmd utility using Windows authentication. You can use Transact-SQL commands such as "sp_addsrvrolemember" to add an 
existing login (or a newly created one) to the sysadmin server role.

* Run '''MS-DOS Command''' Prompt as '''Administrator'''
* run SQL client (SQLCMD) eg: 
** C:\Program Files\Microsoft SQL Server\100\Tools\Binn\sqlcmd -S 'wks-031\sqlexpress'
)))

* The following example adds the account "Buck" in the "CONTOSO" domain to the SQL Server "sysadmin" role:
** EXEC sp_addsrvrolemember 'CONTOSO\Buck', 'sysadmin';
** GO

'''Finally''': Once the sysadmin access has been recovered/granted, remove the '''";-m"''' from the '''Startup parameters''' & restart the SQL Server Instance.
</PRE>

=== Unlock database (disconnect all users)===
<PRE>
* Go to the folder of the website that connects to the database and SAVE the Web.config. 
** IIS will notice this and will drop all open connections and open sessions.
</PRE>{TOP}

=== SQL trusted connection (Windows Integrated Authentication)===
<PRE>
* Cannot open database "xxxx" requested by the login. 
** Login failed for user 'IIS APPPOOL\DefaultAppPool'
** Login failed for user 'NT AUTHORITY\NETWORK SERVICE'

* Check if the Identity settings of the Application Pool in IIS is ApplicationPoolIdentity(default) and change that to NetworkService.
** Open IIS, double click your PC name under Connections, Click Application Pools, Select the App. pool used for the site. 
*** Then under actions on the right click Advanced Settings, Go to Process Model section and click on Identity. Now select NetworkService.

* [http://devilswork.wordpress.com/2009/01/28/login-failed-for-user-networkservice|Finally give the '''NetworkService''' access to the "xxxx" database]
</PRE>{TOP}

=== Orphaned Users===
:'''summary''': Bij het verplaatsen van een database op SQL Server ontstaan er problemen met de gebruikers

<PRE>
* '''Detecteren van de orphaned users'''
 USE &lt;database_name&gt;;
 GO; 
 sp_change_users_login @Action='Report';
 GO;

* '''Herstellen van de orphaned users'''
 USE &lt;database_name&gt;;
 GO;
 sp_change_users_login @Action='update_one', @UserNamePattern='&lt;database_user&gt;', @LoginName='&lt;login_name&gt;';
 GO;

* '''Wijzigen van het wachtwoord van de zojuist herstelde orphaned users'''
 USE master; 
 GO;
 sp_password @old=NULL, @new='password', @loginame='&lt;login_name&gt;';
 GO;

* '''Aanbevolen script voor het herstel'''
 EXEC sp_change_users_login 'Auto_Fix', 'loginnaam', NULL, 'nieuwwachtwoord';

[^http://msdn.microsoft.com/en-us/library/ms175475.aspx|Troubleshooting Orphaned Users]
</PRE>
{TOP}

=== Migrate SQL2000 to SQL2008 (batch)===
<PRE>
* '''SET VARIABLES'''
 set DBNAME=NAMEOFDATABASEBEINGRESTORED
 set DBDIRECTORY=C:\Program Files\Microsoft SQL Server\MSSQL\Data

* '''PUT DATABASE IN SINGLE USER MODE TO ALLOW RESTORE'''
 osql -E -d master -Q "alter database %DBNAME% set single_user with rollback immediate"

 '''RESTORE DATABASE'''
 osql -E -d master -Q "restore database %DBNAME% from disk='%~dp0\%DBNAME%.bak' WITH MOVE '%DBNAME%_Data' TO '%DBDIRECTORY%\%DBNAME%_Data.MDF',  MOVE '%DBNAME%_Log' TO '%DBDIRECTORY%\%DBNAME%_Log.LDF'"

* '''GRANT PERMISSION TO ASPNET USER'''
 osql -E -d %DBNAME% -Q "sp_grantdbaccess '%COMPUTERNAME%\ASPNET'"
 osql -E -d %DBNAME% -Q "sp_addrolemember 'db_owner', '%COMPUTERNAME%\ASPNET'"

* '''RESTORE TO MULTI USER'''
 osql -E -d master -Q "alter database %DBNAME% set multi_user"
 pause
</PRE>{TOP}