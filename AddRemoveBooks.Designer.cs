namespace Course_Work
{
    partial class AddRemoveBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRemoveBooks));
            this.labelAddBookId = new System.Windows.Forms.Label();
            this.labelAddBookName = new System.Windows.Forms.Label();
            this.labelAddAuthor = new System.Windows.Forms.Label();
            this.labelAddCategory = new System.Windows.Forms.Label();
            this.textBoxAddBookId = new System.Windows.Forms.TextBox();
            this.textBoxAddBookName = new System.Windows.Forms.TextBox();
            this.textBoxAddAuthor = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonBackAddRemoveBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddBookId
            // 
            this.labelAddBookId.AutoSize = true;
            this.labelAddBookId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelAddBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBookId.Location = new System.Drawing.Point(207, 75);
            this.labelAddBookId.Name = "labelAddBookId";
            this.labelAddBookId.Size = new System.Drawing.Size(66, 20);
            this.labelAddBookId.TabIndex = 0;
            this.labelAddBookId.Text = "BookId";
            this.labelAddBookId.Click += new System.EventHandler(this.labelAddBookId_Click);
            // 
            // labelAddBookName
            // 
            this.labelAddBookName.AutoSize = true;
            this.labelAddBookName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelAddBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBookName.Location = new System.Drawing.Point(207, 132);
            this.labelAddBookName.Name = "labelAddBookName";
            this.labelAddBookName.Size = new System.Drawing.Size(99, 20);
            this.labelAddBookName.TabIndex = 1;
            this.labelAddBookName.Text = "BookName";
            // 
            // labelAddAuthor
            // 
            this.labelAddAuthor.AutoSize = true;
            this.labelAddAuthor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddAuthor.Location = new System.Drawing.Point(207, 179);
            this.labelAddAuthor.Name = "labelAddAuthor";
            this.labelAddAuthor.Size = new System.Drawing.Size(64, 20);
            this.labelAddAuthor.TabIndex = 2;
            this.labelAddAuthor.Text = "Author";
            // 
            // labelAddCategory
            // 
            this.labelAddCategory.AutoSize = true;
            this.labelAddCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddCategory.Location = new System.Drawing.Point(207, 231);
            this.labelAddCategory.Name = "labelAddCategory";
            this.labelAddCategory.Size = new System.Drawing.Size(84, 20);
            this.labelAddCategory.TabIndex = 3;
            this.labelAddCategory.Text = "Category";
            // 
            // textBoxAddBookId
            // 
            this.textBoxAddBookId.Location = new System.Drawing.Point(394, 75);
            this.textBoxAddBookId.Name = "textBoxAddBookId";
            this.textBoxAddBookId.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddBookId.TabIndex = 4;
            this.textBoxAddBookId.TextChanged += new System.EventHandler(this.textBoxAddBookId_TextChanged);
            this.textBoxAddBookId.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAddBookId_Validating);
            // 
            // textBoxAddBookName
            // 
            this.textBoxAddBookName.Location = new System.Drawing.Point(394, 130);
            this.textBoxAddBookName.Name = "textBoxAddBookName";
            this.textBoxAddBookName.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddBookName.TabIndex = 5;
            // 
            // textBoxAddAuthor
            // 
            this.textBoxAddAuthor.Location = new System.Drawing.Point(394, 177);
            this.textBoxAddAuthor.Name = "textBoxAddAuthor";
            this.textBoxAddAuthor.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddAuthor.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Black;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(198, 317);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(128, 48);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Black;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRemove.Location = new System.Drawing.Point(416, 317);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(109, 48);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Novel",
            "Childrens",
            "Poetry",
            "Historical"});
            this.comboBoxCategory.Location = new System.Drawing.Point(385, 231);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCategory.TabIndex = 10;
            // 
            // buttonBackAddRemoveBooks
            // 
            this.buttonBackAddRemoveBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackAddRemoveBooks.BackgroundImage")));
            this.buttonBackAddRemoveBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackAddRemoveBooks.Location = new System.Drawing.Point(12, 12);
            this.buttonBackAddRemoveBooks.Name = "buttonBackAddRemoveBooks";
            this.buttonBackAddRemoveBooks.Size = new System.Drawing.Size(75, 48);
            this.buttonBackAddRemoveBooks.TabIndex = 11;
            this.buttonBackAddRemoveBooks.UseVisualStyleBackColor = true;
            this.buttonBackAddRemoveBooks.Click += new System.EventHandler(this.buttonBackAddRemoveBooks_Click);
            // 
            // AddRemoveBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBackAddRemoveBooks);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAddAuthor);
            this.Controls.Add(this.textBoxAddBookName);
            this.Controls.Add(this.textBoxAddBookId);
            this.Controls.Add(this.labelAddCategory);
            this.Controls.Add(this.labelAddAuthor);
            this.Controls.Add(this.labelAddBookName);
            this.Controls.Add(this.labelAddBookId);
            this.Name = "AddRemoveBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRemoveBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddBookId;
        private System.Windows.Forms.Label labelAddBookName;
        private System.Windows.Forms.Label labelAddAuthor;
        private System.Windows.Forms.Label labelAddCategory;
        private System.Windows.Forms.TextBox textBoxAddBookId;
        private System.Windows.Forms.TextBox textBoxAddBookName;
        private System.Windows.Forms.TextBox textBoxAddAuthor;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonBackAddRemoveBooks;
    }
}