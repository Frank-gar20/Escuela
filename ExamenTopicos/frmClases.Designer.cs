namespace ExamenTopicos
{
    partial class frmClases
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
            this.cbIdProfesor = new System.Windows.Forms.ComboBox();
            this.cbIdAlumno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreClase = new System.Windows.Forms.TextBox();
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
            this.TBPaginacion.Size = new System.Drawing.Size(732, 405);
            this.TBPaginacion.TabIndex = 1;
            // 
            // tbAgregar
            // 
            this.tbAgregar.Controls.Add(this.cbIdProfesor);
            this.tbAgregar.Controls.Add(this.cbIdAlumno);
            this.tbAgregar.Controls.Add(this.label3);
            this.tbAgregar.Controls.Add(this.label1);
            this.tbAgregar.Controls.Add(this.label2);
            this.tbAgregar.Controls.Add(this.txtNombreClase);
            this.tbAgregar.Controls.Add(this.btnAgregar);
            this.tbAgregar.Location = new System.Drawing.Point(4, 22);
            this.tbAgregar.Name = "tbAgregar";
            this.tbAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbAgregar.Size = new System.Drawing.Size(724, 379);
            this.tbAgregar.TabIndex = 0;
            this.tbAgregar.Text = "Agregar Clase";
            this.tbAgregar.UseVisualStyleBackColor = true;
            // 
            // cbIdProfesor
            // 
            this.cbIdProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdProfesor.FormattingEnabled = true;
            this.cbIdProfesor.Location = new System.Drawing.Point(151, 167);
            this.cbIdProfesor.Name = "cbIdProfesor";
            this.cbIdProfesor.Size = new System.Drawing.Size(110, 32);
            this.cbIdProfesor.TabIndex = 11;
            // 
            // cbIdAlumno
            // 
            this.cbIdAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdAlumno.FormattingEnabled = true;
            this.cbIdAlumno.Location = new System.Drawing.Point(151, 113);
            this.cbIdAlumno.Name = "cbIdAlumno";
            this.cbIdAlumno.Size = new System.Drawing.Size(110, 32);
            this.cbIdAlumno.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID Profesor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre Clase:";
            // 
            // txtNombreClase
            // 
            this.txtNombreClase.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreClase.Location = new System.Drawing.Point(151, 65);
            this.txtNombreClase.Name = "txtNombreClase";
            this.txtNombreClase.Size = new System.Drawing.Size(194, 28);
            this.txtNombreClase.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(422, 118);
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
            this.tbMostrar.Size = new System.Drawing.Size(724, 379);
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
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buscar (Nombre):";
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
            // frmClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 438);
            this.Controls.Add(this.TBPaginacion);
            this.Name = "frmClases";
            this.Text = "Clases";
            this.Activated += new System.EventHandler(this.frmClases_Activated);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreClase;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TabPage tbMostrar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIdProfesor;
        private System.Windows.Forms.ComboBox cbIdAlumno;
        private System.Windows.Forms.ContextMenuStrip cmsEditarEliminar;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}