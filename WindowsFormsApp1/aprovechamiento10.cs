using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class aprovechamiento10 : Form
    {
        public aprovechamiento10()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Aprovechamiento9 a = new Aprovechamiento9();    
            a.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();    
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

        private void picMone_Click(object sender, EventArgs e)
        {
            Producto_Click(sender, e);
        }

        private void panelIzq_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picCarte_Click(object sender, EventArgs e)
        {
            Producto_Click(sender, e);
        }

        private void Producto_Click(object sender, EventArgs e)
        {
            lblProceso.Visible = true;
            if (sender == picCarte)
            {
                pictureBox4.Image = Properties.Resources.prosCarte;
                lblProceso.Text =
                "Proceso de corte y costura de la cartera:\n\n" +
                "• Selección del material\n" +
                "• Corte de las piezas según el molde\n" +
                "• Unión de piezas principales\n" +
                "• Costura manual\n" +
                "• Revisión y acabados finales";

            }
            else if (sender == picForro)
            {
                pictureBox4.Image = Properties.Resources.prosForro; 
                lblProceso.Text =
                "Proceso de elaboración del forro:\n\n" +
                "Se realiza el corte del material, se ajustan las piezas " +
                "y se cose cuidadosamente para garantizar resistencia y acabado limpio.";
            }
            else if (sender == picLlavero)
            {
                pictureBox4.Image = Properties.Resources.prosLLa;
                lblProceso.Text =
                "Proceso de corte y costura del llavero:\n\n" +
                "El material se corta en pequeñas piezas, se refuerza con costura " +
                "y se coloca el aro metálico.";
            }
            else if (sender == picMone)
            {
                pictureBox4.Image = Properties.Resources.prosMo;
                lblProceso.Text =
                "Proceso del monedero:\n\n" +
                "Incluye corte preciso, costura de bordes y colocación del cierre.";
            }
            else if (sender == picTarje)
            {
                pictureBox4.Image = Properties.Resources.prosTar;
                lblProceso.Text =
                "Proceso del tarjetero:\n\n" +
                "Se cortan las piezas delgadas y se cosen en capas para formar compartimentos.";
            }
            lblProceso.Visible = true;
            panelGrande.Visible = true;
        }

        private void picForro_Click(object sender, EventArgs e)
        {
            Producto_Click(sender, e);
        }

        private void picLlavero_Click(object sender, EventArgs e)
        {
            Producto_Click(sender, e);
        }

        private void picTarje_Click(object sender, EventArgs e)
        {
            Producto_Click(sender, e);
        }
        
        private void aprovechamiento10_Load(object sender, EventArgs e)
        {
            lblProceso.Visible = false;
        }

        private void lblProceso_Click(object sender, EventArgs e)
        {

        }
    }
}
