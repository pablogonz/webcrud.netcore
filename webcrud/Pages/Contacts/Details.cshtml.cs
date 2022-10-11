using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webcrud.Data;
using webcrud.Entities;

namespace webcrud.Pages.Contacts
{
    public class DetailsModel : PageModel
    {
        private readonly webcrud.Data.INTEC_AGU_OCT22Context _context;

        public DetailsModel(webcrud.Data.INTEC_AGU_OCT22Context context)
        {
            _context = context;
        }

      public ContactType ContactType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ContactType == null)
            {
                return NotFound();
            }

            var contacttype = await _context.ContactType.FirstOrDefaultAsync(m => m.Id == id);
            if (contacttype == null)
            {
                return NotFound();
            }
            else 
            {
                ContactType = contacttype;
            }
            return Page();
        }
    }
}
