using ClubDeportivo.BBDD;
using ClubDeportivo.Clases;
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
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();
            cmbFormaPago.SelectedIndex = 0;
            nudMonto.Minimum = 1000;
            nudMonto.Maximum = 100000;
            nudMonto.Value = 30000; // Valor sugerido
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
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

        private void Pago_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarFormulario()
        {
            txtDNI.Clear();
            cmbFormaPago.SelectedIndex = 0;
            nudMonto.Value = 5000;
            txtDatos.Text = string.Empty;
        }

        private void nudMonto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            if (dni.Length < 7) return;

            StringBuilder info = new StringBuilder();
            var sistema = new Sistema();

            using (var con = ConexionMySQL.ObtenerConexion())
            {
                // Buscar NO SOCIO
                var cmdNoSocio = new MySqlCommand("SELECT * FROM no_socios WHERE dni = @dni", con);
                cmdNoSocio.Parameters.AddWithValue("@dni", dni);
                using (var reader = cmdNoSocio.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        info.AppendLine("🟡 NO SOCIO (pendiente de alta)");
                        info.AppendLine($"👤 {reader["nombre"]} {reader["apellido"]}");
                        info.AppendLine($"📅 Inscripto: {Convert.ToDateTime(reader["fecha_inscripcion"]).ToShortDateString()}");
                        info.AppendLine($"📋 Ficha médica: {(Convert.ToBoolean(reader["ficha_medica"]) ? "Sí" : "No")}");
                        txtDatos.Text = info.ToString();
                        return;
                    }
                }

                // Buscar SOCIO
                var cmdSocio = new MySqlCommand("SELECT * FROM socios WHERE dni = @dni", con);
                cmdSocio.Parameters.AddWithValue("@dni", dni);
                int idSocio = -1;
                using (var reader = cmdSocio.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idSocio = Convert.ToInt32(reader["idSocio"]);
                        info.AppendLine("🟢 SOCIO ACTIVO");
                        info.AppendLine($"👤 {reader["nombre"]} {reader["apellido"]}");
                        info.AppendLine($"📅 Alta: {Convert.ToDateTime(reader["fecha_inscripcion"]).ToShortDateString()}");
                        info.AppendLine($"📋 Ficha médica: {(Convert.ToBoolean(reader["ficha_medica"]) ? "Sí" : "No")}");
                    }
                }

                if (idSocio != -1)
                {
                    var cmdCuota = new MySqlCommand(@"SELECT fechaPago, fechaVencimiento 
                                               FROM cuotas WHERE idSocio = @id 
                                               ORDER BY fechaPago DESC LIMIT 1", con);
                    cmdCuota.Parameters.AddWithValue("@id", idSocio);
                    using (var reader = cmdCuota.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            info.AppendLine($"💰 Último pago: {Convert.ToDateTime(reader["fechaPago"]).ToShortDateString()}");
                            info.AppendLine($"⏳ Vencimiento: {Convert.ToDateTime(reader["fechaVencimiento"]).ToShortDateString()}");
                        }
                        else
                        {
                            info.AppendLine("⚠️ Sin pagos registrados.");
                        }
                    }
                }
                else
                {
                    info.AppendLine("🔴 DNI no registrado.");
                }

                txtDatos.Text = info.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
