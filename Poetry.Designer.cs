namespace Course_Work
{
    partial class Poetry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poetry));
            this.label1 = new System.Windows.Forms.Label();
            this.labelPoetry = new System.Windows.Forms.Label();
            this.buttonPoetryBack = new System.Windows.Forms.Button();
            this.buttonUpdatedListPoetry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // labelPoetry
            // 
            this.labelPoetry.AutoSize = true;
            this.labelPoetry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelPoetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoetry.Location = new System.Drawing.Point(107, 31);
            this.labelPoetry.Name = "labelPoetry";
            this.labelPoetry.Size = new System.Drawing.Size(581, 290);
            this.labelPoetry.TabIndex = 1;
            this.labelPoetry.Text = resources.GetString("labelPoetry.Text");
            // 
            // buttonPoetryBack
            // 
            this.buttonPoetryBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPoetryBack.BackgroundImage")));
            this.buttonPoetryBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPoetryBack.Location = new System.Drawing.Point(12, 12);
            this.buttonPoetryBack.Name = "buttonPoetryBack";
            this.buttonPoetryBack.Size = new System.Drawing.Size(63, 44);
            this.buttonPoetryBack.TabIndex = 2;
            this.buttonPoetryBack.UseVisualStyleBackColor = true;
            this.buttonPoetryBack.Click += new System.EventHandler(this.buttonPoetryBack_Click);
            // 
            // buttonUpdatedListPoetry
            // 
            this.buttonUpdatedListPoetry.BackColor = System.Drawing.Color.Black;
            this.buttonUpdatedListPoetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatedListPoetry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdatedListPoetry.Location = new System.Drawing.Point(313, 371);
            this.buttonUpdatedListPoetry.Name = "buttonUpdatedListPoetry";
            this.buttonUpdatedListPoetry.Size = new System.Drawing.Size(139, 56);
            this.buttonUpdatedListPoetry.TabIndex = 3;
            this.buttonUpdatedListPoetry.Text = "Updated List";
            this.buttonUpdatedListPoetry.UseVisualStyleBackColor = false;
            this.buttonUpdatedListPoetry.Click += new System.EventHandler(this.buttonUpdatedListPoetry_Click);
            // 
            // Poetry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdatedListPoetry);
            this.Controls.Add(this.buttonPoetryBack);
            this.Controls.Add(this.labelPoetry);
            this.Controls.Add(this.label1);
            this.Name = "Poetry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poetry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPoetry;
        private System.Windows.Forms.Button buttonPoetryBack;
        private System.Windows.Forms.Button buttonUpdatedListPoetry;
    }
}