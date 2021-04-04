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
    public partial class frmTerminalIslemleri : Form
    {
        public frmTerminalIslemleri()
        {
            InitializeComponent();
        }
        bool kaydet = true;
        private void Goster()
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT * FROM tblTerminaller", null);
            dgvTerminaller.DataSource = dt;
            Temizle();
            if (dt.Rows.Count > 0)
                dgvTerminaller.Columns[0].Visible = false;

        }
        private void Temizle()
        {
            txtTerminal.Text = "";
            txtArama.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtTerminal.Text != "")
            {
                if (kaydet == true)
                {

                int cnt = MSSQLDataConnection.SelectIntFromDB("SELECT COUNT(*) FROM tblTerminaller WHERE TerminalAdi = @param1", new SqlParameter[] { new SqlParameter("param1", txtTerminal.Text) });
                    if (cnt == 0)
                    {

                        MSSQLDataConnection.InsertDataToDB("INSERT INTO tblTerminaller (TerminalAdi) VALUES (@param1)", new SqlParameter[] { new SqlParameter("param1", txtTerminal.Text) });
                        Goster();
                        MessageBox.Show("Kayıt Başarıyla Eklendi.", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {

                    MSSQLDataConnection.UpdateDataToDB("UPDATE tblTerminaller SET TerminalAdi = @param1 WHERE ID = @param2 ", new SqlParameter[] { new SqlParameter("param1", txtTerminal.Text), new SqlParameter("param2", seciliID) });
                    MessageBox.Show("Kayıt Başarıyla Güncellendi.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Goster();
                    kaydet = true;


                }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil = MessageBox.Show("Terminal kaydını silmek istediğinizden emin misiniz ?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (sil == DialogResult.Yes)
            {
                int ID = Convert.ToInt32(dgvTerminaller.CurrentRow.Cells[0].Value.ToString());
                MSSQLDataConnection.DeleteDataFromDB("DELETE FROM tblTerminaller WHERE ID = @param1", new SqlParameter[] { new SqlParameter("param1", ID) });
                MessageBox.Show("Kayıt Başarıyla Silindi.", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Goster();
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        

        private void frmTerminalIslemleri_Load(object sender, EventArgs e)
        {
            Goster();
        }
        int seciliID = 0;
        private void dgvTerminaller_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            seciliID = Convert.ToInt32(dgvTerminaller.CurrentRow.Cells[0].Value.ToString());
            txtTerminal.Text = dgvTerminaller.CurrentRow.Cells[1].Value.ToString();
            kaydet = false;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT * FROM tblTerminaller WHERE TerminalAdi LIKE '%" + txtArama.Text + "%'", null);
            dgvTerminaller.DataSource = dt;
            if (dt.Rows.Count > 0)
                dgvTerminaller.Columns[0].Visible = false;

        }
    }
}
