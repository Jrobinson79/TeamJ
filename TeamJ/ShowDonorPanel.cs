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
            // Update the fields of the selectedRecipient/donor
        }
    }
}
