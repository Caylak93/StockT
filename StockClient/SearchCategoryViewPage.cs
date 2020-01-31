using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Service.Lib;
using Service.Lib.Model;

namespace StockClient
{
    public partial class SearchCategoryViewPage : DevExpress.XtraEditors.XtraForm
    {
        public SearchCategoryViewPage()
        {
            InitializeComponent();
        }

        private void checkButton4_CheckedChanged(object sender, EventArgs e)
        {
            CategoryService service = new CategoryService();
            gridView1.DataController.DataSource = service.GetAlls();
        }

        private void SearchCategoryViewPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'connectDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.connectDataSet.Categories);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkButton2_CheckedChanged(object sender, EventArgs e)
        {
            CategoryService service = new CategoryService();
            CategoryModel categoryModel = new CategoryModel
            {

                CategoryId = new Guid(),
                CategoryName = textEdit2.Text,
                CategoryCode = textEdit1.Text,
                Description = textEdit3.Text,
                Picture = new byte[0]
            };
           service.Delete(categoryModel);
        }
    }
}