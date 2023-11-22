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

        private void ColumnasLista(string connectionString, string query)
        {
            //string query = "SELECT * FROM ItemsListados";
            DataTable dataTab = new DataTable();
            //string connectionString = "Server=DESKTOP-8A3M14H;Initial Catalog=tp2;User ID=sa;Password=arbolitos;TrustServerCertificate=true";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {

                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dataTab);

            }
            dataGridView1.DataSource = dataTab;
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
                string query = "INSERT INTO ItemsListados (Tipo,Nombre,Cantidad,Tiempo,Estado,Precio)" +
                    "VALUES" + $"('{comboBoxTipo.Text}', '{textBoxNombre.Text}', {textBoxCantidad.Text}, GETDATE(), {textBoxEstado.Text}, {textBoxPrecio.Text})";
                SqlCommand command = new SqlCommand(query, conexion.GetConexion());
                conexion.AbrirConexion();
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
        public void BorrarItem()
        {
            object idABorrar = dataGridView1.CurrentRow.Cells["ID"].Value;
            string consulta = $"DELETE FROM ItemsListados WHERE ID = {idABorrar}";

            conexion.AbrirConexion();

            using (SqlCommand command = new SqlCommand(consulta, conexion.GetConexion()))
            {
                int nroFilas = command.ExecuteNonQuery();

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

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string nombreArchivo = $"Compra_{fechaHoraActual}.csv";
            string rutaArchivo = @"C:\Users\Inoue\Desktop\tp2\" + nombreArchivo;

            object idAComprar = dataGridView1.CurrentRow.Cells["ID"].Value;
            string consulta = $"SELECT * FROM ItemsListados WHERE ID = {idAComprar}";

            conexion.AbrirConexion();
            using (StreamWriter writer = File.Exists(rutaArchivo) ? File.AppendText(rutaArchivo) : new StreamWriter(rutaArchivo))
            {
                using (SqlCommand command = new SqlCommand(consulta, conexion.GetConexion()))
                {
                    using (SqlDataReader lector = command.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            string nombreItem = lector["Nombre"].ToString();
                            int cantidadItem = Convert.ToInt16(lector["Cantidad"]);
                            double precioItem = Convert.ToDouble(lector["Precio"]);
                            double precioTotal = precioItem * cantidadItem;


                            string mostrarProducto = $"Nombre producto: {nombreItem} \nCantidad: {cantidadItem} \nPrecio: {precioItem} \n" +
                                $"--------------------\nTotal: {precioTotal}";
                            listaCompras.Push(mostrarProducto);
                            writer.WriteLine(mostrarProducto);
                            MessageBox.Show($"{mostrarProducto}");
                        }
                    }
                }
            }
            conexion.CerrarConexion();
            BorrarItem();
            ColumnasLista(connectionString, "SELECT * FROM ItemsListados");
        }

        public void cartel(object sender, EventArgs e)
        {
            MensajeAsync.ConfirmacionCierre();
        }

        private void buttonCerrarFormPrincipal_Click(object sender, EventArgs e)
        {

        }

    }
}
