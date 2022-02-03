#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GroceryDelivery.Models;

    public class ItemContext : DbContext
    {
        public ItemContext (DbContextOptions<ItemContext> options)
            : base(options)
        {
        }

        public DbSet<GroceryDelivery.Models.Item> Item { get; set; }
    }
