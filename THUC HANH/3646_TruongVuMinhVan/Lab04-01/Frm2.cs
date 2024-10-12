using Lab04_01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_01
{
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm2_Load(object sender, EventArgs e)
        {
            
        }

        private void BindGrid2(List<Faculty> listsfaculties)
        {
            dgv_DSCK.Rows.Clear();
            foreach (var item in listsfaculties)
            {
                int index = dgv_DSCK.Rows.Add();
                dgv_DSCK.Rows[index].Cells[0].Value = item.FacultyID;
                dgv_DSCK.Rows[index].Cells[1].Value = item.FacultyName;
                dgv_DSCK.Rows[index].Cells[2].Value = item.TotalProfessor;
            }
        }
    }
}
