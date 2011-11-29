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
    public partial class SearchPanel : Panel
    {
        #region Private Variables

        private TeamJDBEntities context = new TeamJDBEntities();
        private Panel showingPanel = null;

        #endregion

        #region Constructors

        #region SearchPanel()
        /// <summary>
        /// Constructs the search panel
        /// </summary>
        public SearchPanel()
        {
            InitializeComponent();
        }

        #endregion

        #region SearchPanel(String search)
        /// <summary>
        /// Constructs the search panel
        /// </summary>
        /// <param name="search">Name of person to search</param>
        public SearchPanel(String search)
        {
            InitializeComponent();
            this.textBoxSearch.Text = search;
            setSearchString(search);
        }

        #endregion

        #endregion

        #region Private Methods

        #region setSearchString(String search)
        /// <summary>
        /// Sets up the query and populates the list box with the results
        /// </summary>
        /// <param name="search">Name of person to search</param>
        private void setSearchString(String search)
        {
            // Make sure list box will show new search results
            this.listBoxSelect.Items.Clear();

            // query database for any combination of users entered
            var peopleQuery = from people in context.People
                              join sale in context.Sales
                                on people.PersonID equals sale.DonorID
                              where (people.FirstName + people.LastName == search)
                              || (people.LastName + people.FirstName == search)
                              || (people.FirstName.Contains(search))
                              || (people.LastName.Contains(search))
                              || (people.LastName == search)
                              || (people.FirstName == search)
                              orderby sale.Date descending
                              select new { sale, people };

            // populate listbox wit results
            foreach (var result in peopleQuery)
            {
                this.listBoxSelect.Items.Add(result.people.FirstName+ " " + result.people.LastName + " - " + result.sale.Date.ToShortDateString() + " - " + "Donor");
            }

            peopleQuery = from people in context.People
                          join sale in context.Sales
                            on people.PersonID equals sale.DedicationID
                          where (people.FirstName + people.LastName == search)
                          || (people.LastName + people.FirstName == search)
                          || (people.FirstName.Contains(search))
                          || (people.LastName.Contains(search))
                          || (people.LastName == search)
                          || (people.FirstName == search)
                          orderby sale.Date descending
                          select new { sale, people };

            // populate listbox wit results
            foreach (var result in peopleQuery)
            {
                this.listBoxSelect.Items.Add(result.people.FirstName + " " + result.people.LastName + " - " + result.sale.Date.ToShortDateString() + " - " + "Recipient");
            }

            this.listBoxSelect.Sorted = true;
        }

        #endregion

        #region showSelectedPerson(String selection)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selection">Name of person selected</param>
        private void showSelectedPerson(String selection)
        {
            Program.mForm.setPanel(new ShowDonorPanel());
        }

        #endregion

        #endregion

        #region Events

        #region buttonSearch_Click(object sender, EventArgs e)
        /// <summary>
        /// Searchs for all combinations of the name entered
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            setSearchString(textBoxSearch.Text);
        }

        #endregion

        #region buttonSelect_Click(object sender, EventArgs e)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBoxSelect.SelectedIndex > -1)
            {
                showSelectedPerson(listBoxSelect.SelectedItem.ToString());
            }
        }

        #endregion

        #region buttonNew_Click(object sender, EventArgs e)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonNew_Click(object sender, EventArgs e)
        {
            Program.mForm.setPanel(new ShowDonorPanel());
        }

        #endregion

        #region listBoxSelect_MouseDoubleClick(object sender, MouseEventArgs e)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void listBoxSelect_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxSelect.SelectedIndex > -1)
            {
                showSelectedPerson(listBoxSelect.SelectedItem.ToString());
            }
        }

        #endregion

        #region textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
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

            if (Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region textBoxSearch_KeyUp(object sender, EventArgs e)
        /// <summary>
        ///     Handles the event that a "Enter" is struck
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setSearchString(textBoxSearch.Text);
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion

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

        #region textBoxSearch_Leave(object sender, EventArgs e)
        //  I, Jordan, removed this section, because although it may be appropriate to remove the search
        //  entry on the main form when the user leaves the search box, this probably isn't the case on 
        //  the search panel form.
        /// <summary>
        ///     Determines if "Enter Name Here" should be entered into the search textbox
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        //private void textBoxSearch_Leave(object sender, EventArgs e)
        //{
        //    if (textBoxSearch.Text == "")
        //    {
        //        textBoxSearch.Text = "Enter Name Here";
        //    }
        //}

        #endregion

        #endregion

        // #endregion
    }
}
