KPN-NEC Deploy New Release
celio|2010/04/18 22:32:58|(((KPN-NEC)))(((KPN Nieuw Electronisch Contract)))
##PAGE##
'''Building & deploy a Nec release'''!!
----

Set the correct release version(eg. 3.0-rc4) for all projects, editing '''project.xml''' file.

#'''Fase1'''
## '''Shared'''
##*maven-> clean jar:deploy
## '''Server'''
##* Set the dependency '''Shared ''' to the correct version
##* maven-> clean ejb:deploy
## '''Web'''
##* Zet the dependency '''Shared ''' & '''Server ''' to the correct version
##* maven-> clean war:deploy
## '''Webservice'''
##* Set the dependency '''Shared ''' & '''Server ''' to the correct version
##* maven-> clean war:deploy
## '''Application'''
##* Set the dependency '''Shared ''', '''Server ''', '''Web ''' & '''Webservice ''' to the correct version 
##* maven-> clean ear weblogic:appc ejb-stubs-deploy serversite:deploy
## '''Client-API'''
##* Set the dependency '''Shared''' & '''App''' to the correct version
##* maven-> clean jar:deploy
## '''Scripting'''
##* Set the dependency '''Shared''', '''App''' & '''Client-Api''' to the correct version
##* maven-> clean jar:deploy
## '''Applet'''
##* Set the dependency '''Shared''', '''App''', '''Client-Api''' & '''Scripting''' to the correct version
##* .../nec/src/nl/mvsd/nec/ClientConstant.java updaten versie	
##* maven-> clean jar clientsite:deploy
## '''Security'''
##* maven-> build.mdf jar:deploy {br}{br}
###*'''Install Nec 3 security providers''' {br}...the setup of Bea Weblogic Server, incl. installation and configuration of the Nec Security Providers. {br}{br}
###*# Copy the file “\NEC\Server\nec-security-<version>.jar “ to “\bea\weblogic81\server\lib\mbeantypes”.{br}{br} 
###*# Start Bea Weblogic service, {br}
###*# Start Bea Weblogic console: surf to http://localhost:7001/console {br}{br}
###*# Log in to Bea Weblogic console (Administrator) {br}{br}
###*# Choose in the Nec tree -> Security -> Realms {br}{br}
###*# Choose Configure a new realm 
###*#* Name: NecRealm
###*#* Click “create” {br}{br}
###*# Choose in the Nec tree -> Security -> Realms -> NecRealm -> Providers -> Adjudication 
###*#* Choose Create a new Default Adjudicator
###*#* Click “create” {br}{br}
###*# Do the same for: 
###*#* Authentication providers: Configure a new Default Identity Asserter
###*#* Authentication providers: Configure a new Nec Authenticator
###*#* Authorizers:		Configure a new Default Authorizer
###*#* Credential Mappers:	Configure a new Default Credential Mapper
###*#* Role Mappers:		Configure a new Default Role Mapper {br}{br}
###*# Choose in the Nec tree 
###*#* Click the underneath link “View Domain-wide Security Settings”
###*#* Default realm: NecRealm
###*#* Click “apply” {br}{br}
###*# Restart the “beasvc nec_<server>” service (in Services in Administrative tools) 
###*#* Wait 1 minuut.
###*#* Look at \bea\user_projects\nec\<server>\<server>.log to see if the restart is succeded.{br}{br}
###* source:[http://intranet.mvsd.nl/sites/necsla/Shared Documents/Handleidingen/NEC3- Server installatie en beheer handleiding.doc|Install Security Providers(Bea Weblogic Console)] {br}{br}
## '''Releasebundle'''
##* Set the dependency '''Shared''', '''App''', '''Client-Api''', '''scripting''' & '''Applet''' to the correct version
##* maven-> clean releasebundle {br}{br}
::'''Now we have a Release(zip) file with the Server & Client site zips within it.'''

----
# '''Fase2'''
## '''Server'''
##* copy file "nec-app-x.x-xxx.ear" naar Server folder
##* delete current application in Weblogic & make new deployment for "nec-app-x.x-xxx.ear"
## '''Site'''
##* Deleten van alle Jar's behalve '''nec_scripting_config.jar'''
##* Koppieren van alle Jar's files behalve '''nec_scripting_config.jar'''	
## '''Merge settings'''
##* WinMerge - vergelijken oude instellingen met de nieuwe en overnemen wat nodige is.

----
§§(celio,2009/02/27 14:05:02)§§