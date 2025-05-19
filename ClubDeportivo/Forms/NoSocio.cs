using ClubDeportivo.BBDD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Forms
{
    public partial class NoSocio : Form
    {
        private FormPrincipal principal;
        public NoSocio(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.principal = formPrincipal;
        }

        private void dgvNoSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NoSocio_Load(object sender, EventArgs e)
        {
            CargarNoSociosDesdeBD();
        }

        private void CargarNoSociosDesdeBD()
        {
            var con = ConexionMySQL.ObtenerConexion();

            string query = "SELECT nombre AS NOMBRE, apellido AS APELLIDO, dni AS DNI, telefono AS TELEFONO, ficha_medica AS FICHA_MEDICA, activo AS ACTIVO, fecha_inscripcion AS FECHA_INSCRIPCION FROM no_socios";

            try
            {
                using (con)
                {
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, con);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvNoSocios.AutoGenerateColumns = true;
                    dgvNoSocios.Columns.Clear();
                    dgvNoSocios.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los no socios: " + ex.Message);
            }
        }

        private void NoSocio_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            principal.AbrirEnPanel(new Home());
        }
    }
}
