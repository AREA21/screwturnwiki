NexusVerus Index
procm|2016/06/07 18:00:51
##PAGE##
'''NexusVerus '''
: summary:...

{TOC}

=== Contacten & URLs===
<PRE>
{| cellspacing="0" cellpadding="5" border="1"
| colspan="5" align="center" style="background-color: #000000; color: #FFFFFF;" | '''Contacts'''
|- 
| rowspan="2" style="background-color: #000000; color: #FFFFFF;" | '''NexusVerus'''
| Sven-Olav Montijn || sven.olav.montijn@nexusverus.nl || +31642505688 || directeur 
|- 
| Mennolt Bosch     || mennolt.bosch@nexusverus.nl     || ???          || Partner
|-
| rowspan="2" style="background-color: #000000; color: #FFFFFF;" | '''Digidentity '''
| Manon Borsboom    || mborsboom@digidentity.eu        || ???          || Salesmanager
|-
| Benoist Claassen  || bclaassen@digidentity.eu        || +31622061111 || Lead developer
|- 
| rowspan="1" style="background-color: #000000; color: #FFFFFF;" | '''NewViews/Dizzydata'''
| Tim Paymans       || tpaymans@newviews.nl            || ???          || Technical Lead
|
|-
| rowspan="1" style="background-color: #000000; color: #FFFFFF;" | '''2020vision'''
| Rob Berting       || rob.berting@2020vision.nl       || ???          || ???
|
|}


'''Testomgeving(en'''): 
* Dizzydata(NewViews): [http://demo-client.dizzydata.com/welcome.aspx]

</PRE>
{TOP}

=== Activiteiten===
<PRE>
==== Projectbeheer====
* Projectplan
* Requirements/Eisenpakket
** bijv. definiëren Interfaces tussen (Digidentiy, Dizzydata, 2020Vision)
** vergelijkende onderzoek: fysieke servers vs Cloud IaaS/PaaS(Windows Azure vs Amazon EC2...) 
* Kosten inschatting (apparatuur, software en ict-infrastructuur)
* Functioneel Ontwerp
* Technisch Ontwerp
* Communicatie
** Telefoon /e-mail
** vergaderingen

==== Infrastructuur omgeving (OTAP wenselijk)====
* SMTP mail service
** Aanvragen/Installeren benodigde certificaten (SSL, PKI Overheid ???)
* Tools
** Code versiebeheer/Repository (SVN, GITHub)
** Project-Issue Management
*** [http://www.axosoft.com]
**** [http://www.ontimenow.com/university/free-courses]
*** [http://www.atlassian.com/]
* Regelen/inrichten toegang voor testomgeving(en)
* Werkpleken (development) 
** 
* Backup & beveiliging 
* Monitoren omgeving (SLA)
* Documenteren omgeving

==== Ontwikkeling====
* Wave 1
** Ophalen E-mail
*** Controle Leverancier Registratie (andere vereisten??)
** Implementatie Interface (nieuw) Digidentity SAML service & Leverancier dataset)
*** Ophalen Leverancier dataset, incl. cert. Publieke Sleutel
*** Controle Leverancier & Certificaat (4uur window, CRL)
** Koppelen Leverancier E-mail 
** Ontsleutelen E-mail (worden bijlages ook versleutelt??)
** Ontwikkelen Gemeente Profiel module (wettelijke & specifiek factuurvereisten)
** Definiëren implementatie Interface Dizzydata service
*** Inrichten beveiligde & asynchrone berichtuitwisseling kanaal(Queue mechanisme???)
**** Versturen PDF factuur
**** Ophalen Dizzydata Output(verwerkte PDF factuur)
**** Verifiëren Dizzydata Output
**** Controle Factuurvereisten, Gemeente (Business Rules) Profiel
**** Genereren (geldige) Factuur, Master formaat(BST)
* Wave 2
** Converteren factuur Master formaat(BST) naar standaard UBL2.0 
** Integratie met 2020vision a.d.h.v. UBL2.o 

</PRE>

'''Legenda:'''
CRL- Certificate Revocation List 
UBL- Universal Business Language
{TOP}

=== Aandrachtpunten===
<PRE>
* TEAM stand van zaken? 
** competenties & taakverdeling 

* Samenwerking constructie 
** Toeslag + betaling gemaakte kosten
** [http://www.uwv.nl/Particulieren/weer_aan_het_werk/solliciteren.aspx|UWV Proefplaatsing]

* Integratie Factuurpor​tal - 2020 Vision
** vergaren specs  

* Definitief maken Requirements & Businessrules (Leverancier, Factuur(velden), Klant et cetera)
** reviewen van bestaande documenten & samenhangende geheel maken

* Kopie Maasvlakte2 media

* Kennismaking met Lionel Martijn, LBM groep


* [http://bytes.com/topic/asp-net/answers/316901-encrypted-mail-asp-net|Encrypted mail in ASP.NET]
** [http://www.emailarchitect.net/easendmail/kb/vbnet.aspx?cat=9|Send Email with Digital Signature in VB.NET - S/MIME('''S'''ecure/'''M'''ultipurpose '''I'''nternet '''M'''ail '''E'''xtensions)]
** [http://en.wikipedia.org/wiki/Secure_Messaging|Secure Messaging/Secure Mail platform]
** [http://technet.microsoft.com/en-us/library/aa995740(v=exchg.65).aspx|Microsoft Understanding S/MIME]
** [http://en.wikipedia.org/wiki/Pretty_Good_Privacy|Pretty Good Privacy]
** [www.eldos.com/sbb/desc-pgp-spec.php|SecureBlackbox Library]

'''Vragen''': Integratie NexusVerus(FactuurPortaal) -> DigIdentity

* Welke dienst(en) heeft NexusVerus van DigIdentity nodig?
** eSigning - documenten(pdf) voorzien van rechtsgeldige digitale Handtekening
** eHerkening??
*** SAML factory/ implementatie nodig
*** Wat is/doet een eHerkenningsmakelaar precies?
** 

* Hoe wordt de certificaat geïnstalleerd? Welke e-mail clients worden ondersteund?

* Van e-mail Encryption Protocols (PGP, S/MIME, TLS) kan gebruikt worden? 

* Welke tools/libraries zijn er om de versleutelde e-mails te kunnen lezen? 

* Bestaat een Test omgeving? Hoe wordt de toegang tot de omgeving regelt?

* Welke technieken & methoden?
** bijv.: om Digidentity in te framen in de Nexusverus (FactuurTotaal) portaal, IFRAME?
((({@code-xml: <iframe id="MyIFrame" runat="server" scrolling="auto" width="100%" height="768px" frameborder="0"></iframe> @}
'''Then in the code behind:''' <nowiki> MyIFrame.Attributes["src"] = "Webpage link"; </nowiki> 
)))


'''AuthnRequest_voorbeeldbericht.xml'''
{@code-xml: <?xml version="1.0" encoding="UTF-8"?>
<samlp:AuthnRequest xmlns:saml="urn:oasis:names:tc:SAML:2.0:assertion"
		xmlns:samlp="urn:oasis:names:tc:SAML:2.0:protocol"
		ID="_c392374de287c092408062878fbc23edf9bb3508"
		AssertionConsumerServiceIndex="1" IssueInstant="2011-08-31T08:30:56+02:00" Version="2.0"
		ForceAuthn="false" ProviderName="DigiD">
	<ds:Signature xmlns:ds="http://www.w3.org/2000/09/xmldsig#">
		<ds:SignedInfo>
			<ds:CanonicalizationMethod Algorithm="http://www.w3.org/2001/10/xml-exc-c14n#"/>
			<ds:SignatureMethod Algorithm="http://www.w3.org/2001/04/xmldsig-more#rsasha256"/>
			<ds:Reference URI="#_c392374de287c092408062878fbc23edf9bb3508">
				<ds:Transforms>
					<ds:Transform Algorithm="http://www.w3.org/2000/09/xmldsig#envelopedsignature"/>
					<ds:Transform Algorithm="http://www.w3.org/2001/10/xml-exc-c14n#">
						<ec:InclusiveNamespaces xmlns:ec="http://www.w3.org/2001/10/xml-exc-c14n#"PrefixList="ds saml samlp xs"/>
					</ds:Transform>
				</ds:Transforms>
				<ds:DigestMethod Algorithm="http://www.w3.org/2001/04/xmlenc#sha256"/>
				<ds:DigestValue>UjQO9aUlQtJ1kn1x90MnSJR074wuyfulpQk2yl3kZ+c=</ds:DigestValue>
			</ds:Reference>
		</ds:SignedInfo>
		<ds:SignatureValue>
			ifpk2qY2W1nCW76xr05wV2/tnJ25FGZgQNOAs2uW5qatg4Pxo+WYrVxhoeYQFh4M
			6a2vGqUX8qWp4FWIeEsPa+vlffn7OcujkczCzVyGn9OdI8CSlGxov6ABEdkUsG9h
			5PIUk7HE+ql1xU7tlrQAk6EYf7WNNTWdGPd/qnaojPVaeKfZoP0BcQAFfZv/3EY3
			UDQv5VJXUnZEZjaD5nECNlac2D4hQpyzTQLDpDXZcUiIP93yleZNHnA/MTMrk6kn
			1ueNTNSqju+cMrntvzS6f0ij93sdQsuY2KJloTaxi64pJfwSG9xNpcTkCkmD+e9l
			OzJgJK7LwbN853McGOVOqw==
		</ds:SignatureValue>
	</ds:Signature>
	<saml:Issuer>http://auth.digidentity.eu/sso/metadata.xml</saml:Issuer>
	<samlp:RequestedAuthnContext Comparison="minimum">
		<saml:AuthnContextClassRef>urn:oasis:names:tc:SAML:2.0:ac:classes:PasswordProtectedTransport</saml:AuthnContextClassRef>
	</samlp:RequestedAuthnContext>
</samlp:AuthnRequest>
@}

</PRE>
{TOP}


=== Omgevingen: Development & Infra===
<PRE>
'''OTAP'''(Ontwikkeling, Test, Acceptatie & Productie) 

* Mail server:
** PoP3 Google Apps(Gmail) 
** SMTP Exchange / Google Apps(Gmail)

* Development env.
** Visual Studio 2010
** WebForms, C# 4.0
** Webservice: REST.API, JSON/XML
** OAUTH v2 API
** compomenten: 
*** Dizzydata, converts documents to data
*** Logius, Digiport
*** KendoUI ??

* Beta env
** Azure http://www.windowsazure.com/en-us/pricing/calculator)


* Extra
** registreren bij Dizzydata nog in beta fase
** aanvragen Digipoort http://www.logius.nl/fileadmin/logius/product/digipoort/aanvraagformulieren/Aanvraagformulier_Digipoort_SOAP_WUS_01.pdf
** aanvragen benodigde certificaaten

</PRE>
{TOP}


=== Fianciele software pakketen===
* Decade
* BCT
* Exact
* Accountview
* Coda
* SAP


{TOP}