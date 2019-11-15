using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppOdontologia.Conexion
{
    class SqlConexion
    {
        public System.Data.SqlClient.SqlConnection conexion()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.conexion);

            con.Open();

            return con;
        }

        public int Ejecutar(String query)
        {
            int resultado = 0;
            try
            {
                SqlCommand Ejecutar = new SqlCommand(query, conexion());
                resultado = Ejecutar.ExecuteNonQuery();
                conexion().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }
        public void LlenarGrid(String sql, DataGridView grid)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion());
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
                conexion().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar datos", "Error" + ex.Message , MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
