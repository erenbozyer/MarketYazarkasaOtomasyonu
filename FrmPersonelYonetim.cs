using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MarketOtomasyon.BL;

namespace MarketOtomasyon
{
    public partial class FrmPersonelYonetim : DevExpress.XtraEditors.XtraForm
    {
        int secilenID = -1;

        public FrmPersonelYonetim()
        {
            InitializeComponent();
            Listele();
        }

        void Listele()
        {
            gridControl1.DataSource = PersonelManager.KullanicilariGetir();
        }

        void Temizle()
        {
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            cmbRol.SelectedIndex = -1;
            secilenID = -1;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (PersonelManager.KullaniciEkle(txtKullaniciAdi.Text, txtSifre.Text, cmbRol.Text))
            {
                XtraMessageBox.Show("Personel başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenID != -1)
            {
                if (PersonelManager.KullaniciGuncelle(secilenID, txtKullaniciAdi.Text, txtSifre.Text, cmbRol.Text))
                {
                    XtraMessageBox.Show("Personel güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    Temizle();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenID != -1)
            {
                DialogResult sor = XtraMessageBox.Show("Seçili personeli silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sor == DialogResult.Yes)
                {
                    PersonelManager.KullaniciSil(secilenID);
                    Listele();
                    Temizle();
                }
            }
        }

        // Grid'den satır seçildiğinde kutuları doldur
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                secilenID = Convert.ToInt32(dr["KullaniciID"]);
                txtKullaniciAdi.Text = dr["KullaniciAdi"].ToString();
                txtSifre.Text = dr["Sifre"].ToString();
                cmbRol.Text = dr["Rol"].ToString();
            }
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}