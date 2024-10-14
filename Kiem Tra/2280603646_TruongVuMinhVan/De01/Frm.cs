using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

using De01.SQL;

namespace De01
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 context = new Model1();
                List<Lop> listLop = context.CacLop.ToList();
                List<Sinhvien> listSV = context.CacSinhvien.ToList();
                FillLopCmb(listLop);
                BindGrid(listSV);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillLopCmb(List<Lop> listLop)
        {
            this.cmb_Lop.DataSource = listLop;
            this.cmb_Lop.DisplayMember = "TenLop";
            this.cmb_Lop.ValueMember = "MaLop";
        }

        private void BindGrid(List<Sinhvien> listSV)
        {
            dgv_DSSV.Rows.Clear();
            foreach (var item in listSV)
            {
                int index = dgv_DSSV.Rows.Add();
                dgv_DSSV.Rows[index].Cells[0].Value = item.MaSV;
                dgv_DSSV.Rows[index].Cells[1].Value = item.HoTenSV;
                dgv_DSSV.Rows[index].Cells[2].Value = item.NgaySinh;
                dgv_DSSV.Rows[index].Cells[3].Value = item.Lop.TenLop;
            }
        }

        private bool IsValidStudentID(string MSSV)
        {
            if (string.IsNullOrEmpty(MSSV) || MSSV.Length != 6)
            {
                MessageBox.Show("Mã Số Sinh Viên Phải Có 6 Ký Tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (Model1 context = new Model1())
                {
                    // Check if fields are empty
                    if (string.IsNullOrWhiteSpace(txt_MSSV.Text) || string.IsNullOrWhiteSpace(txt_HoTen.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string MSSV = txt_MSSV.Text;

                    if (IsValidStudentID(MSSV))
                    {
                        // Check if student already exists
                        bool studentExists = context.CacSinhvien.Any(s => s.MaSV == MSSV);
                        if (studentExists)
                        {
                            MessageBox.Show("Mã số sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Create new student object
                        Sinhvien newStudent = new Sinhvien()
                        {
                            MaSV = MSSV,
                            HoTenSV = txt_HoTen.Text,
                            MaLop = (string)cmb_Lop.SelectedValue, // Assuming combo box value is a string
                            NgaySinh = dtp_NgaySinh.Value
                        };

                        // Add new student to context
                        context.CacSinhvien.Add(newStudent);
                        context.SaveChanges();

                        // Reload student list and bind to the grid
                        List<Sinhvien> listSV = context.CacSinhvien.Include(s => s.Lop).ToList();
                        BindGrid(listSV);

                        MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mã số sinh viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                using (Model1 context = new Model1())
                {
                    string MSSV = txt_MSSV.Text;

                    // Validate MSSV input
                    if (IsValidStudentID(MSSV))
                    {
                        // Find the student in the database
                        Sinhvien studentToDelete = context.CacSinhvien.SingleOrDefault(s => s.MaSV == MSSV);

                        if (studentToDelete != null)
                        {
                            // Ask for confirmation before deletion
                            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa sinh viên này không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dialogResult == DialogResult.Yes)
                            {
                                // Remove the student from the database
                                context.CacSinhvien.Remove(studentToDelete);
                                context.SaveChanges();

                                // Refresh the grid with the updated list of students
                                List<Sinhvien> listSV = context.CacSinhvien.Include(s => s.Lop).ToList();
                                BindGrid(listSV);

                                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên với MSSV này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã số sinh viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thoát Chương Trình?", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
