using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Sistema_de_Incendios
{
    public partial class FormThingSpeak : Form
    {
        public FormThingSpeak()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FormThingSpeak_Load);
        }

        private void FormThingSpeak_Load(object sender, EventArgs e)
        {
            string url = "https://thingspeak.com/channels/2959270/charts/1?api_key=MNH1MTGB6RS3YLS2"; 
            webBrowserThingSpeak.Navigate(url);
        }

    }
}
