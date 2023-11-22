using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{

    public static class SqlConnectionExtensions
    {
        /// <summary>
        /// Ejecuta una consulta en la base de datos usando la conexión establecida y devuelve un SqlDataReader.
        /// </summary>
        /// <param name="connection">La conexión a la base de datos.</param>
        /// <param name="consulta">La consulta SQL a ejecutar.</param>
        /// <returns>Un SqlDataReader con los resultados de la consulta.</returns>
        public static SqlDataReader EjecutarConsulta(this SqlConnection connection, string consulta)
        {
            using (SqlCommand command = new SqlCommand(consulta, connection))
            {
                return command.ExecuteReader();
            }
        }
        
        /// <summary>
        /// Inserta una fila en la tabla especificada con las columnas y valores proporcionados.
        /// </summary>
        /// <param name="connection">La conexión a la base de datos.</param>
        /// <param name="tabla">El nombre de la tabla donde se insertará la fila.</param>
        /// <param name="columnas">Array de strings que representa las columnas de la tabla.</param>
        /// <param name="valores">Array de objetos que contiene los valores a insertar en las columnas correspondientes.</param>
        public static void InsertarFila(this SqlConnection connection, string tabla, string[] columnas, object[] valores)
        {
            if (columnas.Length != valores.Length)
            {
                throw new ArgumentException("La cantidad de columnas y valores deben ser iguales");
            }
            
            string columnasStr = string.Join(", ", columnas);
            string valoresParametrizados = string.Join(", ", Enumerable.Range(0, valores.Length).Select(i => $"@param{i}"));

            string consulta = $"INSERT INTO {tabla} ({columnasStr}) VALUES ({valoresParametrizados})";

            using (SqlCommand command = new SqlCommand(consulta, connection))
            {
                for (int i = 0; i < valores.Length; i++)
                {
                    command.Parameters.AddWithValue($"@param{i}", valores[i]);
                }
                
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Crea una tabla en la base de datos con el nombre y columnas especificadas.
        /// </summary>
        /// <param name="connection">La conexión a la base de datos.</param>
        /// <param name="nombreTabla">El nombre de la tabla a crear.</param>
        /// <param name="columnas">Array de strings que representa las columnas de la tabla a crear.</param>
        public static void CrearTabla(this SqlConnection connection, string nombreTabla, string[] columnas)
        {
            string columnasStr = string.Join(", ", columnas);
            string consulta = $"CREATE TABLE {nombreTabla} ({columnasStr})";

            using (SqlCommand command = new SqlCommand(consulta, connection))
            {
                command.ExecuteNonQuery();
            }
        }

    }
}