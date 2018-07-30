using System;
using USDConfigurator.Helpers;

namespace USDConfigurator
{
    public partial class USDConfiguratorPluginControl : PluginControlBaseExtended
    {
        public USDConfiguratorPluginControl()
        {
            InitializeComponent();
        }

        private void toolStripButton_About_Click(object sender, EventArgs e)
        {
            ShowAboutDialog();
        }
    }
}
