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
        #region Private Variables

        private Panel showingPanel = null;

        #endregion

        #region Constructors

        #region MainForm()
        /// <summary>
        ///     Constructs a MainForm object
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.buttonNewDonor.Focus();
        }

        #endregion

        #endregion

        #region Public Methods

        #region setPanel(Panel p)
        /// <summary>
        ///     Sets the Panel
        /// </summary>
        /// <param name="p"></param>
        public void setPanel(Panel p)
        {
            if (showingPanel != null)
                panelFloat.Controls.Remove(showingPanel);

            showingPanel = p;

            this.panelFloat.BringToFront();
            this.panelFloat.Visible = true;

            panelFloat.Controls.Add(p);
        }

        #endregion

        #endregion

        #region Events

        #region MainForm_Click(object sender, EventArgs e)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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

        #endregion

        #region buttonSearch_Click(object sender, EventArgs e)
        /// <summary>
        ///     Creates a SearchPanel.
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchPanel sp = new SearchPanel(textBoxSearch.Text);

            setPanel(sp);
        }

        #endregion

        #region buttonNewDonor_Click(object sender, EventArgs e)
        /// <summary>
        ///     Sets the ShowDonorPanel onto the MainForm
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonNewDonor_Click(object sender, EventArgs e)
        {
            // setPanel(donorPanel(new donor)
            setPanel(new ShowDonorPanel());
        }

        #endregion

        #region buttonReport_Click(object sender, EventArgs e)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonReport_Click(object sender, EventArgs e)
        {
            //  setPanel(new createreportPanel);
            AdvancedSearchPanel panel = new AdvancedSearchPanel();
            setPanel(panel);
            panel.Visible = true;
        }

        #endregion

        #region textBoxSearch_KeyPress(object sender, EventArgs e)
        /// <summary>
        ///     Handles the event when the user strikes a key on the keyboard.
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxSearch.Text == "Enter Name Here")
            {
                textBoxSearch.Text = "";
            }

            base.OnKeyPress(e);

            // Determine if the key that was struck is a letter
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                textBoxSearch.Text += e.KeyChar;
                
            }
            else if(Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }

            // Determines if the search button should be enabled/disabled
            if (textBoxSearch.Text == "" || textBoxSearch.Text == "Enter Name Here")
            {
                buttonSearch.Enabled = false;
            }
            else
            {
                buttonSearch.Enabled = true;
            }

            this.textBoxSearch.SelectionStart = this.textBoxSearch.Text.Length;
        }

        #endregion

        #region textBoxSearch_Leave(object sender, EventArgs e)
        /// <summary>
        ///     Determines if "Enter Name Here" should be entered into the search textbox
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = "Enter Name Here";
            }
        }

        #endregion

        #endregion
    }
}
