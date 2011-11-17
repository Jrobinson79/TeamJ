using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TeamJ
{
    public partial class AdvancedSearchPanel : Component
    {
        public AdvancedSearchPanel()
        {
            InitializeComponent();
        }

        public AdvancedSearchPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
