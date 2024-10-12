namespace Lab04_01
{
    partial class Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_QLK = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Tim = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstxt_Tim = new System.Windows.Forms.ToolStripTextBox();
            this.dgv_DSSV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MSV = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_DTB = new System.Windows.Forms.TextBox();
            this.cmb_Khoa = new System.Windows.Forms.ComboBox();
            this.rb_Nam = new System.Windows.Forms.RadioButton();
            this.rb_Nu = new System.Windows.Forms.RadioButton();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_TongNam = new System.Windows.Forms.TextBox();
            this.txt_TongNu = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_QLK,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.tsb_Tim,
            this.toolStripLabel2,
            this.tstxt_Tim});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_QLK
            // 
            this.tsb_QLK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_QLK.Image = ((System.Drawing.Image)(resources.GetObject("tsb_QLK.Image")));
            this.tsb_QLK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_QLK.Name = "tsb_QLK";
            this.tsb_QLK.Size = new System.Drawing.Size(23, 22);
            this.tsb_QLK.Text = "toolStripButton1";
            this.tsb_QLK.Click += new System.EventHandler(this.tsb_QLK_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel1.Text = "Quản Lý Khoa";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_Tim
            // 
            this.tsb_Tim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Tim.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Tim.Image")));
            this.tsb_Tim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Tim.Name = "tsb_Tim";
            this.tsb_Tim.Size = new System.Drawing.Size(23, 22);
            this.tsb_Tim.Text = "toolStripButton2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel2.Text = "Tìm Kiếm";
            // 
            // tstxt_Tim
            // 
            this.tstxt_Tim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxt_Tim.Name = "tstxt_Tim";
            this.tstxt_Tim.Size = new System.Drawing.Size(100, 25);
            // 
            // dgv_DSSV
            // 
            this.dgv_DSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSSV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FullName,
            this.Gender,
            this.AverageScore,
            this.FacultyName});
            this.dgv_DSSV.Location = new System.Drawing.Point(298, 108);
            this.dgv_DSSV.Name = "dgv_DSSV";
            this.dgv_DSSV.Size = new System.Drawing.Size(502, 272);
            this.dgv_DSSV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(151, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông Tin Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã SV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Khoa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Điểm TB";
            // 
            // txt_MSV
            // 
            this.txt_MSV.Location = new System.Drawing.Point(64, 144);
            this.txt_MSV.Name = "txt_MSV";
            this.txt_MSV.Size = new System.Drawing.Size(173, 20);
            this.txt_MSV.TabIndex = 10;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(64, 179);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(173, 20);
            this.txt_HoTen.TabIndex = 11;
            // 
            // txt_DTB
            // 
            this.txt_DTB.Location = new System.Drawing.Point(64, 296);
            this.txt_DTB.Name = "txt_DTB";
            this.txt_DTB.Size = new System.Drawing.Size(173, 20);
            this.txt_DTB.TabIndex = 12;
            // 
            // cmb_Khoa
            // 
            this.cmb_Khoa.FormattingEnabled = true;
            this.cmb_Khoa.Location = new System.Drawing.Point(64, 257);
            this.cmb_Khoa.Name = "cmb_Khoa";
            this.cmb_Khoa.Size = new System.Drawing.Size(121, 21);
            this.cmb_Khoa.TabIndex = 13;
            // 
            // rb_Nam
            // 
            this.rb_Nam.AutoSize = true;
            this.rb_Nam.Location = new System.Drawing.Point(76, 222);
            this.rb_Nam.Name = "rb_Nam";
            this.rb_Nam.Size = new System.Drawing.Size(47, 17);
            this.rb_Nam.TabIndex = 14;
            this.rb_Nam.TabStop = true;
            this.rb_Nam.Text = "Nam";
            this.rb_Nam.UseVisualStyleBackColor = true;
            // 
            // rb_Nu
            // 
            this.rb_Nu.AutoSize = true;
            this.rb_Nu.Location = new System.Drawing.Point(157, 222);
            this.rb_Nu.Name = "rb_Nu";
            this.rb_Nu.Size = new System.Drawing.Size(39, 17);
            this.rb_Nu.TabIndex = 15;
            this.rb_Nu.TabStop = true;
            this.rb_Nu.Text = "Nữ";
            this.rb_Nu.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(21, 393);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 35);
            this.btn_Them.TabIndex = 16;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(110, 393);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 35);
            this.btn_Xoa.TabIndex = 17;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(201, 393);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 35);
            this.btn_Sua.TabIndex = 18;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tổng Nam";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tổng Nữ";
            // 
            // txt_TongNam
            // 
            this.txt_TongNam.Location = new System.Drawing.Point(440, 412);
            this.txt_TongNam.Name = "txt_TongNam";
            this.txt_TongNam.Size = new System.Drawing.Size(90, 20);
            this.txt_TongNam.TabIndex = 21;
            // 
            // txt_TongNu
            // 
            this.txt_TongNu.Location = new System.Drawing.Point(600, 412);
            this.txt_TongNu.Name = "txt_TongNu";
            this.txt_TongNu.Size = new System.Drawing.Size(90, 20);
            this.txt_TongNu.TabIndex = 22;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(713, 412);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 35);
            this.btn_Thoat.TabIndex = 23;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Mã SV";
            this.StudentID.Name = "StudentID";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Họ Tên";
            this.FullName.Name = "FullName";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.Name = "Gender";
            // 
            // AverageScore
            // 
            this.AverageScore.HeaderText = "Điểm Trung Bình";
            this.AverageScore.Name = "AverageScore";
            // 
            // FacultyName
            // 
            this.FacultyName.HeaderText = "Tên Khoa";
            this.FacultyName.Name = "FacultyName";
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.txt_TongNu);
            this.Controls.Add(this.txt_TongNam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.rb_Nu);
            this.Controls.Add(this.rb_Nam);
            this.Controls.Add(this.cmb_Khoa);
            this.Controls.Add(this.txt_DTB);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_MSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_DSSV);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_QLK;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_Tim;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tstxt_Tim;
        private System.Windows.Forms.DataGridView dgv_DSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_MSV;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_DTB;
        private System.Windows.Forms.ComboBox cmb_Khoa;
        private System.Windows.Forms.RadioButton rb_Nam;
        private System.Windows.Forms.RadioButton rb_Nu;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_TongNam;
        private System.Windows.Forms.TextBox txt_TongNu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
    }
}

