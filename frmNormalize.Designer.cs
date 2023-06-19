
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
            this.lstViwChosenCols = new System.Windows.Forms.ListView();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnResetChosenCols = new System.Windows.Forms.Button();
            this.btnNormalize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbColumns
            // 
            this.cmbColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumns.FormattingEnabled = true;
            this.cmbColumns.Location = new System.Drawing.Point(6, 37);
            this.cmbColumns.Name = "cmbColumns";
            this.cmbColumns.Size = new System.Drawing.Size(201, 23);
            this.cmbColumns.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetChosenCols);
            this.groupBox1.Controls.Add(this.btnAddToList);
            this.groupBox1.Controls.Add(this.lstViwChosenCols);
            this.groupBox1.Controls.Add(this.cmbColumns);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 335);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Columns to Normalize";
            // 
            // lstViwChosenCols
            // 
            this.lstViwChosenCols.HideSelection = false;
            this.lstViwChosenCols.Location = new System.Drawing.Point(6, 80);
            this.lstViwChosenCols.Name = "lstViwChosenCols";
            this.lstViwChosenCols.Size = new System.Drawing.Size(201, 223);
            this.lstViwChosenCols.TabIndex = 1;
            this.lstViwChosenCols.UseCompatibleStateImageBehavior = false;
            this.lstViwChosenCols.View = System.Windows.Forms.View.List;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(223, 37);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(88, 25);
            this.btnAddToList.TabIndex = 2;
            this.btnAddToList.Text = "Add";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // btnResetChosenCols
            // 
            this.btnResetChosenCols.Location = new System.Drawing.Point(6, 303);
            this.btnResetChosenCols.Name = "btnResetChosenCols";
            this.btnResetChosenCols.Size = new System.Drawing.Size(201, 32);
            this.btnResetChosenCols.TabIndex = 3;
            this.btnResetChosenCols.Text = "Reset";
            this.btnResetChosenCols.UseVisualStyleBackColor = true;
            this.btnResetChosenCols.Click += new System.EventHandler(this.btnResetChosenCols_Click);
            // 
            // btnNormalize
            // 
            this.btnNormalize.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNormalize.Location = new System.Drawing.Point(379, 148);
            this.btnNormalize.Name = "btnNormalize";
            this.btnNormalize.Size = new System.Drawing.Size(148, 45);
            this.btnNormalize.TabIndex = 2;
            this.btnNormalize.Text = "Normalize";
            this.btnNormalize.UseVisualStyleBackColor = true;
            this.btnNormalize.Click += new System.EventHandler(this.btnNormalize_Click);
            // 
            // frmNormalize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 404);
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