using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Customization;
using Service.Lib;
using Service.Lib.Mapper;
using Service.Lib.Model;

namespace StockClient
{
    public partial class AddCategoryViewPage : DevExpress.XtraEditors.XtraForm
    {
        public AddCategoryViewPage()
        {
            InitializeComponent();
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            if (opnfd.ShowDialog() == DialogResult.OK)
                pictureEdit1.Image = new Bitmap(opnfd.FileName);
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            CategoryService service = new CategoryService();

            CategoryModel categoryModel = new CategoryModel
            {
                CategoryId = new Guid(),
                CategoryCode = textEdit1.Text,
                CategoryName = textEdit2.Text,
                Description =  textEdit3.Text,
                Picture = new byte[0]
            };
            
            service.Add(categoryModel);
           

        }

    }
}