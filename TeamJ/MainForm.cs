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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void setPanel(Panel p)
        {
            if (showingPanel != null)
                panelFloat.Controls.Remove(showingPanel);

            showingPanel = p;

            this.panelFloat.BringToFront();
            this.panelFloat.Visible = true;

            panelFloat.Controls.Add(p);
        }

        private Panel showingPanel = null;

        private void MainForm_Click(object sender, EventArgs e)
        {
            if (panelFloat.Visible)
            {
                panelFloat.Visible = false;
                panelFloat.SendToBack();
                panelFloat.Controls.Remove(showingPanel);
                showingPanel = null;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchPanel sp = new SearchPanel(textBoxSearch.Text);

            setPanel(sp);
        }

        private void buttonNewDonor_Click(object sender, EventArgs e)
        {
            // setPanel(donorPanel(new donor)
            setPanel(new ShowDonorPanel());
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            //  setPanel(new createreportPanel);
            AdvancedSearchPanel panel = new AdvancedSearchPanel();
            setPanel(panel);
            panel.Visible = true;
        }
    }
}
