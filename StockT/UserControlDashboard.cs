using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockT
{
    public partial class UserControlDashboard : MetroFramework.Controls.MetroUserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void ktgTile_Click(object sender, EventArgs e)
        {
            if (!MainViewPage.Instance.MetroContainer.Controls.ContainsKey("UserControlCategory"))
            {
                UserControlCategory controlCategory = new UserControlCategory();
                controlCategory.Dock = DockStyle.Fill;
                MainViewPage.Instance.MetroContainer.Controls.Add(controlCategory);
            }
            MainViewPage.Instance.MetroContainer.Controls["UserControlCategory"].BringToFront();
            MainViewPage.Instance.MetroBack.Visible = true;
        }
        private void productTile_Click(object sender, EventArgs e)
        {
            ProductUserControl productUser = new ProductUserControl();
            productUser.Show(); 
            
        }
        private void musteriTile_Click(object sender, EventArgs e)
        {
            CustomerUserControl customerUser = new CustomerUserControl();
            customerUser.Show();

        }

        private void UserControlDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
