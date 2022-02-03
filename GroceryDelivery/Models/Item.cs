using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryDelivery.Models
{
    public class Item
    {
        [Key]
        public int ItemID {get; set;} // Primary Key
        public string? ItemName {get; set;}
        public string? ItemType {get; set;}
        public int Quantity {get; set;}
        [DataType(DataType.Currency)]
        public double Price {get; set;}
        public int StoreID {get; set;} // Foreign Key
        public Store? Store {get; set;} // Reference Object
        public int OrderID {get; set;} // Foreign Key
        public Order? Order {get; set;} // Reference Object
    }
}