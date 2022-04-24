using AplicacionSellpoint_v1._0.Formularios;
using AplicacionSellpoint_v1._0.Formularios.FormulariosDeEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionSellpoint_v1._0
{
    public partial class frmMenuPrincipal : Form
    {

        public frmMenuPrincipal()
        {
            InitializeComponent();
            statusStrip1.Items["lblNombreDeUsuario"].Text = Program.nombreDeUsuario;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe frm = new frmAcercaDe();
            frm.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIniciarSesion frm = new frmIniciarSesion();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {   
            frmIniciarSesion frm = new frmIniciarSesion();
            frm.ShowDialog();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fechaActual.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            horaActual.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void tiposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroDeTiposDeEntidades frm = new frmRegistroDeTiposDeEntidades();
            frm.ShowDialog();
        }

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEntidades registroEntidades = new RegistroEntidades();
            registroEntidades.ShowDialog();
        }
    }
}
