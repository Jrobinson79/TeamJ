using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using DomainClasses;
using DataLayer;

namespace TeamJ
{
    public partial class EntryForm : Form
    {

        public EntryForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            using (var context = new Context())
            {
                Address da = new Address();
                da.Street = addressTextBox.Text;
                da.City = cityTextBox.Text;
                da.State = stateTextBox.Text;
                da.Zipcode = zipcodeTextBox.Text;

                foreach (var address in context.Addresses)
                {
                    if (da.CompareTo(address) == 0)
                        da = address;
                }

                context.Addresses.Add(da);

                Person d = new Person();
                d.FirstName = firstNameTextBox.Text;
                d.LastName = lastNameTextBox.Text;
                d.Email = emailTextBox.Text;
                d.Phone = phoneTextBox.Text;
                d.Address = da;

                context.People.Add(d);

                Address ra = new Address();
                ra.Street = dedAddressTextBox.Text;
                ra.City = dedCityTextBox.Text;
                ra.State = dedStateTextBox.Text;
                ra.Zipcode = dedZipcodeTextBox.Text;

                context.Addresses.Add(ra);

                Person r = new Person();
                r.FirstName = dedFirstNameTextBox.Text;
                r.LastName = dedLastNameTextBox.Text;
                r.Address = ra;

                context.People.Add(r);

                Sale s = new Sale();
                s.Donor = d;
                s.Recipient = r;
                s.Date = DateTime.Now;

                context.Sales.Add(s);

                Item i = new Item();
                i.ItemType = context.ItemTypes.Where(it => it.Type == "Brick").First();
                i.Line1 = "Hello World!";
                i.Section = context.Sections.Where(sec => sec.Location == "A").First();
                i.Sale = s;

                context.Items.Add(i);

                decimal cost = 0;

                foreach (Item item in s.Items.ToList())
                    cost += item.ItemType.Price;

                s.Cost = cost;

                context.SaveChanges();

            }

        }
    }
}
