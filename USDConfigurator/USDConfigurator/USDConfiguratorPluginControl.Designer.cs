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
            this.toolStripButton_retrieveData = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_about = new System.Windows.Forms.ToolStripButton();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.toolStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_main
            // 
            this.toolStrip_main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_retrieveData,
            this.toolStripButton_about});
            this.toolStrip_main.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_main.Name = "toolStrip_main";
            this.toolStrip_main.Size = new System.Drawing.Size(150, 25);
            this.toolStrip_main.TabIndex = 0;
            this.toolStrip_main.Text = "Main Tool Strip";
            // 
            // toolStripButton_retrieveData
            // 
            this.toolStripButton_retrieveData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_retrieveData.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_retrieveData.Image")));
            this.toolStripButton_retrieveData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_retrieveData.Name = "toolStripButton_retrieveData";
            this.toolStripButton_retrieveData.Size = new System.Drawing.Size(80, 22);
            this.toolStripButton_retrieveData.Text = "Retrieve Data";
            this.toolStripButton_retrieveData.Click += new System.EventHandler(this.toolStripButton_retrieveData_Click);
            // 
            // toolStripButton_about
            // 
            this.toolStripButton_about.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_about.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_about.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_about.Image")));
            this.toolStripButton_about.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_about.Name = "toolStripButton_about";
            this.toolStripButton_about.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton_about.Text = "About";
            this.toolStripButton_about.Click += new System.EventHandler(this.toolStripButton_About_Click);
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
        private System.Windows.Forms.ToolStripButton toolStripButton_about;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.ToolStripButton toolStripButton_retrieveData;
    }
}
