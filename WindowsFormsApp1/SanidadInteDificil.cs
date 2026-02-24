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
    public partial class SanidadInteDificil : Form
    {
        bool juegoTerminado = false;
        int puntaje = 0;
        int pregunta = 0;
        int tiempo = 100;

        Random rnd = new Random();
        List<Point> posiciones = new List<Point>();
        public SanidadInteDificil()
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

        private void SanidadInteDificil_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            label3.Text = "Puntaje: 0";

            posiciones.Add(button1.Location);
            posiciones.Add(button2.Location);
            posiciones.Add(button3.Location);
            posiciones.Add(button4.Location);
            posiciones.Add(button5.Location);

            CargarPregunta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Correcta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Incorrecta("Tratamiento incompleto.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Incorrecta("Aumenta el contagio.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo--;
            progressBar1.Value = tiempo;

            if (tiempo <= 0)
            {
                timer1.Stop();
                puntaje -= 10;
                label3.Text = "Puntaje: " + puntaje;

                label2.Text = "❌ Tiempo agotado";
                label2.ForeColor = Color.Red;

                MessageBox.Show("Consecuencia grave: brote sanitario.");
                SiguientePregunta();
            }
        }
        void CargarPregunta()
        {
            tiempo = 60;
            progressBar1.Value = 60;
            label2.Text = "";
            timer1.Start();

            MezclarBotones();


            if (pregunta == 0)
            {
                label1.Text =
                "Alta mortalidad, diarrea severa y deshidratación.\n" +
                "Corrales húmedos y sin desinfección.";

                AsignarOpciones(
                    "Cuarentena total, desinfección y tratamiento clínico",
                    "Cambiar solo el alimento",
                    "Separar algunos cuyes",
                    "Aumentar suministro de agua",
                    "Esperar evolución"
                );
            }
            else if (pregunta == 1)
            {
                label1.Text =
                "Problemas respiratorios recurrentes,\n" +
                "hacinamiento y mala ventilación.";

                AsignarOpciones(
                    "Mejorar ventilación, reducir densidad y tratar",
                    "Cerrar el galpón",
                    "Mojar la cama",
                    "Reducir alimento",
                    "No intervenir"
                );
            }
            else if (pregunta == 2)
            {
                label1.Text =
                "Lesiones cutáneas generalizadas,\n" +
                "prurito intenso y pérdida de pelo.";

                AsignarOpciones(
                    "Aislar, desinfectar y aplicar antiparasitario",
                    "Bañar diariamente",
                    "Aumentar proteína",
                    "Mantenerlos juntos",
                    "Ignorar síntomas"
                );
            }
            else if (pregunta == 3)
            {
                label1.Text =
                "Brotes repetidos de enfermedad\n" +
                "a pesar de tratamientos previos.";

                AsignarOpciones(
                    "Revisar manejo sanitario y asesoría veterinaria",
                    "Cambiar medicamentos",
                    "Aumentar dosis",
                    "Separar animales",
                    "Esperar resultados"
                );
            }
            else if (pregunta == 4)
            {
                label1.Text =
                "Alta incidencia de enfermedades\n" +
                "relacionadas con higiene deficiente.";

                AsignarOpciones(
                    "Implementar programa preventivo y bioseguridad",
                    "Limpiar solo cuando haya síntomas",
                    "Dar vitaminas periódicamente",
                    "Reducir población",
                    "No intervenir"
                );
            }

            else
            {
                Finalizar();
            }
        }

        void AsignarOpciones(string correcta, string b2, string b3, string b4, string b5)
        {
            button1.Text = correcta;
            button2.Text = b2;
            button3.Text = b3;
            button4.Text = b4;
            button5.Text = b5;
        }

        void Correcta()
        {
            timer1.Stop();
            puntaje += 20;

            label2.Text = "✔ Decisión correcta";
            label2.ForeColor = Color.Green;
            label3.Text = "Puntaje: " + puntaje;

            MessageBox.Show("Excelente manejo sanitario.");
            SiguientePregunta();
        }

        void Incorrecta(string msg)
        {
            timer1.Stop();

            label2.Text = "❌ Decisión incorrecta";
            label2.ForeColor = Color.Red;

            MessageBox.Show(msg);
            SiguientePregunta();
        }

        void MezclarBotones()
        {
            var mix = posiciones.OrderBy(x => rnd.Next()).ToList();
            button1.Location = mix[0];
            button2.Location = mix[1];
            button3.Location = mix[2];
            button4.Location = mix[3];
            button5.Location = mix[4];
        }

        void SiguientePregunta()
        {
            pregunta++;
            CargarPregunta();
        }

        void Finalizar()
        {
            timer1.Stop();

            string r;
            if (puntaje >= 40) r = "🥇 Nivel experto";
            else if (puntaje >= 20) r = "🥈 Buen manejo";
            else r = "❌ Manejo deficiente";

            label1.Text = "🎉 Nivel Difícil finalizado";
            label2.Text = r;
            label2.ForeColor = Color.Blue;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

            progressBar1.Value = 0;

            MessageBox.Show("Puntaje final: " + puntaje);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Incorrecta("No soluciona el problema.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Incorrecta("Empeora la sanidad.");
        }
    }
}
