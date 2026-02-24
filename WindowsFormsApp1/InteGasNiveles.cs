using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InteGasNiveles : Form
    {
        public InteGasNiveles()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            RecetasApartado apartado = new RecetasApartado();
            this.Hide();
            apartado.Show();
        }

        InteGastronomia juego = new InteGastronomia();
        private void nivel1_Click(object sender, EventArgs e)
        {
            Progreso.nivel1 = true;
            this.Hide();
            juego.Show();           
        }

        private void nivel2_Click(object sender, EventArgs e)
        {
            Progreso.nivel2 = true;
            this.Hide();
            juego.Show();
        }

        private void nivel3_Click(object sender, EventArgs e)
        {
            Progreso.nivel3 = true;
            this.Close();
            juego.Show();            
        }

        private void InteGasNiveles_Load(object sender, EventArgs e)
        {
            NivelesCompletados();
        }

        private void NivelesCompletados()
        {
            if (Progreso.nivel1_completado)
            {
                lblNivel1.Text = "COMPLETADO";
                lblNivel1.ForeColor = Color.Green;
            }

            if (Progreso.nivel2_completado)
            {
                lblNivel2.Text = "COMPLETADO";
                lblNivel2.ForeColor = Color.Green;
            }

            if (Progreso.nivel3_completado)
            {
                lblNivel3.Text = "COMPLETADO";
                lblNivel3.ForeColor = Color.Green;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static class Progreso
        {
            public static bool nivel1 = false;
            public static bool nivel1_completado = false;
            public static bool nivel2 = false;
            public static bool nivel2_completado = false;
            public static bool nivel3 = false;
            public static bool nivel3_completado = false;
        }
    }
}
