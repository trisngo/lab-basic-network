
namespace lab3
{
    partial class Lab3_Bai3_Dash
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
            this.buttonOServer = new System.Windows.Forms.Button();
            this.buttonOClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOServer
            // 
            this.buttonOServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOServer.Location = new System.Drawing.Point(22, 27);
            this.buttonOServer.Name = "buttonOServer";
            this.buttonOServer.Size = new System.Drawing.Size(454, 46);
            this.buttonOServer.TabIndex = 0;
            this.buttonOServer.Text = "Open TCP Server";
            this.buttonOServer.UseVisualStyleBackColor = true;
            this.buttonOServer.Click += new System.EventHandler(this.buttonOServer_Click);
            // 
            // buttonOClient
            // 
            this.buttonOClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOClient.Location = new System.Drawing.Point(22, 97);
            this.buttonOClient.Name = "buttonOClient";
            this.buttonOClient.Size = new System.Drawing.Size(454, 46);
            this.buttonOClient.TabIndex = 1;
            this.buttonOClient.Text = "Open new TCP Client";
            this.buttonOClient.UseVisualStyleBackColor = true;
            this.buttonOClient.Click += new System.EventHandler(this.buttonOClient_Click);
            // 
            // Lab3_Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 174);
            this.Controls.Add(this.buttonOClient);
            this.Controls.Add(this.buttonOServer);
            this.Name = "Lab3_Bai3";
            this.Text = "Lab3_Bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOServer;
        private System.Windows.Forms.Button buttonOClient;
    }
}