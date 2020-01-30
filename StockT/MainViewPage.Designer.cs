namespace StockT
{
    partial class MainViewPage
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(981, 407);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseWaitCursor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 12;
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = global::StockT.Properties.Resources.icons8_go_back_48;
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroLink1.Location = new System.Drawing.Point(8, 12);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(56, 44);
            this.metroLink1.TabIndex = 1;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.UseWaitCursor = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // MainViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1027, 487);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroPanel1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "MainViewPage";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "         STOK TAKİP";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.MainViewPage_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainViewPage_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink metroLink1;

    }
}