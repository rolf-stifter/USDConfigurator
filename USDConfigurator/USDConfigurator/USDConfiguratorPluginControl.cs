using System;
using USDConfigurator.Helpers;
using XrmToolBox.Extensibility;

namespace USDConfigurator
{
    public partial class USDConfiguratorPluginControl : PluginControlBaseExtended
    {
        public USDConfiguratorPluginControl()
        {
            InitializeComponent();
        }

        private void toolStripButton_retrieveData_Click(object sender, EventArgs e)
        {
            GetCRMData();
        }

        private void toolStripButton_About_Click(object sender, EventArgs e)
        {
            ShowAboutDialog();
        }

        private void GetCRMData()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieving USD Data",
                Work = (w, e) =>
                {
                       
                },
                ProgressChanged = e =>
                {
                    SetWorkingMessage(e.UserState.ToString());
                    SendInfoToStatusBar(e.ProgressPercentage);
                },
                PostWorkCallBack = e =>
                {
                    
                },
                IsCancelable = true
            });
        }
    }
}