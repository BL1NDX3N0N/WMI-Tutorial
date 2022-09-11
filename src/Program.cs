using System;
using System.Text;
using System.Management;

namespace WMI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WMI Component Console\n");
            
            while (true)
            {
                Console.Write("Component>");
                Console.WriteLine(WMIQuery(Console.ReadLine()));
            }
        }

        private static string WMIQuery(string command)
        {
            try
            {
                string[] parsedComponent = command.Split(' ');

                string commandNamespace = "root\\CIMV2",
                    commandClass = parsedComponent[0],
                    commandMethod = parsedComponent[1];

                ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                    commandNamespace, "SELECT * FROM " + commandClass);

                var componentBuffer = new StringBuilder();

                foreach (ManagementObject managementObject in searcher.Get())
                    componentBuffer.Append(managementObject[commandMethod].ToString() + '\n');

                return componentBuffer.ToString();
            }
            catch (Exception)
            {
                return "Unknown component.\n";
            }
        }
    }
}
