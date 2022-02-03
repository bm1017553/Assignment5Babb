#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GroceryDelivery.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GroceryDelivery.Pages_Items
{
    public class IndexModel : PageModel
    {
        private readonly GroceryDelivery.Models.GroceryDbContext _context;

        public IndexModel(GroceryDelivery.Models.GroceryDbContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }
        public SelectList StoreFind {get; set;}

        public IActionResult OnGet()
        {
            StoreFind = new SelectList(_context.Stores, "StoreID", "Name"); 
            Item = _context.Items
                .Include(i => i.Order)
                .Include(i => i.Store).ToList();
                return Page();
        }

        [BindProperty]
        public Store Store {get; set;}

        public async Task<IActionResult> OnPostAsync(int id)
        {
            id = Store.StoreID;
            Item = await _context.Items.Where(i => i.StoreID.Equals(id))
                .Include(i => i.Order)
                .Include(i => i.Store).ToListAsync();
                return Page();
        }
    }
}
