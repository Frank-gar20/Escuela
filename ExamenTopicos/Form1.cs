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
    public partial class frmAlumnos : Form
    {
        int id = -1;
        Datos datos = new Datos();
        private void mostrarDatos()
        {
            DataTable dt = datos.getAlldata("select * from alumnos order by id_alumno");
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
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtNoControl.Text = string.Empty;
            dtpFechaNac.Value = DateTime.Now;
            txtCorreo.Text = string.Empty;
            btnAgregar.Text = "Agregar";
            id = -1;
        }
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtNoControl.Text)))
                {
                    bool resultado;
                    Datos data = new Datos();

                    if (id == -1)
                    {
                        string query = "INSERT INTO alumnos (num_Control, nombre, apellido, fecha_nac, correo) " +
                             "VALUES ('" + txtNoControl.Text + "', '" + txtNombre.Text + "', '" + txtApellidos.Text + "', '" +
                             dtpFechaNac.Value.ToString("yyyy-MM-dd") + "', '" + txtCorreo.Text + "')";

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
                        string query = "UPDATE alumnos SET " +
                             "num_control = '" + txtNoControl.Text + "', " +
                             "nombre = '" + txtNombre.Text + "', " +
                             "apellido = '" + txtApellidos.Text + "', " +
                             "fecha_nac = '" + dtpFechaNac.Value.ToString("yyyy-MM-dd") + "', " +
                             "correo = '" + txtCorreo.Text + "' " +
                             "WHERE id_alumno = " + id;
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = dgvDatos[0, dgvDatos.CurrentCell.RowIndex].Value.ToString();
            bool resultado;
            Datos datos = new Datos();
            if (MessageBox.Show("¿estas seguro de Borrar?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string query = "Delete from alumnos where id_alumno = " + id;
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
            DataTable dt = datos.getAlldata("SELECT * FROM alumnos WHERE id_alumno = " + id);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                txtNoControl.Text = row["num_control"].ToString();
                txtNombre.Text = row["nombre"].ToString();
                txtApellidos.Text = row["apellido"].ToString();
                dtpFechaNac.Value = Convert.ToDateTime(row["fecha_nac"]);
                txtCorreo.Text = row["correo"].ToString();
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = datos.getAlldata("select * from alumnos where " +
                "nombre like '%" + txtBuscar.Text + "%' or " +
                "a_paterno like '%" + txtBuscar.Text + "%' or " +
                "a_materno like '%" + txtBuscar.Text + "%' or " +
                "No_Control like '%" + txtBuscar.Text + "%'");
            if (dt != null)
            {
                dgvDatos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
