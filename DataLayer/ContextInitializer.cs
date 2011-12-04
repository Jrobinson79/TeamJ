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
                new ItemType { ItemTypeID = 1, Type = "Brick", Price = decimal.Parse("100.00") },
                new ItemType { ItemTypeID = 2, Type = "Bench", Price = decimal.Parse("1000.00") }
            };

            foreach (ItemType type in types)
                context.ItemTypes.Add(type);

            context.SaveChanges();


            List<Section> sections = new List<Section>()
            {
                new Section { SectionID = 1, Location = "A", Description = "NNE" },
                new Section { SectionID = 2, Location = "B", Description = "ENE" },
                new Section { SectionID = 3, Location = "C", Description = "ESE" },
                new Section { SectionID = 4, Location = "D", Description = "SSE" },
                new Section { SectionID = 5, Location = "E", Description = "SSW" },
                new Section { SectionID = 6, Location = "F", Description = "WSW" },
                new Section { SectionID = 7, Location = "G", Description = "WNW" },
                new Section { SectionID = 8, Location = "H", Description = "NNW" },
                new Section { SectionID = 9, Location = "G-1", Description = "North Left Side" },
                new Section { SectionID = 10, Location = "G-2", Description = "North Right Side" },
                new Section { SectionID = 11, Location = "G-3", Description = "East Left Side" },
                new Section { SectionID = 12, Location = "G-4", Description = "East Right Side" },
                new Section { SectionID = 13, Location = "G-5", Description = "South Left Side" },
                new Section { SectionID = 14, Location = "G-6", Description = "South Right Side" },
                new Section { SectionID = 15, Location = "G-7", Description = "West Left Side" },
                new Section { SectionID = 16, Location = "G-8", Description = "West Right Side" }
            };

            foreach (Section section in sections)
                context.Sections.Add(section);

            context.SaveChanges();

            //----------------------------------------------------------
            // Jordan:  Adding test data
            //----------------------------------------------------------

            List<Address> addrs = new List<Address>()
            {
                new Address { AddressID = 1, Street = "169 India Drive", City = "Shreveport", State = "LA", Zipcode = "71115" }, 
                new Address { AddressID = 2, Street = "100 John Street", City = "Shreveport", State = "LA", Zipcode = "71115" }, 
                new Address { AddressID = 3, Street = "111 Jen Ave", City = "Bossier", State = "LA", Zipcode = "71115" }, 
                new Address { AddressID = 4, Street = "1100 Jeremiah Lane", City = "Shreveport", State = "LA", Zipcode = "71115" } 
            };

            foreach (Address addr in addrs)
                context.Addresses.Add(addr);

            context.SaveChanges();

            List<Person> people = new List<Person>()
            {
                new Person { PersonID = 1, FirstName = "Jordan", MiddleName = "Stone", LastName = "Berroteran", Email = "sx3stonesky@yahoo.com", Phone = "13185182348", AddressID = 1 },
                new Person { PersonID = 2, FirstName = "John", MiddleName = "Bruce", LastName = "Nelson", Email = "john.bruce.nelson@gmail.com", Phone = "13184444675", AddressID = 2 },
                new Person { PersonID = 3, FirstName = "Jen", MiddleName = "Diane", LastName = "Smith", Email = "jen.smith@gmail.com", Phone = "13187474666", AddressID = 3 },
                new Person { PersonID = 4, FirstName = "Jeremiah", MiddleName = "", LastName = "Slack", Email = "a771cu5@gmail.com", Phone = "13184445555", AddressID = 4 }
            };

            foreach (Person p in people)
                context.People.Add(p);

            context.SaveChanges();

            List<Sale> sales = new List<Sale>()
            {
                new Sale { SaleID = 1, Cost = 120.00M, Date = new DateTime(2010, 5, 15), DonorID = 1, RecipientID = 1}, 
                new Sale { SaleID = 2, Cost = 100.00M, Date = new DateTime(2009, 3, 17), DonorID = 2, RecipientID = 3}, 
                new Sale { SaleID = 3, Cost = 1500.00M, Date = new DateTime(2011, 1, 12), DonorID = 4, RecipientID = 3}, 
            };

            foreach (Sale s in sales)
                context.Sales.Add(s);

            context.SaveChanges();

            List<Item> items = new List<Item>()
            {
                new Item { ItemID = 1, Line1 = "We are", Line2 = "Very", Line3 = "Proud of You!", ItemTypeID = 1, SectionID = 3, SaleID = 1},
                new Item { ItemID = 2, Line1 = "Yay", Line2 = "It's Finally Over!", Line3 = null, ItemTypeID = 1, SectionID = 4, SaleID = 2},
                new Item { ItemID = 3, Line1 = "Congratulations", Line2 = null, Line3 = null, ItemTypeID = 2, SectionID = 9, SaleID = 3}
            };

            foreach (Item i in items)
                context.Items.Add(i);

            context.SaveChanges();
        }
    }
}
