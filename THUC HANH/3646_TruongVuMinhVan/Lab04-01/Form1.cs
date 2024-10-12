using Lab04_01.Model;
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

namespace Lab04_01
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rb_Nu.Checked = true;
            try
            {
                Model1 context = new Model1();
                List<Faculty> listfaculties = context.Faculties.ToList();
                List<Student> liststudents = context.Students.ToList();
                FillFacultyCmb(listfaculties);
                BindGrid(liststudents);
                CountGender (liststudents);
                txt_TongNam.Enabled = false;
                txt_TongNu.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void CountGender (List<Student> liststudents)
        {
            int TongNam = liststudents.Count(s => s.Gender == "Male");
            int TongNu = liststudents.Count(s => s.Gender == "Female");
            txt_TongNam.Text = TongNam.ToString();
            txt_TongNu.Text = TongNu.ToString();
        }
        private void FillFacultyCmb(List<Faculty> listfaculties)
        {
            this.cmb_Khoa.DataSource = listfaculties;
            this.cmb_Khoa.DisplayMember = "FacultyName";
            this.cmb_Khoa.ValueMember = "FacultyID";
        }

        private void BindGrid(List<Student> liststudents)
        {
            dgv_DSSV.Rows.Clear();
            foreach (var item in liststudents)
            {
                int index = dgv_DSSV.Rows.Add();
                dgv_DSSV.Rows[index].Cells[0].Value = item.StudentID;
                dgv_DSSV.Rows[index].Cells[1].Value = item.FullName;
                dgv_DSSV.Rows[index].Cells[2].Value = item.Gender;
                dgv_DSSV.Rows[index].Cells[3].Value = item.AverageScore;
                dgv_DSSV.Rows[index].Cells[4].Value = item.Faculty.FacultyName;
            }
        }
    
    

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show ("Thoát Chương Trình?", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool IsValidStudentID(string MSSV)
        {
            if (string.IsNullOrEmpty(MSSV) || MSSV.Length != 10)
            {
                MessageBox.Show("Mã Số Sinh Viên Phải Có 10 Ký Tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {

                using (Model1 context = new Model1())
                {

                    if (string.IsNullOrWhiteSpace(txt_MSV.Text) || string.IsNullOrWhiteSpace(txt_HoTen.Text) ||
                        string.IsNullOrWhiteSpace(txt_DTB.Text))
                    {
                        MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    string MSSV = txt_MSV.Text;
                    if (IsValidStudentID(MSSV))
                    {

                        if (int.TryParse(MSSV, out int studentID))
                        {

                            bool studentExists = context.Students.Any(s => s.StudentID == studentID);
                            if (studentExists)
                            {
                                MessageBox.Show("Mã Số Sinh Viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }


                            if (decimal.TryParse(txt_DTB.Text, out decimal averageScore))
                            {
                                string gender = rb_Nam.Checked ? "Male" : "Female";
                                Student newStudent = new Student()
                                {
                                    StudentID = studentID,
                                    FullName = txt_HoTen.Text,
                                    Gender = gender,
                                    AverageScore = averageScore,                                 
                                    FacultyID = (int)cmb_Khoa.SelectedValue,
                                };


                                context.Students.Add(newStudent);
                                context.SaveChanges();

                                List<Student> liststudents = context.Students.Include(s => s.Faculty).ToList();
                                BindGrid(liststudents);
                                CountGender(liststudents);

                                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Điểm Trung Bình không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã Số Sinh Viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (Model1 context = new Model1())
                {

                    string MSSV = txt_MSV.Text;


                    if (IsValidStudentID(MSSV) && int.TryParse(MSSV, out int studentID))
                    {

                        Student studentToDelete = context.Students.FirstOrDefault(s => s.StudentID == studentID);

                        if (studentToDelete != null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa sinh viên này không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dialogResult == DialogResult.Yes)
                            {
                                context.Students.Remove(studentToDelete);
                                context.SaveChanges();

                                List<Student> liststudents = context.Students.Include(s => s.Faculty).ToList();
                                BindGrid(liststudents);
                                CountGender(liststudents);


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
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 context = new Model1();
                string MSSV = txt_MSV.Text;
                if (IsValidStudentID(MSSV) && int.TryParse(MSSV, out int ID))
                {
                    Student editStudent = context.Students.FirstOrDefault(s => s.StudentID == ID);
                    if (editStudent != null)
                    {
                        editStudent.FullName = txt_HoTen.Text;
                        if (decimal.TryParse(txt_DTB.Text, out decimal averageScore))
                        {
                            editStudent.AverageScore = averageScore;
                            editStudent.Gender = rb_Nam.Checked ? "Male" : "Female";
                            editStudent.FacultyID = (int)cmb_Khoa.SelectedValue;
                            context.SaveChanges();


                            List<Student> liststudents = context.Students.Include(s => s.Faculty).ToList();
                            BindGrid(liststudents);

                            MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Điểm Trung Bình không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Mã số sinh viên xóa không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsb_QLK_Click(object sender, EventArgs e)
        {
            Frm2 frm2 = new Frm2();
            frm2.Show();
            Hide();
        }
    }
}
