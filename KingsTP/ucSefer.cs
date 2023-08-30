using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KingsTP
{
    public partial class ucSefer : UserControl
    {
      
        public ucSefer()
        {
            InitializeComponent();
            
        }

        private void ucSefer_Load(object sender, EventArgs e)
        {

        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            if (GirisBilgileri.KullaniciID != -1)
            {
                int ind = Convert.ToInt32(this.Name.Substring(3, 1));
                ((frmMain)this.Parent.Parent.Parent).KoltukDoldur(Convert.ToInt32(lbSeferID.Text), ind);
            }
            else
                MessageBox.Show("Önce giriş yapmalısınız","Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
