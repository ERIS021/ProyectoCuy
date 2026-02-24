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
    public partial class ReceFritas : Form
    {
        public ReceFritas()
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
            lblNombreReceta.Text = "Cuy apanado";
            txtReceta1.Text = "Ingredientes\r\n\r\n- 1 cuy limpio y cortado\r\n- Sal, pimienta y comino\r\n- 2 dientes de ajo molidos\r\n- 2 huevos\r\n- Pan molido (o panko para más crocancia)\r\n- Harina\r\n- Aceite para freír\r\n\r\nPreparación\r\n\r\n1. Sazona el cuy con ajo, sal, pimienta y comino.\r\n2. Pasa cada pieza por:\r\n3. Harina\r\n4. Huevo batido\r\n5. Pan molido\r\n6. Presiona bien el apanado.\r\n7. Calienta el aceite a temperatura media.\r\n8. Fríe hasta que esté dorado y crujiente.\r\n9. Retira y deja reposar sobre papel absorbente.";            
            lblGustativo.Text = "Sabor:\r\n- Salado\r\n- Suave\r\n- Neutro \r\n\r\nTextura:\r\n- Muy crocante\r\n- Interior tierno";
            OcultarImagenes();
            picBoxReceta2.Visible = true;
        }

        private void btt3_Click(object sender, EventArgs e)
        {
            timerop.Start();
            lblNombreReceta.Text = "Cuy estilo crujiente (extra crocante)";
            txtReceta1.Text = "Ingredientes\r\n\r\n- 1 cuy limpio (entero o en presas)\r\n- Sal y pimienta\r\n- 1 cda de ajo en polvo o fresco\r\n- 1 cda de maicena\r\n- 1 taza de harina\r\n- Aceite abundante\r\n\r\nPreparación\r\n\r\n1. Seca muy bien el cuy (esto es clave).\r\n2. Mezcla harina, maicena, sal, pimienta y ajo.\r\n3. Reboza el cuy completamente.\r\n4. Deja reposar 10 minutos antes de freír.\r\n5. Fríe en aceite bien caliente.\r\n6. Baja un poco el fuego y cocina hasta que esté bien dorado y súper crujiente.";           
            lblGustativo.Text = "Sabor:\r\n- Salado\r\n- Intenso\r\n- Tostado\r\n\r\nTextura:\r\n- Súper crocante\r\n- Seco por fuera\r\n- Carne firme por dentro";
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
            lblNombreReceta.Text = "Cuy frito tradicional";
            txtReceta1.Text = "Ingredientes\r\n\r\n- 1 cuy entero, limpio y cortado en presas\r\n- 4 dientes de ajo molidos\r\n- 1 cda de comino\r\n- Sal y pimienta al gusto\r\n- ½ taza de chicha de jora o cerveza\r\n- Harina (cantidad necesaria)\r\n- Aceite abundante para freír\r\n\r\nPreparación\r\n\r\n1. Lava y seca bien las presas de cuy.\r\n2. Adoba con ajo, comino, sal, pimienta y chicha.\r\n3. Deja marinar 1–2 horas.\r\n4. Pasa ligeramente las presas por harina.\r\n5. Calienta aceite a fuego medio-alto.\r\n6. Fríe el cuy hasta que esté bien dorado y crocante (15–20 min).\r\n7. Escurre en papel absorbente y sirve caliente.";           
            lblGustativo.Text = "Sabor:\r\n- Salado\r\n- Especiado \r\n- Ligeramente fermentado\r\n\r\nTextura:\r\n- Crocante por fuera\r\n- Jugoso por dentro";
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
