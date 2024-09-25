using Rosales_WaterLevel_Monitor.Configuracion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rosales_WaterLevel_Monitor.Controllers;

namespace Rosales_WaterLevel_Monitor.Modelos
{
    internal class UsuariosModel
    {
        public int IDUSUARIO {  get; set; }
        public string USUARIO { get; set; }
        public string CONTRASENA { get; set; }
   
        public UsuariosModel() { }

        public static UsuariosModel Insertar(UsuariosModel usuario)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO USUARIOS (USUARIO, CONTRASENA) " +
                                   "OUTPUT INSERTED.IDUSUARIO, INSERTED.USUARIO, INSERTED.CONTRASENA" +
                                   "VALUES (@USUARIO, @CONTRASENA)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@USUARIO", usuario.USUARIO);
                        comando.Parameters.AddWithValue("@CONTRASENA", usuario.CONTRASENA);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new UsuariosModel
                                {
                                    IDUSUARIO = Convert.ToInt32(lector["IDUSUARIO"]),
                                    USUARIO = lector["USUARIO"].ToString(),
                                    CONTRASENA = lector["CONTRASENA"].ToString(),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el usuario.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el usuario.");
            }
            return null;
        }

        public static string Actualizar(UsuariosModel usuario)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE USUARIOS SET USUARIO = @USUARIO, CONTRASENA = @CONTRASENA WHERE IDUSUARIO = @IDUSUARIO";


                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IDUSUARIO", usuario.IDUSUARIO.ToString());
                        comando.Parameters.AddWithValue("@USUARIO", usuario.USUARIO.ToString());
                        comando.Parameters.AddWithValue("@CONTRASENA", usuario.CONTRASENA.ToString());
                        comando.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar el usuario.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el usuario.");
                return "Error";
            }
        }

        public static string Eliminar(int IDUSUARIO)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM USUARIO WHERE IDUSUARIO = @IDUSUARIO";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IDUSUARIO", IDUSUARIO);
                        comando.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar el usuario.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el usuario.");
                return "Error";
            }
        }

        public static UsuariosModel ObtenerPorId(int IDUSUARIO)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM USUARIOS WHERE IDUSUARIO = @IDUSUARIO";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IDUSUARIO", IDUSUARIO);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new UsuariosModel
                                {
                                    IDUSUARIO = Convert.ToInt32(lector["IDUSUARIO"]),
                                    USUARIO = lector["USUARIO"].ToString(),
                                    CONTRASENA = lector["CONTRASENA"].ToString(),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el usuario.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el usuario.");
            }
            return null;
        }

        public static List<UsuariosModel> ObtenerTodos()
        {
            var usuarios = new List<UsuariosModel>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM USUARIOS";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                usuarios.Add(new UsuariosModel
                                {
                                    IDUSUARIO = Convert.ToInt32(lector["IDUSUARIO"]),
                                    USUARIO = lector["USUARIO"].ToString(),
                                    CONTRASENA = lector["CONTRASENA"].ToString(),
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de usuarios.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de usuarios.");
            }

            return usuarios;
        }
        public static UsuariosModel Autenticar(string USUARIO, string CONTRASENA)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    string consulta = "SELECT * FROM USUARIOS WHERE USUARIO = @USUARIO AND CONTRASENA = @CONTRASENA";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@USUARIO", USUARIO);
                        comando.Parameters.AddWithValue("@CONTRASENA", CONTRASENA);
                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {

                                return new UsuariosModel
                                {
                                    IDUSUARIO = Convert.ToInt32(lector["IDUSUARIO"]),
                                    USUARIO = lector["USUARIO"].ToString(),
                                    CONTRASENA = lector["CONTRASENA"].ToString(),
                                };
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de SQL al autenticar el usuario: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al autenticar el usuario: " + ex.Message);
            }
        }
        public UsuariosModel OtroAutenticar(string USUARIO, string CONTRASENA)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    string consulta = "SELECT * FROM USUARIOS WHERE USUARIO ='" + USUARIO + "'";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                if (lector["CONTRASENA"].ToString() == CONTRASENA)
                                {
                                    return new UsuariosModel
                                    {
                                        IDUSUARIO = Convert.ToInt32(lector["IDUSUARIO"]),
                                        USUARIO = lector["USUARIO"].ToString(),
                                        CONTRASENA = lector["CONTRASENA"].ToString(),
                                    };
                                }
                                else
                                {
                                    return null;
                                }


                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de SQL al autenticar el usuario: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al autenticar el usuario: " + ex.Message);
            }
        }


    }
}
