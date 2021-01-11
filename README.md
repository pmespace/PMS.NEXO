# PMS.NEXO
Nexo Retailer implementation
That implementation currently supports Nexo Retailer 3.0 and all available messages.

# myXSD and XSDEx
These are tools created to export efficiently NEXO Retailer XSD to C#
Classes exported by these tools are used inside PMS.NEXO integrated inside NEXO_XX_SHARED folders



TO USE ANY OF THESE PACKAGES YOU MUST ALSO DOWNLOAD PMS.COMMON EITHER FROM GITHUB OR NUGET


This library supports both Nexo Retailer 3.0 and 3.1 though not dynamically (you must recompile to change the library).
Both library classes are available directly inside the code.

To use Retailer 3.0 or 3.1 you must go to the project properties (NEXO, NEXO35 and NEXOSIMULATOR) and set the compilation variables (inside "Build" for C# projects, inside "Compile"->Advanced Compile Options) to NEXO30 to compile in Retailer 3.0 and NEXO31 to compile using Retailer 3.1.

Releasenotes:

2.0.12
------
- PMS.NEXO
. Added the possibility to manage connections with an OleDB database. Scripts can be found inside the NEXO_SERVER_SHARED (for SQL Server). It is still possible to not use any database. A sample database is provided as an ACCESS one.
. All messages are now stored inside the database (if any).

-  NEXOSIMULATOR
. Now supports the PMS.NEXO database.
. Adds the possibility to launch a pre-connection message and receive a reply. That is used to reach POI connected to a GPRS/3G/... private network whose access has been authorized by the network provider (this is possible to do that in France with Lyra Network). That feature may be useless to anybody else, do not ckeck the "Use pre-connection" if you connect to your POI over your network, it's not fully tested in that case.
. Refer to BUILDER section whose functions are supported inside the simulator.

- BUILDER
. A new application allowing to create any Nexo Retailer message using graphically. Once validated the message is available as an XML string inside the clipboard.