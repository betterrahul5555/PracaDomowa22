using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WWW1.Models;

namespace WWW1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]

        public Address Address { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
 public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("./Privacy");
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
        }
       


    }
}
