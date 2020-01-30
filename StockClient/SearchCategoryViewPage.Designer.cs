namespace StockClient
{
    partial class SearchCategoryViewPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCategoryViewPage));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton2 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton3 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton4 = new DevExpress.XtraEditors.CheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(231, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1143, 588);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Kod";
            this.textEdit1.Location = new System.Drawing.Point(30, 57);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(172, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "Kategory Adı";
            this.textEdit2.Location = new System.Drawing.Point(30, 83);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(172, 20);
            this.textEdit2.TabIndex = 1;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "Açıklama";
            this.textEdit3.Location = new System.Drawing.Point(30, 109);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(172, 20);
            this.textEdit3.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(30, 158);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(172, 154);
            this.pictureEdit1.TabIndex = 2;
            // 
            // checkButton1
            // 
            this.checkButton1.Image = ((System.Drawing.Image)(resources.GetObject("checkButton1.Image")));
            this.checkButton1.Location = new System.Drawing.Point(127, 414);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(75, 53);
            this.checkButton1.TabIndex = 3;
            this.checkButton1.Text = "Düzelt";
            // 
            // checkButton2
            // 
            this.checkButton2.Image = ((System.Drawing.Image)(resources.GetObject("checkButton2.Image")));
            this.checkButton2.Location = new System.Drawing.Point(30, 414);
            this.checkButton2.Name = "checkButton2";
            this.checkButton2.Size = new System.Drawing.Size(75, 53);
            this.checkButton2.TabIndex = 3;
            this.checkButton2.Text = "Sil";
            // 
            // checkButton3
            // 
            this.checkButton3.Image = ((System.Drawing.Image)(resources.GetObject("checkButton3.Image")));
            this.checkButton3.Location = new System.Drawing.Point(30, 508);
            this.checkButton3.Name = "checkButton3";
            this.checkButton3.Size = new System.Drawing.Size(75, 45);
            this.checkButton3.TabIndex = 4;
            this.checkButton3.Text = "Yeni";
            // 
            // checkButton4
            // 
            this.checkButton4.Image = ((System.Drawing.Image)(resources.GetObject("checkButton4.Image")));
            this.checkButton4.Location = new System.Drawing.Point(127, 508);
            this.checkButton4.Name = "checkButton4";
            this.checkButton4.Size = new System.Drawing.Size(75, 45);
            this.checkButton4.TabIndex = 4;
            this.checkButton4.Text = "Yenile";
            // 
            // SearchCategoryViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 612);
            this.Controls.Add(this.checkButton4);
            this.Controls.Add(this.checkButton3);
            this.Controls.Add(this.checkButton2);
            this.Controls.Add(this.checkButton1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.gridControl1);
            this.Name = "SearchCategoryViewPage";
            this.Text = "SearchCategoryViewPage";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.CheckButton checkButton1;
        private DevExpress.XtraEditors.CheckButton checkButton2;
        private DevExpress.XtraEditors.CheckButton checkButton3;
        private DevExpress.XtraEditors.CheckButton checkButton4;



    }
}