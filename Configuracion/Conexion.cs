using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosales_WaterLevel_Monitor.Configuracion
{
    internal class Conexion
    {

        private static readonly string connectionString;

        static Conexion()
        {
            // Corregido el nombre de la instancia
            connectionString = ("Server=.;database=MonitoreoAgua;uid=sa;pwd=1234");
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}");
                Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
                throw;
            }
        }


    }
}
