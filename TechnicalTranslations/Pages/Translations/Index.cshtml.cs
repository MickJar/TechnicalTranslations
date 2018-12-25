using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TechnicalTranslations.Models;

namespace TechnicalTranslations.Pages.Translations
{
    public class IndexModel : PageModel
    {
        private readonly TechnicalTranslations.Models.TechnicalTranslationsContext _context;

        public IndexModel(TechnicalTranslations.Models.TechnicalTranslationsContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Languages { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Language { get; set; }

        public IList<Word> Word { get;set; }

        public async Task OnGetAsync()
        {
            var words = from m in _context.Word
                         select m;
            if (!String.IsNullOrEmpty(SearchString))
            {

                words = words.Where(s => s.Swedish.Contains(SearchString));
                //words = words.Where(s => s.English.Contains(SearchString));
            }

            Word = await words.ToListAsync();
            //Word = await _context.Word.ToListAsync();
        }
    }
}
