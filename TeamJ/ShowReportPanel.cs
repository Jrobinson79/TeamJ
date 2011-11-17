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
        public ShowReportPanel()
        {
            InitializeComponent();
        }

        public ShowReportPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
