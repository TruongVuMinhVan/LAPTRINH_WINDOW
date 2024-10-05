using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVMV
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

        private void tmr_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("Today is date {0} - Now is date {1}",
            DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }



        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mkv;*.wmv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Video.URL = openFileDialog.FileName;
            }
        }
       
        private void ToolStripExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
