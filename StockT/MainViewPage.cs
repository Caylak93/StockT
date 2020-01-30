using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace StockT
{
    public partial class MainViewPage : MetroFramework.Forms.MetroForm
    {
        
        static MainViewPage _instance;
        
        public static MainViewPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainViewPage();
                return _instance;
            }

        }

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return metroPanel1; }
            set { metroPanel1 = value; }
        }

        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return metroLink1; }
            set { metroLink1 = value;}
        }


        public MainViewPage()
        {
            InitializeComponent();
        }

        private void MainViewPage_Load(object sender, EventArgs e)
        {
            metroLink1.Visible = false;
            _instance = this;
            UserControlDashboard controlDashboard = new UserControlDashboard();
            controlDashboard.Dock = DockStyle.Fill;
            metroPanel1.Controls.Add(controlDashboard);

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            metroPanel1.Controls["UserControlDashboard"].BringToFront();
            metroLink1.Visible = false;
        }

        private void MainViewPage_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
