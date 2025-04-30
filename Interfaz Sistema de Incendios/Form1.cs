using System;
using System.Data.SqlClient;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Interfaz_Sistema_de_Incendios;

namespace AlarmaGas
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly string urlESP = "http://192.168.1.78/datos";
        private readonly string connectionString = "Server=VICTORGHOST8D;Database=SistemaIncendiosDB;Integrated Security=True;";
        private Timer timerActualizacion;
        private bool errorMostrado = false;

        public Form1()
        {
            InitializeComponent();

            timerActualizacion = new Timer { Interval = 1000 };
            timerActualizacion.Tick += async (s, e) => await ObtenerYActualizar();
            timerActualizacion.Start();
            client.Timeout = TimeSpan.FromSeconds(1); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Resize += (s, ev) => CentrarControles();

            timerReloj = new Timer { Interval = 1000 };
            timerReloj.Tick += (s, ev) =>
            {
                DateTime ahora = DateTime.Now;
                string dia = char.ToUpper(ahora.ToString("dddd")[0]) + ahora.ToString("dddd").Substring(1);
                lblReloj.Text = $"{dia} {ahora:dd/MM/yyyy HH:mm:ss}";
                CentrarControles();
            };
            timerReloj.Start();

            CentrarControles();
        }

        private async Task ObtenerYActualizar()
        {
            try
            {
                string json = await client.GetStringAsync(urlESP);
                var datos = JsonSerializer.Deserialize<DatosSensor>(json);

                if (datos != null)
                {
                    ActualizarUI(datos);
                    GuardarEnBaseDeDatos(datos.temperatura, datos.gas, datos.alarma.Contains("ACTIVA"));

                    errorMostrado = false;
                    lblConexionESP.Visible = false;
                }
            }
            catch (Exception ex)
            {
                if (!errorMostrado)
                {
                    errorMostrado = true;
                    MessageBox.Show("Error al obtener datos del ESP32:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                lblConexionESP.Visible = true;
            }
        }

        private void ActualizarUI(DatosSensor datos)
        {
            lblTemperatura.Text = $"{datos.temperatura} °C";
            lblGas.Text = datos.gas.ToString();
            lblAlarma.Text = datos.alarma;
        }

        private void GuardarEnBaseDeDatos(float temperatura, int gas, bool alarma)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                var cmd = new SqlCommand("INSERT INTO RegistroDatos (Temperatura, Gas, AlarmaActiva) VALUES (@temp, @gas, @alarma)", con);
                cmd.Parameters.AddWithValue("@temp", temperatura);
                cmd.Parameters.AddWithValue("@gas", gas);
                cmd.Parameters.AddWithValue("@alarma", alarma);
                cmd.ExecuteNonQuery();
            }
        }

        private void CentrarControles()
        {
            lblTitulo.Left = (ClientSize.Width - lblTitulo.Width) / 2;
            lblReloj.Left = (ClientSize.Width - lblReloj.Width) / 2;
            lblReloj.Top = lblTitulo.Bottom + 10;
            panelInfo.Left = (ClientSize.Width - panelInfo.Width) / 2;
            panelInfo.Top = (ClientSize.Height - panelInfo.Height) / 2 - 60;
            btnActualizar.Left = (ClientSize.Width - btnActualizar.Width) / 2;
            btnActualizar.Top = panelInfo.Bottom + 20;
            btnBorrar.Left = (ClientSize.Width - btnBorrar.Width) / 2;
            btnBorrar.Top = btnActualizar.Bottom + 10;
            lblConexionESP.Left = (this.ClientSize.Width - lblConexionESP.Width) / 2;
            lblConexionESP.Top = btnBorrar.Bottom + 10;
            btnVerGrafica.Left = (this.ClientSize.Width - btnVerGrafica.Width) / 2;
            btnVerGrafica.Top = lblConexionESP.Bottom + 10;
        }

        private void buttonborrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas borrar todos los registros?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM RegistroDatos", con);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Todos los registros han sido eliminados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar registros: " + ex.Message);
                }
            }
        }

        private void btnVerGrafica_Click(object sender, EventArgs e)
        {
            using (var ventanaGrafica = new FormGrafica())
            {
                ventanaGrafica.ShowDialog();
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await ObtenerYActualizar();
        }

        public class DatosSensor
        {
            public float temperatura { get; set; }
            public int gas { get; set; }
            public string alarma { get; set; }
        }
    }
}
