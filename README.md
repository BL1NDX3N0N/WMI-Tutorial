# WMI Tutorial
A tutorial on querying system information from [Windows Management Instrumentation (WMI)](https://docs.microsoft.com/en-us/windows/desktop/wmisdk/wmi-start-page) in .NET.

Working on a library needing the ability to detect if it is executing on a virtual environments I resorted to using WMI to create my red pill functions. Finding great use out of WMI I have decided to create this simple tutorial for others to reference and learn from.

WMI is capable of returning information about a Windows system and the software that runs on it by refering to a specific namespace, class, and method. For example, the *root\CIMV2* namespace contains several classes pertaining to the systems current hardware configuration such as the motherboard, CPU, RAM, NIC (Network Interface Card), storage, etc.. Even specific BIOS and hardware vendor/manufacturer information can be queried from WMI as well. You can find new namespaces and their class through [PowerShell](https://www.powershellmagazine.com/2013/10/18/pstip-list-all-wmi-namespaces-on-a-system/), [WMI Code Creator](https://www.microsoft.com/en-us/download/details.aspx?id=8572), or online. For a list of classes you will have to do the same as above as if you were looking for a new namespace.

## Using
The command structure is `[class] [method]`. So we will type in and execute `win32_processor name` which for me returns:

**Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz**.

You can find more classes and methods with their descriptions under the root\CIMV2 namespace [here](https://docs.microsoft.com/en-us/windows/desktop/cimwin32prov/computer-system-hardware-classes).
