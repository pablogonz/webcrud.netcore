using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webcrud.Data;
using webcrud.Entities;

namespace webcrud.Pages.Departments
{
    public class DetailsModel : PageModel
    {
        private readonly webcrud.Data.INTEC_AGU_OCT22Context _context;

        public DetailsModel(webcrud.Data.INTEC_AGU_OCT22Context context)
        {
            _context = context;
        }

      public Deparment Deparment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Deparment == null)
            {
                return NotFound();
            }

            var deparment = await _context.Deparment.FirstOrDefaultAsync(m => m.Id == id);
            if (deparment == null)
            {
                return NotFound();
            }
            else 
            {
                Deparment = deparment;
            }
            return Page();
        }
    }
}
