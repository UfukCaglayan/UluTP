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
            if (txtAdSoyad.Text != "" && txtTCKimlikNo.Text != "" && txtTelefon.Text != "" && txtEmail.Text != "" && txtSifre.Text != "" && txtSifreTekrar.Text != "")
            {
                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    if (txtTCKimlikNo.Text.Length == 11)
                    {
                        Uyelik uyelik = new Uyelik(txtAdSoyad.Text, txtTCKimlikNo.Text, txtTelefon.Text, txtEmail.Text, txtSifre.Text);
                        bool kayit = uyelik.KayitOl();
                        if (kayit == false)
                            MessageBox.Show("Aynı TC Kimlik Numarası veya Email adresiyle daha önce kayıt oluşturulmuştur");
                    }
                    else
                        MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır");
                }
                else
                    MessageBox.Show("Girdiğiniz şifreler aynı değildir");
            }
            else
                MessageBox.Show("Bilgilerinizi eksik girdiniz");
        }
    }
}
