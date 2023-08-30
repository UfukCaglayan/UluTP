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
            Terminal terminal = new Terminal();
            DataTable dt = terminal.Doldur();
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
                Terminal terminal = new Terminal(txtTerminal.Text);
                bool kontrol = terminal.terminalVarmi(txtTerminal.Text);
                if (kaydet == true)
                {
                    if (kontrol == false)
                    {
                        terminal.Kaydet();
                        Goster();
                        MessageBox.Show("Kayıt Başarıyla Eklendi.", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        MessageBox.Show("Bu terminal daha önce sisteme kayıt edildi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {

                    terminal.setID(seciliID);
                    if (txtTerminal.Text != dgvTerminaller.CurrentRow.Cells[1].Value.ToString())
                    {
                        if (kontrol == false)
                        {
                            terminal.Guncelle();
                            Goster();
                            MessageBox.Show("Kayıt başarıyla güncellendi.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            kaydet = true;
                        }
                        else
                            MessageBox.Show("Bu terminal daha önce sisteme kayıt edildi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        terminal.Guncelle();
                        Goster();
                        MessageBox.Show("Kayıt başarıyla güncellendi.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                   
                }
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil = MessageBox.Show("Terminal kaydını silmek istediğinizden emin misiniz ?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (sil == DialogResult.Yes)
            {
                Terminal terminal = new Terminal();
                int ID = Convert.ToInt32(dgvTerminaller.CurrentRow.Cells[0].Value.ToString());
                terminal.Sil(ID);
                Goster();
                MessageBox.Show("Kayıt Başarıyla Silindi.", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            Terminal terminal = new Terminal();
            DataTable dt = terminal.Arama(txtArama.Text);
            dgvTerminaller.DataSource = dt;
            if (dt.Rows.Count > 0)
                dgvTerminaller.Columns[0].Visible = false;

        }
    }
}
