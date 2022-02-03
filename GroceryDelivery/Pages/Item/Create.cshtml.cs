#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GroceryDelivery.Models;

namespace GroceryDelivery.Pages_Item
{
    public class CreateModel : PageModel
    {
        private readonly ItemContext _context;

        public CreateModel(ItemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["OrderID"] = new SelectList(_context.Set<Order>(), "OrderID", "OrderID");
        ViewData["StoreID"] = new SelectList(_context.Set<Store>(), "StoreID", "StoreID");
            return Page();
        }

        [BindProperty]
        public Item Item { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Item.Add(Item);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
