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
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "" && txtTCKimlikNo.Text != "" && msbTelefon.Text != "" && txtEmail.Text != "" && txtSifre.Text != "" && txtSifreTekrar.Text != "")
            {

                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    if (txtTCKimlikNo.Text.Length == 11)
                    {
                        if (msbTelefon.Text.Length == 15)
                        {
                            Kayit kayit = new Kayit(txtAdSoyad.Text, txtTCKimlikNo.Text, msbTelefon.Text, txtEmail.Text, txtSifre.Text);
                            if (kayit.emailKontrol(txtEmail.Text))
                            {
                                bool kayitVarmi = kayit.kayitVarmi();
                                if (kayitVarmi == false)
                                    MessageBox.Show("Aynı TC Kimlik Numarası veya Email adresiyle daha önce kayıt oluşturulmuştur", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                {
                                    int id = kayit.KayitOl();
                                    MessageBox.Show("Kayıt başarıyla tamamlandı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    GirisBilgileri.KullaniciID = id;
                                    ((frmMain)this.Owner).Giris(txtAdSoyad.Text);
                                    this.Close();
                                }
                            }
                            else
                                MessageBox.Show("Email adresinizi doğru giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Telefon numaranızı eksiksiz giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Girdiğiniz şifreler aynı değildir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bilgilerinizi eksik eirdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
        }
    }
}
