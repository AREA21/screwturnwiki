Database
procm|2012/10/01 11:46:18
##PAGE##
{TOC}


== Design checklist==
===table names===
* must be consistent with other table names. Tables that together form a module in an application should start with the same prefix(like ''ProjectContact, ProjectCustomer, ProjectIteraction'', ...) to keep them together in the complete list of table. 
* Don't create long names for crosstables (for NxM relations). Crosstables can have their own unique name(like the crosstable ProjectParticipation is a crosstable between ''ProjectContact'' and ''ProjectInstance''). 
*Reference tables (that have just a few records only used for dropdown lists) always start with Reference...(like ''ReferenceOrderStatus'' and ''ReferenceSecurityLevel''). All table names should be singular(not MonitorMailboxes but MonitorMailbox) and written in ''PascalCase''.

===column names===
* in a table must be consistent with the other column names.(If something is called LastModified in one table, the same information should no be called ModificationDate in another table.)
* All column names should be singular(not Titles but Title) and writen in ''PascalCase''. Note: be careful when changing the name of the primary key of an existing table. This may result in errors in the foreign key triggers.

===primary key===
* of a table is always called ''Id''. 
* It must be an ''Identify'' field, and it should be of size tinyint, smallint, int or bigint. 
**Exception to this rule: crosstable(for NxM relations) do not need their own ''Id'' column, unless they contain additional data themselves and are edited independently. 
*In crosstables the primary key can be set on the columns that togheter form the NxM relation. The name of the primary key in all tables is usally ''PK_tablename''.

* There is an explicit choice for each field to '''allow nulls''' or not. Try to set ''Allow Nulls'' to False for most columns. Only set it to True when is valid for a column not to have a vaue. Note: for foreign keys to other tables it is sometimes useful to include an Unknown value in the primary key table in the first record, which enables you to set the ''Allow Nulls'' value of the foreign key to False. 

* For many tables the '''Deactivated''' field is advised. However, this field in not needed in tables that have another(more advanced) status field. This field is usally not needed in crosstables.

* For many tables the fields '''LastModified'''  & '''LastModifiedUSer''' are advised. However, these fields are sometimes not needed in crosstables.

* There is an explicit choice beteween the '''integer types''': tinyint, smallint, int & bigint for each integer field. Choose the smallest type that will still be big enough for the values that the column will hold.

* There is an explicit choice between the '''data/time types''' smalldatetime & datetime for each date/time field. Choose the smallest type that will be big enough for the values taht the column will hold.

* There is an explicit choice between the '''string types''' char, nchar, varchar, nvarchar, varchar(max) and nvarchar(max) for each string field. Only use the n...char types when you are sure that unicode characters must be stored. Only use the ''char'' & ''nchar'' types when the string sizes are constant. (The ''text'' type should not be used.) 

* the '''string size''' of string is set to an acceptable value. Do not set all values simply to 50 or 255 characters.

* Use a '''user defined type''' for values(most often:string types) that appear in multiple tables when it is essential that they should remain consistent with each other.

* Add a '''description''' to any of the columns that require a bit of explanation. Descriptions are not needed for standaard columns like ''Id'' & ''LastModified''.

* There is always a '''clustered index''' on the table, and it is set on the primary key(unless you can name very good reason not to do that for a particular table). Form most tables this will be the ''Id'' column. For crosstables this may be the index on the NxM relation.

* All columns that refer to an ''Id'' field in another table(foreign keys) preferable should have a name that ends with ''Id''. A '''foreign key contraint''' must be defined between this column and the primary key in the other table.

* For each foreign key it must be decided explicitly ia a '''cascading delete''' is needed or not. A cascading delete should only be triggered when the record in the foreign key table cannot exist without a corresponding record in the primary table. (Cascading updates are never needed because the values in ''Id'' columns should never be updated.)

* There is an explicit choice to include '''computed columns''' or not. This should only be done for columns that can be computed easly and will need to be used often.(Otherwise, the business layer is a more appropriate place to compute extra field values.)

* Ther are '''indexes''' defined on(combinations of) fields that you think may be used for searching or sorting. For small tables(<10.000 records) that are not updated frequently(<1x per minute) you can create many different indexes. But create only the essential indexes for large tables and tables that are heavily updated. The indexes usually have a name like ''IX_columnname(s)''.

* A '''covering index''' is an index that not only indexes the main column, but also contains on or two extra fields that are often needed. (For example: ''PostalCode+Address'' can be a covering index, while only ''PostCode'' is not a covering index.) 

* There are '''unique constraints''' defined on fields that should have unique values. This not only applies to individual columns, but also to combinations of them. (It is easier to let the database check on these constraints than to do this in the business layer.) You could give all unique constraints a name like ''UC_columnname(s)''.

*'''Note:''' It is often not needed to define '''default values''' for columns. The business layer is a more suitable place to define default values for new entities.

*'''Note:''' It is often not needed to define '''premissions''' on table objects in a web application. Permissons on data need to be defined at the application level.

*'''Note:''' It is often not needed to define '''check constraints''' or '''rules''' on one or more columns in a table. The business layer is far more powerful in checking the validity of data before it is being saved.

{TOP}


== SQL Tips==
'''Summary'''
SQL Guidelines

=== Algemeen===
* dbo. gebruiken in een query.
** voorbeeld: '''SELECT productid FROM dbo.tblProduct''' ipv '''SELECT productid FROM tblproduct'''
** voordeel: Is sneller omdat SQL server gelijk weet van welke gebruiker de tabel is.
** nadeel: geen!!

* WITH(NOLOCK) gebruiken in een SELECT query
** voorbeld: '''SELECT productid FROM dbo.tblProduct WITH(NOLOCK)''' ipv '''SELECT productid FROM dbo.tblProduct'''
** voordeel: er wordt bij het uitvoeren van de query niet gekeken naar bewerkingen van andere gebruikers.
** nadelen:
*** Mogelijke dirty read, data niet te bewerken.
*** Werk niet in Enterprise Manager indien de tabel is "gealiased"".
** niet gebruiken: indien je in met 1 bewerking de data aanpast en met de tweede de data ophaalt heb je de kans dat je de ongewijzigde data ophaald(Dirty=read)

* Stored procedures gebruiken in plaats van losse queries.
** voordelen:
*** Minder dataverkeer van webserver naar database server (query is korter)
*** Beter caching van execution plan.
*** Mogelijk een beter execution plan(vooral bij queries met meerdere joins).
*** Mogelijk alleen SQL update en geen code aanpassing.

* sp_executedsql gebruiken ipv EXEC
** voordeel beter hergebruik van execution plan.

* Client sided connecties gebruiken(connecties met DB na ophalen recordset verbreken voor de recordset).

* Bij een update van een enkele rij, de rij "locken" ('''adLockPessimistic''' of '''WITH(ROWLOCK)''')

* UNION ALL in plaats van UNION
** voordeel: SQL server hoeft niet te kijken voor het ontdubbelen van rijen.
** nadeel: alleen te gebruiken indien je weet dat er geen dubbele records terug komen.

* Geen DISTINCT gebruiken indien mogelijk.

* Geen HAVING gebruiken indien mogelijk.

* ORDER BY
** Indien mogelijk geen ORDER BY gebruiken maar een index die in de goede richting is gesorteerd.
** Niet gebruiken indien in een resultaat rij data voorkomt die langer is dan 8060 tekens want dan kan er niet meer gesorteerd worden.(kan voorkomen bij JOINS)
** Indien mogelijk niet gebruiken indien je meerdere tabellen "joined", de ORDER BY kom pas nogal eens op een plaats te staan in het execution plan die niet gunstig is.
*** oplossing: Client sided(op de Webserver) de ORDER BY uitvoeren.

* Gebruik Constraints ipv Triggers waar mogelijk.

* Sluit in code de Recordsets ed. goed af waardoor SQL server de resources sneller vrij kan geven.

{TOP}

=== Stored Procedures===
* SET NOCOUNT ON gebruiken boven in de stored procedure.
* RETURN gebruiken ipv SELECT indien je maar 1 waarde terug geeft.
* Naamgeving: niet beginnen met sp_ want dan wordt altijd eerst gekeken in de MASTER database.

=== Execution plan===
* Je wilt geen 'SCANS' zien maar 'INDEX SEEKS'
** Op te lossen met goede indexen te leggen.
* Geen 'BOOKMARK LOOPKUPS'
** Op te lossen door goede indexen te leggen.
* Afhankelijk van de hoeveelheid data kan het zijn dat met dezelfde indexen toch het execution plan anders is op ''Live'' dan bijvoorbeeld op ''Development''.

=== Indexen===
* Primary key
** Over het algemeen is het beste om op de primary key een clustered index te leggen.
** Geen clustered index leggen op de primary key indien hier nooit opgezocht wordt via een query, dan beter een clustered index leggen op het veld of velden waar vaak op gezocht wordt.
* Kunnen niet gelegd worden op een bit veld. Indien je een tabel hebt waar je vaak gaat zoeken op een combinatie van velden met daarin een bit veld dan is het waarschijnlijk slim om het bit veld om te zetten naar tinyint en een index te leggen over alle velden waar je opzoekt.

=== GUID's, when to use?===
* Use guid.comb in your database if you need guid keys but don't want to take a big performance hit - level 300
Another option (in Sql Server 2005) is NEWSEQUENTIALID(), which generates a GUID which is greater than any previous GUID on that computer. 
If you set NEWSEQUENTIALID() as the default on a PK GUID column, you'll avoid the fragmentation problem. 

{TOP}

=== MS SQL Profiler (SQL Server Diagnosing Tool)===
* Start SQL Profiler(liefst op een live database met echte acties)
* File -> Trace
* Kies SQL server
* Tab filter
** Zet eventueel een filter op de databasename die je wilt profilen
* Start de profiler (RUN)
* Save het resultaat in een tabel bijvoorbeeld _MyTrace, bij voorkeur op een database(server) met minder belasting.
* Voeg een kolom toe "Identifier" VARCHAR(50)
* Opschonen tabel
** Query uitvoeren DELETE FROM dbo._MyTrace WHERE(TextData IS NULL)
** Query uitvoeren DELETE FROM dbo._MyTrace WHERE(Duration IS NULL)
* Identificeren queries voor optimalisatie.(de duration >100 is een richlijn indien je er geen of weinig heb dan >50), alles onder de 16 is meestal niet te optimaliseren.
** Select TOP 20 CAST(TextData AS VARCHAR(8000)) AS query, Duration FROM dbo_MyTrace WHERE(Duration > 100) AND (Identifier IS NULL) ORDER BY Duration DESC
*** UPDATE het identifier veld bijvoorbeeld
**** UPDATE dbo._MyTrace SET Identifier = 'ShowMyAds' WHERE(TextData LIKE '%ShowMyAds%')
**** Herhalen totdat er niets meer te groperen valt. Zet alle andere identifiers op 'Other'
***** UPDATE dbo._MyTrace SET Identifier = 'Other' WHERE Identifier IS NULL
* Uitzoeken queries die niet goed performen
** SELECT Identifier, SUM(Duration) AS TotalDuration, AVG(Duration) AS AverageDuration, COUNT(Duration) AS NumberOfQueries, MAX(Duration) AS MaximumDuration, MIN(Duration) AS MinimumDuration FROM dbo_MyTrace WITH(NOLOCK) GROUP BY Identifier ORDER BY SUM(Duration) DESC
** SELECT CAST(TextData as VARCHAR(8000)) as query FROM dbo_MyTrace WITH(NOLOCK) WHERE Identifier = 'ShowMyAds'
** Bekijk per query het Execution plan in Query Analyser zowel op ''Development'' als op ''Live''(er kunnen verschillen in zitten)
** Controleer of de indexen van de ''Dev'', ''Test'' en ''Live'' database overeen komen.
** Optimaliseer de queries(op ''Dev'')
*** Indexen leggen en/of verwijderen
*** Herschrijven queries
** Cache de resultset in de code indien dit nog niet gedaan is en de query niet geoptimaliseerd kan worden.

* Na deployment van de SQL optimalisaties, nogmaals profilen, het kan zijn dat de aangelegde indexen ongustig zijn voor andere queries ook is het mogelijk dat er nu andere queries boven water komen die ook nodig geoptimaliseerd kunnen worden.

{TOP}


