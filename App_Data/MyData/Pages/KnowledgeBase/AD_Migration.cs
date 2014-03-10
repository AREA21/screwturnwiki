Active Directory Migration
procm|2012/11/15 13:19:08
##PAGE##
{TOC}

== Migration Active Directory '''2003 to 2008'''==

=== Gather information 2003 AD=== 
* Domain name
* Domain Controller IP
* Domain Functional Level)

=== Preparing Windows 2008 Server===
* Set up static IP address(es)
* Set up DNS IP address(es)
* Set up Computername
* Test connectivity (with W2k3 server)
* Run DCPROMO 

=== Preparing Windows 2003 server Active Directory Schema===
* ADPREP /ForestPrep
* ADPREP /DomainPrep
* ADPREP /RODCPREP 

=== Promoting Windows 2008 server as Domain Controller===
* run DCPROMO
* Choose existing forest & additional controller
* Verify the installation

=== Transfer  '''F'''lexible '''S'''ingle '''M'''aster '''O'''perations(FSMO) roles=== 
§§(procm,2012/11/13)§§
* PDC master
* RID master
* Insfrasctute master
* Domain Naming master
* Schema master

=== Demoting Windows Server(s) 2003===
* run DCPROMO
** Verify that the server is removed from AD '''Domain Controllers''' 
* Remove Windows 2003 server
** Make Server '''Member of''' Workgroup '''Legacy'''
** Delete this Server object from the AD
** Delete this host record(s) from DNS zone
* Raise Domain functional Level to '''Windows Server 2008'''
** run NTDSUTIL (metadata clean)
** delete account from Active Directory Sites & Services

{TOP}