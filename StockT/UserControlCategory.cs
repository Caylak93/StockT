using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using Service.Lib;
using Service.Lib.Mapper;
using Service.Lib.Model;


namespace StockT
{
    public partial class UserControlCategory : MetroFramework.Controls.MetroUserControl
    {
        private CategoryService service;

        public UserControlCategory()
        {
            InitializeComponent();

        }

        private void UserControlCategory_Load(object sender, EventArgs e)
        {
            gridDataSource();

        }

        private void gridDataSource()
        {
            service = new CategoryService();
            metroGrid1.DataSource = service.GetAlls();

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                var result = MessageBox.Show("Kategori adı dolu olmalıdır", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                    return;
            }
            service = new CategoryService();
            CategoryModel categoryModel = new CategoryModel
            {
                CategoryName = textBox1.Text,
                Description = textBox2.Text,
            };

            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                categoryModel.Picture = ms.ToArray();
            }
            var addResult = service.Add(categoryModel);
            if (!addResult)
            {
                var result = MessageBox.Show("Kaydetme işlemi başarısız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Kaydetme işlemi başarılı", "Uyarı", MessageBoxButtons.OK);

            clearTextBox();
            gridDataSource();
        }

        private void clearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            pictureBox1.Image = null;
            textBox1.Focus();

        }


        private void button4_Click(object sender, EventArgs e)
        {

            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);

                pictureBox1.ImageLocation = opnfd.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            CategoryModel categoryModel = new CategoryModel
            {
                CategoryId = new Guid(label4.Text),
                CategoryName = textBox1.Text,
                Description = textBox2.Text,
                Picture = new byte[] { 1}
            };

            var updateResult = service.Update(categoryModel);
            if (!updateResult)
            {
                MessageBox.Show("Kaydetme işlemi başarısız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Kaydetme işlemi başarılı", "Uyarı", MessageBoxButtons.OK);
            clearTextBox();
            gridDataSource();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryModel categoryModel = new CategoryModel
            {
                CategoryId = new Guid(label4.Text),
                CategoryName = textBox1.Text,
                Description = textBox2.Text,
                Picture = new byte[] { 1 }
            };

            var deleteResult = service.Delete(categoryModel);
            if (!deleteResult)
            {
                MessageBox.Show("Silme işlemi başarısız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Silme işlemi başarılı", "Uyarı", MessageBoxButtons.OK);
            clearTextBox();
            gridDataSource();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
