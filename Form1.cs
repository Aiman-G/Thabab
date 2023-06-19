using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using luminous;
using MathNet.Numerics.Statistics;
namespace Thabab

{
    public partial class Form1 : Form
    {
        public string cat_Col;
        public string time_Col;
        public string flux_Col;


        DataProcessing dpObject = new DataProcessing();

      


        private void PopulateListBoxs()
        {
            //CkListBox_columns.Items.Clear();
            //CkBoxList_timeFlux.Items.Clear();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                // CkListBox_columns.Items.Add(column.HeaderText);
                // CkBoxList_timeFlux.Items.Add(column.HeaderText);
            }
        }

        private bool CheckIfDataLoaded()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data, upload your CSV file first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LstBox_cat_columns.Visible = false;
            //LstBoxTimeFlux.Visible = false;
            
        }

        private void BtnOpenCsv_Click(object sender, EventArgs e)
        {
            

            // Show the Open File dialog.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog1.Title = "Select a CSV File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Read the contents of the selected CSV file into a DataTable.
                DataTable dt = new DataTable();
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i];
                        }
                        dt.Rows.Add(dr);
                    }
                }

                // Set the DataTable as the DataSource of the DataGridView.
                dataGridView1.DataSource = dt;

                // Populate the ListBox with the column names.
                PopulateListBoxs();
               
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        
        private string selectedItem;
                              

        // when use double click the datagridview header, descriptive statistcs should be shown 

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {



        }


        

        private void loadCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            // Show the Open File dialog.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog1.Title = "Select a CSV File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Read the contents of the selected CSV file into a DataTable.
                DataTable dt = new DataTable();
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    // Read the first line of the file to determine the column names.
                    string headerLine = sr.ReadLine();
                    if (headerLine == null)
                    {
                        MessageBox.Show("The selected file is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string[] headers = headerLine.Split(',');
                    if (headers.Length == 0)
                    {
                        MessageBox.Show("The selected file does not have any columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check that all column names are unique.
                    if (headers.Distinct().Count() != headers.Length)
                    {
                        MessageBox.Show("The selected file has duplicate column names.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Add the columns to the DataTable.
                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header);
                    }

                    // Read the remaining lines of the file to add rows to the DataTable.
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        if (rows.Length != headers.Length)
                        {
                            MessageBox.Show("The selected file has rows with different numbers of columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i];
                        }
                        dt.Rows.Add(dr);
                    }
                }

                // Set the DataTable as the DataSource of the DataGridView.
                dataGridView1.DataSource = dt;

                // Populate the ListBox with the column names.
                PopulateListBoxs();
            }
        }

        
       

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.Show();

        }

        private void toolStripMenuPlotCategorical_Click(object sender, EventArgs e)
        {

            var xx = dpObject.AreValuesSurroundedByQuotes(dataGridView1);
            if (xx)
            {
                MessageBox.Show("Data is not ready, remove the quoates from the processig menue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            if (!CheckIfDataLoaded())
            {
                return;
            }

            frmCategPlots frmcat = new frmCategPlots();
            
            frmcat.Show();
            // here show new form
        }

        private void toolStripPlotCombinations_Click(object sender, EventArgs e)
        {

            var xx = dpObject.AreValuesSurroundedByQuotes(dataGridView1);
            if (xx)
             {
                MessageBox.Show("Data is not ready, remove the quoates from the processig menue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!CheckIfDataLoaded())
             {
               return;
            }
            // frmCombinationPlots frmCombPlots = new frmCombinationPlots();
            //frmCombPlots.Show();

            frmCmbPlots frmcombplot = new frmCmbPlots();
            frmcombplot.Show();



        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)

        {


            var xx = dpObject.AreValuesSurroundedByQuotes(dataGridView1);
            if (xx)
            {
                MessageBox.Show("Data is not ready, remove the quoates from the processig menue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (!CheckIfDataLoaded())
            {
                return;
            }
            frmFiltering frmquery = new frmFiltering();
            frmquery.Show();
        }

        private void plotToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            int rowCount = dataGridView1.Rows.Count;
            
            toolStripStatusLabel1.Text = "No. of Records: " + rowCount.ToString();
                
        }



       // private string emptyRowsCount;
        private void btnDelNull_Click(object sender, EventArgs e)
        {
           
            dpObject.RemoveNullRowsFromDataGridView(dataGridView1);

           // MessageBox.Show($"{emptyRowsCount} rows were deleted because they contained empty cells.");

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                // Header
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    sb.Append(col.HeaderText + ",");
                }

                sb.AppendLine();

                // Rows
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sb.Append(cell.Value + ",");
                    }
                    sb.AppendLine();
                }

                // Save to file
                File.WriteAllText(saveFileDialog.FileName, sb.ToString());
            }
        }

        private void RemoveQuotes_StripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckIfDataLoaded())
            {
                return;
            }
            dpObject.RemoveQuotesFromValuesAndColumns(dataGridView1);
            dataGridView1.Refresh();
        }

        private void removeNullsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckIfDataLoaded())
            {
                return;
            }
            dpObject.RemoveNullRowsFromDataGridView(dataGridView1);
            dataGridView1.Refresh();
        }

        private void processingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Normalize_tripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckIfDataLoaded())
            {
                return;
            }
            frmNormalize frmnomralization = new frmNormalize();
            frmnomralization.Show();

        }

        private void SetFlaotingPoint_tripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckIfDataLoaded())
            {
                return;
            }
            frmFloatingPoint frmSetFloatinPoint = new frmFloatingPoint();

            frmSetFloatinPoint.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width - 20;
            dataGridView1.Height = this.Height - (this.Height/4);
        }
    }
}
