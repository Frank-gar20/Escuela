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
                SqlConnection cnx = new SqlConnection(connectionString);
                cnx.Open();
                return cnx;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a SQL Server:\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool ExecuteQuery(string query)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, GetConnection()))
                {
                    cmd.ExecuteNonQuery();
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
                using (var cnx = GetConnection())
                {
                    if (cnx != null && cnx.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Conexión exitosa a SQL Server.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo establecer conexión.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al probar conexión:\n" + ex.Message);
                return false;
            }
        }

        public DataTable getAlldata(string query)
        {
            DataTable dt = new DataTable();

            try
            {
                // 1. Obtener la conexión y asegurar que se cierra
                using (SqlConnection cnx = GetConnection())
                {
                    if (cnx == null) return null;

                    // 2. Crear el comando SQL
                    using (SqlCommand cmd = new SqlCommand(query, cnx))
                    {
                        // 3. Ejecutar la consulta para obtener el lector de datos
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // 4. Llenar las Columnas del DataTable
                            // Lo hacemos antes de empezar a leer las filas
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                // Agregamos el nombre de la columna y su tipo de dato
                                dt.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                            }

                            // 5. Llenar las Filas del DataTable (Usando un bucle)
                            // El método Read() avanza al siguiente registro y devuelve true si hay más.
                            while (reader.Read()) // Esto reemplaza el 'for' que mencionó el profe
                            {
                                object[] rowValues = new object[reader.FieldCount];
                                // Usamos un 'for' para leer todos los campos de la fila actual
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    rowValues[i] = reader.GetValue(i);
                                }
                                dt.Rows.Add(rowValues); // Agregar la fila al DataTable
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
