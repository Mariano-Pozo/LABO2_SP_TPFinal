using System.Data.SqlClient;

namespace Entidades
{
    public class DataBaseConnection : IConexion
    {
        public SqlConnection conexion = new SqlConnection("Server=DESKTOP-8A3M14H;Initial Catalog=tp2;User ID=sa;Password=arbolitos;TrustServerCertificate=true");

        public SqlConnection GetConexion() => conexion;

        public void AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
        }
        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
