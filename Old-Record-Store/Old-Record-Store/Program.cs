using System;
using Old_Record_Store.Library;
using System.Collections.Generic;


namespace Old_Record_Stores
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to 'Farro's Garden of Earthly Delights' Record Store: ");
                Console.WriteLine("Please input a number to interact with the menu, type 'exit' to quit the program");
                Console.WriteLine("\ta - Add Customer");
                Console.WriteLine("\tb - Display the Customer List");
                Console.WriteLine("\tc - Search for a Customer");
                Console.WriteLine("\td - Place an Order");
                Console.WriteLine("\te - Exit Software");

                switch (Console.ReadLine())
                {
                    case "a":

                        Console.WriteLine("Please input the customer's name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please input the customer's address: ");
                        string address = Console.ReadLine();
                        Console.WriteLine("Please input the customer's phone: ");
                        string phone = Console.ReadLine();
                        Console.WriteLine("Please input the customer's e-mail: ");
                        string email = Console.ReadLine();
                        Customer.AddCustomer(name, phone, address, email);
                        break;
                    case "b":
                        Console.WriteLine("Displaying current customer list");
                        Customer.DisplayCustomers();
                        Console.WriteLine("Press Any key to go back to main menu");
                        break;
                    case "c":
                        Console.WriteLine("Please input a field to look for a custoemr (name, address, phone, or e-mail");
                        string field = Console.ReadLine();
                        Customer.SeachCustomer(field);
                        Console.WriteLine("Press Any key to go back to main menu");
                        break;
                    case "d":
                        Console.WriteLine("Please input a customer to start the order: ");
                        Console.WriteLine("Please select a location to order from: ");
                        string lname = Console.ReadLine();
                        if (Location.SearchLocation(lname))
                        {
                            Console.WriteLine("Location found, please input the records you would like to order: ");
                            string rname = Console.ReadLine();

                        }

                        break;
                    case "e":
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
    }
}