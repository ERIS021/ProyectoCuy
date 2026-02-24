using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GestionCuyProduccion : Form
    {
        string carpeta;
        string ruta;
        public GestionCuyProduccion()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.GestionCuyProduccion_Load);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Produccion a = new Produccion();
            a.Show();
            this.Hide();
        }

        private void GestionCuyProduccion_Load(object sender, EventArgs e)
        {
            PrepararArchivo();
            CargarCombos();
            CargarCuyes();

            textPrecio.ForeColor = Color.Gray;
            textPrecio.Text = "Precio";

            textStock.ForeColor = Color.Gray;
            textStock.Text = "Stock";
        }
        private void PrepararArchivo()
        {
            carpeta = Path.Combine(
           Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
           "Cuyes"
            );

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            ruta = Path.Combine(carpeta, "cuy.txt");

            if (!File.Exists(ruta))
                File.Create(ruta).Close();
        }
        private void CargarCombos()
        {
            cmbRaza.Items.Clear();
            cmbColor.Items.Clear();

           
            cmbRaza.Items.AddRange(new string[]
            {
                "Peruano",
                "Crestado",
                "Abisinio",
                "Teddy",
                "Texel",
                "Rex",
            });

     
            cmbColor.Items.AddRange(new string[]
            {
                 "Blanco",
                 "Negro",
                 "Marron",
                 "Manchado",
                 "Crema",
                 "Saffron",
                 "Rojo",
                 "Tricolor",
                 "Beige",
                "Azulado",
            });

          
            cmbRaza.SelectedIndex = -1;
            cmbColor.SelectedIndex = -1;

        }

        private void CargarCuyes()
        {
            listCuy.Items.Clear();
            string[] lineas = File.ReadAllLines(ruta);
            foreach (string linea in lineas)
            {
                if (linea.Trim() == "") continue;
                string[] datos = linea.Split(',');

                string texto =
                    $"Id: {datos[0]} - Raza: {datos[1]} - Color: {datos[2]} - Precio: {datos[3]} - Stock: {datos[4]}";
                listCuy.Items.Add(texto);
            }
        }

        private void btt_aggCuy_Click(object sender, EventArgs e)
        {
            if (cmbRaza.SelectedIndex == -1 ||
               cmbColor.SelectedIndex == -1 ||
               textPrecio.Text == "" ||
               textPrecio.Text == "Precio" ||
               textStock.Text == "" ||
               textStock.Text == "Stock")
            {
                MessageBox.Show(
                    "⚠️ Debe completar todos los campos obligatorios",
                    "Campos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int id = File.ReadAllLines(ruta).Length + 1;

            string cuy =
                id + "," +
                cmbRaza.SelectedItem.ToString() + "," +
                cmbColor.SelectedItem.ToString() + "," +
                textPrecio.Text + "," +
                textStock.Text;

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea agregar este cuy?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                File.AppendAllText(ruta, cuy + Environment.NewLine);

                MessageBox.Show(
                    "Cuy agregado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarCuyes();
                LimpiarCampos();
            }
        }

        private void listCuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCuy.SelectedIndex == -1)
            {
                return;
            }

            string linea = File.ReadAllLines(ruta)[listCuy.SelectedIndex];
            string[] datos = linea.Split(',');

            cmbRaza.SelectedItem = datos[1];
            cmbColor.SelectedItem = datos[2];
            textPrecio.Text = datos[3];
            textStock.Text = datos[4];
        }

        private void btt_editCuy_Click(object sender, EventArgs e)
        {
            int index = listCuy.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Por favor seleccione un cuy para editar.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea editar este cuy?",
                "Confirmar edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                string[] lineas = File.ReadAllLines(ruta);
                string[] Datos = lineas[index].Split(',');

                Datos[1] = cmbRaza.SelectedItem.ToString();
                Datos[2] = cmbColor.SelectedItem.ToString();
                Datos[3] = textPrecio.Text;
                Datos[4] = textStock.Text;

                lineas[index] = string.Join(",", Datos);
                File.WriteAllLines(ruta, lineas);

                MessageBox.Show(
                    "Cuy editado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarCuyes();
                LimpiarCampos();
            }
        }

        private void btt_elimCuy_Click(object sender, EventArgs e)
        {
            int index = listCuy.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Por favor seleccione un cuy para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea eliminar este cuy?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                List<string> lineas = File.ReadAllLines(ruta).ToList();
                lineas.RemoveAt(index);
                File.WriteAllLines(ruta, lineas);

                MessageBox.Show(
                    "Cuy eliminado correctamente.",
                    "Eliminado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarCuyes();
                LimpiarCampos();
            }
        }
        private void LimpiarCampos()
        {
            cmbRaza.SelectedIndex = -1;
            cmbColor.SelectedIndex = -1;

            textPrecio.Text = "Precio";
            textPrecio.ForeColor = Color.Gray;

            textStock.Text = "Stock";
            textStock.ForeColor = Color.Gray;

        }

        private void cmbRaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRaza.SelectedIndex != -1)
                cmbRaza.ForeColor = Color.Black;
        }

        private void cmbRaza_Enter(object sender, EventArgs e)
        {

        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColor.SelectedIndex != -1)
                cmbColor.ForeColor = Color.Black;
        }

        private void textPrecio_Enter(object sender, EventArgs e)
        {
            if (textPrecio.Text == "Precio")
            {
                textPrecio.Text = "";
                textPrecio.ForeColor = Color.Black;
            }
        }

        private void textPrecio_Leave(object sender, EventArgs e)
        {
            if (textPrecio.Text == "")
            {
                textPrecio.Text = "Precio";
                textPrecio.ForeColor = Color.Gray;
            }
        }

        private void textStock_Enter(object sender, EventArgs e)
        {
            if (textStock.Text == "Stock")
            {
                textStock.Text = "";
                textStock.ForeColor = Color.Black;
            }
        }

        private void textStock_Leave(object sender, EventArgs e)
        {
            if (textStock.Text == "")
            {
                textStock.Text = "Stock";
                textStock.ForeColor = Color.Gray;
            }
        }

        private void textStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
