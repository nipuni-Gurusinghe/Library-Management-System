namespace Course_Work
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.LabelLibraryName = new System.Windows.Forms.Label();
            this.LableInstruction = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelClickThis = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.errorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBoxWelcome = new System.Windows.Forms.PictureBox();
            this.pictureBoxWelcome2 = new System.Windows.Forms.PictureBox();
            this.buttonBackWelcome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome2)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLibraryName
            // 
            this.LabelLibraryName.AutoSize = true;
            this.LabelLibraryName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelLibraryName.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLibraryName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelLibraryName.Location = new System.Drawing.Point(463, 55);
            this.LabelLibraryName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelLibraryName.Name = "LabelLibraryName";
            this.LabelLibraryName.Size = new System.Drawing.Size(0, 37);
            this.LabelLibraryName.TabIndex = 0;
            this.LabelLibraryName.Click += new System.EventHandler(this.LabelLibraryName_Click);
            // 
            // LableInstruction
            // 
            this.LableInstruction.AutoSize = true;
            this.LableInstruction.BackColor = System.Drawing.Color.Transparent;
            this.LableInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableInstruction.Location = new System.Drawing.Point(284, 117);
            this.LableInstruction.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LableInstruction.Name = "LableInstruction";
            this.LableInstruction.Size = new System.Drawing.Size(566, 32);
            this.LableInstruction.TabIndex = 1;
            this.LableInstruction.Text = "If you have an account.Please login here";
            this.LableInstruction.Click += new System.EventHandler(this.LableInstruction_Click);
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.BackColor = System.Drawing.Color.Transparent;
            this.labelUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserId.Location = new System.Drawing.Point(413, 198);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(117, 25);
            this.labelUserId.TabIndex = 2;
            this.labelUserId.Text = "Member ID";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(424, 275);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(106, 25);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(621, 198);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 30);
            this.textBoxUserName.TabIndex = 4;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            this.textBoxUserName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUserName_Validating);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(621, 275);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 30);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
            // 
            // labelClickThis
            // 
            this.labelClickThis.AutoSize = true;
            this.labelClickThis.BackColor = System.Drawing.Color.Transparent;
            this.labelClickThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickThis.Location = new System.Drawing.Point(245, 467);
            this.labelClickThis.Name = "labelClickThis";
            this.labelClickThis.Size = new System.Drawing.Size(694, 32);
            this.labelClickThis.TabIndex = 6;
            this.labelClickThis.Text = "If you don\'t have an account.Click here to Register";
            this.labelClickThis.Click += new System.EventHandler(this.labelClickThis_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Black;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegister.Location = new System.Drawing.Point(483, 555);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(165, 52);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Black;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(500, 363);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(148, 44);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.Validating += new System.ComponentModel.CancelEventHandler(this.buttonLogin_Validating);
            // 
            // errorProviderUsername
            // 
            this.errorProviderUsername.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // pictureBoxWelcome
            // 
            this.pictureBoxWelcome.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWelcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxWelcome.BackgroundImage")));
            this.pictureBoxWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWelcome.Location = new System.Drawing.Point(33, 180);
            this.pictureBoxWelcome.Name = "pictureBoxWelcome";
            this.pictureBoxWelcome.Size = new System.Drawing.Size(241, 227);
            this.pictureBoxWelcome.TabIndex = 12;
            this.pictureBoxWelcome.TabStop = false;
            this.pictureBoxWelcome.Click += new System.EventHandler(this.pictureBoxWelcome_Click);
            // 
            // pictureBoxWelcome2
            // 
            this.pictureBoxWelcome2.BackColor = System.Drawing.Color.White;
            this.pictureBoxWelcome2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxWelcome2.BackgroundImage")));
            this.pictureBoxWelcome2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWelcome2.Location = new System.Drawing.Point(400, 12);
            this.pictureBoxWelcome2.Name = "pictureBoxWelcome2";
            this.pictureBoxWelcome2.Size = new System.Drawing.Size(267, 80);
            this.pictureBoxWelcome2.TabIndex = 13;
            this.pictureBoxWelcome2.TabStop = false;
            // 
            // buttonBackWelcome
            // 
            this.buttonBackWelcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackWelcome.BackgroundImage")));
            this.buttonBackWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackWelcome.Location = new System.Drawing.Point(12, 33);
            this.buttonBackWelcome.Name = "buttonBackWelcome";
            this.buttonBackWelcome.Size = new System.Drawing.Size(58, 45);
            this.buttonBackWelcome.TabIndex = 14;
            this.buttonBackWelcome.UseVisualStyleBackColor = true;
            this.buttonBackWelcome.Click += new System.EventHandler(this.buttonBackWelcome_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.buttonBackWelcome);
            this.Controls.Add(this.pictureBoxWelcome2);
            this.Controls.Add(this.pictureBoxWelcome);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelClickThis);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.LableInstruction);
            this.Controls.Add(this.LabelLibraryName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WelcomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLibraryName;
        private System.Windows.Forms.Label LableInstruction;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelClickThis;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ErrorProvider errorProviderUsername;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.PictureBox pictureBoxWelcome;
        private System.Windows.Forms.PictureBox pictureBoxWelcome2;
        private System.Windows.Forms.Button buttonBackWelcome;
    }
}

