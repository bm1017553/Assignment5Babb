#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GroceryDelivery.Models;

    public class OrderContext : DbContext
    {
        public OrderContext (DbContextOptions<OrderContext> options)
            : base(options)
        {
        }

        public DbSet<GroceryDelivery.Models.Order> Order { get; set; }
    }
