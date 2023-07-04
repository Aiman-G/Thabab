using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Globalization;

namespace Thabab
{
    class Ploting
    {




           




        public void PlotDataByCategory(DataGridView dgv, string ColGroup, string col1, string col2)
        {

            try
            {
                // Get unique categories from ColGroup column
                var categories = dgv.Rows.Cast<DataGridViewRow>()
                    .Select(r => r.Cells[ColGroup].Value?.ToString())
                    .Distinct();

                // Create a new window with a plot for each category
                var plotFormWindow = new Form();
                plotFormWindow.Text = "Plots by " + ColGroup;
                plotFormWindow.ClientSize = new System.Drawing.Size(800, 600);
                var plots = new List<PlotView>();
                foreach (var category in categories)
                {
                    // Filter the DataGridView to get rows in the current category
                    var rows = dgv.Rows.Cast<DataGridViewRow>()
                        .Where(r => r.Cells[ColGroup].Value?.ToString() == category);

                    // Create a new PlotModel for the current category
                    var model = new PlotModel();
                    model.Title = category;
                    // adding labels to x-axis and y-axis
                    model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Title = col1 });
                    model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Title = col2 });

                    // Create a new series for the current category
                    var series = new LineSeries();
                    series.Title = category;
                    
                    
                    //series.Color = OxyColor.FromRgb(24, 255, 255);

                    // Add data points to the series
                    foreach (var row in rows)
                    {
                        double x;
                        double y;

                        // Check if the values are valid doubles
                        if (double.TryParse(row.Cells[col1].Value?.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out x) &&
                            double.TryParse(row.Cells[col2].Value?.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out y))
                        {
                            series.Points.Add(new OxyPlot.DataPoint(x, y));
                        }
                    }

                    // Add the series to the PlotModel
                    model.Series.Add(series);

                    // Create a new PlotView for the current category
                    var plotForm = new PlotView();
                    plotForm.Dock = DockStyle.Fill;
                    plotForm.Model = model;

                    // Add the PlotView to the plots collection
                    plots.Add(plotForm);
                }

                // Create a tab control to display the plots
                var tabControl = new TabControl();
                tabControl.Font = new Font(tabControl.Font, FontStyle.Bold);




                tabControl.Dock = DockStyle.Fill;
                foreach (var plotForm in plots)
                {
                    if (plotForm.Model.Title != null) // to delete tha last tab that is empty
                    {

                        var tabPage = new TabPage(plotForm.Model.Title);
                        tabPage.BorderStyle = BorderStyle.Fixed3D;
                        //tabPage.BackColor = Color.Aqua;

                        tabPage.Controls.Add(plotForm);
                        tabControl.TabPages.Add(tabPage);
                    }
                }

                // Add the tab control to the form
                plotFormWindow.Controls.Add(tabControl);

                // Show the plotForm
                plotFormWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that are thrown by the function
                MessageBox.Show("Make sure your CSV file is in correct format, and choose plots according to your knowledge of your data: " + ex.Message);
            }
        }




        public void PlotTwoCol(DataGridView dataGridView, string xColName, string yColName)
        {
            // Get the indices of the x and y columns
            int xColIndex = dataGridView.Columns[xColName].Index;
            int yColIndex = dataGridView.Columns[yColName].Index;

            // Create a new chart object
            Chart chart = new Chart();

            // Set the chart properties
            chart.ChartAreas.Add(new ChartArea());
            chart.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series());

            // Loop through the rows of the DataGridView and add data points to the chart
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    double xVal = Convert.ToDouble(row.Cells[xColIndex].Value);
                    double yVal = Convert.ToDouble(row.Cells[yColIndex].Value);
                    chart.Series[0].Points.AddXY(xVal, yVal);
                }
            }

            // Create a new form to display the chart
            Form chartForm = new Form();
            chartForm.Text = "Plot";
            chartForm.Size = new Size(600, 400);

            // Create a new chart control and add it to the form
            Chart chartControl = new Chart();
            chartControl.Parent = chartForm;
            chartControl.Dock = DockStyle.Fill;

            // Add the chart to the chart control
            chartControl.ChartAreas.Add(chart.ChartAreas[0]);
            chartControl.Series.Add(chart.Series[0]);

            // Display the form
            chartForm.ShowDialog();
        }









    }
}
