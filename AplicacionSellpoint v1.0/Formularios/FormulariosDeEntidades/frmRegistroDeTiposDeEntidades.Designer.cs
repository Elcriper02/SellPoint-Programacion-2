namespace AplicacionSellpoint_v1._0.Formularios.FormulariosDeEntidades
{
    partial class frmRegistroDeTiposDeEntidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSeleccionarGrupoDeEntidad = new System.Windows.Forms.ComboBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnAgregarGrupo = new System.Windows.Forms.Button();
            this.dgvEntidades = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.textTipoDeEntidad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccionar grupo de entidad: ";
            // 
            // comboSeleccionarGrupoDeEntidad
            // 
            this.comboSeleccionarGrupoDeEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeleccionarGrupoDeEntidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboSeleccionarGrupoDeEntidad.FormattingEnabled = true;
            this.comboSeleccionarGrupoDeEntidad.ItemHeight = 20;
            this.comboSeleccionarGrupoDeEntidad.Location = new System.Drawing.Point(266, 30);
            this.comboSeleccionarGrupoDeEntidad.Name = "comboSeleccionarGrupoDeEntidad";
            this.comboSeleccionarGrupoDeEntidad.Size = new System.Drawing.Size(329, 28);
            this.comboSeleccionarGrupoDeEntidad.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackgroundImage = global::AplicacionSellpoint_v1._0.Properties.Resources.actualizar_mas_pequeño;
            this.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefrescar.Location = new System.Drawing.Point(601, 30);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(30, 29);
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.BackgroundImage = global::AplicacionSellpoint_v1._0.Properties.Resources.personbutton;
            this.btnAgregarGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarGrupo.Location = new System.Drawing.Point(637, 30);
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Size = new System.Drawing.Size(30, 29);
            this.btnAgregarGrupo.TabIndex = 4;
            this.btnAgregarGrupo.UseVisualStyleBackColor = true;
            this.btnAgregarGrupo.Click += new System.EventHandler(this.btnAgregarGrupo_Click);
            // 
            // dgvEntidades
            // 
            this.dgvEntidades.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntidades.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvEntidades.Location = new System.Drawing.Point(17, 277);
            this.dgvEntidades.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEntidades.MultiSelect = false;
            this.dgvEntidades.Name = "dgvEntidades";
            this.dgvEntidades.ReadOnly = true;
            this.dgvEntidades.RowHeadersVisible = false;
            this.dgvEntidades.RowHeadersWidth = 51;
            this.dgvEntidades.RowTemplate.Height = 29;
            this.dgvEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntidades.Size = new System.Drawing.Size(650, 474);
            this.dgvEntidades.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 28);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ingresar tipo de entidad: ";
            // 
            // textTipoDeEntidad
            // 
            this.textTipoDeEntidad.Location = new System.Drawing.Point(265, 96);
            this.textTipoDeEntidad.Name = "textTipoDeEntidad";
            this.textTipoDeEntidad.Size = new System.Drawing.Size(402, 27);
            this.textTipoDeEntidad.TabIndex = 26;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(266, 156);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(369, 156);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 29);
            this.btnBorrar.TabIndex = 28;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(471, 156);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(94, 29);
            this.btnActualizar.TabIndex = 29;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(573, 156);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Busqueda: ";
            // 
            // textBusqueda
            // 
            this.textBusqueda.Location = new System.Drawing.Point(112, 217);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(555, 27);
            this.textBusqueda.TabIndex = 32;
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // frmRegistroDeTiposDeEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 764);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textTipoDeEntidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvEntidades);
            this.Controls.Add(this.btnAgregarGrupo);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.comboSeleccionarGrupoDeEntidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistroDeTiposDeEntidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de entidades";
            this.Load += new System.EventHandler(this.frmRegistroDeTiposDeEntidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboSeleccionarGrupoDeEntidad;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnAgregarGrupo;
        private System.Windows.Forms.DataGridView dgvEntidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTipoDeEntidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}