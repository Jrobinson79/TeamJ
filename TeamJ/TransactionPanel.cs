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

namespace TeamJ
{
    public partial class TransactionPanel : UserControl
    {
        #region Private Methods
        private Sale sale = new Sale();

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

            try
            {
                LoadComboBox();
                SetPriceField();
            }
            catch (Exception) { }
        }

        #endregion

        #region SetSale(Sale s)
        /// <summary>
        ///     Sets the textbox fields from the data contained in the Sale parameter
        /// </summary>
        /// <param name="s">The Sale object that needs to be loaded into the textbox fields</param>
        public void SetSale(Sale s)
        {
            this.sale = s;
            this.textBoxPrice.Text = s.Cost.ToString();
            this.dateTimePicker1.Text = s.Date.ToString();
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
            sale.SaleID = Guid.NewGuid();
            sale.Cost = decimal.Parse(textBoxPrice.Text.ToString());
            sale.Date = dateTimePicker1.Value;
        }

        #endregion

        #region SetPriceField()
        /// <summary>
        ///     Sets the price field to the correct price of the type selected in the combobox of ItemTypes
        /// </summary>
        private void SetPriceField()
        {
            using (TeamJDBEntities context = new TeamJDBEntities())
            {
                if (this.comboBoxItemType.SelectedIndex == 0)
                {
                    textBoxPrice.Text = "";
                }
                else
                {
                    string selectedItem = this.comboBoxItemType.GetItemText(this.comboBoxItemType.SelectedItem).ToString();

                    var itemPriceQuery = from itemType in context.ItemTypes
                                         where itemType.Type == selectedItem
                                         select itemType;

                    foreach (var result in itemPriceQuery)
                    {
                        this.textBoxPrice.Text = result.Price.ToString("0.00");
                    }
                }
            }
        }

        #endregion

        #region LoadComboBoox()
        /// <summary>
        ///     Loads the ItemTypes combobox with a list of ItemTypes from the database.
        /// </summary>
        private void LoadComboBox()
        {
            using (TeamJDBEntities context = new TeamJDBEntities())
            {
                this.comboBoxItemType.Items.Add("<Select Item>");

                var itemQuery = from itemType in context.ItemTypes
                                select itemType;

                foreach (var result in itemQuery)
                {
                    this.comboBoxItemType.Items.Add(result.Type.ToString());
                }

                this.comboBoxItemType.SelectedIndex = 0;
            }
        }

        #endregion

        #region GetItemID()
        /// <summary>
        ///     Returns the ItemType ID of the item selected in the combobox
        /// </summary>
        /// <returns>The Guid ID of the ItemType</returns>
        public Guid GetItemID()
        {
            using (TeamJDBEntities context = new TeamJDBEntities())
            {
                string selectedItem = this.comboBoxItemType.GetItemText(this.comboBoxItemType.SelectedItem).ToString();

                var itemIDQuery = from itemID in context.ItemTypes
                                  where itemID.Type == selectedItem
                                  select itemID;

                foreach (var result in itemIDQuery)
                {
                    return result.ItemTypeID;
                }

                return Guid.Parse(null);
            }
        }

        #endregion

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

        #endregion
    }
}
