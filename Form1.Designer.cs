
namespace Thabab
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleCSVsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuPlotCategorical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPlotCombinations = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveQuotes_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNullsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Normalize_tripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetFlaotingPoint_tripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1249, 499);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.plotToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.processingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1261, 33);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AutoToolTip = true;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCSVToolStripMenuItem,
            this.exportToCSVToolStripMenuItem,
            this.multipleCSVsToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::Thabab.Properties.Resources._3442848;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // loadCSVToolStripMenuItem
            // 
            this.loadCSVToolStripMenuItem.Image = global::Thabab.Properties.Resources.LoadCSV;
            this.loadCSVToolStripMenuItem.Name = "loadCSVToolStripMenuItem";
            this.loadCSVToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.loadCSVToolStripMenuItem.Text = "Load CSV..";
            this.loadCSVToolStripMenuItem.Click += new System.EventHandler(this.loadCSVToolStripMenuItem_Click);
            // 
            // exportToCSVToolStripMenuItem
            // 
            this.exportToCSVToolStripMenuItem.Image = global::Thabab.Properties.Resources.To_CSV;
            this.exportToCSVToolStripMenuItem.Name = "exportToCSVToolStripMenuItem";
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.exportToCSVToolStripMenuItem.Text = "Export to CSV";
            this.exportToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportToCSVToolStripMenuItem_Click);
            // 
            // multipleCSVsToolStripMenuItem
            // 
            this.multipleCSVsToolStripMenuItem.Image = global::Thabab.Properties.Resources.ManyCSVs;
            this.multipleCSVsToolStripMenuItem.Name = "multipleCSVsToolStripMenuItem";
            this.multipleCSVsToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.multipleCSVsToolStripMenuItem.Text = "Multiple CSVs..";
            this.multipleCSVsToolStripMenuItem.Click += new System.EventHandler(this.multipleCSVsToolStripMenuItem_Click);
            // 
            // plotToolStripMenuItem
            // 
            this.plotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuPlotCategorical,
            this.toolStripPlotCombinations});
            this.plotToolStripMenuItem.Image = global::Thabab.Properties.Resources.ploticon22;
            this.plotToolStripMenuItem.Name = "plotToolStripMenuItem";
            this.plotToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.plotToolStripMenuItem.Text = "Plot";
            this.plotToolStripMenuItem.Click += new System.EventHandler(this.plotToolStripMenuItem_Click);
            // 
            // toolStripMenuPlotCategorical
            // 
            this.toolStripMenuPlotCategorical.Image = global::Thabab.Properties.Resources.Plot_categories;
            this.toolStripMenuPlotCategorical.Name = "toolStripMenuPlotCategorical";
            this.toolStripMenuPlotCategorical.Size = new System.Drawing.Size(214, 26);
            this.toolStripMenuPlotCategorical.Text = "Plot Categorical ";
            this.toolStripMenuPlotCategorical.Click += new System.EventHandler(this.toolStripMenuPlotCategorical_Click);
            // 
            // toolStripPlotCombinations
            // 
            this.toolStripPlotCombinations.Image = global::Thabab.Properties.Resources.Plot_combinaion;
            this.toolStripPlotCombinations.Name = "toolStripPlotCombinations";
            this.toolStripPlotCombinations.Size = new System.Drawing.Size(214, 26);
            this.toolStripPlotCombinations.Text = "Plot Combinations";
            this.toolStripPlotCombinations.Click += new System.EventHandler(this.toolStripPlotCombinations_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Image = global::Thabab.Properties.Resources.filtering;
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.queryToolStripMenuItem.Text = "Query";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // processingToolStripMenuItem
            // 
            this.processingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveQuotes_StripMenuItem,
            this.removeNullsToolStripMenuItem,
            this.Normalize_tripMenuItem,
            this.SetFlaotingPoint_tripMenuItem});
            this.processingToolStripMenuItem.Image = global::Thabab.Properties.Resources.Processing;
            this.processingToolStripMenuItem.Name = "processingToolStripMenuItem";
            this.processingToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.processingToolStripMenuItem.Text = "Processing";
            this.processingToolStripMenuItem.Click += new System.EventHandler(this.processingToolStripMenuItem_Click);
            // 
            // RemoveQuotes_StripMenuItem
            // 
            this.RemoveQuotes_StripMenuItem.Image = global::Thabab.Properties.Resources.remove_quotes;
            this.RemoveQuotes_StripMenuItem.Name = "RemoveQuotes_StripMenuItem";
            this.RemoveQuotes_StripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.RemoveQuotes_StripMenuItem.Text = "Remove Quotes";
            this.RemoveQuotes_StripMenuItem.Click += new System.EventHandler(this.RemoveQuotes_StripMenuItem_Click);
            // 
            // removeNullsToolStripMenuItem
            // 
            this.removeNullsToolStripMenuItem.Image = global::Thabab.Properties.Resources.remove_nulls;
            this.removeNullsToolStripMenuItem.Name = "removeNullsToolStripMenuItem";
            this.removeNullsToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.removeNullsToolStripMenuItem.Text = "Remove Nulls";
            this.removeNullsToolStripMenuItem.Click += new System.EventHandler(this.removeNullsToolStripMenuItem_Click);
            // 
            // Normalize_tripMenuItem
            // 
            this.Normalize_tripMenuItem.Image = global::Thabab.Properties.Resources.Normalization_icon;
            this.Normalize_tripMenuItem.Name = "Normalize_tripMenuItem";
            this.Normalize_tripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.Normalize_tripMenuItem.Text = "Normalize ";
            this.Normalize_tripMenuItem.Click += new System.EventHandler(this.Normalize_tripMenuItem_Click);
            // 
            // SetFlaotingPoint_tripMenuItem
            // 
            this.SetFlaotingPoint_tripMenuItem.Image = global::Thabab.Properties.Resources.FloatingPointIcon;
            this.SetFlaotingPoint_tripMenuItem.Name = "SetFlaotingPoint_tripMenuItem";
            this.SetFlaotingPoint_tripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.SetFlaotingPoint_tripMenuItem.Text = "Floating Point";
            this.SetFlaotingPoint_tripMenuItem.Click += new System.EventHandler(this.SetFlaotingPoint_tripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 680);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1261, 26);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(111, 20);
            this.toolStripStatusLabel1.Text = "No of Records: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 706);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Thabab";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPlotCategorical;
        private System.Windows.Forms.ToolStripMenuItem toolStripPlotCombinations;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveQuotes_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNullsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem Normalize_tripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetFlaotingPoint_tripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleCSVsToolStripMenuItem;
    }
}

