using System;
using System.Collections.Generic;
using System.Text;

namespace Old_Record_Store.Library
{
    // Order: Place order, Display customer order history, display order details, display order history
    //  	- Order -> Order Constructor(User, Record, Amount)
    //- Display order.
    //- Display history.
    class Order
    {
        //Order constructor, requires a customer, records, and amount to successfully initialize the object
        public Order(Customer customer, Location location, List<Records> record) 
        { 
            Customer = customer;
            Location = location;
            Record = record;
        }

        //Auto-properties for Order object initizaliation. 
        public Customer Customer { get; set; }
        public Location Location { get; set; }
        public List<Records> Record { get; set; }

        public void PlaceOrder(Customer customer, Location store, string record)
        {
            //Check for inventory availability (do we have the record, do we have the stock)
            //Find record in store inventory
            store.Inventory.Find(record);
            Order NewOrder = new Order(customer, store, store.Inventory);
            
        }            
        public void DisplayOrderHistory() {
        }

        public void OrderDetails()
        {

        } 

        //display customer order history

    }
}
