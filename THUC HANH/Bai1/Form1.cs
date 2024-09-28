using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txt_Dau_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txt_Sau_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_KQ_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_Cong_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txt_Dau.Text);
                float num2 = float.Parse(txt_Sau.Text);
                float result = num1 + num2;
                txt_KQ.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui Long Nhap So Hop Le", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da Xay Ra Loi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Tru_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txt_Dau.Text);
                float num2 = float.Parse(txt_Sau.Text);
                float result = num1 - num2;
                txt_KQ.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui Long Nhap So Hop Le", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da Xay Ra Loi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Nhan_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txt_Dau.Text);
                float num2 = float.Parse(txt_Sau.Text);
                float result = num1 * num2;
                txt_KQ.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui Long Nhap So Hop Le", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da Xay Ra Loi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btn_Chia_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txt_Dau.Text);
                float num2 = float.Parse(txt_Sau.Text);
                float result = num1 / num2;
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Khong Chia duoc cho so 0");
                }
                txt_KQ.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui Long Nhap So Hop Le", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Loi Chia Cho So 0", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
