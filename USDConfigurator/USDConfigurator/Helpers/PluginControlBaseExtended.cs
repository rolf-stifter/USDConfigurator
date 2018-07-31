using System;
using USDConfigurator.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Args;
using XrmToolBox.Extensibility.Interfaces;

namespace USDConfigurator.Helpers
{
    public class PluginControlBaseExtended : PluginControlBase, IGitHubPlugin, IPayPalPlugin, IHelpPlugin, IAboutPlugin, IStatusBarMessenger
    {
        #region XrmToolBox Plugins
        #region Github
        public string RepositoryName => "USDConfigurator";
        public string UserName => "rolf-stifter";
        #endregion
        #region Paypal
        public string DonationDescription => "XrmToolBox: USDConfigurator";
        public string EmailAccount => "rolfstifter@hotmail.com";
        #endregion
        #region Help
        public string HelpUrl => "https://github.com/rolf-stifter/USDConfigurator/wiki";
        #endregion
        #region About
        public void ShowAboutDialog()
        {
            new AboutBox().ShowDialog();
        }
        #endregion
        #region Status Bar Messager
        public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;
        public void SendInfoToStatusBar(int progressPercentage, string message)
        {
            SendMessageToStatusBar?.Invoke(this, new StatusBarMessageEventArgs(progressPercentage, message));
        }
        public void SendInfoToStatusBar(int progressPercentage)
        {
            SendMessageToStatusBar?.Invoke(this, new StatusBarMessageEventArgs(progressPercentage));
        }
        #endregion
        #endregion
    }
}
