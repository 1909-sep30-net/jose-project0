using System;
using System.Collections.Generic;
using System.Text;

namespace Old_Record_Store.Library
{
    //has an inventory
    //inventory decreases when orders are accepted
    //rejects orders that cannot be fulfilled with remaining inventory
    //(optional: more than one inventory item decrements for a given product order, for at least one product)
    public class Location
    {
        public static List<Records> Inventory { get; set; }
        public Order Orders { get; set; }

        public static void UpdateStock(string recordname, int amount)
        {
            foreach (Records record in Inventory)
            {
                if (record.Name.Equals(recordname) && Records.CheckStock(recordname))
                {
                    record.Stock = record.Stock - amount;
                }
                else
                {
                    Console.WriteLine("Cannot update stock");
                    break;
                }
            }
        }

    }
}
