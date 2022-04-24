using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionSellpoint_v1._0.Formularios
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 599)
            {

                timer1.Stop();
                frmMenuPrincipal ld = new frmMenuPrincipal();
                ld.Show();
                this.Close();
            }
        }
    }
}
