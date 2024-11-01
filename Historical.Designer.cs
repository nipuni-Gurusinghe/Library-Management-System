namespace Course_Work
{
    partial class Historical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historical));
            this.labelHistorical = new System.Windows.Forms.Label();
            this.buttonHistoricalBack = new System.Windows.Forms.Button();
            this.buttonUpdateListHistorical = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHistorical
            // 
            this.labelHistorical.AutoSize = true;
            this.labelHistorical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelHistorical.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistorical.Location = new System.Drawing.Point(59, 78);
            this.labelHistorical.Name = "labelHistorical";
            this.labelHistorical.Size = new System.Drawing.Size(718, 290);
            this.labelHistorical.TabIndex = 0;
            this.labelHistorical.Text = resources.GetString("labelHistorical.Text");
            this.labelHistorical.Click += new System.EventHandler(this.labelHistorical_Click);
            // 
            // buttonHistoricalBack
            // 
            this.buttonHistoricalBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHistoricalBack.BackgroundImage")));
            this.buttonHistoricalBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHistoricalBack.Location = new System.Drawing.Point(12, 12);
            this.buttonHistoricalBack.Name = "buttonHistoricalBack";
            this.buttonHistoricalBack.Size = new System.Drawing.Size(67, 47);
            this.buttonHistoricalBack.TabIndex = 1;
            this.buttonHistoricalBack.UseVisualStyleBackColor = true;
            this.buttonHistoricalBack.Click += new System.EventHandler(this.buttonHistoricalBack_Click);
            // 
            // buttonUpdateListHistorical
            // 
            this.buttonUpdateListHistorical.BackColor = System.Drawing.Color.Black;
            this.buttonUpdateListHistorical.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateListHistorical.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdateListHistorical.Location = new System.Drawing.Point(333, 382);
            this.buttonUpdateListHistorical.Name = "buttonUpdateListHistorical";
            this.buttonUpdateListHistorical.Size = new System.Drawing.Size(136, 56);
            this.buttonUpdateListHistorical.TabIndex = 2;
            this.buttonUpdateListHistorical.Text = "Updated List";
            this.buttonUpdateListHistorical.UseVisualStyleBackColor = false;
            this.buttonUpdateListHistorical.Click += new System.EventHandler(this.buttonUpdateListHistorical_Click);
            // 
            // Historical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdateListHistorical);
            this.Controls.Add(this.buttonHistoricalBack);
            this.Controls.Add(this.labelHistorical);
            this.Name = "Historical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historical";
            this.Load += new System.EventHandler(this.Historical_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHistorical;
        private System.Windows.Forms.Button buttonHistoricalBack;
        private System.Windows.Forms.Button buttonUpdateListHistorical;
    }
}