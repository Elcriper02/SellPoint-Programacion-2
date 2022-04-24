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
    public partial class frmIniciarSesion : Form
    {
        //private frmMenuPrincipal MenuPrincipal;
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        //public frmIniciarSesion(frmMenuPrincipal frmMenuPrincipal)
        //{
        //    InitializeComponent();
        //    this.MenuPrincipal = frmMenuPrincipal;
        //}

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            errorP.Clear();
            if (textNombreDeUsuario.Text.Trim().Length == 0)
            {
                errorP.SetError(textNombreDeUsuario, "Debe ingresar el nombre de usuario.");
                textNombreDeUsuario.Focus();
                return;
            }

            if (textContraseña.Text.Trim().Length == 0)
            {
                errorP.SetError(textContraseña, "Debe ingresar la contraseña.");
                textContraseña.Focus();
                return;
            }

            string getQuery = "SELECT UserNameEntidad, PassworEntidad FROM Entidades WHERE UserNameEntidad = '" + textNombreDeUsuario.Text.Trim() + "' AND PassworEntidad = '" + textContraseña.Text.Trim() + "'";
            DataTable dataTable = AccesoABaseDeDatos.Seleccionar(getQuery);
            if (dataTable == null)
            {
                labelError.Visible = true;
                return;
            }
            else if (dataTable.Rows.Count > 0)
            {
                //MenuPrincipal.lblNombreDeUsuario.Text = textNombreDeUsuario.Text.Trim();
                Program.nombreDeUsuario = textNombreDeUsuario.Text;
                this.Close();
                return;
            }
            else
            {
                labelError.Visible = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {

        }
    }
}