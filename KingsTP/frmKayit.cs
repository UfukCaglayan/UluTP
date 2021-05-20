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
            int a = msbTelefon.Text.Length;
            if (txtAdSoyad.Text != "" && txtTCKimlikNo.Text != "" && msbTelefon.Text != "" && txtEmail.Text != "" && txtSifre.Text != "" && txtSifreTekrar.Text != "")
            {

                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    if (txtTCKimlikNo.Text.Length == 11)
                    {
                        if (msbTelefon.Text.Length == 15)
                        {
                            Uyelik uyelik = new Uyelik(txtAdSoyad.Text, txtTCKimlikNo.Text, msbTelefon.Text, txtEmail.Text, txtSifre.Text);
                            if (uyelik.emailKontrol(txtEmail.Text))
                            {
                                bool kayit = uyelik.KayitOl();
                                if (kayit == false)
                                    MessageBox.Show("Aynı TC Kimlik Numarası veya Email Adresiyle Daha Önce Kayıt Oluşturulmuştur", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                    MessageBox.Show("Kayıt Başarıyla Tamamlandı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                                MessageBox.Show("Email Adresinizi Doğru Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Telefon Numaranızı Eksiksiz Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("TC Kimlik Numarası 11 Haneli Olmalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Girdiğiniz Şifreler Aynı Değildir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Bilgilerinizi Eksik Girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
        }
    }
}
