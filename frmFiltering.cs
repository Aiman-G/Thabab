using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Thabab
{
    public partial class frmFiltering : Form
    {
        public frmFiltering()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true; // set the WorkerReportsProgress property to true
        }

        private void frmFiltering_Load(object sender, EventArgs e)
        {
            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)frmMain.Controls["dataGridView1"];

            var datasource = dataGridViewInstance.DataSource;
            dgvShowFilteredData.DataSource = datasource;

           

        }



        

       

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)frmMain.Controls["dataGridView1"];

            PopulatingTools popObj = new PopulatingTools();
            popObj.comboxOfUniquevalues(dataGridViewInstance, panel1, backgroundWorker1);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            // Update the progress bar
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Hide the progress bar when the task is complete
            progressBar1.Visible = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            try
            {
                // Get the values chosen in every combobox and their corresponding column names
                List<(string columnName, string selectedValue)> selectedValues = new List<(string columnName, string selectedValue)>();
                foreach (Control control in panel1.Controls)
                {
                    if (control is ComboBox comboBox && comboBox.SelectedItem != null)
                    {
                        string columnName = comboBox.Name.Replace("combo", "");

                        //selectedValues.Add(comboBox.SelectedItem.ToString());
                        selectedValues.Add((columnName, comboBox.SelectedItem.ToString()));
                    }
                }

                // Filter the DataGridView based on the selected values
                DataTable dataTable = ((DataTable)dgvShowFilteredData.DataSource).Copy();
                string filterExpression = string.Join(" AND ", selectedValues.Select((value) =>
                {
                    string columnName = value.columnName;
                    string columnType = dataTable.Columns[columnName].DataType.ToString();
                    object columnValue = value.selectedValue;

                // Determine the type of the column
                switch (columnType)
                    {
                        case "System.Int16":
                        case "System.Int32":
                        case "System.Int64":
                        case "System.Decimal":
                        case "System.Double":
                        // If the value is numeric, don't add quotes
                        if (double.TryParse(columnValue.ToString(), NumberStyles.Any, CultureInfo.CurrentCulture, out double numberValue))
                            {
                                columnValue = numberValue;
                            }
                            else
                            {
                                columnValue = $"'{columnValue}'";
                            }
                            break;

                        case "System.DateTime":
                        // If the value is a date, surround with # symbols
                        if (DateTime.TryParse(columnValue.ToString(), out DateTime dateValue))
                            {
                                columnValue = "#" + dateValue.ToString("yyyy-MM-dd") + "#";
                            }
                            else
                            {
                                throw new ArgumentException($"Invalid value '{columnValue}' for date column '{columnName}'");
                            }
                            break;

                        default:
                        // If the value is a string, surround with quotes
                        columnValue = $"'{columnValue}'";
                            break;
                    }

                    return $"{columnName} = {columnValue}";
                }));

                dataTable.DefaultView.RowFilter = filterExpression;
                dgvShowFilteredData.DataSource = dataTable;
                dgvShowFilteredData.Refresh();
            }

            catch (Exception ex)
            {
                // Handle any exceptions that are thrown by the function
                //MessageBox.Show("Make sure your CSV file is in correct format..: " + ex.Message);
                MessageBox.Show("Make sure your CSV file is in correct format.. " );
            }
        }

        private void btnClearSelections_Click(object sender, EventArgs e)
        {

            foreach (Control control in panel1.Controls)
            {
                if (control is ComboBox comboBox && comboBox.SelectedItem != null)
                {
                    comboBox.SelectedItem = null;

                }
            }
        }

        private void btnLoadUnfilterd_Click(object sender, EventArgs e)
        {

            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)frmMain.Controls["dataGridView1"];

            var datasource = dataGridViewInstance.DataSource;
            dgvShowFilteredData.DataSource = datasource;
        }

        private void dgvShowFilteredData_DataSourceChanged(object sender, EventArgs e)
        {
            int rowCount = dgvShowFilteredData.Rows.Count;
            toolStripStatusLabel1.Text = "No. Of Records: " + rowCount.ToString();
            

        }

        private void btnUniqueValues_Click(object sender, EventArgs e)
        {

            // Show the progress bar
            progressBar1.Visible = true;

            // Start the background worker
            backgroundWorker1.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvShowFilteredData.RowCount == 0)
            {
                return;
            }
            DataSummarization dataSmrObject = new DataSummarization();

            dataSmrObject.SummarizeDataGridView(dgvShowFilteredData, dgvSummary);
        }

        private void dgvShowFilteredData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
