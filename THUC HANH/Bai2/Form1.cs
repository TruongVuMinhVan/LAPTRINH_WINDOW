using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frm_QLSV : Form
    {
        public frm_QLSV()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        { 
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng chương trình không?", "Xác nhận đóng chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) { e.Cancel = true; } 
        }

        private void frm_QLSV_Load (object sender, EventArgs e)
        {
            cmb_CN.SelectedIndex = 0;
        }

        private int GetSelectedRow(string StudentID)
        {
            for (int i = 0; i < dgv_QLSV.Rows.Count; i++)
            {
                if (dgv_QLSV.Rows[i].Cells[0].Value != null && dgv_QLSV.Rows[i].Cells[0].Value.ToString() == StudentID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgv_QLSV.Rows[selectedRow].Cells[0].Value = txt_MaSV.Text;
            dgv_QLSV.Rows[selectedRow].Cells[1].Value = txt_HoTen.Text;
            dgv_QLSV.Rows[selectedRow].Cells[2].Value = rb_Nam.Checked ? "Nam" : "Nữ";
            dgv_QLSV.Rows[selectedRow].Cells[3].Value = float.Parse(txt_DTB.Text).ToString();
            dgv_QLSV.Rows[selectedRow].Cells[4].Value = cmb_CN.Text;
            
            int nam = 0;
            int nu = 0;
            for (int i = 0; i < dgv_QLSV.Rows.Count; i++)
            {
                if (dgv_QLSV.Rows[i].Cells[0].Value != null && dgv_QLSV.Rows[i].Cells[2].Value.ToString() == "Nam")
                {
                    nam++;
                }
                if (dgv_QLSV.Rows[i].Cells[0].Value != null && dgv_QLSV.Rows[i].Cells[2].Value.ToString() == "Nữ")
                {
                    nu++;
                }
            }
            txt_TongNam.Text = nam.ToString();
            txt_TongNu.Text = nu.ToString();

        }
        private void btn_ThemSua_Click(object sender, EventArgs e)
        {
            try { 
                if (string.IsNullOrEmpty(txt_MaSV.Text) || string.IsNullOrEmpty(txt_HoTen.Text) || string.IsNullOrEmpty(txt_DTB.Text) || string.IsNullOrEmpty(cmb_CN.Text) )
                {
                    MessageBox.Show("VUI LONG NHAP DU THONG TIN!", "LOI NHAP XUAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int selectedRow = GetSelectedRow(txt_MaSV.Text);
                    if(selectedRow == -1)
                    {
                        selectedRow = dgv_QLSV.Rows.Add();
                        InsertUpdate(selectedRow);
                        MessageBox.Show("THEM DU LIEU THANH CONG", "THONG BAO", MessageBoxButtons.OK);
                    }
                    else
                    {
                        InsertUpdate(selectedRow);
                        MessageBox.Show("CAP NHAT DU LIEU THANH CONG","THONG BAO", MessageBoxButtons.OK);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txt_MaSV.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("KHONG TIM THAY MSSV CAN XOA");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("BAN CO MUON XOA", "YES/NO", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes)
                    {
                        dgv_QLSV.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("XOA SINH VIEN THANH CONG", "THONG BAO", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"LOI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            int selectedRow = GetSelectedRow(txt_MaSV.Text);
            if (selectedRow != -1)
            {
                dgv_QLSV.CurrentCell = dgv_QLSV.Rows[selectedRow].Cells[0];
                MessageBox.Show("Tim thay sinh vien", "THONG BAO", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Khong tim thay sinh vien", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_TongNam_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_TongNu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
