using System.Drawing;
using System.Windows.Forms;

namespace AlarmaGas
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblGas = new System.Windows.Forms.Label();
            this.lblAlarma = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.Estado = new System.Windows.Forms.Label();
            this.Gas = new System.Windows.Forms.Label();
            this.Temperatura = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.lblReloj = new System.Windows.Forms.Label();
            this.panelReloj = new System.Windows.Forms.Panel();
            this.btnVerGrafica = new System.Windows.Forms.Button();
            this.lblConexionESP = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTemperatura.ForeColor = System.Drawing.Color.White;
            this.lblTemperatura.Location = new System.Drawing.Point(174, 22);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(151, 28);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Temperatura: -";
            // 
            // lblGas
            // 
            this.lblGas.AutoSize = true;
            this.lblGas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGas.ForeColor = System.Drawing.Color.White;
            this.lblGas.Location = new System.Drawing.Point(174, 62);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(65, 28);
            this.lblGas.TabIndex = 1;
            this.lblGas.Text = "Gas: -";
            // 
            // lblAlarma
            // 
            this.lblAlarma.AutoSize = true;
            this.lblAlarma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAlarma.ForeColor = System.Drawing.Color.Red;
            this.lblAlarma.Location = new System.Drawing.Point(174, 102);
            this.lblAlarma.Name = "lblAlarma";
            this.lblAlarma.Size = new System.Drawing.Size(99, 28);
            this.lblAlarma.TabIndex = 2;
            this.lblAlarma.Text = "Alarma: -";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(283, 296);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(241, 35);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Registrar Datos en BD";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.Estado);
            this.panelInfo.Controls.Add(this.Gas);
            this.panelInfo.Controls.Add(this.Temperatura);
            this.panelInfo.Controls.Add(this.lblTemperatura);
            this.panelInfo.Controls.Add(this.lblGas);
            this.panelInfo.Controls.Add(this.lblAlarma);
            this.panelInfo.Location = new System.Drawing.Point(251, 115);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(300, 150);
            this.panelInfo.TabIndex = 0;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Estado.ForeColor = System.Drawing.Color.White;
            this.Estado.Location = new System.Drawing.Point(21, 102);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(183, 28);
            this.Estado.TabIndex = 5;
            this.Estado.Text = "Estado de Alarma:";
            // 
            // Gas
            // 
            this.Gas.AutoSize = true;
            this.Gas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Gas.ForeColor = System.Drawing.Color.White;
            this.Gas.Location = new System.Drawing.Point(73, 62);
            this.Gas.Name = "Gas";
            this.Gas.Size = new System.Drawing.Size(117, 28);
            this.Gas.TabIndex = 4;
            this.Gas.Text = "Gas/Humo:";
            // 
            // Temperatura
            // 
            this.Temperatura.AutoSize = true;
            this.Temperatura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Temperatura.ForeColor = System.Drawing.Color.White;
            this.Temperatura.Location = new System.Drawing.Point(57, 22);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(137, 28);
            this.Temperatura.TabIndex = 3;
            this.Temperatura.Text = "Temperatura:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(330, 337);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(150, 30);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar registros";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.buttonborrar_Click);
            // btnThingSpeak
            this.btnThingSpeak = new System.Windows.Forms.Button();
            this.btnThingSpeak.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThingSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThingSpeak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThingSpeak.ForeColor = System.Drawing.Color.White;
            this.btnThingSpeak.Location = new System.Drawing.Point(346, 415);
            this.btnThingSpeak.Name = "btnThingSpeak";
            this.btnThingSpeak.Size = new System.Drawing.Size(120, 35);
            this.btnThingSpeak.TabIndex = 6;
            this.btnThingSpeak.Text = "Ver Online";
            this.btnThingSpeak.UseVisualStyleBackColor = false;
            this.btnThingSpeak.Click += new System.EventHandler(this.btnThingSpeak_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTitulo.Location = new System.Drawing.Point(188, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(466, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Alarma de Incendios";
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblReloj.ForeColor = System.Drawing.Color.White;
            this.lblReloj.Location = new System.Drawing.Point(361, 70);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(81, 20);
            this.lblReloj.TabIndex = 8;
            this.lblReloj.Text = "00:00:00";
            // 
            // panelReloj
            // 
            this.panelReloj.Location = new System.Drawing.Point(0, 0);
            this.panelReloj.Name = "panelReloj";
            this.panelReloj.Size = new System.Drawing.Size(200, 100);
            this.panelReloj.TabIndex = 0;
            // 
            // btnVerGrafica
            // 
            this.btnVerGrafica.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnVerGrafica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerGrafica.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerGrafica.ForeColor = System.Drawing.Color.White;
            this.btnVerGrafica.Location = new System.Drawing.Point(346, 373);
            this.btnVerGrafica.Name = "btnVerGrafica";
            this.btnVerGrafica.Size = new System.Drawing.Size(120, 35);
            this.btnVerGrafica.TabIndex = 4;
            this.btnVerGrafica.Text = "Ver Gráficas";
            this.btnVerGrafica.UseVisualStyleBackColor = false;
            this.btnVerGrafica.Click += new System.EventHandler(this.btnVerGrafica_Click);
            // 
            // lblConexionESP
            // 
            this.lblConexionESP.AutoSize = true;
            this.lblConexionESP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConexionESP.ForeColor = System.Drawing.Color.Red;
            this.lblConexionESP.Location = new System.Drawing.Point(326, 270);
            this.lblConexionESP.Name = "lblConexionESP";
            this.lblConexionESP.Size = new System.Drawing.Size(175, 23);
            this.lblConexionESP.TabIndex = 0;
            this.lblConexionESP.Text = "ESP32 Desconectado";
            this.lblConexionESP.Visible = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConexionESP);
            this.Controls.Add(this.btnVerGrafica);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.btnThingSpeak);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Form1";
            this.Text = "Sistema de Alarma de Incendios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblConexionESP;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Label lblAlarma;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label Temperatura;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Label Gas;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnVerGrafica;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelReloj;
        private Timer timerReloj;
        private Label lblReloj;
        private System.Windows.Forms.Button btnThingSpeak;
    }
}
