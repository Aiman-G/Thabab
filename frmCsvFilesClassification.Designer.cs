namespace Thabab
{
    partial class frmCsvFilesClassification
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
            this.btnGetClassfiedFiles = new System.Windows.Forms.Button();
            this.tableLayoutPanelClassifiedFiles = new System.Windows.Forms.TableLayoutPanel();
            this.dgvShowCSVFile = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatuslblRecordsNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusNoOfColumns = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExportToCSV = new System.Windows.Forms.Button();
            this.btnExportToMainWindow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCSVFile)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetClassfiedFiles
            // 
            this.btnGetClassfiedFiles.Location = new System.Drawing.Point(27, 24);
            this.btnGetClassfiedFiles.Name = "btnGetClassfiedFiles";
            this.btnGetClassfiedFiles.Size = new System.Drawing.Size(179, 38);
            this.btnGetClassfiedFiles.TabIndex = 2;
            this.btnGetClassfiedFiles.Text = "Get Classfied Files";
            this.btnGetClassfiedFiles.UseVisualStyleBackColor = true;
            this.btnGetClassfiedFiles.Click += new System.EventHandler(this.btnGetClassfiedFiles_Click);
            // 
            // tableLayoutPanelClassifiedFiles
            // 
            this.tableLayoutPanelClassifiedFiles.AutoScroll = true;
            this.tableLayoutPanelClassifiedFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelClassifiedFiles.ColumnCount = 1;
            this.tableLayoutPanelClassifiedFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelClassifiedFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelClassifiedFiles.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanelClassifiedFiles.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanelClassifiedFiles.Name = "tableLayoutPanelClassifiedFiles";
            this.tableLayoutPanelClassifiedFiles.RowCount = 4;
            this.tableLayoutPanelClassifiedFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelClassifiedFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelClassifiedFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelClassifiedFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelClassifiedFiles.Size = new System.Drawing.Size(1336, 303);
            this.tableLayoutPanelClassifiedFiles.TabIndex = 4;
            // 
            // dgvShowCSVFile
            // 
            this.dgvShowCSVFile.AllowUserToAddRows = false;
            this.dgvShowCSVFile.AllowUserToOrderColumns = true;
            this.dgvShowCSVFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowCSVFile.Location = new System.Drawing.Point(27, 440);
            this.dgvShowCSVFile.Name = "dgvShowCSVFile";
            this.dgvShowCSVFile.RowHeadersWidth = 51;
            this.dgvShowCSVFile.RowTemplate.Height = 24;
            this.dgvShowCSVFile.Size = new System.Drawing.Size(1361, 277);
            this.dgvShowCSVFile.TabIndex = 5;
            this.dgvShowCSVFile.DataSourceChanged += new System.EventHandler(this.dgvShowCSVFile_DataSourceChanged);
            this.dgvShowCSVFile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowCSVFile_CellContentClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1361, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatuslblRecordsNo,
            this.toolStripStatusNoOfColumns});
            this.statusStrip1.Location = new System.Drawing.Point(0, 771);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1426, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatuslblRecordsNo
            // 
            this.toolStripStatuslblRecordsNo.Name = "toolStripStatuslblRecordsNo";
            this.toolStripStatuslblRecordsNo.Size = new System.Drawing.Size(107, 20);
            this.toolStripStatuslblRecordsNo.Text = "No of Records:";
            // 
            // toolStripStatusNoOfColumns
            // 
            this.toolStripStatusNoOfColumns.Name = "toolStripStatusNoOfColumns";
            this.toolStripStatusNoOfColumns.Size = new System.Drawing.Size(92, 20);
            this.toolStripStatusNoOfColumns.Text = "No of Fields:";
            // 
            // btnExportToCSV
            // 
            this.btnExportToCSV.Location = new System.Drawing.Point(1109, 723);
            this.btnExportToCSV.Name = "btnExportToCSV";
            this.btnExportToCSV.Size = new System.Drawing.Size(112, 29);
            this.btnExportToCSV.TabIndex = 9;
            this.btnExportToCSV.Text = "Export to CSV";
            this.btnExportToCSV.UseVisualStyleBackColor = true;
            this.btnExportToCSV.Click += new System.EventHandler(this.btnExportToCSV_Click);
            // 
            // btnExportToMainWindow
            // 
            this.btnExportToMainWindow.Location = new System.Drawing.Point(1242, 723);
            this.btnExportToMainWindow.Name = "btnExportToMainWindow";
            this.btnExportToMainWindow.Size = new System.Drawing.Size(127, 29);
            this.btnExportToMainWindow.TabIndex = 10;
            this.btnExportToMainWindow.Text = "Export to Main";
            this.btnExportToMainWindow.UseVisualStyleBackColor = true;
            this.btnExportToMainWindow.Click += new System.EventHandler(this.btnExportToMainWindow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanelClassifiedFiles);
            this.groupBox1.Location = new System.Drawing.Point(27, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1361, 330);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files with exact columns";
            // 
            // frmCsvFilesClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 797);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExportToMainWindow);
            this.Controls.Add(this.btnExportToCSV);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dgvShowCSVFile);
            this.Controls.Add(this.btnGetClassfiedFiles);
            this.Name = "frmCsvFilesClassification";
            this.Text = "frmCsvFilesClassification";
            this.Load += new System.EventHandler(this.frmCsvFilesClassification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCSVFile)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetClassfiedFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelClassifiedFiles;
        private System.Windows.Forms.DataGridView dgvShowCSVFile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatuslblRecordsNo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusNoOfColumns;
        private System.Windows.Forms.Button btnExportToCSV;
        private System.Windows.Forms.Button btnExportToMainWindow;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}