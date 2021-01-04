namespace _02_BitmapPlayground
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PhotoGallary = new System.Windows.Forms.PictureBox();
            this.BrowseMultipleButton = new System.Windows.Forms.Button();
            this.FilterPickerBox = new System.Windows.Forms.ComboBox();
            this.PictureBoxFiltered = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFiltered)).BeginInit();
            this.SuspendLayout();                               
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PhotoGallary
            //            
            this.PhotoGallary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PhotoGallary.Location = new System.Drawing.Point(10, 91);
            this.PhotoGallary.Image = BrowseMultipleButton.Image;
            this.PhotoGallary.Name = "PhotoGallary";
            this.PhotoGallary.Size = new System.Drawing.Size(411, 385);
            this.PhotoGallary.TabIndex = 7;
            this.PhotoGallary.Paint += new System.Windows.Forms.PaintEventHandler(this.PhotoGallary_Paint);
            // 
            // BrowseMultipleButton
            // 
            this.BrowseMultipleButton.Location = new System.Drawing.Point(375, 28);
            this.BrowseMultipleButton.Name = "BrowseMultipleButton";
            this.BrowseMultipleButton.Size = new System.Drawing.Size(130, 27);
            this.BrowseMultipleButton.TabIndex = 6;
            this.BrowseMultipleButton.Text = "Browse Image";
            this.BrowseMultipleButton.UseVisualStyleBackColor = true;
            this.BrowseMultipleButton.Click += new System.EventHandler(this.BrowseMultipleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 409);
            this.Controls.Add(this.FilterPickerBox);
            this.Controls.Add(this.ApplyFilterButton);
            this.Controls.Add(this.PictureBoxFiltered);
            this.Controls.Add(this.PhotoGallary);
            this.Controls.Add(this.BrowseMultipleButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFiltered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoGallary)).EndInit();
            this.ResumeLayout(false);
            // 
            // ApplyFilterButton
            // 
            this.ApplyFilterButton.Location = new System.Drawing.Point(460, 146);
            this.ApplyFilterButton.Name = "ApplyFilterButton";
            this.ApplyFilterButton.Size = new System.Drawing.Size(75, 74);
            this.ApplyFilterButton.TabIndex = 2;
            this.ApplyFilterButton.Text = ">";
            this.ApplyFilterButton.UseVisualStyleBackColor = true;
            this.ApplyFilterButton.Click += new System.EventHandler(this.ApplyFilterButton_Click);
            // 
            // FilterPickerBox
            // 
            this.FilterPickerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterPickerBox.FormattingEnabled = true;
            this.FilterPickerBox.Location = new System.Drawing.Point(438, 226);
            this.FilterPickerBox.Name = "FilterPickerBox";
            this.FilterPickerBox.Size = new System.Drawing.Size(121, 21);
            this.FilterPickerBox.TabIndex = 3;
            // 
            // PictureBoxFiltered
            // 
            this.PictureBoxFiltered.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxFiltered.Location = new System.Drawing.Point(571, 12);
            this.PictureBoxFiltered.Name = "PictureBoxFiltered";
            this.PictureBoxFiltered.Size = new System.Drawing.Size(386, 385);
            this.PictureBoxFiltered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxFiltered.TabIndex = 1;
            this.PictureBoxFiltered.TabStop = false;
        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox PhotoGallary;
        private System.Windows.Forms.Button BrowseMultipleButton;
        private System.Windows.Forms.PictureBox PictureBoxFiltered;
        private System.Windows.Forms.Button ApplyFilterButton;
        private System.Windows.Forms.ComboBox FilterPickerBox;    
    }
}

