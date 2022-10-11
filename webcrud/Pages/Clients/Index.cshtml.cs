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
    public class IndexModel : PageModel
    {
        private readonly webcrud.Data.INTEC_AGU_OCT22Context _context;

        public IndexModel(webcrud.Data.INTEC_AGU_OCT22Context context)
        {
            _context = context;
        }

        public IList<ClientType> ClientType { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ClientType != null)
            {
                ClientType = await _context.ClientType.ToListAsync();
            }
        }
    }
}
