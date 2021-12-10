using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasShow
{
    class Program
    {
        static void Main(string[] args)
        {
            ChristmasShow app = new ChristmasShow();

            Console.WriteLine("\r\n \r\n     Welcome to the 2021 Christmas Show! \r\n \r\n");
            Console.WriteLine("     Choose your option:");
            Console.WriteLine(@"
        Add [First Name, Last Name, Email and Chair Number]         Add a New Customer to the Christmas Show
        Remove [# Number]                                           Remove a Customer
        View                                                        View all Customers
        Exit                                                        Close the Consol Application");

            Console.Write("\r\n \r\n >");

            string inputLine = Console.ReadLine();
           while (!inputLine.Equals("") && !inputLine.ToLower().Equals("exit"))
            {


            }









     
           inputLine = Console.ReadLine();

        }
    }
}