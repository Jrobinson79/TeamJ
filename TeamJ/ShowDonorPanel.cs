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
            this.labelDonor.Visible = false;
            this.labelDonorName.Visible = false;
            this.listBoxRecipients.Visible = false;
            this.groupBoxRecipients.Visible = false;
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

            listBoxRecipients.Items.AddRange(list.Items);
            listBoxRecipients.SelectedIndex = list.FindString(selectedName);
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

        #region Events

        #region radioButtonBrick_CheckedChanged(object sender, MouseEventArgs e)
        /// <summary>
        ///     Handles the event that the brick radio button selection was changed
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void radioButtonBrick_CheckedChanged(object sender, EventArgs e)
        {
            // change the image to the brick of the user and make the lineText labels visible
        }

        #endregion

        #region radioButtonSection_CheckedChanged(object sender, MouseEventArgs e)
        /// <summary>
        ///     Handles the event that the section radio button was changed
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void radioButtonSection_CheckedChanged(object sender, EventArgs e)
        {
            // change the image to the section of the selected recipients brick
        }

        #endregion

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
