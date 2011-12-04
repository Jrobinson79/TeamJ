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

                listBoxResults.DataSource = searchResults;
            }
        }

        #endregion

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

        #endregion
    }
}
