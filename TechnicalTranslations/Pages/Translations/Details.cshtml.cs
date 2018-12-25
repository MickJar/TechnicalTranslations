using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TechnicalTranslations.Models;

namespace TechnicalTranslations.Pages.Translations
{
    public class DetailsModel : PageModel
    {
        private readonly TechnicalTranslations.Models.TechnicalTranslationsContext _context;

        public DetailsModel(TechnicalTranslations.Models.TechnicalTranslationsContext context)
        {
            _context = context;
        }

        public Word Word { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Word = await _context.Word.FirstOrDefaultAsync(m => m.ID == id);

            if (Word == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
