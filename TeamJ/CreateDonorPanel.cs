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
        public CreateDonorPanel()
        {
            InitializeComponent();
        }

        public CreateDonorPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
