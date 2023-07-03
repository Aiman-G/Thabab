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
    public partial class frmCategPlots : Form
    {
        public string cat_Col;
        public string time_Col;
        public string flux_Col;
        public frmCategPlots()
        {
            InitializeComponent();
        }

        
        private void PopulateComboBox()
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)form1.Controls["dataGridView1"];

            cmb_cat_variable.Items.Clear();
            cmb_time.Items.Clear();
            cmbFlux.Items.Clear();
            foreach (DataGridViewColumn column in dataGridViewInstance.Columns)
            {
                cmb_cat_variable.Items.Add(column.HeaderText);
                cmb_time.Items.Add(column.HeaderText);
                cmbFlux.Items.Add(column.HeaderText);

            }
        }


        private void frmCategPlots_Load(object sender, EventArgs e)
        {
            
            

            PopulateComboBox();
            cmb_cat_variable.SelectedItem = null;
            cmb_cat_variable.SelectedText = "--select--";




        }

        private void btnShowPlot_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)form1.Controls["dataGridView1"];

            Ploting plotObject = new Ploting();

            if (cmb_cat_variable.SelectedItem == null || cmbFlux.SelectedItem == null || cmb_time.SelectedItem == null)
            {
                MessageBox.Show("You need to upload dataset, then select X, Y, and the categorical variable", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                plotObject.PlotDataByCategory(dataGridViewInstance, cat_Col, time_Col, flux_Col);
            }

        }

        private string selectedItem;
        private void cmb_cat_variable_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedItem = cmb_cat_variable.SelectedItem.ToString();
            cat_Col = selectedItem;
        }

        private void cmb_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            time_Col = cmb_time.SelectedItem.ToString();
        }

        private void cmbFlux_SelectedIndexChanged(object sender, EventArgs e)
        {
            flux_Col = cmbFlux.SelectedItem.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
