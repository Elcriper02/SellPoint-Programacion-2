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

namespace AplicacionSellpoint_v1._0.Formularios.FormulariosDeEntidades
{
    public partial class frmAgregarGrupoDeEntidades : Form
    {
        public frmAgregarGrupoDeEntidades()
        {
            InitializeComponent();
        }
        public void cargar_combo_box()
        {
  
            
        }
        public void LlenarCuadro(string busqueda_a_realizar)
        {
            string query = string.Empty;
            DataTable tabladedatos = new DataTable();
            if (string.IsNullOrEmpty(busqueda_a_realizar) && string.IsNullOrWhiteSpace(busqueda_a_realizar))
            {
                query = " SELECT IdGrupoEntidad AS [ID], Descripcion AS [Descripción], Comentario, Status AS [Estado], FechaRegistro AS [Fecha de registro] FROM GruposEntidades WHERE NoEliminable = 0";
            }
            else
            {
                query = "SELECT IdGrupoEntidad AS [ID], Descripcion AS [Descripción], Comentario, Status AS [Estado], FechaRegistro AS [Fecha de registro] FROM GruposEntidades WHERE (Descripcion +' '+Comentario) LIKE '%" + busqueda_a_realizar + "%'";
            }
            tabladedatos = AccesoABaseDeDatos.Seleccionar(query);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    dgvGruposEntidades.DataSource = tabladedatos;
                    dgvGruposEntidades.Columns[0].Width = 100;    // ID Grupo entidad.
                    dgvGruposEntidades.Columns[1].Width = 150;    // Descripcion.
                    dgvGruposEntidades.Columns[2].Width = 150;    // Comentario.
                    dgvGruposEntidades.Columns[3].Width = 120;    // Estado.
                    dgvGruposEntidades.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;  // Fecha de registro.
                }
                else
                {
                    dgvGruposEntidades.DataSource = null;
                }
            }
            else
            {
                dgvGruposEntidades.DataSource = null;
            }
            checkEliminado.Checked = false;
        }

        private void LlenarCuadroEliminado(string busqueda_a_realizar)
        {
            string query = string.Empty;
            DataTable tabladedatos = new DataTable();
            if (string.IsNullOrEmpty(busqueda_a_realizar) && string.IsNullOrWhiteSpace(busqueda_a_realizar))
            {
                query = "SELECT IdGrupoEntidad AS [ID], Descripcion AS [Descripción], Comentario, Status AS [Estado], FechaRegistro AS [Fecha de registro] FROM GruposEntidades WHERE NoEliminable = 1";
            }
            else
            {
                query = "SELECT IdGrupoEntidad AS [ID], Descripcion AS [Descripción], Comentario, Status AS [Estado], FechaRegistro AS [Fecha de registro] FROM GruposEntidades WHERE Descripcion LIKE '%" + busqueda_a_realizar + "%' AND NoEliminable = 1";
            }
            

            
            tabladedatos = AccesoABaseDeDatos.Seleccionar(query);
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    dgvGruposEntidades.DataSource = tabladedatos;
                    dgvGruposEntidades.Columns[0].Width = 100;
                    dgvGruposEntidades.Columns[1].Width = 100;
                    dgvGruposEntidades.Columns[2].Width = 100;
                    dgvGruposEntidades.Columns[3].Width = 100;
                    dgvGruposEntidades.Columns[4].Width = 100;
                }
                else
                {
                    dgvGruposEntidades.DataSource = null;
                }
            }
            else
            {
                dgvGruposEntidades.DataSource = null;
            }
        }

        private void LimpiarFormulario()
        {
            textDescripcion.Clear();
            textComentario.Clear();
            checkBEstaInactivo.Checked = false;
            dateTPFechaDeRegistro.Value = DateTime.Now;
        }

        private void HabilitarBotones()
        {
            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = false;
            dgvGruposEntidades.Enabled = false;
            textBusqueda.Enabled = false;
            checkEliminado.Enabled = false;
        }

        private void DeshabilitarBotones()
        {
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = true;
            dgvGruposEntidades.Enabled = true;
            textBusqueda.Enabled = true;
            LlenarCuadro("");
            checkEliminado.Enabled = true;
        }
        private void frmAgregarGrupoDeEntidades_Load(object sender, EventArgs e)
        {
            LlenarCuadro("");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarBotones();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            LlenarCuadro(textBusqueda.Text.Trim());
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGruposEntidades != null)
            {
                if (dgvGruposEntidades.Rows.Count > 0)
                {
                    if (dgvGruposEntidades.SelectedRows.Count == 1)
                    {
                        textDescripcion.Text = Convert.ToString(dgvGruposEntidades.CurrentRow.Cells[1].Value);    // Descripcion.
                        textComentario.Text = Convert.ToString(dgvGruposEntidades.CurrentRow.Cells[2].Value);    // Comentario.
                        HabilitarBotones();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un registro.");
                    }
                }
                else
                {
                    MessageBox.Show("La lista está vacía.");
                }
            }
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

            // CON ESTO SE SELECCIONAN LOS DATOS EN LA BASE DE DATOS

            DataTable tabladedatos = new DataTable();
            tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM GruposEntidades WHERE Descripcion = '" + textDescripcion.Text.Trim() + "'");
            if (tabladedatos != null)
            {
                if (tabladedatos.Rows.Count > 0)
                {
                    errorP.SetError(textDescripcion, "Ya está registrado.");
                    textDescripcion.Focus();
                    return;
                }
            }

            // CON ESTO SE INSERTAN LOS DATOS EN LA BASE DE DATOS

            string query = string.Format("INSERT INTO GruposEntidades(Descripcion,Comentario,FechaRegistro) VALUES('{0}','{1}','{2}')", 
                                                                      textDescripcion.Text.Trim(), textComentario.Text.Trim(), dateTPFechaDeRegistro.Value.ToString("yyyy/MM/dd"));
            bool resultado = AccesoABaseDeDatos.Insertar(query);
            if (resultado)
            {
                MessageBox.Show("Guardado exitosamente.");
                checkBEstaInactivo.Checked = false;
                checkEliminado.Checked = false;
                LimpiarFormulario();
                LlenarCuadro("");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // CON ESTO MANEJAS LOS ERRORES DE LOS INPUTS

            errorP.Clear();
            if (textDescripcion.Text.Trim().Length == 0)
            {
                errorP.SetError(textDescripcion, "Debe ingresar la descripción.");
                textDescripcion.Focus();
                return;
            }


            DataTable tabla_de_datos = AccesoABaseDeDatos.Seleccionar("SELECT * FROM GruposEntidades WHERE Descripcion = '" + textDescripcion.Text.Trim() + "' AND IdGrupoEntidad != '" + dgvGruposEntidades.CurrentRow.Cells[0].Value + "'");
            if (tabla_de_datos != null)
            {
                if (tabla_de_datos.Rows.Count > 0)
                {
                    errorP.SetError(textDescripcion, "Ya existe.");
                    textDescripcion.Focus();
                    return;
                }
            }

            // CON ESTO SE ACTUALIZAN LOS DATOS EN LA BASE DE DATOS

            string actualizarquery = string.Format("UPDATE GruposEntidades SET Descripcion = '{0}',Comentario = '{1}',FechaRegistro = '{2}' WHERE IdGrupoEntidad = '{3}'",
                                                               textDescripcion.Text.Trim(), textComentario.Text.Trim(), dateTPFechaDeRegistro.Value.ToString("yyyy/MM/dd"), dgvGruposEntidades.CurrentRow.Cells[0].Value);

            bool resultado = AccesoABaseDeDatos.Actualizar(actualizarquery);
            if (resultado)
            {
                MessageBox.Show("Actualizado exitosamente.");
                checkBEstaInactivo.Checked = false;
                DeshabilitarBotones();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Por favor contactese con el programador.");
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGruposEntidades != null)
            {
                if (dgvGruposEntidades.Rows.Count > 0)
                {
                    if (dgvGruposEntidades.SelectedRows.Count == 1)
                    {

                        if (eliminarToolStripMenuItem.Text == "Eliminar")
                        {
                            // CON ESTO SE ELIMINAN LOS DATOS EN LA BASE DE DATOS

                            if (MessageBox.Show("¿Está seguro de que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string eliminarquery = "UPDATE GruposEntidades SET NoEliminable = 1 WHERE IdGrupoEntidad = '" + dgvGruposEntidades.CurrentRow.Cells[0].Value + "'";
                                bool resultado = AccesoABaseDeDatos.Eliminar(eliminarquery);
                                if (resultado)
                                {
                                    MessageBox.Show("Eliminado exitosamente.");
                                    LlenarCuadro("");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un registro.");
                    }
                }
                else
                {
                    MessageBox.Show("La lista está vacía.");
                }
            }
        }

        private void checkEliminado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEliminado.Checked == true)
            {
                LlenarCuadroEliminado("");
            }
            else
            {
                LlenarCuadro("");
            }
        }

        private void checkBEstaInactivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}