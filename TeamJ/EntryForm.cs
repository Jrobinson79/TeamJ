using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;

namespace TeamJ
{
    public partial class EntryForm : Form
    {
        private TeamJDBEntities context = null;

        public EntryForm(TeamJDBEntities context)
        {
            InitializeComponent();

            this.context = context;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            Person donor = new Person();
            donor.PersonID = Guid.NewGuid();
            donor.FirstName = firstNameTextBox.Text;
            donor.LastName = lastNameTextBox.Text;
            donor.MiddleName = middleNameTextBox.Text;
            donor.Email = emailTextBox.Text;
            donor.Phone = phoneTextBox.Text;
            donor.Addr = addressTextBox.Text;
            donor.City = cityTextBox.Text;
            donor.State = stateTextBox.Text;
            donor.Zip = zipcodeTextBox.Text;

            context.People.AddObject(donor);

            Person dedication = new Person();
            dedication.PersonID = Guid.NewGuid();
            dedication.FirstName = dedFirstNameTextBox.Text;
            dedication.LastName = dedLastNameTextBox.Text;
            dedication.MiddleName = dedMiddleNameTextBox.Text;
            dedication.Addr = dedAddressTextBox.Text;
            dedication.City = dedCityTextBox.Text;
            dedication.State = dedStateTextBox.Text;
            dedication.Zip = dedZipcodeTextBox.Text;

            context.People.AddObject(dedication);

            Sale sale = new Sale();
            sale.SaleID = Guid.NewGuid();
            sale.Donor = donor;
            sale.Dedication = dedication;
            sale.Cost = 100;
            sale.Date = DateTime.Now;

            context.Sales.AddObject(sale);

            ItemType type = context.ItemTypes.Where(t => t.Type == "Brick").ToList<ItemType>().ElementAt(0);
            Section section = context.Sections.Where(s => s.Location == "A").ToList<Section>().ElementAt(0);

            Item item = new Item();
            item.ItemID = Guid.NewGuid();
            item.ItemType = type;
            item.Section = section;
            item.Sale = sale;
            item.Line1 = line1TextBox.Text;
            item.Line2 = line2TextBox.Text;
            item.Line3 = line3TextBox.Text;

            context.Items.AddObject(item);

            try
            {
                int res = context.SaveChanges();
                context.AcceptAllChanges();
                MessageBox.Show("Result: " + res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

        }
    }
}
