using System.Windows.Forms;
using System.Drawing;

namespace Interfaz_Sistema_de_Incendios
{
    partial class FormThingSpeak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelScroll = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();

            this.panelGrafica1 = new System.Windows.Forms.Panel();
            this.panelGrafica2 = new System.Windows.Forms.Panel();
            this.panelGrafica3 = new System.Windows.Forms.Panel();

            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.webView23 = new Microsoft.Web.WebView2.WinForms.WebView2();

            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView23)).BeginInit();
            this.panelScroll.SuspendLayout();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Text = "Gráficas de Sensor - Sistema de Alarma";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(178, 34, 34);
            this.lblTitulo.Dock = DockStyle.Top;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Height = 60;
            this.lblTitulo.BackColor = System.Drawing.Color.WhiteSmoke;

            // panelScroll
            this.panelScroll.Dock = DockStyle.Fill;
            this.panelScroll.AutoScroll = true;
            this.panelScroll.BackColor = System.Drawing.Color.Gray;

            // tableLayoutPanel1
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.Dock = DockStyle.Top;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.Padding = new Padding(20);
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Paneles de gráficas
            Panel[] panels = { panelGrafica1, panelGrafica2, panelGrafica3 };
            Microsoft.Web.WebView2.WinForms.WebView2[] webs = { webView21, webView22, webView23 };

            for (int i = 0; i < panels.Length; i++)
            {
                panels[i].BackColor = Color.Gray;
                panels[i].BorderStyle = BorderStyle.FixedSingle;
                panels[i].Margin = new Padding(20);
                panels[i].Padding = new Padding(10);
                panels[i].Size = new Size(860, 320);
                panels[i].Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                webs[i].Dock = DockStyle.Fill;
                webs[i].DefaultBackgroundColor = Color.Black;
                webs[i].ZoomFactor = 1D;

                panels[i].Controls.Add(webs[i]);
                this.tableLayoutPanel1.Controls.Add(panels[i], 0, i);
            }

            // Nesting
            this.panelScroll.Controls.Add(this.tableLayoutPanel1);

            // Form settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.panelScroll);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Name = "FormThingSpeak";
            this.Text = "Visualización en Tiempo Real - ThingSpeak";
            this.StartPosition = FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView23)).EndInit();
            this.panelScroll.ResumeLayout(false);
            this.panelScroll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelScroll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.Panel panelGrafica1;
        private System.Windows.Forms.Panel panelGrafica2;
        private System.Windows.Forms.Panel panelGrafica3;

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView23;

    }
}