
namespace Thabab
{
    partial class frmCombinationPlots
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
            this.chkListColumns = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dgvFilteredData = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstViewChosenCombination = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilteredData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkListColumns
            // 
            this.chkListColumns.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chkListColumns.FormattingEnabled = true;
            this.chkListColumns.Location = new System.Drawing.Point(31, 32);
            this.chkListColumns.Name = "chkListColumns";
            this.chkListColumns.Size = new System.Drawing.Size(162, 244);
            this.chkListColumns.TabIndex = 0;
            this.chkListColumns.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListColumns_ItemCheck);
            this.chkListColumns.SelectedIndexChanged += new System.EventHandler(this.chkListColumns_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkListColumns);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Categorical Variable(s)";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 252);
            this.panel1.TabIndex = 2;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 612);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(217, 39);
            this.progressBar1.TabIndex = 6;
            // 
            // dgvFilteredData
            // 
            this.dgvFilteredData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilteredData.Location = new System.Drawing.Point(12, 295);
            this.dgvFilteredData.Name = "dgvFilteredData";
            this.dgvFilteredData.ReadOnly = true;
            this.dgvFilteredData.RowHeadersWidth = 51;
            this.dgvFilteredData.RowTemplate.Height = 27;
            this.dgvFilteredData.Size = new System.Drawing.Size(799, 311);
            this.dgvFilteredData.TabIndex = 8;
            this.dgvFilteredData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilteredData_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(308, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 288);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Choose Variables Combination";
            // 
            // lstViewChosenCombination
            // 
            this.lstViewChosenCombination.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstViewChosenCombination.HideSelection = false;
            this.lstViewChosenCombination.Location = new System.Drawing.Point(828, 25);
            this.lstViewChosenCombination.Name = "lstViewChosenCombination";
            this.lstViewChosenCombination.Size = new System.Drawing.Size(244, 252);
            this.lstViewChosenCombination.TabIndex = 10;
            this.lstViewChosenCombination.UseCompatibleStateImageBehavior = false;
            // 
            // frmCombinationPlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 667);
            this.Controls.Add(this.lstViewChosenCombination);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvFilteredData);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmCombinationPlots";
            this.Text = "Plot Combinations";
            this.Load += new System.EventHandler(this.frmCombinationPlots_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilteredData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListColumns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dgvFilteredData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstViewChosenCombination;
    }
}