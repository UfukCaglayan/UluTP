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
    public partial class frmKoltukRezerve : Form
    {
        public frmKoltukRezerve()
        {
            InitializeComponent();
        }


        public List<int> koltuklar = new List<int>();
        int sefer;
        public void KoltukDoldur(int seferID)
        {
            int sag = 0, sol = 0;
            sefer = seferID;
            int koltukTuru = MSSQLDataConnection.SelectIntFromDB("SELECT KoltukTuruID FROM tblSeferler S INNER JOIN tblOtobusler O ON S.OtobusID = O.ID WHERE S.ID = @param1", new SqlParameter[] { new SqlParameter("param1", seferID) });
            if (koltukTuru == 1)
            {
                sag = 1;
                sol = 1;
            }
            else if (koltukTuru == 2)
            {
                sag = 2;
                sol = 1;
            }
            else if (koltukTuru == 3)
            {
                sag = 2;
                sol = 2;
            }
            int sagSon = 0;
            for (int i = 0; i < sag; i++)
            {
                for (int k = 1; k <= 20; k++)
                {
                    Button btnSag = new Button();
                    btnSag.Width = 50;
                    btnSag.Height = 40;
                    btnSag.Location = new Point(90 + (k * 60), 80 + (i * 45));
                    string koltukText = "";
                    if (sag == 2)
                    {
                        if (i == 0)
                        {
                            koltukText = (k * 2 - 1).ToString();
                        }
                        else if (i == 1)
                        {
                            koltukText = (k * 2).ToString();
                        }
                    }
                    else if (sag == 1)
                    {
                        koltukText = k.ToString();
                    }
                    btnSag.Click += btnKoltuk_Click;
                    btnSag.Text = koltukText;
                    btnSag.Name = "btnKoltuk" + koltukText;
                    this.Controls.Add(btnSag);
                }
            }
            sagSon = sag * 20;
            for (int i = 0; i < sol; i++)
            {
                for (int k = 1; k <= 20; k++)
                {
                    Button btnSol = new Button();
                    btnSol.Width = 50;
                    btnSol.Height = 40;
                    btnSol.Location = new Point(90 + (k * 60), 220 + (i * 45));
                    string koltukText = "";
                    if (sol == 2)
                    {
                        if (i == 0)
                        {
                            koltukText = (k * 2 - 1 + sagSon).ToString();
                        }
                        else if (i == 1)
                        {
                            koltukText = (k * 2 + sagSon).ToString();
                        }
                    }
                    else if (sol == 1)
                    {
                        koltukText = (sagSon + k).ToString();
                    }
                    btnSol.Click += btnKoltuk_Click;
                    btnSol.Text = koltukText;
                    btnSol.Name = "btnKoltuk" + koltukText;
                    this.Controls.Add(btnSol);
                }
            }


            DataTable dt = MSSQLDataConnection.SelectDataFromDB("SELECT KoltukNo FROM tblKoltukRezerve WHERE SeferID = @param1", new SqlParameter[] { new SqlParameter("param1", seferID) });
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string koltuk = dt.Rows[i][0].ToString();
                Button btnKoltuk = this.Controls.Find("btnKoltuk" + koltuk, true).FirstOrDefault() as Button;
                btnKoltuk.Enabled = false;
            }
        }

        int koltukNo = 0;

        private void btnKoltuk_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            koltukNo = Convert.ToInt32(btn.Text);
            pnlCinsiyet.Location = new Point(btn.Location.X - 40, btn.Location.Y - 62);
            pnlCinsiyet.Visible = true;
        }

        private void frmKoltukRezerve_Load(object sender, EventArgs e)
        {
            pnlCinsiyet.Visible = false;
        }


        private void btnSecim_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            koltuklar.Add(koltukNo);
            pnlCinsiyet.Visible = false;
        }

        private void btnRezerve_Click(object sender, EventArgs e)
        {
            Sefer.koltukNo = koltuklar;
            for (int i = 0; i < koltuklar.Count; i++)
            {
                ucRezerve uc1 = new ucRezerve();
                uc1.Name = "ucRezerve" + i;
                uc1.Top = i * 70;
                pnlBilgiler.Controls.Add(uc1);
            }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SeferID", typeof(int));
            dt.Columns.Add("KoltukID", typeof(int));
            dt.Columns.Add("TCKimlikNo", typeof(string));
            dt.Columns.Add("Ad", typeof(string));
            dt.Columns.Add("Soyad", typeof(string));
            dt.Columns.Add("Cinsiyet", typeof(string));

            for (int i = 0; i < koltuklar.Count; i++)
            {
                UserControl uc = this.Controls.Find("ucRezerve" + i, true).FirstOrDefault() as UserControl;
                TextBox txTCKimlikNo = uc.Controls.Find("txTCKimlikNo", true).FirstOrDefault() as TextBox;
                TextBox txtAd = uc.Controls.Find("txtAd", true).FirstOrDefault() as TextBox;
                TextBox txtSoyad = uc.Controls.Find("txtSoyad", true).FirstOrDefault() as TextBox;
                dt.Rows.Add(sefer,koltuklar[i],txTCKimlikNo.Text,txtAd.Text,txtSoyad.Text,"E");
                
            }
            MSSQLDataConnection.InsertRezerveTablo(dt);
            MessageBox.Show("İŞLEM TAMAM");

        }
    }
}
