using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Thabab
{
    public partial class frmCsvFilesClassification : Form
    {
        public frmCsvFilesClassification()
        {
            InitializeComponent();
        }
        PopulatingTools popTools = new PopulatingTools();

        private void frmCsvFilesClassification_Load(object sender, EventArgs e)

        {
            //tableLayoutPanelClassifiedFiles.RowStyles.Add(
            //    new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dgvShowCSVFile.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dgvShowCSVFile.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;



        }

        private async void btnGetClassfiedFiles_Click(object sender, EventArgs e)
        {
            frmMultiCsvFiles frmMultiCSV = (frmMultiCsvFiles)Application.OpenForms["frmMultiCsvFiles"];
            GroupBox groupBoxCombinationCols = (GroupBox)frmMultiCSV.Controls["groupBoxCombinationCols"];
            System.Windows.Forms.ListView lsvFileNames = (System.Windows.Forms.ListView)groupBoxCombinationCols.Controls["lsvFileNames"];



            List<string> filePaths = new List<string>();

            // Retrieve file paths from the ListView tags
            foreach (ListViewItem item in lsvFileNames.Items)
            {
                if (item.Tag != null)
                {
                    filePaths.Add(item.Tag.ToString());
                }
            }

            // Disable the button and show the progress bar
            btnGetClassfiedFiles.Enabled = false;
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;

            // Execute the classification asynchronously in a separate task
            Dictionary<string, List<string>> classifiedFiles = await Task.Run(() =>
            popTools.ClassifyCsvFilesByColumns(filePaths));




            // Clear existing controls from the table layout panel
            tableLayoutPanelClassifiedFiles.Controls.Clear();
            tableLayoutPanelClassifiedFiles.ColumnStyles.Clear();
            tableLayoutPanelClassifiedFiles.RowStyles.Clear();

            // Create and populate ListView controls for each classified file group
            int column = 0; // Start at the first row
            int nameSuffix = 0; // to name the new created controls
            string lsvName = string.Empty; // to save the ListView name
            

            foreach (var group in classifiedFiles)
            {
                System.Windows.Forms.ListView listView = new System.Windows.Forms.ListView();
                listView.View = View.Tile;
                listView.Width = 273;
                listView.Height = 200;
                //listView.Columns.Add("File Name");

                // Set the ListView control's name as the common column names
                listView.Name = "lsv" + nameSuffix.ToString();

                // Subscribe to the DoubleClick event of the ListView
                listView.DoubleClick += ListView_DoubleClick;

                foreach (var filePath in group.Value)
                {
                    string fileName = Path.GetFileName(filePath);

                    ListViewItem item = new ListViewItem(fileName);
                    item.Tag = filePath;
                    listView.Items.Add(item);
                }

                
                // Create a Label to display the number of files
                Label labelFiles = new Label();

                labelFiles.Text = "Number of Files: " + listView.Items.Count.ToString();

                // lsvName = "lsv" + "lsv" + nameSuffix.ToString(); // get the current Listview name


                // Create a Button for "Contact"
                System.Windows.Forms.Button buttonConcate = new System.Windows.Forms.Button();
                buttonConcate.Text = "Concate";
                // Subscribe to Click event of the buttonConcate
                buttonConcate.Click += ButtonConcate_Click;




                // Add the controls to the table layout panel
                tableLayoutPanelClassifiedFiles.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tableLayoutPanelClassifiedFiles.Controls.Add(labelFiles, column, 0);
                tableLayoutPanelClassifiedFiles.Controls.Add(listView, column, 2);
                tableLayoutPanelClassifiedFiles.Controls.Add(buttonConcate, column, 3);

                // Set explicit column widths
                tableLayoutPanelClassifiedFiles.ColumnStyles[column] = new ColumnStyle(SizeType.Absolute, 300); // Adjust the width as needed



                // Increment the row counter
                column++; // Increase row by 4 to account for all controls in each group
                nameSuffix++; // seting the name suffix for the next listview
            }


            // Enable the button and hide the progress bar
            btnGetClassfiedFiles.Enabled = true;
            progressBar1.Visible = false;


        }

        private void ButtonConcate_Click(object sender, EventArgs e)
        {
            
            // Retrieve the file paths from the ListView above the clicked button
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            int column = tableLayoutPanelClassifiedFiles.GetColumn(button);
            System.Windows.Forms.ListView listView = (System.Windows.Forms.ListView)tableLayoutPanelClassifiedFiles.GetControlFromPosition(column, 2);
            if (listView.Items.Count <=1 ) { return; }

            List<string> filePaths = listView.Items.Cast<ListViewItem>()
                .Select(item => item.Tag.ToString())
                .ToList();

            

            // Concatenate the CSV files
            DataTable concatenatedData = popTools.ConcatenateCSVFiles(filePaths);
            dgvShowCSVFile.DataSource = concatenatedData;
        }

        private void ListView_DoubleClick(object sender, EventArgs e)
        {
            // Get the selected item from the ListView
            System.Windows.Forms.ListView listView = (System.Windows.Forms.ListView)sender;
            ListViewItem selectedItem = listView.SelectedItems[0];

            // Handle the double-click event for the selected item
            // Example: Show a message box with the file path
            string filePath = selectedItem.Tag.ToString();
            // Read the contents of the file and display it in the DataGridView, popTools is an instance of PopulatingTools.cs
            DataTable dataTable = popTools.ReadCsvFile(filePath);
            dgvShowCSVFile.DataSource = dataTable;

        }





        private void dgvShowCSVFile_DataSourceChanged(object sender, EventArgs e)
        {
            toolStripStatuslblRecordsNo.Text = "No of Recoreds:" + 0 ;
            toolStripStatusNoOfColumns.Text = "No of Fields:" + 0;
            toolStripStatuslblRecordsNo.Text = "No of Recoreds:" + dgvShowCSVFile.Rows.Count.ToString();
            toolStripStatusNoOfColumns.Text = "No of Fields:" + dgvShowCSVFile.Columns.Count.ToString();

        }

        private void btnExportToMainWindow_Click(object sender, EventArgs e)
        {
            if (dgvShowCSVFile.Rows.Count == 0) { return; }

            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dgvAtMainWindw = (DataGridView)frmMain.Controls["dataGridView1"];
            dgvAtMainWindw.DataSource = dgvShowCSVFile.DataSource;
            frmMain.Show(); 
            frmMain.BringToFront();


        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (dgvShowCSVFile.Rows.Count == 0) { return; }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {


                StringBuilder sb = new StringBuilder();

                // Header
                foreach (DataGridViewColumn col in dgvShowCSVFile.Columns)
                {
                    sb.Append(col.HeaderText + ",");
                }

                sb.AppendLine();

                // Rows
                foreach (DataGridViewRow row in dgvShowCSVFile.Rows)
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

        private void dgvShowCSVFile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        //_____________________


    }
}
