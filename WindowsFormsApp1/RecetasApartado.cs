using cuy;
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
    public partial class RecetasApartado : Form
    {
        public RecetasApartado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SabiasQue sabiaque = new SabiasQue();
            sabiaque.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceHorno recetas = new ReceHorno();
            recetas.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            InteGasNiveles a = new InteGasNiveles();
            a.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            ReceFritas fritas = new ReceFritas();
            this.Hide();
            fritas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReceGuisadas guisadas = new ReceGuisadas();
            this.Hide();
            guisadas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReceEspeciales especiales = new ReceEspeciales();
            this.Hide();
            especiales.Show(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            SabiasQue sabiaque = new SabiasQue();
            this.Hide();
            sabiaque.Show();
        }
    }
}
