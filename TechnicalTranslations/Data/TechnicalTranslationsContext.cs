using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TechnicalTranslations.Models
{
    public class TechnicalTranslationsContext : DbContext
    {
        public TechnicalTranslationsContext (DbContextOptions<TechnicalTranslationsContext> options)
            : base(options)
        {
        }

        public DbSet<TechnicalTranslations.Models.Word> Word { get; set; }
    }
}
