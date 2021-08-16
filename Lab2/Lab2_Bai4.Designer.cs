
namespace Lab2
{
    partial class Lab2_Bai4
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
            this.buttonNhap = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonHienThi = new System.Windows.Forms.Button();
            this.richTextShow = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonNhap
            // 
            this.buttonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhap.Location = new System.Drawing.Point(26, 30);
            this.buttonNhap.Name = "buttonNhap";
            this.buttonNhap.Size = new System.Drawing.Size(215, 56);
            this.buttonNhap.TabIndex = 1;
            this.buttonNhap.Text = "Nhập dữ liệu";
            this.buttonNhap.UseVisualStyleBackColor = true;
            this.buttonNhap.Click += new System.EventHandler(this.buttonNhap_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(26, 126);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(215, 56);
            this.buttonLuu.TabIndex = 2;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // buttonHienThi
            // 
            this.buttonHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHienThi.Location = new System.Drawing.Point(26, 221);
            this.buttonHienThi.Name = "buttonHienThi";
            this.buttonHienThi.Size = new System.Drawing.Size(215, 56);
            this.buttonHienThi.TabIndex = 3;
            this.buttonHienThi.Text = "Hiển thị thông tin";
            this.buttonHienThi.UseVisualStyleBackColor = true;
            this.buttonHienThi.Click += new System.EventHandler(this.buttonHienThi_Click);
            // 
            // richTextShow
            // 
            this.richTextShow.Location = new System.Drawing.Point(271, 12);
            this.richTextShow.Name = "richTextShow";
            this.richTextShow.Size = new System.Drawing.Size(517, 426);
            this.richTextShow.TabIndex = 0;
            this.richTextShow.Text = "";
            // 
            // Lab2_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHienThi);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonNhap);
            this.Controls.Add(this.richTextShow);
            this.Name = "Lab2_Bai4";
            this.Text = "Lab2_Bai4";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonNhap;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonHienThi;
        private System.Windows.Forms.RichTextBox richTextShow;
    }
}