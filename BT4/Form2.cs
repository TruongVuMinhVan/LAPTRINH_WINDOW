using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_2form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public int LuongCB { get; set; }

        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_maNV.Text) || string.IsNullOrEmpty(txt_Ten.Text) || string.IsNullOrEmpty(txt_Luong.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MaNV = txt_maNV.Text;
                TenNV = txt_Ten.Text;
                LuongCB = int.Parse(txt_Luong.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public void ClearFields()
        {
            txt_maNV.Clear();
            txt_Ten.Clear();
            txt_Luong.Clear();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
