using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class LoginRepository
    {
        /// <summary>
        /// Método estático que verifica las credenciales del usuario para el inicio de sesión.
        /// </summary>
        /// <param name="usuario">Nombre de usuario.</param>
        /// <param name="pass">Contraseña del usuario.</param>
        /// <returns>True si las credenciales son válidas; de lo contrario, False.</returns>
        public static bool Login(string usuario, string pass)
        {
            string connectionString = "Data Source=DESKTOP-8A3M14H; Initial Catalog=tp2;Integrated Security=True";
            //string connectionString = "Server=DESKTOP-8A3M14H;Initial Catalog=tp2;User ID=sa;Password=arbolitos;TrustServerCertificate=true";
            string consulta = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Password"; // Consulta parametrizada "@"

            int count = 0;

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    count = ObtenerCantidadUsuarios(conexion, consulta, usuario, pass);
                }
            }
            catch (SqlException ex)
            {
                // Manejo de excepciones de SQL
                Console.WriteLine("Error de SQL: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                // Otros tipos de excepciones
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            return count > 0; // Si count es mayor que 0, las credenciales son válidas
        }

        /// <summary>
        /// Método privado que obtiene la cantidad de usuarios que coinciden con el usuario y la contraseña dados.
        /// </summary>
        /// <param name="conexion">Objeto SqlConnection para la conexión a la base de datos.</param>
        /// <param name="consulta">Consulta SQL parametrizada para verificar las credenciales.</param>
        /// <param name="usuario">Nombre de usuario.</param>
        /// <param name="pass">Contraseña del usuario.</param>
        /// <returns>El número de usuarios que coinciden con las credenciales dadas.</returns>
        private static int ObtenerCantidadUsuarios(SqlConnection conexion, string consulta, string usuario, string pass)
        {
            int count = 0;

            try
            {
                SqlCommand command = new SqlCommand(consulta, conexion);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Password", pass);

                conexion.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de SQL: " + ex.Message);
                throw; // Relanzar la excepción para manejo superior si es necesario
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw; // Relanzar la excepción para manejo superior si es necesario
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close(); // Asegurarse de cerrar la conexión en todos los casos
                }
            }

            return count;
        }

    }
}
