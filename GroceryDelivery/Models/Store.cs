using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryDelivery.Models
{
    public class Store
    {
        public int StoreID {get; set;} // Primary Key
        public string Name {get; set;}
        public string Address {get; set;}
        public int PhoneNumber {get; set;}
        public List<Item> Items {get; set;} // Navigation Property
    }
}