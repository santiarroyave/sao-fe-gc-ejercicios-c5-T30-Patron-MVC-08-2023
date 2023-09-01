using T30_Ejercicio01.Views;

namespace T30_Ejercicio01
{
    public partial class ViewInicio : Form
    {
        public ViewInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewNuevoCliente nuevoCliente = new ViewNuevoCliente();
            nuevoCliente.Show();
        }
    }
}