namespace Participation5
{
    partial class CountCategoriesForm
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.LvCategories = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnClose.Location = new System.Drawing.Point(12, 353);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(365, 76);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LvCategories
            // 
            this.LvCategories.FullRowSelect = true;
            this.LvCategories.GridLines = true;
            this.LvCategories.HideSelection = false;
            this.LvCategories.Location = new System.Drawing.Point(13, 13);
            this.LvCategories.Name = "LvCategories";
            this.LvCategories.Size = new System.Drawing.Size(364, 334);
            this.LvCategories.TabIndex = 0;
            this.LvCategories.UseCompatibleStateImageBehavior = false;
            this.LvCategories.View = System.Windows.Forms.View.Details;
            // 
            // CountCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 439);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LvCategories);
            this.Name = "CountCategoriesForm";
            this.Text = "CountCategoriesForm";
            this.Load += new System.EventHandler(this.CountCategoriesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ListView LvCategories;
    }
}