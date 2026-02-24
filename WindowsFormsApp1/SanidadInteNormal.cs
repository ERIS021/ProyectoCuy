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
    public partial class SanidadInteNormal : Form
    {
        bool juegoTerminado = false;
        int puntaje = 0;
        int pregunta = 0;
        int tiempo = 90;

        Random rnd = new Random();
        List<Point> posiciones = new List<Point>();
        public SanidadInteNormal()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
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

        private void SanidadInteNormal_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 90;
            label3.Text = "Puntaje: 0";

            posiciones.Add(button1.Location);
            posiciones.Add(button2.Location);
            posiciones.Add(button3.Location);
            posiciones.Add(button4.Location);

            CargarPregunta();
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

                MessageBox.Show("El problema sanitario se agrava.");
                SiguientePregunta();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RespuestaCorrecta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RespuestaIncorrecta("El tratamiento no es adecuado.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RespuestaIncorrecta("Aumenta el riesgo de contagio.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RespuestaIncorrecta("La condición sanitaria empeora.");
        }
        void CargarPregunta()
        {
            tiempo = 90;
            progressBar1.Value = 90;
            label2.Text = "";
            timer1.Start();

            MezclarBotones();

           
            if (pregunta == 0)
            {
                label1.Text =
                "Varios cuyes presentan diarrea persistente,\n" +
                "deshidratación y mala higiene en el corral.";

                AsignarOpciones(
                    "Aislar, desinfectar y medicar",
                    "Cambiar solo el alimento",
                    "Dar agua con electrolitos",
                    "Separar los más débiles"
                );
            }
            else if (pregunta == 1)
            {
                label1.Text =
                "Cuyes con secreción nasal, estornudos y\n" +
                "corrientes de aire en el galpón.";

                AsignarOpciones(
                    "Corregir ventilación y tratar",
                    "Cerrar completamente el galpón",
                    "Mojar la cama",
                    "Reducir animales"
                );
            }
            else if (pregunta == 2)
            {
                label1.Text =
                "Se detectan zonas sin pelo, costras\n" +
                "y prurito intenso en varios cuyes.";

                AsignarOpciones(
                    "Aislar y aplicar antiparasitario",
                    "Bañarlos diariamente",
                    "Aumentar proteína",
                    "Separar afectados"
                );
            }
            else if (pregunta == 3)
            {
                label1.Text =
                "Hay muertes repentinas, diarrea severa\n" +
                "y decaimiento generalizado.";

                AsignarOpciones(
                    "Cuarentena y aviso veterinario",
                    "Separar los más débiles",
                    "Cambiar la cama",
                    "Dar vitaminas"
                );
            }
            else if (pregunta == 4)
            {
                label1.Text =
                "El corral presenta humedad constante\n" +
                "y aumento de enfermedades.";

                AsignarOpciones(
                    "Mejorar drenaje y limpieza",
                    "Aumentar ventilación",
                    "Cambiar dieta",
                    "Reducir animales"
                );
            }

            else
            {
                FinalizarJuego();
            }

        }
        void AsignarOpciones(string correcta, string op2, string op3, string op4)
        {
            button1.Text = correcta;
            button2.Text = op2;
            button3.Text = op3;
            button4.Text = op4;
        }

        void RespuestaCorrecta()
        {
            timer1.Stop();
            puntaje += 15;

            label2.Text = "✔ Decisión correcta";
            label2.ForeColor = Color.Green;
            label3.Text = "Puntaje: " + puntaje;

            MessageBox.Show("Buena decisión.\nSe controla el brote sanitario.");
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
            button4.Location = mezcladas[3];
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

            label1.Text = "🎉 Nivel Normal finalizado";
            label2.Text = ranking;
            label2.ForeColor = Color.Blue;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            progressBar1.Value = 0;

            MessageBox.Show("Puntaje final: " + puntaje + "\nRanking: " + ranking);
        }

        string ObtenerRanking()
        {
            if (puntaje >= 45) return "🥇 Excelente manejo sanitario";
            if (puntaje >= 30) return "🥈 Buen manejo";
            if (puntaje >= 15) return "🥉 Manejo básico";
            return "❌ Manejo deficiente";
        }

    }
}
