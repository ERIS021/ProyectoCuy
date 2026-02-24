using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Produccion : Form
    {
        public Produccion()
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

        private void Produccion_Load(object sender, EventArgs e)
        {

        }

        private void btt_ges_Click(object sender, EventArgs e)
        {
            GestionCuyProduccion a = new GestionCuyProduccion();  
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionClientesProduccion a = new GestionClientesProduccion();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroVentaProduccion a = new RegistroVentaProduccion();  
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportesVentasProduccion a = new ReportesVentasProduccion();
            a.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            InteProduccion a = new InteProduccion();
            a.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Produccion0 a = new Produccion0();
            a.Show();
            this.Hide();
        }
    }
}
