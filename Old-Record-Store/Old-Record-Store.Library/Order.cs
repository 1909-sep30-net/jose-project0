using System;
using System.Collections.Generic;


namespace Old_Record_Store.Library
{
    public class Order
    {

        public Customer Customer { get; set; }
        public Location Location { get; set; }
        public List<Records> Recordlist { get; set; }
        public static string Date { get; set; }

        //                            Customer customer
        public static void PlaceOrder(string name, Location store, List<Records> record, int amount)
        {
        //                          customer.FullName
            if (Customer.SeachCustomer(name))
            {
                foreach (Records rec in record)
                {
                    if (Records.CheckStock(rec.Name))
                    {
                        Location.UpdateStock(rec.Name, amount, store.LocationName);
                        
                    }
                }
                Date = DateTime.Now.ToString("HH:mm:ss tt");
                Console.WriteLine("Order sucessfully created. Time of order: " + DateTime.Now.ToString("HH:mm:ss tt"));
            }
            else
            {
                Console.WriteLine("Customer does not exist, please add customer before placing an order");
            }
        }
    }
}
