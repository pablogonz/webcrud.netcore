using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webcrud.Data;
using webcrud.Entities;

namespace webcrud.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly webcrud.Data.INTEC_AGU_OCT22Context _context;

        public DetailsModel(webcrud.Data.INTEC_AGU_OCT22Context context)
        {
            _context = context;
        }

      public ClientType ClientType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ClientType == null)
            {
                return NotFound();
            }

            var clienttype = await _context.ClientType.FirstOrDefaultAsync(m => m.Id == id);
            if (clienttype == null)
            {
                return NotFound();
            }
            else 
            {
                ClientType = clienttype;
            }
            return Page();
        }
    }
}
