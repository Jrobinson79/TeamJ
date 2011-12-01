using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            PopulateMenus();
            SetPurchaseDates();

            this.endLabel1.Visible = false;
            this.purchaseEndDatePicker.Visible = false;
            this.purchaseEndDatePicker.Enabled = false;
        }

        #endregion

        #endregion

        #region Private Methods

        #region PopulateMenus()
        /// <summary>
        ///     Loads the ItemTypes combobox with a list of ItemTypes from the database.
        /// </summary>
        private void PopulateMenus()
        {
            using (TeamJDBEntities context = new TeamJDBEntities())
            {
                // Load the items combobox

                var itemQuery = from itemType in context.ItemTypes
                                select itemType;

                foreach (var result in itemQuery)
                {
                    this.itemComboBox.Items.Add(result.Type.ToString());
                }

                // To Deselect the Combo Box
                this.itemComboBox.SelectedIndex = -1;

                // Load the sections combobox

                var sectionQuery = from section in context.Sections
                                   select section;

                foreach (var result in sectionQuery)
                {
                    this.sectionComboBox.Items.Add(result.Location.ToString());
                }

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
            using (TeamJDBEntities context = new TeamJDBEntities())
            {
                DateTime minDate = DateTime.Today;

                foreach (Sale s in context.Sales)
                    if (s.Date.CompareTo(minDate) == -1)
                        minDate = s.Date;

                DateTime maxDate = minDate;

                foreach (Sale s in context.Sales)
                    if (s.Date.CompareTo(maxDate) == 1)
                        maxDate = s.Date;

                this.purchaseStartDatePicker.Value = minDate;
                this.purchaseEndDatePicker.Value = maxDate;
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

        #endregion
    }
}
