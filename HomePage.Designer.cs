namespace Course_Work
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.buttonHomeLogging = new System.Windows.Forms.Button();
            this.labeltitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHomeAbout = new System.Windows.Forms.Label();
            this.labelHomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHomeLogging
            // 
            this.buttonHomeLogging.BackColor = System.Drawing.Color.Black;
            this.buttonHomeLogging.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHomeLogging.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHomeLogging.Location = new System.Drawing.Point(620, 391);
            this.buttonHomeLogging.Name = "buttonHomeLogging";
            this.buttonHomeLogging.Size = new System.Drawing.Size(141, 47);
            this.buttonHomeLogging.TabIndex = 2;
            this.buttonHomeLogging.Text = "Loggin";
            this.buttonHomeLogging.UseVisualStyleBackColor = false;
            this.buttonHomeLogging.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labeltitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labeltitle.Location = new System.Drawing.Point(12, 381);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(0, 37);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Click += new System.EventHandler(this.labeltitle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(304, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 108);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // labelHomeAbout
            // 
            this.labelHomeAbout.AutoSize = true;
            this.labelHomeAbout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelHomeAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeAbout.Location = new System.Drawing.Point(68, 45);
            this.labelHomeAbout.Name = "labelHomeAbout";
            this.labelHomeAbout.Size = new System.Drawing.Size(750, 29);
            this.labelHomeAbout.TabIndex = 5;
            this.labelHomeAbout.Text = "Instant access to endless books & resources, anytime, anywhere.\r\n";
            // 
            // labelHomeLabel
            // 
            this.labelHomeLabel.AutoSize = true;
            this.labelHomeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelHomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeLabel.Location = new System.Drawing.Point(267, 147);
            this.labelHomeLabel.Name = "labelHomeLabel";
            this.labelHomeLabel.Size = new System.Drawing.Size(262, 29);
            this.labelHomeLabel.TabIndex = 6;
            this.labelHomeLabel.Text = "Welcome to e-Library";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.labelHomeLabel);
            this.Controls.Add(this.labelHomeAbout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonHomeLogging);
            this.Controls.Add(this.labeltitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(38, 50);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonHomeLogging;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHomeAbout;
        private System.Windows.Forms.Label labelHomeLabel;
    }
}