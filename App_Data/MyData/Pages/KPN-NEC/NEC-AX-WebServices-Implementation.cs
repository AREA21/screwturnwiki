NEC-AX(Opus) WebServices Implementation FAQ
celio|2010/02/12 15:59:15
##PAGE##
{TOC}

=== MVSD vraaglijst===

* 1) Hoe moet NEC omgaan met wijziging van de gebruiker die de order inschiet? 
** Ofwel gebruiker A start via AX NEC en begint aan de order, maar maakt deze niet af. Vervolgens gaat gebruiker B verder met de order. 
** Moet er automatisch een nieuwe versie van de dienst aangemaakt worden met als auteur gebruiker B en de oude versie in de ‘overnemen’ status gezet worden? 
*** Dit zou de huidige manier van werken zijn in NEC. Of kan  Gebruiker B gewoon in de huidige versie editen?

(((Answer: Als aanvulling op het maitje van Cees (di 27-1-2009 9:34). Matthijs: Wordt in AX bijgehouden wie allemaal aan een order gewerkt hebben? Maw is het achteraf mogelijk te achterhalen wie er via een order (AX)  gemuteerd heeft in NEC?)))

* 2) Hoe moet NEC omgaan met de contractTakeOver acties?

* 3) Wat stellen de acties Blokkeren en Deblokkeren voor met betrekking tot NEC? 
** Wat moet er aan de kant van NEC gebeuren?

* 4) Businessrules met betrekking op packlinks/status wijzigingen.
** In de huidige situatie kan de gebruiker een dienst niet bewerken zonder het contract eerst te bewerken. 
** Het is niet mogelijk om een dienst “Administratief in dienst” te zetten, omdat het contract in bewerken status behoort te zijn.
** Het is niet mogelijk een contract in dienst te zetten zonder dat er een klant versie in dienst staat.
** Deze huidige business rule regels zijn opgesteld om de packlinks tussen de verschillende lagen correct te houden. 
*** Zie ook Jira issue '''NEC-349''', waarin het een en ander over de pack links gedefinieerd is.
** De provisioning XML generatie heeft een probleem als er geen valide packlinks zijn.
*** Deze restricties hebben gevolgen voor de interface, namelijk het contract en het klant document kunnen zonder de interface bewerkt worden en worden ook niet automatisch gesloten/geopend. 
*** Ofwel bij wijzigen van een dienst krijgt de gebruiker een foutmelding dat het contract niet in bewerken status staat.
*** Hoe moeten we met deze ‘oude’ businessrules omgaan?

* 5) Hoe worden naamswijzigingen in de dienst/contractnaam doorgegeven door Opus, of is dit niet meer mogelijk?

(((Mathijs / Tom, we (Cees en ik ) nemen aan dat dit mogelijk is in AX en dat dit doorgestuurd wordt naar NEC. Is dat juist?)))

§§(MVSD, 2009/01/22)§§

----
* 1) Krijgt NEC nu wel of niet properties mee met de testen dienst melding.Tijdens testen niet. Zo ja, moet er dan opnieuw de tariefcode bepaald worden? 
** Nee.

* 2) Moet er in de NEC gereedmelding  een volledige dienst meegestuurd, of alleen de technische namen van alle componenten?
** Wat mij betreft een volledige dienst. Van een aantal componenten (o.a. de controls) moet de inhoud van velden met de klant gecommuniceerd worden. Ik weet niet of Tom dit ook weet.
* 3) In het huidige NEC kunnen ingevulde webformulieren geïmporteerd worden. Wat moet er met deze functionaliteit gebeuren, vervalt deze of moet dit op een of andere manier in de interface opgenomen worden?
** Web-formulieren zouden volgens Peter de Paus voorlopig niet meer gebruikt worden. Moet in een vervolg fase opgepakt worden ?
* 4) Wat gebeurt er met de Crest documenten? 
** Die willen we verwijderen.
* 5) Wat gebeurt er met de technische import functionaliteit op het document niveau, wordt deze alleen op de productie uitgeschakeld, zodat er nog gebruik gemaakt van kan worden op de testserver.
** Ja, als dat kan.
* 6) Hoe kan de gebruiker de klant/ het contract wijzigen en hoe zet de gebruiker deze weer in dienst?
** Alles binnen NEC. Niet gestuurd vanuit AX.
* 7) Hoe gaat AX om met een Internationaal contract met meerdere landen en dus diensten? 
**(bulkcreatie)Is mij nog onduidelijk. Zal in CWT moeten blijken.

§§(MVSD, 2008/12/23)§§

=== Openstaande punten uit het login FO van Bart===

* 1) Het gebeurd wel eens dat een gebruiker een dienst tor op bewerken heeft gezet of admin in dienst gesteld (nieuwe NEC versie). 
De wens van de gebruiker is dan dat die NEC versie wordt verwijderd. Is dat in de toekomst ook mogelijk? 
*Eigenlijk is de vraag*: Wat is het laatste moment/status in NEC waarbij de dienst weggegooid kan worden zonder dat het impact heeft op de nog niet afgesloten melding in AX? 
** In NEC is dit geen probleem. De call (create/change) vanuit AX blijft staan in de database van NEC zolang de melding niet gereed gemeld wordt. Hoe eea met AX gaat moet nog uitgezocht worden.

§§(MVSD, 2008/12/23)§§