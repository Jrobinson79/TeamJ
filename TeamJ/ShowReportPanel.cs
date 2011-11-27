using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TeamJ
{
    public partial class ShowReportPanel : Component
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
        }

        #endregion

        #endregion

        #region Private Methods

        #endregion

        #region Events

        #endregion
    }
}
