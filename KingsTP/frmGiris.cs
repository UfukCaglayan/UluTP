using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsTP
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtSifre.Text != "")
            {
                Giris giris = new Giris(txtEmail.Text, txtSifre.Text);
                int id = giris.GirisYap();
                if (id != -1)
                {
                    bool admin = giris.adminKontrol();
                    if (admin == true)
                    {
                        frmYonetim yonetim = new frmYonetim();
                        yonetim.Show();
                        this.Close();
                    }
                    else
                    {
                        GirisBilgileri.KullaniciID = id;
                        ((frmMain)this.Owner).Giris(giris.getAdSoyad());
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("E Mail adresini veya şifreyi yanlış girdiniz");
            }
            else
                MessageBox.Show("E Mail adresinizi ve şifrenizi boş girmeyiniz");
        }
    }
}
