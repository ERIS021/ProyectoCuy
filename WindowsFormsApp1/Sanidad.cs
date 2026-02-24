using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Sanidad : Form
    {
        public Sanidad()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            bool enfermedadDetectada = false;

            // COCCIDIOSIS
            if (checkBox2.Checked && (checkBox6.Checked || checkBox8.Checked))
            {
                richTextBox1.Text =
                "Posible enfermedad: Coccidiosis\n\n" +
                "Síntomas detectados:\n- Diarrea\n- Pérdida de peso / Decaimiento\n\n" +
                "Causas:\n- Agua o alimento contaminado\n- Alta humedad\n\n" +
                "Prevención:\n- Limpieza diaria\n- Cambio de cama\n\n" +
                "Control:\n- Sulfaquinoxalina en el agua\n";
                enfermedadDetectada = true;
            }

            // MICOSIS
            else if (checkBox3.Checked && checkBox5.Checked)
            {
                richTextBox1.Text =
                "Posible enfermedad: Micosis\n\n" +
                "Síntomas detectados:\n- Caída de pelo\n- Picazón\n\n" +
                "Causas:\n- Ambientes húmedos\n- Falta de higiene\n\n" +
                "Prevención:\n- Desinfección\n- Ambientes secos\n\n" +
                "Control:\n- Antifúngicos tópicos\n";
                enfermedadDetectada = true;
            }

            // NEUMONÍA / BRONCONEUMONÍA
            else if (checkBox4.Checked && checkBox7.Checked)
            {
                richTextBox1.Text =
                "Posible enfermedad: Neumonía / Bronconeumonía\n\n" +
                "Síntomas detectados:\n- Dificultad respiratoria\n- Secreción nasal\n\n" +
                "Causas:\n- Humedad\n- Mala ventilación\n\n" +
                "Prevención:\n- Mejorar ventilación\n\n" +
                "Control:\n- Tetraciclinas\n";
                enfermedadDetectada = true;
            }

            // ECTOPARÁSITOS
            else if (checkBox5.Checked && checkBox8.Checked)
            {
                richTextBox1.Text =
                "Posible problema: Ectoparásitos\n\n" +
                "Síntomas:\n- Picazón\n- Decaimiento\n\n" +
                "Control:\n- Insecticidas\n- Limpieza profunda\n";
                enfermedadDetectada = true;
            }

            // Si NO hubo enfermedad
            if (!enfermedadDetectada)
            {
                richTextBox1.Text =
                "No se detectó una enfermedad específica.\n" +
                "Observe más síntomas y refuerce la higiene.\n";
            }
            int edad;
            double peso;

            if (int.TryParse(edadtxt.Text, out edad) &&
                double.TryParse(pesotxt.Text, out peso))
            {
                richTextBox1.AppendText("\n--- Evaluación por edad y peso ---\n");

                if (edad <= 1)
                {
                    richTextBox1.AppendText(
                        peso < 100 ? "Bajo peso para la edad.\n" :
                        peso <= 200 ? "Peso adecuado para la edad.\n" :
                        "Peso elevado para la edad.\n");
                }
                else if (edad <= 3)
                {
                    richTextBox1.AppendText(
                        peso < 150 ? "Bajo peso, posible problema sanitario.\n" :
                        peso <= 300 ? "Peso adecuado.\n" :
                        "Sobrepeso leve.\n");
                }
                else
                {
                    richTextBox1.AppendText(
                        peso < 400 ? "Bajo peso, revisar parásitos o alimentación.\n" :
                        peso <= 900 ? "Peso adecuado.\n" :
                        "Sobrepeso.\n");
                }
            }
            else
            {
                richTextBox1.AppendText("\n[Edad o peso no válidos]\n");
            }




        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox2.Checked = false; // Diarrea
                checkBox3.Checked = false; // Caída de pelo
                checkBox5.Checked = false; // Picazón
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox4.Checked = false; // Respiratorio
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox4.Checked = false;
            }
        }

        private void Sanidad_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            InteSanidad a = new InteSanidad();  
            a.Show();    
            this.Hide();
        }

        private void contracfm_Enter(object sender, EventArgs e)
        {
            if(edadtxt.Text== "Edad (meses):")
                {
                edadtxt.Text = "";
                edadtxt.ForeColor = Color.Black;
            }
        }

        private void contracfm_TextChanged(object sender, EventArgs e)
        {

        }

        private void contracfm_Leave(object sender, EventArgs e)
        {
            if(edadtxt.Text=="")
                {
                edadtxt.Text = "Edad (meses):";
                edadtxt.ForeColor = Color.Black;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(pesotxt.Text== "Peso (gramos):")
                {
                pesotxt.Text = "";
                pesotxt.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(pesotxt.Text=="")
                {
                pesotxt.Text = "Peso (gramos):";
                pesotxt.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar CheckBox
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;

            // Limpiar TextBox
            pesotxt.Text = "Peso (gramos):"; 
            edadtxt.Text = "Edad (meses):"; 

            // Limpiar resultados
            richTextBox1.Clear();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SanidadPrincipal a = new SanidadPrincipal();
            a.Show();
            this.Hide();
        }
    }
}

