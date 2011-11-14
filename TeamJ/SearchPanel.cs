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

        public void setSearchString(String search)
        {
            this.search = search;
            this.textBoxSearch.Text = search;
            textBoxSearch.Refresh();

            // TODO:  Perform search and update list box
        }
    }
}
