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
            Console.WriteLine("\r\n \r\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("            ############################################################");
            Console.WriteLine("            ############################################################");
            Console.WriteLine("            ####                                                    ####");
            Console.WriteLine("            ####      Welcome to the 2021 Christmas Show!           ####");
            Console.Write("            ####"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("       -Food, drinks, music and entertainment!");
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("      ####");
            Console.WriteLine("            ####                                                    ####");
            Console.WriteLine("            ############################################################");
            Console.WriteLine("            ############################################################");

            Console.WriteLine("\r\n");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("            Choose your option:");
            Console.WriteLine(@"
                Add                        Add a customer to the Christmas Show!
                Remove                     Remove a customer
                View                       View all customers
                Discount                   Generate a discount code
                Menu                       See your options
                Exit                       Exit the command line application");

            Console.Write("\r\n \r\n >");

            ChristmasShow _show = new();

            string UserInput = Console.ReadLine();

            while (!UserInput.Equals("") && !UserInput.ToLower().Equals("exit"))
            {
            if (UserInput.StartsWith("Add") || UserInput.StartsWith("add"))
            {
                _show.AddCustomer();
            }
            else if (UserInput.StartsWith("Remove") || UserInput.StartsWith("remove"))
            {
                _show.Remove();
            }
            else if (UserInput.StartsWith("View") || UserInput.StartsWith("view"))
            {
                _show.ViewCustomers();
            }
            else if (UserInput.StartsWith("Discount") || UserInput.StartsWith("discount"))
            {
                _show.Discount();
            }
            else if (UserInput.StartsWith("Menu") || UserInput.StartsWith("menu"))
            {
                _show.Menu();
            }
            else if (UserInput.StartsWith("Exit") || UserInput.StartsWith("exit"))
            {
                _show.Exit();
            }
            else
            {
                Console.WriteLine("Try another option!");
            }
                Console.Write("\r\n \r\n >");
                UserInput = Console.ReadLine();
            }
        }
    }
}

