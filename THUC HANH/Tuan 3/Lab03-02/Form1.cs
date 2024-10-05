using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        private bool isFileSaved = false;
        private string currentFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cmbFont.Items.AddRange(FontFamily.Families.Select(f => f.Name).ToArray());

            int[] fontSizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            cmbSize.Items.AddRange(fontSizes.Select(size => size.ToString()).ToArray());

            cmbFont.SelectedItem = "Tahoma";
            cmbSize.SelectedItem = "14";
            richTextBox.SelectionFont = new Font("Tahoma", 14);
        }


        


 

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileExtension = System.IO.Path.GetExtension(openFileDialog.FileName).ToLower();
                if (fileExtension == ".txt")
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName, Encoding.UTF8))
                    {
                        richTextBox.Text = sr.ReadToEnd();
                    }
                }
                else if (fileExtension == ".rtf")
                {
                    richTextBox.LoadFile(openFileDialog.FileName);
                }

                currentFilePath = openFileDialog.FileName;
                isFileSaved = true;
            }
        }


        

        private void tạoVănBảnMớiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (richTextBox.Modified)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu tài liệu trước khi tạo văn bản mới không?", "Lưu tài liệu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    lưuNộiDungVănBảnToolStripMenuItem_Click_1(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            richTextBox.Clear();
            isFileSaved = false; 
            currentFilePath = string.Empty;

            cmbFont.SelectedItem = "Tahoma";
            cmbSize.SelectedItem = "14";
            richTextBox.SelectionFont = new Font("Tahoma", 14);
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!isFileSaved || string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SaveFile(saveFileDialog.FileName);
                    currentFilePath = saveFileDialog.FileName;
                    isFileSaved = true;
                    MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                richTextBox.SaveFile(currentFilePath);
                MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (richTextBox.Modified)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu tài liệu trước khi thoát không?", "Lưu tài liệu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    lưuNộiDungVănBảnToolStripMenuItem_Click_1(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            Application.Exit();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                FontStyle style = richTextBox.SelectionFont.Style;
                if (richTextBox.SelectionFont.Bold)
                    style &= ~FontStyle.Bold;
                else
                    style |= FontStyle.Bold;

                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, style);
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                FontStyle style = richTextBox.SelectionFont.Style;
                if (richTextBox.SelectionFont.Italic)
                    style &= ~FontStyle.Italic;
                else
                    style |= FontStyle.Italic;

                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, style);
            }
        }

        private void btnUnderlined_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionFont != null)
            {
                FontStyle style = richTextBox.SelectionFont.Style;
                if (richTextBox.SelectionFont.Underline)
                    style &= ~FontStyle.Underline;
                else
                    style |= FontStyle.Underline;

                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, style);
            }
        }

        private void cmbFont_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbFont.SelectedIndex != -1 && cmbSize.SelectedIndex != -1)
            {
                string selectedFont = cmbFont.SelectedItem.ToString();
                float selectedSize = float.Parse(cmbSize.SelectedItem.ToString());
                richTextBox.SelectionFont = new Font(new FontFamily(selectedFont), selectedSize);
            }
        }

        private void cmbSize_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbFont.SelectedIndex != -1 && cmbSize.SelectedIndex != -1)
            {
                string selectedFont = cmbFont.SelectedItem.ToString();
                float selectedSize = float.Parse(cmbSize.SelectedItem.ToString());
                richTextBox.SelectionFont = new Font(new FontFamily(selectedFont), selectedSize);
            }
        }

        private void cmbSave_Click(object sender, EventArgs e)
        {
            if (!isFileSaved || string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SaveFile(saveFileDialog.FileName);
                    currentFilePath = saveFileDialog.FileName;
                    isFileSaved = true;
                    MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                richTextBox.SaveFile(currentFilePath);
                MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbNewFile_Click(object sender, EventArgs e)
        {
            if (richTextBox.Modified)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu văn bản trước khi tạo mới không?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    cmbSave_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {

                    return;
                }
            }

            richTextBox.Clear();

            cmbFont.SelectedItem = "Tahoma";  
            cmbSize.SelectedItem = "14";      
            richTextBox.SelectionFont = new Font("Tahoma", 14);
            richTextBox.Modified = false;
        }
    }
}
