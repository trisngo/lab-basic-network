
namespace Lab2
{
    partial class Lab2_Bai5
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnTenFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKichThuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDuoiFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNgayTao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTenFile,
            this.columnLoai,
            this.columnKichThuoc,
            this.columnDuoiFile,
            this.columnNgayTao});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 450);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnTenFile
            // 
            this.columnTenFile.Text = "Tên file";
            this.columnTenFile.Width = 270;
            // 
            // columnLoai
            // 
            this.columnLoai.Text = "Loại";
            this.columnLoai.Width = 100;
            // 
            // columnKichThuoc
            // 
            this.columnKichThuoc.Text = "Kích thước";
            this.columnKichThuoc.Width = 100;
            // 
            // columnDuoiFile
            // 
            this.columnDuoiFile.Text = "Đuôi mở rộng";
            this.columnDuoiFile.Width = 100;
            // 
            // columnNgayTao
            // 
            this.columnNgayTao.Text = "Ngày tạo";
            this.columnNgayTao.Width = 226;
            // 
            // Lab2_Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "Lab2_Bai5";
            this.Text = "Lab2_Bai5";
            this.Load += new System.EventHandler(this.Lab2_Bai5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnTenFile;
        private System.Windows.Forms.ColumnHeader columnKichThuoc;
        private System.Windows.Forms.ColumnHeader columnDuoiFile;
        private System.Windows.Forms.ColumnHeader columnNgayTao;
        private System.Windows.Forms.ColumnHeader columnLoai;
    }
}