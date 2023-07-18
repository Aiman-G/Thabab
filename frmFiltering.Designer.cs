
namespace Thabab
{
    partial class frmFiltering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltering));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnLoadUnfilterd = new System.Windows.Forms.Button();
            this.btnUniqueValues = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearSelections = new System.Windows.Forms.Button();
            this.dgvShowFilteredData = new System.Windows.Forms.DataGridView();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.btnShowSummary = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExportFiltredToMain = new System.Windows.Forms.Button();
            this.btnExportFilteredToCSV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowFilteredData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btnLoadUnfilterd);
            this.groupBox1.Controls.Add(this.btnUniqueValues);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnClearSelections);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 379);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query ";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnFilter.Location = new System.Drawing.Point(4, 106);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(194, 71);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Query";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.Location = new System.Drawing.Point(6, 340);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(623, 32);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // btnLoadUnfilterd
            // 
            this.btnLoadUnfilterd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnLoadUnfilterd.Location = new System.Drawing.Point(6, 274);
            this.btnLoadUnfilterd.Name = "btnLoadUnfilterd";
            this.btnLoadUnfilterd.Size = new System.Drawing.Size(194, 60);
            this.btnLoadUnfilterd.TabIndex = 5;
            this.btnLoadUnfilterd.Text = "Load Unfiltred Data";
            this.btnLoadUnfilterd.UseVisualStyleBackColor = true;
            this.btnLoadUnfilterd.Click += new System.EventHandler(this.btnLoadUnfilterd_Click);
            // 
            // btnUniqueValues
            // 
            this.btnUniqueValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnUniqueValues.Location = new System.Drawing.Point(4, 32);
            this.btnUniqueValues.Name = "btnUniqueValues";
            this.btnUniqueValues.Size = new System.Drawing.Size(196, 67);
            this.btnUniqueValues.TabIndex = 2;
            this.btnUniqueValues.Text = "Get Query Values";
            this.btnUniqueValues.UseVisualStyleBackColor = true;
            this.btnUniqueValues.Click += new System.EventHandler(this.btnUniqueValues_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(206, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 319);
            this.panel1.TabIndex = 1;
            // 
            // btnClearSelections
            // 
            this.btnClearSelections.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnClearSelections.Location = new System.Drawing.Point(6, 207);
            this.btnClearSelections.Name = "btnClearSelections";
            this.btnClearSelections.Size = new System.Drawing.Size(192, 61);
            this.btnClearSelections.TabIndex = 6;
            this.btnClearSelections.Text = "Clear Selection";
            this.btnClearSelections.UseVisualStyleBackColor = true;
            this.btnClearSelections.Click += new System.EventHandler(this.btnClearSelections_Click);
            // 
            // dgvShowFilteredData
            // 
            this.dgvShowFilteredData.AllowUserToAddRows = false;
            this.dgvShowFilteredData.AllowUserToDeleteRows = false;
            this.dgvShowFilteredData.AllowUserToOrderColumns = true;
            this.dgvShowFilteredData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowFilteredData.Location = new System.Drawing.Point(12, 407);
            this.dgvShowFilteredData.Name = "dgvShowFilteredData";
            this.dgvShowFilteredData.ReadOnly = true;
            this.dgvShowFilteredData.RowHeadersWidth = 51;
            this.dgvShowFilteredData.RowTemplate.Height = 27;
            this.dgvShowFilteredData.Size = new System.Drawing.Size(1371, 319);
            this.dgvShowFilteredData.TabIndex = 4;
            this.dgvShowFilteredData.DataSourceChanged += new System.EventHandler(this.dgvShowFilteredData_DataSourceChanged);
            this.dgvShowFilteredData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowFilteredData_CellContentClick);
            this.dgvShowFilteredData.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShowFilteredData_CellMouseDown);
            // 
            // dgvSummary
            // 
            this.dgvSummary.AllowUserToAddRows = false;
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Location = new System.Drawing.Point(30, 63);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.RowHeadersWidth = 51;
            this.dgvSummary.RowTemplate.Height = 27;
            this.dgvSummary.Size = new System.Drawing.Size(699, 309);
            this.dgvSummary.TabIndex = 7;
            // 
            // btnShowSummary
            // 
            this.btnShowSummary.Location = new System.Drawing.Point(30, 15);
            this.btnShowSummary.Name = "btnShowSummary";
            this.btnShowSummary.Size = new System.Drawing.Size(112, 42);
            this.btnShowSummary.TabIndex = 8;
            this.btnShowSummary.Text = "Show";
            this.btnShowSummary.UseVisualStyleBackColor = true;
            this.btnShowSummary.Click += new System.EventHandler(this.btnShowSummary_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowSummary);
            this.groupBox2.Controls.Add(this.dgvSummary);
            this.groupBox2.Location = new System.Drawing.Point(648, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 379);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Query Summary";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip2.Location = new System.Drawing.Point(0, 764);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1395, 26);
            this.statusStrip2.TabIndex = 11;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 20);
            this.toolStripStatusLabel1.Text = "Info";
            // 
            // btnExportFiltredToMain
            // 
            this.btnExportFiltredToMain.Location = new System.Drawing.Point(1196, 732);
            this.btnExportFiltredToMain.Name = "btnExportFiltredToMain";
            this.btnExportFiltredToMain.Size = new System.Drawing.Size(151, 29);
            this.btnExportFiltredToMain.TabIndex = 12;
            this.btnExportFiltredToMain.Text = "Export to main";
            this.btnExportFiltredToMain.UseVisualStyleBackColor = true;
            this.btnExportFiltredToMain.Click += new System.EventHandler(this.btnExportFiltredToMain_Click);
            // 
            // btnExportFilteredToCSV
            // 
            this.btnExportFilteredToCSV.Location = new System.Drawing.Point(1010, 732);
            this.btnExportFilteredToCSV.Name = "btnExportFilteredToCSV";
            this.btnExportFilteredToCSV.Size = new System.Drawing.Size(151, 29);
            this.btnExportFilteredToCSV.TabIndex = 12;
            this.btnExportFilteredToCSV.Text = "Export to CSV";
            this.btnExportFilteredToCSV.UseVisualStyleBackColor = true;
            this.btnExportFilteredToCSV.Click += new System.EventHandler(this.btnExportFilteredToCSV_Click);
            // 
            // frmFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 790);
            this.Controls.Add(this.btnExportFilteredToCSV);
            this.Controls.Add(this.btnExportFiltredToMain);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvShowFilteredData);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFiltering";
            this.Text = "Filtering";
            this.Load += new System.EventHandler(this.frmFiltering_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowFilteredData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadUnfilterd;
        private System.Windows.Forms.Button btnClearSelections;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnUniqueValues;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvShowFilteredData;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.Button btnShowSummary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnExportFiltredToMain;
        private System.Windows.Forms.Button btnExportFilteredToCSV;
    }
}