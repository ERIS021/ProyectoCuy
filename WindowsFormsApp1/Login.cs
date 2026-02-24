using cuy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().ToLower() == DatosUsuario.Usuari0 && textBox2.Text.Trim().ToLower() == DatosUsuario.Contra)
            {
                NombreUsuario.Usuario = textBox1.Text;
                MessageBox.Show("Sesion iniciada");
                this.Close();
                Menu a = new Menu();
                a.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Registro a = new Registro();
            a.Show();
            this.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "USUARIO")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.FromArgb(79, 43, 41);

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "USUARIO";
                textBox1.ForeColor = Color.FromArgb(79, 43, 41);

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "CONTRASEÑA")
            {
                textBox2.Text = "";
                textBox1.ForeColor = Color.FromArgb(79, 43, 41);

                textBox2.UseSystemPasswordChar = true; 
            }
        }


        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.UseSystemPasswordChar = false; // 🔥 CLAVE
                textBox2.Text = "CONTRASEÑA";
                textBox1.ForeColor = Color.FromArgb(79, 43, 41);

            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Inicio a = new Inicio();
            a.Show();
            this.Hide();
        }
     
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            pictureBox5.Visible = false;
            ojoCerrado.Visible = true;
        }

        private void ojoCerrado_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            pictureBox5.Visible = true;
            ojoCerrado.Visible = false;
        }
    }
}
