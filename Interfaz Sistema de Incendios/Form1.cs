using System;
using System.Data.SqlClient;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace AlarmaGas
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string urlESP = "http://192.168.1.79/datos"; 
        private string connectionString = "Server=TU_SERVIDOR;Database=TuDB;User Id=usuario;Password=clave;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private async Task ObtenerDatos()
        {
            try
            {
                string json = await client.GetStringAsync(urlESP);

                var datos = JsonSerializer.Deserialize<DatosSensor>(json);

                if (datos != null)
                {
                    lblTemperatura.Text = datos.temperatura + " °C";
                    lblGas.Text = datos.gas.ToString();
                    lblAlarma.Text = datos.alarma;

                    // Puedes descomentar esta línea si quieres guardar en SQL
                    // GuardarEnBaseDeDatos(datos.temperatura, datos.gas, datos.alarma.Contains("ACTIVA"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message);
            }
        }

        private void GuardarEnBaseDeDatos(float temperatura, int gas, bool alarma)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                var cmd = new SqlCommand("INSERT INTO RegistroAlarmas (Temperatura, Gas, AlarmaActiva) VALUES (@temp, @gas, @alarma)", con);
                cmd.Parameters.AddWithValue("@temp", temperatura);
                cmd.Parameters.AddWithValue("@gas", gas);
                cmd.Parameters.AddWithValue("@alarma", alarma);
                cmd.ExecuteNonQuery();
            }
        }

        public async void btnActualizar_Click(object sender, EventArgs e)
        {
            await ObtenerDatos();
        }


        public class DatosSensor
        {
            public float temperatura { get; set; }
            public int gas { get; set; }
            public string alarma { get; set; }
        }

        private void Temperatura_Click(object sender, EventArgs e)
        {

        }

        private void Gas_Click(object sender, EventArgs e)
        {

        }
    }
}
