using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using DataLayer;
using DomainClasses;

namespace TeamJ
{
    public partial class AdvancedSearchPanel : UserControl
    {

        #region Private Variables

        #endregion

        #region Constructors

        #region AdvancedSearchPanel()
        /// <summary>
        ///     Constructs an AdvancedSearchPanel object
        /// </summary>
        public AdvancedSearchPanel()
        {
            InitializeComponent();
            initialize();
        }

        #endregion

        #endregion

        #region Private Methods

        #region initialize();

        private void initialize()
        {
            this.Dock = DockStyle.Fill;

            PopulateMenus();
            SetPurchaseDates();

            this.endLabel1.Visible = false;
            this.purchaseEndDatePicker.Visible = false;
            this.purchaseEndDatePicker.Enabled = false;
        }

        #endregion

        #region PopulateMenus()
        /// <summary>
        ///     Loads the ItemTypes combobox with a list of ItemTypes from the database.
        /// </summary>
        private void PopulateMenus()
        {
            using (var context = new Context())
            {
                // Load the items combobox
                context.ItemTypes.Load();
                itemComboBox.DataSource = context.ItemTypes.Local.ToBindingList();
                itemComboBox.DisplayMember = "Type";

                // Load the sections combobox
                context.Sections.Load();
                sectionComboBox.DataSource = context.Sections.Local.ToBindingList();
                sectionComboBox.DisplayMember = "Location";

                // To Deselect the Combo Box
                this.itemComboBox.SelectedIndex = -1;

                // To Deselect the Combo Box
                this.sectionComboBox.SelectedIndex = -1;

            }
        }

        #endregion

        #region SetPurchaseDates()

        // Getting the minimum sale date and the
        // maximum sale date so that the user knows
        // the existing range of dates when entering
        // information
        private void SetPurchaseDates()
        {
            using (var context = new Context())
            {
                DateTime minDate = DateTime.Today;

                context.Sales.Load();

                foreach (Sale s in context.Sales.Local)
                    if (s.Date.CompareTo(minDate) == -1)
                        minDate = s.Date;

                DateTime maxDate = minDate;

                foreach (Sale s in context.Sales.Local)
                    if (s.Date.CompareTo(maxDate) == 1)
                        maxDate = s.Date;

                this.purchaseStartDatePicker.Value = minDate;
                this.purchaseEndDatePicker.Value = maxDate;
            }
        }

        #endregion

        #region Search()

        private void Search()
        {
            using(var context = new Context())
            {
                List<int> indexesToRemove = new List<int>();

                context.Sales.Load();

                List<Sale> searchResults = context.Sales.Local
                    .Where(i => i.Date >= purchaseStartDatePicker.Value)
                    .ToList();

                if(this.rangeCheckBox.Checked)
                {
                    searchResults = searchResults
                        .Where(i => i.Date <= purchaseEndDatePicker.Value)
                        .ToList();
                }

                if (this.itemComboBox.SelectedIndex > -1 && !itemComboBox.Text.Trim().Equals(""))
                {
                    searchResults = searchResults
                        .Where(i => i.Items.First().ItemTypeID == ((ItemType)itemComboBox.SelectedItem).ItemTypeID)
                        .ToList();
                }

                if (this.sectionComboBox.SelectedIndex > -1 && !sectionComboBox.Text.Trim().Equals(""))
                {
                    searchResults = searchResults
                        .Where(i => i.Items.First().SectionID == ((Section)sectionComboBox.SelectedItem).SectionID)
                        .ToList();
                }

                List<Person> people = new List<Person>();
                List<Sale> removeList = new List<Sale>();

                if (useTextBox(addressTextBox) ||
                    useTextBox(cityTextBox) ||
                    useTextBox(stateTextBox) ||
                    useTextBox(zipTextBox))
                {   //  Filter out the address
                    context.Addresses.Load();
                    List<Address> addresses = context.Addresses.Local.ToList();

                    if(useTextBox(addressTextBox))
                        addresses = addresses.Where(i => i.Street.StartsWith(addressTextBox.Text.Trim(), true, null)).ToList();

                    if (useTextBox(cityTextBox))
                        addresses = addresses.Where(i => i.City.StartsWith(cityTextBox.Text.Trim(), true, null)).ToList();

                    if (useTextBox(stateTextBox))
                        addresses = addresses.Where(i => i.State.StartsWith(stateTextBox.Text.Trim(), true, null)).ToList();

                    if (useTextBox(zipTextBox))
                        addresses = addresses.Where(i => i.Zipcode.StartsWith(zipTextBox.Text.Trim(), true, null)).ToList();

                    foreach (Address a in addresses)
                        people.AddRange(a.People);

                    foreach (Sale s in searchResults)
                    {
                        if (!people.Contains(s.Donor) &&
                            !people.Contains(s.Recipient))
                            removeList.Add(s);
                    }

                    foreach (Sale s in removeList)
                        searchResults.Remove(s);
                }

                if (useTextBox(donorFNTextBox) ||
                    useTextBox(donorMNTextBox) ||
                    useTextBox(donorLNTextBox) ||
                    useTextBox(textBoxPhone) ||
                    useTextBox(textBoxEmail))
                {
                    context.People.Load();
                    people = context.People.Local.ToList();

                    if (useTextBox(donorFNTextBox))
                        people = people.Where(i => i.FirstName.StartsWith(donorFNTextBox.Text.Trim(), true, null)).ToList();

                    if (useTextBox(donorMNTextBox))
                        people = people.Where(i => i.MiddleName.StartsWith(donorMNTextBox.Text.Trim(), true, null)).ToList();

                    if (useTextBox(donorLNTextBox))
                        people = people.Where(i => i.LastName.StartsWith(donorLNTextBox.Text.Trim(), true, null)).ToList();

                    if (useTextBox(textBoxPhone))
                        people = people.Where(i => i.Phone.StartsWith(textBoxPhone.Text.Trim(), true, null)).ToList();

                    if (useTextBox(textBoxEmail))
                        people = people.Where(i => i.Email.StartsWith(textBoxEmail.Text.Trim(), true, null)).ToList();

                    removeList.Clear();

                    foreach (Sale s in searchResults)
                    {
                        if (!people.Contains(s.Donor) &&
                            !people.Contains(s.Recipient))
                            removeList.Add(s);
                    }

                    foreach (Sale s in removeList)
                        searchResults.Remove(s);
                }

                if (searchResults.Count > 0)
                {
                    List<TransactionItem> mList = new List<TransactionItem>();

                    foreach (Sale s in searchResults)
                    {
                        if (s.DonorID == s.RecipientID)
                            mList.Add(new TransactionItem(s.Donor, s, "Donor & Recipient"));
                        else
                        {
                            mList.Add(new TransactionItem(s.Donor, s, "Donor"));
                            mList.Add(new TransactionItem(s.Recipient, s, "Recipient"));
                        }
                    }

                    listBoxResults.DataSource = mList;
                }
                else
                {
                    listBoxResults.DataSource = null;

                    listBoxResults.Items.Clear();
                    listBoxResults.Items.Add("No Results Found");
                }
            }
        }

        #endregion

        private bool useTextBox(TextBox b)
        {
            return (!b.Text.Trim().Equals(""));
        }

        private void selectSale()
        {
            if (!listBoxResults.SelectedItem.ToString().Equals("No Results Found"))
            {
                List<TransactionItem> mList = new List<TransactionItem>();

                foreach(TransactionItem s in listBoxResults.Items)
                {
                    mList.Add(s);
                }

                Program.mForm.setPanel(new ShowDonorPanel(mList, listBoxResults.SelectedIndex));
            }
        }

        #endregion

        #region Events

        private void rangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rangeCheckBox.Checked)
            {
                this.endLabel1.Visible = true;
                this.purchaseEndDatePicker.Visible = true;
                this.purchaseEndDatePicker.Enabled = true;
            }
            else
            {
                this.endLabel1.Visible = false;
                this.purchaseEndDatePicker.Visible = false;
                this.purchaseEndDatePicker.Enabled = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void enterPressedEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
                Search();
        }

        private void textBoxEntered(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void comboBoxEntered(object sender, EventArgs e)
        {
            ((ComboBox)sender).SelectAll();
        }

        private void listBoxResults_DoubleClick(object sender, EventArgs e)
        {
            selectSale();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            selectSale();
        }

        #endregion
    }
}
