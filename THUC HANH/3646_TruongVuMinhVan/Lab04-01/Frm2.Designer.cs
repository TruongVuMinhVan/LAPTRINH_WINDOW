namespace Lab04_01
{
    partial class Frm2
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_TongNam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_TongGS = new System.Windows.Forms.TextBox();
            this.txt_TenKhoa = new System.Windows.Forms.TextBox();
            this.txt_MaKhoa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DSCK = new System.Windows.Forms.DataGridView();
            this.FacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFrofessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_SapXep = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSCK)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(711, 383);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 35);
            this.btn_Thoat.TabIndex = 45;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_TongNam
            // 
            this.txt_TongNam.Location = new System.Drawing.Point(434, 379);
            this.txt_TongNam.Name = "txt_TongNam";
            this.txt_TongNam.Size = new System.Drawing.Size(90, 20);
            this.txt_TongNam.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Tổng Số GS";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(199, 364);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 35);
            this.btn_Sua.TabIndex = 40;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(108, 364);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 35);
            this.btn_Xoa.TabIndex = 39;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(19, 364);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 35);
            this.btn_Them.TabIndex = 38;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_TongGS
            // 
            this.txt_TongGS.Location = new System.Drawing.Point(80, 190);
            this.txt_TongGS.Name = "txt_TongGS";
            this.txt_TongGS.Size = new System.Drawing.Size(155, 20);
            this.txt_TongGS.TabIndex = 34;
            // 
            // txt_TenKhoa
            // 
            this.txt_TenKhoa.Location = new System.Drawing.Point(62, 150);
            this.txt_TenKhoa.Name = "txt_TenKhoa";
            this.txt_TenKhoa.Size = new System.Drawing.Size(173, 20);
            this.txt_TenKhoa.TabIndex = 33;
            // 
            // txt_MaKhoa
            // 
            this.txt_MaKhoa.Location = new System.Drawing.Point(62, 115);
            this.txt_MaKhoa.Name = "txt_MaKhoa";
            this.txt_MaKhoa.Size = new System.Drawing.Size(173, 20);
            this.txt_MaKhoa.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tổng Số GS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tên Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Thông Tin Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(273, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "QUẢN LÝ KHOA";
            // 
            // dgv_DSCK
            // 
            this.dgv_DSCK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSCK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DSCK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSCK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacultyID,
            this.FacultyName,
            this.TotalFrofessor});
            this.dgv_DSCK.Location = new System.Drawing.Point(296, 79);
            this.dgv_DSCK.Name = "dgv_DSCK";
            this.dgv_DSCK.Size = new System.Drawing.Size(502, 272);
            this.dgv_DSCK.TabIndex = 24;
            // 
            // FacultyID
            // 
            this.FacultyID.HeaderText = "Mã Khoa";
            this.FacultyID.Name = "FacultyID";
            // 
            // FacultyName
            // 
            this.FacultyName.HeaderText = "Tên Khoa";
            this.FacultyName.Name = "FacultyName";
            // 
            // TotalFrofessor
            // 
            this.TotalFrofessor.HeaderText = "Tổng GS";
            this.TotalFrofessor.Name = "TotalFrofessor";
            // 
            // cmb_SapXep
            // 
            this.cmb_SapXep.DisplayMember = "Tăng Dần";
            this.cmb_SapXep.FormattingEnabled = true;
            this.cmb_SapXep.Location = new System.Drawing.Point(78, 276);
            this.cmb_SapXep.Name = "cmb_SapXep";
            this.cmb_SapXep.Size = new System.Drawing.Size(121, 21);
            this.cmb_SapXep.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Sắp xếp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "CHỨC NĂNG";
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_SapXep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.txt_TongNam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_TongGS);
            this.Controls.Add(this.txt_TenKhoa);
            this.Controls.Add(this.txt_MaKhoa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_DSCK);
            this.Name = "Frm2";
            this.Text = "Quản Lý Khoa";
            this.Load += new System.EventHandler(this.Frm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSCK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_TongNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_TongGS;
        private System.Windows.Forms.TextBox txt_TenKhoa;
        private System.Windows.Forms.TextBox txt_MaKhoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DSCK;
        private System.Windows.Forms.ComboBox cmb_SapXep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFrofessor;
        private System.Windows.Forms.Label label5;
    }
}