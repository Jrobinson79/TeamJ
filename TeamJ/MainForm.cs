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
            setPanel(new SearchPanel());
        }

        public void setPanel(Panel p)
        {
            this.panelFloat.BringToFront();
            this.panelFloat.Visible = true;

            panelFloat.Controls.Add(p);
            p.Dock = DockStyle.Fill;
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            if (panelFloat.Visible)
            {
                panelFloat.Visible = false;
                panelFloat.SendToBack();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchPanel sp = new SearchPanel();

            setPanel(sp);
            sp.setSearchString(textBoxSearch.Text);
        }

        private void buttonNewDonor_Click(object sender, EventArgs e)
        {
            // setPanel(donorPanel(new donor)
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            //  setPanel(new createreportPanel);
        }
    }
}
