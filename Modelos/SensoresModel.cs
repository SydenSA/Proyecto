using Rosales_WaterLevel_Monitor.Configuracion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rosales_WaterLevel_Monitor.Modelos
{
    internal class SensoresModel
    {
        public int IDSENSOR { get; set; }
        public string LOCALIZACION { get; set; }
        public string DESCRIPCION { get; set; }

        public SensoresModel() { }

        public static SensoresModel Insertar(SensoresModel LOCALIZACION)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO SENSORES (LOCALIZACION, DESCRIPCION) " +
                                   "OUTPUT INSERTED.IDSENSOR, INSERTED.LOCALIZACION, INSERTED.DESCRIPCION" +
                                   "VALUES (@LOCALIZACION, @DESCRIPCION)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@LOCALIZACION", LOCALIZACION.LOCALIZACION);
                        comando.Parameters.AddWithValue("@DESCRIPCION", LOCALIZACION.DESCRIPCION);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new SensoresModel
                                {
                                    IDSENSOR = Convert.ToInt32(lector["IDUSUARIO"]),
                                    LOCALIZACION = lector["USUARIO"].ToString(),
                                    DESCRIPCION = lector["CONTRASENA"].ToString(),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el sensor.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el sensor.");
            }
            return null;
        }

        public static string Actualizar(SensoresModel LOCALIZACION)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE SENSORES SET LOCALIZACION = @LOCALIZACION, DESCRIPCION = @DESCRIPCION WHERE IDSENSOR = @IDSENSOR";


                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IDSENSOR", LOCALIZACION.IDSENSOR.ToString());
                        comando.Parameters.AddWithValue("@LOCALIZACION", LOCALIZACION.LOCALIZACION.ToString());
                        comando.Parameters.AddWithValue("@DESCRIPCION", LOCALIZACION.DESCRIPCION.ToString());
                        comando.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar el sensor.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el sensor.");
                return "Error";
            }
        }

        public static string Eliminar(int IDSENSOR)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM SENSORES WHERE IDSENSOR = @IDSENSOR";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IDSENSOR", IDSENSOR);
                        comando.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar el sensor.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el sensor.");
                return "Error";
            }
        }

        public static SensoresModel ObtenerPorId(int IDSENSOR)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM SENSORES WHERE IDSENSOR = @IDSENSOR";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IDSENSOR", IDSENSOR);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new SensoresModel
                                {
                                    IDSENSOR = Convert.ToInt32(lector["IDSENSOR"]),
                                    LOCALIZACION = lector["LOCALIZACION"].ToString(),
                                    DESCRIPCION = lector["DESCRIPCION"].ToString(),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el sensor.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el sensor.");
            }
            return null;
        }

        public static List<SensoresModel> ObtenerTodos()
        {
            var sensor = new List<SensoresModel>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM SENSORES";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                sensor.Add(new SensoresModel
                                {
                                    IDSENSOR = Convert.ToInt32(lector["IDSENSOR"]),
                                    LOCALIZACION = lector["LOCALIZACION"].ToString(),
                                    DESCRIPCION = lector["DESCRIPCION"].ToString(),
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de sensor.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de sensor.");
            }

            return sensor;
        }


    }


}
