using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp
{
    public class ChristmasShow
    {
        readonly string menu = @"
                Add                        Add a customer to the Christmas Show!
                Remove                     Remove a customer
                View                       View all customers
                Discount                   Generate a discount code
                Menu                       See your options
                Exit                       Exit the command line application";

        public void Menu()
        {
            Console.WriteLine(menu);
        }

        public void AddCustomer()
        {
            Customer customer = new Customer(); 

            Console.WriteLine("First name:");
            customer.FirstName = Console.ReadLine();
            Console.WriteLine("\r");

            Console.WriteLine("Last name:");
            customer.LastName = Console.ReadLine();
            Console.WriteLine("\r");

            Console.WriteLine("Email:");
            customer.Email = Console.ReadLine();
            Console.WriteLine("\r");

            Console.WriteLine("Age:");
            customer.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\r");

            if(customer.Age < 18)
            {
                Console.WriteLine("You have to be 18 years old to attend the Christmas Show! ");
                Environment.Exit(0);
            }
            else if(customer.Age > 18 || customer.Age == 18)
            {
                Console.WriteLine("Food allergy [Yes / No]:");
                customer.FoodAllergy = Console.ReadLine();
                Console.WriteLine("\r");

                File.AppendAllText(@"viewcustomers.txt", $"{customer.FirstName} {customer.LastName}, {customer.Email} {Environment.NewLine}");
            }

            if (customer.FoodAllergy == "Yes" || (customer.FoodAllergy == "yes"))
            {
                Console.WriteLine("What are you allergic to?");
                customer.InputFoodAllergy = Console.ReadLine();
                Console.WriteLine("\r\n \r");

                Console.WriteLine(@"We will make sure not to serve you any " + $"{customer.InputFoodAllergy}" + "!");
                Console.WriteLine("\r");

                File.AppendAllText(@"customers.txt", $"{customer.FirstName} {customer.LastName}, {customer.Email}, {customer.Age}, {customer.InputFoodAllergy}{Environment.NewLine}");
                Console.WriteLine(customer.FirstName + " " + customer.LastName + ", " + customer.Email + ", " + customer.Age + " years old and allergic to " + customer.InputFoodAllergy + "," + " have been added!");

            } else if (customer.FoodAllergy == "No" || (customer.FoodAllergy == "no"))
            {
                Console.WriteLine("\r\n \r");
                Console.WriteLine("Then you can enjoy our buffet!");
                Console.WriteLine("\r");

                File.AppendAllText(@"customers.txt", $"{customer.FirstName} {customer.LastName}, {customer.Email}, {customer.Age}{Environment.NewLine}");
                Console.WriteLine(customer.FirstName + " " + customer.LastName + ", " + customer.Email + " and " + customer.Age + " years old " + "have been added!");
            }
            else
            {
                Console.WriteLine("You have to type Yes or No! Type Add to start over!");
            }
        }

        public void Remove()
        {
            ViewCustomers();
            Console.WriteLine("\r");

            Console.WriteLine("Type the First and Last Name of the customer you want to remove:");
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

        public void ViewCustomers()
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

        public void Discount()
        {
            {
                Console.WriteLine(@"Your Discount Code is" + " " + Guid.NewGuid() + ".");
                Console.WriteLine("This will get you a 20% discount at the bar!");
            }
        }
    }
}
