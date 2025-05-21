using System;
using System.Windows.Forms;

namespace Interfaz_Sistema_de_Incendios
{
    public partial class FormThingSpeak : Form
    {
        public FormThingSpeak()
        {
            InitializeComponent();
            this.Load += FormThingSpeak_Load;
        }

        private async void FormThingSpeak_Load(object sender, EventArgs e)
        {
            string grafica1 = "https://thingspeak.com/channels/2959270/charts/1?bgcolor=%23ffffff&dynamic=true&type=line&results=60";
            string grafica2 = "https://thingspeak.mathworks.com/channels/2959270/charts/2?bgcolor=%23ffffff&color=%23d62020&dynamic=true&results=60&type=line&update=15";
            string grafica3 = "https://thingspeak.mathworks.com/channels/2959270/charts/3?bgcolor=%23ffffff&color=%23d62020&dynamic=true&results=60&type=line&update=15";

            await webView21.EnsureCoreWebView2Async();
            await webView22.EnsureCoreWebView2Async();
            await webView23.EnsureCoreWebView2Async();

            webView21.Source = new Uri(grafica1);
            webView22.Source = new Uri(grafica2);
            webView23.Source = new Uri(grafica3);
        }

        private void webView22_Click(object sender, EventArgs e)
        {

        }
    }
}
