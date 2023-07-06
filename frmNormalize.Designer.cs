
namespace Thabab
{
    partial class frmNormalize
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
            this.cmbColumns = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetChosenCols = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.lstViwChosenCols = new System.Windows.Forms.ListView();
            this.btnNormalize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbColumns
            // 
            this.cmbColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumns.FormattingEnabled = true;
            this.cmbColumns.Location = new System.Drawing.Point(6, 39);
            this.cmbColumns.Name = "cmbColumns";
            this.cmbColumns.Size = new System.Drawing.Size(201, 24);
            this.cmbColumns.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetChosenCols);
            this.groupBox1.Controls.Add(this.btnAddToList);
            this.groupBox1.Controls.Add(this.lstViwChosenCols);
            this.groupBox1.Controls.Add(this.cmbColumns);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 357);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Columns to Normalize";
            // 
            // btnResetChosenCols
            // 
            this.btnResetChosenCols.Location = new System.Drawing.Point(6, 323);
            this.btnResetChosenCols.Name = "btnResetChosenCols";
            this.btnResetChosenCols.Size = new System.Drawing.Size(201, 34);
            this.btnResetChosenCols.TabIndex = 3;
            this.btnResetChosenCols.Text = "Reset";
            this.btnResetChosenCols.UseVisualStyleBackColor = true;
            this.btnResetChosenCols.Click += new System.EventHandler(this.btnResetChosenCols_Click);
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(223, 39);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(88, 27);
            this.btnAddToList.TabIndex = 2;
            this.btnAddToList.Text = "Add";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // lstViwChosenCols
            // 
            this.lstViwChosenCols.HideSelection = false;
            this.lstViwChosenCols.Location = new System.Drawing.Point(6, 85);
            this.lstViwChosenCols.Name = "lstViwChosenCols";
            this.lstViwChosenCols.Size = new System.Drawing.Size(201, 238);
            this.lstViwChosenCols.TabIndex = 1;
            this.lstViwChosenCols.UseCompatibleStateImageBehavior = false;
            this.lstViwChosenCols.View = System.Windows.Forms.View.List;
            // 
            // btnNormalize
            // 
            this.btnNormalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnNormalize.Location = new System.Drawing.Point(379, 158);
            this.btnNormalize.Name = "btnNormalize";
            this.btnNormalize.Size = new System.Drawing.Size(148, 48);
            this.btnNormalize.TabIndex = 2;
            this.btnNormalize.Text = "Normalize";
            this.btnNormalize.UseVisualStyleBackColor = true;
            this.btnNormalize.Click += new System.EventHandler(this.btnNormalize_Click);
            // 
            // frmNormalize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 431);
            this.Controls.Add(this.btnNormalize);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmNormalize";
            this.Text = "frmNormalize";
            this.Load += new System.EventHandler(this.frmNormalize_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbColumns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstViwChosenCols;
        private System.Windows.Forms.Button btnResetChosenCols;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnNormalize;
    }
}