using System;
using System.Collections.Generic;
using System.Text;

namespace Old_Record_Store.Library
{
    //has an inventory
    //inventory decreases when orders are accepted
    //rejects orders that cannot be fulfilled with remaining inventory
    //(optional: more than one inventory item decrements for a given product order, for at least one product)
    class Location
    {

        public Location(string state, List<Records> inventory)
        {
            State = state;
            Inventory = inventory;
        }

        public string State { get; set; }
        public List<Records> Inventory { get; set; }


    }


}
