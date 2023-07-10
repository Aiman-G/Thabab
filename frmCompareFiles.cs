using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Thabab
{
    public partial class frmCompareFiles : Form
    {
        public frmCompareFiles()
        {
            InitializeComponent();
        }

        PopulatingTools popObj = new PopulatingTools();

        // two global variables to save the chosen file names 

        string FirstFileName = string.Empty;
        string SecondFileName = string.Empty;
        string FirstFilePath = string.Empty;
        string SecondFilePath = string.Empty;



        private void frmCompareFiles_Load(object sender, EventArgs e)
        {
            frmMultiCsvFiles frmMultiCSV = (frmMultiCsvFiles)Application.OpenForms["frmMultiCsvFiles"];
            // to retrieve the listview contol that contains files, we first rtreive its container ( the groupbox)
            GroupBox groupBoxCombinationCols = (GroupBox)frmMultiCSV.Controls["groupBoxCombinationCols"];
            System.Windows.Forms.ListView lsvFileNames = (System.Windows.Forms.ListView)groupBoxCombinationCols.Controls["lsvFileNames"];

            // Clear existing data in the DataGridViews
            dgvFirstFile.Rows.Clear();
            dgvSecondFile.Rows.Clear();

            // Iterate over the ListView items and populate the DataGridViews

            foreach (ListViewItem item in lsvFileNames.Items)
            {
                string fileName = item.Text; // Get the file name from the ListViewItem
                string filePath = item.Tag.ToString(); // Get the file path from the ListViewItem tag

                // Add the file name to dgvFirstFile
                DataGridViewRow firstFileRow = dgvFirstFile.Rows[dgvFirstFile.Rows.Add(fileName)];
                firstFileRow.Tag = filePath; // Set the tag as the file path

                // Add the file name to dgvSecondFile
                DataGridViewRow secondFileRow = dgvSecondFile.Rows[dgvSecondFile.Rows.Add(fileName)];
                secondFileRow.Tag = filePath; // Set the tag as the file path
            }

            // style of datagridview tools
            this.dgvFirstFile.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dgvFirstFile.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            this.dgvSecondFile.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dgvSecondFile.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            this.dgvFirstFileSummary.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dgvFirstFileSummary.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            this.dgvSecondFileSummary.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dgvSecondFileSummary.AlternatingRowsDefaultCellStyle.BackColor= Color.Beige;

            


        }





        private void dgvFirstFile_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = (DataGridView)sender;
                DataGridViewCell clickedCell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];

                DataGridViewRow clickedRow = dgv.Rows[e.RowIndex];
                if (clickedRow.Tag != null)
                {
                    string filePath = clickedRow.Tag.ToString();

                    // Perform further actions with filePath
                    FirstFilePath = filePath;
                    FirstFileName = clickedCell.FormattedValue.ToString();
                    //ColumnNamesToListViews();

                    //MessageBox.Show($"File Path: {filePath}");
                }
            }
        }

        private void dgvSecondFile_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = (DataGridView)sender;
                DataGridViewCell clickedCell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];

                DataGridViewRow clickedRow = dgv.Rows[e.RowIndex];
                if (clickedRow.Tag != null)
                {
                    string filePath = clickedRow.Tag.ToString();
                    // Perform further actions with filePath
                    SecondFilePath = filePath;
                    SecondFileName = clickedCell.FormattedValue.ToString();
                    //ColumnNamesToListViews();
                    //MessageBox.Show($"File Path: {filePath}");
                }
            }
        }


        private void tabControlComparison_MouseClick(object sender, MouseEventArgs e)
        {
            ColumnNamesToListViews();
        }

        // ---------- populate listviews with column names 



        private void tabControlComparison_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(tabControlComparison.SelectedIndex.ToString());
           

            switch (tabControlComparison.SelectedIndex)
            {
                case 0:
                    
                    ColumnNamesToListViews();
                    break;

                case 1:
                    
                    break;

                case 2:
                    

                    break;



            }



        }



        //bind chart to a datatable 


        private void PlotChartFromTable(string filename, Chart crtControl)
        {
            DataTable chartDatatable = popObj.ReadCsvFile(filename);

            // Clear any existing series from the chart
            crtControl.Series.Clear();

            // set properties of chart controls 

            crtControl.ChartAreas[0].CursorX.IsUserEnabled = true;
            crtControl.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            crtControl.ChartAreas[0].CursorY.IsUserEnabled = true;
            crtControl.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;

            // Check if the DataTable contains data
            if (chartDatatable != null && chartDatatable.Rows.Count > 0)
            {
                // Iterate over each column and plot the histogram
                foreach (DataColumn column in chartDatatable.Columns)
                {
                    string columnName = column.ColumnName;
                    Series series = new Series(columnName);
                    series.ChartType = SeriesChartType.Column;

                    // Create a dictionary to store value frequencies
                    Dictionary<object, int> valueFrequencies = new Dictionary<object, int>();

                    // Iterate over each row and count the frequencies
                    foreach (DataRow row in chartDatatable.Rows)
                    {
                        object value = row[column];
                        if (!valueFrequencies.ContainsKey(value))
                            valueFrequencies[value] = 0;
                        valueFrequencies[value]++;
                    }

                    // Add data points to the series
                    foreach (KeyValuePair<object, int> kvp in valueFrequencies)
                    {
                        series.Points.AddXY(kvp.Key.ToString(), kvp.Value);
                    }

                    // Add the series to the chart
                    crtControl.Series.Add(series);
                }

                // Set chart title
                crtControl.Titles.Clear();
                crtControl.Titles.Add("Histogram");

                // Set X-axis label
                crtControl.ChartAreas[0].AxisX.Title = "Values";

                // Set Y-axis label
                crtControl.ChartAreas[0].AxisY.Title = "Frequency";
            }
            else
            {
                // Handle the case when the DataTable is empty or null
                MessageBox.Show("No data available to plot.");
            }
        }





        // summarize a csv file into a datagridview
        private void SummarizeFileToDatagridView(string filename, DataGridView dgvTarget)
            {
            DataSummarization dataSmrObject = new DataSummarization();
            // summarize the first file 
            DataTable FileDataTable = popObj.ReadCsvFile(filename);

            // Create a new DataGridView for the CSV data
            DataGridView sourceDataGridView = new DataGridView();

            //this step is a must, or the datagridview will be empty even if the datatable has data
            
            this.Controls.Add(sourceDataGridView);
            sourceDataGridView.Visible = false;

            sourceDataGridView.DataSource = FileDataTable;
            // Clear the target grid
            dgvTarget.Rows.Clear();
            dgvTarget.Columns.Clear();

            //set datagridview appearance
            

            // Summarize the DataGridView
            dataSmrObject.SummarizeDataGridView(sourceDataGridView, dgvTarget);

        }

        
        private void ColumnNamesToListViews()
        {
            if (!string.IsNullOrEmpty(FirstFilePath) && !string.IsNullOrEmpty(SecondFilePath))
            {
                // Both variables are not empty
                // Perform further actions
                List<string> FirstFileColumns = new List<string>();
                List<string> SecondFileColumns = new List<string>();
                FirstFileColumns = popObj.GetCsvColumns(FirstFilePath);
                SecondFileColumns = popObj.GetCsvColumns(SecondFilePath);

                lblFirstFileName.Text = FirstFileName;
                lblSecondFileName.Text = SecondFileName;

                // Clear existing items in the list boxes
                listBoxCommonColumns.Items.Clear();
                listBoxDifferentColumns.Items.Clear();

                // Find common columns
                List<string> commonColumns = FirstFileColumns.Intersect(SecondFileColumns).ToList();

                // Find different columns
                List<string> differentColumns = FirstFileColumns.Except(SecondFileColumns).Union(SecondFileColumns.Except(FirstFileColumns)).ToList();

                // Populate listBoxCommonColumns
                foreach (string column in commonColumns)
                {
                    listBoxCommonColumns.Items.Add(column);
                }

                // Populate listBoxDifferentColumns
                foreach (string column in differentColumns)
                {
                    listBoxDifferentColumns.Items.Add(column);
                }

                // Clear existing items in the ListViews
                lsvFirstFile.Items.Clear();
                lsvSecondFile.Items.Clear();
                // Customize the header appearance


                // Set ListView view mode to Details
                //lsvFirstFile.View = View.Details;
                //lsvSecondFile.View = View.Details;

                // Add column headers
                lsvFirstFile.Columns.Add("Column Names");
                lsvSecondFile.Columns.Add("Column Names");

                // Populate lsvFirstFile
                foreach (string item in FirstFileColumns)
                {
                    ListViewItem listItem = new ListViewItem(item);
                    lsvFirstFile.Items.Add(listItem);
                }

                // Populate lsvSecondFile
                foreach (string item in SecondFileColumns)
                {
                    ListViewItem listItem = new ListViewItem(item);
                    lsvSecondFile.Items.Add(listItem);
                }
            }
            else
            {
                // At least one of the variables is empty
                // Handle the case when the variables are empty
            }
        }

        private void btnRefreshColumnsInfo_Click(object sender, EventArgs e)
        {
            ColumnNamesToListViews();
        }

        private  void btnRefreshSummary_Click(object sender, EventArgs e)
        {
            //show the prgressbar
            // Change the mouse pointer to the wait cursor

            Cursor = Cursors.WaitCursor;
            btnRefreshSummary.Enabled = false;
            lblFirstFileNameSummary.Text = FirstFileName;
            lblSecondFileNameSummary.Text = SecondFileName;

            btnRefreshSummary.Enabled = false;
            SummarizeFileToDatagridView(FirstFilePath, dgvFirstFileSummary);
            SummarizeFileToDatagridView(SecondFilePath, dgvSecondFileSummary);

            Cursor = Cursors.Default;  
            btnRefreshSummary.Enabled = true;
      

        }

        private void btnRefreshChart_Click(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;
            // Disable the button during the operation
            btnRefreshChart.Enabled = false;
            lblFirstFileNameChart.Text = FirstFileName;
            lblSecondFileNameChart.Text = SecondFileName;

            
           PlotChartFromTable(FirstFilePath, chartFirstFile);
           PlotChartFromTable(SecondFilePath, chartSecondFile);
           

            Cursor = Cursors.Default;

            // Enable the button after the operation is complete
            btnRefreshChart.Enabled = true;
        }





        //______________________
    }
}
