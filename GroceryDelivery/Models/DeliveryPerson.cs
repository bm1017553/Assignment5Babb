using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryDelivery.Models
{
    public class DeliveryPerson
    {
        [Key]
        public int DelivererId {get; set;} // Primary Key
        public string FullName {get; set;}
        public string Address {get; set;}
        public int PhoneNumber {get; set;}
        public List<OrderDelivery> OrderDeliveries {get; set;} // Navigation Property
    }
}