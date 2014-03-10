HMailServer
celio|2011/04/19 12:09:23
##PAGE##
=== hMailServer ===
<pre>
handleiding: [http://www.hmailserver.com/documentation/v5.1/?page=overview]
{br}{br}
'''In het kort:'''
Na inloggen heb je links de "domains" die actief zijn, en in het welcome scherm 
kan je een niew domain toevoegen via Add domain... 
(uiteraard na het goed zetten van MX records in dns).

In de domains lijst heb ik 1 test domain toegevoegd (mvsd.numloq.nl) met 
daaronder 1 user (test@mvsd.numloq.nl met password test).
Users toevoegen gebeurt in de accounts lijst onder een domain met de "add" knop,
waarna je een naam en wachtwoord op kan geven voor die user.
Hierna is de user meteen beschikbaar via pop3 en imap4 met als username dus 
het hele email adres en het wachtwoord als opgegeven.
Aliases geef je op in de aliases lijst (heb er een voorbeeld in staan, 
test2@ die naar test@ gaat).{br}{br}
Overige zaken als anti spam, blacklists, grey lists of antivirus kunnen we aan 
zetten als er een noodzaak voor is.
Voorlopig heb ik alleen de zenhaus en spamcop blacklists aan staan, deze houden 
90 a 95% tegen (op numloq zelf gebruik ik alleen die).
</pre>


{TOP}



==WebServer2==

=== Emailadressen op de Numloq server aanmaken ===
<pre>
Het ip adres is 87.253.140.61, die moet je dus opgeven bij transip.
Email adressen toevoegen doe je in de hMailServer Administrator (in de hMailServer groep van het 
startmenu).
Als wachtwoord gebruik je Rood42Haar, dan kom je in dit scherm:


Vervolgens, voor een niew domain voeg je deze toe onder de menu optie domains.
1. domains aan klikken en "Add..." doen.
2. domain naam opgeven.
3. Eventueel in advanced een extern catchall adres aangeven

Dan klik je op save (rechts onder) en is deze toegevoegd in de lijst links en meteen geselecteerd
Als je het domain links aan klinkt kan je instellingen (zoals catchall en domain naam zelf) nog 
veranderen.

Adressen toevoegen doe je vervolgens in accounts, waar je een email adres opgeeft en een password 
in tikt.
Ook hier kan je wat extra opties op geven (mailbox limiet en bv. autoreply bij vakantie, of forwards).

Dan hebben we nog aliases, waar je redirections kan toevoegen, bv. een info@ laten forwarden naar een 
bepaalde gebruiker (kan ook een gebruiker zijn op een ander domain).
En als laatste hebben we distribution lists, waar je maillists kan toevoegen (bv. een info@ naar meerdere 
gebruikers. deze voeg je toe bij members)
</pre>
{TOP}