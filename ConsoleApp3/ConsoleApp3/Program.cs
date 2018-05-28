using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> openWith =
                new Dictionary<string, string>();

            openWith.Add("txt", "notabet.exe");
            openWith.Add("bmb", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"Txt\" already exists.");
            }
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key =\"rtf\", value = {0}.", openWith["rtf"]);

            openWith["doc"] = "winword.exe";

            try
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }
            string value = "";
            if (openWith.TryGetValue("tif", out value))
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", value);

            }
            else
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]);

            }
            Console.WriteLine();
            foreach( KeyValuePair<string, string> kvp in openWith )
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            Dictionary<string, string>.ValueCollection valueColl = openWith.Values;
            Console.WriteLine();
            foreach( string s in valueColl )
            {
                Console.WriteLine("Value = {0}", s);
            }
            Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;
            Console.WriteLine();
            foreach( string s in keyColl )
            {
                Console.WriteLine("Key = {0}", s);
            }
            Console.WriteLine("\nRemove(\"doc\")");
            openWith.Remove("doc");
            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is no found.");
            }
            Console.ReadKey();











            
           

        }
    }
}
