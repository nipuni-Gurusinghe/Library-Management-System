namespace Course_Work
{
    partial class BorrowPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowPage));
            this.labelBorrowDetails = new System.Windows.Forms.Label();
            this.labelBOrrowBookName = new System.Windows.Forms.Label();
            this.textBoxBorrowBookName = new System.Windows.Forms.TextBox();
            this.labelBookId = new System.Windows.Forms.Label();
            this.textBoxBorrowBookId = new System.Windows.Forms.TextBox();
            this.labelBorrow = new System.Windows.Forms.Label();
            this.dateTimePickerBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelMenberId = new System.Windows.Forms.Label();
            this.textBoxMemberId = new System.Windows.Forms.TextBox();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonBorrowBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBorrowDetails
            // 
            this.labelBorrowDetails.AutoSize = true;
            this.labelBorrowDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelBorrowDetails.Font = new System.Drawing.Font("Californian FB", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrowDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBorrowDetails.Location = new System.Drawing.Point(238, 20);
            this.labelBorrowDetails.Name = "labelBorrowDetails";
            this.labelBorrowDetails.Size = new System.Drawing.Size(256, 43);
            this.labelBorrowDetails.TabIndex = 0;
            this.labelBorrowDetails.Text = "Borrow Details";
            // 
            // labelBOrrowBookName
            // 
            this.labelBOrrowBookName.AutoSize = true;
            this.labelBOrrowBookName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelBOrrowBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBOrrowBookName.Location = new System.Drawing.Point(205, 152);
            this.labelBOrrowBookName.Name = "labelBOrrowBookName";
            this.labelBOrrowBookName.Size = new System.Drawing.Size(105, 20);
            this.labelBOrrowBookName.TabIndex = 1;
            this.labelBOrrowBookName.Text = "Book Name";
            // 
            // textBoxBorrowBookName
            // 
            this.textBoxBorrowBookName.Location = new System.Drawing.Point(375, 150);
            this.textBoxBorrowBookName.Name = "textBoxBorrowBookName";
            this.textBoxBorrowBookName.Size = new System.Drawing.Size(100, 22);
            this.textBoxBorrowBookName.TabIndex = 2;
            this.textBoxBorrowBookName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBorrowBookName_Validating);
            // 
            // labelBookId
            // 
            this.labelBookId.AutoSize = true;
            this.labelBookId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookId.Location = new System.Drawing.Point(206, 107);
            this.labelBookId.Name = "labelBookId";
            this.labelBookId.Size = new System.Drawing.Size(72, 20);
            this.labelBookId.TabIndex = 3;
            this.labelBookId.Text = "Book Id";
            // 
            // textBoxBorrowBookId
            // 
            this.textBoxBorrowBookId.Location = new System.Drawing.Point(375, 105);
            this.textBoxBorrowBookId.Name = "textBoxBorrowBookId";
            this.textBoxBorrowBookId.Size = new System.Drawing.Size(100, 22);
            this.textBoxBorrowBookId.TabIndex = 4;
            this.textBoxBorrowBookId.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBorrowBookId_Validating);
            // 
            // labelBorrow
            // 
            this.labelBorrow.AutoSize = true;
            this.labelBorrow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrow.Location = new System.Drawing.Point(206, 259);
            this.labelBorrow.Name = "labelBorrow";
            this.labelBorrow.Size = new System.Drawing.Size(115, 20);
            this.labelBorrow.TabIndex = 5;
            this.labelBorrow.Text = "Borrow Date";
            // 
            // dateTimePickerBorrowDate
            // 
            this.dateTimePickerBorrowDate.Location = new System.Drawing.Point(375, 257);
            this.dateTimePickerBorrowDate.Name = "dateTimePickerBorrowDate";
            this.dateTimePickerBorrowDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBorrowDate.TabIndex = 6;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(375, 321);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 22);
            this.textBoxDuration.TabIndex = 7;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(206, 321);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(81, 20);
            this.labelDuration.TabIndex = 8;
            this.labelDuration.Text = "Duration";
            // 
            // labelMenberId
            // 
            this.labelMenberId.AutoSize = true;
            this.labelMenberId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelMenberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenberId.Location = new System.Drawing.Point(206, 205);
            this.labelMenberId.Name = "labelMenberId";
            this.labelMenberId.Size = new System.Drawing.Size(97, 20);
            this.labelMenberId.TabIndex = 9;
            this.labelMenberId.Text = "Member Id";
            // 
            // textBoxMemberId
            // 
            this.textBoxMemberId.Location = new System.Drawing.Point(375, 203);
            this.textBoxMemberId.Name = "textBoxMemberId";
            this.textBoxMemberId.Size = new System.Drawing.Size(100, 22);
            this.textBoxMemberId.TabIndex = 10;
            this.textBoxMemberId.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMemberId_Validating);
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.BackColor = System.Drawing.Color.Black;
            this.buttonBorrow.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBorrow.Location = new System.Drawing.Point(330, 372);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(132, 51);
            this.buttonBorrow.TabIndex = 11;
            this.buttonBorrow.Text = "Borrow";
            this.buttonBorrow.UseVisualStyleBackColor = false;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // buttonBorrowBack
            // 
            this.buttonBorrowBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBorrowBack.BackgroundImage")));
            this.buttonBorrowBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBorrowBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBorrowBack.Name = "buttonBorrowBack";
            this.buttonBorrowBack.Size = new System.Drawing.Size(70, 51);
            this.buttonBorrowBack.TabIndex = 12;
            this.buttonBorrowBack.UseVisualStyleBackColor = true;
            this.buttonBorrowBack.Click += new System.EventHandler(this.buttonBorrowBack_Click);
            // 
            // BorrowPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBorrowBack);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.textBoxMemberId);
            this.Controls.Add(this.labelMenberId);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.dateTimePickerBorrowDate);
            this.Controls.Add(this.labelBorrow);
            this.Controls.Add(this.textBoxBorrowBookId);
            this.Controls.Add(this.labelBookId);
            this.Controls.Add(this.textBoxBorrowBookName);
            this.Controls.Add(this.labelBOrrowBookName);
            this.Controls.Add(this.labelBorrowDetails);
            this.Name = "BorrowPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BorrowPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBorrowDetails;
        private System.Windows.Forms.Label labelBOrrowBookName;
        private System.Windows.Forms.TextBox textBoxBorrowBookName;
        private System.Windows.Forms.Label labelBookId;
        private System.Windows.Forms.TextBox textBoxBorrowBookId;
        private System.Windows.Forms.Label labelBorrow;
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrowDate;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelMenberId;
        private System.Windows.Forms.TextBox textBoxMemberId;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button buttonBorrowBack;
    }
}