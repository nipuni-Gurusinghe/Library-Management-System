namespace Course_Work
{
    partial class HandOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandOver));
            this.labelHandOverBID = new System.Windows.Forms.Label();
            this.labelMemberId = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelOverDueDays = new System.Windows.Forms.Label();
            this.labelPenalty = new System.Windows.Forms.Label();
            this.labelHandOver = new System.Windows.Forms.Label();
            this.buttonHandOver = new System.Windows.Forms.Button();
            this.textBoxBookIdH = new System.Windows.Forms.TextBox();
            this.textBoxMemberIdH = new System.Windows.Forms.TextBox();
            this.textBoxBNameH = new System.Windows.Forms.TextBox();
            this.textBoxOverdueDates = new System.Windows.Forms.TextBox();
            this.textBoxPenalty = new System.Windows.Forms.TextBox();
            this.labelPaymentStatus = new System.Windows.Forms.Label();
            this.textBoxPaymentStatus = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonHandOverBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHandOverBID
            // 
            this.labelHandOverBID.AutoSize = true;
            this.labelHandOverBID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelHandOverBID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHandOverBID.Location = new System.Drawing.Point(233, 74);
            this.labelHandOverBID.Name = "labelHandOverBID";
            this.labelHandOverBID.Size = new System.Drawing.Size(72, 20);
            this.labelHandOverBID.TabIndex = 0;
            this.labelHandOverBID.Text = "Book Id";
            // 
            // labelMemberId
            // 
            this.labelMemberId.AutoSize = true;
            this.labelMemberId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelMemberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMemberId.Location = new System.Drawing.Point(233, 114);
            this.labelMemberId.Name = "labelMemberId";
            this.labelMemberId.Size = new System.Drawing.Size(97, 20);
            this.labelMemberId.TabIndex = 1;
            this.labelMemberId.Text = "Member Id";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookName.Location = new System.Drawing.Point(233, 160);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(105, 20);
            this.labelBookName.TabIndex = 2;
            this.labelBookName.Text = "Book Name";
            // 
            // labelOverDueDays
            // 
            this.labelOverDueDays.AutoSize = true;
            this.labelOverDueDays.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelOverDueDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverDueDays.Location = new System.Drawing.Point(233, 213);
            this.labelOverDueDays.Name = "labelOverDueDays";
            this.labelOverDueDays.Size = new System.Drawing.Size(128, 20);
            this.labelOverDueDays.TabIndex = 3;
            this.labelOverDueDays.Text = "Overdue Days";
            // 
            // labelPenalty
            // 
            this.labelPenalty.AutoSize = true;
            this.labelPenalty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenalty.Location = new System.Drawing.Point(233, 260);
            this.labelPenalty.Name = "labelPenalty";
            this.labelPenalty.Size = new System.Drawing.Size(149, 20);
            this.labelPenalty.TabIndex = 4;
            this.labelPenalty.Text = "Penalty Payment";
            // 
            // labelHandOver
            // 
            this.labelHandOver.AutoSize = true;
            this.labelHandOver.BackColor = System.Drawing.Color.Transparent;
            this.labelHandOver.Font = new System.Drawing.Font("Californian FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHandOver.ForeColor = System.Drawing.Color.Black;
            this.labelHandOver.Location = new System.Drawing.Point(229, 9);
            this.labelHandOver.Name = "labelHandOver";
            this.labelHandOver.Size = new System.Drawing.Size(295, 43);
            this.labelHandOver.TabIndex = 5;
            this.labelHandOver.Text = "Hand Over Books";
            // 
            // buttonHandOver
            // 
            this.buttonHandOver.BackColor = System.Drawing.Color.Black;
            this.buttonHandOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHandOver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHandOver.Location = new System.Drawing.Point(315, 364);
            this.buttonHandOver.Name = "buttonHandOver";
            this.buttonHandOver.Size = new System.Drawing.Size(149, 55);
            this.buttonHandOver.TabIndex = 6;
            this.buttonHandOver.Text = "Hand over";
            this.buttonHandOver.UseVisualStyleBackColor = false;
            this.buttonHandOver.Click += new System.EventHandler(this.buttonHandOver_Click);
            // 
            // textBoxBookIdH
            // 
            this.textBoxBookIdH.Location = new System.Drawing.Point(415, 72);
            this.textBoxBookIdH.Name = "textBoxBookIdH";
            this.textBoxBookIdH.Size = new System.Drawing.Size(100, 22);
            this.textBoxBookIdH.TabIndex = 7;
            // 
            // textBoxMemberIdH
            // 
            this.textBoxMemberIdH.Location = new System.Drawing.Point(415, 114);
            this.textBoxMemberIdH.Name = "textBoxMemberIdH";
            this.textBoxMemberIdH.Size = new System.Drawing.Size(100, 22);
            this.textBoxMemberIdH.TabIndex = 8;
            // 
            // textBoxBNameH
            // 
            this.textBoxBNameH.Location = new System.Drawing.Point(415, 158);
            this.textBoxBNameH.Name = "textBoxBNameH";
            this.textBoxBNameH.Size = new System.Drawing.Size(100, 22);
            this.textBoxBNameH.TabIndex = 9;
            // 
            // textBoxOverdueDates
            // 
            this.textBoxOverdueDates.Location = new System.Drawing.Point(415, 212);
            this.textBoxOverdueDates.Name = "textBoxOverdueDates";
            this.textBoxOverdueDates.Size = new System.Drawing.Size(100, 22);
            this.textBoxOverdueDates.TabIndex = 10;
            // 
            // textBoxPenalty
            // 
            this.textBoxPenalty.Location = new System.Drawing.Point(415, 260);
            this.textBoxPenalty.Name = "textBoxPenalty";
            this.textBoxPenalty.Size = new System.Drawing.Size(100, 22);
            this.textBoxPenalty.TabIndex = 11;
            // 
            // labelPaymentStatus
            // 
            this.labelPaymentStatus.AutoSize = true;
            this.labelPaymentStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentStatus.Location = new System.Drawing.Point(233, 306);
            this.labelPaymentStatus.Name = "labelPaymentStatus";
            this.labelPaymentStatus.Size = new System.Drawing.Size(141, 20);
            this.labelPaymentStatus.TabIndex = 12;
            this.labelPaymentStatus.Text = "Payment Status";
            // 
            // textBoxPaymentStatus
            // 
            this.textBoxPaymentStatus.Location = new System.Drawing.Point(415, 306);
            this.textBoxPaymentStatus.Name = "textBoxPaymentStatus";
            this.textBoxPaymentStatus.Size = new System.Drawing.Size(100, 22);
            this.textBoxPaymentStatus.TabIndex = 13;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.Black;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCalculate.Location = new System.Drawing.Point(553, 201);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(111, 47);
            this.buttonCalculate.TabIndex = 14;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonHandOverBack
            // 
            this.buttonHandOverBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHandOverBack.BackgroundImage")));
            this.buttonHandOverBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHandOverBack.Location = new System.Drawing.Point(12, 16);
            this.buttonHandOverBack.Name = "buttonHandOverBack";
            this.buttonHandOverBack.Size = new System.Drawing.Size(66, 44);
            this.buttonHandOverBack.TabIndex = 15;
            this.buttonHandOverBack.UseVisualStyleBackColor = true;
            this.buttonHandOverBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // HandOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHandOverBack);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxPaymentStatus);
            this.Controls.Add(this.labelPaymentStatus);
            this.Controls.Add(this.textBoxPenalty);
            this.Controls.Add(this.textBoxOverdueDates);
            this.Controls.Add(this.textBoxBNameH);
            this.Controls.Add(this.textBoxMemberIdH);
            this.Controls.Add(this.textBoxBookIdH);
            this.Controls.Add(this.buttonHandOver);
            this.Controls.Add(this.labelHandOver);
            this.Controls.Add(this.labelPenalty);
            this.Controls.Add(this.labelOverDueDays);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.labelMemberId);
            this.Controls.Add(this.labelHandOverBID);
            this.Name = "HandOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HandOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHandOverBID;
        private System.Windows.Forms.Label labelMemberId;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelOverDueDays;
        private System.Windows.Forms.Label labelPenalty;
        private System.Windows.Forms.Label labelHandOver;
        private System.Windows.Forms.Button buttonHandOver;
        private System.Windows.Forms.TextBox textBoxBookIdH;
        private System.Windows.Forms.TextBox textBoxMemberIdH;
        private System.Windows.Forms.TextBox textBoxBNameH;
        private System.Windows.Forms.TextBox textBoxOverdueDates;
        private System.Windows.Forms.TextBox textBoxPenalty;
        private System.Windows.Forms.Label labelPaymentStatus;
        private System.Windows.Forms.TextBox textBoxPaymentStatus;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonHandOverBack;
    }
}