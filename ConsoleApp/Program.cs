using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTable
{
    class Program
    {
        static void Main(string[] args)
        {
            ChristmasTable app = new ChristmasTable();

            Console.WriteLine("\r\n \r\n     Welcome to the 2021 Christmas table! \r\n \r\n");
            Console.WriteLine("     Choose your option:");
            Console.WriteLine(@"
        Add [First Name, Last Name, Email and Allergies]        Add a New Customer to the Christmas Table
        Remove [# Number]                                       Remove a Customer
        View                                                    View all Customers
        Exit                                                    Close the Consol Application");

            Console.Write("\r\n \r\n >");

            string inputLine = Console.ReadLine();
           while (!inputLine.Equals("") && !inputLine.ToLower().Equals("exit"))
            {


            }









     
           inputLine = Console.ReadLine();

        }
    }
}