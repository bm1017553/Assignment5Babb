using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GroceryDelivery.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GroceryDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<GroceryDbContext>>()))
                {
                    // Look for customers, orders, stores, items, delivery persons
                    if (context.Customers.Any() && context.Orders.Any() && context.Stores.Any() && context.Items.Any() && context.DeliveryPeople.Any())
                    {
                        return; // db seeded
                    }

                    context.Customers.AddRange(
                        new Customer
                        {
                            FirstName = "Joe",
                            LastName = "Bob",
                            Address = "1234 That St.",
                            PhoneNumber = 1234567890,
                            Email = "thisperson@thatemail.com",
                            CreditCard = 459823423
                        },
                        new Customer
                        {
                            FirstName = "Michelle",
                            LastName = "Wilson",
                            Address = "5678 This St.",
                            PhoneNumber = 0123456789,
                            Email = "thatperson@thisemail.com",
                            CreditCard = 89897863
                        }
                    );

                    context.SaveChanges();
                }
        }
    }
}