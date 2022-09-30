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
    public partial class CountCategoriesForm : Form
    {
        // create new instance of MyProductsDb class called db
        MyProductsDb db = new MyProductsDb();
        public CountCategoriesForm()
        {
            InitializeComponent();
            //add columns to List View
            LvCategories.Columns.Add("Cateogry");
            LvCategories.Columns.Add("Total Count");    
        }
        /// <summary>
        /// total each category and display it in the list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountCategoriesForm_Load(object sender, EventArgs e)
        {
            // creatte a list of the Total class called categories using the cat column in db.Products
            List<Total> categories = (from cat in db.Products
                              group cat.Category by cat.Category into c
                              select new Total { Category = c.Key, CategoryTotal = c.Count() } ).ToList();

            //List<Total> catg = db.Products.GroupBy(x => x.Category).Select(x => new Total { Category = x.Key, CategoryTotal = x.Count().}).ToList();

            foreach (Total item in categories)
            {
                string[] listItems = { item.Category, item.CategoryTotal.ToString() };
                ListViewItem lvi = new ListViewItem(listItems);
                LvCategories.Items.Add(lvi);

            }
            LvCategories.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            LvCategories.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
