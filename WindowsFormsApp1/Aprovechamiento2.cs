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
    public partial class Aprovechamiento2 : Form
    {
        public Aprovechamiento2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Aprovechamiento1 a = new Aprovechamiento1();
            a.Show();
            this.Hide();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Aprovechamiento3 a = new Aprovechamiento3();
            a.Show();
            this.Hide();
        }
    }
}
