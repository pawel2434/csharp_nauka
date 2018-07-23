using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMISample
{
    public class MyWMIQuery
    {
        private const string V = "CurrentTemperature";
        private const string V1 = "CurrentTemperature";

        public static object MessageBox { get; private set; }
        public static int queryObjV { get; private set; }

        public static void Main()
        {
            int te = 0;
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\WMI",
                    "SELECT * FROM MSAcpi_ThermalZoneTemperature");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("MSAcpi_ThermalZoneTemperature instance");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("CurrentTemperature: {0}", queryObjV);
                    int t = Convert.ToInt32(queryObjV.ToString());
                    t = (t / 10) - 273;
                    te = t;
                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
            }
            Console.WriteLine("Temp : {0}", te);
            Console.Read();
        }
    }
}