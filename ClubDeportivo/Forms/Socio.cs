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

namespace ClubDeportivo
{
    public partial class Socio : Form
    {
        private FormPrincipal principal;
        public Socio(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.Load += Socio_Load;
            this.principal = formPrincipal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Close();
             principal.AbrirEnPanel(new Home());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Socio_Load(object sender, EventArgs e)
        {
            CargarSociosDesdeBD();
        }

        private void CargarSociosDesdeBD()
        {
            string query = "SELECT nombre AS NOMBRE, apellido AS APELLIDO, dni AS DNI, telefono AS TELEFONO, ficha_medica AS FICHA_MEDICA, activo AS ACTIVO, fecha_inscripcion AS FECHA_INSCRIPCION FROM socios";

            try
            {
                using (var con = ConexionMySQL.ObtenerConexion())
                {
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, con);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvSocios.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los socios: " + ex.Message);
            }
        }

    }
}
