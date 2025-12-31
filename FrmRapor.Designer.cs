namespace MarketOtomasyon
{
    partial class FrmZRaporu
    {
        

       

        private void InitializeComponent()
        {
            // --- FORM AYARLARI --- STIL
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmRapor";
            this.Text = "Rapor Yönetimi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnRaporla = new DevExpress.XtraEditors.SimpleButton();
            this.deTarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtOnizleme = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOnizleme.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.txtOnizleme);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(900, 550);
            this.splitContainerControl1.SplitterPosition = 280;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnRaporla);
            this.groupControl1.Controls.Add(this.deTarih);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(280, 550);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Rapor Parametreleri";
            // 
            // btnRaporla
            // 
            this.btnRaporla.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnRaporla.Appearance.Options.UseFont = true;
            
            this.btnRaporla.Location = new System.Drawing.Point(12, 114);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(250, 50);
            this.btnRaporla.TabIndex = 2;
            this.btnRaporla.Text = "Z RAPORU OLUŞTUR";
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // deTarih
            // 
            this.deTarih.EditValue = null;
            this.deTarih.Location = new System.Drawing.Point(12, 69);
            this.deTarih.Name = "deTarih";
            this.deTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.deTarih.Properties.Appearance.Options.UseFont = true;
            this.deTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTarih.Size = new System.Drawing.Size(250, 24);
            this.deTarih.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Rapor Tarihi Seçin:";
            // 
            // txtOnizleme
            // 
            this.txtOnizleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOnizleme.Location = new System.Drawing.Point(0, 0);
            this.txtOnizleme.Name = "txtOnizleme";
            this.txtOnizleme.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 10.5F); // Fiş hizalaması için kritik
            this.txtOnizleme.Properties.Appearance.Options.UseFont = true;
            this.txtOnizleme.Properties.ReadOnly = true;
            this.txtOnizleme.Size = new System.Drawing.Size(610, 550);
            this.txtOnizleme.TabIndex = 0;
            // 
            // FrmZRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmZRaporu";
            this.Text = "Gün Sonu (Z) Raporu";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOnizleme.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnRaporla;
        private DevExpress.XtraEditors.DateEdit deTarih;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtOnizleme;
    }
}