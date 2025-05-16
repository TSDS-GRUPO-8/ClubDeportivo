using ClubDeportivo.Clases;

namespace ClubDeportivo
{
    public partial class FormRegistrarSocio : Form
    {
        public FormRegistrarSocio()
        {
            InitializeComponent();
            cmbFormaPago.Items.AddRange(new string[] { "Efectivo", "Tarjeta", "Débito" });
            cmbFormaPago.SelectedIndex = 0;
            nudMonto.Minimum = 1000;
            nudMonto.Maximum = 100000;
            nudMonto.Value = 30000; // Valor sugerido
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormRegistrarSocio_Load(object sender, EventArgs e)
        {

        }

        private void txtDNIPagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string dni = txtDNIPagar.Text.Trim();
            string formaPago = cmbFormaPago.SelectedItem.ToString();
            decimal monto = nudMonto.Value;

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingresá el DNI.");
                return;
            }

            try
            {
                Sistema sistema = new Sistema();
                string resultado = sistema.PagarCuota(dni, monto, formaPago);
                MessageBox.Show(resultado);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el pago: " + ex.Message);
            }
        }

        private void LimpiarFormulario()
        {
            txtDNI.Clear();
            cmbFormaPago.SelectedIndex = 0;
            nudMonto.Value = 5000;
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, completá todos los campos.");
                return;
            }

            try
            {
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string dni = txtDNI.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                bool fichaMedica = chkFichaMedica.Checked;
                DateTime fechaInscripcion = DateTime.Now;

                NoSocio nuevoNoSocio = new NoSocio(
                    fechaInscripcion,
                    nombre,
                    apellido,
                    dni,
                    telefono,
                    direccion,
                    fichaMedica
                );

                Sistema sistema = new Sistema();
                sistema.RegistrarNoSocio(nuevoNoSocio);

                MessageBox.Show("¡No Socio registrado correctamente!");
                LimpiarFormularioRegistro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el no socio: " + ex.Message);
            }
        }

        private void LimpiarFormularioRegistro()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            chkFichaMedica.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
