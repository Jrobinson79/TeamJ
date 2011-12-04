using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Globalization;
using System.Data.SqlTypes;
using DataLayer;
using DomainClasses;
using System.Data.Entity;

namespace TeamJ
{
    public partial class TransactionPanel : UserControl
    {
        #region Private Methods
        private Sale sale = new Sale();
        private bool newSale = false;

        #endregion

        #region Constructors

        #region TransactionPanel()
        /// <summary>
        ///     Constructs a TransactionPanel object
        /// </summary>
        public TransactionPanel()
        {
            InitializeComponent();
            this.initialize();
        }

        #endregion

        #region TransactionPanel(IContainer container)
        /// <summary>
        ///     Constructs a TransactionPanel object
        /// </summary>
        /// <param name="container"></param>
        public TransactionPanel(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            this.initialize();
        }

        #endregion

        #endregion

        #region Methods

        #region

        private void initialize()
        {
            this.Dock = DockStyle.Fill;
            LoadComboBox();
            SetPriceField();
            sectionChanged();
        }

        #endregion

        public void setNewSale(bool newSale)
        {
            this.newSale = newSale;
        }

        #region SetSale(Sale s)
        /// <summary>
        ///     Sets the textbox fields from the data contained in the Sale parameter
        /// </summary>
        /// <param name="s">The Sale object that needs to be loaded into the textbox fields</param>
        public void SetSale(Sale s)
        {
            this.sale = s;

            Item item = s.Items.First();

            this.comboBoxItemType.SelectedItem = item.ItemType.Type;
            this.dateTimePicker1.Value = s.Date;

            this.textBoxLine1.Text = item.Line1;
            this.textBoxLine2.Text = item.Line2;
            this.textBoxLine3.Text = item.Line3;

            comboBoxSection.SelectedItem = item.Section.Location;

            this.textBoxPrice.Text = item.ItemType.Price.ToString();
            this.textBoxDonation.Text = (s.Cost - item.ItemType.Price).ToString();
        }

        #endregion

        #region GetSale()
        /// <summary>
        ///     Gets the sale object of the class.
        /// </summary>
        /// <returns>The Sale Object of the class</returns>
        public Sale GetSale()
        {
            return sale;
        }

        #endregion

        #region SaveSale()
        /// <summary>
        ///     Stores the textbox fields into a sale object
        /// </summary>
        public void SaveSale()
        {
            Item item = sale.Items.First();

            item.ItemType = (ItemType)comboBoxItemType.SelectedItem;
            sale.Date = dateTimePicker1.Value;

            item.Line1 = textBoxLine1.Text;
            item.Line2 = textBoxLine2.Text;
            item.Line3 = textBoxLine3.Text;

            item.Section = (Section)comboBoxSection.SelectedItem;
            item.Sale = sale;
        }

        #endregion

        #region SetPriceField()
        /// <summary>
        ///     Sets the price field to the correct price of the type selected in the combobox of ItemTypes
        /// </summary>
        private void SetPriceField()
        {
            using (var context = new Context())
            {
                if (this.comboBoxItemType.SelectedIndex > 0 &&
                    !this.comboBoxItemType.Text.Trim().Equals(""))
                {
                    this.textBoxPrice.Text = ((ItemType)comboBoxItemType.SelectedItem).Price.ToString("0.00");
                }
                else
                    this.textBoxPrice.Text = "";
            }
        }

        #endregion


        #region LoadComboBox()
        /// <summary>
        ///     Loads the ItemTypes combobox with a list of ItemTypes from the database.
        /// </summary>
        private void LoadComboBox()
        {
            using (var context = new Context())
            {
                this.comboBoxItemType.Items.Add("<Select Item>");

				context.ItemTypes.Load();
				comboBoxItemType.DataSource = context.ItemTypes.Local.ToBindingList();
				comboBoxItemType.DisplayMember = "Type";

				this.comboBoxItemType.SelectedIndex = 0;

				this.comboBoxSection.Items.Add("<Select Item>");
				
				context.Sections.Load();
				comboBoxSection.DataSource = context.Sections.Local.ToBindingList();
				comboBoxSection.DisplayMember = "Location";
	
				comboBoxSection.SelectedIndex = 0;
            }
        }

        #endregion

        private void calculateTotal()
        {
            try
            {
                labelTotalCalc.Text = "" +
                    (Decimal.Parse(textBoxPrice.Text)
                   + Decimal.Parse(textBoxDonation.Text.Trim()));
            }
            catch (Exception)
            {
                labelTotal.Text = "";
            }
        }

        private void sectionChanged()
        {
            if (comboBoxSection.SelectedIndex > -1 && !comboBoxSection.Text.Trim().Equals(""))
            {
                labelDescriptionVar.Text = ((Section)comboBoxSection.SelectedItem)
                    .Description;
            }
            else
            {
                labelDescriptionVar.Text = "";
            }
        }

        #endregion

        #region Events

        #region comboBoxItemType_SelectedIndexChanged(object sender, MouseEventArgs e)
        /// <summary>
        ///     Handles the event of when the selection item is changed
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void comboBoxItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPriceField();
        }

        #endregion

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        #endregion

        private void comboBoxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            sectionChanged();
        }
    }
}
