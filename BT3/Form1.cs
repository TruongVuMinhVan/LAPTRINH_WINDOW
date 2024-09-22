using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DSSV
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txt_Ho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (list_DS.SelectedItems.Count > 0) 
            {
                foreach (ListViewItem item in list_DS.SelectedItems)
                {
                    list_DS.Items.Remove(item); // Xóa mục được chọn
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (list_DS.SelectedItems.Count > 0) // Kiểm tra có mục nào được chọn không
            {
                ListViewItem selectedItem = list_DS.SelectedItems[0]; 

                // Cập nhật thông tin từ các TextBox
                selectedItem.Text = txt_Ho.Text; 
                selectedItem.SubItems[1].Text = txt_Ten.Text; 
                selectedItem.SubItems[2].Text = txt_SDT.Text; 

                // Xóa các TextBox sau khi chỉnh sửa
                txt_Ho.Clear();
                txt_Ten.Clear();
                txt_SDT.Clear();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txt_Ho.Text); 
            item.SubItems.Add(txt_Ten.Text); 
            item.SubItems.Add(txt_SDT.Text); 

            // Thêm mục vào ListView
            list_DS.Items.Add(item);   

            // Xóa các TextBox sau khi thêm vào danh sách
            txt_Ho.Clear();
            txt_Ten.Clear();
            txt_SDT.Clear();
        }

        private void list_DS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
