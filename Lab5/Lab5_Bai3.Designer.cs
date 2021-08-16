
namespace Lab5_Nhom5
{
    partial class Lab5_Bai3
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBoxFrom = new System.Windows.Forms.TextBox();
            this.txtBoxTo = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxSubj = new System.Windows.Forms.TextBox();
            this.txtBoxBody = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxFromAlias = new System.Windows.Forms.TextBox();
            this.txtBoxToAlias = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.lbAttach = new System.Windows.Forms.Label();
            this.checkBoxShowPwd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(274, 530);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(278, 48);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBoxFrom
            // 
            this.txtBoxFrom.Location = new System.Drawing.Point(477, 3);
            this.txtBoxFrom.Name = "txtBoxFrom";
            this.txtBoxFrom.Size = new System.Drawing.Size(317, 20);
            this.txtBoxFrom.TabIndex = 1;
            // 
            // txtBoxTo
            // 
            this.txtBoxTo.Location = new System.Drawing.Point(477, 71);
            this.txtBoxTo.Name = "txtBoxTo";
            this.txtBoxTo.Size = new System.Drawing.Size(317, 20);
            this.txtBoxTo.TabIndex = 2;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(477, 35);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(317, 20);
            this.txtBoxPass.TabIndex = 3;
            this.txtBoxPass.UseSystemPasswordChar = true;
            // 
            // txtBoxSubj
            // 
            this.txtBoxSubj.Location = new System.Drawing.Point(114, 121);
            this.txtBoxSubj.Name = "txtBoxSubj";
            this.txtBoxSubj.Size = new System.Drawing.Size(755, 20);
            this.txtBoxSubj.TabIndex = 4;
            // 
            // txtBoxBody
            // 
            this.txtBoxBody.Location = new System.Drawing.Point(117, 160);
            this.txtBoxBody.Name = "txtBoxBody";
            this.txtBoxBody.Size = new System.Drawing.Size(752, 318);
            this.txtBoxBody.TabIndex = 5;
            this.txtBoxBody.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Body:";
            // 
            // txtBoxFromAlias
            // 
            this.txtBoxFromAlias.Location = new System.Drawing.Point(159, 4);
            this.txtBoxFromAlias.Name = "txtBoxFromAlias";
            this.txtBoxFromAlias.Size = new System.Drawing.Size(210, 20);
            this.txtBoxFromAlias.TabIndex = 11;
            // 
            // txtBoxToAlias
            // 
            this.txtBoxToAlias.Location = new System.Drawing.Point(159, 71);
            this.txtBoxToAlias.Name = "txtBoxToAlias";
            this.txtBoxToAlias.Size = new System.Drawing.Size(210, 20);
            this.txtBoxToAlias.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(390, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(390, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Email:";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(114, 484);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(124, 29);
            this.btnAttach.TabIndex = 17;
            this.btnAttach.Text = "Click to attach a file";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // lbAttach
            // 
            this.lbAttach.AutoSize = true;
            this.lbAttach.Location = new System.Drawing.Point(244, 492);
            this.lbAttach.Name = "lbAttach";
            this.lbAttach.Size = new System.Drawing.Size(74, 13);
            this.lbAttach.TabIndex = 18;
            this.lbAttach.Text = "Attached files:";
            // 
            // checkBoxShowPwd
            // 
            this.checkBoxShowPwd.AutoSize = true;
            this.checkBoxShowPwd.Location = new System.Drawing.Point(800, 38);
            this.checkBoxShowPwd.Name = "checkBoxShowPwd";
            this.checkBoxShowPwd.Size = new System.Drawing.Size(101, 17);
            this.checkBoxShowPwd.TabIndex = 19;
            this.checkBoxShowPwd.Text = "Show password";
            this.checkBoxShowPwd.UseVisualStyleBackColor = true;
            this.checkBoxShowPwd.CheckedChanged += new System.EventHandler(this.checkBoxShowPwd_CheckedChanged);
            // 
            // Lab5_Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 590);
            this.Controls.Add(this.checkBoxShowPwd);
            this.Controls.Add(this.lbAttach);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxToAlias);
            this.Controls.Add(this.txtBoxFromAlias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxBody);
            this.Controls.Add(this.txtBoxSubj);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxTo);
            this.Controls.Add(this.txtBoxFrom);
            this.Controls.Add(this.btnSend);
            this.Name = "Lab5_Bai3";
            this.Text = "Lab5_Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtBoxFrom;
        private System.Windows.Forms.TextBox txtBoxTo;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.TextBox txtBoxSubj;
        private System.Windows.Forms.RichTextBox txtBoxBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxFromAlias;
        private System.Windows.Forms.TextBox txtBoxToAlias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label lbAttach;
        private System.Windows.Forms.CheckBox checkBoxShowPwd;
    }
}