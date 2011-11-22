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
        private TeamJDBEntities context = new TeamJDBEntities();

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
                              where (people.FirstName + people.LastName == search)
                              || (people.LastName + people.FirstName == search)
                              || (people.LastName == search)
                              || (people.FirstName == search)
                              orderby people.LastName
                              select people;

            // populate listbox wit results
            foreach (var result in peopleQuery)
            {
                this.listBoxSelect.Items.Add(result.FirstName + " " + result.LastName);
            }
        }

        #endregion

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
            // TODO:  launch wizard to create a new donor
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

        #region showSelectedPerson(String selection)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selection">Name of person selected</param>
        private void showSelectedPerson(String selection)
        {
            // TODO:  launch the panel with the persons info
        }

        #endregion

        #endregion
    }
}
