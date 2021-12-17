using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp
{
    internal class ChristmasShow
    {
        /// <summary>
        /// Metoden frågar efter förnamn, efternamn, mail, ålder och allergier.
        /// Gör en enklare åldersvalidering då det krävs att man är minst 18 år.
        /// Frågar om du är allergisk, om ja mot vad.
        /// All information sparas i customers.txt. Förnamn, efternamn och mail sparas i viewcustomers.txt.
        /// </summary>
        
        internal void AddCustomer()
        {
            CustomerModel _customer = new(); 

            Console.WriteLine("First name:");
            _customer.FirstName = Console.ReadLine();
            Console.WriteLine("\r");

            Console.WriteLine("Last name:");
            _customer.LastName = Console.ReadLine();
            Console.WriteLine("\r");

            Console.WriteLine("Email:");
            _customer.Email = Console.ReadLine();
            Console.WriteLine("\r");

            Console.WriteLine("Age:");
            _customer.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\r");

            if(_customer.Age < 18)
            {
                Console.WriteLine("You have to be 18 years old to attend the Christmas Show! ");
                Environment.Exit(0);
            }
            else if(_customer.Age > 18 || _customer.Age == 18)
            {
                Console.WriteLine("Food allergy [Yes / No]:");
                _customer.FoodAllergy = Console.ReadLine();
                Console.WriteLine("\r");

                File.AppendAllText(@"viewcustomers.txt", $"{_customer.FirstName} {_customer.LastName}, {_customer.Email} {Environment.NewLine}");
            }

            if (_customer.FoodAllergy == "Yes" || (_customer.FoodAllergy == "yes"))
            {
                Console.WriteLine("What are you allergic to?");
                _customer.InputFoodAllergy = Console.ReadLine();
                Console.WriteLine("\r\n \r");

                Console.WriteLine(@"We will make sure not to serve you any " + $"{_customer.InputFoodAllergy}" + "!");
                Console.WriteLine("\r");

                File.AppendAllText(@"customers.txt", $"{_customer.FirstName} {_customer.LastName}, {_customer.Email}, {_customer.Age}, {_customer.InputFoodAllergy}{Environment.NewLine}");
                Console.WriteLine(_customer.FirstName + " " + _customer.LastName + ", " + _customer.Email + ", " + _customer.Age + " years old and allergic to " + _customer.InputFoodAllergy + "," + " have been added!");

            } else if (_customer.FoodAllergy == "No" || (_customer.FoodAllergy == "no"))
            {
                Console.WriteLine("\r\n \r");
                Console.WriteLine("Then you can enjoy our buffet!");
                Console.WriteLine("\r");

                File.AppendAllText(@"customers.txt", $"{_customer.FirstName} {_customer.LastName}, {_customer.Email}, {_customer.Age}{Environment.NewLine}");
                Console.WriteLine(_customer.FirstName + " " + _customer.LastName + ", " + _customer.Email + " and " + _customer.Age + " years old " + "have been added!");
            }
            else
            {
                Console.WriteLine("You have to type Yes or No! Type Add to start over!");
            }
        }

        /// <summary>
        /// Tar bort Customer genom att matcha användarens input mot Customers i viewcustomers.txt.
        /// </summary>
        
        internal void Remove() 
        {
            ViewCustomers();
            Console.WriteLine("\r");

            Console.WriteLine("Type the First Name and the Last Name of the customer you want to remove:");
            string strFilePath = "viewcustomers.txt";
            string strSearchText = Console.ReadLine();
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(strFilePath);
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!strOldText.Contains(strSearchText))
                {
                    n += strOldText + Environment.NewLine;
                }
            }
            sr.Close();
            File.WriteAllText(strFilePath, n);
            Console.WriteLine("\r");

            Console.WriteLine(strSearchText + " have been removed from the Christmas Show!");
        }

        /// <summary>
        /// Visar upp all text i viewcustomers.txt, dvs alla Customers.
        /// </summary>

        internal void ViewCustomers()
        {
            string file = @"viewcustomers.txt";

            if (File.Exists(file))
            {
                string text = File.ReadAllText(file);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("The Christmas Show has 0 Customers!");
            }
        }

        /// <summary>
        /// Genererar en Guid som är unik och som fungerar som en discount code.
        /// </summary>

        internal void Discount()
        {
            Console.WriteLine(@"Your Discount Code is" + " " + Guid.NewGuid() + ".");
            Console.WriteLine("This will get you a 20% discount at the bar!");
        }

        /// <summary>
        /// Tar fram nedanstående meny.
        /// </summary>

        readonly string menu = @"
                Add                        Add a customer to the Christmas Show!
                Remove                     Remove a customer
                View                       View all customers
                Discount                   Generate a discount code
                Menu                       See your options
                Exit                       Exit the command line application";

        internal void Menu()
        {
            Console.WriteLine(menu);
        }

        /// <summary>
        /// Avslutar applikationen.
        /// </summary>

        internal void Exit()
        {
            Environment.Exit(0);
        }
    }
}
