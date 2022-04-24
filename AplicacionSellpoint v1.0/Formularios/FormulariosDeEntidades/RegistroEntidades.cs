using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AplicacionSellpoint_v1._0.CodigoFuente;

namespace AplicacionSellpoint_v1._0.Formularios.FormulariosDeEntidades
{
    public partial class RegistroEntidades : Form
    {
        public RegistroEntidades()
        {
            InitializeComponent();
        }

        private void RegistroEntidades_Load(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarGrupoDeEntidad(cbIDG);
            ComboDeAyuda.LlenarTiposDeEntidad(cbIDT);
            cbRolE.Items.Add("Admin");
            cbRolE.Items.Add("Supervisor");
            cbRolE.Items.Add("User");


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            errorP.Clear();
            if (textDescripcion.Text.Trim().Length == 0)
            {
                errorP.SetError(textDescripcion, "Debe ingresar la descripción.");
                textDescripcion.Focus();
                return;
            }


        
            string estatus = "Inactivo";
            int eliminar = 0;   
            if(checkBox1.Checked)
            {
                estatus = "Activo";
            }
            if(radioButton3.Checked)
            {
                eliminar = 1;   
            }
            int Credito=int.Parse(txtLCredito.Text);
            int Nu_documento = int.Parse(txtNumDoc.Text);

            string query=String.Format("INSERT INTO Entidades (Descripcion,Direccion,Localidad,TipoDocumento,TipoEntidad,NumeroDocumento," +
                "Teléfonos,URLPaginaWeb,URLFacebook,URLInstagram,URLTwitter,URLTikTok,IdGrupoEntidad,IdTipoEntidad,LimiteCredito," +
                "UserNameEntidad,PassworEntidad, RolUserEntidad,Comentario,Status,NoEliminable,FechaRegistro) VALUES ('{0}','{1}'," +
                "'{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}','{11}',{12},{13},{14},'{15}','{16}','{17}','{18}','{19}',{20},'{21}')",
                textDescripcion.Text.Trim(),txtDire.Text.Trim(),txtLocali.Text.Trim(),txtTipoDocu.Text.Trim(),txtTipoEntidad.Text.Trim(),Nu_documento,txtTelefono.Text.Trim(),
                txtPagWeb.Text.Trim(),txtFacebook.Text.Trim(),txtInstagram.Text.Trim(),txtTwitter.Text.Trim(),txtTiktok.Text.Trim(),cbIDG.SelectedValue,cbIDT.SelectedValue,
                Credito,txtUser.Text.Trim(),txtPass.Text.Trim(),cbRolE.Text.Trim(),txtComen.Text.Trim(),estatus,eliminar,DTFechaE.Value.ToString("yyy/MM/dd"));



            bool resultado = AccesoABaseDeDatos.Insertar(query);
            if (resultado)
            {
                MessageBox.Show("Guardado exitosamente.");
               
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtLCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
