Deployment NHibernate based applications (EasyShop/EasyMail)
devid|2010/03/18 14:57:22
##PAGE##
{TOC}

==Step 1: Setting up the project's solution==
# Get project from de codebase SVN-repository.
# Open the solution in Visual Studio.
# Add the references to each project/website in the solution:
#* '''Businss.Dao''' 
#** References to the dll's in '''~\ExternalBin\Business.Dao\*.*'''
#* '''Businss.Dao.NHibernate''' 
#** References to the dll's in '''~\ExternalBin\Business.Dao.NHibernate\*.*'''
#** References to project '''Businss.Dao'''
#* Project '''Website''' 
#** References to the dll's in '''~\ExternalBin\Website\*.*'''
#** References to project '''Businss.Dao'''
#** References to project '''Businss.Dao.NHibernate'''
#** References to project '''Utilities'''
# Modify the following values in '''~\Website\web.config''':
#* Database connectionstring
#* SMTP server/port
#* Exception manager e-mailrecipient

==Step 1: Preparing the database==
Create a new database in the SQL Server and assign the database owner user.

==Step 2: Preparing the installation page==
The webapplication will not run without a database. The database has to be filled with required data such as languages and an administrator account.

The following code snippet contains the Spring.NET Framework build-in functions needed to generate the database from the mapping files. 
<code c#>// The LocalSessionFactoryObject is needed to call the methods to create/update/drop the database.
LocalSessionFactoryObject sessionFactoryObject = (LocalSessionFactoryObject)Spring.Context.Support.ContextRegistry.GetContext().GetObject("&NHibernateSessionFactory");

// The method needed to create the database.
sessionFactoryObject.CreateDatabaseSchema();

// The method needed to update the database (Usefull when tables are added/altered in the mapping files).
sessionFactoryObject.UpdateDatabaseSchema();

// The method needed to drop the database.
sessionFactoryObject.DropDatabaseSchema();</code>

===='''EasyShop:''' The following actions are required on the installation page (~\Setup\Install.aspx) in this order:====
# GenerateDatabaseSchema
# Insert the ConfigurationWebshop.
# Insert an Administrator (1 Minimum).
# Insert the Languages (1 Minimum).
# Insert the e-mailtemplates with the e-mailtemplatecodes:
#* MailTemplate.Code = WebshopOrderException
#* MailTemplate.Code = WebshopOrderSuccess
#* MailTemplate.Code = CustomerOrderException
#* MailTemplate.Code = CustomerOrderSuccess
#* MailTemplate.Code = CustomerRegistration
#* MailTemplate.Code = CustomerLoginRequest
# Insert the basic cmspages with the cmsagecodes:
#* CMSPage.Code = home
#* CMSPage.Code = pagenotfound
# Insert a Shipping (1 Minimum).
# Execute the steps above by running the installation page.
# Run the SQL-script '''GetAllCategoryChildren''' found in the bottom of the mapping '''~\Business.Dao.NHibernate\Mapping\Product.hbm.xml'''
# Remove the installation page when it's no longer needed to prevent customers from corrupting the database.

===='''EasyMail:''' The following actions are required on the installation page (~\Setup\Install.aspx) in this order:====
# GenerateDatabaseSchema
# Insert an User with administrative rights (1 Minimum).
# Execute the steps above by running the installation page.
# Remove the installation page when it's no longer needed to prevent customers from corrupting the database.

==Finished==

