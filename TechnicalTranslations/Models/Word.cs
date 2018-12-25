using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalTranslations.Models
{
    public class Word
    {   
        public int ID { get; set; }
        public string Swedish { get; set; }
        public string English { get; set; }
    }
}
