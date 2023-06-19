using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thabab
{
    public partial class frmCombinationPlots : Form
    {
        public frmCombinationPlots()
        {
            InitializeComponent();
        }



       
        private void addparirTOListview(string item1, string item2)

        {






        }




        private void frmCombinationPlots_Load(object sender, EventArgs e)
        {
            
           
            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)frmMain.Controls["dataGridView1"];

            var datasource = dataGridViewInstance.DataSource;
            dgvFilteredData.DataSource = datasource;


            // Set the View property to Details to show the pairs in tabular mode
            lstViewChosenCombination.View = View.Details;

            // Add the columns to the ListView
            lstViewChosenCombination.Columns.Add("Column", 100);
            lstViewChosenCombination.Columns.Add("Chosen Value", 100);

            // First, populate the CheckBoxList with the column names of the DataGridView.
            foreach (DataGridViewColumn column in dataGridViewInstance.Columns)
            {
                chkListColumns.Items.Add(column.Name);
            }

        }

        private void chkListColumns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkListColumns_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            // Set the progress bar minimum and maximum values
            //progressBar1.Minimum = 0;
           // progressBar1.Maximum = chkListColumns.Items.Count;
            //progressBar1.Visible = true;

            Form1 frmMain = (Form1)Application.OpenForms["Form1"];
            DataGridView dataGridViewInstance = (DataGridView)frmMain.Controls["dataGridView1"];




            if (e.NewValue == CheckState.Checked)
            {
                // Increment the progress bar value
                //progressBar1.Value++;

                // Get the selected column name from the checkedListBox
                string columnName = chkListColumns.Items[e.Index].ToString();

                // Get the unique values in the selected column of the dataGridView
                var uniqueValues = dataGridViewInstance.Rows
                    .Cast<DataGridViewRow>()
                    .Select(row => row.Cells[columnName].Value)
                    .Where(value => value != null)
                    .Distinct()
                    .ToList();

                // Create a new group box for the column
                var groupBox = new GroupBox();
                groupBox.Text = columnName;

                // update the the label that show the number of unique values
               // var lbluniqvalues = new Label();
              //  lbluniqvalues.Text = "Unique values #" + uniqueValues.Count.ToString();
                               

                // Create a new panel for the radio buttons
                var panel = new Panel();
                panel.Dock = DockStyle.Fill;
                panel.AutoScroll = true;
                
                groupBox.Height = panel1.Height;
                


                groupBox.Controls.Add(panel);

                // Set the location of the group box
                int groupBoxLeft = panel1.Controls.OfType<GroupBox>().Count() * (groupBox.Width + 10);
                groupBox.Location = new Point(groupBoxLeft, 20);

                panel1.Controls.Add(groupBox);

                // Add radio buttons for each unique value to the panel
                int top = 20;
                foreach (var value in uniqueValues)
                {
                    //progressBar1.Value++;

                    var radioButton = new RadioButton();
                    radioButton.Text = value.ToString();
                    radioButton.Top = top;
                    radioButton.Parent = panel;
                    panel.Controls.Add(radioButton);
                    top += 20;
                }

                // Set the group box as the container control for the radio buttons
                foreach (RadioButton radioButton in panel.Controls)
                {
                   // progressBar1.Value++;

                    radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
                }

                // Adjust the size of Panel1 to fit all the GroupBox controls
                int totalWidth = panel1.Controls.OfType<GroupBox>().Count() * (groupBox.Width + 10);
                panel1.AutoScrollMinSize = new Size(totalWidth, 0);

               // progressBar1.Value = progressBar1.Maximum;
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // Remove the group box for the column
                
                string columnName = chkListColumns.Items[e.Index].ToString();
                var groupBox = panel1.Controls.OfType<GroupBox>()
                    .FirstOrDefault(gb => gb.Text == columnName);
                if (groupBox != null)
                {
                    panel1.Controls.Remove(groupBox);
                    groupBox.Dispose(); // free up resources used by the GroupBox
                }

                // Rearrange the remaining group boxes
                int groupBoxLeft = 0;
                foreach (GroupBox gb in panel1.Controls.OfType<GroupBox>())
                {
                    gb.Left = groupBoxLeft;
                    groupBoxLeft += gb.Width + 10;
                }

                // Adjust the size of Panel1 to fit all the GroupBox controls
                int totalWidth = panel1.Controls.OfType<GroupBox>().Count() * (groupBox.Width + 10);
                panel1.AutoScrollMinSize = new Size(totalWidth, 0);
            }

            


        }





        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Handle radio button selection here
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                string selectedValue = radioButton.Text;
                // Do something with the selected value
                //var groupBox = radioButton.Parent as GroupBox;
                //var groupBoxText = groupBox.Text;
                var parName = radioButton.Parent;
                var thecontianername = parName.Parent;
                var groupBox = parName.Parent as GroupBox;

                if (groupBox != null)
                {
                    string groupBoxText = groupBox.Text;
                    // Use the groupBoxText variable as needed
                    addparirTOListview(groupBoxText, selectedValue);
                   //MessageBox.Show(selectedValue);
                }

                
                
            }
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dgvFilteredData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
