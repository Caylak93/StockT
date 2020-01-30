using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace StockClient
{
    public partial class MainPage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddCategoryViewPage page = new AddCategoryViewPage();
            page.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchCategoryViewPage page = new SearchCategoryViewPage();
            page.Show();
        }
    }
}