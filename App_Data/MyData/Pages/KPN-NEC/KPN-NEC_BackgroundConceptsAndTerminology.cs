KPN-NEC Background, Concepts & Terminology
celio|2009/04/24 12:10:49
##PAGE##
{TOC}

=== Projects & subprojects===
<pre>
* '''NEC'''= Nieuw Electronisch Contract
* '''OMS '''= Order Management System
** '''TC''' =  TariffCode Bepaling 
** '''SCP''' = Service Control Point
* '''AX/OPUS''' = Microsoft AXapta, project code '''OPUS'''
</pre>

=== NEC: niveaus & layers===
<pre>
* NEC niveau:
** documnetType 1 = '''Template''' = SET met alle drie de lagen(1,2,3), waar staat wat technische mogelijk is.
*** documentType 2 = '''Package''', subSet van Template, waar staat wat commercieel mogelijk is.
**** documentType 3 = '''Document''', subSet van package. (oldname: Contract)
***** documentType 4 = '''Basic-Document''', subSet van package. Gebruikt als basis/sjabloon voor nieuwe documenten. (oldname: templateContract)

* Niveau layers: see (Eclipse: /KPN-NEC-Shared/{nec/src}/{nl/mvsd/nec}/Constant.java)
** Layer0 = '''Template''', not visible!!
*** Layer1 = '''Customer''' document
**** Layer2 = '''Contract''' document
***** Layer3 = '''Service''' document NEW -> layer -> contract -> package
</pre>

=== Terminology===
<pre>
*'''documentType''' = (NEC)niveau
*'''documentLayer''' = (niveau)layer
* '''Property'''/Eigenschap =
* '''PropertyDefinition'''/EigenschapsDefinitie =
* '''Facility'''/Faciliteit = Node / componenten / Bouwblokken
* '''FacilityDefinition'''/FaciliteitsDefinitie = Node/compoment/building block definitie
* '''ControlFacility '''= Faciliteit/Node, met XMLTYPE(Location, Feature, Message)
* '''Expression'''/Expressie = 
* '''Definition'''/Definitie =
* '''Link'''/Verbinding =
* '''Status'''/Status =
* '''NumberList'''/Automatisch nummerlijst = 
* '''PackDefinition''' = de pack kolom/eigenschap "baseOnPackID" verwijst naar zijn eigen definitie, dus een * Pack die gedefineerd is door ander Pack(id)
* '''ServicePackage''' = dienst(pack met layer 3 en documenttype 2)
* '''Service'''/ServiceDocument = dienst(pack met layer 3 en documenttype = 3)
* '''ServiceBasis''' = dienst(pack met layer 3 en documenttype 4)
</pre>
	