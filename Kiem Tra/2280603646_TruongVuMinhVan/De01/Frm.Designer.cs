namespace De01
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.cmb_Lop = new System.Windows.Forms.ComboBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_KLuu = new System.Windows.Forms.Button();
            this.dgv_DSSV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.col_MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Add.Location = new System.Drawing.Point(320, 174);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(76, 35);
            this.btn_Add.TabIndex = 44;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Edit.Location = new System.Drawing.Point(484, 174);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(76, 35);
            this.btn_Edit.TabIndex = 43;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Del
            // 
            this.btn_Del.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Del.Location = new System.Drawing.Point(402, 174);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(76, 35);
            this.btn_Del.TabIndex = 42;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // cmb_Lop
            // 
            this.cmb_Lop.FormattingEnabled = true;
            this.cmb_Lop.Location = new System.Drawing.Point(657, 118);
            this.cmb_Lop.Name = "cmb_Lop";
            this.cmb_Lop.Size = new System.Drawing.Size(151, 24);
            this.cmb_Lop.TabIndex = 40;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(656, 80);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(250, 22);
            this.txt_HoTen.TabIndex = 38;
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Location = new System.Drawing.Point(306, 83);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(250, 22);
            this.txt_MSSV.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(598, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Lớp Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(598, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(233, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã Số SV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(232, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "THÔNG TIN SINH VIÊN";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Thoat.Location = new System.Drawing.Point(845, 174);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(76, 35);
            this.btn_Thoat.TabIndex = 45;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Tim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Tim.Location = new System.Drawing.Point(236, 161);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(78, 48);
            this.btn_Tim.TabIndex = 46;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 47;
            // 
            // btn_Luu
            // 
            this.btn_Luu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Luu.Location = new System.Drawing.Point(657, 174);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(76, 35);
            this.btn_Luu.TabIndex = 48;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // btn_KLuu
            // 
            this.btn_KLuu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_KLuu.Location = new System.Drawing.Point(739, 174);
            this.btn_KLuu.Name = "btn_KLuu";
            this.btn_KLuu.Size = new System.Drawing.Size(76, 35);
            this.btn_KLuu.TabIndex = 49;
            this.btn_KLuu.Text = "K.Lưu";
            this.btn_KLuu.UseVisualStyleBackColor = true;
            // 
            // dgv_DSSV
            // 
            this.dgv_DSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSSV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MSSV,
            this.col_HoTen,
            this.NgaySinh,
            this.Lop});
            this.dgv_DSSV.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_DSSV.Location = new System.Drawing.Point(26, 215);
            this.dgv_DSSV.Name = "dgv_DSSV";
            this.dgv_DSSV.RowHeadersWidth = 51;
            this.dgv_DSSV.RowTemplate.Height = 24;
            this.dgv_DSSV.Size = new System.Drawing.Size(896, 285);
            this.dgv_DSSV.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(233, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ngày Sinh";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Location = new System.Drawing.Point(306, 121);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtp_NgaySinh.TabIndex = 51;
            // 
            // col_MSSV
            // 
            this.col_MSSV.HeaderText = "Mã Số Sinh Viên";
            this.col_MSSV.MinimumWidth = 6;
            this.col_MSSV.Name = "col_MSSV";
            // 
            // col_HoTen
            // 
            this.col_HoTen.HeaderText = "Họ Tên";
            this.col_HoTen.MinimumWidth = 6;
            this.col_HoTen.Name = "col_HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 6;
            this.Lop.Name = "Lop";
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 525);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_KLuu);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.cmb_Lop);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_MSSV);
            this.Controls.Add(this.dgv_DSSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm";
            this.Text = "DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.ComboBox cmb_Lop;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_KLuu;
        private System.Windows.Forms.DataGridView dgv_DSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
    }
}

