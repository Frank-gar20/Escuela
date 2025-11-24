using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenTopicos
{
    public partial class frmClases : Form
    {
        int id = -1;
        Datos datos = new Datos();
        private void mostrarDatos()
        {
            DataTable dt = datos.getAlldata("select * from clases order by id_clase");
            if (dt != null)
            {
                dgvDatos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Limpiar()
        {
            txtNombreClase.Text = string.Empty;
            cbIdAlumno.SelectedIndex = 0;
            cbIdProfesor.SelectedIndex = 0;
            this.id = -1;
            btnAgregar.Text = "Agretar";
        }

        public frmClases()
        {
            InitializeComponent();
        }

        private void CargarAlumnos()
        {
            DataTable dtAlumnos = datos.getAlldata("SELECT id_alumno, nombre AS Nombre FROM alumnos ORDER BY id_alumno");

            if (dtAlumnos != null)
            {
                cbIdAlumno.DataSource = dtAlumnos;
                cbIdAlumno.DisplayMember = "Nombre";
                cbIdAlumno.ValueMember = "id_alumno";
            }
        }

        private void CargarProfesores()
        {
            DataTable dtProfesores = datos.getAlldata("SELECT id_profesor, nombre AS Nombre FROM profesores ORDER BY id_profesor");

            if (dtProfesores != null)
            {
                cbIdProfesor.DataSource = dtProfesores;
                cbIdProfesor.DisplayMember = "Nombre";
                cbIdProfesor.ValueMember = "id_profesor";
            }
        }
        private void frmClases_Activated(object sender, EventArgs e)
        {
            mostrarDatos();

            if (cbIdAlumno.Items.Count == 0)
            {
                CargarAlumnos();
            }

            if (cbIdProfesor.Items.Count == 0)
            {
                CargarProfesores();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(txtNombreClase.Text)))
                {
                    bool resultado;
                    Datos data = new Datos();

                    if (id == -1)
                    {
                        string query = "INSERT INTO clases (nombre, id_profesor, id_alumno) " +
                             "VALUES ('" + txtNombreClase.Text + "', " + Convert.ToInt32(cbIdProfesor.SelectedValue) + ", " + Convert.ToInt32(cbIdAlumno.SelectedValue)+")";

                        resultado = data.ExecuteQuery(query);
                        if (resultado)
                        {
                            MessageBox.Show("Registro agregado", "Sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el registro", "Sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string query = "UPDATE clases SET " +
                             "nombre = '" + txtNombreClase.Text + "', " +
                             "id_profesor = " + Convert.ToInt32(cbIdProfesor.SelectedValue) + ", " +
                             "id_alumno = " + Convert.ToInt32(cbIdAlumno.SelectedValue) +
                             " WHERE id_profesor = " + id;
                        resultado = data.ExecuteQuery(query);
                        if (resultado)
                        {
                            MessageBox.Show("Registro Acutalizdo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al Actualizar el registro", "Sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Verifica los datos de los campos", "Sistema",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifica los datos de los campos \n Error: " + ex.Message, "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = datos.getAlldata("select * from clases where " +
                "nombre like '%" + txtBuscar.Text + "%'");
            if (dt != null)
            {
                dgvDatos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = dgvDatos[0, dgvDatos.CurrentCell.RowIndex].Value.ToString();
            bool resultado;
            Datos datos = new Datos();
            if (MessageBox.Show("¿estas seguro de Borrar?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string query = "Delete from clases where id_clase = " + id;
                resultado = datos.ExecuteQuery(query);
                if (resultado)
                {
                    MessageBox.Show("Registro Eliminado", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void CargarDatos(int id)
        {
            DataTable dt = datos.getAlldata("SELECT * FROM clases WHERE id_clase = " + id);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                txtNombreClase.Text = row["nombre"].ToString();
                cbIdProfesor.Text = row["id_profesor"].ToString();
                cbIdAlumno.Text = row["id_alumno"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el Alumno", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvDatos[0, dgvDatos.CurrentCell.RowIndex].Value);
                CargarDatos(id);
                TBPaginacion.SelectedTab = tbAgregar;
                btnAgregar.Text = "Actualizar";
                this.id = id;
            }
        }
    }
}
