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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add (frm.MaNV, frm.TenNV, frm.LuongCB);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Kiểm tra có mục nào được chọn không
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Cập nhật thông tin từ các TextBox
               Form2 frm = new Form2();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    selectedRow.Cells["col_MaNV"].Value = frm.MaNV;
                    selectedRow.Cells["col_TenNV"].Value = frm.TenNV;
                    selectedRow.Cells["col_Luong"].Value = frm.LuongCB;

                    frm.ClearFields();
                }
            }
            else { MessageBox.Show("Vui lòng chọn một nhân viên để sửa.");}
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
