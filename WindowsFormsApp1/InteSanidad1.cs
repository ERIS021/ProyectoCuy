using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InteSanidad1 : Form
    {
        bool juegoTerminado = false;
        int puntaje = 0;
        int pregunta = 0;
        int tiempo = 100;
        Random rnd = new Random();
        List<Point> posiciones = new List<Point>();
        public InteSanidad1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            puntaje += 10;

            label2.Text = "✔ Decisión correcta";
            label2.ForeColor = Color.Green;
            label3.Text = "Puntaje: " + puntaje;

            MessageBox.Show("Buena decisión.\nSe controla el problema sanitario.");
            SiguientePregunta();
        }

        private void InteSanidad1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            label3.Text = "Puntaje: 0";
            // Guardar posiciones iniciales
            posiciones.Add(button1.Location);
            posiciones.Add(button2.Location);
            posiciones.Add(button3.Location);

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

            if (pregunta == 0)
            {
                label1.Text =
                "Un cuy joven presenta diarrea y pérdida de peso.\nEl corral está húmedo.";

                button1.Text = "Limpiar y dar sulfaquinoxalina"; // ✔
                button2.Text = "Dar más alimento verde";
                button3.Text = "No hacer nada";
            }
            else if (pregunta == 1)
            {
                label1.Text =
                "Un cuy presenta secreción nasal y dificultad respiratoria.";

                button1.Text = "Mejorar ventilación y dar tetraciclinas"; // ✔
                button2.Text = "Encerrar más los cuyes";
                button3.Text = "Mojar la cama";
            }
            else if (pregunta == 2)
            {
                label1.Text =
                "Un cuy tiene caída de pelo, enrojecimiento y picazón.";

                button1.Text = "Aislar y aplicar antifúngicos"; // ✔
                button2.Text = "Bañarlo constantemente";
                button3.Text = "Mantenerlo con los demás";
            }
            else if (pregunta == 3)
            {
                label1.Text =
                "Los cuyes presentan picazón, heridas y decaimiento.";

                button1.Text = "Limpiar corrales y usar insecticidas"; // ✔
                button2.Text = "Cambiar solo el alimento";
                button3.Text = "Ignorar el problema";
            }
            else if (pregunta == 4)
            {
                label1.Text =
                "Un cuy muestra decaimiento, diarrea y hay muertes \n repentinas.";

                button1.Text = "Cuarentena y desinfección"; // ✔
                button2.Text = "Separar solo al más débil";
                button3.Text = "Esperar a que pase";
            }
            else
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

                MessageBox.Show(
                    "Puntaje final: " + puntaje + "\n" +
                    "Ranking: " + ranking
                );
            }


        }
        
        void MezclarBotones()
        {
            var mezcladas = posiciones.OrderBy(x => rnd.Next()).ToList();
            button1.Location = mezcladas[0];
            button2.Location = mezcladas[1];
            button3.Location = mezcladas[2];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RespuestaIncorrecta("La enfermedad empeora.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RespuestaIncorrecta("Aumenta la mortalidad.");
        }
        void RespuestaIncorrecta(string mensaje)
        {
            timer1.Stop();

            label2.Text = "❌ Decisión incorrecta";
            label2.ForeColor = Color.Red;
            label3.Text = "Puntaje: " + puntaje;

            MessageBox.Show("Mala decisión.\n" + mensaje);
            SiguientePregunta();
        }

        void SiguientePregunta()
        {
            pregunta++;
            CargarPregunta();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();    
            a.Show();
            this.Close();
        }
        string ObtenerRanking()
        {
            if (puntaje >= 40)
                return "🥇 Experto en sanidad de cuyes";
            else if (puntaje >= 25)
                return "🥈 Buen cuidador de cuyes";
            else if (puntaje >= 10)
                return "🥉 Principiante en sanidad";
            else
                return "❌ Necesita mejorar el manejo sanitario";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Sanidad a = new Sanidad();
            a.Show();
            this.Hide();
        }
    }
}
