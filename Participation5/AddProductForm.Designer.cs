namespace Participation5
{
    partial class AddProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.TxtBoxPrice = new System.Windows.Forms.TextBox();
            this.TxtBoxUnitsOnHand = new System.Windows.Forms.TextBox();
            this.TxtBoxProductDesc = new System.Windows.Forms.TextBox();
            this.TxtBoxProductNum = new System.Windows.Forms.TextBox();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtBoxNewCategory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(90, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(150, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(109, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Units On Hand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(225, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(176, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(520, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "New";
            // 
            // CbCategory
            // 
            this.CbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(306, 268);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(208, 39);
            this.CbCategory.TabIndex = 1;
            this.CbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // TxtBoxPrice
            // 
            this.TxtBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TxtBoxPrice.Location = new System.Drawing.Point(307, 216);
            this.TxtBoxPrice.Name = "TxtBoxPrice";
            this.TxtBoxPrice.Size = new System.Drawing.Size(464, 38);
            this.TxtBoxPrice.TabIndex = 2;
            // 
            // TxtBoxUnitsOnHand
            // 
            this.TxtBoxUnitsOnHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TxtBoxUnitsOnHand.Location = new System.Drawing.Point(307, 160);
            this.TxtBoxUnitsOnHand.Name = "TxtBoxUnitsOnHand";
            this.TxtBoxUnitsOnHand.Size = new System.Drawing.Size(464, 38);
            this.TxtBoxUnitsOnHand.TabIndex = 2;
            // 
            // TxtBoxProductDesc
            // 
            this.TxtBoxProductDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TxtBoxProductDesc.Location = new System.Drawing.Point(307, 98);
            this.TxtBoxProductDesc.Name = "TxtBoxProductDesc";
            this.TxtBoxProductDesc.Size = new System.Drawing.Size(464, 38);
            this.TxtBoxProductDesc.TabIndex = 2;
            // 
            // TxtBoxProductNum
            // 
            this.TxtBoxProductNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TxtBoxProductNum.Location = new System.Drawing.Point(306, 43);
            this.TxtBoxProductNum.Name = "TxtBoxProductNum";
            this.TxtBoxProductNum.Size = new System.Drawing.Size(464, 38);
            this.TxtBoxProductNum.TabIndex = 2;
            this.TxtBoxProductNum.TextChanged += new System.EventHandler(this.TxtBoxProductNum_TextChanged);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnAddProduct.Location = new System.Drawing.Point(307, 333);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(464, 42);
            this.BtnAddProduct.TabIndex = 3;
            this.BtnAddProduct.Text = "Add";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnCancel.Location = new System.Drawing.Point(566, 396);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(205, 42);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtBoxNewCategory
            // 
            this.TxtBoxNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TxtBoxNewCategory.Location = new System.Drawing.Point(592, 269);
            this.TxtBoxNewCategory.Name = "TxtBoxNewCategory";
            this.TxtBoxNewCategory.Size = new System.Drawing.Size(179, 38);
            this.TxtBoxNewCategory.TabIndex = 2;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAddProduct);
            this.Controls.Add(this.TxtBoxProductNum);
            this.Controls.Add(this.TxtBoxProductDesc);
            this.Controls.Add(this.TxtBoxUnitsOnHand);
            this.Controls.Add(this.TxtBoxPrice);
            this.Controls.Add(this.TxtBoxNewCategory);
            this.Controls.Add(this.CbCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.TextBox TxtBoxPrice;
        private System.Windows.Forms.TextBox TxtBoxUnitsOnHand;
        private System.Windows.Forms.TextBox TxtBoxProductDesc;
        private System.Windows.Forms.TextBox TxtBoxProductNum;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtBoxNewCategory;
    }
}