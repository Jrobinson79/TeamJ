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
        private String search = "";

        public SearchPanel()
        {
            InitializeComponent();
        }

        public SearchPanel(String search)
        {
            InitializeComponent();
            setSearchString(search);
        }

        public void setSearchString(String search)
        {
            this.search = search;
            this.textBoxSearch.Text = search;

            // TODO:  Perform search and update list box
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // TODO:  search for the person and update list box
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBoxSelect.SelectedIndex > -1)
            {
                showSelectedPerson(listBoxSelect.SelectedItem.ToString());
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            // TODO:  launch wizard to create a new donor
        }

        private void listBoxSelect_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxSelect.SelectedIndex > -1)
            {
                showSelectedPerson(listBoxSelect.SelectedItem.ToString());
            }
        }

        private void showSelectedPerson(String selection)
        {
            // TODO:  launch the panel with the persons info
        }
    }
}
