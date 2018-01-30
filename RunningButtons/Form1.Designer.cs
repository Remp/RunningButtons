namespace RunningButtons
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
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLamborgini = new RunningButtons.ButtonCompare();
            this.btnFerrari = new RunningButtons.ButtonCompare();
            this.btnBMW = new RunningButtons.ButtonCompare();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(14, 16);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(134, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 50);
            this.panel1.TabIndex = 4;
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(176, 16);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 25);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(95, 16);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 25);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::RunningButtons.Properties.Resources.Finish;
            this.pictureBox1.Image = global::RunningButtons.Properties.Resources.Image1;
            this.pictureBox1.InitialImage = global::RunningButtons.Properties.Resources.Image1;
            this.pictureBox1.Location = new System.Drawing.Point(468, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 129);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnLamborgini
            // 
            this.btnLamborgini.ForeColor = System.Drawing.Color.Yellow;
            this.btnLamborgini.Location = new System.Drawing.Point(26, 97);
            this.btnLamborgini.Name = "btnLamborgini";
            this.btnLamborgini.Size = new System.Drawing.Size(75, 25);
            this.btnLamborgini.TabIndex = 2;
            this.btnLamborgini.Text = "LAMBORGINI";
            this.btnLamborgini.UseVisualStyleBackColor = true;
            // 
            // btnFerrari
            // 
            this.btnFerrari.ForeColor = System.Drawing.Color.Red;
            this.btnFerrari.Location = new System.Drawing.Point(26, 57);
            this.btnFerrari.Name = "btnFerrari";
            this.btnFerrari.Size = new System.Drawing.Size(75, 25);
            this.btnFerrari.TabIndex = 1;
            this.btnFerrari.Text = "FERRARI";
            this.btnFerrari.UseVisualStyleBackColor = true;
            // 
            // btnBMW
            // 
            this.btnBMW.Location = new System.Drawing.Point(26, 19);
            this.btnBMW.Name = "btnBMW";
            this.btnBMW.Size = new System.Drawing.Size(75, 25);
            this.btnBMW.TabIndex = 0;
            this.btnBMW.Text = "BMW";
            this.btnBMW.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 242);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLamborgini);
            this.Controls.Add(this.btnFerrari);
            this.Controls.Add(this.btnBMW);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonCompare btnBMW;
        private ButtonCompare btnFerrari;
        private ButtonCompare btnLamborgini;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

