namespace Participation5
{
    partial class MainForm
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
            this.BtnProductSearch = new System.Windows.Forms.Button();
            this.BtnCategories = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnProductSearch
            // 
            this.BtnProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnProductSearch.Location = new System.Drawing.Point(41, 40);
            this.BtnProductSearch.Name = "BtnProductSearch";
            this.BtnProductSearch.Size = new System.Drawing.Size(293, 120);
            this.BtnProductSearch.TabIndex = 1;
            this.BtnProductSearch.Text = "Search Products";
            this.BtnProductSearch.UseVisualStyleBackColor = true;
            this.BtnProductSearch.Click += new System.EventHandler(this.BtnProductSearch_Click);
            // 
            // BtnCategories
            // 
            this.BtnCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnCategories.Location = new System.Drawing.Point(41, 187);
            this.BtnCategories.Name = "BtnCategories";
            this.BtnCategories.Size = new System.Drawing.Size(293, 120);
            this.BtnCategories.TabIndex = 1;
            this.BtnCategories.Text = "Categories";
            this.BtnCategories.UseVisualStyleBackColor = true;
            this.BtnCategories.Click += new System.EventHandler(this.BtnCategories_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Participation5.Properties.Resources.ProductMainForm;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(767, 792);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 462);
            this.Controls.Add(this.BtnCategories);
            this.Controls.Add(this.BtnProductSearch);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnProductSearch;
        private System.Windows.Forms.Button BtnCategories;
    }
}

