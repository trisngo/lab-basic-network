
namespace Lab4
{
    partial class Bai4_Lab4
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai4_Lab4));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnForward = new System.Windows.Forms.ToolStripButton();
            this.txtUrl = new System.Windows.Forms.ToolStripTextBox();
            this.btnGoto = new System.Windows.Forms.ToolStripButton();
            this.btnDownSource = new System.Windows.Forms.ToolStripButton();
            this.btnViewSource = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnForward,
            this.txtUrl,
            this.btnGoto,
            this.btnDownSource,
            this.btnViewSource});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1062, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 22);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(23, 22);
            this.btnForward.Text = "Forward";
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.txtUrl.Size = new System.Drawing.Size(910, 25);
            this.txtUrl.Text = "https://www.google.com/";
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnUrl_KeyDown);
            // 
            // btnGoto
            // 
            this.btnGoto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoto.Image = ((System.Drawing.Image)(resources.GetObject("btnGoto.Image")));
            this.btnGoto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(23, 22);
            this.btnGoto.Text = "Go to";
            this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
            // 
            // btnDownSource
            // 
            this.btnDownSource.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDownSource.Image = ((System.Drawing.Image)(resources.GetObject("btnDownSource.Image")));
            this.btnDownSource.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDownSource.Name = "btnDownSource";
            this.btnDownSource.Size = new System.Drawing.Size(23, 22);
            this.btnDownSource.Text = "Download source";
            this.btnDownSource.Click += new System.EventHandler(this.btnDownSource_Click);
            // 
            // btnViewSource
            // 
            this.btnViewSource.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnViewSource.Image = ((System.Drawing.Image)(resources.GetObject("btnViewSource.Image")));
            this.btnViewSource.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewSource.Name = "btnViewSource";
            this.btnViewSource.Size = new System.Drawing.Size(23, 22);
            this.btnViewSource.Text = "View source";
            this.btnViewSource.Click += new System.EventHandler(this.btnViewSource_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1062, 639);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // Bai4_Lab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 664);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Bai4_Lab4";
            this.Text = "Bai4_Lab4";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtUrl;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnGoto;
        private System.Windows.Forms.ToolStripButton btnDownSource;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton btnViewSource;
        private System.Windows.Forms.ToolStripButton btnForward;
    }
}