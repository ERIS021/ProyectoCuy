using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReportesVentasProduccion : Form
    {
        string rutaVentas;
        string rutaCuy;
        public ReportesVentasProduccion()
        {
            InitializeComponent();
            this.Load += ReportesVentasProduccion_Load;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
      "¿Estás seguro de que deseas salir?",
      "Confirmar salida",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Question
     );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Hide();
        }

        private void ReportesVentasProduccion_Load(object sender, EventArgs e)
        {
            PrepararRutas();
            CargarVentas();
            CalcularStock();
            CalcularReporte();
        }
        private void PrepararRutas()
        {
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            rutaVentas = Path.Combine(docs, "Ventas", "Ventas.txt");
            rutaCuy = Path.Combine(docs, "Cuyes", "cuy.txt");

            Directory.CreateDirectory(Path.Combine(docs, "Ventas"));
            Directory.CreateDirectory(Path.Combine(docs, "Cuyes"));

            if (!File.Exists(rutaVentas))
                File.Create(rutaVentas).Close();

            if (!File.Exists(rutaCuy))
                File.Create(rutaCuy).Close();
        }
        private void CalcularReporte()
        {
            listVentas.Items.Clear();

            int totalVentas = 0;
            decimal totalIngresos = 0;

            foreach (string linea in File.ReadAllLines(rutaVentas))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] d = linea.Split(',');
                // formato: Cliente, Cuy, Cantidad, Total

                string mostrar =
                    "Cliente: " + d[0] +
                    " | Cuy: " + d[1] +
                    " | Cant: " + d[2] +
                    " | Total: $" + d[3];

                listVentas.Items.Add(mostrar);

                totalVentas++;
                totalIngresos += decimal.Parse(d[3], CultureInfo.InvariantCulture);
            }

            lbl_VentasT.Text = totalVentas.ToString();
            lbl_ingresosTotales.Text = "$" + totalIngresos.ToString("0.00");
        }

        private void CargarVentas()
        {
            listVentas.Items.Clear();

            int totalVentas = 0;
            decimal totalIngresos = 0;

            foreach (string linea in File.ReadAllLines(rutaVentas))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] d = linea.Split(',');
                // formato: Cliente, Cuy, Cantidad, Total

                string mostrar =
                    "Cliente: " + d[0] +
                    " | Cuy: " + d[1] +
                    " | Cant: " + d[2] +
                    " | Total: $" + d[3];

                listVentas.Items.Add(mostrar);

                totalVentas++;
                totalIngresos += decimal.Parse(d[3], CultureInfo.InvariantCulture);
            }
        }

        private void CalcularStock()
        {
            int stockDisponible = 0;

            foreach (string linea in File.ReadAllLines(rutaCuy))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] d = linea.Split(',');
                stockDisponible += int.Parse(d[4]);
            }

            lbl_stockDisponible.Text = stockDisponible.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Produccion a = new Produccion();
            a.Show();
            this.Hide();
        }

        private void btt_volver_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
