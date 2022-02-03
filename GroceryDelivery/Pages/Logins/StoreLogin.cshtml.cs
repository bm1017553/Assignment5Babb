using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using GroceryDelivery.Models;

namespace GroceryDelivery.Pages.Logins
{
    public class StoreLoginModel : PageModel
    {
        private readonly GroceryDbContext _context;
        private readonly ILogger<StoreLoginModel> _logger;

        // [BindProperty]
        // public StoreLogin StoreLogin {get; set;}
        [BindProperty]
        public Store Store {get; set;}
        public StoreLoginModel(GroceryDbContext context, ILogger<StoreLoginModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            ViewData["StoreID"] = new SelectList(_context.Stores, "StoreID", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            return RedirectToPage("Items/Index");
        }
    }
}