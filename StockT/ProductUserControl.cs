using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Lib;
using Service.Lib.Model;

namespace StockT
{
    public partial class ProductUserControl : MetroFramework.Forms.MetroForm
    {
        
        public ProductUserControl()
        {
            InitializeComponent();
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductModel productModel = new ProductModel
            {
                ProductName = txtProductName.Text,
                QuantityPerUnit = txtQuantityPerUnit.Text,
                UnitPrice = Convert.ToInt32(txtUnitPrice.Text),
                Discontinued = (string) metroComboBox1.SelectedItem == "var",
                
                
            };

            ProductService service = new ProductService();
            service.Add(productModel);
            



        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            }

                

        }
    }

