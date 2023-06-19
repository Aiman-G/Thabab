
namespace Thabab
{
    partial class frmCmbPlots
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
            this.dgvShowFilteredData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadUnfilterd = new System.Windows.Forms.Button();
            this.btnClearSelections = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnUniqueValues = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_cat_var = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlotFilterd = new System.Windows.Forms.Button();
            this.cmb_y_col = new System.Windows.Forms.ComboBox();
            this.cmb_x_col = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowFilteredData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowFilteredData
            // 
            this.dgvShowFilteredData.AllowUserToAddRows = false;
            this.dgvShowFilteredData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowFilteredData.Location = new System.Drawing.Point(12, 366);
            this.dgvShowFilteredData.Name = "dgvShowFilteredData";
            this.dgvShowFilteredData.ReadOnly = true;
            this.dgvShowFilteredData.RowHeadersWidth = 51;
            this.dgvShowFilteredData.RowTemplate.Height = 27;
            this.dgvShowFilteredData.Size = new System.Drawing.Size(1000, 305);
            this.dgvShowFilteredData.TabIndex = 0;
            this.dgvShowFilteredData.DataSourceChanged += new System.EventHandler(this.dgvShowFilteredData_DataSourceChanged);
            this.dgvShowFilteredData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowFilteredData_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(6, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 221);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadUnfilterd);
            this.groupBox1.Controls.Add(this.btnClearSelections);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.btnUniqueValues);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 333);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1- Obtain Unique Values";
            // 
            // btnLoadUnfilterd
            // 
            this.btnLoadUnfilterd.Location = new System.Drawing.Point(414, 230);
            this.btnLoadUnfilterd.Name = "btnLoadUnfilterd";
            this.btnLoadUnfilterd.Size = new System.Drawing.Size(194, 54);
            this.btnLoadUnfilterd.TabIndex = 5;
            this.btnLoadUnfilterd.Text = "Load Unfiltred Data";
            this.btnLoadUnfilterd.UseVisualStyleBackColor = true;
            this.btnLoadUnfilterd.Click += new System.EventHandler(this.btnLoadUnfilterd_Click);
            // 
            // btnClearSelections
            // 
            this.btnClearSelections.Location = new System.Drawing.Point(414, 178);
            this.btnClearSelections.Name = "btnClearSelections";
            this.btnClearSelections.Size = new System.Drawing.Size(194, 46);
            this.btnClearSelections.TabIndex = 6;
            this.btnClearSelections.Text = "Clear Selection";
            this.btnClearSelections.UseVisualStyleBackColor = true;
            this.btnClearSelections.Click += new System.EventHandler(this.btnClearSelections_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 297);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(613, 30);
            this.progressBar1.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(414, 73);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(194, 43);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnUniqueValues
            // 
            this.btnUniqueValues.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUniqueValues.Location = new System.Drawing.Point(108, 24);
            this.btnUniqueValues.Name = "btnUniqueValues";
            this.btnUniqueValues.Size = new System.Drawing.Size(196, 40);
            this.btnUniqueValues.TabIndex = 2;
            this.btnUniqueValues.Text = "Pick Combination";
            this.btnUniqueValues.UseVisualStyleBackColor = true;
            this.btnUniqueValues.Click += new System.EventHandler(this.btnUniqueValues_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_cat_var);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnPlotFilterd);
            this.groupBox2.Controls.Add(this.cmb_y_col);
            this.groupBox2.Controls.Add(this.cmb_x_col);
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(665, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 333);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2- Choose X, Y";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmb_cat_var
            // 
            this.cmb_cat_var.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cat_var.FormattingEnabled = true;
            this.cmb_cat_var.Location = new System.Drawing.Point(35, 93);
            this.cmb_cat_var.Name = "cmb_cat_var";
            this.cmb_cat_var.Size = new System.Drawing.Size(204, 23);
            this.cmb_cat_var.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Choose the Categorical Variable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Choose Y Column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(58, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose X Column";
            // 
            // btnPlotFilterd
            // 
            this.btnPlotFilterd.Location = new System.Drawing.Point(78, 242);
            this.btnPlotFilterd.Name = "btnPlotFilterd";
            this.btnPlotFilterd.Size = new System.Drawing.Size(135, 49);
            this.btnPlotFilterd.TabIndex = 2;
            this.btnPlotFilterd.Text = "Plot";
            this.btnPlotFilterd.UseVisualStyleBackColor = true;
            this.btnPlotFilterd.Click += new System.EventHandler(this.btnPlotFilterd_Click);
            // 
            // cmb_y_col
            // 
            this.cmb_y_col.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_y_col.FormattingEnabled = true;
            this.cmb_y_col.Location = new System.Drawing.Point(35, 191);
            this.cmb_y_col.Name = "cmb_y_col";
            this.cmb_y_col.Size = new System.Drawing.Size(210, 23);
            this.cmb_y_col.TabIndex = 1;
            // 
            // cmb_x_col
            // 
            this.cmb_x_col.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_x_col.FormattingEnabled = true;
            this.cmb_x_col.Location = new System.Drawing.Point(35, 145);
            this.cmb_x_col.Name = "cmb_x_col";
            this.cmb_x_col.Size = new System.Drawing.Size(204, 23);
            this.cmb_x_col.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 688);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1030, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "Number of Records: ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 20);
            this.toolStripStatusLabel1.Text = "No of Records:";
            // 
            // frmCmbPlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 714);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvShowFilteredData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmCmbPlots";
            this.Text = "Plot Combinations";
            this.Load += new System.EventHandler(this.frmCmbPlots_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowFilteredData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowFilteredData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUniqueValues;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnLoadUnfilterd;
        private System.Windows.Forms.Button btnClearSelections;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_y_col;
        private System.Windows.Forms.ComboBox cmb_x_col;
        private System.Windows.Forms.Button btnPlotFilterd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_cat_var;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}