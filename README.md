# PMS.NEXOxx
Nexo Retailer implementation
That implementation currently supports Nexo Retailer 3.0 and all available messages.

# myXSD and XSDEx
These are tools created to export efficiently NEXO Retailer XSD to C#
Classes exported by these tools are used inside PMS.NEXO integrated inside NEXO_XX_SHARED folders


TO USE ANY OF THESE PACKAGES YOU MUST ALSO DOWNLOAD PMS.COMMON EITHER FROM GITHUB OR NUGET


This library supports both Nexo Retailer 3.0 and 3.1 though not dynamically (you must recompile to change the library).
Both library classes are available directly inside the code.

To use Retailer 3.0 or 3.1 you must go to the project properties (NEXO, NEXO35 and NEXOSIMULATOR) and set the compilation variables (inside "Build" for C# projects, inside "Compile"->Advanced Compile Options) to NEXO30 to compile in Retailer 3.0 and NEXO31 to compile using Retailer 3.1.

>>> PMS.NEXOSALE <<<
Using these libraries allows implementing Nexo Retailer but leaves you with the burden of creating your interface within your application.
It you wish to QUICKLY start with Nexo you can use PMS.NEXOSALE package which allows interfacing your .NET (or not using the COM solution) with 4 lines of code.
PMS.NEXOSALE is a complete solution giving access to all functions inside these libraries without even having to create any window or specific code and is used in solutions on the market.
PMS.NEXOSALE (like PMS.COMMON and all PMS.NEXOxx components) is available on Github but also as a nuget package and can be used as a .NET compoment as well as a COM component (for languages not supporting .NET).




Releasenotes:
3.0.2
-----
- Fixed a bug inside NEXO 3.0 and 3.1
- Update NexoBuilder and NexoSimulator to avoid crashing when editing a response
- Updated NexoSimulator to allow sending RAW request and managed requests from the XML entry field

3.0.1
-----
- Fixed a bug which prevented the ReponseType to be set appropriately

2.0.14
------
- PMS.NEXO no longer exists
. It has been replaced by PMS.NEXO30 running Nexo Retailer 3.0 and PMS.NEXO31 running Nexo Retailer 3.1, both using .NET 4.7.
. PMS.NEXO35 still runs Nexo Retailer 3.0 using .NET 3.5.

-  NEXOSIMULATOR
. As for PMS.NEXO 2 versions have been created for Retailer 3.0 and Retailer 3.1.


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