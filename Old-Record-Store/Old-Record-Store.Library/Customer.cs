using System;
using System.Collections.Generic;
using System.Text;

namespace Old_Record_Store.Library
{
    class Customer
    {
        List<Customer> CustomerList = new List<Customer>();

        //Customer constructor, requires all fields to create a customer object.
        public Customer(string fullname, string phone, string address, string email)
        {
            FullName = fullname;
            Phone = phone;
            Address = address;
            Email = email;
        }

        //Auto-properties for customer fields
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public void AddCustomer(string fullname, string phone, string address, string email)
        {
            //Creates a new customer object
            Customer NewCustomer = new Customer(fullname, phone, address, email);
                
            //Cannot depend on input/output, will have to move somewhere on UI.
            ////Populates NewCustomer object fields with user input
            //Console.WriteLine("Please input your Full Name: ");
            //NewCustomer.FullName = Console.ReadLine();
            //Console.WriteLine("\nPlease input your address");
            //NewCustomer.Address = Console.ReadLine();
            //Console.WriteLine("\nPlease input your Email: ");
            //NewCustomer.Email = Console.ReadLine();
            //Console.WriteLine("\nLastly, please input your Phone: ");
            //NewCustomer.Phone = Console.ReadLine();

            ////Adds the new customer into the end of Customer list
            CustomerList.Add(NewCustomer);
            Console.WriteLine("Customer successfully added, you can now place orders!");

            
        }

        public void SeachCustomer()
        {

        }

    }
}
