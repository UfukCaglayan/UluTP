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
    public partial class frmOtobusIslemleri : Form
    {
        public frmOtobusIslemleri()
        {
            InitializeComponent();
        }
        bool kaydet = true;

        private void Temizle()
        {
            txtPlaka.Text = "";
            cmbKoltukTuru.Text = "Seçiniz";
            kaydet = true;

        }

        private void Goster()
        {
            Otobus otobus = new Otobus();
            DataTable dt = otobus.Doldur();
            dgvOtobusler.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dgvOtobusler.Columns[0].Visible = false;
                dgvOtobusler.Columns[3].Visible = false;
            }

            Temizle();
        }

        private void frmOtobusIslemleri_Load(object sender, EventArgs e)
        {
            KoltukTurleri kt = new KoltukTurleri();
            DataTable dtKoltuk = kt.Cagir();
            cmbKoltukTuru.DataSource = dtKoltuk;
            cmbKoltukTuru.Text = "Seçiniz";
            Goster();
        }
        int seciliID;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtPlaka.Text != null && cmbKoltukTuru.Text != "Seçiniz")
            {
                Otobus otobus = new Otobus();
                if (txtPlaka.Text.Length == 8)
                {
                    bool kontrol = otobus.otobusVarmi(txtPlaka.Text);
                    if (kaydet == true)
                    {
                        if (kontrol == false)
                        {
                            otobus.setPlaka(txtPlaka.Text);
                            otobus.setKoltukTuruID(Convert.ToInt32(cmbKoltukTuru.SelectedValue));
                            otobus.Kaydet();
                            Goster();
                            MessageBox.Show("Kayıt Başarıyla Eklendi.", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                       else
                            MessageBox.Show("Bu Plakaya Sahip Otobüs Daha Önce Sisteme Kayıt Edildi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        otobus.setID(seciliID);
                        otobus.setPlaka(txtPlaka.Text);
                        otobus.setKoltukTuruID(Convert.ToInt32(cmbKoltukTuru.SelectedValue));
                        otobus.Guncelle();
                        Goster();
                        MessageBox.Show("Kayıt Başarıyla Güncellendi.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        kaydet = true;
                    }
                }
                else
                    MessageBox.Show("Plaka 8 Haneli Olmalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
                MessageBox.Show("Bilgileri Eksik Girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil = MessageBox.Show("Otobüs kaydını silmek istediğinizden emin misiniz ?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (sil == DialogResult.Yes)
            {
                int ID = Convert.ToInt32(dgvOtobusler.CurrentRow.Cells[0].Value.ToString());
                Otobus otobus = new Otobus();
                otobus.Sil(ID);
                Goster();
                MessageBox.Show("Kayıt Başarıyla Silindi.", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            Otobus otobus = new Otobus();
            DataTable dt = otobus.Arama(txtArama.Text);
            dgvOtobusler.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dgvOtobusler.Columns[0].Visible = false;
                dgvOtobusler.Columns[3].Visible = false;
            }
        }

        private void dgvOtobusler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            seciliID = Convert.ToInt32(dgvOtobusler.CurrentRow.Cells[0].Value.ToString());
            txtPlaka.Text = dgvOtobusler.CurrentRow.Cells[1].Value.ToString();
            cmbKoltukTuru.SelectedValue = dgvOtobusler.CurrentRow.Cells[3].Value.ToString();
            kaydet = false;
        }

       
    }
}
