namespace SerialPlotter
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBoxCOMM = new System.Windows.Forms.ComboBox();
            this.chartXY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartXY)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCOMM
            // 
            this.comboBoxCOMM.FormattingEnabled = true;
            this.comboBoxCOMM.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.comboBoxCOMM.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCOMM.Name = "comboBoxCOMM";
            this.comboBoxCOMM.Size = new System.Drawing.Size(147, 21);
            this.comboBoxCOMM.TabIndex = 0;
            this.comboBoxCOMM.Text = "Select COM";
            // 
            // chartXY
            // 
            this.chartXY.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Graphics;
            chartArea2.AxisX.Interval = 128D;
            chartArea2.AxisX.MajorGrid.Interval = 128D;
            chartArea2.AxisX.Maximum = 1023D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Interval = 128D;
            chartArea2.AxisY.MajorGrid.Interval = 128D;
            chartArea2.AxisY.Maximum = 768D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.Name = "ChartArea1";
            this.chartXY.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartXY.Legends.Add(legend2);
            this.chartXY.Location = new System.Drawing.Point(172, 12);
            this.chartXY.Name = "chartXY";
            this.chartXY.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series5.Legend = "Legend1";
            series5.MarkerSize = 10;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "Blob1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series6.Legend = "Legend1";
            series6.MarkerSize = 10;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "Blob2";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series7.Legend = "Legend1";
            series7.MarkerSize = 10;
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series7.Name = "Blob3";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series8.Legend = "Legend1";
            series8.MarkerSize = 10;
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "Blob4";
            this.chartXY.Series.Add(series5);
            this.chartXY.Series.Add(series6);
            this.chartXY.Series.Add(series7);
            this.chartXY.Series.Add(series8);
            this.chartXY.Size = new System.Drawing.Size(929, 604);
            this.chartXY.TabIndex = 1;
            this.chartXY.Text = "chart1";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 39);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(84, 39);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(983, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 643);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.chartXY);
            this.Controls.Add(this.comboBoxCOMM);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartXY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCOMM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartXY;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button button1;
    }
}

