using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChristmasShow Show = new();

            Console.WriteLine("\r\n \r\n");
            Console.WriteLine("            Welcome to the 2021 Christmas Show!");
            Console.WriteLine("            - Food, drinks, music and entertainment! \r\n \r\n");
            Console.WriteLine("             Choose your option:");
            Console.WriteLine(@"
                Add                        Add a customer to the Christmas Show!
                Remove                     Remove a customer
                View                       View all customers
                Discount                   Generate a discount code
                Menu                       See your options
                Exit                       Exit the command line application");

            Console.Write("\r\n \r\n >");

                    string UserInput = Console.ReadLine();

                    while (!UserInput.Equals("") && !UserInput.ToLower().Equals("exit"))
                {
                    if (UserInput.StartsWith("Add") || UserInput.StartsWith("add"))
                {
                    Show.AddCustomer();
                }
                    else if (UserInput.StartsWith("Remove") || UserInput.StartsWith("remove"))
                {
                    Show.Remove();
                }
                    else if (UserInput.StartsWith("View") || UserInput.StartsWith("view"))
                {
                    Show.ViewCustomers();
                }
                    else if (UserInput.StartsWith("Discount") || UserInput.StartsWith("discount"))
                {
                    Show.Discount();
                }
                    else if (UserInput.StartsWith("Menu") || UserInput.StartsWith("menu"))
                {
                    Show.Menu();
                }
                    else if (UserInput.StartsWith("Exit") || UserInput.StartsWith("exit"))
                {
                    Show.Exit();
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

