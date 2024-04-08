using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperar_contrasena.Classes
{
    class conexion
    {
        NpgsqlConnection conn = new NpgsqlConnection();

        static string servidor = "localhost";
        static string db = "login_Software";
        static string usuario = "postgres";
        static string password = "J@s1115";
        static string puerto = "5433";

        string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + password + ";" + "Database=" + db + ";";

        public bool ActualizarContraseña(string usuario, string nombreCompleto, string telefono, string nuevaContrasena, string repetirContrasena)
        {

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(cadenaConexion))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT COUNT(*) FROM usuarios WHERE nombre_completo = @nombreCompleto AND telefono = @telefono AND usuario = @usuario";
                        cmd.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                        cmd.Parameters.AddWithValue("@telefono", telefono);
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        //int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // Mostrar la consulta que se está ejecutando (para depurar)
                        MessageBox.Show("Consulta SQL: " + cmd.CommandText);

                        // Mostrar los valores de los parámetros (para depurar)
                        MessageBox.Show("Valores de los parámetros: " + nombreCompleto + ", " + telefono + ", " + usuario);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        MessageBox.Show("El número es: " + count);

                        if (count > 0)
                        {
                            if (nuevaContrasena == repetirContrasena)
                            {
                                cmd.CommandText = "UPDATE usuarios SET contrasena = @nuevaContrasena WHERE nombre_completo = @nombreCompleto AND telefono = @telefono AND usuario = @usuario";
                                cmd.Parameters.AddWithValue("@nuevaContrasena", nuevaContrasena);
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Contraseña actualizada exitosamente.");
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Error al actualizar la contraseña.");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("La contraseñas no coinciden.");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la contraseña: " + ex.Message);
                return false;
            }
        }
    }

}
