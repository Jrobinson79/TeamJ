using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DomainClasses;

namespace DataLayer
{
    public class Context : DbContext
    {
        public DbSet<Section> Sections { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Section>().HasKey(s => s.SectionID);
            modelBuilder.Entity<Section>().Property(s => s.Location).IsRequired();
            modelBuilder.Entity<Section>().Property(s => s.Description).IsRequired();

            modelBuilder.Entity<ItemType>().HasKey(i => i.ItemTypeID);
            modelBuilder.Entity<ItemType>().Property(i => i.Type).IsRequired();
            modelBuilder.Entity<ItemType>().Property(i => i.Price).IsRequired();

            modelBuilder.Entity<Address>().HasKey(a => a.AddressID);
            modelBuilder.Entity<Address>().Property(a => a.Zipcode).IsRequired();
            modelBuilder.Entity<Address>().Property(a => a.State).IsRequired();
            modelBuilder.Entity<Address>().Property(a => a.City).IsRequired();
            modelBuilder.Entity<Address>().Property(a => a.Street).IsRequired();

            modelBuilder.Entity<Item>().HasKey(i => i.ItemID);
            modelBuilder.Entity<Item>().Property(i => i.Line1).IsRequired();
            modelBuilder.Entity<Item>().Property(i => i.Line1).HasMaxLength(20);
            modelBuilder.Entity<Item>().Property(i => i.Line2).HasMaxLength(20);
            modelBuilder.Entity<Item>().Property(i => i.Line3).HasMaxLength(20);

            modelBuilder.Entity<Sale>().HasKey(s => s.SaleID);
            modelBuilder.Entity<Sale>().Property(s => s.Cost).IsRequired();
            modelBuilder.Entity<Sale>().Property(s => s.Date).IsRequired();
            modelBuilder.Entity<Sale>().HasRequired(s => s.Donor)
                .WithMany(d => d.DonorSales)
                .HasForeignKey(s => s.DonorID)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Sale>().HasRequired(s => s.Recipient)
                .WithMany(r => r.RecipientSales)
                .HasForeignKey(s => s.RecipientID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>().HasKey(p => p.PersonID);
            modelBuilder.Entity<Person>().Property(p => p.FirstName).IsRequired();
            modelBuilder.Entity<Person>().Property(p => p.LastName).IsRequired();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
