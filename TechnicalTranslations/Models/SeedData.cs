using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace TechnicalTranslations.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TechnicalTranslationsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TechnicalTranslationsContext>>()))
            {
                // Look for any movies.
                if (context.Word.Any())
                {
                    return;   // DB has been seeded
                }

                context.Word.AddRange(
                    new Word
                    {
                        Swedish = "Värme",
                        English = "Heat"
                    },
                    new Word
                    {
                        Swedish = "Abbes komparatorprincip",
                        English = "Abbes Comparison Principle"
                    },
                    new Word
                    {
                        Swedish = "abrasiv förslitning",
                        English = "Abrasive wear"
                    },
                    new Word
                    {
                        Swedish = "acetylen-syrglasblandning",
                        English = "Acethylene-oxygen mixture"
                    },
                    new Word
                    {
                        Swedish = "Acikulär bainit",
                        English = "Acicular Bainite"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}