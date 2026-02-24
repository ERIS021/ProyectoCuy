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
    public partial class InteProduccion : Form
    {
        string nivelSeleccionado = "Medio";
        public InteProduccion()
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Produccion0 a = new Produccion0();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InteProduccion2 juego = new InteProduccion2(nivelSeleccionado);
            juego.Show();
            this.Hide();
        }

        private void btt_reglas_Click(object sender, EventArgs e)
        {             
            panelReglas.Visible = true;
            panelReglas.BringToFront();

        }

        private void panelReglas_Click(object sender, EventArgs e)
        {

        }

        private void btt_cerrar_Click(object sender, EventArgs e)
        {
            panelReglas.Visible = false;
        }

        private void btt_niveles_Click(object sender, EventArgs e)
        {
            panelNiveles.Location = new Point(291, 116);
            pictureBox6.Location = new Point (8, 0);
            panelNiveles.Visible = true;
            panelNiveles.BringToFront();
        }

        private void btt_facil_Click(object sender, EventArgs e)
        {
            nivelSeleccionado = "Facil";
            panelNiveles.Visible = false;
        }

        private void bb_medio_Click(object sender, EventArgs e)
        {
            nivelSeleccionado = "Medio";
            panelNiveles.Visible = false;
        }

        private void btt_dificil_Click(object sender, EventArgs e)
        {
            nivelSeleccionado = "Dificil";
            panelNiveles.Visible = false;
        }


        private void btt_Click_1(object sender, EventArgs e)
        {
            panelNiveles.Visible = false;
        }

        private void panelNiveles_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
