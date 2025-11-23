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
    public partial class frmProfesores : Form
    {
        int id = -1;
        Datos datos = new Datos();
        private void mostrarDatos()
        {
            DataTable dt = datos.getAlldata("select * from profesores order by id_profesor");
            if (dt != null)
            {
                dgvDatos.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error al cargar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public frmProfesores()
        {
            InitializeComponent();
        }

        private void frmProfesores_Activated(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}
