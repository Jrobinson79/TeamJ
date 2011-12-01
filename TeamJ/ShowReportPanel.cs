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
    public partial class ShowReportPanel : UserControl
    {
        #region Private Variables

        #endregion

        #region Constructors

        #region ShowReportPanel()
        /// <summary>
        /// Constructs the ShowReportPanel
        /// </summary>
        public ShowReportPanel()
        {
            InitializeComponent();
            initialize();
        }

        #endregion

        #region ShowReportPanel(IContainer container)
        /// <summary>
        /// Constructs the ShowReportPanel
        /// </summary>
        /// <param name="container"></param>
        public ShowReportPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            initialize();
        }

        #endregion

        #endregion

        #region Private Methods

        #region initialize();

        private void initialize()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

        #endregion

        #region Events

        #endregion
    }
}
