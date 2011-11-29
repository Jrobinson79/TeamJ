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

        #endregion

        #region Constructors

        #region MainForm()
        /// <summary>
        ///     Constructs a MainForm object
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
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
            panelToShow.Controls.Clear();

            this.panelFloat.BringToFront();
            this.panelFloat.Visible = true;

            panelToShow.Controls.Add(p);

            tableLayoutPanelButtons.Visible = false;
        }

        public void hidePanel()
        {
            if (panelFloat.Visible)
            {
                panelFloat.Visible = false;
                panelFloat.SendToBack();
                panelToShow.Controls.Clear();

                tableLayoutPanelButtons.Visible = true;
            }
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
            hidePanel();
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
            setPanel(new SearchPanel(textBoxSearch.Text));
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
            setPanel(new ShowReportPanel());
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
            // Determine if the textbox should be cleared
            if (textBoxSearch.Text.Equals("Enter Name Here"))
            {
                textBoxSearch.Clear();
            }

            if(Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void labelBackToHome_Click(object sender, EventArgs e)
        {
            hidePanel();
        }

        #endregion

        private void buttonAdvancedSearch_Click(object sender, EventArgs e)
        {
            setPanel(new AdvancedSearchPanel());
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //  Search for transaction when user keys enter
            if (buttonSearch.Enabled && e.KeyCode == Keys.Enter)
                setPanel(new SearchPanel(textBoxSearch.Text));
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // Determines if the search button should be enabled/disabled
            if (textBoxSearch.Text.Trim().Equals("") || textBoxSearch.Text.Equals("Enter Name Here"))
            {
                buttonSearch.Enabled = false;
            }
            else
            {
                buttonSearch.Enabled = true;
            }
        }
    }
}
