namespace Charettes
{
    partial class FormSelectGrid
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
            this.btnstart = new System.Windows.Forms.Button();
            this.combogridselect = new System.Windows.Forms.ComboBox();
            this.lblgrid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(178, 101);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(129, 63);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // combogridselect
            // 
            this.combogridselect.FormattingEnabled = true;
            this.combogridselect.Location = new System.Drawing.Point(12, 62);
            this.combogridselect.Name = "combogridselect";
            this.combogridselect.Size = new System.Drawing.Size(455, 33);
            this.combogridselect.TabIndex = 1;
            this.combogridselect.SelectedIndexChanged += new System.EventHandler(this.combogridselect_SelectedIndexChanged);
            // 
            // lblgrid
            // 
            this.lblgrid.AutoSize = true;
            this.lblgrid.Location = new System.Drawing.Point(173, 34);
            this.lblgrid.Name = "lblgrid";
            this.lblgrid.Size = new System.Drawing.Size(136, 25);
            this.lblgrid.TabIndex = 2;
            this.lblgrid.Text = "Select a Grid";
            this.lblgrid.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormSelectGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 335);
            this.Controls.Add(this.lblgrid);
            this.Controls.Add(this.combogridselect);
            this.Controls.Add(this.btnstart);
            this.Name = "FormSelectGrid";
            this.Text = "Virtual Hamilton";
            this.Load += new System.EventHandler(this.FormSelectGrid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.ComboBox combogridselect;
        private System.Windows.Forms.Label lblgrid;
    }
}

