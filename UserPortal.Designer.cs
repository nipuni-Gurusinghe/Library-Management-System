namespace Course_Work
{
    partial class UserPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPortal));
            this.buttonportalManageBooks = new System.Windows.Forms.Button();
            this.buttonportalBorrow = new System.Windows.Forms.Button();
            this.buttonPortalBookDetails = new System.Windows.Forms.Button();
            this.buttonUserPortralBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonportalManageBooks
            // 
            this.buttonportalManageBooks.BackColor = System.Drawing.Color.Black;
            this.buttonportalManageBooks.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonportalManageBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonportalManageBooks.Location = new System.Drawing.Point(567, 132);
            this.buttonportalManageBooks.Name = "buttonportalManageBooks";
            this.buttonportalManageBooks.Size = new System.Drawing.Size(187, 132);
            this.buttonportalManageBooks.TabIndex = 3;
            this.buttonportalManageBooks.Text = "Manage Books";
            this.buttonportalManageBooks.UseVisualStyleBackColor = false;
            this.buttonportalManageBooks.Click += new System.EventHandler(this.buttonportalManageBooks_Click);
            // 
            // buttonportalBorrow
            // 
            this.buttonportalBorrow.BackColor = System.Drawing.Color.Black;
            this.buttonportalBorrow.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonportalBorrow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonportalBorrow.Location = new System.Drawing.Point(318, 132);
            this.buttonportalBorrow.Name = "buttonportalBorrow";
            this.buttonportalBorrow.Size = new System.Drawing.Size(186, 132);
            this.buttonportalBorrow.TabIndex = 2;
            this.buttonportalBorrow.Text = "Borrow";
            this.buttonportalBorrow.UseVisualStyleBackColor = false;
            this.buttonportalBorrow.Click += new System.EventHandler(this.buttonportalBorrow_Click);
            // 
            // buttonPortalBookDetails
            // 
            this.buttonPortalBookDetails.BackColor = System.Drawing.Color.Black;
            this.buttonPortalBookDetails.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPortalBookDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPortalBookDetails.Location = new System.Drawing.Point(64, 132);
            this.buttonPortalBookDetails.Name = "buttonPortalBookDetails";
            this.buttonPortalBookDetails.Size = new System.Drawing.Size(191, 132);
            this.buttonPortalBookDetails.TabIndex = 0;
            this.buttonPortalBookDetails.Text = "Book \r\nDetails";
            this.buttonPortalBookDetails.UseVisualStyleBackColor = false;
            this.buttonPortalBookDetails.Click += new System.EventHandler(this.buttonPortalBookDetails_Click);
            // 
            // buttonUserPortralBack
            // 
            this.buttonUserPortralBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUserPortralBack.BackgroundImage")));
            this.buttonUserPortralBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUserPortralBack.Location = new System.Drawing.Point(13, 13);
            this.buttonUserPortralBack.Name = "buttonUserPortralBack";
            this.buttonUserPortralBack.Size = new System.Drawing.Size(71, 42);
            this.buttonUserPortralBack.TabIndex = 4;
            this.buttonUserPortralBack.UseVisualStyleBackColor = true;
            this.buttonUserPortralBack.Click += new System.EventHandler(this.buttonUserPortralBack_Click);
            // 
            // UserPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUserPortralBack);
            this.Controls.Add(this.buttonportalManageBooks);
            this.Controls.Add(this.buttonportalBorrow);
            this.Controls.Add(this.buttonPortalBookDetails);
            this.Name = "UserPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPortal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPortalBookDetails;
        private System.Windows.Forms.Button buttonportalBorrow;
        private System.Windows.Forms.Button buttonportalManageBooks;
        private System.Windows.Forms.Button buttonUserPortralBack;
    }
}