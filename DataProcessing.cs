using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
//using MathNet.Numerics.Statistics;
using System.Globalization;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProgressBar = System.Windows.Forms.ProgressBar;

namespace Thabab
{
    class DataProcessing
    {
        //RemoveRowsWithEmptyCells



        public void RemoveNullRowsFromDataGridView(DataGridView dgv)
        {

            // Get the DataTable associated with the DataGridView
            DataTable dt = (DataTable)dgv.DataSource;

            // Create a new DataTable to hold the filtered rows
            DataTable filteredDt = dt.Clone();

            // Filter out rows with null, DBNull or NaN values
            foreach (DataRow row in dt.Rows)
            {
                bool rowIsNull = true;

                foreach (var item in row.ItemArray)
                {
                    if (item != null && item != DBNull.Value)
                    {
                        if (double.TryParse(item.ToString(), out double value))
                        {
                            if (!double.IsNaN(value))
                            {
                                rowIsNull = false;
                            }
                            else
                            {
                                rowIsNull = true; // remove row with NaN value
                                break;
                            }
                        }
                        else if (item.ToString().Equals("NaN", StringComparison.OrdinalIgnoreCase))
                        {
                            rowIsNull = true; // remove row with "NaN" string
                            break;
                        }
                        else
                        {
                            rowIsNull = false;
                        }
                    }
                }

                if (!rowIsNull)
                {
                    filteredDt.Rows.Add(row.ItemArray);
                }
            }

            // Reassign the filtered DataTable as the DataSource for the DataGridView
            dgv.DataSource = filteredDt;

        }


        // Function to check if values in DataGridView are surrounded by quotes
        public bool AreValuesSurroundedByQuotes(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                string header = col.HeaderText?.ToString() ?? "";
                if (header.Length > 1 && header[0] == '"' && header[header.Length - 1] == '"')
                {
                    return true;
                }
            }
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string value = cell.Value?.ToString() ?? "";
                    if (value.Length > 1 && value[0] == '"' && value[value.Length - 1] == '"')
                    {
                        return true;
                    }
                }
            }
            return false;
        }



        // Function to remove surrounding quotes from values and column names in DataGridView
        public void RemoveQuotesFromValuesAndColumns(DataGridView dgv)
        {
            // Check and remove quotes and blanks from column headers
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                // Remove quotes
                if (column.HeaderText.Contains("\""))
                {
                    column.HeaderText = column.HeaderText.Replace("\"", string.Empty);
                }

                // Remove blanks
                if (column.HeaderText.Trim().Length == 0)
                {
                    column.HeaderText = "Column" + column.Index.ToString();
                }
            }

            // Check and remove quotes from cells
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains("\""))
                    {
                        cell.Value = cell.Value.ToString().Replace("\"", string.Empty);
                    }
                }
            }

            // Refresh the DataGridView to update the changes
            dgv.Refresh();


        }


        public void NormalizeColumns11(DataGridView dgv, List<string> columnNames)
        {
            // Loop through each column name in the list
            foreach (string columnName in columnNames)
            {
                // Find the index of the column with the specified name
                int columnIndex = dgv.Columns[columnName].Index;

                // Loop through each row in the DataGridView
                double maxValue = double.MinValue;
                double minValue = double.MaxValue;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    // Get the value of the cell in the current row and column
                    double cellValue = Convert.ToDouble(row.Cells[columnIndex].Value);

                    // Update the max and min values if necessary
                    if (cellValue > maxValue) maxValue = cellValue;
                    if (cellValue < minValue) minValue = cellValue;
                }

                // Loop through each row in the DataGridView again
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    // Get the value of the cell in the current row and column
                    double cellValue = Convert.ToDouble(row.Cells[columnIndex].Value);

                    // Normalize the value and update the cell
                    double normalizedValue = (cellValue - minValue) / (maxValue - minValue);
                    row.Cells[columnIndex].Value = normalizedValue;
                }
            }
        }

        public void NormalizeColumns22(DataGridView dgv, List<string> columnNames)
        {
            // Loop through each column name in the list
            foreach (string columnName in columnNames)
            {
                // Find the index of the column with the specified name
                int columnIndex = dgv.Columns[columnName].Index;

                // Loop through each row in the DataGridView
                double maxValue = double.MinValue;
                double minValue = double.MaxValue;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    // Get the value of the cell in the current row and column
                    double cellValue = Convert.ToDouble(row.Cells[columnIndex].Value);

                    // Update the max and min values if necessary
                    if (cellValue > maxValue) maxValue = cellValue;
                    if (cellValue < minValue) minValue = cellValue;
                }

                // Loop through each row in the DataGridView again
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    // Get the value of the cell in the current row and column
                    double cellValue = Convert.ToDouble(row.Cells[columnIndex].Value);

                    // Normalize the value and update the cell
                    double normalizedValue = (cellValue - minValue) / (maxValue - minValue);
                    row.Cells[columnIndex].Value = normalizedValue;
                }
            }
        }

        public void NormalizeColumns(DataGridView dgv, List<string> columnNames)
        {
            // Loop through each column name in the list
            foreach (string columnName in columnNames)
            {
                // Find the index of the column with the specified name
                int columnIndex = dgv.Columns[columnName].Index;

                // Loop through each row in the DataGridView
                double maxValue = double.MinValue;
                double minValue = double.MaxValue;
                bool isNumeric = true;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    // Get the value of the cell in the current row and column
                    object cellValue = row.Cells[columnIndex].Value;
                    if (cellValue != null)
                    {
                        // Check if the cell value is numeric
                        if (!double.TryParse(cellValue.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out double numericValue))
                        {
                            isNumeric = false;
                            break;
                        }
                        // Update the max and min values if necessary
                        if (numericValue > maxValue) maxValue = numericValue;
                        if (numericValue < minValue) minValue = numericValue;
                    }
                }

                // Skip normalization if the column contains non-numeric values
                if (!isNumeric)
                {
                    continue;
                }

                // Loop through each row in the DataGridView again
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    // Get the value of the cell in the current row and column
                    object cellValue = row.Cells[columnIndex].Value;
                    if (cellValue != null)
                    {
                        // Normalize the value and update the cell
                        double normalizedValue = (Convert.ToDouble(cellValue, CultureInfo.InvariantCulture) - minValue) / (maxValue - minValue);
                        row.Cells[columnIndex].Value = normalizedValue.ToString(CultureInfo.InvariantCulture);
                    }
                }
            }
        }


        public void SetFloatingPoingPrecision(DataGridView dgv, ProgressBar prgBar, NumericUpDown nmrUpDown)
        {
            try
            {

                // Initialize the progress bar
                prgBar.Minimum = 0;
                prgBar.Maximum = dgv.Rows.Count * dgv.Columns.Count;
                prgBar.Value = 0;



                int numDigits = (int)nmrUpDown.Value;


                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.GetType() == typeof(string))
                        {
                            string value = cell.Value.ToString();
                            int decimalPlaces = value.IndexOf('.') >= 0 ? value.Length - value.IndexOf('.') - 1 : 0;
                            if (decimalPlaces > numDigits)
                            {
                                //cell.Value= String.Format()

                                double roundedValue = Math.Round(double.Parse(value, CultureInfo.InvariantCulture), numDigits);
                                cell.Value = roundedValue.ToString($"F{numDigits}", CultureInfo.InvariantCulture);
                            }
                        }
                        else if (cell.Value != null && cell.Value.GetType() == typeof(double))
                        {
                            double value = (double)cell.Value;
                            double roundedValue = Math.Round(value, numDigits);
                            string roundedString = roundedValue.ToString($"F{numDigits}");
                            cell.Value = roundedString;

                        }

                        prgBar.Value++;
                    }




                    // Application.DoEvents();
                }

                dgv.Refresh();
                // Reset the progress bar
                prgBar.Value = 0;


            }
            catch
            {
                MessageBox.Show("Recheck your CSV format..");

            }


        }






    }
}
