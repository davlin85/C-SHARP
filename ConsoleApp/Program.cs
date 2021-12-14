using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChristmasShow Show = new();

            Console.WriteLine("\r\n \r\n     Welcome to the 2021 Christmas Show! \r\n \r\n");
            Console.WriteLine("     Choose your option:");
            Console.WriteLine(@"
        Add                        Add a customer to the Christmas Show!
        Remove                     Remove a customer
        View                       View all customers
        Discount                   Generate a discount code
        Menu                       See your options
        Exit                       Exit the command line application");

            Console.Write("\r\n \r\n >");

            string inputLine = Console.ReadLine();
            while (!inputLine.Equals("") && !inputLine.ToLower().Equals("exit"))
            {
                if (inputLine.StartsWith("Add") || inputLine.StartsWith("add"))
                {
                    Show.AddCustomer();
                }
                else if (inputLine.StartsWith("Remove") || inputLine.StartsWith("remove"))
                {
                    Show.Remove();
                }
                else if (inputLine.StartsWith("View") || inputLine.StartsWith("view"))
                {
                    Show.ViewCustomers();
                }
                else if (inputLine.StartsWith("Menu") || inputLine.StartsWith("menu"))
                {
                    Show.Menu();
                }
                else
                {
                    Console.WriteLine("Try another option!");
                }

                Console.Write("\r\n \r\n >");
                inputLine = Console.ReadLine();
            }
        }
    }
}

