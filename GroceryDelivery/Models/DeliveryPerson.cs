using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryDelivery.Models
{
    public class DeliveryPerson
    {
        public int DelivererID {get; set;} // Primary Key
        public string FullName {get; set;}
        public string Address {get; set;}
        public int PhoneNumber {get; set;}
        public List<OrderDelivery> OrderDeliveries {get; set;} // Navigation Property
    }
}