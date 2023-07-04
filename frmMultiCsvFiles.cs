using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Thabab
{
    public partial class frmMultiCsvFiles : Form
    {
        public frmMultiCsvFiles()
        {
            InitializeComponent();
        }
        PopulatingTools popTools = new PopulatingTools();

        // This originalItems list is to keep a verision for the filterd files, so that when the user undo filtering,
        // we can repopulate listview with the original files. 
        private List<ListViewItem> originalItems;

        // Declare a list to store the original files

        private List<ListViewItem> originalItemsForCatColumnsListview;

        private async void btnMultiCsvUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            checkedListBoxColumns.Items.Clear();
            lsvFileNames.Items.Clear();
            lblFilesNumber.Text = "No of Files:" + 0;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Disable the button to prevent multiple clicks
                btnMultiCsvUpload.Enabled = false;

                // Show the progress bar
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                progressBar1.Maximum = openFileDialog.FileNames.Length;

                await Task.Run(() =>
                {
                    // Read and process the CSV files asynchronously
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        string fileName = Path.GetFileName(filePath);
                        ListViewItem listItem = new ListViewItem(fileName);
                        listItem.Tag = filePath;

                        // Invoke the ListView control on the UI thread to update its items
                        lsvFileNames.Invoke((MethodInvoker)delegate
                        {
                            lsvFileNames.Items.Add(listItem);
                        });

                        // Update the progress bar value on the UI thread
                        progressBar1.Invoke((MethodInvoker)delegate
                        {
                            progressBar1.Value++;
                        });
                    }
                });

                // Update the file numbers in the label
                lblFilesNumber.Text = "No of Files: " + lsvFileNames.Items.Count.ToString();

                // Re-enable the button
                btnMultiCsvUpload.Enabled = true;

                // Reset the progress bar
                progressBar1.Value = 0;
                progressBar1.Visible = false;
            }
        }









        private void frmMultiCsvFiles_Load(object sender, EventArgs e)
        {
            this.Width = 1254;
            this.Height = 777;
            helpProvider1.SetHelpString(btnFilterByCatCols, "Filter the files according to categorical variables values on the left. ");
            helpProvider1.SetHelpString(btnUniqueColumnNames, "Get the unique column names accross all the files. ");
            helpProvider1.SetHelpString(btnFilterFileNames, "Get the fiels that contain the chosen columns .");
            helpProvider1.SetHelpString(btnDistinctValuesAcrossFiles, "Get the unique values of categrorical varaialbes accross all the files," +
                "Note, if a column name is too big to be fully shown, hover the mouse over the column name to see a tip that shows the full name." +
                "Perfectionism!");
            helpProvider1.SetHelpString(lsvFileNames, "Double click on the files name to show its content.");
            helpProvider1.SetHelpString(lsvFilterdByCatCols, "Double click on the file name to show its content.");
            helpProvider1.SetHelpString(btnClassifyCsvFiles, "This will take you to a new window, " +
                "where you can get the files with common column names/numbers grouped, so that you can combine similar files." +
                " The files that will get grouped are in the below list.");
            helpProvider1.SetHelpString(pictureBoxHome, "Show the main window.");

            helpProvider1.SetHelpString(btnResetFiltering, "Retrieve the orginal items before filtering.");
            
                



            // set the number of files label to 0;
            lblFilesNumber.Text = "No of Files: " + lsvFileNames.Items.Count.ToString();

            this.dgvShowSelected.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dgvShowSelected.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

        }

        private void lsvFileNames_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = lsvFileNames.SelectedItems[0];
            string filePath = selectedItem.Tag.ToString();

            // Read the contents of the file and display it in the DataGridView, popTools is an instance of PopulatingTools.cs
            DataTable dataTable = popTools.ReadCsvFile(filePath);
            dgvShowSelected.DataSource = dataTable;
        }

        private void cmbCommonColumns_SelectedIndexChanged(object sender, EventArgs e)

        {

            
        }

        private async void btnFilterFileNames_Click(object sender, EventArgs e)
        {
            if (originalItems is null) return;
           

            // Disable the filter button
            btnFilterFileNames.Enabled = false;

            // Show the progress bar
            progressBar1.Visible = true;

            // Start the progress bar animation
            progressBar1.Style = ProgressBarStyle.Marquee;

            // Get the selected column names from the CheckedListBox
            List<string> selectedColumns = new List<string>();
            foreach (string checkedItem in checkedListBoxColumns.CheckedItems)
            {
                selectedColumns.Add(checkedItem);
            }

                        
            
            // Create a copy of the original file names list
            List<ListViewItem> filteredItems = new List<ListViewItem>(originalItems);

            await Task.Run(() =>
            {
                // Filter the file names in the copy list based on the selected columns
                foreach (ListViewItem item in originalItems)
                {
                    string filePath = item.Tag as string;

                    // Get the columns of the current file
                    List<string> columns = popTools.GetCsvColumns(filePath);

                    // Check if all selected columns are present in the current file's columns
                    bool isMatch = selectedColumns.Count == 0 || selectedColumns.All(selectedColumn => columns.Contains(selectedColumn));

                    if (!isMatch)
                    {
                        // Remove the item from the copy list
                        filteredItems.Remove(item);
                    }
                }
            });

            // Update the ListView with the filtered items
            lsvFileNames.BeginUpdate();
            lsvFileNames.Items.Clear();
            lsvFileNames.Items.AddRange(filteredItems.ToArray());
            lsvFileNames.EndUpdate();

            // Update the file numbers in the label
            lblFilesNumber.Text = "No of Files: " + lsvFileNames.Items.Count.ToString();

            
            // Hide the progress bar
            progressBar1.Visible = false;

            // Re-enable the filter button
            btnFilterFileNames.Enabled = true;
        }

        //------------------------

        private async void btnFilterByCatCols_Click(object sender, EventArgs e)
        {
            // keep a copy of the items before filtering to be able to revert filtering

            originalItemsForCatColumnsListview =  lsvFileNames.Items.Cast<ListViewItem>().ToList();
            // Disable the button
            btnFilterByCatCols.Enabled = false;

            // Show the progress bar
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;

            // Retrieve selected values from comboboxes on the main UI thread
            Dictionary<string, string> selectedValues = new Dictionary<string, string>();
            Invoke((MethodInvoker)delegate
            {
                foreach (Control control in panelColDistmictValues.Controls)
                {
                    if (control is System.Windows.Forms.ComboBox comboBox && comboBox.SelectedIndex != -1)
                    {
                        string columnName = comboBox.Tag.ToString();
                        string selectedValue = comboBox.SelectedItem.ToString();
                        selectedValues[columnName] = selectedValue;
                    }
                }
            });

            // Get the file names from lsvFileNames on the main UI thread
            List<ListViewItem> fileItems = new List<ListViewItem>();
            Invoke((MethodInvoker)delegate
            {
                fileItems.AddRange(lsvFileNames.Items.Cast<ListViewItem>());
            });

            // Filter the file names based on the selected categorical column values
            List<ListViewItem> filteredItems = await Task.Run(() =>
            {
                List<ListViewItem> filteredList = new List<ListViewItem>();

                foreach (ListViewItem item in fileItems)
                {
                    string filePath = item.Tag as string;
                    string fileName = Path.GetFileName(filePath);

                    // Check if the file contains the selected values in categorical columns
                    bool containsValues = popTools.CheckCsvFileContainsValues(filePath, selectedValues);

                    if (containsValues)
                    {
                        // Create a new ListViewItem with the file name as text and save the full file path as a tag
                        ListViewItem filteredItem = new ListViewItem(fileName);
                        filteredItem.Tag = filePath; // Use the full file path instead of just the file name

                        // Add the item to the filtered list
                        filteredList.Add(filteredItem);
                    }
                }

                return filteredList;
            });

            // Update the filtered ListView on the main UI thread
            Invoke((MethodInvoker)delegate
            {
                lsvFilterdByCatCols.BeginUpdate();
                lsvFilterdByCatCols.Items.Clear();
                lsvFilterdByCatCols.Items.AddRange(filteredItems.ToArray());
                lsvFilterdByCatCols.EndUpdate();

                // Hide the progress bar
                progressBar1.Visible = false;
                progressBar1.Style = ProgressBarStyle.Blocks;

                // Enable the button
                btnFilterByCatCols.Enabled = true;
            });

            // Update the file numbers in the label
            lblFileNumberOfCatcols.Text = "No of Files: " + lsvFilterdByCatCols.Items.Count.ToString();
        }

        
        private void lsvFilterdByCatCols_DoubleClick(object sender, EventArgs e)
        {

                ListViewItem selectedItem = lsvFilterdByCatCols.SelectedItems[0];
                string filePath = selectedItem.Tag.ToString();

                // Read the contents of the file and display it in the DataGridView
                DataTable dataTable = popTools.ReadCsvFile(filePath);
                dgvShowSelected.DataSource = dataTable;
            
        }

        private async void btnDistinctValuesAcrossFiles_Click(object sender, EventArgs e)
        {
            if (lsvFileNames.Items.Count == 0) return;

            // Disable the filter button
            btnDistinctValuesAcrossFiles.Enabled = false;
            //Disable the button that filter by categerocal columns
            btnFilterByCatCols.Enabled = false;
            btnFilterFileNames.Enabled= false;
            btnMultiCsvUpload.Enabled = false;
            btnResetFiltering.Enabled = false;

            // Clear the panel before populating it
            panelColDistmictValues.Controls.Clear();

            txtCatCols.Visible = true;

            // Set the parent of the textbox as the panel
            txtCatCols.Parent = panelColDistmictValues;
            txtCatCols.BringToFront();

            // Show the progress bar
            progressBarCatCols.Visible = true;

            // Start the progress bar animation
            progressBarCatCols.Style = ProgressBarStyle.Marquee;


            

            int labelTop = 10; // Initial top position for the label
            int comboBoxTop = 10; // Initial top position for the combobox

            // Create a copy of the original file names list
            List<ListViewItem> filteredItems = new List<ListViewItem>();

            // Get the file names from the ListView's items' tag
            foreach (ListViewItem item in lsvFileNames.Items)
            {
                string filePath = item.Tag as string;
                filteredItems.Add(new ListViewItem(item.Text) { Tag = filePath });
            }

            // Get distinct categorical columns and their values
            Dictionary<string, List<string>> distinctCategoricalValues = await Task.Run(() =>
            {
                return popTools.GetDistinctCategoricalValues(filteredItems.Select(item => item.Tag as string).ToList());

            });

            // Populate the panel with labels and comboboxes
            foreach (KeyValuePair<string, List<string>> entry in distinctCategoricalValues)
            {
                string columnName = entry.Key;
                List<string> columnValues = entry.Value;

                // Create a label for the column name
                Label label = new Label();
                label.Text = columnName;
                label.AutoSize = true;
                label.Left = 10;
                label.Top = labelTop;
                // set the tool tip to show the column name if the column name is too big to be shown fully, when the user hover, will see full name
              
                toolTip1.SetToolTip(label, label.Text);


                panelColDistmictValues.Controls.Add(label);

                // Create a combobox containing the distinct values
                System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();
                comboBox.Items.AddRange(columnValues.ToArray());
                comboBox.Left = 120;
                comboBox.Top = comboBoxTop;
                comboBox.Tag = columnName; // Assign the column name as the tag
                panelColDistmictValues.Controls.Add(comboBox);


                // Create a label for the number of items
                Label itemCountLabel = new Label();
                itemCountLabel.Text = "Count: " + columnValues.Count.ToString();
                itemCountLabel.AutoSize = true;
                itemCountLabel.Left = 240;
                itemCountLabel.Top = comboBoxTop;
                panelColDistmictValues.Controls.Add(itemCountLabel);

                // Adjust the top positions for the next label and combobox
                labelTop += 30;
                comboBoxTop += 30;
            }

            // Hide the progress bar
            progressBarCatCols.Visible = false;
            txtCatCols.Visible = false; 

            // Re-enable the filter button
            btnDistinctValuesAcrossFiles.Enabled = true;
            btnFilterByCatCols.Enabled = true;

            btnFilterFileNames.Enabled= true;
            btnMultiCsvUpload.Enabled = true;
            btnResetFiltering.Enabled = true;


        }

        private void dgvShowSelected_DataSourceChanged(object sender, EventArgs e)
           
        {
            // Get the number of columns in the DataGridView
            int recordsCount = dgvShowSelected.Rows.Count;
            lblNoOfRecords.Text= "No of Records:" + recordsCount.ToString();

        }

        private void btnClassifyCsvFiles_Click(object sender, EventArgs e)
        {
            frmCsvFilesClassification frmClassifyCsvs = new frmCsvFilesClassification();
            frmClassifyCsvs.Show();

        }

        private async void btnUniqueColumnNames_Click(object sender, EventArgs e)
        {
            // Check if lsvFileNames is empty
            if (lsvFileNames.Items.Count == 0)
            {
                MessageBox.Show("No files uploaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            checkedListBoxColumns.Items.Clear();

            // Disable the button and show the progress bar
            btnUniqueColumnNames.Enabled = false;
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;

            List<string> fileNames = new List<string>();

            await Task.Run(() =>
            {
                // Get the file names from the ListView's items' tag
                List<string> tempFileNames = new List<string>();
                lsvFileNames.Invoke((MethodInvoker)(() =>
                {
                    tempFileNames = lsvFileNames.Items.Cast<ListViewItem>()
                                                      .Select(item => item.Tag.ToString())
                                                      .ToList();
                }));
                fileNames.AddRange(tempFileNames);

                // Get the distinct column names from the CSV files
                List<string> distinctColumns = popTools.GetDistinctColumnsFromCsvFiles(fileNames);

                // Invoke the UI update on the main thread
                this.Invoke(new Action(() =>
                {
                    // Populate the CheckedListBox with distinct column names
                    checkedListBoxColumns.Items.Clear();
                    checkedListBoxColumns.Items.AddRange(distinctColumns.ToArray());

                    // Store the original file names in a separate list
                    originalItems = new List<ListViewItem>(lsvFileNames.Items.Cast<ListViewItem>());

                    // Hide the progress bar
                    progressBar1.Visible = false;

                    // Enable the button
                    btnUniqueColumnNames.Enabled = true;
                }));
            });
        }

        private void lsvFileNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            frmMain.BringToFront();
        }

        private void btnResetFiltering_Click(object sender, EventArgs e)
        {
            // Clear the filtered ListView and re-populate it with the original files
            lsvFilterdByCatCols.BeginUpdate();
            lsvFilterdByCatCols.Items.Clear();

            foreach (var originalItem in originalItemsForCatColumnsListview)
            {
                ListViewItem newItem = new ListViewItem(originalItem.Text);
                newItem.Tag = originalItem.Tag;

                lsvFilterdByCatCols.Items.Add(newItem);
            }

            lsvFilterdByCatCols.EndUpdate();

            // Update the file numbers in the label
            lblFileNumberOfCatcols.Text = "No of Files: " + lsvFilterdByCatCols.Items.Count.ToString();
        }

        private void btnExportToMain_Click(object sender, EventArgs e)
        {
            if (dgvShowSelected.Rows.Count == 0) { return; }

            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dgvAtMainWindw = (DataGridView)frmMain.Controls["dataGridView1"];
            dgvAtMainWindw.DataSource = dgvShowSelected.DataSource;
            frmMain.Show();
            frmMain.BringToFront();
        }





        /*
        private async void btnDistnictColsAcrossFiles_Click(object sender, EventArgs e)
        {
            // Check if lsvFileNames is empty
            if (lsvFileNames.Items.Count == 0)
            {
                MessageBox.Show("No files uploaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            progressBardictinctColNames.Visible = true;
            progressBardictinctColNames.Style = ProgressBarStyle.Marquee;

            await Task.Run(() =>
            {
                // Get the distinct columns from all the CSV files in the lsvFileNames and populate the CheckedListBox
                List<string> fileNames = new List<string>();

                // Get the file names from the ListView's items' tag
                List<string> tempFileNames = new List<string>();

                Invoke((MethodInvoker)delegate
                {
                    foreach (ListViewItem item in lsvFileNames.Items)
                    {
                        string filePath = item.Tag as string;
                        tempFileNames.Add(filePath);
                    }
                });

                fileNames.AddRange(tempFileNames);

                // Get the distinct column names from the CSV files
                List<string> distinctColumns = popTools.GetDistinctColumnsFromCsvFiles(fileNames);

                // Populate the CheckedListBox with distinct column names
                BeginInvoke((MethodInvoker)delegate
                {
                    checkedListBoxColumns.Items.Clear();
                    checkedListBoxColumns.Items.AddRange(distinctColumns.ToArray());
                });

            });

            progressBardictinctColNames.Visible = false;
        }
        */








        //-----------------------------

    }
}
