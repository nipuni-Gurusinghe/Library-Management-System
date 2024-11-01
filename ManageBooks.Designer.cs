namespace Course_Work
{
    partial class ManageBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooks));
            this.labelManageUserId = new System.Windows.Forms.Label();
            this.labelManagePassword = new System.Windows.Forms.Label();
            this.labelManageText = new System.Windows.Forms.Label();
            this.textBoxAdminUserId = new System.Windows.Forms.TextBox();
            this.textBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.buttonManageBookLogin = new System.Windows.Forms.Button();
            this.buttonBackManageBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelManageUserId
            // 
            this.labelManageUserId.AutoSize = true;
            this.labelManageUserId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelManageUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageUserId.Location = new System.Drawing.Point(257, 162);
            this.labelManageUserId.Name = "labelManageUserId";
            this.labelManageUserId.Size = new System.Drawing.Size(82, 20);
            this.labelManageUserId.TabIndex = 0;
            this.labelManageUserId.Text = "Admin Id";
            // 
            // labelManagePassword
            // 
            this.labelManagePassword.AutoSize = true;
            this.labelManagePassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelManagePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagePassword.Location = new System.Drawing.Point(257, 225);
            this.labelManagePassword.Name = "labelManagePassword";
            this.labelManagePassword.Size = new System.Drawing.Size(91, 20);
            this.labelManagePassword.TabIndex = 1;
            this.labelManagePassword.Text = "Password";
            // 
            // labelManageText
            // 
            this.labelManageText.AutoSize = true;
            this.labelManageText.BackColor = System.Drawing.Color.Transparent;
            this.labelManageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageText.Location = new System.Drawing.Point(24, 80);
            this.labelManageText.Name = "labelManageText";
            this.labelManageText.Size = new System.Drawing.Size(764, 29);
            this.labelManageText.TabIndex = 2;
            this.labelManageText.Text = "Before edit book items,please enter your admin id and password";
            // 
            // textBoxAdminUserId
            // 
            this.textBoxAdminUserId.Location = new System.Drawing.Point(410, 160);
            this.textBoxAdminUserId.Name = "textBoxAdminUserId";
            this.textBoxAdminUserId.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdminUserId.TabIndex = 3;
            // 
            // textBoxAdminPassword
            // 
            this.textBoxAdminPassword.Location = new System.Drawing.Point(410, 225);
            this.textBoxAdminPassword.Name = "textBoxAdminPassword";
            this.textBoxAdminPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdminPassword.TabIndex = 4;
            // 
            // buttonManageBookLogin
            // 
            this.buttonManageBookLogin.BackColor = System.Drawing.Color.Black;
            this.buttonManageBookLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageBookLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonManageBookLogin.Location = new System.Drawing.Point(335, 309);
            this.buttonManageBookLogin.Name = "buttonManageBookLogin";
            this.buttonManageBookLogin.Size = new System.Drawing.Size(110, 56);
            this.buttonManageBookLogin.TabIndex = 5;
            this.buttonManageBookLogin.Text = "Login";
            this.buttonManageBookLogin.UseVisualStyleBackColor = false;
            this.buttonManageBookLogin.Click += new System.EventHandler(this.buttonManageBookLogin_Click);
            // 
            // buttonBackManageBook
            // 
            this.buttonBackManageBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackManageBook.BackgroundImage")));
            this.buttonBackManageBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackManageBook.Location = new System.Drawing.Point(12, 12);
            this.buttonBackManageBook.Name = "buttonBackManageBook";
            this.buttonBackManageBook.Size = new System.Drawing.Size(70, 50);
            this.buttonBackManageBook.TabIndex = 6;
            this.buttonBackManageBook.UseVisualStyleBackColor = true;
            this.buttonBackManageBook.Click += new System.EventHandler(this.buttonBackManageBook_Click);
            // 
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 471);
            this.Controls.Add(this.buttonBackManageBook);
            this.Controls.Add(this.buttonManageBookLogin);
            this.Controls.Add(this.textBoxAdminPassword);
            this.Controls.Add(this.textBoxAdminUserId);
            this.Controls.Add(this.labelManageText);
            this.Controls.Add(this.labelManagePassword);
            this.Controls.Add(this.labelManageUserId);
            this.Name = "ManageBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManageUserId;
        private System.Windows.Forms.Label labelManagePassword;
        private System.Windows.Forms.Label labelManageText;
        private System.Windows.Forms.TextBox textBoxAdminUserId;
        private System.Windows.Forms.TextBox textBoxAdminPassword;
        private System.Windows.Forms.Button buttonManageBookLogin;
        private System.Windows.Forms.Button buttonBackManageBook;
    }
}