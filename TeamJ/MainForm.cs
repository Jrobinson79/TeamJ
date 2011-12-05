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
        public void setPanel(UserControl p)
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
            search();
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
            //setPanel(new ShowReportPanel());
            SectionPopup popup = new SectionPopup();
            popup.ShowDialog();
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

        private void textBoxHighlight(object sender, EventArgs e)
        {
            textBoxSearch.SelectAll();
        }

        #region buttonAdvancedSearch_Click(object sender, EventArgs e)
        /// <summary>
        ///     Brings up the advanced search panel
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonAdvancedSearch_Click(object sender, EventArgs e)
        {
            setPanel(new AdvancedSearchPanel());
        }

        #endregion

        #region textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        /// <summary>
        ///     determines if the enter key will go to the search page.
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //  Search for transaction when user keys enter
            if (buttonSearch.Enabled && e.KeyCode == Keys.Enter)
                search();
        }

        #endregion

        private void search()
        {
            String search = textBoxSearch.Text;
            setPanel(new SearchPanel(search));
            textBoxSearch.Text = "Enter Name Here";
        }

        #region textBoxSearch_TextChanged(object sender, EventArgs e)
        /// <summary>
        ///     Determines if the search button is visible
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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

        #endregion

        #region labelBackToHome_Click(object sender, EventArgs e)
        /// <summary>
        ///     Sends the user back to the main page.
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void labelBackToHome_Click(object sender, EventArgs e)
        {
            hidePanel();
        }

        #endregion

        #endregion
    }
}
