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
    public partial class frmNormalize : Form
    {
        public frmNormalize()
        {
            InitializeComponent();
        }
        PopulatingTools popObject = new PopulatingTools();
        DataProcessing dpObject = new DataProcessing();
        private void frmNormalize_Load(object sender, EventArgs e)
        {
            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)frmMain.Controls["dataGridView1"];
            popObject.PopulateCombBox(dataGridViewInstance, cmbColumns);
            cmbColumns.SelectedIndex = 0;
        }

        private void btnResetChosenCols_Click(object sender, EventArgs e)
        {
            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)frmMain.Controls["dataGridView1"];

            // clear  lsit view items
            lstViwChosenCols.Items.Clear();
            cmbColumns.Items.Clear();
            //re polulate the combobox with the column names
            popObject.PopulateCombBox(dataGridViewInstance, cmbColumns);
            // set the combobox default chosen item
            cmbColumns.SelectedIndex = 0;

        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ComboBox
            if (cmbColumns.SelectedItem != null)
            {
                // Add the selected item to the ListView
                ListViewItem item = new ListViewItem(cmbColumns.SelectedItem.ToString());
                lstViwChosenCols.Items.Add(item);

                // Remove the selected item from the ComboBox
                cmbColumns.Items.Remove(cmbColumns.SelectedItem);
                // Ensure that the added item is visible in the ListView
                item.EnsureVisible();
            }
        }

        private void btnNormalize_Click(object sender, EventArgs e)
        {
            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)frmMain.Controls["dataGridView1"];

            List<string> items = new List<string>();
            if (lstViwChosenCols.Items.Count > 0)
            {
                foreach (ListViewItem item in lstViwChosenCols.Items)
                {
                    items.Add(item.Text);
                    dpObject.NormalizeColumns(dataGridViewInstance, items);
               }
            }

            else
            {
                MessageBox.Show("No columns chosen, choose columns first");
            }
           
        }
    
    
    
    
    
    
    
    
    
    }
    
}
