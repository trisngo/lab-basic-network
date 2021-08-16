
namespace Lab1
{
    partial class Lab01_Bai05
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDTB = new System.Windows.Forms.Label();
            this.labelDiemCao1 = new System.Windows.Forms.Label();
            this.labelDiemThap1 = new System.Windows.Forms.Label();
            this.labelMon0Dau = new System.Windows.Forms.Label();
            this.labelMonDau = new System.Windows.Forms.Label();
            this.labelHocLuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm quản lý điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách điểm:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(623, 26);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(36, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 282);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học và điểm";
            // 
            // labelDTB
            // 
            this.labelDTB.AutoSize = true;
            this.labelDTB.Location = new System.Drawing.Point(52, 530);
            this.labelDTB.Name = "labelDTB";
            this.labelDTB.Size = new System.Drawing.Size(129, 20);
            this.labelDTB.TabIndex = 5;
            this.labelDTB.Text = "Điểm trung bình: ";
            // 
            // labelDiemCao1
            // 
            this.labelDiemCao1.AutoSize = true;
            this.labelDiemCao1.Location = new System.Drawing.Point(52, 580);
            this.labelDiemCao1.Name = "labelDiemCao1";
            this.labelDiemCao1.Size = new System.Drawing.Size(173, 20);
            this.labelDiemCao1.TabIndex = 7;
            this.labelDiemCao1.Text = "Môn có điểm cao nhất: ";
            // 
            // labelDiemThap1
            // 
            this.labelDiemThap1.AutoSize = true;
            this.labelDiemThap1.Location = new System.Drawing.Point(569, 580);
            this.labelDiemThap1.Name = "labelDiemThap1";
            this.labelDiemThap1.Size = new System.Drawing.Size(179, 20);
            this.labelDiemThap1.TabIndex = 8;
            this.labelDiemThap1.Text = "Môn có điểm thấp nhất: ";
            // 
            // labelMon0Dau
            // 
            this.labelMon0Dau.AutoSize = true;
            this.labelMon0Dau.Location = new System.Drawing.Point(52, 636);
            this.labelMon0Dau.Name = "labelMon0Dau";
            this.labelMon0Dau.Size = new System.Drawing.Size(151, 20);
            this.labelMon0Dau.TabIndex = 9;
            this.labelMon0Dau.Text = "Số môn không đậu: ";
            // 
            // labelMonDau
            // 
            this.labelMonDau.AutoSize = true;
            this.labelMonDau.Location = new System.Drawing.Point(569, 636);
            this.labelMonDau.Name = "labelMonDau";
            this.labelMonDau.Size = new System.Drawing.Size(103, 20);
            this.labelMonDau.TabIndex = 10;
            this.labelMonDau.Text = "Số môn đậu: ";
            // 
            // labelHocLuc
            // 
            this.labelHocLuc.AutoSize = true;
            this.labelHocLuc.Location = new System.Drawing.Point(569, 530);
            this.labelHocLuc.Name = "labelHocLuc";
            this.labelHocLuc.Size = new System.Drawing.Size(128, 20);
            this.labelHocLuc.TabIndex = 11;
            this.labelHocLuc.Text = "Xếp loại học lực: ";
            // 
            // Lab01_Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 689);
            this.Controls.Add(this.labelHocLuc);
            this.Controls.Add(this.labelMonDau);
            this.Controls.Add(this.labelMon0Dau);
            this.Controls.Add(this.labelDiemThap1);
            this.Controls.Add(this.labelDiemCao1);
            this.Controls.Add(this.labelDTB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab01_Bai05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab01_Bai05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDTB;
        private System.Windows.Forms.Label labelDiemCao1;
        private System.Windows.Forms.Label labelDiemThap1;
        private System.Windows.Forms.Label labelMon0Dau;
        private System.Windows.Forms.Label labelMonDau;
        private System.Windows.Forms.Label labelHocLuc;
    }
}