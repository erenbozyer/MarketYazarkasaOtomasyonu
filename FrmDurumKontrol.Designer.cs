namespace MarketOtomasyon
{
    partial class FrmDurumKontrol
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
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            splitMain = new DevExpress.XtraEditors.SplitContainerControl();
            splitTop = new DevExpress.XtraEditors.SplitContainerControl();
            groupStok = new DevExpress.XtraEditors.GroupControl();
            gridStok = new DevExpress.XtraGrid.GridControl();
            gridViewStok = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupHaftalik = new DevExpress.XtraEditors.GroupControl();
            chartHaftalik = new DevExpress.XtraCharts.ChartControl();
            groupGunluk = new DevExpress.XtraEditors.GroupControl();
            chartGunluk = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitMain.Panel1).BeginInit();
            splitMain.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain.Panel2).BeginInit();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitTop.Panel1).BeginInit();
            splitTop.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitTop.Panel2).BeginInit();
            splitTop.Panel2.SuspendLayout();
            splitTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupStok).BeginInit();
            groupStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupHaftalik).BeginInit();
            groupHaftalik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartHaftalik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupGunluk).BeginInit();
            groupGunluk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGunluk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pieSeriesView1).BeginInit();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            splitMain.Horizontal = false;
            splitMain.Location = new System.Drawing.Point(0, 0);
            splitMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(splitTop);
            splitMain.Panel1.Text = "Panel1";
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(groupGunluk);
            splitMain.Panel2.Text = "Panel2";
            splitMain.Size = new System.Drawing.Size(1381, 937);
            splitMain.SplitterPosition = 492;
            splitMain.TabIndex = 0;
            // 
            // splitTop
            // 
            splitTop.Dock = System.Windows.Forms.DockStyle.Fill;
            splitTop.Location = new System.Drawing.Point(0, 0);
            splitTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            splitTop.Name = "splitTop";
            // 
            // splitTop.Panel1
            // 
            splitTop.Panel1.Controls.Add(groupStok);
            splitTop.Panel1.Text = "Panel1";
            // 
            // splitTop.Panel2
            // 
            splitTop.Panel2.Controls.Add(groupHaftalik);
            splitTop.Panel2.Text = "Panel2";
            splitTop.Size = new System.Drawing.Size(1381, 492);
            splitTop.SplitterPosition = 583;
            splitTop.TabIndex = 0;
            // 
            // groupStok
            // 
            groupStok.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            groupStok.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon;
            groupStok.AppearanceCaption.Options.UseFont = true;
            groupStok.AppearanceCaption.Options.UseForeColor = true;
            groupStok.Controls.Add(gridStok);
            groupStok.Dock = System.Windows.Forms.DockStyle.Fill;
            groupStok.Location = new System.Drawing.Point(0, 0);
            groupStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupStok.Name = "groupStok";
            groupStok.Size = new System.Drawing.Size(583, 492);
            groupStok.TabIndex = 0;
            groupStok.Text = "Kritik Stok Uyarıları";
            // 
            // gridStok
            // 
            gridStok.Dock = System.Windows.Forms.DockStyle.Fill;
            gridStok.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gridStok.Location = new System.Drawing.Point(2, 28);
            gridStok.MainView = gridViewStok;
            gridStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gridStok.Name = "gridStok";
            gridStok.Size = new System.Drawing.Size(579, 462);
            gridStok.TabIndex = 0;
            gridStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewStok });
            // 
            // gridViewStok
            // 
            gridViewStok.DetailHeight = 431;
            gridViewStok.GridControl = gridStok;
            gridViewStok.Name = "gridViewStok";
            gridViewStok.OptionsBehavior.Editable = false;
            gridViewStok.OptionsEditForm.PopupEditFormWidth = 933;
            gridViewStok.OptionsView.ShowGroupPanel = false;
            // 
            // groupHaftalik
            // 
            groupHaftalik.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            groupHaftalik.AppearanceCaption.Options.UseFont = true;
            groupHaftalik.Controls.Add(chartHaftalik);
            groupHaftalik.Dock = System.Windows.Forms.DockStyle.Fill;
            groupHaftalik.Location = new System.Drawing.Point(0, 0);
            groupHaftalik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupHaftalik.Name = "groupHaftalik";
            groupHaftalik.Size = new System.Drawing.Size(786, 492);
            groupHaftalik.TabIndex = 0;
            groupHaftalik.Text = "Haftanın En Çok Satan Ürünleri (Popülerlik Analizi)";
            // 
            // chartHaftalik
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            chartHaftalik.Diagram = xyDiagram1;
            chartHaftalik.Dock = System.Windows.Forms.DockStyle.Fill;
            chartHaftalik.Legend.Name = "Default Legend";
            chartHaftalik.Location = new System.Drawing.Point(2, 28);
            chartHaftalik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            chartHaftalik.Name = "chartHaftalik";
            series1.Name = "Satış Adedi";
            series1.SeriesID = 0;
            chartHaftalik.SeriesSerializable = new DevExpress.XtraCharts.Series[]
    {
    series1
    };
            chartHaftalik.Size = new System.Drawing.Size(782, 462);
            chartHaftalik.TabIndex = 0;
            // 
            // groupGunluk
            // 
            groupGunluk.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            groupGunluk.AppearanceCaption.Options.UseFont = true;
            groupGunluk.Controls.Add(chartGunluk);
            groupGunluk.Dock = System.Windows.Forms.DockStyle.Fill;
            groupGunluk.Location = new System.Drawing.Point(0, 0);
            groupGunluk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupGunluk.Name = "groupGunluk";
            groupGunluk.Size = new System.Drawing.Size(1381, 433);
            groupGunluk.TabIndex = 0;
            groupGunluk.Text = "Günlük Kasa Durumu (Nakit / Kredi Kartı Dağılımı)";
            // 
            // chartGunluk
            // 
            chartGunluk.Dock = System.Windows.Forms.DockStyle.Fill;
            chartGunluk.Legend.Name = "Default Legend";
            chartGunluk.Location = new System.Drawing.Point(2, 28);
            chartGunluk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            chartGunluk.Name = "chartGunluk";
            series2.Name = "Ödeme Tipi";
            series2.SeriesID = 0;
            series2.View = pieSeriesView1;
            chartGunluk.SeriesSerializable = new DevExpress.XtraCharts.Series[]
    {
    series2
    };
            chartGunluk.Size = new System.Drawing.Size(1377, 403);
            chartGunluk.TabIndex = 0;
            // 
            // FrmDurumKontrol
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1381, 937);
            Controls.Add(splitMain);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "FrmDurumKontrol";
            Text = "Market Durum Kontrol Paneli (Dashboard)";
            ((System.ComponentModel.ISupportInitialize)splitMain.Panel1).EndInit();
            splitMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain.Panel2).EndInit();
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitTop.Panel1).EndInit();
            splitTop.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitTop.Panel2).EndInit();
            splitTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitTop).EndInit();
            splitTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupStok).EndInit();
            groupStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupHaftalik).EndInit();
            groupHaftalik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).EndInit();
            ((System.ComponentModel.ISupportInitialize)series1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartHaftalik).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupGunluk).EndInit();
            groupGunluk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pieSeriesView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)series2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartGunluk).EndInit();
            ResumeLayout(false);

        }

        private DevExpress.XtraEditors.SplitContainerControl splitMain;
        private DevExpress.XtraEditors.SplitContainerControl splitTop;
        private DevExpress.XtraEditors.GroupControl groupStok;
        private DevExpress.XtraGrid.GridControl gridStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStok;
        private DevExpress.XtraEditors.GroupControl groupHaftalik;
        private DevExpress.XtraCharts.ChartControl chartHaftalik;
        private DevExpress.XtraEditors.GroupControl groupGunluk;
        private DevExpress.XtraCharts.ChartControl chartGunluk;
    }
}