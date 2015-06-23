Software Quality
procm|2015/06/22 09:30:19
##PAGE##
== Software Quality (Brainstorm)==
<PRE>
[http://nvie.com/posts/a-successful-git-branching-model/|'''Successful Git(Distributed VCS) branching-model''']

[https://msdn.microsoft.com/en-us/library/ms229002%28v=vs.110%29.aspx|'''Naming Guidelines from Microsoft''']

=== Issue/project Management===
(((
* Issue Status workflow 
** Open
** In Progress
** Resolved
** Team Review (Request)
*** Team OK
*** Team Rejected
** Test deployment(Request)
*** Test deploy OK
*** Test deploy Rejected
** Beta deployment(Request)
*** Beta deploy OK 
*** Beta deploy Rejected
** Live deployment(Request)
*** Live deployment OK
*** Live deployment rejected
** Closed 
** reOpen
** Release Management???

* Enhancements:
** place comments before your Code
*** name + date + version 
*** issue code/key
*** description(optional)
** commit(SVN), mention {Issuekey or URL} in the comment section
** look forward to integrate/automate Issuemanagement tool with VersionControl
*** possible to trace/manage all changes in the VersionControl system based on the Issuekey

{TOP})))
=== Release Procedure/checklist===
((('''summary''': Dit document beschrijft de procedure die gevolgd moet worden voor het maken van een release.

* Bepaal het versienummer van de module
** versienummers bestaan uit de elementen major.minor.micro (bv. 2.5.13) plus een eventuele toevoeging. 
Het bepalen van een versienummer gaat volgens de volgende regels:
*** '''Major''': zeer significante/fundamentele wijzigingen: versiesprong. 
Beslissing tot ophoging mag alleen door/in overleg met de projectmanager genomen worden.
*** '''Minor''': komt overeen met een release vanaf de trunk. 
Bevat in de regel een beperkt aantal RFEs(Request for Enhancement) en fixes, zowel in scope als in aantal. 
Ophoging met 1 gebeurt voor iedere trunk-release.
*** '''Micro''': komt overeen met een patch/bugfix. 
Bevat in de regel slechts één tot enkele fixes, en geen RFEs. 
Ophoging gebeurt voor iedere branch-release met 1. Minor releases hebben een micro versie ‘0’.
*** '''Toevoeging''': interne (test)releases worden gevolgd door de toevoeging ‘-rc#’, waarbij ‘#’ begint bij 1 en 
opgehoogd wordt voor iedere volgende interne release. Hierbij staat ‘rc’ voor ‘release candidate’.
** Voorbeeld: de laatste minor release van een willekeurig  component was 2.5.0. 
Op deze release zijn in totaal 13 bugfixes uitgebracht. De huidige release die in productie is, is dus 2.5.13. 
Parallel aan de bugfixes werden op de trunk verschillende RFEs doorgevoerd . Vanaf de trunk wordt een nieuwe release 
geprepareerd die eerst intern getest zal worden. Voor deze release wordt het minor versienummer met 1 opgehoogd ten
 opzichte van de vorige release. Het micro versienummer wordt op ‘0’ gezet. Omdat het de eerste interne release 
betreft, krijgt het component de toevoeging ‘-rc1’. Het volledige versienummer van deze release is dus 2.6.0-rc1
* Tag de release
** Het versienummer wordt gebruikt om de release in de Subversion repository te taggen. 
Dit kan worden gedaan met TortoiseSVN, door het aanroepen Branch/tag optie.
TortoiseSVN vraagt hierbij om het te gebruiken versienummer, dat in de vorige stap bepaald is. 
Er is ook Build(Maven) script die automatische '''Tags''' creert nadat het builden van een .NET project succesvol is.
* Maak de release
** Met behulp van dezelfde Build script wordt de release daadwerkelijk gemaakt.

{TOP}

==== '''Bugfix checklist'''====
* maak, indien nodig, een bugfix-branch
** Bugfixes (in de zin van patches op micro-versieniveau) mogen nooit op de trunk uitgevoerd worden. 
Hiervoor moet altijd een aparte bugfix-branch gebruikt worden.
** Per minor-versie bestaat hoogstens 1 bugfix-branch. 
Deze wordt aangemaakt op het moment dat de eerste bugfix gemaakt moet worden, ofwel in aanloop naar micro-versie ‘.1’.
** Procedure aanmaken bugfix-branch:
*** Switch naar minor versie (e.g. 2.6.0).
*** Branch vanaf deze versie naar 2.6-fixes (het micro-versienummer wordt niet gebruikt in de branchnaam, omdat deze 
overeenkomt met het nummer van de bugfix).
* Switch naar de bugfix-branch
** Een bugfix-branch heeft altijd de naam major.minor-fixes. Als de bugfix-branch niet bestaat, moet deze aangemaakt worden.
* Los de bug(s) op
** Een bugfix is slechts beperkt in scope. Voer zo min mogelijk wijzigingen door. RFEs worden in principe uitgevoerd op de trunk.
* Maak een release volgens de hierboven beschreven procedure
** In het voorbeeld van de eerste bugfix voor 2.6.0 zou de eerste interne testrelease het versienummer 2.6.1-rc1 meekrijgen.
* Voer de bugfix door op de trunk
** Nadat een productierelease gemaakt is (dus 2.6.1, '''niet''' 2.6.1-rc1) moet de geimplementeerde patch ook op de trunk
 uitgerold worden
*** Creeer de patch tussen de voorlaatste micro-versie en de huidige bugfix (e.g. 2.6.0?2.6.1, of 2.6.1?2.6.2,
 maar nooit 2.6.0?2.6.2.
**** [http://tortoisesvn.net/docs/release/TortoiseSVN_en/tsvn-dug-patch.html|Creating & Applying Patches(TortoiseSVN)]
*** Hang de patch als attachment aan het JIRA issue dat in deze bugfix opgelost is.
*** Switch naar trunk
*** Pas de patch toe op de trunk. 
Dit kan, zeker als trunk-ontwikkeling in een ver stadium is en de huidige trunkversie veel verschillen vertoond met 
de gepatchete minor release, conflicten opleveren. 
Het is daarom belangrijk dat de patch '''direct''' en '''door dezelfde ontwikkelaar''' die de patch ontwikkeld heeft op de trunk
 wordt toegepast. Eventuele conflicten kunnen dan makkelijk(er) geplaatst en verholpen worden. Overleg zonodig met
 andere ontwikkelaars die, blijkens het SVN log, wijzigingen in de conflicterende code aangebracht hebben

:'''Merk op dat de bugfixes ook op de trunk uitgerold moeten worden. Zie hiervoor Bugfix checklist.'''

* '''Resource'''(s):
**[http://en.wikipedia.org/wiki/Revision_control| Revision Control (Wiki)]
)))
{TOP}
</PRE>