using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FociWebApp_2.Models;

namespace FociWebApp_2.Pages
{
    public class MeccsKukkolásModel : PageModel
    {
        private readonly FociWebApp_2.Models.FociDbContext _context;

        public MeccsKukkolásModel(FociWebApp_2.Models.FociDbContext context)
        {
            _context = context;
        }

        public IList<Meccs> Meccs { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Meccs = await _context.Meccsek.ToListAsync();
        }
    }
}
