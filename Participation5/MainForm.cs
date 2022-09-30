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
    // derived class MainForm, from Form
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// opens product search form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProductSearch_Click(object sender, EventArgs e)
        {
            // when button is clicked, create new instance of class ProductForm called productForm and show the form window
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
            
        }

        /// <summary>
        /// opens categories form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCategories_Click(object sender, EventArgs e)
        {
            // when button is clicked create new instance of class CountCategoriesForm called countCategoriesForm and show the
            //window
            CountCategoriesForm countCategoriesForm = new CountCategoriesForm();
            countCategoriesForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
