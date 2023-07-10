namespace Thabab
{
    partial class frmCompareFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvFirstFile = new System.Windows.Forms.DataGridView();
            this.file_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSecondFile = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControlComparison = new System.Windows.Forms.TabControl();
            this.tabColumns = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCommonColumns = new System.Windows.Forms.ListBox();
            this.listBoxDifferentColumns = new System.Windows.Forms.ListBox();
            this.groupBoxSecondFileCols = new System.Windows.Forms.GroupBox();
            this.lblSecondFileName = new System.Windows.Forms.Label();
            this.lsvSecondFile = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsvFirstFile = new System.Windows.Forms.ListView();
            this.lblFirstFileName = new System.Windows.Forms.Label();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.dgvSecondFileSummary = new System.Windows.Forms.DataGridView();
            this.dgvFirstFileSummary = new System.Windows.Forms.DataGridView();
            this.tabCharts = new System.Windows.Forms.TabPage();
            this.chartSecondFile = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFirstFile = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblFirstFileNameSummary = new System.Windows.Forms.Label();
            this.lblSecondFileNameSummary = new System.Windows.Forms.Label();
            this.lblFirstFileNameChart = new System.Windows.Forms.Label();
            this.lblSecondFileNameChart = new System.Windows.Forms.Label();
            this.btnRefreshColumnsInfo = new System.Windows.Forms.Button();
            this.btnRefreshSummary = new System.Windows.Forms.Button();
            this.btnRefreshChart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirstFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecondFile)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlComparison.SuspendLayout();
            this.tabColumns.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxSecondFileCols.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecondFileSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirstFileSummary)).BeginInit();
            this.tabCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSecondFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFirstFile)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFirstFile
            // 
            this.dgvFirstFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirstFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.file_name});
            this.dgvFirstFile.Location = new System.Drawing.Point(20, 21);
            this.dgvFirstFile.Name = "dgvFirstFile";
            this.dgvFirstFile.RowHeadersWidth = 51;
            this.dgvFirstFile.RowTemplate.Height = 24;
            this.dgvFirstFile.Size = new System.Drawing.Size(337, 232);
            this.dgvFirstFile.TabIndex = 0;
            this.dgvFirstFile.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFirstFile_CellClick);
            // 
            // file_name
            // 
            this.file_name.HeaderText = "File Name";
            this.file_name.MinimumWidth = 6;
            this.file_name.Name = "file_name";
            this.file_name.Width = 125;
            // 
            // dgvSecondFile
            // 
            this.dgvSecondFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecondFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvSecondFile.Location = new System.Drawing.Point(18, 21);
            this.dgvSecondFile.Name = "dgvSecondFile";
            this.dgvSecondFile.RowHeadersWidth = 51;
            this.dgvSecondFile.RowTemplate.Height = 24;
            this.dgvSecondFile.Size = new System.Drawing.Size(342, 222);
            this.dgvSecondFile.TabIndex = 0;
            this.dgvSecondFile.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecondFile_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "File Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(this.dgvFirstFile);
            this.groupBox1.Location = new System.Drawing.Point(58, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 259);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose First File";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox2.Controls.Add(this.dgvSecondFile);
            this.groupBox2.Location = new System.Drawing.Point(988, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 259);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Second File";
            // 
            // tabControlComparison
            // 
            this.tabControlComparison.Controls.Add(this.tabColumns);
            this.tabControlComparison.Controls.Add(this.tabSummary);
            this.tabControlComparison.Controls.Add(this.tabCharts);
            this.tabControlComparison.Location = new System.Drawing.Point(29, 327);
            this.tabControlComparison.Multiline = true;
            this.tabControlComparison.Name = "tabControlComparison";
            this.tabControlComparison.SelectedIndex = 0;
            this.tabControlComparison.Size = new System.Drawing.Size(1374, 368);
            this.tabControlComparison.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlComparison.TabIndex = 3;
            this.tabControlComparison.SelectedIndexChanged += new System.EventHandler(this.tabControlComparison_SelectedIndexChanged);
            this.tabControlComparison.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControlComparison_MouseClick);
            // 
            // tabColumns
            // 
            this.tabColumns.Controls.Add(this.btnRefreshColumnsInfo);
            this.tabColumns.Controls.Add(this.groupBox4);
            this.tabColumns.Controls.Add(this.groupBoxSecondFileCols);
            this.tabColumns.Controls.Add(this.groupBox3);
            this.tabColumns.Location = new System.Drawing.Point(4, 25);
            this.tabColumns.Name = "tabColumns";
            this.tabColumns.Padding = new System.Windows.Forms.Padding(3);
            this.tabColumns.Size = new System.Drawing.Size(1366, 339);
            this.tabColumns.TabIndex = 0;
            this.tabColumns.Text = "Columns";
            this.tabColumns.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.listBoxCommonColumns);
            this.groupBox4.Controls.Add(this.listBoxDifferentColumns);
            this.groupBox4.Location = new System.Drawing.Point(478, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 281);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Common & Difference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Difference";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Common";
            // 
            // listBoxCommonColumns
            // 
            this.listBoxCommonColumns.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxCommonColumns.FormattingEnabled = true;
            this.listBoxCommonColumns.HorizontalScrollbar = true;
            this.listBoxCommonColumns.ItemHeight = 16;
            this.listBoxCommonColumns.Location = new System.Drawing.Point(6, 43);
            this.listBoxCommonColumns.Name = "listBoxCommonColumns";
            this.listBoxCommonColumns.Size = new System.Drawing.Size(183, 212);
            this.listBoxCommonColumns.TabIndex = 1;
            // 
            // listBoxDifferentColumns
            // 
            this.listBoxDifferentColumns.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxDifferentColumns.FormattingEnabled = true;
            this.listBoxDifferentColumns.HorizontalScrollbar = true;
            this.listBoxDifferentColumns.ItemHeight = 16;
            this.listBoxDifferentColumns.Location = new System.Drawing.Point(218, 43);
            this.listBoxDifferentColumns.Name = "listBoxDifferentColumns";
            this.listBoxDifferentColumns.Size = new System.Drawing.Size(166, 212);
            this.listBoxDifferentColumns.TabIndex = 1;
            // 
            // groupBoxSecondFileCols
            // 
            this.groupBoxSecondFileCols.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBoxSecondFileCols.Controls.Add(this.lblSecondFileName);
            this.groupBoxSecondFileCols.Controls.Add(this.lsvSecondFile);
            this.groupBoxSecondFileCols.Location = new System.Drawing.Point(955, 51);
            this.groupBoxSecondFileCols.Name = "groupBoxSecondFileCols";
            this.groupBoxSecondFileCols.Size = new System.Drawing.Size(382, 281);
            this.groupBoxSecondFileCols.TabIndex = 3;
            this.groupBoxSecondFileCols.TabStop = false;
            this.groupBoxSecondFileCols.Text = "Columns";
            // 
            // lblSecondFileName
            // 
            this.lblSecondFileName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSecondFileName.AutoSize = true;
            this.lblSecondFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondFileName.Location = new System.Drawing.Point(77, 12);
            this.lblSecondFileName.Name = "lblSecondFileName";
            this.lblSecondFileName.Size = new System.Drawing.Size(41, 18);
            this.lblSecondFileName.TabIndex = 6;
            this.lblSecondFileName.Text = "File 2";
            // 
            // lsvSecondFile
            // 
            this.lsvSecondFile.HideSelection = false;
            this.lsvSecondFile.Location = new System.Drawing.Point(53, 33);
            this.lsvSecondFile.Name = "lsvSecondFile";
            this.lsvSecondFile.Size = new System.Drawing.Size(238, 222);
            this.lsvSecondFile.TabIndex = 0;
            this.lsvSecondFile.UseCompatibleStateImageBehavior = false;
            this.lsvSecondFile.View = System.Windows.Forms.View.Tile;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Tan;
            this.groupBox3.Controls.Add(this.lsvFirstFile);
            this.groupBox3.Controls.Add(this.lblFirstFileName);
            this.groupBox3.Location = new System.Drawing.Point(25, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 281);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Columns";
            // 
            // lsvFirstFile
            // 
            this.lsvFirstFile.HideSelection = false;
            this.lsvFirstFile.Location = new System.Drawing.Point(51, 33);
            this.lsvFirstFile.Name = "lsvFirstFile";
            this.lsvFirstFile.Size = new System.Drawing.Size(253, 222);
            this.lsvFirstFile.TabIndex = 0;
            this.lsvFirstFile.UseCompatibleStateImageBehavior = false;
            this.lsvFirstFile.View = System.Windows.Forms.View.Tile;
            // 
            // lblFirstFileName
            // 
            this.lblFirstFileName.AutoSize = true;
            this.lblFirstFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstFileName.Location = new System.Drawing.Point(75, 12);
            this.lblFirstFileName.Name = "lblFirstFileName";
            this.lblFirstFileName.Size = new System.Drawing.Size(41, 18);
            this.lblFirstFileName.TabIndex = 6;
            this.lblFirstFileName.Text = "File 1";
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.btnRefreshSummary);
            this.tabSummary.Controls.Add(this.lblSecondFileNameSummary);
            this.tabSummary.Controls.Add(this.lblFirstFileNameSummary);
            this.tabSummary.Controls.Add(this.dgvSecondFileSummary);
            this.tabSummary.Controls.Add(this.dgvFirstFileSummary);
            this.tabSummary.Location = new System.Drawing.Point(4, 25);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(1366, 339);
            this.tabSummary.TabIndex = 1;
            this.tabSummary.Text = "Summary ";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // dgvSecondFileSummary
            // 
            this.dgvSecondFileSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecondFileSummary.Location = new System.Drawing.Point(721, 66);
            this.dgvSecondFileSummary.Name = "dgvSecondFileSummary";
            this.dgvSecondFileSummary.RowHeadersWidth = 51;
            this.dgvSecondFileSummary.RowTemplate.Height = 24;
            this.dgvSecondFileSummary.Size = new System.Drawing.Size(616, 263);
            this.dgvSecondFileSummary.TabIndex = 0;
            // 
            // dgvFirstFileSummary
            // 
            this.dgvFirstFileSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirstFileSummary.Location = new System.Drawing.Point(25, 66);
            this.dgvFirstFileSummary.Name = "dgvFirstFileSummary";
            this.dgvFirstFileSummary.RowHeadersWidth = 51;
            this.dgvFirstFileSummary.RowTemplate.Height = 24;
            this.dgvFirstFileSummary.Size = new System.Drawing.Size(575, 263);
            this.dgvFirstFileSummary.TabIndex = 0;
            // 
            // tabCharts
            // 
            this.tabCharts.Controls.Add(this.btnRefreshChart);
            this.tabCharts.Controls.Add(this.lblSecondFileNameChart);
            this.tabCharts.Controls.Add(this.lblFirstFileNameChart);
            this.tabCharts.Controls.Add(this.chartSecondFile);
            this.tabCharts.Controls.Add(this.chartFirstFile);
            this.tabCharts.Location = new System.Drawing.Point(4, 25);
            this.tabCharts.Name = "tabCharts";
            this.tabCharts.Size = new System.Drawing.Size(1366, 339);
            this.tabCharts.TabIndex = 2;
            this.tabCharts.Text = "Charts";
            this.tabCharts.UseVisualStyleBackColor = true;
            // 
            // chartSecondFile
            // 
            chartArea9.Name = "ChartArea1";
            this.chartSecondFile.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartSecondFile.Legends.Add(legend9);
            this.chartSecondFile.Location = new System.Drawing.Point(818, 36);
            this.chartSecondFile.Name = "chartSecondFile";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartSecondFile.Series.Add(series9);
            this.chartSecondFile.Size = new System.Drawing.Size(480, 300);
            this.chartSecondFile.TabIndex = 1;
            this.chartSecondFile.Text = "chart2";
            // 
            // chartFirstFile
            // 
            chartArea10.Name = "ChartArea1";
            this.chartFirstFile.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartFirstFile.Legends.Add(legend10);
            this.chartFirstFile.Location = new System.Drawing.Point(45, 36);
            this.chartFirstFile.Name = "chartFirstFile";
            this.chartFirstFile.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartFirstFile.Series.Add(series10);
            this.chartFirstFile.Size = new System.Drawing.Size(458, 300);
            this.chartFirstFile.TabIndex = 0;
            this.chartFirstFile.Text = "chart1";
            // 
            // lblFirstFileNameSummary
            // 
            this.lblFirstFileNameSummary.AutoSize = true;
            this.lblFirstFileNameSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstFileNameSummary.Location = new System.Drawing.Point(170, 32);
            this.lblFirstFileNameSummary.Name = "lblFirstFileNameSummary";
            this.lblFirstFileNameSummary.Size = new System.Drawing.Size(78, 18);
            this.lblFirstFileNameSummary.TabIndex = 7;
            this.lblFirstFileNameSummary.Text = "File 1 name";
            // 
            // lblSecondFileNameSummary
            // 
            this.lblSecondFileNameSummary.AutoSize = true;
            this.lblSecondFileNameSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondFileNameSummary.Location = new System.Drawing.Point(854, 32);
            this.lblSecondFileNameSummary.Name = "lblSecondFileNameSummary";
            this.lblSecondFileNameSummary.Size = new System.Drawing.Size(78, 18);
            this.lblSecondFileNameSummary.TabIndex = 7;
            this.lblSecondFileNameSummary.Text = "File 2 name";
            // 
            // lblFirstFileNameChart
            // 
            this.lblFirstFileNameChart.AutoSize = true;
            this.lblFirstFileNameChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstFileNameChart.Location = new System.Drawing.Point(93, 15);
            this.lblFirstFileNameChart.Name = "lblFirstFileNameChart";
            this.lblFirstFileNameChart.Size = new System.Drawing.Size(78, 18);
            this.lblFirstFileNameChart.TabIndex = 7;
            this.lblFirstFileNameChart.Text = "File 1 name";
            // 
            // lblSecondFileNameChart
            // 
            this.lblSecondFileNameChart.AutoSize = true;
            this.lblSecondFileNameChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondFileNameChart.Location = new System.Drawing.Point(855, 15);
            this.lblSecondFileNameChart.Name = "lblSecondFileNameChart";
            this.lblSecondFileNameChart.Size = new System.Drawing.Size(78, 18);
            this.lblSecondFileNameChart.TabIndex = 7;
            this.lblSecondFileNameChart.Text = "File 2 name";
            // 
            // btnRefreshColumnsInfo
            // 
            this.btnRefreshColumnsInfo.Location = new System.Drawing.Point(630, 6);
            this.btnRefreshColumnsInfo.Name = "btnRefreshColumnsInfo";
            this.btnRefreshColumnsInfo.Size = new System.Drawing.Size(107, 39);
            this.btnRefreshColumnsInfo.TabIndex = 5;
            this.btnRefreshColumnsInfo.Text = "Refresh";
            this.btnRefreshColumnsInfo.UseVisualStyleBackColor = true;
            this.btnRefreshColumnsInfo.Click += new System.EventHandler(this.btnRefreshColumnsInfo_Click);
            // 
            // btnRefreshSummary
            // 
            this.btnRefreshSummary.Location = new System.Drawing.Point(616, 6);
            this.btnRefreshSummary.Name = "btnRefreshSummary";
            this.btnRefreshSummary.Size = new System.Drawing.Size(107, 43);
            this.btnRefreshSummary.TabIndex = 8;
            this.btnRefreshSummary.Text = "Refresh";
            this.btnRefreshSummary.UseVisualStyleBackColor = true;
            this.btnRefreshSummary.Click += new System.EventHandler(this.btnRefreshSummary_Click);
            // 
            // btnRefreshChart
            // 
            this.btnRefreshChart.Location = new System.Drawing.Point(610, 6);
            this.btnRefreshChart.Name = "btnRefreshChart";
            this.btnRefreshChart.Size = new System.Drawing.Size(97, 35);
            this.btnRefreshChart.TabIndex = 8;
            this.btnRefreshChart.Text = "Refresh";
            this.btnRefreshChart.UseVisualStyleBackColor = true;
            this.btnRefreshChart.Click += new System.EventHandler(this.btnRefreshChart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 694);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1414, 30);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // frmCompareFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 726);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControlComparison);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCompareFiles";
            this.Text = "Compare Files Side by Side";
            this.Load += new System.EventHandler(this.frmCompareFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirstFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecondFile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControlComparison.ResumeLayout(false);
            this.tabColumns.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxSecondFileCols.ResumeLayout(false);
            this.groupBoxSecondFileCols.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabSummary.ResumeLayout(false);
            this.tabSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecondFileSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirstFileSummary)).EndInit();
            this.tabCharts.ResumeLayout(false);
            this.tabCharts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSecondFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFirstFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFirstFile;
        private System.Windows.Forms.DataGridView dgvSecondFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn file_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControlComparison;
        private System.Windows.Forms.TabPage tabColumns;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.TabPage tabCharts;
        private System.Windows.Forms.ListView lsvSecondFile;
        private System.Windows.Forms.ListView lsvFirstFile;
        private System.Windows.Forms.ListBox listBoxDifferentColumns;
        private System.Windows.Forms.ListBox listBoxCommonColumns;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBoxSecondFileCols;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSecondFileName;
        private System.Windows.Forms.Label lblFirstFileName;
        private System.Windows.Forms.DataGridView dgvSecondFileSummary;
        private System.Windows.Forms.DataGridView dgvFirstFileSummary;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSecondFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFirstFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSecondFileNameSummary;
        private System.Windows.Forms.Label lblFirstFileNameSummary;
        private System.Windows.Forms.Label lblSecondFileNameChart;
        private System.Windows.Forms.Label lblFirstFileNameChart;
        private System.Windows.Forms.Button btnRefreshColumnsInfo;
        private System.Windows.Forms.Button btnRefreshSummary;
        private System.Windows.Forms.Button btnRefreshChart;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}