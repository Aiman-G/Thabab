using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using MathNet.Numerics.Statistics;

namespace Thabab
{
    class DataSummarization
    {

        //SummarizeDataGridView
       

        public void SummarizeDataGridView(DataGridView source, DataGridView target)
        {
            // Clear the target grid
            target.Rows.Clear();
            target.Columns.Clear();

            // Add columns for summary information
            target.Columns.Add("Column", "Column");
            target.Columns.Add("Unique Values", "Unique Values");
            target.Columns.Add("Max", "Max");
            target.Columns.Add("Min", "Min");
            target.Columns.Add("Standard Deviation", "Standard Deviation");
            target.Columns.Add("Mean", "Mean");
            target.Columns.Add("Count", "Count");

            // Add a row for each column in the source grid
            for (int i = 0; i < source.Columns.Count; i++)
            {
                // Get the column name and data type
                string columnName = source.Columns[i].HeaderText;
                Type dataType = source.Columns[i].ValueType;

                // Calculate summary information for the column
                var uniqueValues = source.Rows.Cast<DataGridViewRow>()
                                    .Select(row => row.Cells[i].Value)
                                    .Where(value => value != null && value != DBNull.Value && !string.IsNullOrWhiteSpace(value.ToString()))
                                    .Distinct().Count();

                var numericValues = source.Rows.Cast<DataGridViewRow>()
                                    .Select(row => row.Cells[i].Value)
                                    .Where(value => value != null && value != DBNull.Value && !string.IsNullOrWhiteSpace(value.ToString()) && double.TryParse(value.ToString(), out _) )
                                    .Select(value => Convert.ToDouble(value));

                double max = double.NaN;
                double min = double.NaN;
                double stdDev = double.NaN;
                double mean = double.NaN;
                //int count = numericValues.Count();
                int count = source.RowCount;

                if (numericValues.Any())
                {
                    max = numericValues.Max();
                    min = numericValues.Min();
                    stdDev = numericValues.StandardDeviation();
                    mean = numericValues.Average();
                }

                // Add the summary information to the target grid
                target.Rows.Add(columnName, uniqueValues, max, min, stdDev, mean, count);
            }
        }



       






    }
}
