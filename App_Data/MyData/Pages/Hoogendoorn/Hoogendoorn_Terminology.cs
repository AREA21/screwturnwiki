Jargon-Terminology
procm|2015/11/24 12:06:38
##PAGE##
{TOC}

=== General===
<PRE>
* '''iRS'''/'''ERS-3''' - iSii Regel Station
* '''iBS''' - iSii Bediening Station
* '''Greenbox'''/iSii Compact - small version Web variant

* '''Aspirator''' = '''Meetbox'''

* '''GMP''' - Gui Management Process

* '''Windows Embedded''' (XPe, Win7e...)
** '''EWF''' - '''E'''nhanced '''W'''rite '''F'''ilter

* '''HAF''' - '''H'''orizontal '''A'''ir '''F'''low

* '''PH''' - [https://en.wikipedia.org/wiki/PH]
** Zuur(NL), Acidity(EN)

* '''EC''' - [http://en.wikipedia.org/wiki/Electrical_conductivity_meter]
** Meest(NL), Fertilizer(EN) 

</PRE>

=== iSii===
'''Acronyms'''
<PRE>
SCM - Software Componenten Model
IPC - Inter Proces Communicatie
PMA - Proces Module Architectuur

OWP - Ontwikkelingsplan
PgDb - Process groep database
GMP - GUI management process (Expose BL to GUI)

EBS - ECONOMIC Base Station
ERS - ECONOMIC Control Station
IPC - Inter Process Communication

LTR - Long Term Registration Process
High - High Priority
Low - Low Priority
</PRE>

'''Definitions'''
<PRE>
'''Background system'''
A collection of Windows Services on the EBS that belong to the ECONOMIC system.

'''Data block'''
A data structure to store settings of a control process. 

'''HDMP.exe'''
The Historical Data Management Process is responsible for the historical data that’s available in the data acquisition files. 
When another process needs historical data the process requests this information by sending a specific message to HDMP.
 
'''PDAMP.exe'''
The Primary Data Acquisition Management Process is responsible for requesting and storing the values of different control 
settings into the data acquisition files.

'''SysMgr.exe'''
The System Manager controls all the configuration data that is available in the registry. The system Manager is also responsible 
for starting, stopping and monitoring all the other services of the ECONOMIC.

'''NodeMgr.exe'''
The node manager is the router of the ECONOMIC and routes all the IPC messages between the different processes. If a process wants 
to send a message to another process it send the message to the node manager and the node manager delivers the message to the destination process.

'''CIMP.exe'''
The Configuration Information Management Process is responsible for the information that’s available in the control process databases. 
Other process can request this information by sending a specific message to the CIMP process.

'''GMP.exe'''
The GUI management process forms a front end for the business layer. All interactions from the user interface travel through GMP. 
GMP is a web server with all sorts of url handlers for different tasks.

'''AMP.exe'''
The Alarm Management Process is responsible for receiving and handling alarms that come from different control processes.

</PRE>

