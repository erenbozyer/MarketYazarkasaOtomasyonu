namespace MarketOtomasyon
{
    partial class FrmPersonelYonetim
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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            btnEkle = new DevExpress.XtraEditors.SimpleButton();
            cmbRol = new DevExpress.XtraEditors.ComboBoxEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtSifre = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbRol.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSifre.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAdi.Properties).BeginInit();

            // --- FORM AYARLARI --- STIL
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmPersonelYonetim";
            this.Text = "personel Yönetimi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;


            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gridControl1.Location = new System.Drawing.Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(747, 690);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            gridView1.DetailHeight = 431;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(btnTemizle);
            groupControl1.Controls.Add(btnSil);
            groupControl1.Controls.Add(btnGuncelle);
            groupControl1.Controls.Add(btnEkle);
            groupControl1.Controls.Add(cmbRol);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(txtSifre);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(txtKullaniciAdi);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupControl1.Location = new System.Drawing.Point(747, 0);
            groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(401, 690);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "Personel Bilgileri";
            // 
            // btnTemizle
            // 
            btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            btnTemizle.Appearance.Options.UseFont = true;
            btnTemizle.Location = new System.Drawing.Point(117, 363);
            btnTemizle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new System.Drawing.Size(253, 43);
            btnTemizle.TabIndex = 9;
            btnTemizle.Text = "Temizle";
            // 
            // btnSil
            // 
            btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            btnSil.Appearance.Options.UseFont = true;
            btnSil.Location = new System.Drawing.Point(117, 313);
            btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(253, 43);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            btnGuncelle.Appearance.Options.UseFont = true;
            btnGuncelle.Location = new System.Drawing.Point(117, 262);
            btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new System.Drawing.Size(253, 43);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            btnEkle.Appearance.Options.UseFont = true;
            btnEkle.Location = new System.Drawing.Point(117, 212);
            btnEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(253, 43);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Kaydet";
            btnEkle.Click += btnEkle_Click;
            // 
            // cmbRol
            // 
            cmbRol.Location = new System.Drawing.Point(117, 154);
            cmbRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            cmbRol.Name = "cmbRol";
            cmbRol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbRol.Properties.Items.AddRange(new object[] { "MUDUR", "KASIYER" });
            cmbRol.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cmbRol.Size = new System.Drawing.Size(253, 22);
            cmbRol.TabIndex = 5;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(21, 158);
            labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(23, 16);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Rol:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new System.Drawing.Point(117, 108);
            txtSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.Properties.UseSystemPasswordChar = true;
            txtSifre.Size = new System.Drawing.Size(253, 22);
            txtSifre.TabIndex = 3;
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(21, 112);
            labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(32, 16);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new System.Drawing.Point(117, 64);
            txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new System.Drawing.Size(253, 22);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(21, 68);
            labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(73, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Kullanıcı Adı:";
            // 
            // FrmPersonelYonetim
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1148, 690);
            Controls.Add(groupControl1);
            Controls.Add(gridControl1);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "FrmPersonelYonetim";
            Text = "Personel Yönetimi";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbRol.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSifre.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAdi.Properties).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbRol;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
    }
}