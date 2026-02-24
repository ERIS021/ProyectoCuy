using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contra.Text.Trim().ToLower() == contracfm.Text.Trim().ToLower())
            {
                DatosUsuario.Usuari0 = userr.Text.Trim().ToLower();
                DatosUsuario.Contra = contracfm.Text.Trim().ToLower();
                this.Close();
                Login a = new Login();
                a.Show();
            }
            else
            {
                MessageBox.Show("Contraseña no coinciden");
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

        private void button1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            
        }

        private void userr_Leave(object sender, EventArgs e)
        {
            if (userr.Text == "")
            {
                userr.Text = "INGRESAR USUARIO:";
                userr.ForeColor = Color.FromArgb(79, 43, 41);
            }
        }

        private void contra_Enter(object sender, EventArgs e)
        {
            if (contra.Text == "INGRESAR CONTRASEÑA:")
            {
                contra.Text = "";
                contra.ForeColor = Color.FromArgb(79, 43, 41);
                contra.UseSystemPasswordChar = true;
            }
        }

        private void contra_Leave(object sender, EventArgs e)
        {
            if (contra.Text == "")
            {
                contra.Text = "INGRESAR CONTRASEÑA:";
                contra.ForeColor = Color.FromArgb(79, 43, 41);
                contra.UseSystemPasswordChar = false;
            }
        }

        private void contracfm_Enter(object sender, EventArgs e)
        {
            if (contracfm.Text == "CONFIRMAR CONTRASEÑA:")
            {
                contracfm.UseSystemPasswordChar = false; 
                contracfm.Text = "";
                contracfm.ForeColor = Color.FromArgb(79, 43, 41);
                contracfm.UseSystemPasswordChar = true;  
            }
        }



        private void contracfm_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contracfm.Text))
            {
                contracfm.UseSystemPasswordChar = false;
                contracfm.Text = "CONFIRMAR CONTRASEÑA:";
                contracfm.ForeColor = Color.FromArgb(79, 43, 41);
            }
        }



        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void userr_TextChanged(object sender, EventArgs e)
        {

        }

        private void userr_Enter(object sender, EventArgs e)
        {
            if (userr.Text == "INGRESAR USUARIO:")
            {
                userr.Text = "";
                userr.ForeColor = Color.FromArgb(79, 43, 41);
            }
        }

        private void contracfm_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login a = new Login();  
            a.Show();
            this.Hide();
        }
       

        int v = 1;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
                contra.UseSystemPasswordChar = false;
            contracfm.UseSystemPasswordChar = false;
            pictureBox5.Visible = false;
            ojoCerrado.Visible = true;
        }

        private void ojoCerrado_Click(object sender, EventArgs e)
        {
            contra.UseSystemPasswordChar = true;
            contracfm.UseSystemPasswordChar = true;
            pictureBox5.Visible = true;
            ojoCerrado.Visible = false;
        }
    }
}
