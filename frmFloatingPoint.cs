using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thabab
{
    public partial class frmFloatingPoint : Form
    {
        public frmFloatingPoint()
        {
            InitializeComponent();
        }
        DataProcessing dpObject = new DataProcessing();

        private void frmFloatingPoint_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSetPrecision_Click(object sender, EventArgs e)
        {
            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)frmMain.Controls["dataGridView1"];

            dpObject.SetFloatingPoingPrecision(dataGridViewInstance, progressBar1, numericUpDown1);
        }
    }
}
