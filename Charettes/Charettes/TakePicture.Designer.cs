namespace Charettes
{
    partial class TakePicture
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCapture = new System.Windows.Forms.Button();
            this.imageBoxLiveFeed = new Emgu.CV.UI.ImageBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnSwitchMode = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.imageBox5 = new Emgu.CV.UI.ImageBox();
            this.imageBox6 = new Emgu.CV.UI.ImageBox();
            this.imageBox7 = new Emgu.CV.UI.ImageBox();
            this.imageBox8 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLiveFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(348, 558);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(217, 103);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imageBoxLiveFeed
            // 
            this.imageBoxLiveFeed.Location = new System.Drawing.Point(12, 12);
            this.imageBoxLiveFeed.Name = "imageBoxLiveFeed";
            this.imageBoxLiveFeed.Size = new System.Drawing.Size(960, 540);
            this.imageBoxLiveFeed.TabIndex = 2;
            this.imageBoxLiveFeed.TabStop = false;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(235, 679);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(257, 73);
            this.lblMode.TabIndex = 3;
            this.lblMode.Text = "lblMode";
            // 
            // btnSwitchMode
            // 
            this.btnSwitchMode.Location = new System.Drawing.Point(12, 663);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(217, 103);
            this.btnSwitchMode.TabIndex = 4;
            this.btnSwitchMode.Text = "Switch Mode";
            this.btnSwitchMode.UseVisualStyleBackColor = true;
            this.btnSwitchMode.Click += new System.EventHandler(this.btnSwitchMode_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(1020, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(245, 181);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Click += new System.EventHandler(this.imageBox1_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(1020, 199);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(245, 181);
            this.imageBox2.TabIndex = 5;
            this.imageBox2.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.Location = new System.Drawing.Point(1020, 386);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(245, 181);
            this.imageBox3.TabIndex = 6;
            this.imageBox3.TabStop = false;
            // 
            // imageBox4
            // 
            this.imageBox4.Location = new System.Drawing.Point(1020, 573);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(245, 181);
            this.imageBox4.TabIndex = 7;
            this.imageBox4.TabStop = false;
            // 
            // imageBox5
            // 
            this.imageBox5.Location = new System.Drawing.Point(1271, 12);
            this.imageBox5.Name = "imageBox5";
            this.imageBox5.Size = new System.Drawing.Size(245, 181);
            this.imageBox5.TabIndex = 8;
            this.imageBox5.TabStop = false;
            // 
            // imageBox6
            // 
            this.imageBox6.Location = new System.Drawing.Point(1271, 199);
            this.imageBox6.Name = "imageBox6";
            this.imageBox6.Size = new System.Drawing.Size(245, 181);
            this.imageBox6.TabIndex = 9;
            this.imageBox6.TabStop = false;
            // 
            // imageBox7
            // 
            this.imageBox7.Location = new System.Drawing.Point(1271, 386);
            this.imageBox7.Name = "imageBox7";
            this.imageBox7.Size = new System.Drawing.Size(245, 181);
            this.imageBox7.TabIndex = 10;
            this.imageBox7.TabStop = false;
            // 
            // imageBox8
            // 
            this.imageBox8.Location = new System.Drawing.Point(1271, 573);
            this.imageBox8.Name = "imageBox8";
            this.imageBox8.Size = new System.Drawing.Size(245, 181);
            this.imageBox8.TabIndex = 11;
            this.imageBox8.TabStop = false;
            // 
            // TakePicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 776);
            this.Controls.Add(this.imageBox8);
            this.Controls.Add(this.imageBox7);
            this.Controls.Add(this.imageBox6);
            this.Controls.Add(this.imageBox5);
            this.Controls.Add(this.imageBox4);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btnSwitchMode);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.imageBoxLiveFeed);
            this.Controls.Add(this.btnCapture);
            this.Name = "TakePicture";
            this.Text = "TakePicture";
            this.Load += new System.EventHandler(this.TakePicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLiveFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCapture;
        private Emgu.CV.UI.ImageBox imageBoxLiveFeed;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnSwitchMode;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox3;
        private Emgu.CV.UI.ImageBox imageBox4;
        private Emgu.CV.UI.ImageBox imageBox5;
        private Emgu.CV.UI.ImageBox imageBox6;
        private Emgu.CV.UI.ImageBox imageBox7;
        private Emgu.CV.UI.ImageBox imageBox8;

    }
}