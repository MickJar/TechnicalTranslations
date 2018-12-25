using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TechnicalTranslations.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            string directory = Environment.CurrentDirectory;
            Message = String.Format("Your directory is {0}.", directory);
            //Message = "This app translates techical terms between swedish and english";
        }
    }
}
