namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Black;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            MensajeAsync.ConfirmacionCierre();
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            textBox_username.Clear();
            textBox_password.Clear();
        }

        
        private void button_login_Click(object sender, EventArgs e)
        {
            string usuario = textBox_username.Text;
            string pass = textBox_password.Text;

            if (LoginHelper.Login(usuario, pass))
            {
                this.Hide();
                FormPrincipal formPrincipal = new FormPrincipal();
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Error en Login");
            }
           
        }
        
    }
}