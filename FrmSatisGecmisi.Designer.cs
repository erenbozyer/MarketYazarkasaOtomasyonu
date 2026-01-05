namespace MarketOtomasyon
{
    partial class FrmSatisGecmisi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {   // --- FORM AYARLARI --- STIL
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmSatisGecmisi";
            this.Text = "Satış Geçmişi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;


            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlSatislar = new DevExpress.XtraGrid.GridControl();
            this.gridViewSatislar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlDetaylar = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetaylar = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetaylar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetaylar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false; // Yatay bölme (Üst-Alt)
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlSatislar);
            this.splitContainerControl1.Panel1.Text = "Satış Listesi";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Satış Detayları";
            this.splitContainerControl1.Size = new System.Drawing.Size(984, 661);
            this.splitContainerControl1.SplitterPosition = 350; // Üst panel yüksekliği
            this.splitContainerControl1.TabIndex = 0;
            // 
            // gridControlSatislar
            // 
            this.gridControlSatislar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSatislar.Location = new System.Drawing.Point(0, 0);
            this.gridControlSatislar.MainView = this.gridViewSatislar;
            this.gridControlSatislar.Name = "gridControlSatislar";
            this.gridControlSatislar.Size = new System.Drawing.Size(984, 350);
            this.gridControlSatislar.TabIndex = 0;
            this.gridControlSatislar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSatislar});
            // 
            // gridViewSatislar
            // 
            this.gridViewSatislar.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridViewSatislar.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewSatislar.GridControl = this.gridControlSatislar;
            this.gridViewSatislar.Name = "gridViewSatislar";
            this.gridViewSatislar.OptionsBehavior.Editable = false; // Düzenleme kapalı
            this.gridViewSatislar.OptionsView.ShowGroupPanel = false; // Gruplama panelini gizle
            this.gridViewSatislar.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSatislar_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlDetaylar);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(984, 301);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Seçili Satışın Ürün Detayları";
            // 
            // gridControlDetaylar
            // 
            this.gridControlDetaylar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDetaylar.Location = new System.Drawing.Point(2, 23);
            this.gridControlDetaylar.MainView = this.gridViewDetaylar;
            this.gridControlDetaylar.Name = "gridControlDetaylar";
            this.gridControlDetaylar.Size = new System.Drawing.Size(980, 276);
            this.gridControlDetaylar.TabIndex = 0;
            this.gridControlDetaylar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetaylar});
            // 
            // gridViewDetaylar
            // 
            this.gridViewDetaylar.GridControl = this.gridControlDetaylar;
            this.gridViewDetaylar.Name = "gridViewDetaylar";
            this.gridViewDetaylar.OptionsBehavior.Editable = false;
            this.gridViewDetaylar.OptionsView.ShowGroupPanel = false;
            // 
            // FrmSatisGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmSatisGecmisi";
            this.Text = "Satış Geçmişi ve Detaylar";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetaylar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetaylar)).EndInit();
            this.ResumeLayout(false);

        }

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlSatislar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSatislar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlDetaylar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetaylar;
    }
}