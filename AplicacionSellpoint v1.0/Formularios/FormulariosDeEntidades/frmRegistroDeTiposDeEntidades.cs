using AplicacionSellpoint_v1._0.CodigoFuente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionSellpoint_v1._0.Formularios.FormulariosDeEntidades
{
    public partial class frmRegistroDeTiposDeEntidades : Form
    {
        public frmRegistroDeTiposDeEntidades()
        {
            InitializeComponent();
        }

        private void LlenarCuadro(string busqueda_a_realizar)
        {
            string query = string.Empty;
            DataTable tabladedatos = new DataTable();
            if (string.IsNullOrEmpty(busqueda_a_realizar) && string.IsNullOrWhiteSpace(busqueda_a_realizar))
            {
                query = "SELECT ID, [Grupo de entidad], [Tipo de entidad] from v_TipoEntidades";
            }
            else
            {
                query = "SELECT ID, [Grupo de entidad], [Tipo de entidad] from v_TipoEntidades WHERE (ID +' '+ [Grupo de entidad] +' '+ [Tipo de entidad]) LIKE '%" + busqueda_a_realizar + "%'";
            }
            tabladedatos = AccesoABaseDeDatos.Seleccionar(query);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    dgvEntidades.DataSource = tabladedatos;
                    dgvEntidades.Columns[0].Width = 100;
                    dgvEntidades.Columns[1].Width = 200;
                    dgvEntidades.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dgvEntidades.DataSource = null;
                }
            }
            else
            {
                dgvEntidades.DataSource = null;
            }
        }

        private void frmRegistroDeTiposDeEntidades_Load(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarGrupoDeEntidad(comboSeleccionarGrupoDeEntidad);
            btnRefrescar_Click(sender, e);
            LlenarCuadro("");

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ComboDeAyuda.LlenarGrupoDeEntidad(comboSeleccionarGrupoDeEntidad);
        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            frmAgregarGrupoDeEntidades frm = new frmAgregarGrupoDeEntidades();
            frm.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //errorP.Clear();
            //if (comboSeleccionarGrupoDeEntidad.SelectedIndex == 0)
            //{
            //    errorP.SetError(comboSeleccionarGrupoDeEntidad, "Debe seleccionar grupo de entidad.");
            //    comboSeleccionarGrupoDeEntidad.Focus();
            //    return;
            //}

            //if (textTipoDeEntidad.Text.Trim().Length == 0)
            //{
            //    errorP.SetError(textTipoDeEntidad, "Debe ingresar el tipo de entidad.");
            //    textTipoDeEntidad.Focus();
            //    return;
            //}

            //DataTable tabla_de_datos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM TiposEntidades WHERE Descripcion = '" + textTipoDeEntidad.Text.Trim() + "' AND IdGrupoEntidad = '" + comboSeleccionarGrupoDeEntidad.SelectedValue + "'");
            //if (tabla_de_datos != null)
            //{
            //    if (tabla_de_datos.Rows.Count > 0)
            //    {
            //        errorP.SetError(textTipoDeEntidad, "Ya existe.");
            //        textTipoDeEntidad.Focus();
            //        return;
            //    }
            //}

            //string insertarquery = string.Format("INSERT INTO TiposEntidades( IdTipoEntidad,Descripcion, IdGrupoEntidad) VALUES('{0}','{1}','{3}')", UsuarioActual.IdEntidad, textTipoDeEntidad.Text.Trim(), comboSeleccionarGrupoDeEntidad.SelectedValue);
            //bool resultado = AccesoABaseDeDatos.Insertar(insertarquery);
            //if (resultado)
            //{
            //    MessageBox.Show("Guardado exitosamente.");
            //    textTipoDeEntidad.Clear();
            //    comboSeleccionarGrupoDeEntidad.SelectedIndex = 0;
            //    LlenarCuadro("");
            //}
            //else
            //{
            //    MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            //}
        }
    }
}