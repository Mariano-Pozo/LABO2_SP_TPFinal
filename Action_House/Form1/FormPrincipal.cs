using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Form1
{
    public partial class FormPrincipal : Form
    {
        string connectionString = "Server=DESKTOP-8A3M14H;Initial Catalog=tp2;User ID=sa;Password=arbolitos;TrustServerCertificate=true";
        ListaGenerica<string> listaCompras = new ListaGenerica<string>();
        public FormPrincipal()
        {
            InitializeComponent();
            ColumnasLista(connectionString, "SELECT * FROM ItemsListados");

        }

        /// <summary>
        /// Llena un DataGridView con datos provenientes de una base de datos utilizando la conexión y la consulta proporcionadas.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión para la base de datos.</param>
        /// <param name="query">Consulta SQL para obtener los datos.</param>
        private void ColumnasLista(string connectionString, string query)
        {
            // Crea un DataTable para almacenar los datos
            DataTable dataTable = new DataTable();

            // Usa la cadena de conexión para establecer una conexión a la base de datos
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                // Crea un SqlDataAdapter y llena el DataTable con los datos obtenidos de la base de datos
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dataTable);
            }

            // Asigna el DataTable como origen de datos para el DataGridView
            dataGridView1.DataSource = dataTable;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ColumnasLista(connectionString, "SELECT * FROM ItemsListados");
        }

        DataBaseConnection conexion = new DataBaseConnection();
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Construye la consulta de inserción utilizando valores de los controles de la interfaz de usuario
                string query = "INSERT INTO ItemsListados (Tipo,Nombre,Cantidad,Tiempo,Estado,Precio)" +
                    "VALUES" + $"('{comboBoxTipo.Text}', '{textBoxNombre.Text}', {textBoxCantidad.Text}, GETDATE(), {textBoxEstado.Text}, {textBoxPrecio.Text})";
                // Crea un comando SqlCommand con la consulta y la conexión obtenida de un objeto de conexión (presumiblemente 'conexion')
                SqlCommand command = new SqlCommand(query, conexion.GetConexion());
                conexion.AbrirConexion();
                // Ejecuta la consulta de inserción en la base de datos
                command.ExecuteNonQuery();
                MessageBox.Show("se agregó correctamente");
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar " + ex.Message);
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            BorrarItem();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            ColumnasLista(connectionString, "SELECT * FROM ItemsListados");
            MessageBox.Show("Actualizado!");
        }

        /// <summary>
        /// Elimina un elemento seleccionado en el DataGridView de la base de datos.
        /// </summary>
        public void BorrarItem()
        {
            // Obtiene el valor del campo "ID" de la fila seleccionada en el DataGridView
            object idABorrar = dataGridView1.CurrentRow.Cells["ID"].Value;
            // Construye la consulta de eliminación utilizando el ID obtenido
            string consulta = $"DELETE FROM ItemsListados WHERE ID = {idABorrar}";
            conexion.AbrirConexion();
            // Crea un comando SqlCommand con la consulta de eliminación y la conexión obtenida de un objeto de conexión (presumiblemente 'conexion')
            using (SqlCommand command = new SqlCommand(consulta, conexion.GetConexion()))
            {
                // Ejecuta la consulta de eliminación en la base de datos y obtiene el número de filas afectadas
                int nroFilas = command.ExecuteNonQuery();
                // Muestra un mensaje si se eliminó exitosamente al menos una fila
                if (nroFilas > 0)
                {
                    MessageBox.Show("Item eliminado");
                }
            }
            conexion.CerrarConexion();
        }

        private void buttonFiltroPelotas_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ItemsListados WHERE Tipo = 'Pelota'";
            ColumnasLista(connectionString, query);
        }

        private void buttonFiltroMotos_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ItemsListados WHERE Tipo = 'Moto'";
            ColumnasLista(connectionString, query);
        }

        private void buttonFiltroAutos_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ItemsListados WHERE Tipo = 'Auto'";
            ColumnasLista(connectionString, query);
        }

        /// <summary>
        /// Maneja el evento de clic del botón para realizar una compra de un artículo.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            // Obtiene la fecha y hora actual para generar un nombre de archivo único en formato CSV
            string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string nombreArchivo = $"Compra_{fechaHoraActual}.csv";
            string rutaArchivo = @"C:\Users\Inoue\Desktop\tp2\" + nombreArchivo;

            // Obtiene el ID del artículo seleccionado en el DataGridView
            object idAComprar = dataGridView1.CurrentRow.Cells["ID"].Value;

            // Consulta para obtener información del artículo a comprar utilizando su ID
            string consulta = $"SELECT * FROM ItemsListados WHERE ID = {idAComprar}";

            conexion.AbrirConexion();

            // Crea un archivo CSV para registrar la compra o agrega a uno existente
            using (StreamWriter writer = File.Exists(rutaArchivo) ? File.AppendText(rutaArchivo) : new StreamWriter(rutaArchivo))
            {
                // Ejecuta la consulta para obtener la información del artículo
                using (SqlCommand command = new SqlCommand(consulta, conexion.GetConexion()))
                {
                    using (SqlDataReader lector = command.ExecuteReader())
                    {
                        // Lee los datos del artículo y realiza operaciones relacionadas con la compra
                        while (lector.Read())
                        {
                            // Obtiene información del artículo
                            string nombreItem = lector["Nombre"].ToString();
                            int cantidadItem = Convert.ToInt16(lector["Cantidad"]);
                            double precioItem = Convert.ToDouble(lector["Precio"]);
                            double precioTotal = precioItem * cantidadItem;

                            // Construye un mensaje con los detalles de la compra
                            string mostrarProducto = $"Nombre producto: {nombreItem} \nCantidad: {cantidadItem} \nPrecio: {precioItem} \n" +
                                $"--------------------\nTotal: {precioTotal}";

                            // Agrega los detalles de la compra a una lista y al archivo CSV
                            listaCompras.Push(mostrarProducto);
                            writer.WriteLine(mostrarProducto);

                            MessageBox.Show($"{mostrarProducto}");
                        }
                    }
                }
            }
            conexion.CerrarConexion();

            // Elimina el artículo de la base de datos
            BorrarItem();

            // Actualiza el DataGridView mostrando las columnas de ItemsListados
            ColumnasLista(connectionString, "SELECT * FROM ItemsListados");
        }

        /// <summary>
        /// Maneja un evento que muestra un mensaje de confirmación de cierre.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        public void cartel(object sender, EventArgs e)
        {
            // Llama al método ConfirmacionCierre de la clase MensajeAsync para mostrar un mensaje de confirmación de cierre
            MensajeAsync.ConfirmacionCierre();
        }

        private void buttonCerrarFormPrincipal_Click(object sender, EventArgs e)
        {

        }

    }
}
