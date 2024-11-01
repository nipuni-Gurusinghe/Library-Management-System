namespace Course_Work
{
    partial class RegistationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistationPage));
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.textBoxRegName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAge = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDateOfBirth = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.labelIDNumber = new System.Windows.Forms.Label();
            this.textBoxIdNumber = new System.Windows.Forms.TextBox();
            this.labelRegPassword = new System.Windows.Forms.Label();
            this.TextBoxRegPassword = new System.Windows.Forms.TextBox();
            this.labelFill = new System.Windows.Forms.Label();
            this.errorProviderId = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonRegisterBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderId)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(186, 182);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 18);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Full Name";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(185, 228);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(41, 20);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(185, 281);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(40, 20);
            this.labelSex.TabIndex = 3;
            this.labelSex.Text = "Sex";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(185, 339);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(118, 20);
            this.labelDateOfBirth.TabIndex = 4;
            this.labelDateOfBirth.Text = "Date of Birth";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(185, 387);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(78, 20);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxSex.Location = new System.Drawing.Point(358, 277);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSex.TabIndex = 6;
            // 
            // textBoxRegName
            // 
            this.textBoxRegName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxRegName.Location = new System.Drawing.Point(358, 178);
            this.textBoxRegName.Name = "textBoxRegName";
            this.textBoxRegName.Size = new System.Drawing.Size(100, 22);
            this.textBoxRegName.TabIndex = 7;
            this.textBoxRegName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxRegName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // textBoxAge
            // 
            this.textBoxAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxAge.Location = new System.Drawing.Point(358, 226);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 22);
            this.textBoxAge.TabIndex = 8;
            this.textBoxAge.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAge_Validating);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxAddress.Location = new System.Drawing.Point(358, 387);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddress.TabIndex = 10;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(358, 339);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDateOfBirth.TabIndex = 11;
            this.dateTimePickerDateOfBirth.ValueChanged += new System.EventHandler(this.dateTimePickerDateOfBirth_ValueChanged);
            this.dateTimePickerDateOfBirth.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerDateOfBirth_Validating);
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderAge
            // 
            this.errorProviderAge.ContainerControl = this;
            // 
            // errorProviderDateOfBirth
            // 
            this.errorProviderDateOfBirth.ContainerControl = this;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.Color.Black;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateAccount.Location = new System.Drawing.Point(540, 190);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(203, 56);
            this.buttonCreateAccount.TabIndex = 12;
            this.buttonCreateAccount.Text = "create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // labelIDNumber
            // 
            this.labelIDNumber.AutoSize = true;
            this.labelIDNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDNumber.Location = new System.Drawing.Point(185, 80);
            this.labelIDNumber.Name = "labelIDNumber";
            this.labelIDNumber.Size = new System.Drawing.Size(97, 20);
            this.labelIDNumber.TabIndex = 13;
            this.labelIDNumber.Text = "Member Id";
            // 
            // textBoxIdNumber
            // 
            this.textBoxIdNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxIdNumber.Location = new System.Drawing.Point(358, 78);
            this.textBoxIdNumber.Name = "textBoxIdNumber";
            this.textBoxIdNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdNumber.TabIndex = 14;
            // 
            // labelRegPassword
            // 
            this.labelRegPassword.AutoSize = true;
            this.labelRegPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegPassword.Location = new System.Drawing.Point(185, 129);
            this.labelRegPassword.Name = "labelRegPassword";
            this.labelRegPassword.Size = new System.Drawing.Size(91, 20);
            this.labelRegPassword.TabIndex = 15;
            this.labelRegPassword.Text = "Password";
            // 
            // TextBoxRegPassword
            // 
            this.TextBoxRegPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBoxRegPassword.Location = new System.Drawing.Point(358, 127);
            this.TextBoxRegPassword.Name = "TextBoxRegPassword";
            this.TextBoxRegPassword.Size = new System.Drawing.Size(100, 22);
            this.TextBoxRegPassword.TabIndex = 16;
            // 
            // labelFill
            // 
            this.labelFill.AutoSize = true;
            this.labelFill.BackColor = System.Drawing.Color.Transparent;
            this.labelFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFill.ForeColor = System.Drawing.Color.Black;
            this.labelFill.Location = new System.Drawing.Point(153, 32);
            this.labelFill.Name = "labelFill";
            this.labelFill.Size = new System.Drawing.Size(433, 29);
            this.labelFill.TabIndex = 0;
            this.labelFill.Text = "Fill this forms to create your account";
            // 
            // errorProviderId
            // 
            this.errorProviderId.ContainerControl = this;
            // 
            // buttonRegisterBack
            // 
            this.buttonRegisterBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRegisterBack.BackgroundImage")));
            this.buttonRegisterBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRegisterBack.Location = new System.Drawing.Point(12, 12);
            this.buttonRegisterBack.Name = "buttonRegisterBack";
            this.buttonRegisterBack.Size = new System.Drawing.Size(65, 49);
            this.buttonRegisterBack.TabIndex = 19;
            this.buttonRegisterBack.UseVisualStyleBackColor = true;
            this.buttonRegisterBack.Click += new System.EventHandler(this.buttonRegisterBack_Click);
            // 
            // RegistationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.buttonRegisterBack);
            this.Controls.Add(this.TextBoxRegPassword);
            this.Controls.Add(this.labelRegPassword);
            this.Controls.Add(this.textBoxIdNumber);
            this.Controls.Add(this.labelIDNumber);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxRegName);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelFill);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "RegistationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.TextBox textBoxRegName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderAge;
        private System.Windows.Forms.ErrorProvider errorProviderDateOfBirth;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Label labelIDNumber;
        private System.Windows.Forms.TextBox textBoxIdNumber;
        private System.Windows.Forms.Label labelRegPassword;
        private System.Windows.Forms.TextBox TextBoxRegPassword;
        private System.Windows.Forms.Label labelFill;
        private System.Windows.Forms.ErrorProvider errorProviderId;
        private System.Windows.Forms.Button buttonRegisterBack;
    }
}