
namespace Lab2
{
    partial class Lab2_Bai1
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
            this.buttonReadF = new System.Windows.Forms.Button();
            this.buttonWriteF = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonReadF
            // 
            this.buttonReadF.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadF.Location = new System.Drawing.Point(33, 32);
            this.buttonReadF.Name = "buttonReadF";
            this.buttonReadF.Size = new System.Drawing.Size(274, 100);
            this.buttonReadF.TabIndex = 0;
            this.buttonReadF.Text = "Đọc file";
            this.buttonReadF.UseVisualStyleBackColor = true;
            this.buttonReadF.Click += new System.EventHandler(this.buttonReadF_Click);
            // 
            // buttonWriteF
            // 
            this.buttonWriteF.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWriteF.Location = new System.Drawing.Point(33, 166);
            this.buttonWriteF.Name = "buttonWriteF";
            this.buttonWriteF.Size = new System.Drawing.Size(274, 100);
            this.buttonWriteF.TabIndex = 1;
            this.buttonWriteF.Text = "Ghi file";
            this.buttonWriteF.UseVisualStyleBackColor = true;
            this.buttonWriteF.Click += new System.EventHandler(this.buttonWriteF_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(368, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(400, 388);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Lab2_Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonWriteF);
            this.Controls.Add(this.buttonReadF);
            this.Name = "Lab2_Bai1";
            this.Text = "Lab2_Bai1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReadF;
        private System.Windows.Forms.Button buttonWriteF;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}