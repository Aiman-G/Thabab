namespace Thabab
{
    partial class frmMultiCsvFiles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMultiCsvFiles));
            this.lsvFileNames = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFilesNumber = new System.Windows.Forms.Label();
            this.dgvShowSelected = new System.Windows.Forms.DataGridView();
            this.checkedListBoxColumns = new System.Windows.Forms.CheckedListBox();
            this.btnFilterFileNames = new System.Windows.Forms.Button();
            this.groupBoxColDistmictValues = new System.Windows.Forms.GroupBox();
            this.btnResetFiltering = new System.Windows.Forms.Button();
            this.lblFileNumberOfCatcols = new System.Windows.Forms.Label();
            this.progressBarCatCols = new System.Windows.Forms.ProgressBar();
            this.lsvFilterdByCatCols = new System.Windows.Forms.ListView();
            this.btnFilterByCatCols = new System.Windows.Forms.Button();
            this.panelColDistmictValues = new System.Windows.Forms.Panel();
            this.txtCatCols = new System.Windows.Forms.TextBox();
            this.groupBoxCombinationCols = new System.Windows.Forms.GroupBox();
            this.btnUniqueColumnNames = new System.Windows.Forms.Button();
            this.btnDistinctValuesAcrossFiles = new System.Windows.Forms.Button();
            this.lblNoOfRecords = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExportToMain = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnUpladCSVs = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnMatchandConcat = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnSideBySide = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnHome = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSelected)).BeginInit();
            this.groupBoxColDistmictValues.SuspendLayout();
            this.panelColDistmictValues.SuspendLayout();
            this.groupBoxCombinationCols.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvFileNames
            // 
            this.lsvFileNames.HideSelection = false;
            this.lsvFileNames.Location = new System.Drawing.Point(312, 53);
            this.lsvFileNames.Name = "lsvFileNames";
            this.lsvFileNames.Size = new System.Drawing.Size(259, 327);
            this.lsvFileNames.TabIndex = 3;
            this.lsvFileNames.UseCompatibleStateImageBehavior = false;
            this.lsvFileNames.View = System.Windows.Forms.View.Tile;
            this.lsvFileNames.SelectedIndexChanged += new System.EventHandler(this.lsvFileNames_SelectedIndexChanged);
            this.lsvFileNames.DoubleClick += new System.EventHandler(this.lsvFileNames_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter by Flies Columns";
            // 
            // lblFilesNumber
            // 
            this.lblFilesNumber.AutoSize = true;
            this.lblFilesNumber.Location = new System.Drawing.Point(309, 383);
            this.lblFilesNumber.Name = "lblFilesNumber";
            this.lblFilesNumber.Size = new System.Drawing.Size(77, 16);
            this.lblFilesNumber.TabIndex = 5;
            this.lblFilesNumber.Text = "No of Files: ";
            // 
            // dgvShowSelected
            // 
            this.dgvShowSelected.AllowUserToAddRows = false;
            this.dgvShowSelected.AllowUserToOrderColumns = true;
            this.dgvShowSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvShowSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowSelected.Location = new System.Drawing.Point(12, 525);
            this.dgvShowSelected.Name = "dgvShowSelected";
            this.dgvShowSelected.RowHeadersWidth = 51;
            this.dgvShowSelected.RowTemplate.Height = 24;
            this.dgvShowSelected.Size = new System.Drawing.Size(1543, 302);
            this.dgvShowSelected.TabIndex = 6;
            this.dgvShowSelected.DataSourceChanged += new System.EventHandler(this.dgvShowSelected_DataSourceChanged);
            // 
            // checkedListBoxColumns
            // 
            this.checkedListBoxColumns.FormattingEnabled = true;
            this.checkedListBoxColumns.Location = new System.Drawing.Point(10, 53);
            this.checkedListBoxColumns.Name = "checkedListBoxColumns";
            this.checkedListBoxColumns.Size = new System.Drawing.Size(188, 327);
            this.checkedListBoxColumns.TabIndex = 7;
            // 
            // btnFilterFileNames
            // 
            this.btnFilterFileNames.Location = new System.Drawing.Point(212, 238);
            this.btnFilterFileNames.Name = "btnFilterFileNames";
            this.btnFilterFileNames.Size = new System.Drawing.Size(94, 41);
            this.btnFilterFileNames.TabIndex = 9;
            this.btnFilterFileNames.Text = "Filter >>";
            this.btnFilterFileNames.UseVisualStyleBackColor = true;
            this.btnFilterFileNames.Click += new System.EventHandler(this.btnFilterFileNames_Click);
            // 
            // groupBoxColDistmictValues
            // 
            this.groupBoxColDistmictValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxColDistmictValues.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxColDistmictValues.Controls.Add(this.btnResetFiltering);
            this.groupBoxColDistmictValues.Controls.Add(this.lblFileNumberOfCatcols);
            this.groupBoxColDistmictValues.Controls.Add(this.progressBarCatCols);
            this.groupBoxColDistmictValues.Controls.Add(this.lsvFilterdByCatCols);
            this.groupBoxColDistmictValues.Controls.Add(this.btnFilterByCatCols);
            this.groupBoxColDistmictValues.Controls.Add(this.panelColDistmictValues);
            this.groupBoxColDistmictValues.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxColDistmictValues.Location = new System.Drawing.Point(738, 85);
            this.groupBoxColDistmictValues.Name = "groupBoxColDistmictValues";
            this.groupBoxColDistmictValues.Size = new System.Drawing.Size(817, 420);
            this.groupBoxColDistmictValues.TabIndex = 11;
            this.groupBoxColDistmictValues.TabStop = false;
            this.groupBoxColDistmictValues.Text = "Distnict Values of Categorical Vairables Across Files";
            // 
            // btnResetFiltering
            // 
            this.btnResetFiltering.Location = new System.Drawing.Point(461, 243);
            this.btnResetFiltering.Name = "btnResetFiltering";
            this.btnResetFiltering.Size = new System.Drawing.Size(92, 36);
            this.btnResetFiltering.TabIndex = 16;
            this.btnResetFiltering.Text = "Reset >>";
            this.btnResetFiltering.UseVisualStyleBackColor = true;
            this.btnResetFiltering.Click += new System.EventHandler(this.btnResetFiltering_Click);
            // 
            // lblFileNumberOfCatcols
            // 
            this.lblFileNumberOfCatcols.AutoSize = true;
            this.lblFileNumberOfCatcols.Location = new System.Drawing.Point(551, 365);
            this.lblFileNumberOfCatcols.Name = "lblFileNumberOfCatcols";
            this.lblFileNumberOfCatcols.Size = new System.Drawing.Size(77, 16);
            this.lblFileNumberOfCatcols.TabIndex = 15;
            this.lblFileNumberOfCatcols.Text = "No of Files: ";
            // 
            // progressBarCatCols
            // 
            this.progressBarCatCols.Location = new System.Drawing.Point(0, 397);
            this.progressBarCatCols.Name = "progressBarCatCols";
            this.progressBarCatCols.Size = new System.Drawing.Size(817, 23);
            this.progressBarCatCols.TabIndex = 14;
            this.progressBarCatCols.Visible = false;
            // 
            // lsvFilterdByCatCols
            // 
            this.lsvFilterdByCatCols.HideSelection = false;
            this.lsvFilterdByCatCols.Location = new System.Drawing.Point(554, 16);
            this.lsvFilterdByCatCols.Name = "lsvFilterdByCatCols";
            this.lsvFilterdByCatCols.Size = new System.Drawing.Size(248, 346);
            this.lsvFilterdByCatCols.TabIndex = 13;
            this.lsvFilterdByCatCols.UseCompatibleStateImageBehavior = false;
            this.lsvFilterdByCatCols.View = System.Windows.Forms.View.Tile;
            this.lsvFilterdByCatCols.DoubleClick += new System.EventHandler(this.lsvFilterdByCatCols_DoubleClick);
            // 
            // btnFilterByCatCols
            // 
            this.btnFilterByCatCols.Location = new System.Drawing.Point(461, 95);
            this.btnFilterByCatCols.Name = "btnFilterByCatCols";
            this.btnFilterByCatCols.Size = new System.Drawing.Size(87, 41);
            this.btnFilterByCatCols.TabIndex = 12;
            this.btnFilterByCatCols.Text = "Filter >>";
            this.btnFilterByCatCols.UseVisualStyleBackColor = true;
            this.btnFilterByCatCols.Click += new System.EventHandler(this.btnFilterByCatCols_Click);
            // 
            // panelColDistmictValues
            // 
            this.panelColDistmictValues.AutoScroll = true;
            this.panelColDistmictValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColDistmictValues.Controls.Add(this.txtCatCols);
            this.panelColDistmictValues.Location = new System.Drawing.Point(39, 37);
            this.panelColDistmictValues.Name = "panelColDistmictValues";
            this.panelColDistmictValues.Size = new System.Drawing.Size(416, 327);
            this.panelColDistmictValues.TabIndex = 0;
            // 
            // txtCatCols
            // 
            this.txtCatCols.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtCatCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatCols.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCatCols.Location = new System.Drawing.Point(36, 33);
            this.txtCatCols.Multiline = true;
            this.txtCatCols.Name = "txtCatCols";
            this.txtCatCols.ReadOnly = true;
            this.txtCatCols.Size = new System.Drawing.Size(354, 268);
            this.txtCatCols.TabIndex = 1;
            this.txtCatCols.Text = resources.GetString("txtCatCols.Text");
            this.txtCatCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCatCols.Visible = false;
            // 
            // groupBoxCombinationCols
            // 
            this.groupBoxCombinationCols.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxCombinationCols.Controls.Add(this.btnUniqueColumnNames);
            this.groupBoxCombinationCols.Controls.Add(this.lsvFileNames);
            this.groupBoxCombinationCols.Controls.Add(this.btnFilterFileNames);
            this.groupBoxCombinationCols.Controls.Add(this.checkedListBoxColumns);
            this.groupBoxCombinationCols.Controls.Add(this.label2);
            this.groupBoxCombinationCols.Controls.Add(this.lblFilesNumber);
            this.groupBoxCombinationCols.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxCombinationCols.Location = new System.Drawing.Point(12, 85);
            this.groupBoxCombinationCols.Name = "groupBoxCombinationCols";
            this.groupBoxCombinationCols.Size = new System.Drawing.Size(625, 420);
            this.groupBoxCombinationCols.TabIndex = 12;
            this.groupBoxCombinationCols.TabStop = false;
            this.groupBoxCombinationCols.Text = "Uploaded Files";
            // 
            // btnUniqueColumnNames
            // 
            this.btnUniqueColumnNames.Location = new System.Drawing.Point(212, 88);
            this.btnUniqueColumnNames.Name = "btnUniqueColumnNames";
            this.btnUniqueColumnNames.Size = new System.Drawing.Size(94, 56);
            this.btnUniqueColumnNames.TabIndex = 11;
            this.btnUniqueColumnNames.Text = "<< Unique Cols.";
            this.btnUniqueColumnNames.UseVisualStyleBackColor = true;
            this.btnUniqueColumnNames.Click += new System.EventHandler(this.btnUniqueColumnNames_Click);
            // 
            // btnDistinctValuesAcrossFiles
            // 
            this.btnDistinctValuesAcrossFiles.Location = new System.Drawing.Point(643, 173);
            this.btnDistinctValuesAcrossFiles.Name = "btnDistinctValuesAcrossFiles";
            this.btnDistinctValuesAcrossFiles.Size = new System.Drawing.Size(89, 55);
            this.btnDistinctValuesAcrossFiles.TabIndex = 13;
            this.btnDistinctValuesAcrossFiles.Text = "Cat. Cols >>";
            this.btnDistinctValuesAcrossFiles.UseVisualStyleBackColor = true;
            this.btnDistinctValuesAcrossFiles.Click += new System.EventHandler(this.btnDistinctValuesAcrossFiles_Click);
            // 
            // lblNoOfRecords
            // 
            this.lblNoOfRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNoOfRecords.AutoSize = true;
            this.lblNoOfRecords.Location = new System.Drawing.Point(12, 834);
            this.lblNoOfRecords.Name = "lblNoOfRecords";
            this.lblNoOfRecords.Size = new System.Drawing.Size(97, 16);
            this.lblNoOfRecords.TabIndex = 14;
            this.lblNoOfRecords.Text = "No of Records:";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.DarkOrange;
            // 
            // btnExportToMain
            // 
            this.btnExportToMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToMain.Location = new System.Drawing.Point(1396, 833);
            this.btnExportToMain.Name = "btnExportToMain";
            this.btnExportToMain.Size = new System.Drawing.Size(159, 30);
            this.btnExportToMain.TabIndex = 16;
            this.btnExportToMain.Text = "Export to Main";
            this.btnExportToMain.UseVisualStyleBackColor = true;
            this.btnExportToMain.Click += new System.EventHandler(this.btnExportToMain_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 872);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1584, 32);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(1540, 24);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnUpladCSVs,
            this.toolStripBtnMatchandConcat,
            this.toolStripbtnSideBySide,
            this.toolStripBtnHome});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1584, 37);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "Operations";
            // 
            // toolStripBtnUpladCSVs
            // 
            this.toolStripBtnUpladCSVs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnUpladCSVs.Image")));
            this.toolStripBtnUpladCSVs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUpladCSVs.Name = "toolStripBtnUpladCSVs";
            this.toolStripBtnUpladCSVs.Size = new System.Drawing.Size(133, 34);
            this.toolStripBtnUpladCSVs.Text = "Upload CSVs";
            this.toolStripBtnUpladCSVs.Click += new System.EventHandler(this.toolStripBtnUpladCSVs_Click);
            // 
            // toolStripBtnMatchandConcat
            // 
            this.toolStripBtnMatchandConcat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnMatchandConcat.Image")));
            this.toolStripBtnMatchandConcat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMatchandConcat.Name = "toolStripBtnMatchandConcat";
            this.toolStripBtnMatchandConcat.Size = new System.Drawing.Size(165, 34);
            this.toolStripBtnMatchandConcat.Text = "Match and Merge";
            this.toolStripBtnMatchandConcat.Click += new System.EventHandler(this.toolStripBtnMatchandConcat_Click);
            // 
            // toolStripbtnSideBySide
            // 
            this.toolStripbtnSideBySide.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnSideBySide.Image")));
            this.toolStripbtnSideBySide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnSideBySide.Name = "toolStripbtnSideBySide";
            this.toolStripbtnSideBySide.Size = new System.Drawing.Size(109, 34);
            this.toolStripbtnSideBySide.Text = "Compare";
            this.toolStripbtnSideBySide.ToolTipText = "Compare files side by side";
            this.toolStripbtnSideBySide.Click += new System.EventHandler(this.toolStripbtnSideBySide_Click);
            // 
            // toolStripBtnHome
            // 
            this.toolStripBtnHome.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnHome.Image")));
            this.toolStripBtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnHome.Name = "toolStripBtnHome";
            this.toolStripBtnHome.Size = new System.Drawing.Size(89, 34);
            this.toolStripBtnHome.Text = "Home";
            this.toolStripBtnHome.ToolTipText = "Show the main window";
            this.toolStripBtnHome.Click += new System.EventHandler(this.toolStripBtnHome_Click);
            // 
            // frmMultiCsvFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 904);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExportToMain);
            this.Controls.Add(this.lblNoOfRecords);
            this.Controls.Add(this.btnDistinctValuesAcrossFiles);
            this.Controls.Add(this.groupBoxCombinationCols);
            this.Controls.Add(this.groupBoxColDistmictValues);
            this.Controls.Add(this.dgvShowSelected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMultiCsvFiles";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Exploring Multiple CSV Files";
            this.Load += new System.EventHandler(this.frmMultiCsvFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSelected)).EndInit();
            this.groupBoxColDistmictValues.ResumeLayout(false);
            this.groupBoxColDistmictValues.PerformLayout();
            this.panelColDistmictValues.ResumeLayout(false);
            this.panelColDistmictValues.PerformLayout();
            this.groupBoxCombinationCols.ResumeLayout(false);
            this.groupBoxCombinationCols.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvFileNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFilesNumber;
        private System.Windows.Forms.DataGridView dgvShowSelected;
        private System.Windows.Forms.CheckedListBox checkedListBoxColumns;
        private System.Windows.Forms.Button btnFilterFileNames;
        private System.Windows.Forms.GroupBox groupBoxColDistmictValues;
        private System.Windows.Forms.Panel panelColDistmictValues;
        private System.Windows.Forms.Button btnFilterByCatCols;
        private System.Windows.Forms.ListView lsvFilterdByCatCols;
        private System.Windows.Forms.GroupBox groupBoxCombinationCols;
        private System.Windows.Forms.Button btnDistinctValuesAcrossFiles;
        private System.Windows.Forms.TextBox txtCatCols;
        private System.Windows.Forms.ProgressBar progressBarCatCols;
        private System.Windows.Forms.Label lblFileNumberOfCatcols;
        private System.Windows.Forms.Label lblNoOfRecords;
        private System.Windows.Forms.Button btnUniqueColumnNames;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnResetFiltering;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnExportToMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnUpladCSVs;
        private System.Windows.Forms.ToolStripButton toolStripBtnMatchandConcat;
        private System.Windows.Forms.ToolStripButton toolStripbtnSideBySide;
        private System.Windows.Forms.ToolStripButton toolStripBtnHome;
    }
}