using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainClasses
{
    public class Address : IComparable<Address>
    {
        public int AddressID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public virtual ICollection<Person> People { get; set; }

        public int CompareTo(Address other)
        {
            if (this.Street == other.Street &&
                this.City == other.City &&
                this.State == other.State &&
                this.Zipcode == other.Zipcode)
                return 0;

            else
                return 1;
        }

    }

    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Sale> DonorSales { get; set; }
        public virtual ICollection<Sale> RecipientSales { get; set; }
    }

    public class Sale
    {
        public int SaleID { get; set; }
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }
        public int DonorID { get; set; }
        public int RecipientID { get; set; }
        public virtual Person Donor { get; set; }
        public virtual Person Recipient { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }

    public class Item
    {
        public int ItemID { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public int ItemTypeID { get; set; }
        public int SectionID { get; set; }
        public int SaleID { get; set; }
        public virtual ItemType ItemType { get; set; }
        public virtual Section Section { get; set; }
        public virtual Sale Sale { get; set; }
    }

    public class ItemType
    {
        public int ItemTypeID { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }

    public class Section
    {
        public int SectionID { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
