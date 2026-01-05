
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
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            btnIadeEt = new DevExpress.XtraEditors.SimpleButton();
            gridControlSatislar = new DevExpress.XtraGrid.GridControl();
            gridViewSatislar = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            gridControlDetaylar = new DevExpress.XtraGrid.GridControl();
            gridViewDetaylar = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlSatislar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewSatislar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlDetaylar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewDetaylar).BeginInit();
            SuspendLayout();
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerControl1.Horizontal = false;
            splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            splitContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(btnIadeEt);
            splitContainerControl1.Panel1.Controls.Add(gridControlSatislar);
            splitContainerControl1.Panel1.Text = "Satış Listesi";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(groupControl1);
            splitContainerControl1.Panel2.Text = "Satış Detayları";
            splitContainerControl1.Size = new System.Drawing.Size(1148, 814);
            splitContainerControl1.SplitterPosition = 431;
            splitContainerControl1.TabIndex = 0;
            // 
            // btnIadeEt
            // 
            btnIadeEt.Location = new System.Drawing.Point(13, 373);
            btnIadeEt.Margin = new System.Windows.Forms.Padding(4);
            btnIadeEt.Name = "btnIadeEt";
            btnIadeEt.Size = new System.Drawing.Size(175, 49);
            btnIadeEt.TabIndex = 0;
            btnIadeEt.Text = "Satışı İade Et";
            btnIadeEt.Click += btnIadeEt_Click;
            // 
            // gridControlSatislar
            // 
            gridControlSatislar.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControlSatislar.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridControlSatislar.Location = new System.Drawing.Point(0, 0);
            gridControlSatislar.MainView = gridViewSatislar;
            gridControlSatislar.Margin = new System.Windows.Forms.Padding(4);
            gridControlSatislar.Name = "gridControlSatislar";
            gridControlSatislar.Size = new System.Drawing.Size(1148, 431);
            gridControlSatislar.TabIndex = 0;
            gridControlSatislar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewSatislar });
            // 
            // gridViewSatislar
            // 
            gridViewSatislar.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            gridViewSatislar.Appearance.FocusedRow.Options.UseBackColor = true;
            gridViewSatislar.DetailHeight = 431;
            gridViewSatislar.GridControl = gridControlSatislar;
            gridViewSatislar.Name = "gridViewSatislar";
            gridViewSatislar.OptionsBehavior.Editable = false;
            gridViewSatislar.OptionsEditForm.PopupEditFormWidth = 933;
            gridViewSatislar.OptionsView.ShowGroupPanel = false;
            gridViewSatislar.RowStyle += gridViewSatislar_RowStyle;
            gridViewSatislar.FocusedRowChanged += gridViewSatislar_FocusedRowChanged;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(gridControlDetaylar);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl1.Location = new System.Drawing.Point(0, 0);
            groupControl1.Margin = new System.Windows.Forms.Padding(4);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(1148, 371);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Seçili Satışın Ürün Detayları";
            // 
            // gridControlDetaylar
            // 
            gridControlDetaylar.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControlDetaylar.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridControlDetaylar.Location = new System.Drawing.Point(2, 28);
            gridControlDetaylar.MainView = gridViewDetaylar;
            gridControlDetaylar.Margin = new System.Windows.Forms.Padding(4);
            gridControlDetaylar.Name = "gridControlDetaylar";
            gridControlDetaylar.Size = new System.Drawing.Size(1144, 341);
            gridControlDetaylar.TabIndex = 0;
            gridControlDetaylar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewDetaylar });
            gridControlDetaylar.Click += gridControlDetaylar_Click;
            // 
            // gridViewDetaylar
            // 
            gridViewDetaylar.DetailHeight = 431;
            gridViewDetaylar.GridControl = gridControlDetaylar;
            gridViewDetaylar.Name = "gridViewDetaylar";
            gridViewDetaylar.OptionsBehavior.Editable = false;
            gridViewDetaylar.OptionsEditForm.PopupEditFormWidth = 933;
            gridViewDetaylar.OptionsView.ShowGroupPanel = false;
            // 
            // FrmSatisGecmisi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1148, 814);
            Controls.Add(splitContainerControl1);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmSatisGecmisi";
            Text = "Satış Geçmişi ve Detaylar";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlSatislar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewSatislar).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlDetaylar).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewDetaylar).EndInit();
            ResumeLayout(false);

        }
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton btnIadeEt; // Tanım burada olmalı!
        
        private DevExpress.XtraGrid.GridControl gridControlSatislar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSatislar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlDetaylar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetaylar;
    }
}