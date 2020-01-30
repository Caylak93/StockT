using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Lib;
using Service.Lib.Model;
using Service.Lib.Model.Request;

namespace StockT
{
    public partial class AddCustomerViewPage : Form
    {
        //readonly CustomerService svc = new CustomerService();
        public AddCustomerViewPage()
        {
           
            InitializeComponent();
        }

        private void AddCustomerViewPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerAddRequest request = new CustomerAddRequest
            {
                CustomerModel = new CustomerModel
                {
                    
                    Address = "Yenımahalle",
                    City = "Ankara",
                    CompanyName = "TcHealth",
                    Country = "Turkiye",
                    ContactName = "Onur",
                    ContactTitle = "Hacı",
                    Fax = "Cekme",
                    Phone = "00000",
                    PostalCode = "0005415",
                    Region = "Tr"

                }

               
            };
            
            //var result = svc.AddCustomer(request);
            //if (result.SaveCount > 0)
            //    MessageBox.Show("işlem başarılı");
            //else
            //    MessageBox.Show("İşlem Başarısız");
           
          
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
          
        }


        }

    }

