using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsTP
{
    public partial class frmSeferIslemleri : Form
    {
        public frmSeferIslemleri()
        {
            InitializeComponent();
        }

        int seciliID;
        bool guncelleme = false;
        private void frmSeferIslemleri_Load(object sender, EventArgs e)
        {
            Sefer sefer = new Sefer();
            DataTable dtOtobusler = sefer.OtobusDoldur();
            cmbOtobus.DataSource = dtOtobusler;
            DataTable dtKalkis = sefer.TerminalDoldur();
            cmbKalkis.DataSource = dtKalkis;
            DataTable dtVaris = sefer.TerminalDoldur();
            cmbVaris.DataSource = dtVaris;
            dtGidisTarih.MinDate = DateTime.Now;
            cmbKalkis.Text = "Seçiniz";
            cmbVaris.Text = "Seçiniz";
            cmbOtobus.Text = "Seçiniz";
            Goster();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbOtobus.Text == "Seçiniz" || cmbKalkis.Text == "Seçiniz" || cmbVaris.Text == "Seçiniz" || t_bKod.Text == "" || t_hSure.Text == "" || t_fiyat.Text == "")
            {
                MessageBox.Show("Bilgileri eksik girdiniz");
                return;
            }
            string gidisTarih = dtGidisTarih.Value.ToString("yyyy-MM-dd");
            string gidisSaat = txtGidisSaat.Text + ":" + txtGidisDakika.Text;
            string gidisTS = gidisTarih + " " + gidisSaat;

            int kalTerminal_id = Convert.ToInt32(cmbKalkis.SelectedValue);
            int varTerminal_id = Convert.ToInt32(cmbVaris.SelectedValue);

            string bKod = t_bKod.Text;

            int hSure = Convert.ToInt32(t_hSure.Text);
            int fiyat = 0;
            string f = t_fiyat.Text;

            int otobusID = Convert.ToInt32(cmbOtobus.SelectedValue);

            if (guncelleme == true)
            {
                fiyat = Convert.ToInt32(f.Remove(f.Length - 5));
            }
            else
                fiyat = Convert.ToInt32(t_fiyat.Text);

            Sefer sefer = new Sefer(gidisTS, kalTerminal_id, varTerminal_id, bKod, hSure, fiyat, otobusID);
            sefer.setKalanKoltuk(otobusID);
            if(guncelleme == true)
            {
                
                sefer.Guncelle(seciliID);
                MessageBox.Show("Kayıt Başarıyla Güncellendi.", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               
            }
            else
            {
                sefer.Kaydet();
                MessageBox.Show("Kayıt Başarıyla Eklendi.", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
            Goster();
            
        }

        void biletUret()
        {
            string idx = "";
            try
            {
                idx = (Convert.ToInt32(dgvSeferler.Rows[dgvSeferler.RowCount - 1].Cells[0].Value) + 1).ToString();
                t_bKod.Text = string.Concat(cmbKalkis.Text[0], cmbVaris.Text[0], idx);
            }
            catch { }
        }

        void Goster()
        {
            Sefer sefer = new Sefer();
            DataTable dt = sefer.SeferDoldur();
            dgvSeferler.DataSource = dt;
            dgvSeferler.Columns[0].Visible = false;
            dgvSeferler.Columns[9].Visible = false; 
            dgvSeferler.Columns[10].Visible = false;
            dgvSeferler.Columns[11].Visible = false;
            Temizle();
        }

        private void nupSaat_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nupGidisSaat.Value.ToString()) < 10)
                txtGidisSaat.Text = "0" + nupGidisSaat.Value;
            else
                txtGidisSaat.Text = nupGidisSaat.Value.ToString();
        }

        private void nupDakika_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nupGidisDakika.Value.ToString()) < 10)
                txtGidisDakika.Text = "0" + nupGidisDakika.Value;
            else
                txtGidisDakika.Text = nupGidisDakika.Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil = MessageBox.Show("Sefer kaydını silmek istediğinizden emin misiniz ?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (sil == DialogResult.Yes)
            {
                Sefer sefer = new Sefer();
                int id = Convert.ToInt32(dgvSeferler.CurrentRow.Cells[0].Value);
                sefer.Sil(id);
                Goster();
                MessageBox.Show("Kayıt Başarıyla Silindi.", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void Temizle()
        {
            t_bKod.Text = "";
            t_hSure.Text = "";
            t_fiyat.Text = "";
            guncelleme = false;

            txtGidisDakika.Text = "00";
            txtGidisDakika.Text = "00";
            dtGidisTarih.Value = DateTime.Now;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }



        private void cmbVaris_SelectedIndexChanged(object sender, EventArgs e)
        {
            biletUret();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            Sefer sefer = new Sefer();
            DataTable dt = sefer.Arama(txtArama.Text);
            dgvSeferler.DataSource = dt;
        }

        private void dgvSeferler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            seciliID = Convert.ToInt32(dgvSeferler.CurrentRow.Cells[0].Value.ToString());
            string tarih = dgvSeferler.CurrentRow.Cells[4].Value.ToString();
            DateTime dtTarih = Convert.ToDateTime(tarih);
            dtGidisTarih.Value = dtTarih;
            txtGidisSaat.Text = dtTarih.Hour.ToString();
            txtGidisDakika.Text = dtTarih.Minute.ToString();

            t_bKod.Text = dgvSeferler.CurrentRow.Cells[5].Value.ToString();

            t_hSure.Text = dgvSeferler.CurrentRow.Cells[6].Value.ToString();

            t_fiyat.Text = dgvSeferler.CurrentRow.Cells[8].Value.ToString();

            cmbOtobus.SelectedValue = dgvSeferler.CurrentRow.Cells[11].Value.ToString();
            cmbKalkis.SelectedValue = dgvSeferler.CurrentRow.Cells[9].Value.ToString();
            cmbVaris.SelectedValue = dgvSeferler.CurrentRow.Cells[10].Value.ToString();

            guncelleme = true;

        }

        private void cmbKalkis_SelectedIndexChanged(object sender, EventArgs e)
        {
            biletUret();
        }
    }
}
