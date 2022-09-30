using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Participation5
{
    public partial class AddProductForm : Form
    {
        // create an instance of the class MyProductsDb called db
        MyProductsDb db = new MyProductsDb();
        public AddProductForm()
        {
            InitializeComponent();
        }

      
        // load event

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            // grab a list of categories from db.Products and pass them to the variable CatItems. pass catItems to the
            // CbCategory combobox array
            var catItems = (from cat in db.Products
                            where cat.Category != null
                            group cat.Category by cat.Category into c
                            select new { Category = c.Key });
            CbCategory.Items.AddRange(catItems.Select(x => x.Category).ToArray());
            CbCategory.Items.Add("New Category");
        }
        // select cateogry for new product
        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbCategory.SelectedItem.ToString() == "New Category")
            {
                TxtBoxNewCategory.Show();
                //LblNewCat.Hide();
                
            }
        }

        /// <summary>
        /// pressing this button will add all new values to the database if the criteria are met
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            // create a decimal called price and set it to 0, and int called uoh and set it to zero
            // create strings productID, description, and category and set them all to an empty string
            decimal price = 0;
            int uoh = 0;
            string productId = "", description = "", category = "";

            //if price is a decimal, uoh is  an int, and product ID is an int
            if (ValidPrice(ref price) && 
                ValidUOH(ref uoh) && 
                ValidProductId(ref productId))
            {
                // if a category is selected
                category = CbCategory.SelectedIndex > -1 ?
                    // take the category selected
                    CbCategory.SelectedItem.ToString():"";
                // description = the text in the TxtBoxProductDesc

                description = TxtBoxProductDesc.Text;
                // add all values as a new prodcut (record, or row) to database
                    AddProductToDataBase(productId, description, uoh, price, category);
               
            }
        }
        /// <summary>
        /// method for adding new product to database
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="description"></param>
        /// <param name="uoh"></param>
        /// <param name="price"></param>
        /// <param name="category"></param>
        private void AddProductToDataBase(string productId, string description, int uoh, decimal price, string category)
        {
            // create new instance of Product class called product
            Product product = new Product
            {
                // set the category property in the product instance of Product to the value found in the string category
                Category = category,
                // set the Description property in the product instance of Product to the value found in the string description
                Description = description,
                // set the Price property in the product instance of Product to the value found in the decimal price
                Price = price,
                // set the Product_Number property in the product instance of Product to the value found in the string productId
                Product_Number = productId,
                // set the Units_On_Hand property in the product instance of Product to the value found in the string uoh
                Units_On_Hand = uoh
            };
            // add the instance product to db.Products
            db.Products.Add(product);
            // save changes
            db.SaveChanges();
            // close window
            this.Close();
        }

        /// <summary>
        /// validates productID
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        private bool ValidProductId(ref string productID)
        {
            // if the number of items (numbers, letters, symbols) found in TxtBoxProductNum is less than or = to 5 run code
            if (TxtBoxProductNum.Text.Count() <= 5)
            {
                // set productID to the string found in TxtBoxProductNum.Text
                productID = TxtBoxProductNum.Text;
                // return the boolean value true
                return true;
            }
            // if that does not happen this code will run, valid product number will be requested, 
            MessageBox.Show("Please enter a valid product number (example: 11-11");
            // return false
            return false;
        }

        /// <summary>
        /// validates uoh
        /// </summary>
        /// <param name="uoh"></param>
        /// <returns></returns>
        private bool ValidUOH(ref int uoh)
        {
            // if you can parse the text in txtboxunitsonhand as an integer, return true, and output the number as integer uoh
            //if not, show message box and return false
            if (int.TryParse(TxtBoxUnitsOnHand.Text, out uoh)) return true;           
            MessageBox.Show("Please enter an integer for the units on hand");            
            return false;
        }

        /// <summary>
        /// validaete price
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        private bool ValidPrice(ref decimal price)
        {
            // if you can parse the text found in TxtBoxPrice as a decimal, return true and output the decimal as the 
            //decimal price. If not show messageboxx and return false
            if (decimal.TryParse(TxtBoxPrice.Text, out price))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a number for the price");
            }
            return false;
        }

        /// <summary>
        /// cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {

            // when button is clicked, close this window.
            this.Close();
        }

        private void TxtBoxProductNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
