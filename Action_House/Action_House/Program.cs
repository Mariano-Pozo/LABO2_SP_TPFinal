using System;
using Entidades;


namespace Auction_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-8A3M14H;Initial Catalog=tp2;User ID=sa;Password=arbolitos;TrustServerCertificate=true";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa");

                    // Ejemplo de uso de los métodos de extensión
                    connection.CrearTabla("NuevaTabla223", new[] { "ID INT PRIMARY KEY", "Nombre VARCHAR(50)" });
                    connection.InsertarFila("NuevaTabla223", new[] { "ID", "Nombre" }, new object[] { 123, "valor2" });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            Console.ReadLine();
            
        }
    }
}