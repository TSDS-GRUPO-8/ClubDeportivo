using ClubDeportivo.Clases;

namespace ClubDeportivo
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panelNav.Visible = true;
            btnCerrarSesion.Visible = false;
            panelAdmin.Visible = true;
            panelAdmin.BringToFront();

            AbrirEnPanel(new Home());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (usuario == "admin" && contrasena == "1234")
            {
                MessageBox.Show("Bienvenido");

                // Ocultamos el overlay
                panelAdmin.Visible = false;

                // Mostramos la navegaci�n
                panelNav.Visible = true;
                btnCerrarSesion.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos");
            }

        }

        public void AbrirEnPanel(Form formulario)
        {
            panelContainer.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;


            panelContainer.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnInscri_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new Inscripcion(this));
        }



        private void button2_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new Pago(this));
        }


        private void button4_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new Socio(this));
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Ocultar navegaci�n
            panelNav.Visible = true;
            btnCerrarSesion.Visible = false;
            AbrirEnPanel(new Home());

            // Mostrar panel de login
            panelAdmin.Visible = true;
            panelAdmin.BringToFront();

            // Limpiar campos de login
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        private void panelAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new ClubDeportivo.Forms.NoSocio(this));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
