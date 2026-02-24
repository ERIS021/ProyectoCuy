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
    public partial class CrRazas1 : Form
    {
        public CrRazas1()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            gestacionytiposdecuy a = new gestacionytiposdecuy();
            a.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Hide();
        }
    }
}
