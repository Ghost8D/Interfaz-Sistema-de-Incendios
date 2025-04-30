using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Interfaz_Sistema_de_Incendios
{
    public partial class FormGrafica : Form
    {
        public FormGrafica()
        {
            InitializeComponent();
            this.Load += FormGrafica_Load;
        }

        private void FormGrafica_Load(object sender, EventArgs e)
        {
            try
            {
                // Crear contenedor de tablas con 2 filas 
                TableLayoutPanel layout = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    RowCount = 2,
                    ColumnCount = 1,
                    AutoSize = true
                };
                layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                this.Controls.Add(layout);

                // Crear gráficas 
                Chart chartTemp = CrearGrafica("Historial de Temperatura", "Temperatura", 45, Color.OrangeRed, out Series serieTemp, out Series umbralTemp);
                Chart chartGas = CrearGrafica("Historial de Gas", "Gas", 1800, Color.MediumBlue, out Series serieGas, out Series umbralGas);

                // Consultar datos
                string connectionString = "Server=VICTORGHOST8D;Database=SistemaIncendiosDB;Trusted_Connection=True;";
                string query = "SELECT TOP 20 FechaRegistro, Temperatura, Gas FROM RegistroDatos ORDER BY FechaRegistro ASC";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime fecha = reader.GetDateTime(0);
                            double temp = reader.GetDouble(1);
                            int gas = reader.GetInt32(2);

                            serieTemp.Points.AddXY(fecha, temp);
                            umbralTemp.Points.AddXY(fecha, 45);

                            serieGas.Points.AddXY(fecha, gas);
                            umbralGas.Points.AddXY(fecha, 1800);
                        }
                    }
                }

                // Agregar gráficas al layout 
                layout.Controls.Add(chartTemp, 0, 0);
                layout.Controls.Add(chartGas, 0, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar las gráficas:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private Chart CrearGrafica(string titulo, string nombreSerie, double umbral, Color colorSerie, out Series datos, out Series lineaUmbral)
        {
            Chart chart = new Chart { Dock = DockStyle.Fill, BackColor = Color.FromArgb(45, 45, 48) };

            ChartArea area = new ChartArea
            {
                BackColor = Color.FromArgb(60, 60, 65),
                BorderColor = Color.Gray,
                BorderWidth = 1,
                AxisX = {
            LabelStyle = { ForeColor = Color.White },
            LineColor = Color.White,
            MajorGrid = { LineColor = Color.DarkGray },
            Title = "Fecha",
            TitleForeColor = Color.White
        },
                AxisY = {
            LabelStyle = { ForeColor = Color.White },
            LineColor = Color.White,
            MajorGrid = { LineColor = Color.DarkGray },
            TitleForeColor = Color.White
        }
            };

            chart.ChartAreas.Add(area);

            chart.Titles.Add(new Title(titulo, Docking.Top, new Font("Segoe UI", 14, FontStyle.Bold), Color.White));

            datos = new Series(nombreSerie)
            {
                ChartType = SeriesChartType.Line,
                Color = colorSerie,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 7,
                BorderWidth = 2
            };

            lineaUmbral = new Series("Umbral " + umbral)
            {
                ChartType = SeriesChartType.Line,
                Color = Color.IndianRed,
                BorderDashStyle = ChartDashStyle.Dash,
                BorderWidth = 2,
                IsVisibleInLegend = true
            };

            chart.Series.Add(datos);
            chart.Series.Add(lineaUmbral);

            Legend legend = new Legend
            {
                BackColor = Color.FromArgb(60, 60, 65),
                ForeColor = Color.White,
                Docking = Docking.Right,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            chart.Legends.Add(legend);

            return chart;
        }

    }
}
