
namespace Lab2
{
    partial class Lab2_Bai3
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
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.textBoxIn = new System.Windows.Forms.RichTextBox();
            this.textBoxOut = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonRead
            // 
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.Location = new System.Drawing.Point(40, 24);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(204, 60);
            this.buttonRead.TabIndex = 0;
            this.buttonRead.Text = "Đọc";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalc.Location = new System.Drawing.Point(311, 24);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(204, 60);
            this.buttonCalc.TabIndex = 1;
            this.buttonCalc.Text = "Tính";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWrite.Location = new System.Drawing.Point(572, 24);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(204, 60);
            this.buttonWrite.TabIndex = 2;
            this.buttonWrite.Text = "Ghi";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // textBoxIn
            // 
            this.textBoxIn.Location = new System.Drawing.Point(41, 107);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(349, 324);
            this.textBoxIn.TabIndex = 3;
            this.textBoxIn.Text = "";
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(427, 107);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(349, 324);
            this.textBoxOut.TabIndex = 4;
            this.textBoxOut.Text = "";
            // 
            // Lab2_Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonRead);
            this.Name = "Lab2_Bai3";
            this.Text = "Lab2_Bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.RichTextBox textBoxIn;
        private System.Windows.Forms.RichTextBox textBoxOut;
    }
}