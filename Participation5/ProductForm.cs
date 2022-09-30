using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Participation5
{
    public partial class ProductForm : Form
    {
        /// <summary>
        /// create a new instance of the MyproducsDb called db
        /// </summary>
        MyProductsDb db = new MyProductsDb();

        // create variable deleteItem
        public string deleteItem;


        /// <summary>
        /// constructor method for product form
        /// </summary>
        public ProductForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load event for ProductForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductForm_Load(object sender, EventArgs e)
        {
            //create a list of the class Prodcut called products and populate it with the Products column in dbproduucts
            List<Product> products = (from prod in db.Products
                                      select prod).ToList();
            // pass the list products to DgvProducts.Datasource making products the datasource for DgvProducts
            DgvProducts.DataSource = products;
            // adjust column width to fit contents
            AdjustColumns();

            // create a variable proNum.
            //select products from db.prodcuts by Product_Number pass to variable c. Make new ProductNumber declaring c as
            // the key and pass ProductNumber to CbProductNum Array
            var proNum = (from num in db.Products
                            where num.Product_Number != null
                            group num.Product_Number by num.Product_Number into c
                            select new { ProductNumber = c.Key });
            // Creates list for combo box
            CbProductNum.Items.AddRange(proNum.Select(x => x.ProductNumber).ToArray());
            // creates New Category option in combobox dropdown list
            CbProductNum.Items.Add("New Category");

        }

        /// <summary>
        ///  adjust column width to fit content
        /// </summary>
        private void AdjustColumns()
        {
            int columns = DgvProducts.Columns.Count;

            for (int i = 0; i < columns; i++)
            {
                DgvProducts.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        /// <summary>
        /// search box which searches for matches as you are typing text into the box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //create a list of the class Product called products which contains the letters typed in TxtBoxSearch and select those
            //products
            List<Product> products = (from prod in db.Products
                                      where prod.Description.Contains(TxtBoxSearch.Text)
                                      select prod).ToList();
            //put this list in the Data Grid View
            DgvProducts.DataSource = products;

            // adjust column width
            AdjustColumns();
        }

        /// <summary>
        /// when button is pressed add contents in cells to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            // create new instance of the AddProductForm class called addProductForm and ShowDialog

            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            // Create a List of the Product class called products 
            List<Product> products = (from prod in db.Products
                                      select prod).ToList();
            // pass the new product to the Data Grid View DgvProducts
            DgvProducts.DataSource = products;
        }

        /// <summary>
        /// select product ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CbProductNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbProductNum.SelectedItem.ToString() == "New Category")
            {
                // pass the selected item in CbProductNum to the string variable deleteItem
                deleteItem = CbProductNum.SelectedItem.ToString();
                
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {

            //Product productTable = new Product();
            // CbProductNum.SelectedItem

            //find the product Number store in the variable deleteItem in db.Products and pass it to variable p
            var p = db.Products.FirstOrDefault(x => x.Product_Number==CbProductNum.SelectedItem.ToString());
            // remove variable p from the table Products
            if (p != null)
            {
            db.Products.Remove(p);
                // save changes
                db.SaveChanges();
            }
            List<Product> products = (from prod in db.Products
                                      select prod).ToList();
            // pass the list products to DgvProducts.Datasource making products the datasource for DgvProducts
            DgvProducts.DataSource = products;
            // adjust column width to fit contents
            AdjustColumns();


            //Product product = db.Products.SingleOrDefault
            //(x => x.Product_Number == CbProductNum.SelectedItem.ToString());
            //db.Products.Remove(product);
            //db.SaveChanges();

            //"DELETE FROM db.Products WHERE ID = '" + 
            //CbProductNum_SelectedIndexChanged.SelectedValue + "'";
        }
        
        
    }
}
