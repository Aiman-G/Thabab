using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

using System.ComponentModel;

using System.Globalization;
using System.IO;

namespace Thabab
{
    class PopulatingTools
    {
        // adding comboxes with unique values of datagridview to a panel

        public void comboxOfUniquevalues(DataGridView dgv, Panel pnl, ProgressBar pbr)
        {   // some times the column names are big, and the labels cannot show the full name, so the name can be shown as a tooltip
            ToolTip tltip = new ToolTip();

            try
            {
                // Loop through the columns of the DataGridView and create a label and combobox for each column
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    // Create a label for the column name
                    Label label = new Label();
                    label.Text = dgv.Columns[i].HeaderText;
                    label.Top = i * 30;
                    label.Left = 10;
                    label.Width = 100;

                    // set the tooltip text to the label text
                    tltip.SetToolTip(label, label.Text);

                    // Update the UI on the main thread
                    pnl.Invoke((MethodInvoker)delegate
                    {
                        pnl.Controls.Add(label);
                    });

                    // Create a combobox for the unique values of the column
                    ComboBox comboBox = new ComboBox();
                    comboBox.Top = i * 30;
                    comboBox.Left = 120;
                    comboBox.Width = 150;
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                    // let the combobox name be the column name
                    comboBox.Name = dgv.Columns[i].HeaderText;

                    // Get the unique values of the column
                    var values = dgv.Rows.Cast<DataGridViewRow>()
                        .Select(row => row.Cells[i].Value)
                        .Where(val => val != null) // filter out null values
                        .Distinct()
                        .ToArray();

                    // Add the values to the combobox
                    comboBox.Items.AddRange(values);

                    //show the first element instead showing empty combo
                    //comboBox.SelectedIndex = 0;

                    // Update the UI on the main thread
                    pnl.Invoke((MethodInvoker)delegate
                    {
                        pnl.Controls.Add(comboBox);
                    });

                    // Calculate progress percentage
                    int progressPercentage = (i + 1) * 100 / dgv.Columns.Count;

                    // Update the progress bar on the main thread
                    pbr.Invoke((MethodInvoker)delegate
                    {
                        pbr.Value = progressPercentage;
                    });
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that are thrown by the function
                MessageBox.Show("Make sure that : your CSV file is in the correct format, you have enough data.. : " + ex.Message);
            }


        }


        public void PopulateCombBox(DataGridView dgv, ComboBox cmb)
        {
            // Get the column names of the DataGridView
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                // Add each column name to the ComboBox
                cmb.Items.Add(column.Name);
            }
        }

        // populate a datagridview with csv, here read the file only and return a data table 

        public DataTable ReadCsvFile(string filePath)
        {
            DataTable dt = new DataTable();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string headerLine = sr.ReadLine();
                    if (headerLine == null)
                    {
                        throw new InvalidDataException("The selected file is empty.");
                    }

                    string[] headers = headerLine.Split(',');
                    if (headers.Length == 0)
                    {
                        throw new InvalidDataException("The selected file does not have any columns.");
                    }

                    if (headers.Distinct().Count() != headers.Length)
                    {
                        throw new InvalidDataException("The selected file has duplicate column names.");
                    }

                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header);
                    }

                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        if (rows.Length != headers.Length)
                        {
                            throw new InvalidDataException("The selected file has rows with different numbers of columns.");
                        }

                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i];
                        }
                        dt.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // or return an empty DataTable if desired
            }

            return dt;
        }



        // -------- Getting disnict columns of multiple csv files -----------------------------------

        public List<string> GetDistinctColumnsFromCsvFiles(List<string> fileNames)
        {
            List<string> distinctColumns = new List<string>();

            foreach (string fileName in fileNames)
            {
                List<string> columns = GetCsvColumns(fileName);
                foreach (string column in columns)
                {
                    if (!distinctColumns.Contains(column))
                    {
                        distinctColumns.Add(column);
                    }
                }
            }

            return distinctColumns;
        }


        // get columns list for a csv file, given the file path 
        public List<string> GetCsvColumns(string filePath)
        {
            List<string> columns = new List<string>();

            // Read the first line of the CSV file to get the column names
            using (StreamReader sr = new StreamReader(filePath))
            {
                string headerLine = sr.ReadLine();
                if (!string.IsNullOrEmpty(headerLine))
                {
                    columns.AddRange(headerLine.Split(','));
                }
            }

            return columns;
        }

        // ---------------- Get distinct values of categorica variables accross multiple csv files__________________
        public Dictionary<string, List<string>> GetDistinctCategoricalValues(List<string> fileNames)
        {
            Dictionary<string, List<string>> categoricalValues = new Dictionary<string, List<string>>();

            foreach (string fileName in fileNames)
            {
                List<string> columns = GetCsvColumns(fileName);

                foreach (string column in columns)
                {
                    if (!IsCategoricalColumn(fileNames, column))
                        continue;

                    List<string> distinctValues = GetDistinctColumnValues(fileNames, column);

                    if (!categoricalValues.ContainsKey(column))
                    {
                        categoricalValues[column] = new List<string>(distinctValues);
                    }
                    else
                    {
                        List<string> existingDistinctValues = categoricalValues[column];
                        existingDistinctValues.AddRange(distinctValues.Except(existingDistinctValues));
                    }
                }
            }

            return categoricalValues;
        }

        private List<string> GetDistinctColumnValues(List<string> fileNames, string columnName)
        {
            List<string> distinctValues = new List<string>();

            foreach (string fileName in fileNames)
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string headerLine = sr.ReadLine();

                    if (!string.IsNullOrEmpty(headerLine))
                    {
                        string[] headers = headerLine.Split(',');

                        int columnIndex = Array.IndexOf(headers, columnName);

                        if (columnIndex >= 0)
                        {
                            while (!sr.EndOfStream)
                            {
                                string line = sr.ReadLine();
                                string[] values = line.Split(',');

                                if (values.Length > columnIndex)
                                {
                                    string value = values[columnIndex];

                                    if (!string.IsNullOrEmpty(value) && !distinctValues.Contains(value))
                                    {
                                        distinctValues.Add(value);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return distinctValues;
        }


        private bool IsCategoricalColumn(List<string> fileNames, string columnName)
        {
            HashSet<string> uniqueValues = new HashSet<string>();
            int rowCount = 0;

            foreach (string fileName in fileNames)
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string headerLine = sr.ReadLine();

                    if (!string.IsNullOrEmpty(headerLine))
                    {
                        string[] headers = headerLine.Split(',');

                        int columnIndex = Array.IndexOf(headers, columnName);

                        if (columnIndex >= 0)
                        {
                            while (!sr.EndOfStream)
                            {
                                string line = sr.ReadLine();
                                string[] values = line.Split(',');

                                if (values.Length > columnIndex)
                                {
                                    string value = values[columnIndex].Trim();

                                    if (!string.IsNullOrEmpty(value))
                                    {
                                        uniqueValues.Add(value);
                                        rowCount++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            double uniqueValueRatioThreshold = 0.7; // Adjust the threshold as needed

            double uniqueValueRatio = (double)uniqueValues.Count / rowCount;
            return uniqueValueRatio < uniqueValueRatioThreshold;
        }







        private bool IsNumeric(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            value = value.Trim();

            // Remove currency symbols or separators if present
            value = value.Replace("$", "").Replace(",", "");

            return double.TryParse(value, out _);
        }


        //------------------------------------

        public bool CheckCsvFileContainsValues(string filePath, Dictionary<string, string> selectedValues)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine();
                string[] headers = headerLine.Split(',');

                // Get the column indexes of the selected categorical columns
                Dictionary<string, int> columnIndexes = new Dictionary<string, int>();
                foreach (var selectedColumn in selectedValues)
                {
                    string columnName = selectedColumn.Key;
                    if (Array.IndexOf(headers, columnName) >= 0)
                    {
                        int columnIndex = Array.IndexOf(headers, columnName);
                        columnIndexes[columnName] = columnIndex;
                    }
                    else
                    {
                        // Column not found in the file, consider it as not matching
                        return false;
                    }
                }

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    // Check if the values in the selected categorical columns match the selected values
                    bool isMatch = true;
                    foreach (var selectedColumn in selectedValues)
                    {
                        string columnName = selectedColumn.Key;
                        string selectedValue = selectedColumn.Value;
                        int columnIndex = columnIndexes[columnName];
                        string columnValue = values[columnIndex];

                        if (columnValue != selectedValue)
                        {
                            isMatch = false;
                            break;
                        }
                    }

                    if (isMatch)
                    {
                        // At least one row matches the selected values, consider the file as containing the values
                        return true;
                    }
                }
            }

            // No rows matching the selected values found in the file
            return false;
        }

        // Classifying files with common columns

        public Dictionary<string, List<string>> ClassifyCsvFilesByColumns(List<string> filePaths)
        {
            Dictionary<string, List<string>> classifiedFiles = new Dictionary<string, List<string>>();

            foreach (string filePath in filePaths)
            {
                List<string> columns = GetCsvColumns(filePath);
                string key = string.Join(",", columns);

                if (classifiedFiles.ContainsKey(key))
                {
                    classifiedFiles[key].Add(filePath);
                }
                else
                {
                    classifiedFiles[key] = new List<string> { filePath };
                }
            }

            return classifiedFiles;
        }


        // _____________________________ concate csv files-----------------------------

        public DataTable ConcatenateCSVFiles(List<string> filePaths)
        {
            DataTable concatenatedData = new DataTable();

            if (filePaths.Count == 0)
            {
                return concatenatedData;
            }

            // Read the first CSV file to get the column names
            string firstFilePath = filePaths[0];
            concatenatedData = ReadCsvFile(firstFilePath);

            // Remove the header row from the concatenated data
            concatenatedData.Rows.RemoveAt(0);

            // Read and concatenate the data from all the CSV files
            foreach (string filePath in filePaths)
            {
                DataTable fileData = ReadCsvFile(filePath);

                // Remove the header row from the file data
                fileData.Rows.RemoveAt(0);

                // Concatenate the file data with the existing data
                concatenatedData.Merge(fileData);
            }

            return concatenatedData;
        }

















        //--------
    }
}
