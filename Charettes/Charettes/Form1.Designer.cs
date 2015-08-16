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
            this.comboBocComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(281, 306);
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
            this.combogridselect.Location = new System.Drawing.Point(115, 104);
            this.combogridselect.Name = "combogridselect";
            this.combogridselect.Size = new System.Drawing.Size(455, 33);
            this.combogridselect.TabIndex = 1;
            this.combogridselect.SelectedIndexChanged += new System.EventHandler(this.combogridselect_SelectedIndexChanged);
            // 
            // lblgrid
            // 
            this.lblgrid.AutoSize = true;
            this.lblgrid.Location = new System.Drawing.Point(276, 52);
            this.lblgrid.Name = "lblgrid";
            this.lblgrid.Size = new System.Drawing.Size(136, 25);
            this.lblgrid.TabIndex = 2;
            this.lblgrid.Text = "Select a Grid";
            this.lblgrid.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBocComPort
            // 
            this.comboBocComPort.FormattingEnabled = true;
            this.comboBocComPort.Location = new System.Drawing.Point(115, 177);
            this.comboBocComPort.Name = "comboBocComPort";
            this.comboBocComPort.Size = new System.Drawing.Size(272, 33);
            this.comboBocComPort.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Com Port";
            // 
            // FormSelectGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBocComPort);
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
        private System.Windows.Forms.ComboBox comboBocComPort;
        private System.Windows.Forms.Label label1;
    }
}

