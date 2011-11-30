using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using DomainClasses;

namespace DataLayer
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {

            List<ItemType> types = new List<ItemType>()
            {
                new ItemType { Type = "Brick", Price = decimal.Parse("100.00") },
                new ItemType { Type = "Bench", Price = decimal.Parse("1000.00") }
            };

            foreach (ItemType type in types)
                context.ItemTypes.Add(type);

            context.SaveChanges();


            List<Section> sections = new List<Section>()
            {
                new Section { Location = "A", Description = "NNE" },
                new Section { Location = "B", Description = "ENE" },
                new Section { Location = "C", Description = "ESE" },
                new Section { Location = "D", Description = "SSE" },
                new Section { Location = "E", Description = "SSW" },
                new Section { Location = "F", Description = "WSW" },
                new Section { Location = "G", Description = "WNW" },
                new Section { Location = "H", Description = "NNW" },
                new Section { Location = "G-1", Description = "North Left Side" },
                new Section { Location = "G-2", Description = "North Right Side" },
                new Section { Location = "G-3", Description = "East Left Side" },
                new Section { Location = "G-4", Description = "East Right Side" },
                new Section { Location = "G-5", Description = "South Left Side" },
                new Section { Location = "G-6", Description = "South Right Side" },
                new Section { Location = "G-7", Description = "West Left Side" },
                new Section { Location = "G-8", Description = "West Right Side" }
            };

            foreach (Section section in sections)
                context.Sections.Add(section);

            context.SaveChanges();

        }
    }
}
