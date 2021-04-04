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
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT O.ID,Plaka,KoltukTuru,KoltukTuruID FROM tblOtobusler O INNER JOIN tblKoltukTurleri KT ON O.KoltukTuruID = KT.ID", null);
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
            DataTable dtKoltuk = MSSQLDataConnection.SelectDataFromDB("SELECT ID,KoltukTuru FROM tblKoltukTurleri", null);
            cmbKoltukTuru.DataSource = dtKoltuk;
            cmbKoltukTuru.Text = "Seçiniz";
            Goster();
        }
        int seciliID;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtPlaka.Text != null && cmbKoltukTuru.Text != "Seçiniz")
            {
                if (txtPlaka.Text.Length == 8)
                {

                    int cnt = MSSQLDataConnection.SelectIntFromDB("SELECT COUNT(*) FROM tblOtobusler WHERE Plaka = @param1", new SqlParameter[] { new SqlParameter("param1", txtPlaka.Text) });
                    if (kaydet == true)
                    {
                        if (cnt == 0)
                        {
                            MSSQLDataConnection.InsertDataToDB("INSERT INTO tblOtobusler (Plaka,KoltukTuruID) VALUES (@param1,@param2)", new SqlParameter[] { new SqlParameter("param1", txtPlaka.Text), new SqlParameter("param2", cmbKoltukTuru.SelectedValue) });
                            Goster();
                            MessageBox.Show("Kayıt Başarıyla Eklendi.", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                       else
                            MessageBox.Show("Bu Plakaya Sahip Otobüs Daha Önce Sisteme Kayıt Edildi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MSSQLDataConnection.UpdateDataToDB("UPDATE tblOtobusler SET Plaka = @param1,KoltukTuruID= @param2 WHERE ID = @param3 ", new SqlParameter[] { new SqlParameter("param1", txtPlaka.Text), new SqlParameter("param2", cmbKoltukTuru.SelectedValue), new SqlParameter("param3", seciliID) });
                        MessageBox.Show("Kayıt Başarıyla Güncellendi.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Goster();
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
                MSSQLDataConnection.DeleteDataFromDB("DELETE FROM tblOtobusler WHERE ID = @param1", new SqlParameter[] { new SqlParameter("param1", ID) });
                MessageBox.Show("Kayıt Başarıyla Silindi.", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Goster();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT * FROM tblOtobusler WHERE Plaka LIKE '%" + txtArama.Text +"%'", null);
            dgvOtobusler.DataSource = dt;
            if (dt.Rows.Count > 0)
                dgvOtobusler.Columns[0].Visible = false;
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
