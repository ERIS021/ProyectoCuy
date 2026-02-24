using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InteProduccion2 : Form
    {
        int pares = 8;
        int filas = 4;
        int columnas = 4;
        int movimientos = 0;
        int tiempo = 0;
        string dificultad = "Facil";
        int vidas = 3;

        int parejasEncontradas = 0;

        bool puedeJugar = true;
        bool juegoIniciado = false;

        List<int> cartas;
        List<int> cartasMezcladas;
        List<PictureBox> seleccionadas = new List<PictureBox>();

        PictureBox carta1;
        PictureBox carta2;
        public InteProduccion2(string nivel)
        {
            InitializeComponent();
            dificultad = nivel;
            InicializarJuego();
            ActualizarVidas();
        }
        
        Bitmap ObtenerImagen(int numero)
        {
            return (Bitmap)Properties.Resources.ResourceManager
          .GetObject("img" + (numero + 1));
        }
        void InicializarJuego()
        {
            panelJuego.Controls.Clear();
            panelJuego.BackColor = SystemColors.Control;

            movimientos = 0;

            if (dificultad == "Facil")
            {
                filas = 2;
                columnas = 3;
                pares = 3;
                tiempo = 6;
            }
            else if (dificultad == "Medio")
            {
                filas = 4;
                columnas = 4;
                pares = 8;
                tiempo = 35;
            }
            else if (dificultad == "Dificil")
            {
                filas = 4;
                columnas = 6;
                pares = 12;
                tiempo = 60;
            }

            parejasEncontradas = 0;

            lblMovimiento.Text = "Movimientos: 0";
            lblTiempo.Text = "Tiempo: " + tiempo + " s";

            cartas = new List<int>();
            cartasMezcladas = new List<int>();
            seleccionadas.Clear();

            puedeJugar = true;
            juegoIniciado = false;

            timerTiempo.Stop();
            timerPreview.Stop();

            // Crear pares
            for (int i = 0; i < pares; i++)
            {
                cartas.Add(i);
                cartas.Add(i);
            }

            Random rnd = new Random();
            cartasMezcladas = cartas.OrderBy(x => rnd.Next()).ToList();

            // Tabla
            TableLayoutPanel tabla = new TableLayoutPanel();
            tabla.RowCount = filas;
            tabla.ColumnCount = columnas;
            tabla.Dock = DockStyle.Fill;

            for (int i = 0; i < filas; i++)
                tabla.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / filas));

            for (int j = 0; j < columnas; j++)
                tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnas));

            int contador = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    PictureBox carta = new PictureBox();
                    carta.Name = contador.ToString();
                    carta.Dock = DockStyle.Fill;
                    carta.SizeMode = PictureBoxSizeMode.StretchImage;
                    carta.Image = Properties.Resources.girada;
                    carta.Cursor = Cursors.Hand;
                    carta.Click += Carta_Click;

                    tabla.Controls.Add(carta, j, i);
                    contador++;
                }
            }

            panelJuego.Enabled = true;
            juegoIniciado = false;
            timerTiempo.Stop();
            timerPreview.Stop();
            panelJuego.Controls.Add(tabla);
        }

        void MostrarTodasLasCartas()
        {
            foreach (Control c in panelJuego.Controls[0].Controls)
            {
                PictureBox carta = (PictureBox)c;
                int indice = int.Parse(carta.Name);
                int valor = cartasMezcladas[indice];
                carta.Image = ObtenerImagen(valor);
            }
        }

        void OcultarTodasLasCartas()
        {
            foreach (Control c in panelJuego.Controls[0].Controls)
            {
                ((PictureBox)c).Image = Properties.Resources.girada;
            }
        }


        void Carta_Click(object sender, EventArgs e)
        {
            if (!juegoIniciado) return;
            if (!puedeJugar) return;

            PictureBox carta = (PictureBox)sender;
            if (seleccionadas.Contains(carta)) return;

            SystemSounds.Beep.Play();

            int indice = int.Parse(carta.Name);
            int valor = cartasMezcladas[indice];

            carta.Image = ObtenerImagen(valor);
            seleccionadas.Add(carta);

            if (seleccionadas.Count == 2)
            {
                puedeJugar = false;

                carta1 = seleccionadas[0];
                carta2 = seleccionadas[1];

                int v1 = cartasMezcladas[int.Parse(carta1.Name)];
                int v2 = cartasMezcladas[int.Parse(carta2.Name)];

                movimientos++;
                lblMovimiento.Text = "Movimientos: " + movimientos;

                if (v1 != v2)
                {
                    SystemSounds.Hand.Play();

                    Timer t = new Timer();
                    t.Interval = 800;
                    t.Tick += (s, a) =>
                    {
                        carta1.Image = Properties.Resources.girada;
                        carta2.Image = Properties.Resources.girada;
                        seleccionadas.Clear();
                        puedeJugar = true;
                        t.Stop();
                    };
                    t.Start();
                }
                else
                {
                    SystemSounds.Asterisk.Play();

                    carta1.Enabled = false;
                    carta2.Enabled = false;
                    seleccionadas.Clear();
                    puedeJugar = true;

                    parejasEncontradas++;

                    if (parejasEncontradas == pares)
                    {
                        timerTiempo.Stop();
                        panelJuego.BackColor = Color.LightGreen;
                        SystemSounds.Exclamation.Play();

                        string siguienteNivel = "";

                        if (dificultad == "Facil")
                            siguienteNivel = "Medio";
                        else if (dificultad == "Medio")
                            siguienteNivel = "Dificil";
                        else if (dificultad == "Dificil")
                            siguienteNivel = "";

                        if (siguienteNivel != "")
                        {
                            DialogResult r = MessageBox.Show(
                                $"🎉 ¡Ganaste el nivel {dificultad}!\n\n¿Quieres pasar al nivel {siguienteNivel}?",
                                "¡Siguiente Nivel!",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information
                            );

                            if (r == DialogResult.Yes)
                            {
                                InteProduccion2 nuevo = new InteProduccion2(siguienteNivel);
                                nuevo.Show();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "🏆 ¡Felicidades! Completaste todos los niveles.",
                                "¡Juego completado!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            ); 
                        }
                    }
                }
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
           InteProduccion a = new InteProduccion();
            a.Show();
            this.Hide();    
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Hide();
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
            this.WindowState=FormWindowState.Minimized;
        }

        private void InteProduccion2_Load(object sender, EventArgs e)
        {

        }

        
        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            tiempo--;
            lblTiempo.Text = "Tiempo: " + tiempo + " s";

            if (tiempo == 0)
            {
                timerTiempo.Stop();
                timerPreview.Stop();
                panelJuego.Enabled = false;

                vidas--;
                ActualizarVidas();

                if (vidas == 0)
                {
                    MessageBox.Show(
                        "💀 Te quedaste sin vidas.\nHas perdido el juego.",
                        "Game Over",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    this.Close(); // o volver al menú
                    return;
                }

                DialogResult r = MessageBox.Show(
                    "⏰ Se acabó el tiempo.\nTe queda(n) " + vidas + " vida(s).\n¿Intentar de nuevo?",
                    "Tiempo agotado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (r == DialogResult.Yes)
                {
                    InicializarJuego();
                }
            }


        }

        private void timerPreview_Tick(object sender, EventArgs e)
        {
            OcultarTodasLasCartas();
            timerPreview.Stop();

            juegoIniciado = true;
            timerTiempo.Start();
        }

        private void btt_click_Click(object sender, EventArgs e)
        {
            if (juegoIniciado) return;

            MostrarTodasLasCartas();

            timerPreview.Start();

            System.Media.SystemSounds.Asterisk.Play();
        }

        private void btt_rn_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Question.Play();
            InicializarJuego();
        }

        void ActualizarVidas()
        {
            pbVida1.Visible = vidas >= 1;
            pbVida2.Visible = vidas >= 2;
            pbVida3.Visible = vidas >= 3;
        }

        private void lblTiempo_Click(object sender, EventArgs e)
        {

        }

        private void panelJuego_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
