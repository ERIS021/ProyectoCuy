using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace cuy
{
    public partial class InteCrianza : Form
    {
        public InteCrianza()
        {
            InitializeComponent();
        }

        private void JuegoCrianza_Load(object sender, EventArgs e)
        {
            RandomizarButtons();
        }

        private void RandomizarButtons()
        {
            Random random = new Random();
            string letras = "BDMXZCRIANEPODUYSLV";
            char Letra() => letras[random.Next(letras.Length)];

            foreach (Control button in panel1.Controls)
            {
                button.Text = Letra().ToString();
            }
        }

        //Reincia todo, habilita los button, reincia palabra y contador
        private void ReinicarTodo()
        {
            //habilita los button marcados
            foreach (Control ctrl in buttons)
            {
                ctrl.Enabled = true;
            }
            
            //reinica la variable palabra y contador, y el txt de palabra formada
            palabra = "";
            cont = 0;
            lblPalabra.Text = "";
        }

        //boton de volver a jugar
        private void Jugar(object sender, EventArgs e)
        {
            RandomizarButtons();
            ReinicarTodo();

            crianza.Enabled = true;
            cuyes.Enabled = true;
            ciclo.Enabled = true;
            reproduccion.Enabled = true;
            crias.Enabled = true;
            vida.Enabled = true;
        }

        //variable que guardar las letras para verificar la palabra
        string palabra;

        //lista tipo Button para guardar los button seleccionados
        List<Button> buttons = new List<Button>();

        //Guarda las letras seleccionadas
        private void GuardarLetra(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string letra = btn.Text;

            btn.Enabled = false;
            buttons.Add(btn);

            palabra += letra;
            lblPalabra.Text += letra;

            LetrasSeleccionada();
        }

        int cont = 0;
        //verifica si se a encontrado la palabra
        private void LetrasSeleccionada()
        {
            if (crianza.Checked == true)
            {
                cont++;
                if (cont == 7 && palabra == "CRIANZA")
                {
                    MessageBox.Show("Has encontrado Crianza¡");
                    crianza.Enabled = false;
                    crianza.Checked = false;
                    Ganar();
                }
                else if (cont == 7 && palabra != "CRIANZA")
                {
                    MessageBox.Show("INCORRECTO¡");
                    ReinicarTodo();
                }
            }
            if (ciclo.Checked == true)
            {
                cont++;
                if (cont == 5 && palabra == "CICLO")
                {
                    MessageBox.Show("Has encontrado Ciclo¡");
                    ciclo.Enabled = false;
                    ciclo.Checked = false;
                    Ganar();
                }
                else if (cont == 5 && palabra != "CICLO")
                {
                    MessageBox.Show("INCORRECTO¡");
                    ReinicarTodo();
                }
            }
            if (reproduccion.Checked == true)
            {
                cont++;
                if (cont == 12 && palabra == "REPRODUCCION")
                {
                    MessageBox.Show("Has encontrado Reproducción¡");
                    reproduccion.Enabled = false;
                    reproduccion.Checked = false;
                    Ganar();
                }
                else if (cont == 12 && palabra != "REPRODUCCION")
                {
                    MessageBox.Show("INCORRECTO¡");
                    ReinicarTodo();
                }
            }
            if (cuyes.Checked == true)
            {
                cont++;
                if (cont == 5 && palabra == "CUYES")
                {
                    MessageBox.Show("Has encontrado Cuyes¡");
                    cuyes.Enabled = false;
                    cuyes.Checked = false;
                    Ganar();
                }
                else if (cont == 5 && palabra != "CUYES")
                {
                    MessageBox.Show("INCORRECTO¡");
                    ReinicarTodo();
                }
            }
            if (crias.Checked == true)
            {
                cont++;
                if (cont == 5 && palabra == "CRIAS")
                {
                    MessageBox.Show("Has encontrado Crias¡");
                    crias.Enabled = false;
                    crias.Checked = false;
                    Ganar();
                }
                else if (cont == 5 && palabra != "CRIAS")
                {
                    MessageBox.Show("INCORRECTO¡");
                    ReinicarTodo();
                }
            }
            if (vida.Checked == true)
            {
                cont++;
                if (cont == 4 && palabra == "VIDA")
                {
                    MessageBox.Show("Has encontrado Vida¡");
                    vida.Enabled = false;
                    vida.Checked = false;
                    Ganar();
                }
                else if (cont == 4 && palabra != "VIDA")
                {
                    MessageBox.Show("INCORRECTO¡");
                    ReinicarTodo();
                }
            }
        }

        //reinicia al cambiar de opcion
        private void CambiarOpcion(object sender, EventArgs e)
        {
            ReinicarTodo();
        }

        //reincia la palabra
        private void bttReinciarPalabra_Click(object sender, EventArgs e)
        {
            ReinicarTodo();
        }

        private void Ganar()
        {
            if (crianza.Enabled == false && ciclo.Enabled == false && reproduccion.Enabled == false && cuyes.Enabled == false && crias.Enabled == false && vida.Enabled == false)
            {
                MessageBox.Show("HAS GANADO¡\nFELICITACIONES¡");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CCrianza a = new CCrianza();
            a.Show();
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
    }
}
