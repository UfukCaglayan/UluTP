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
    public partial class frmYonetim : Form
    {
        public frmYonetim()
        {
            InitializeComponent();
        }

        private void tsmOtobusIslemleri_Click(object sender, EventArgs e)
        {
            frmOtobusIslemleri otobus = new frmOtobusIslemleri();
            otobus.MdiParent = this;
            otobus.Show();
        }

        private void tsmSeferIslemleri_Click(object sender, EventArgs e)
        {
            frmSeferIslemleri sefer = new frmSeferIslemleri();
            sefer.MdiParent = this;
            sefer.Show();
        }

        private void tsmTerminalIslemleri_Click(object sender, EventArgs e)
        {
            frmTerminalIslemleri terminal = new frmTerminalIslemleri();
            terminal.MdiParent = this;
            terminal.Show();
        }
    }
}
