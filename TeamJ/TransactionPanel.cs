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
    public partial class TransactionPanel : Panel
    {
        TeamJDBEntities context = new TeamJDBEntities();
        private Sale sale = new Sale();
        public TransactionPanel()
        {
            InitializeComponent();

            try
            {
                LoadComboBox();
                SetPriceField();
            }
            catch (Exception) { }
        }

        public TransactionPanel(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            try
            {
                LoadComboBox();
                SetPriceField();
            }
            catch (Exception) {  }
        }

        private void comboBoxItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetPriceField();
        }
        
        public void SetSale(Sale s)
        {
            this.sale = s;
            this.textBoxPrice.Text = s.Cost.ToString();
            this.dateTimePicker1.Text = s.Date.ToString();
        }

        public Sale GetSale()
        {
            return sale;
        }

        public void SaveSale()
        {
            sale.SaleID = Guid.NewGuid();
            sale.Cost = decimal.Parse(textBoxPrice.Text.ToString());
            sale.Date = dateTimePicker1.Value;
        }

        private void SetPriceField()
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

        private void LoadComboBox()
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

        public Guid GetItemID()
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
}
