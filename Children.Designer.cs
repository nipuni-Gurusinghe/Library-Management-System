namespace Course_Work
{
    partial class Children
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Children));
            this.labelChildren = new System.Windows.Forms.Label();
            this.buttonChildrenBsck = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChildren
            // 
            this.labelChildren.AutoSize = true;
            this.labelChildren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChildren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelChildren.Location = new System.Drawing.Point(89, 45);
            this.labelChildren.Name = "labelChildren";
            this.labelChildren.Size = new System.Drawing.Size(667, 290);
            this.labelChildren.TabIndex = 0;
            this.labelChildren.Text = resources.GetString("labelChildren.Text");
            // 
            // buttonChildrenBsck
            // 
            this.buttonChildrenBsck.BackColor = System.Drawing.Color.White;
            this.buttonChildrenBsck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChildrenBsck.BackgroundImage")));
            this.buttonChildrenBsck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChildrenBsck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonChildrenBsck.Location = new System.Drawing.Point(12, 12);
            this.buttonChildrenBsck.Name = "buttonChildrenBsck";
            this.buttonChildrenBsck.Size = new System.Drawing.Size(71, 49);
            this.buttonChildrenBsck.TabIndex = 1;
            this.buttonChildrenBsck.UseVisualStyleBackColor = false;
            this.buttonChildrenBsck.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(328, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Updated List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Children
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonChildrenBsck);
            this.Controls.Add(this.labelChildren);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Children";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Children";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChildren;
        private System.Windows.Forms.Button buttonChildrenBsck;
        private System.Windows.Forms.Button button1;
    }
}