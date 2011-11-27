using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TeamJ
{
    public partial class CreateDonorPanel : Component
    {
        #region Private Variables

        #endregion

        #region Constructors

        #region CreateDonorPanel()
        /// <summary>
        ///     Constructs a CreateDonorPanel object
        /// </summary>
        public CreateDonorPanel()
        {
            InitializeComponent();
        }

        #endregion

        #region CreateDonorPanel(IContainer container)
        /// <summary>
        ///     Constructs a CreateDonorPanel object
        /// </summary>
        /// <param name="container"></param>
        public CreateDonorPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #endregion

        #endregion

        #region Public Methods

        #endregion

        #region Events

        #endregion
    }
}
