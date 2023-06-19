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

namespace Thabab
{
    class PopulatingTools
    {
        // adding comboxes with unique values of datagridview to a panel

        public void comboxOfUniquevalues(DataGridView dgv, Panel pnl, BackgroundWorker bkgw)
        {

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
                    //MessageBox.Show(comboBox.Name);

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


                    // Report progress to the UI thread
                    int progressPercentage = (i + 1) * 100 / dgv.Columns.Count;
                    bkgw.ReportProgress(progressPercentage);
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



    }
}
