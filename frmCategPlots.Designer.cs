
namespace Thabab
{
    partial class frmCategPlots
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFlux = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowPlot = new System.Windows.Forms.Button();
            this.cmb_cat_variable = new System.Windows.Forms.ComboBox();
            this.cmb_time = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFlux);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnShowPlot);
            this.groupBox1.Controls.Add(this.cmb_cat_variable);
            this.groupBox1.Controls.Add(this.cmb_time);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 238);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Variables";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbFlux
            // 
            this.cmbFlux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlux.FormattingEnabled = true;
            this.cmbFlux.Location = new System.Drawing.Point(9, 185);
            this.cmbFlux.Name = "cmbFlux";
            this.cmbFlux.Size = new System.Drawing.Size(185, 23);
            this.cmbFlux.TabIndex = 11;
            this.cmbFlux.SelectedIndexChanged += new System.EventHandler(this.cmbFlux_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Choose Y Column";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose the Categorical Variable";
            // 
            // btnShowPlot
            // 
            this.btnShowPlot.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowPlot.Location = new System.Drawing.Point(248, 104);
            this.btnShowPlot.Name = "btnShowPlot";
            this.btnShowPlot.Size = new System.Drawing.Size(233, 37);
            this.btnShowPlot.TabIndex = 9;
            this.btnShowPlot.Text = "Show Plot(s)";
            this.btnShowPlot.UseVisualStyleBackColor = true;
            this.btnShowPlot.Click += new System.EventHandler(this.btnShowPlot_Click);
            // 
            // cmb_cat_variable
            // 
            this.cmb_cat_variable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cat_variable.FormattingEnabled = true;
            this.cmb_cat_variable.Location = new System.Drawing.Point(6, 62);
            this.cmb_cat_variable.Name = "cmb_cat_variable";
            this.cmb_cat_variable.Size = new System.Drawing.Size(188, 23);
            this.cmb_cat_variable.TabIndex = 7;
            this.cmb_cat_variable.SelectedIndexChanged += new System.EventHandler(this.cmb_cat_variable_SelectedIndexChanged);
            // 
            // cmb_time
            // 
            this.cmb_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_time.FormattingEnabled = true;
            this.cmb_time.Location = new System.Drawing.Point(6, 118);
            this.cmb_time.Name = "cmb_time";
            this.cmb_time.Size = new System.Drawing.Size(188, 23);
            this.cmb_time.TabIndex = 8;
            this.cmb_time.SelectedIndexChanged += new System.EventHandler(this.cmb_time_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose X Column";
            // 
            // frmCategPlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 300);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmCategPlots";
            this.Text = "Plot Categorical Vars";
            this.Load += new System.EventHandler(this.frmCategPlots_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFlux;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowPlot;
        private System.Windows.Forms.ComboBox cmb_cat_variable;
        private System.Windows.Forms.ComboBox cmb_time;
        private System.Windows.Forms.Label label2;
    }
}