using System.Data.SqlClient;

namespace Entidades
{
    /// <summary>
    /// Clase que representa una conexión a la base de datos implementando la interfaz IConexion.
    /// </summary>
    public class DataBaseConnection : IConexion
    {
        /// <summary>
        /// SqlConnection utilizada para la conexión a la base de datos.
        /// </summary>
        public SqlConnection conexion = new SqlConnection("Server=DESKTOP-8A3M14H;Initial Catalog=tp2;User ID=sa;Password=arbolitos;TrustServerCertificate=true");

        /// <summary>
        /// Obtiene la conexión SqlConnection.
        /// </summary>
        /// <returns>La conexión SqlConnection.</returns>
        public SqlConnection GetConexion() => conexion;

        /// <summary>
        /// Abre la conexión a la base de datos si está cerrada.
        /// </summary>
        public void AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        /// <summary>
        /// Cierra la conexión a la base de datos si está abierta.
        /// </summary>
        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
