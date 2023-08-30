using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsTP
{
    public partial class ucGecmisRezerve : UserControl
    {
        public ucGecmisRezerve()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult iptal = MessageBox.Show("İptal etmek istediğinizden emin misiniz ?", "İptal İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (iptal == DialogResult.Yes)
            {
                SeferIslem seferIslem = new SeferIslem();
                seferIslem.KoltukArttir(Convert.ToInt32(lbRezerveID.Text));
                KoltukRezerve koltukRezerve = new KoltukRezerve();
                koltukRezerve.RezerveIptal(Convert.ToInt32(lbRezerveID.Text));
                Form form = Application.OpenForms.Cast<Form>().Where(f => f.GetType() == typeof(frmGecmisRezerve)).FirstOrDefault();
                form.Close();
                new frmGecmisRezerve().Show();
            }
        }

        private void ucGecmisRezerve_Load(object sender, EventArgs e)
        {

        }
    }
}
