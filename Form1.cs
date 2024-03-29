﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using luminous;
using MathNet.Numerics.Statistics;
using OxyPlot;

namespace Thabab

{
    public partial class Form1 : Form
    {
        public string cat_Col;
        public string time_Col;
        public string flux_Col;


        DataProcessing dpObject = new DataProcessing();
        PopulatingTools popTools = new PopulatingTools();

      


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
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        
            MainFormhelpProvider.SetHelpString(dataGridView1, "To delet a column right click and the column. You can move a column by click and hold" +
                "then move it. You can delete a row by selecting it and click delete from the keyboard. " +
                "You can chose more than a row by holding the ctrl key" +
                "key and use the mouse to choose the rows. If you want to choose multiple neighboring rows, no need to hold the ctrl key ");
            //LstBox_cat_columns.Visible = false;
            //LstBoxTimeFlux.Visible = false;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            
            // If you do not set the EnableHeadersVisualStyles flag to False,
            // then the changes of backcolor you make to the style of the header will not take effect
            this.dataGridView1.EnableHeadersVisualStyles = false;

            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

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









        private void loadCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog1.Title = "Select a CSV File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Clear the current data in the DataTable
                if (dataGridView1.DataSource is DataTable dataTable)
                {
                    dataTable.Clear();
                    dataTable.Columns.Clear();
                }

                string filePath = openFileDialog1.FileName;
                DataTable newDataTable = popTools.ReadCsvFile(filePath);

                // Set the DataTable as the DataSource of the DataGridView.
                dataGridView1.DataSource = newDataTable;

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

            var AreThereQuotes = dpObject.AreValuesSurroundedByQuotes(dataGridView1);
            if (AreThereQuotes)
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
            Cursor = Cursors.WaitCursor;
            // some csv files arn't standard, and the values of strings are in quotes, this could cause a problem
            var quotedValues = dpObject.AreValuesSurroundedByQuotes(dataGridView1);
            if (quotedValues)
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
            Cursor = Cursors.Default;


        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)

        {
            Cursor = Cursors.WaitCursor;

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
            Cursor = Cursors.Default;
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
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.RestoreDirectory = true;

                Cursor = Cursors.WaitCursor;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();

                    // Header
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        sb.Append(col.HeaderText + ",");
                    }
                    sb.Length--; // Remove the trailing comma
                    sb.AppendLine();

                    // Rows
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            sb.Append(cell.Value + ",");
                        }
                        sb.Length--; // Remove the trailing comma
                        sb.AppendLine();
                    }

                    // Save to file
                    File.WriteAllText(saveFileDialog.FileName, sb.ToString());

                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while exporting to CSV: " + ex.Message);
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

        //private void Form1_Resize(object sender, EventArgs e)
        //{
         //   dataGridView1.Width = this.Width - 20;
            // dataGridView1.Height = this.Height - (this.Height/20);
         //   dataGridView1.Height = this.Height;
       // }

        private void multipleCSVsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMultiCsvFiles frmMultiCSV = new frmMultiCsvFiles();
            frmMultiCSV.Show();
        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Check if the close button (X button) was clicked
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Display a MessageBox to confirm if the user wants to close the application
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user clicks "No", cancel the closing event
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            toolStripStatusLabel1.Text = "No of Records:" + dataGridView1.Rows.Count;

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            toolStripStatusLabel1.Text = "No of Records:" + dataGridView1.Rows.Count;
        }



        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                //string rowidx = e.RowIndex.ToString();
                //string colidx = e.ColumnIndex.ToString();
                //MessageBox.Show("rowidx:"+ rowidx + "|col index" + colidx);
                               
                DataGridViewCell headerCell = dataGridView1.Columns[e.ColumnIndex].HeaderCell;

                if (headerCell != null && headerCell.ColumnIndex == e.ColumnIndex)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Columns[e.ColumnIndex].Selected = true;

                    ContextMenuStrip contextMenu = new ContextMenuStrip();
                    // Create a ToolStripMenuItem with the column name for deletion
                   string columnName = headerCell.Value.ToString();
                   ToolStripMenuItem deleteColumnMenuItem = new ToolStripMenuItem("Delete " + columnName);

                    deleteColumnMenuItem.Click += (deleteSender, deleteEventArgs) =>
                    {
                        if (e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.Columns.Count)
                        {
                            DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                            dataGridView1.Columns.Remove(column);
                        }
                    };
                    contextMenu.Items.Add(deleteColumnMenuItem);

                    dataGridView1.ContextMenuStrip = contextMenu;
                    contextMenu.Show(dataGridView1, dataGridView1.PointToClient(Cursor.Position));
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }














        //___________________
    }
}
