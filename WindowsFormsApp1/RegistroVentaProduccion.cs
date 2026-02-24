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
    public partial class RegistroVentaProduccion : Form
    {
        string rutaCuy;
        string rutaClientes;
        string rutaVentas;
        public RegistroVentaProduccion()
        {
            InitializeComponent();
            this.Load += RegistroVentaProduccion_Load;
        }

        private void RegistroVentaProduccion_Load(object sender, EventArgs e)
        {
            PrepararArchivos();
            CargarClientes();
            CargarCuyes();

            cmbCliente.SelectedIndex = -1;
            cmbCuy.SelectedIndex = -1;
            cmbCuy.Text = "";

            numCantidad.Minimum = 0;
            numCantidad.Value = 0;
            lblTotal.Text = "$0.00";

            r_efectivo.Checked = false;
            r_transferencia.Checked = false;
            r_tarjeta.Checked = false;
        }
        private void PrepararArchivos()
        {
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // RUTAS
            rutaCuy = Path.Combine(docs, "Cuyes", "cuy.txt");
            rutaClientes = Path.Combine(docs, "Clientes", "Clientes.txt");
            rutaVentas = Path.Combine(docs, "Ventas", "Ventas.txt");

            // CREAR CARPETAS
            Directory.CreateDirectory(Path.Combine(docs, "Cuyes"));
            Directory.CreateDirectory(Path.Combine(docs, "Clientes"));
            Directory.CreateDirectory(Path.Combine(docs, "Ventas"));

            // CREAR ARCHIVOS SI NO EXISTEN
            if (!File.Exists(rutaCuy))
                File.Create(rutaCuy).Close();

            if (!File.Exists(rutaClientes))
                File.Create(rutaClientes).Close();

            if (!File.Exists(rutaVentas))
                File.Create(rutaVentas).Close();
        }

        private void CargarCuyes()
        {
            cmbCuy.Items.Clear();

            foreach (string linea in File.ReadAllLines(rutaCuy))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] d = linea.Split(',');
                int stock = int.Parse(d[4]);

                if (stock > 0)
                {
                    // SOLO texto bonito (sin |, sin ID visible)
                    cmbCuy.Items.Add(new CuyItem
                    {
                        Id = int.Parse(d[0]),
                        Texto = $"{d[1]} {d[2]} - ${d[3]}"
                    });
                }
            }

            cmbCuy.DisplayMember = "Texto";
        }
        private string ObtenerMetodoPago()
        {
            if (r_efectivo.Checked) return "Efectivo";
            if (r_transferencia.Checked) return "Transferencia";
            if (r_tarjeta.Checked) return "Tarjeta";
            return "";
        }


        public class CuyItem
        {
            public int Id { get; set; }
            public string Texto { get; set; }
            public override string ToString() => Texto;
        }



        private void CargarClientes()
        {
            cmbCliente.Items.Clear();

            foreach (string linea in File.ReadAllLines(rutaClientes))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                string[] d = linea.Split(',');
                cmbCliente.Items.Add(d[1]);
            }
        }

        private void btt_regisV_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1 || cmbCuy.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione cliente y cuy");
                return;
            }

            int cantidad = (int)numCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida");
                return;
            }
            string metodoPago = ObtenerMetodoPago();
            if (metodoPago == "")
            {
                MessageBox.Show("Seleccione un método de pago");
                return;
            }

            CuyItem cuySeleccionado = (CuyItem)cmbCuy.SelectedItem;
            int idCuy = cuySeleccionado.Id;

            string[] lineas = File.ReadAllLines(rutaCuy);
            string[] datosCuy = null;
            int index = -1;

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] temp = lineas[i].Split(',');
                if (int.Parse(temp[0]) == idCuy)
                {
                    datosCuy = temp;
                    index = i;
                    break;
                }
            }

            if (datosCuy == null)
            {
                MessageBox.Show("Error al encontrar el cuy seleccionado.");
                return;
            }

            int stock = int.Parse(datosCuy[4]);
            decimal precio = decimal.Parse(datosCuy[3], CultureInfo.InvariantCulture);

            if (cantidad > stock)
            {
                MessageBox.Show($"Stock insuficiente. Disponible: {stock}");
                return;
            }

            decimal total = precio * cantidad;
            lblTotal.Text = "$" + total.ToString("0.00");

           

            DialogResult r = MessageBox.Show(
              $"¿Confirmar venta?\n\nCliente: {cmbCliente.Text}\nCuy: {cuySeleccionado.Texto}\nCantidad: {cantidad}\nTotal: ${total:0.00}",
              "Confirmar venta",
              MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (r != DialogResult.Yes) return;

            string venta =
               cmbCliente.Text + "," +
               cuySeleccionado.Texto + "," +
               cantidad + "," +
               total;

            File.AppendAllText(rutaVentas, venta + Environment.NewLine);

            datosCuy[4] = (stock - cantidad).ToString();
            lineas[index] = string.Join(",", datosCuy);
            File.WriteAllLines(rutaCuy, lineas);

            MessageBox.Show("✅ Venta registrada");

            cmbCliente.SelectedIndex = -1;
            cmbCuy.SelectedIndex = -1;
            numCantidad.Value = 0;
            lblTotal.Text = "$0.00";

            CargarCuyes();
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Produccion a = new Produccion();
            a.Show();
            this.Hide();
        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (cmbCuy.SelectedIndex == -1) return;

            CuyItem cuy = (CuyItem)cmbCuy.SelectedItem;
            string[] lineas = File.ReadAllLines(rutaCuy);

            foreach (var linea in lineas)
            {
                string[] d = linea.Split(',');
                if (int.Parse(d[0]) == cuy.Id)
                {
                    decimal precio = decimal.Parse(d[3], CultureInfo.InvariantCulture);
                    decimal total = precio * numCantidad.Value;
                    lblTotal.Text = "$" + total.ToString("0.00");
                    break;
                }
            }
        }
    }
}
