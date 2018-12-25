using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TechnicalTranslations.Pages
{
    public class IndexModel : PageModel
    {
        public string SearchString { get; set; }
        public void OnGet()
        {
         
        }
    }
}
