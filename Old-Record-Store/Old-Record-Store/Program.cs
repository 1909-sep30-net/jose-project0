using System;
using Old_Record_Store.Library;
using System.Collections.Generic;
using Old_Record_Store_DataAccess;

namespace Old_Record_Store.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using IRecordStoreRepository recordStoreRepository = Dependencies.CreateRestaurantRepository();
            do
            {
                Console.WriteLine("Welcome to 'Farro's Garden of Earthly Delights' Record Store: ");
                Console.WriteLine("Please input a letter to interact with the menu, press 'e' to Exit the application");
                Console.WriteLine("\ta - Add Customer");
                Console.WriteLine("\tb - Display the Customer List");
                Console.WriteLine("\tc - Search for a Customer");
                Console.WriteLine("\td - Place an Order");
                Console.WriteLine("\te - Display Order Details");
                Console.WriteLine("\tf - Display Customer Order History");
                Console.WriteLine("\tg - Display Location Order History");
                Console.WriteLine("\th - Exit Software");

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
                        Customer newCustomer = new Customer
                        {
                            FullName = name,
                            Address = address,
                            Phone = phone,
                            Email = email
                        };
                        recordStoreRepository.AddCustomer(newCustomer);
                        break;

                    case "b":
                        Console.WriteLine("Displaying current customer list");
                        Console.WriteLine("Customer ID                  Customer List");
                        Console.WriteLine("-----------                  --------------");
                        recordStoreRepository.DisplayCustomers();
                        break;

                    case "c":
                        Console.WriteLine("Please input a customer name to being search: ");
                        string field = Console.ReadLine();
                        recordStoreRepository.SeachCustomer(field);
                        Console.WriteLine("Press Any key to go back to main menu");
                        break;

                    case "d":
                        List<int> recordList = new List<int>();
                        List<int> amountList = new List<int>();
                        bool selection = true;
                        Console.WriteLine("Please input a customer ID number to start the order: ");
                        Console.WriteLine("Customer ID                  Customer List");
                        Console.WriteLine("-----------                  --------------");

                        recordStoreRepository.DisplayCustomers();
                        int customerInput = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Please select a location to order from: ");
                        Console.WriteLine("Location ID                    Location List");
                        Console.WriteLine("-----------                    --------------");
                        recordStoreRepository.DisplayLocations();
                        int locationinput = Int32.Parse(Console.ReadLine());


                        Console.WriteLine("Please select the records ID you wish to add into your order, when done selecting records press '0' to proceed to the next window");
                        Console.WriteLine("Record ID        Name and Artist - (Price)");
                        Console.WriteLine("---------       -------------------------");
                        recordStoreRepository.DisplayRecords(locationinput);
                        while (selection)
                        {
                              Console.WriteLine("Please select the records ID you wish to add into your order, when done selecting records press '0' to proceed to the next window");
                            int customerSelection = Int32.Parse(Console.ReadLine());
                            if(customerSelection != 0)
                            {
                                recordList.Add(customerSelection);
                                Console.WriteLine("Please input the amount of records you want to purchase: ");
                                int amountSelection = Int32.Parse(Console.ReadLine());
                                amountList.Add(amountSelection);
                                //have to create an order then order history
                                //add record from location into order
                            }
                            else
                            {
                                selection = false;
                            }
                       
                        }
                        recordStoreRepository.AddToOrder(customerInput, locationinput, recordList, amountList);
                        break;

                    case "e":
                        Console.WriteLine("Please input an order id from the following list to display the details: ");
                        recordStoreRepository.DisplayOrderList();
                        int recordID = Int32.Parse(Console.ReadLine());
                        recordStoreRepository.DisplayOrderDetails(recordID);
                        break;
                    case "f":
                        Console.WriteLine("Please input a customer id from the following customer list to display the order History: ");
                        recordStoreRepository.DisplayCustomers();
                        int customerID = Int32.Parse(Console.ReadLine());
                        recordStoreRepository.DisplayOrderHistoryByCustomer(customerID);
                        break;
                    case "g":
                        Console.WriteLine("Please input a location id from the following list to display the order History: ");
                        recordStoreRepository.DisplayLocations();
                        int locationID = Int32.Parse(Console.ReadLine());
                        recordStoreRepository.DisplayOrderDetails(locationID);
                        break;
                    case "h":
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
    }
}