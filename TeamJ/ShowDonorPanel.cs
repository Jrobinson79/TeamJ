using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeamJ
{
    public partial class ShowDonorPanel : Panel
    {
        #region Private Variables

        private List<Sale> sales;
        private TeamJDBEntities context = new TeamJDBEntities();
        private List<List<string>> ids = new List<List<string>>();

        #endregion

        #region Constructors

        #region ShowDonorPanel()
        /// <summary>
        ///     Constructs a ShowDonorPanel object
        /// </summary>
        public ShowDonorPanel()
        {
            InitializeComponent();
            this.buttonUpdate.Text = "Create";

            this.tableLayoutPanelBottomLeft.Visible = false;

            this.tableLayoutPanelMainBottom.ColumnStyles.Clear();
            this.tableLayoutPanelMainBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelMainBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            this.tableLayoutPanelMainBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelMainBottom.Controls.Add(tableLayoutPanelBottomRight, 1, 0);
        }

        #endregion

        #region ShowDonorPanel(ListBox list, string selectedName)
        /// <summary>
        ///     Constructs a ShowDonorPanel object
        /// </summary>
        /// <param name="sales"></param>
        public ShowDonorPanel(ListBox list, string selectedName)
        {
            // sales should be from the same donor

            InitializeComponent();

            listBoxResults.Items.AddRange(list.Items);
            listBoxResults.SelectedIndex = list.FindString(selectedName);
        }

        #endregion

        #region ShowDonorPanel(string search)
        /// <summary>
        ///     Constructs a ShowDonorPanel object
        /// </summary>
        /// <param name="sales"></param>
        public ShowDonorPanel(string search)
        {
            // sales should be from the same donor

            InitializeComponent();
        }

        #endregion

        #endregion

        #region Private Methods

        #region selectBrickImage(String lineText1, String lineText2, String lineText3)
        /// <summary>
        /// This method sets the image as the brick image.  lineText1 should have a value before
        /// lineText2, and lineText2 should have a value before lineText3 is given a value.
        /// ("String Line 1", null, null) would show one line of text.
        /// ("String line 1", "String line 2", null) would show two lines of text.
        /// ("String line 1", "String line 2", "String line 3) would show three lines of text.
        /// </summary>
        /// <param name="lineText1"></param>
        /// <param name="lineText2"></param>
        /// <param name="lineText3"></param>
        private void selectBrickImage(String lineText1, String lineText2, String lineText3)
        {
            tableLayoutPanelImageBorder.Controls.Remove(panelSectionImage);

            this.tableLayoutPanelImage.ColumnStyles.Clear();
            this.tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            this.tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            this.tableLayoutPanelImageBorder.RowStyles.Clear();
            this.tableLayoutPanelImageBorder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelImageBorder.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            this.tableLayoutPanelImageBorder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            this.tableLayoutPanelImageBorder.Controls.Add(panelBrickImage, 0, 1);

            tableLayoutPanelBrickText.Controls.Remove(labelBrickTextLine1);
            tableLayoutPanelBrickText.Controls.Remove(labelBrickTextLine2);
            tableLayoutPanelBrickText.Controls.Remove(labelBrickTextLine3);
            tableLayoutPanelBrickText2.Controls.Remove(labelBrickTextLine1);
            tableLayoutPanelBrickText2.Controls.Remove(labelBrickTextLine2);

            if (lineText3 == null)
            {
                // Only one line of text
                if (lineText2 == null)
                {
                    this.tableLayoutPanelBrickText.RowStyles.Clear();
                    this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                    this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                    this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                    this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

                    this.tableLayoutPanelBrickText.Controls.Add(labelBrickTextLine1, 0, 2);

                    labelBrickTextLine1.Text = lineText1;
                }
                //  Two lines of text
                else
                {
                    this.tableLayoutPanelBrickText2.RowStyles.Clear();
                    this.tableLayoutPanelBrickText2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    this.tableLayoutPanelBrickText2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                    this.tableLayoutPanelBrickText2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                    this.tableLayoutPanelBrickText2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

                    this.tableLayoutPanelBrickText.Controls.Add(labelBrickTextLine1, 0, 1);
                    this.tableLayoutPanelBrickText.Controls.Add(labelBrickTextLine2, 0, 2);

                    labelBrickTextLine1.Text = lineText1;
                    labelBrickTextLine2.Text = lineText2;
                }
            }
            // Three lines of text
            else
            {
                this.tableLayoutPanelBrickText.RowStyles.Clear();
                this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

                this.tableLayoutPanelBrickText.Controls.Add(labelBrickTextLine1, 0, 1);
                this.tableLayoutPanelBrickText.Controls.Add(labelBrickTextLine2, 0, 2);
                this.tableLayoutPanelBrickText.Controls.Add(labelBrickTextLine3, 0, 3);

                labelBrickTextLine1.Text = lineText1;
                labelBrickTextLine2.Text = lineText2;
                labelBrickTextLine3.Text = lineText3;
            }
        }

        #endregion

        #region
        /// <summary>
        /// This method shows the section image.  Passing in a null value 
        /// will show the default section image.
        /// </summary>
        /// <param name="section"></param>
        private void selectSectionImage(Section section)
        {
            tableLayoutPanelImageBorder.Controls.Remove(panelBrickImage);

            this.tableLayoutPanelImage.ColumnStyles.Clear();
            this.tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            this.tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            this.tableLayoutPanelImageBorder.RowStyles.Clear();
            this.tableLayoutPanelImageBorder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelImageBorder.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            this.tableLayoutPanelImageBorder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            panelSectionImage.BackgroundImage = Properties.Resources.Plaza;

            switch (section.Location)
            {
                case "A":
                    panelSectionImage.BackgroundImage = Properties.Resources.Plaza_A;
                    break;
                case "B":
                    panelSectionImage.BackgroundImage = Properties.Resources.Plaza_B;
                    break;
                case "C":
                    panelSectionImage.BackgroundImage = Properties.Resources.Plaza_C;
                    break;
                case "D":
                    panelSectionImage.BackgroundImage = Properties.Resources.Plaza_D;
                    break;
                case "E":
                    panelSectionImage.BackgroundImage = Properties.Resources.Plaza_E;
                    break;
                case "F":
                    panelSectionImage.BackgroundImage = Properties.Resources.Plaza_F;
                    break;
                case "G":
                    panelSectionImage.BackgroundImage = Properties.Resources.Plaza_G;
                    break;
                case "H":
                    panelSectionImage.BackgroundImage = Properties.Resources.Plaza_H;
                    break;
            }

            this.tableLayoutPanelImageBorder.Controls.Add(panelSectionImage, 0, 1);
        }

        #endregion

        #endregion

        #region Events

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBrick.Checked)
                selectBrickImage(null, null, null);
            else
                selectSectionImage(null);
        }

        #region listBoxRecipients_SelectedIndexChanged(object sender, MouseEventArgs e)
        /// <summary>
        ///     Handles the event that a new selection was made in the listbox.
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void listBoxRecipients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // change the tabpageRecipient to the selected recipient
        }

        #endregion

        #region buttonUpdate_Click(object sender, MouseEventArgs e)
        /// <summary>
        ///     Loads data entered into the database, enforcing mappings
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Guid donorID;
            Guid recipientID;

            PersonInfoPanel donorPanel = (PersonInfoPanel)personInfoPanelDonor;
            donorPanel.savePerson();
            Person donor = donorPanel.getPerson();

            if (donorPanel.HasPerson(donor))
            {
                donorID = Guid.Parse(donorPanel.GetID());
            }
            else
            {
                donorID = donor.PersonID;
                context.People.AddObject(donor);
            }

            // Process the recipient information
            PersonInfoPanel recipientPanel = (PersonInfoPanel)personInfoPanelRecipient;
            recipientPanel.savePerson();
            Person recipient = recipientPanel.getPerson();

            if (recipientPanel.HasPerson(recipient))
            {
                recipientID = Guid.Parse(recipientPanel.GetID());
            }
            else
            {
                recipientID = recipient.PersonID;
                context.People.AddObject(recipient);
            }

            TransactionPanel salePanel = (TransactionPanel)transactionPanel1;

            salePanel.SaveSale();
            Sale sale = salePanel.GetSale();

            Item item = new Item();
            item.ItemID = Guid.NewGuid();
            item.ItemTypeID = salePanel.GetItemID();
                
            sale.SaleID = Guid.NewGuid();
            sale.DonorID = donorID;
            sale.DedicationID = recipientID;

            context.Sales.AddObject(sale);

            try
            {
                context.AcceptAllChanges();
            }
            catch(Exception) { }
        }

        #endregion

        #endregion
    }
}
