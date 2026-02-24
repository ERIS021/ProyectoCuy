using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SanidadPrincipal : Form
    {
        public SanidadPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Sandad0 a = new Sandad0();
            a.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            InteSanidad a = new InteSanidad();
            a.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Sanidad a = new Sanidad();
            a.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void SanidadPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string enfermedad = comboBox1.SelectedItem.ToString();
            richTextBox1.Clear();

            switch (enfermedad)
            {
                case "Salmonelosis":
                    richTextBox1.Text =
                    "Síntomas:\n" +
                    "• Diarrea\n• Decaimiento\n• Falta de apetito\n• Muerte súbita\n\n" +
                    "Causas:\n" +
                    "• Alimento o agua contaminados\n• Estrés\n• Mala higiene\n\n" +
                    "Prevención:\n" +
                    "• Desinfección\n• Cuarentena\n• Control sanitario";
                    break;

                case "Neumonía":
                    richTextBox1.Text =
                    "Síntomas:\n" +
                    "• Dificultad respiratoria\n• Secreción nasal\n• Falta de apetito\n\n" +
                    "Causas:\n" +
                    "• Corrientes de aire\n• Humedad\n• Frío\n\n" +
                    "Prevención:\n" +
                    "• Buena ventilación\n• Ambiente seco";
                    break;

                case "Bronconeumonía":
                    richTextBox1.Text =
                    "Síntomas:\n" +
                    "• Respiración ruidosa\n• Secreción nasal\n• Postración\n\n" +
                    "Causas:\n" +
                    "• Polvo\n• Gases\n• Ambientes cerrados\n\n" +
                    "Prevención:\n" +
                    "• Limpieza\n• Ventilación adecuada";
                    break;

                case "Pseudotuberculosis":
                    richTextBox1.Text =
                    "Síntomas:\n" +
                    "• Adelgazamiento\n• Decaimiento\n• Muerte repentina\n\n" +
                    "Causas:\n" +
                    "• Alimento contaminado\n• Falta de higiene\n\n" +
                    "Prevención:\n" +
                    "• Desinfección rigurosa\n• Control sanitario";
                    break;

                case "Linfadenitis":
                    richTextBox1.Text =
                    "Síntomas:\n" +
                    "• Inflamación de ganglios\n• Bultos en el cuello\n\n" +
                    "Causas:\n" +
                    "• Heridas infectadas\n• Golpes\n\n" +
                    "Prevención:\n" +
                    "• Desinfección de heridas\n• Limpieza del corral";
                    break;

                case "Micosis":
                    richTextBox1.Text =
                    "Síntomas:\n" +
                    "• Caída de pelo\n• Picazón\n• Lesiones en la piel\n\n" +
                    "Causas:\n" +
                    "• Ambientes húmedos\n• Contacto con animales infectados\n\n" +
                    "Prevención:\n" +
                    "• Ambientes secos\n• Desinfección de jaulas";
                    break;

                case "Coccidiosis":
                    richTextBox1.Text =
                    "Síntomas:\n" +
                    "• Diarrea con moco o sangre\n• Pérdida de peso\n• Decaimiento\n\n" +
                    "Causas:\n" +
                    "• Agua o alimento contaminados\n• Falta de limpieza\n\n" +
                    "Prevención:\n" +
                    "• Limpieza diaria\n• Cambio de cama";
                    break;

                case "Fasciolosis":
                    richTextBox1.Text =
                    "Síntomas:\n" +
                    "• Debilidad\n• Falta de apetito\n• Adelgazamiento\n\n" +
                    "Causas:\n" +
                    "• Pastos contaminados\n• Zonas húmedas\n\n" +
                    "Prevención:\n" +
                    "• Evitar pastos inundados\n• Desparasitación";
                    break;

                case "Nematodos intestinales":
                    richTextBox1.Text =
                    "Síntomas:\n" +
                    "• Adelgazamiento\n• Diarrea\n• Pelaje erizado\n\n" +
                    "Causas:\n" +
                    "• Suelos contaminados\n• Falta de desparasitación\n\n" +
                    "Prevención:\n" +
                    "• Programas de desparasitación\n• Higiene";
                    break;

                case "Ectoparásitos":
                    richTextBox1.Text =
                    "Síntomas:\n" +
                    "• Picazón intensa\n• Heridas\n• Caída de pelo\n• Anemia\n\n" +
                    "Causas:\n" +
                    "• Cama sucia\n• Ambientes húmedos\n\n" +
                    "Prevención:\n" +
                    "• Limpieza profunda\n• Desinfección periódica";
                    break;
            }

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

        private void SanidadPrincipal_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Salmonelosis");
            comboBox1.Items.Add("Neumonía");
            comboBox1.Items.Add("Bronconeumonía");
            comboBox1.Items.Add("Pseudotuberculosis");
            comboBox1.Items.Add("Linfadenitis");
            comboBox1.Items.Add("Micosis");
            comboBox1.Items.Add("Coccidiosis");
            comboBox1.Items.Add("Fasciolosis");
            comboBox1.Items.Add("Nematodos intestinales");
            comboBox1.Items.Add("Ectoparásitos");

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            richTextBox1.ReadOnly = true;
        }
    }
    }
