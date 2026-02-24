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
    public partial class ReceGuisadas : Form
    {
        public ReceGuisadas()
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
        private void btt2_Click(object sender, EventArgs e)
        {
            timerop.Start();
            lblNombreReceta.Text = "Cuy estofado con verduras";
            txtReceta1.Text = "Ingredientes\r\n\r\n- 1 cuy en presas\r\n- 2 cdas de aceite\r\n- 1 cebolla picada\r\n- 2 dientes de ajo\r\n- 1 tomate picado\r\n- 1 zanahoria en rodajas\r\n- ½ taza de arvejas\r\n- 1 cda de ají amarillo molido\r\n- Sal, pimienta y comino\r\n- Caldo (cantidad necesaria)\r\n- Hierbabuena o culantro\r\n\r\nPreparación\r\n\r\n1. Dora el cuy en una olla con aceite y retira.\r\n2. Sofríe cebolla, ajo y tomate.\r\n3. Agrega ají amarillo, sal, pimienta y comino.\r\n4. Incorpora el cuy y cubre con caldo.\r\n5. Cocina a fuego bajo 30 minutos.\r\n6. Añade verduras y cocina hasta que estén tiernas.\r\n7. Espolvorea hierbas al final.";            
            lblGustativo.Text = "Sabor:\r\n- Salado\r\n- Aromático\r\n- Equilibrado\r\n- Un poco dulce\r\n\r\nTextura:\r\n- Muy tierno\r\n- Jugoso\r\n- Verduras suaves";
            OcultarImagenes();
            picBoxReceta2.Visible = true;
        }

        private void btt3_Click(object sender, EventArgs e)
        {
            timerop.Start();
            lblNombreReceta.Text = "Cuy en salsa de maní";
            txtReceta1.Text = "Ingredientes\r\n\r\n- 1 cuy cortado en presas\r\n- 3 cdas de aceite\r\n- 1 cebolla picada\r\n- 2 dientes de ajo\r\n- 2 cdas de ají amarillo\r\n- ½ taza de maní tostado y molido\r\n- Sal, pimienta y comino\r\n- Caldo o agua\r\n- Culantro picado\r\n\r\nPreparación\r\n\r\n1. Fríe ligeramente las presas de cuy y reserva.\r\n2. En la olla, sofríe cebolla y ajo.\r\n3. Agrega ají amarillo y el maní molido.\r\n4. Añade caldo poco a poco hasta lograr una salsa espesa.\r\n5. Incorpora el cuy y cocina a fuego bajo 20–25 minutos.\r\n6. Rectifica sal y termina con culantro.";           
            lblGustativo.Text = "Sabor:\r\n- Salado\r\n- Cremoso\r\n- Intenso\r\n- Ligeramente dulce\r\n\r\nTextura:\r\n- Muy jugoso\r\n- Carne blanda\r\n- Salsa espesa y envolvente";
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
            lblNombreReceta.Text = "Cuy guisado con papas";
            txtReceta1.Text = "Ingredientes\r\n\r\n- 1 cuy limpio y cortado en presas\r\n- 3 cdas de aceite\r\n- 1 cebolla picada\r\n- 3 dientes de ajo molidos\r\n- 1 cda de ají panca\r\n- 1 cda de comino\r\n- Sal y pimienta al gusto\r\n- ½ taza de chicha de jora o caldo\r\n- 4 papas peladas y cortadas\r\n- Culantro picado\r\n\r\nPreparación\r\n\r\n1. Sazona el cuy con sal, pimienta y comino.\r\n2. En una olla, dora ligeramente el cuy en aceite. Retira y reserva.\r\n3. En la misma olla sofríe cebolla, ajo y ají panca.\r\n4. Regresa el cuy, agrega chicha o caldo y deja hervir.\r\n5. Cocina a fuego medio 20 minutos.\r\n6. Añade las papas y cocina hasta que estén suaves.\r\n7. Termina con culantro picado y sirve caliente.";           
            lblGustativo.Text = "Sabor:\r\n- Salado\r\n- Suave\r\n- Ligeramente especiado\r\n- Tradicional\r\n\r\nTextura:\r\n- Jugoso\r\n- Carne tierna\r\n- Papas suaves";
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

        private void panelOpiniones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
