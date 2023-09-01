

using T30_Ejercicio01.Controller;

namespace T30_Ejercicio01
{
    public partial class ViewInicio : Form
    {
        ClienteController clienteController = new ClienteController();
        public ViewInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            //int id;
            //string nombre;
            //string apellidos;
            //string direccion;
            //string dni;
            //DateTime fecha;
            string id = txtID.Text;
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string direccion = txtDireccion.Text;
            string dni = txtDNI.Text;
            DateTime fecha = dateTimeSelector.Value;

            try
            {
                clienteController.NuevoCliente(id, nombre, apellidos, direccion, dni, fecha);
                txtID.Text = "";
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtDireccion.Text = "";
                txtDNI.Text = "";
                dateTimeSelector.Value = DateTime.Now;
            }
            catch
            {
                MessageBox.Show("Error al guardar, datos incorrectos");
            }


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}