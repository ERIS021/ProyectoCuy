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
    public partial class SanidadInteFacil : Form
    {
        bool juegoTerminado = false;
        int puntaje = 0;
        int pregunta = 0;
        int tiempo = 100;

        Random rnd = new Random();
        List<Point> posiciones = new List<Point>();
        public SanidadInteFacil()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            juegoTerminado = true;
            timer1.Stop();
            SanidadDificultad sanidadDificultad = new SanidadDificultad();
            sanidadDificultad.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            RespuestaCorrecta();
        }

        private void SanidadInteFacil_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            label3.Text = "Puntaje: 0";

            posiciones.Add(button1.Location);
            posiciones.Add(button2.Location);
            posiciones.Add(button3.Location);

            CargarPregunta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RespuestaIncorrecta("La enfermedad empeora.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RespuestaIncorrecta("Aumenta la mortalidad.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo--;
            progressBar1.Value = tiempo;

            if (tiempo <= 0)
            {
                timer1.Stop();
                puntaje -= 5;
                label3.Text = "Puntaje: " + puntaje;

                label2.Text = "❌ Tiempo agotado";
                label2.ForeColor = Color.Red;

                MessageBox.Show("Consecuencia: aumenta el riesgo sanitario.");
                SiguientePregunta();
            }
        }
        void CargarPregunta()
        {
            tiempo = 100;
            progressBar1.Value = 100;
            label2.Text = "";
            timer1.Start();

            MezclarBotones();

            // FÁCIL
            if (pregunta == 0)
            {
                label1.Text =
                "Un cuy joven presenta diarrea acuosa y pérdida de peso.\n" +
                "El corral está húmedo y con restos de heces.";

                AsignarOpciones(
                    "Limpiar el corral y medicar",
                    "Aumentar forraje verde",
                    "Esperar evolución"
                );
            }
            else if (pregunta == 1)
            {
                label1.Text =
                "Un cuy presenta estornudos frecuentes y secreción nasal.";

                AsignarOpciones(
                    "Mejorar ventilación y tratar",
                    "Cerrar el galpón",
                    "Bañarlo"
                );
            }
            else if (pregunta == 2)
            {
                label1.Text =
                "Se observa caída de pelo, enrojecimiento de la piel\n" +
                "y rascado constante.";

                AsignarOpciones(
                    "Aislar y aplicar tratamiento",
                    "Cambiar solo alimento",
                    "Esperar mejoría"
                );
            }
            else if (pregunta == 3)
            {
                label1.Text =
                "Los cuyes presentan picazón, pequeñas heridas\n" +
                "y decaimiento.";

                AsignarOpciones(
                    "Limpiar corrales y desparasitar",
                    "Dar vitaminas",
                    "No intervenir"
                );
            }
            else if (pregunta == 4)
            {
                label1.Text =
                "Un cuy muestra decaimiento, diarrea leve\n" +
                "y pérdida de apetito.";

                AsignarOpciones(
                    "Aislar y limpiar el ambiente",
                    "Aumentar alimento",
                    "Esperar sin tratar"
                );
            }

            else
            {
                FinalizarJuego();
            }
        }

        void AsignarOpciones(string correcta, string opcion2, string opcion3)
        {
            button1.Text = correcta;
            button2.Text = opcion2;
            button3.Text = opcion3;
        }

        void RespuestaCorrecta()
        {
            timer1.Stop();
            puntaje += 10;

            label2.Text = "✔ Decisión correcta";
            label2.ForeColor = Color.Green;
            label3.Text = "Puntaje: " + puntaje;

            MessageBox.Show("Buena decisión.\nSe controla el problema sanitario.");
            SiguientePregunta();
        }

        void RespuestaIncorrecta(string mensaje)
        {
            timer1.Stop();

            label2.Text = "❌ Decisión incorrecta";
            label2.ForeColor = Color.Red;

            MessageBox.Show("Mala decisión.\n" + mensaje);
            SiguientePregunta();
        }

        void MezclarBotones()
        {
            var mezcladas = posiciones.OrderBy(x => rnd.Next()).ToList();
            button1.Location = mezcladas[0];
            button2.Location = mezcladas[1];
            button3.Location = mezcladas[2];
        }

        void SiguientePregunta()
        {
            pregunta++;
            CargarPregunta();
        }

        void FinalizarJuego()
        {
            juegoTerminado = true;
            timer1.Stop();

            string ranking = ObtenerRanking();

            label1.Text = "🎉 Trivia finalizada";
            label2.Text = ranking;
            label2.ForeColor = Color.Blue;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            progressBar1.Value = 0;

            MessageBox.Show("Puntaje final: " + puntaje + "\nRanking: " + ranking);
        }

        string ObtenerRanking()
        {
            if (puntaje >= 40) return "🥇 Experto en sanidad de cuyes";
            if (puntaje >= 25) return "🥈 Buen cuidador de cuyes";
            if (puntaje >= 10) return "🥉 Principiante en sanidad";
            return "❌ Necesita mejorar el manejo sanitario";
        }
    }
}
