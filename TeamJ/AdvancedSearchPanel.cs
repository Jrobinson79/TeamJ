using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeamJ
{
    public partial class AdvancedSearchPanel : Panel
    {

        #region Private Variables

        TeamJDBEntities context = new TeamJDBEntities();

        #endregion

        #region Constructors

        #region AdvancedSearchPanel()
        /// <summary>
        ///     Constructs an AdvancedSearchPanel object
        /// </summary>
        public AdvancedSearchPanel()
        {
            InitializeComponent();
            PopulateMenus();
        }

        #endregion

        #endregion

        #region Private Methods

        #region PopulateMenus()
        /// <summary>
        ///     Loads the ItemTypes combobox with a list of ItemTypes from the database.
        /// </summary>
        private void PopulateMenus()
        {
            // Load the items combobox
            this.itemComboBox.Items.Add("<Select Item>");

            var itemQuery = from itemType in context.ItemTypes
                            select itemType;

            foreach (var result in itemQuery)
            {
                this.itemComboBox.Items.Add(result.Type.ToString());
            }

            this.itemComboBox.SelectedIndex = 0;

            // Load the sections combobox
            this.sectionComboBox.Items.Add("<Select Item>");

            var sectionQuery = from section in context.Sections
                            select section;

            foreach (var result in sectionQuery)
            {
                this.sectionComboBox.Items.Add(result.Description.ToString());
            }

            this.sectionComboBox.SelectedIndex = 0;
        
        }

        #endregion

        #endregion

        #region Events

        #endregion
    }
}
