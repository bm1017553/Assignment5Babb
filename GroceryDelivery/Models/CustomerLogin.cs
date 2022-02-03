using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryDelivery.Models
{
    public class SignInPage
    {
        [Key]
        public DeliveryPerson? EmployeeID { get; set; } // Foreign and Primary Key
        //Need sign in button and binding to Employee.cs
    }
}