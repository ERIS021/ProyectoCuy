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
    public partial class GestionClientesProduccion : Form
    {
        string carpetaClientes;
        string rutaClientes;
        int indiceSeleccionado = -1;

        private bool CamposObligatoriosLlenos()
        {
            return
                !string.IsNullOrWhiteSpace(textNombres.Text) &&
                !string.IsNullOrWhiteSpace(textCedula.Text) &&
                !string.IsNullOrWhiteSpace(textTelefono.Text) &&

                textNombres.ForeColor == Color.Black &&
                textCedula.ForeColor == Color.Black &&
                textTelefono.ForeColor == Color.Black;
        }
        public GestionClientesProduccion()
        {
            InitializeComponent();
            this.Load += GestionClientesProduccion_Load;
            this.ActiveControl = null;
        }

        private void GestionClientesProduccion_Load(object sender, EventArgs e)
        {
            PrepararArchivo();

            textNombres.Text = "Nombres y Apellidos:";
            textNombres.ForeColor = Color.Gray;

            textCedula.Text = "Cedula";
            textCedula.ForeColor = Color.Gray;

            textTelefono.Text = "Telefono";
            textTelefono.ForeColor = Color.Gray;

            textCorreo.Text = "Correo (Opcional)";
            textCorreo.ForeColor = Color.Gray;

            textDireccion.Text = "Dirección (Opcional)";
            textDireccion.ForeColor = Color.Gray;

            CargarClientesEnlistClientes();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu a= new Menu();
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
        private void PrepararArchivo()
        {
            carpetaClientes = Path.Combine
            (

              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
              "Clientes"
            );

            if (!Directory.Exists(carpetaClientes))
                Directory.CreateDirectory(carpetaClientes);

            rutaClientes = Path.Combine(carpetaClientes, "Clientes.txt");

            if (!File.Exists(rutaClientes))
                File.Create(rutaClientes).Close();
        }

       
      
        private void btt_Regis_Click(object sender, EventArgs e)
        {
            if (!CamposObligatoriosLlenos())
            {
                MessageBox.Show(
                    "⚠️ Debe llenar todos los campos obligatorios",
                    "Campos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult r = MessageBox.Show(
                "¿Está seguro que desea registrar este cliente?",
                "Confirmar registro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

               if (r != DialogResult.Yes) return;

               // 📌 Obtener número correcto automáticamente
               string[] lineas = File.ReadAllLines(rutaClientes);
               int nuevoNumero = lineas.Length + 1;

              string nuevaLinea =
                nuevoNumero + "," +
                textNombres.Text + "," +
                textCedula.Text + "," +
                textTelefono.Text + "," +
                textCorreo.Text + "," +
                textDireccion.Text;

               File.AppendAllText(rutaClientes, nuevaLinea + Environment.NewLine);

               MessageBox.Show("✅ Cliente registrado correctamente");

               LimpiarCampos();
               CargarClientesEnlistClientes();
        }
        


        private void LimpiarCampos()
        {
            textNombres.Text = "Nombres y Apellidos:";
            textNombres.ForeColor = Color.Gray;

            textCedula.Text = "Cedula";
            textCedula.ForeColor = Color.Gray;

            textTelefono.Text = "Telefono";
            textTelefono.ForeColor = Color.Gray;

            textCorreo.Text = "Correo (Opcional)";
            textCorreo.ForeColor = Color.Gray;

            textDireccion.Text = "Dirección (Opcional)";
            textDireccion.ForeColor = Color.Gray;
        }

        private void textCorreo_Enter(object sender, EventArgs e)
        {
            if (textCorreo.Text == "Correo (Opcional)")
            {
                textCorreo.Text = "";
                textCorreo.ForeColor = Color.Black;
            }
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            if (textCorreo.Text == "")
            {
                textCorreo.Text = "Correo (Opcional)";
                textCorreo.ForeColor = Color.Gray;
            }
        }

        private void textDireccion_Enter(object sender, EventArgs e)
        {
            if (textDireccion.Text == "Dirección (Opcional)")
            {
                textDireccion.Text = "";
                textDireccion.ForeColor = Color.Black;
            }
        }

        private void textDireccion_Leave(object sender, EventArgs e)
        {
            if (textDireccion.Text == "")
            {
                textDireccion.Text = "Dirección (Opcional)";
                textDireccion.ForeColor = Color.Gray;
            }
        }

        private void textNombres_Enter(object sender, EventArgs e)
        {
            if (textNombres.Text == "Nombres y Apellidos:")
            {
                textNombres.Text = "";
                textNombres.ForeColor = Color.Black;
            }
        }

        private void textNombres_Leave(object sender, EventArgs e)
        {
            if (textNombres.Text == "")
            {
                textNombres.Text = "Nombres y Apellidos:";
                textNombres.ForeColor = Color.Gray;
            }
        }

        private void textCedula_Enter(object sender, EventArgs e)
        {
            if (textCedula.Text == "Cedula")
            {
                textCedula.Text = "";
                textCedula.ForeColor = Color.Black;
            }
        }

        private void textCedula_Leave(object sender, EventArgs e)
        {
            if (textCedula.Text == "")
            {
                textCedula.Text = "Cedula";
                textCedula.ForeColor = Color.Gray;
            }
        }

        private void textTelefono_Enter(object sender, EventArgs e)
        {
            if (textTelefono.Text == "Telefono")
            {
                textTelefono.Text = "";
                textTelefono.ForeColor = Color.Black;
            }
        }

        private void textTelefono_Leave(object sender, EventArgs e)
        {
            if (textTelefono.Text == "")
            {
                textTelefono.Text = "Telefono";
                textTelefono.ForeColor = Color.Gray;
            }
        }
        private void CargarClientesEnlistClientes()
        {
            listClientes.Items.Clear();

            if (!File.Exists(rutaClientes)) return;

            string[] lineas = File.ReadAllLines(rutaClientes);

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] datos = linea.Split(',');

                // datos[1] = Nombre
                // datos[2] = Cédula
                string mostrar = datos[1] + " - " + datos[2];

                listClientes.Items.Add(mostrar);
            }
        }

        private void btt_editCliente_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un cliente de la lista");
                return;
            }


            DialogResult r = MessageBox.Show(
                "¿Está seguro que desea editar este cliente?",
                "Confirmar edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r != DialogResult.Yes) return;

            string[] lineas = File.ReadAllLines(rutaClientes);

            lineas[indiceSeleccionado] =
                (indiceSeleccionado + 1) + "," +
                textNombres.Text + "," +
                textCedula.Text + "," +
                textTelefono.Text + "," +
                textCorreo.Text + "," +
                textDireccion.Text;

            File.WriteAllLines(rutaClientes, lineas);

            MessageBox.Show("✏️ Cliente editado correctamente");

            indiceSeleccionado = -1;
            LimpiarCampos();
            CargarClientesEnlistClientes();


        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listClientes.SelectedIndex == -1) return;

            indiceSeleccionado = listClientes.SelectedIndex;

            string linea = File.ReadAllLines(rutaClientes)[indiceSeleccionado];
            string[] datos = linea.Split(',');

            textNombres.Text = datos[1];
            textNombres.ForeColor = Color.Black;

            textCedula.Text = datos[2];
            textCedula.ForeColor = Color.Black;

            textTelefono.Text = datos[3];
            textTelefono.ForeColor = Color.Black;

            textCorreo.Text = datos[4];
            textCorreo.ForeColor = Color.Black;

            textDireccion.Text = datos[5];
            textDireccion.ForeColor = Color.Black;
        }

        private void btt_elimCliente_Click(object sender, EventArgs e)
        {
            if (indiceSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un cliente de la lista");
                return;
            }

            DialogResult r = MessageBox.Show(
                "¿Está seguro de eliminar este cliente?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (r != DialogResult.Yes) return;

            var lineas = File.ReadAllLines(rutaClientes).ToList();
            lineas.RemoveAt(indiceSeleccionado);

            File.WriteAllLines(rutaClientes, lineas);

            MessageBox.Show("🗑️ Cliente eliminado");

            indiceSeleccionado = -1;
            LimpiarCampos();
            CargarClientesEnlistClientes();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Produccion a = new Produccion();
            a.Show();
            this.Hide();
        }
    }
}
