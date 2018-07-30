namespace USDConfigurator
{
    partial class USDConfiguratorPluginControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USDConfiguratorPluginControl));
            this.toolStrip_main = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_About = new System.Windows.Forms.ToolStripButton();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.toolStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_main
            // 
            this.toolStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_About});
            this.toolStrip_main.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_main.Name = "toolStrip_main";
            this.toolStrip_main.Size = new System.Drawing.Size(150, 25);
            this.toolStrip_main.TabIndex = 0;
            this.toolStrip_main.Text = "Main Tool Strip";
            // 
            // toolStripButton_About
            // 
            this.toolStripButton_About.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_About.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_About.Image")));
            this.toolStripButton_About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_About.Name = "toolStripButton_About";
            this.toolStripButton_About.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton_About.Text = "About";
            this.toolStripButton_About.Click += new System.EventHandler(this.toolStripButton_About_Click);
            // 
            // tabControl_main
            // 
            this.tabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_main.Location = new System.Drawing.Point(0, 25);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(150, 125);
            this.tabControl_main.TabIndex = 1;
            // 
            // USDConfiguratorPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl_main);
            this.Controls.Add(this.toolStrip_main);
            this.Name = "USDConfiguratorPluginControl";
            this.toolStrip_main.ResumeLayout(false);
            this.toolStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_main;
        private System.Windows.Forms.ToolStripButton toolStripButton_About;
        private System.Windows.Forms.TabControl tabControl_main;
    }
}
