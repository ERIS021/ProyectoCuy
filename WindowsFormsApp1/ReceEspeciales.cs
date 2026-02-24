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
    public partial class ReceEspeciales : Form
    {
        public ReceEspeciales()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            RecetasApartado a = new RecetasApartado();  
            a.Show();
            this.Hide();
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

        private void ReceGastronomia_Load(object sender, EventArgs e)
        {
            //mueve la location de los button
            btt1.Location = new Point(53, 230);
            btt2.Location = new Point(266, 230);
            btt3.Location = new Point(475, 230);

            //asignamos la posicion del button a una variable 
            int posicioninicial = btt1.Top;
        }

        private void timerop_Tick(object sender, EventArgs e)
        {
            //asigna la velocidad de la "animacion"
            timerop.Interval = 5;
            //asigna posicion final y la velocidad de movimiento
            int posicionFinalY = 92;
            int velocidad = 6;

            //si la posicion actual es igual a posicionFinal, entonces para de moverse
            if (btt1.Top == posicionFinalY)
            {
                panelRecetas.Visible = true;
                panelOpiniones.Visible = true;
                panelGustativo.Visible = true;                
                panelImagenes.Visible = true;
                panelEmojis.Enabled = true;
                timerop.Stop();
                //para que lo detenga al instante cuando la condicion es verdadera (evita errores)
                return;
            }

            //se mueve restando la posicion hasta llegar a posicionFinalY
            btt1.Top -= velocidad;
            btt2.Top -= velocidad;
            btt3.Top -= velocidad;
        }

        private void OcultarImagenes()
        {
            picBoxReceta.Visible = false;
            picBoxReceta2.Visible = false;
            picBoxReceta3.Visible = false;
        }

        private void btt3_Click(object sender, EventArgs e)
        {
            timerop.Start();
            lblNombreReceta.Text = "Cuy con acompañamientos especiales (mote, arroz y ensalada)";
            txtReceta1.Text = "Ingredientes\r\n\r\n- 1 cuy frito u horneado (puede ser cualquiera de las recetas anteriores)\r\n\r\nAcompañamientos\r\n\r\n- 1 taza de mote cocido\r\n- 1 taza de arroz blanco graneado\r\n- Papas doradas o sancochadas (opcional)\r\n- Ensalada\r\n- Lechuga\r\n- Tomate\r\n- Cebolla\r\n- Limón\r\n- Sal y aceite\r\n\r\nPreparación\r\n\r\n1. Prepara el cuy (frito u horneado, bien dorado).\r\n2. Cocina el mote hasta que esté suave y caliente.\r\n3. Prepara el arroz blanco de manera tradicional.\r\n4. Mezcla los ingredientes de la ensalada y aliña al gusto.\r\n5. Sirve el cuy al centro, rodeado de mote, arroz y ensalada fresca.";           
            lblGustativo.Text = "Sabor:\r\n- Salado\r\n- Equilibrado\r\n- Variado \r\n\r\nTextura:\r\n- Crocante en el cuy\r\n- Suave en mote y arroz\r\n- Fresca en la ensalada";
            OcultarImagenes();
            picBoxReceta3.Visible = true;
        }
        private void bttEnviarOpinion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Gracias por tu opinión!");
            txtOpinion.Text = "";
            txtOpinion.Visible = false;
            bttEnviarOpinion.Visible = false;
            bttDejarOpinion.Visible = true;
            panelGustativo.Visible = true;
        }

        private void btt1_Click(object sender, EventArgs e)
        {
            timerop.Start();
            lblNombreReceta.Text = "Cuy festivo (estilo tradicional de fiesta)";
            txtReceta1.Text = "Ingredientes\r\n\r\n- 1 cuy entero limpio\r\n- 4 dientes de ajo molidos\r\n- 1 cda de comino\r\n- 1 cda de ají panca\r\n- Sal y pimienta\r\n- ½ taza de chicha de jora o cerveza\r\n- 2 cdas de manteca o aceite\r\n- Hierbas aromáticas (huacatay o culantro)\r\n\r\nPreparación\r\n\r\n1. Lava y seca bien el cuy.\r\n2. Mezcla ajo, comino, ají panca, sal, pimienta y chicha.\r\n3. Adoba el cuy por dentro y por fuera.\r\n4. Deja marinar mínimo 4 horas (ideal toda la noche).\r\n5. Hornéalo o ásalo a fuego medio 50–60 minutos, volteándolo.\r\n6. Al final, pincela con manteca para que quede bien dorado.\r\n7. Sirve entero, bien crocante, como plato central de fiesta.";           
            lblGustativo.Text = "Sabor:\r\n- Salado\r\n- Intenso\r\n- Especiado\r\n- Tradicional\r\n\r\nTextura:\r\n- Crocante por fuera\r\n- Jugoso por dentro\r\n- Carne firme";
            OcultarImagenes();
            picBoxReceta.Visible = true;
        }

        private void bttDejarOpinion_Click(object sender, EventArgs e)
        {
            txtOpinion.Visible = true;
            bttEnviarOpinion.Visible = true;
            bttDejarOpinion.Visible = false;
            panelGustativo.Visible = false;
        }

        private void panelRecetas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emojiChanged(object sender, EventArgs e)
        {
            MessageBox.Show("¡GRACIAS POR TU SINCERIDAD!\nDeseas dejar tu opinion sobre la receta? Esto nos ayudara a mejorar");
            panelEmojis.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btt2_Click_1(object sender, EventArgs e)
        {
            timerop.Start();
            lblNombreReceta.Text = "Cuy al ají(picante y sabroso)";
            txtReceta1.Text = "Ingredientes\r\n\r\n- 1 cuy cortado en presas\r\n- 3 cdas de aceite\r\n- 1 cebolla picada\r\n- 3 dientes de ajo\r\n- 2 cdas de ají amarillo molido\r\n- 1 cda de ají panca\r\n- Sal, pimienta y comino\r\n- ½ taza de caldo\r\n- Culantro picado\r\n\r\nPreparación\r\n\r\n1. Sazona y dora ligeramente el cuy en aceite. Reserva.\r\n2. En la misma olla, sofríe cebolla y ajo.\r\n3. Agrega ají amarillo y ají panca.\r\n4. Incorpora el cuy y el caldo.\r\n5. Cocina a fuego medio 25–30 minutos, hasta que la salsa espese.\r\n6. Rectifica sal y termina con culantro.";
            lblGustativo.Text = "Sabor:\r\n- Salado\r\n- Picante\r\n- Intenso\r\n- Aromático\r\n\r\nTextura:\r\n- Jugoso\r\n- Carne tierna\r\n- Salsa espesa";
            OcultarImagenes();
            picBoxReceta2.Visible = true;
        }

        private void panelOpiniones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBoxReceta2_Click(object sender, EventArgs e)
        {

        }

        private void picBoxReceta3_Click(object sender, EventArgs e)
        {

        }

        private void panelImagenes_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
