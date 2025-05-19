using ClubDeportivo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class Inscripcion : Form
    {
        private FormPrincipal principal;
        public Inscripcion(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.principal = formPrincipal;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            principal.AbrirEnPanel(new Home());

        }

        private void btnIngresar_Click(object sender, EventArgs e)
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

        private void Inscripcion_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioRegistro();
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
