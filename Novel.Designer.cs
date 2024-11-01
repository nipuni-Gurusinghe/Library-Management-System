namespace Course_Work
{
    partial class Novel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Novel));
            this.labelNovel = new System.Windows.Forms.Label();
            this.buttonUpdatedListNovel = new System.Windows.Forms.Button();
            this.buttonNovelBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNovel
            // 
            this.labelNovel.AutoSize = true;
            this.labelNovel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelNovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovel.Location = new System.Drawing.Point(114, 34);
            this.labelNovel.Name = "labelNovel";
            this.labelNovel.Size = new System.Drawing.Size(578, 290);
            this.labelNovel.TabIndex = 0;
            this.labelNovel.Text = resources.GetString("labelNovel.Text");
            // 
            // buttonUpdatedListNovel
            // 
            this.buttonUpdatedListNovel.BackColor = System.Drawing.Color.Black;
            this.buttonUpdatedListNovel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpdatedListNovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatedListNovel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdatedListNovel.Location = new System.Drawing.Point(318, 367);
            this.buttonUpdatedListNovel.Name = "buttonUpdatedListNovel";
            this.buttonUpdatedListNovel.Size = new System.Drawing.Size(141, 56);
            this.buttonUpdatedListNovel.TabIndex = 2;
            this.buttonUpdatedListNovel.Text = "Updated List";
            this.buttonUpdatedListNovel.UseVisualStyleBackColor = false;
            this.buttonUpdatedListNovel.Click += new System.EventHandler(this.buttonUpdatedListNovel_Click);
            // 
            // buttonNovelBack
            // 
            this.buttonNovelBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNovelBack.BackgroundImage")));
            this.buttonNovelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNovelBack.Location = new System.Drawing.Point(12, 12);
            this.buttonNovelBack.Name = "buttonNovelBack";
            this.buttonNovelBack.Size = new System.Drawing.Size(68, 46);
            this.buttonNovelBack.TabIndex = 1;
            this.buttonNovelBack.UseVisualStyleBackColor = true;
            this.buttonNovelBack.Click += new System.EventHandler(this.buttonNovelBack_Click);
            // 
            // Novel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdatedListNovel);
            this.Controls.Add(this.buttonNovelBack);
            this.Controls.Add(this.labelNovel);
            this.Name = "Novel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNovel;
        private System.Windows.Forms.Button buttonUpdatedListNovel;
        private System.Windows.Forms.Button buttonNovelBack;
    }
}