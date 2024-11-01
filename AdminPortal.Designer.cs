namespace Course_Work
{
    partial class AdminPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPortal));
            this.buttonAPHandOver = new System.Windows.Forms.Button();
            this.buttonAPAddRemove = new System.Windows.Forms.Button();
            this.buttonBackAdminPoetral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAPHandOver
            // 
            this.buttonAPHandOver.BackColor = System.Drawing.Color.Black;
            this.buttonAPHandOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAPHandOver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAPHandOver.Location = new System.Drawing.Point(148, 152);
            this.buttonAPHandOver.Name = "buttonAPHandOver";
            this.buttonAPHandOver.Size = new System.Drawing.Size(209, 147);
            this.buttonAPHandOver.TabIndex = 0;
            this.buttonAPHandOver.Text = "HandOverBooks";
            this.buttonAPHandOver.UseVisualStyleBackColor = false;
            this.buttonAPHandOver.Click += new System.EventHandler(this.buttonAPHandOver_Click);
            // 
            // buttonAPAddRemove
            // 
            this.buttonAPAddRemove.BackColor = System.Drawing.Color.Black;
            this.buttonAPAddRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAPAddRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAPAddRemove.Location = new System.Drawing.Point(423, 152);
            this.buttonAPAddRemove.Name = "buttonAPAddRemove";
            this.buttonAPAddRemove.Size = new System.Drawing.Size(232, 139);
            this.buttonAPAddRemove.TabIndex = 1;
            this.buttonAPAddRemove.Text = "Add Remove Books";
            this.buttonAPAddRemove.UseVisualStyleBackColor = false;
            this.buttonAPAddRemove.Click += new System.EventHandler(this.buttonAPAddRemove_Click);
            // 
            // buttonBackAdminPoetral
            // 
            this.buttonBackAdminPoetral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackAdminPoetral.BackgroundImage")));
            this.buttonBackAdminPoetral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackAdminPoetral.Location = new System.Drawing.Point(12, 12);
            this.buttonBackAdminPoetral.Name = "buttonBackAdminPoetral";
            this.buttonBackAdminPoetral.Size = new System.Drawing.Size(69, 46);
            this.buttonBackAdminPoetral.TabIndex = 2;
            this.buttonBackAdminPoetral.UseVisualStyleBackColor = true;
            this.buttonBackAdminPoetral.Click += new System.EventHandler(this.buttonBackAdminPoetral_Click);
            // 
            // AdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBackAdminPoetral);
            this.Controls.Add(this.buttonAPAddRemove);
            this.Controls.Add(this.buttonAPHandOver);
            this.Name = "AdminPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPortal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAPHandOver;
        private System.Windows.Forms.Button buttonAPAddRemove;
        private System.Windows.Forms.Button buttonBackAdminPoetral;
    }
}