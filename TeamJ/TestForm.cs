using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;

namespace TeamJ
{
    public partial class TestForm : Form
    {
        private TeamJDBEntities context = new TeamJDBEntities();

        public TestForm()
        {
            InitializeComponent();
        }

        private void showItemTypesButton_Clicked(object sender, EventArgs e)
        {

            List<ItemType> types = context.ItemTypes.ToList();
            String strList = "Type | Price\n\n";

            foreach (ItemType type in types)
            {
                strList += type.Type + ": " + type.Price + "\n";
            }

            MessageBox.Show(strList);

        }

        private void showAllSectionsButton_Click(object sender, EventArgs e)
        {
            List<Section> sections = context.Sections.ToList();
            String strSections = "Section | Description\n\n";

            foreach (Section section in sections)
            {
                strSections += section.Location + ": " + section.Description + "\n";
            }

            MessageBox.Show(strSections);

        }

        private void singleBrickSaleButton_Click(object sender, EventArgs e)
        {
            EntryForm ef = new EntryForm(context);
            ef.ShowDialog();
        }
    }
}
