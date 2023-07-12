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
using System.IO;

namespace Thabab
{
    public partial class frmFiltering : Form
    {
        public frmFiltering()
        {
            InitializeComponent();
            
        }

        private void frmFiltering_Load(object sender, EventArgs e)
        {
            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)frmMain.Controls["dataGridView1"];

            var datasource = dataGridViewInstance.DataSource;
            dgvShowFilteredData.DataSource = datasource;

            this.dgvShowFilteredData.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dgvShowFilteredData.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.dgvSummary.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dgvSummary.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;


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
            dgvShowFilteredData.Refresh();
        }

        private void dgvShowFilteredData_DataSourceChanged(object sender, EventArgs e)
        {
            int rowCount = dgvShowFilteredData.Rows.Count;
            toolStripStatusLabel1.Text = "No. Of Records: " + rowCount.ToString();
            

        }

        private async void btnUniqueValues_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            btnUniqueValues.Enabled = false;
            panel1.Controls.Clear();

            // Get the DataGridView instance
            //Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            //DataGridView dataGridViewInstance = (DataGridView)frmMain.Controls["dataGridView1"];

            

            // Perform the operation asynchronously
            await Task.Run(() =>
            {
                PopulatingTools popObj = new PopulatingTools();
                popObj.comboxOfUniquevalues(dgvShowFilteredData, panel1);
            });

            Cursor= Cursors.Default;
            btnUniqueValues.Enabled = true;


        }

       

        private void dgvShowFilteredData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnExportFiltredToMain_Click(object sender, EventArgs e)
        {

            if (dgvShowFilteredData.Rows.Count == 0) { return; }
            DataSummarization summeryObject = new DataSummarization();

            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dgvAtMainWindw = (DataGridView)frmMain.Controls["dataGridView1"];
            // Create a new DataTable for the filtered and modified data
            DataTable filteredData = summeryObject.ConvertDataGridViewToDataTable(dgvShowFilteredData);


            dgvAtMainWindw.DataSource = filteredData;
            
            frmMain.Show();
            frmMain.BringToFront();
        }

        private void btnExportFilteredToCSV_Click(object sender, EventArgs e)
        {
            if (dgvShowFilteredData.Rows.Count == 0) { return; }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {


                StringBuilder sb = new StringBuilder();

                // Header
                foreach (DataGridViewColumn col in dgvShowFilteredData.Columns)
                {
                    sb.Append(col.HeaderText + ",");
                }

                sb.AppendLine();

                // Rows
                foreach (DataGridViewRow row in dgvShowFilteredData.Rows)
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

        private void dgvShowFilteredData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                //string rowidx = e.RowIndex.ToString();
                //string colidx = e.ColumnIndex.ToString();
                //MessageBox.Show("rowidx:"+ rowidx + "|col index" + colidx);

                DataGridViewCell headerCell = dgvShowFilteredData.Columns[e.ColumnIndex].HeaderCell;

                if (headerCell != null && headerCell.ColumnIndex == e.ColumnIndex)
                {
                    dgvShowFilteredData.ClearSelection();
                    dgvShowFilteredData.Columns[e.ColumnIndex].Selected = true;

                    ContextMenuStrip contextMenu = new ContextMenuStrip();
                    ToolStripMenuItem deleteColumnMenuItem = new ToolStripMenuItem("Delete Column");
                    deleteColumnMenuItem.Click += (deleteSender, deleteEventArgs) =>
                    {
                        if (e.ColumnIndex >= 0 && e.ColumnIndex < dgvShowFilteredData.Columns.Count)
                        {
                            DataGridViewColumn column = dgvShowFilteredData.Columns[e.ColumnIndex];
                            dgvShowFilteredData.Columns.Remove(column);
                        }
                    };
                    contextMenu.Items.Add(deleteColumnMenuItem);

                    dgvShowFilteredData.ContextMenuStrip = contextMenu;
                    contextMenu.Show(dgvShowFilteredData, dgvShowFilteredData.PointToClient(Cursor.Position));
                }
            }
        }

        private void btnShowSummary_Click_1(object sender, EventArgs e)
        {

            if (dgvShowFilteredData.RowCount == 0)
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            DataSummarization dataSmrObject = new DataSummarization();

            dataSmrObject.SummarizeDataGridView(dgvShowFilteredData, dgvSummary);
            Cursor = Cursors.Default;

        }



        //-------
    }
}
