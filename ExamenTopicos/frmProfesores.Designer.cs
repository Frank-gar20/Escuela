namespace ExamenTopicos
{
    partial class frmProfesores
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
            this.TBPaginacion = new System.Windows.Forms.TabControl();
            this.tbAgregar = new System.Windows.Forms.TabPage();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNoTarjeta = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbMostrar = new System.Windows.Forms.TabPage();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmsEditarEliminar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.TBPaginacion.SuspendLayout();
            this.tbAgregar.SuspendLayout();
            this.tbMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.cmsEditarEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBPaginacion
            // 
            this.TBPaginacion.Controls.Add(this.tbAgregar);
            this.TBPaginacion.Controls.Add(this.tbMostrar);
            this.TBPaginacion.Location = new System.Drawing.Point(12, 12);
            this.TBPaginacion.Name = "TBPaginacion";
            this.TBPaginacion.SelectedIndex = 0;
            this.TBPaginacion.Size = new System.Drawing.Size(776, 426);
            this.TBPaginacion.TabIndex = 1;
            // 
            // tbAgregar
            // 
            this.tbAgregar.Controls.Add(this.dtpFechaNac);
            this.tbAgregar.Controls.Add(this.label6);
            this.tbAgregar.Controls.Add(this.label4);
            this.tbAgregar.Controls.Add(this.label3);
            this.tbAgregar.Controls.Add(this.label2);
            this.tbAgregar.Controls.Add(this.label1);
            this.tbAgregar.Controls.Add(this.txtNombre);
            this.tbAgregar.Controls.Add(this.txtEspecialidad);
            this.tbAgregar.Controls.Add(this.txtApellidos);
            this.tbAgregar.Controls.Add(this.txtNoTarjeta);
            this.tbAgregar.Controls.Add(this.btnAgregar);
            this.tbAgregar.Location = new System.Drawing.Point(4, 22);
            this.tbAgregar.Name = "tbAgregar";
            this.tbAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbAgregar.Size = new System.Drawing.Size(768, 400);
            this.tbAgregar.TabIndex = 0;
            this.tbAgregar.Text = "Agregar Profesor";
            this.tbAgregar.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(194, 200);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNac.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Especialidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "No. Tarjeta:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(140, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 28);
            this.txtNombre.TabIndex = 5;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidad.Location = new System.Drawing.Point(151, 245);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(194, 28);
            this.txtEspecialidad.TabIndex = 3;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(140, 147);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(194, 28);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtNoTarjeta
            // 
            this.txtNoTarjeta.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoTarjeta.Location = new System.Drawing.Point(140, 61);
            this.txtNoTarjeta.Name = "txtNoTarjeta";
            this.txtNoTarjeta.Size = new System.Drawing.Size(100, 28);
            this.txtNoTarjeta.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(483, 140);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbMostrar
            // 
            this.tbMostrar.Controls.Add(this.dgvDatos);
            this.tbMostrar.Controls.Add(this.label5);
            this.tbMostrar.Controls.Add(this.txtBuscar);
            this.tbMostrar.Location = new System.Drawing.Point(4, 22);
            this.tbMostrar.Name = "tbMostrar";
            this.tbMostrar.Padding = new System.Windows.Forms.Padding(3);
            this.tbMostrar.Size = new System.Drawing.Size(768, 400);
            this.tbMostrar.TabIndex = 1;
            this.tbMostrar.Text = "Almacenados";
            this.tbMostrar.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.ContextMenuStrip = this.cmsEditarEliminar;
            this.dgvDatos.Location = new System.Drawing.Point(24, 101);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(548, 198);
            this.dgvDatos.TabIndex = 2;
            // 
            // cmsEditarEliminar
            // 
            this.cmsEditarEliminar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.cmsEditarEliminar.Name = "cmsEditarEliminar";
            this.cmsEditarEliminar.Size = new System.Drawing.Size(118, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buscar (Nombre/Apellido):";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(24, 48);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(338, 29);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // frmProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBPaginacion);
            this.Name = "frmProfesores";
            this.Text = "Profesores";
            this.Activated += new System.EventHandler(this.frmProfesores_Activated);
            this.TBPaginacion.ResumeLayout(false);
            this.tbAgregar.ResumeLayout(false);
            this.tbAgregar.PerformLayout();
            this.tbMostrar.ResumeLayout(false);
            this.tbMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.cmsEditarEliminar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TBPaginacion;
        private System.Windows.Forms.TabPage tbAgregar;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNoTarjeta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TabPage tbMostrar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ContextMenuStrip cmsEditarEliminar;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}