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

        private void frmSeferIslemleri_Load(object sender, EventArgs e)
        {
            DataTable dtOtobusler = MSSQLDataConnection.SelectDataFromDB("SELECT ID,Plaka FROM tblOtobusler", null);
            cmbOtobus.DataSource = dtOtobusler;
            DataTable dtKalkis = MSSQLDataConnection.SelectDataFromDB("SELECT ID,TerminalAdi FROM tblTerminaller", null);
            cmbKalkis.DataSource = dtKalkis;
            DataTable dtVaris = MSSQLDataConnection.SelectDataFromDB("SELECT ID,TerminalAdi FROM tblTerminaller", null);
            cmbVaris.DataSource = dtVaris;
            goster();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {   
            if(t_bKod.Text == "" || t_hSure.Text == "" || t_fiyat.Text == "")
            {
                MessageBox.Show("eksik giriş yaptınız");
                return;
            }
            string gidisTarih = dtGidisTarih.Value.ToString("yyyy-MM-dd");
            string gidisSaat = txtGidisSaat.Text + ":" + txtGidisDakika.Text;
            string gidisTS = gidisTarih + " " + gidisSaat;

            int kalTerminal_id = Convert.ToInt32(cmbKalkis.SelectedValue);
            int varTerminal_id = Convert.ToInt32(cmbVaris.SelectedValue);

            string bKod = t_bKod.Text;

            int hSure = Convert.ToInt32(t_hSure.Text);

            int fiyat = Convert.ToInt32(t_fiyat.Text);

            int otobusID = Convert.ToInt32(cmbOtobus.SelectedValue);

           // bool gidisDonus = cbGidisDonus.Checked;

            int kalanKoltuk = MSSQLDataConnection.SelectIntFromDB("SELECT KoltukSayisi FROM tblKoltukTurleri KT INNER JOIN tblOtobusler O ON KT.ID = O.KoltukTuruID WHERE O.ID = @param1", new SqlParameter[] { new SqlParameter("param1", otobusID) });

            Sefer sefer = new Sefer(gidisTS, kalTerminal_id, varTerminal_id, bKod, hSure, fiyat, otobusID, kalanKoltuk);
            goster();

        }

        

        void goster()
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT ID,OtobusID,KalkisTerminalID,VarisTerminalID,KalkisZaman,BiletKodu,HareketSuresi,KalanKoltuk,Fiyat FROM tblSeferler", null);
            dgvSeferler.DataSource = dt;
            dgvSeferler.Columns[0].Visible = false;
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
                int id = Convert.ToInt32(dgvSeferler.CurrentRow.Cells[0].Value);
                MSSQLDataConnection.DeleteDataFromDB("DELETE FROM tblSeferler WHERE ID = @param1", new SqlParameter[] { new SqlParameter("param1", id) });
                goster();
                MessageBox.Show("Kayıt Başarıyla Silindi.", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }

       

        private void cmbVaris_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idx="";
            try
            {
                idx = (Convert.ToInt32(dgvSeferler.Rows[dgvSeferler.RowCount - 2].Cells[0].Value)+1).ToString();
            }
            catch {}
            t_bKod.Text = string.Concat(cmbKalkis.Text[0], cmbVaris.Text[0], idx);
        }
    }
}
