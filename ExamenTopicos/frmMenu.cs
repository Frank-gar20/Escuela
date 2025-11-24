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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            frmAlumnos frmAlumnos = new frmAlumnos();
            frmAlumnos.Show();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            frmProfesores frmProfesores = new frmProfesores();
            frmProfesores.Show();
        }

        private void BtnClases_Click(object sender, EventArgs e)
        {
            frmClases frmClases = new frmClases();
            frmClases.Show();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            datos.TestConnection();
        }
    }
}
