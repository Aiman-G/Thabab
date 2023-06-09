﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 
namespace Thabab
{
    public partial class frmCmbPlots : Form
    {
        public frmCmbPlots()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true; // set the WorkerReportsProgress property to true

        }


        private void frmCmbPlots_Load(object sender, EventArgs e)
        {
            DataSummarization dataSummarization = new DataSummarization();

            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)frmMain.Controls["dataGridView1"];
            DataTable dt = dataSummarization.ConvertDataGridViewToDataTable(dataGridViewInstance);

            //var datasource = dataGridViewInstance.DataSource;
            dgvShowFilteredData.DataSource = dt;

            PopulatingTools PopCmb = new PopulatingTools();
            PopCmb.PopulateCombBox(dgvShowFilteredData, cmb_x_col);
            PopCmb.PopulateCombBox(dgvShowFilteredData, cmb_y_col);
            PopCmb.PopulateCombBox(dgvShowFilteredData, cmb_cat_var);
            cmb_cat_var.SelectedIndex = 0;
            cmb_y_col.SelectedIndex = 0;
            cmb_x_col.SelectedIndex = 0;

            this.dgvShowFilteredData.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;

            // If you do not set the EnableHeadersVisualStyles flag to False,
            // then the changes of backcolor you make to the style of the header will not take effect
            this.dgvShowFilteredData.EnableHeadersVisualStyles = false;

            this.dgvShowFilteredData.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dgvShowFilteredData.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;


        }

        private void btnUniqueValues_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)frmMain.Controls["dataGridView1"];

            PopulatingTools popObj = new PopulatingTools();
            popObj.comboxOfUniquevalues(dataGridViewInstance, panel1);


            Cursor = Cursors.Default;


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
                MessageBox.Show("Make sure your CSV file is in correct format... " );
            }
        }



        private void btnLoadUnfilterd_Click(object sender, EventArgs e)
        {
            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)frmMain.Controls["dataGridView1"];

            var datasource = dataGridViewInstance.DataSource;
            dgvShowFilteredData.DataSource = datasource;

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

        private string cat_Col;
        private string X_Col;
        private string Y_Col;
        private void btnPlotFilterd_Click(object sender, EventArgs e)
        {
            


            if (dgvShowFilteredData.RowCount > 0)
            {
                Ploting pltTwo = new Ploting();


                if (cmb_x_col.SelectedItem == null || cmb_y_col.SelectedItem == null || cmb_cat_var.SelectedItem == null)
                {
                    MessageBox.Show("You need to upload dataset, then select X, Y, and the categorical variable", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else

                { Ploting pltObj = new Ploting();

                    Cursor = Cursors.WaitCursor;

                    cat_Col = cmb_cat_var.SelectedItem.ToString();
                    X_Col = cmb_x_col.SelectedItem.ToString();
                    Y_Col = cmb_y_col.SelectedItem.ToString();
                    pltTwo.PlotDataByCategory(dgvShowFilteredData, cat_Col, X_Col, Y_Col);

                    Cursor = Cursors.Default;
                }




                
                
                
            }
        }

        private void dgvShowFilteredData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvShowFilteredData_DataSourceChanged(object sender, EventArgs e)
        {
            int rowCount = dgvShowFilteredData.Rows.Count;
             toolStripStatusLabel1.Text = "NO. of Records: " + rowCount.ToString();
           
        }
    }
}
