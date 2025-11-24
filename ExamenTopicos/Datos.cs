using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenTopicos
{
    internal class Datos
    {
        private string connectionString =
            "Server=LAPTOP-HUOTB082;Database=Escuela;Trusted_Connection=True;";

        private SqlConnection GetConnection()
        {
            try
            {
                SqlConnection conectar = new SqlConnection(connectionString);
                conectar.Open();
                return conectar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a SQL Server:\n" + ex.Message,
                    "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool ExecuteQuery(string query)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand(query, GetConnection()))
                {
                    comando.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta:\n" + ex.Message,
                    "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool TestConnection()
        {
            try
            {
                using (var conectar = GetConnection())
                {
                    if (conectar != null && conectar.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Conexion exitosa a SQLServer",
                            "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo establecer conexión",
                            "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de prueba en conexión:\n" + ex.Message);
                return false;
            }
        }

        public DataTable getAlldata(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conectar = GetConnection())
                {
                    if (conectar == null)
                        return null;

                    using (SqlCommand cmd = new SqlCommand(query, conectar))
                    {
                        using (SqlDataReader leer = cmd.ExecuteReader())
                        {
                            for (int i = 0; i < leer.FieldCount; i++)
                            {
                                dt.Columns.Add(leer.GetName(i), leer.GetFieldType(i));
                            }

                            while (leer.Read())
                            {
                                object[] datos = new object[leer.FieldCount];
                                for (int i = 0; i < leer.FieldCount; i++)
                                {
                                    datos[i] = leer.GetValue(i);
                                }
                                dt.Rows.Add(datos);
                            }
                        }
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al extraer datos:\n" + ex.Message,
                    "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
