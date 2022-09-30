namespace Participation5
{
    partial class ProductForm
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
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxSearch = new System.Windows.Forms.TextBox();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.CbProductNum = new System.Windows.Forms.ComboBox();
            this.BtnDeleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProducts
            // 
            this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducts.Location = new System.Drawing.Point(13, 13);
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.Size = new System.Drawing.Size(973, 347);
            this.DgvProducts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Description:";
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxtBoxSearch.Location = new System.Drawing.Point(214, 393);
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.Size = new System.Drawing.Size(498, 32);
            this.TxtBoxSearch.TabIndex = 2;
            this.TxtBoxSearch.TextChanged += new System.EventHandler(this.TxtBoxSearch_TextChanged);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BtnAddProduct.Location = new System.Drawing.Point(740, 391);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(246, 34);
            this.BtnAddProduct.TabIndex = 3;
            this.BtnAddProduct.Text = "Add Product";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // CbProductNum
            // 
            this.CbProductNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CbProductNum.FormattingEnabled = true;
            this.CbProductNum.Location = new System.Drawing.Point(425, 452);
            this.CbProductNum.Name = "CbProductNum";
            this.CbProductNum.Size = new System.Drawing.Size(287, 33);
            this.CbProductNum.TabIndex = 4;
            this.CbProductNum.SelectedIndexChanged += new System.EventHandler(this.CbProductNum_SelectedIndexChanged);
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BtnDeleteProduct.Location = new System.Drawing.Point(740, 452);
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.Size = new System.Drawing.Size(246, 33);
            this.BtnDeleteProduct.TabIndex = 5;
            this.BtnDeleteProduct.Text = "Delete Product";
            this.BtnDeleteProduct.UseVisualStyleBackColor = true;
            this.BtnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 553);
            this.Controls.Add(this.BtnDeleteProduct);
            this.Controls.Add(this.CbProductNum);
            this.Controls.Add(this.BtnAddProduct);
            this.Controls.Add(this.TxtBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvProducts);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxSearch;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.ComboBox CbProductNum;
        private System.Windows.Forms.Button BtnDeleteProduct;
    }
}