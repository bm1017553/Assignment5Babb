using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryDelivery.Models
{
    public class Item
    {
        public int ItemID {get; set;} // Primary Key
        public string ItemName {get; set;}
        public string ItemType {get; set;}
        public int Quantity {get; set;}
        public double Price {get; set;}
        public int StoreID {get; set;} // Foreign Key
        public Store Store {get; set;} // Reference Object
        public int OrderID {get; set;} // Foreign Key
        public Order Order {get; set;} // Reference Object
    }
}