using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Lib;
using Service.Lib.Model;

namespace StockT
{
    public partial class CustomerUserControl : UserControl
    {
        public CustomerUserControl()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerUserControl_Load(object sender, EventArgs e)
        {

        }
        private void gridDataSource()
        {
            CustomerService service = new CustomerService();
            metroGrid1.DataSource = service.GetAlls();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCity.Text) && string.IsNullOrEmpty(txtCompanyName.Text) && string.IsNullOrEmpty(txtRegion.Text) && string.IsNullOrEmpty(txtContactTitle.Text) && string.IsNullOrEmpty(txtCountry.Text) && string.IsNullOrEmpty(txtPhone.Text) && string.IsNullOrEmpty(txtAdress.Text) && string.IsNullOrEmpty(txtFax.Text) && string.IsNullOrEmpty(txtPostalCode.Text))
            {
                var result = MessageBox.Show("Bu alanlar dolu olmalıdır", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                    return;
            }
            CustomerService service = new CustomerService();
            CustomerModel customerModel = new CustomerModel
            {
                
                
            };

          
            var addResult = service.Add(customerModel);
            if (!addResult)
            {
                var result = MessageBox.Show("Kaydetme işlemi başarısız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Kaydetme işlemi başarılı", "Uyarı", MessageBoxButtons.OK);

            gridDataSource();
            
        }
    }
}
