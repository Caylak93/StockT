namespace StockClient
{
    partial class AddCategoryViewPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryViewPage));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.buttonEdit1);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.checkButton1);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(878, 508);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Kategori Ekle";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.EditValue = "Resim Ekle";
            this.buttonEdit1.Location = new System.Drawing.Point(452, 154);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(100, 20);
            this.buttonEdit1.TabIndex = 5;
            this.buttonEdit1.EditValueChanged += new System.EventHandler(this.buttonEdit1_EditValueChanged);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(217, 157);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Properties.InitialImage")));
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(229, 178);
            this.pictureEdit1.TabIndex = 4;
            // 
            // checkButton1
            // 
            this.checkButton1.Image = ((System.Drawing.Image)(resources.GetObject("checkButton1.Image")));
            this.checkButton1.Location = new System.Drawing.Point(217, 365);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(236, 50);
            this.checkButton1.TabIndex = 3;
            this.checkButton1.Text = "Kaydet";
            this.checkButton1.CheckedChanged += new System.EventHandler(this.checkButton1_CheckedChanged);
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "Açıklama";
            this.textEdit2.Location = new System.Drawing.Point(217, 131);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(229, 20);
            this.textEdit2.TabIndex = 1;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "Kodu";
            this.textEdit3.Location = new System.Drawing.Point(217, 69);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(229, 20);
            this.textEdit3.TabIndex = 0;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Adı";
            this.textEdit1.Location = new System.Drawing.Point(217, 95);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(229, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // AddCategoryViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 508);
            this.Controls.Add(this.groupControl1);
            this.Name = "AddCategoryViewPage";
            this.Text = "AddCategoryViewPage";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckButton checkButton1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;

    }
}