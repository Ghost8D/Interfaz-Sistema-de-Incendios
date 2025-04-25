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
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblGas = new System.Windows.Forms.Label();
            this.lblAlarma = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.Estado = new System.Windows.Forms.Label();
            this.Gas = new System.Windows.Forms.Label();
            this.Temperatura = new System.Windows.Forms.Label();
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
            this.lblTemperatura.Size = new System.Drawing.Size(121, 21);
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
            this.lblGas.Size = new System.Drawing.Size(51, 21);
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
            this.lblAlarma.Size = new System.Drawing.Size(79, 21);
            this.lblAlarma.TabIndex = 2;
            this.lblAlarma.Text = "Alarma: -";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(335, 280);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 35);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
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
            this.panelInfo.Location = new System.Drawing.Point(250, 100);
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
            this.Estado.Size = new System.Drawing.Size(147, 21);
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
            this.Gas.Size = new System.Drawing.Size(95, 21);
            this.Gas.TabIndex = 4;
            this.Gas.Text = "Gas/Humo:";
            this.Gas.Click += new System.EventHandler(this.Gas_Click);
            // 
            // Temperatura
            // 
            this.Temperatura.AutoSize = true;
            this.Temperatura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Temperatura.ForeColor = System.Drawing.Color.White;
            this.Temperatura.Location = new System.Drawing.Point(57, 22);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(111, 21);
            this.Temperatura.TabIndex = 3;
            this.Temperatura.Text = "Temperatura:";
            this.Temperatura.Click += new System.EventHandler(this.Temperatura_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.btnActualizar);
            this.Name = "Form1";
            this.Text = "Sistema de Monitoreo de Incendios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Label lblAlarma;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label Temperatura;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Label Gas;
    }
}
