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
        private List<Sale> sales;
        TeamJDBEntities context = new TeamJDBEntities();

        public ShowDonorPanel()
        {
            InitializeComponent();
        }

        public ShowDonorPanel(List<Sale> sales)
        {
            // sales should be from the same donor

            InitializeComponent();

            if (sales != null && sales.Count > 0)
            {
                this.sales = sales;
            }
        }

        private void radioButtonBrick_CheckedChanged(object sender, EventArgs e)
        {
            // change the image to the brick of the user and make the lineText labels visible
        }

        private void radioButtonSection_CheckedChanged(object sender, EventArgs e)
        {
            // change the image to the section of the selected recipients brick
        }

        private void listBoxRecipients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // change the tabpageRecipient to the selected recipient
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Guid donorID;
            Guid recipientID;

            // Update the fields of the selectedRecipient/donor
            // Process the donor information
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
            
            MessageBox.Show(donor.PersonID + "\n" +
                donor.FirstName + "\n" +
                donor.MiddleName + "\n" +
                donor.LastName + "\n" +
                donor.Addr + "\n" +
                donor.City + "\n" +
                donor.State + "\n" +
                donor.Zip + "\n" +
                donor.Phone + "\n" +
                donor.Email + "\n" +
                recipient.PersonID + "\n" +
                recipient.FirstName + "\n" +
                recipient.MiddleName + "\n" +
                recipient.LastName + "\n" +
                recipient.Addr + "\n" +
                recipient.City + "\n" +
                recipient.State + "\n" +
                recipient.Zip + "\n" +
                recipient.Phone + "\n" +
                recipient.Email + "\n" +
                sale.DonorID + "\n" +
                sale.DedicationID + "\n" +
                sale.Cost + "\n" +
                sale.Date + "\n" +
                item.ItemID + "\n" +
                item.ItemTypeID + "\n");
        }
    }
}
