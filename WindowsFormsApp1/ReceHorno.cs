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
    public partial class ReceHorno : Form
    {
        public ReceHorno()
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
            lblNombreReceta.Text = "Cuy asado a la parrilla";
            txtReceta1.Text = "Ingredientes\r\n\r\n- 1 cuy entero limpio\r\n- 3 dientes de ajo molidos\r\n- 1 cda de comino\r\n- Sal y pimienta\r\n- 2 cdas de aceite\r\n- Jugo de 1 limón\r\n- Ají molido (opcional)\r\n\r\nPreparación\r\n\r\n1. Mezcla ajo, comino, sal, pimienta, aceite y limón.\r\n2. Adoba bien el cuy y déjalo reposar 1–2 horas.\r\n3. Ensarta el cuy o colócalo en una parrilla doble.\r\n4. Asa a fuego medio, girándolo constantemente.\r\n5. Cocínalo por 35–45 minutos, hasta que la piel esté bien dorada y crujiente.\r\n6. Sirve con papas sancochadas y ají.\r\n";            
            lblGustativo.Text = "Sabor:\r\n- Salado\r\n- Ácido (limón)\r\n- Ahumado\r\n- Picante ligero \r\n\r\nTextura:\r\n- Muy crocante\r\n- Puede quedar un poco seco si se pasa de cocción";
            OcultarImagenes();
            picBoxReceta2.Visible = true;
        }

        private void btt3_Click(object sender, EventArgs e)
        {
            timerop.Start();
            lblNombreReceta.Text = "Cuy con hierbas andinas";
            txtReceta1.Text = "Ingredientes\r\n\r\n- 1 cuy entero limpio\r\n- 3 dientes de ajo\r\n- 1 cda de comino\r\n- Sal y pimienta\r\n- Hierbas andinas picadas:\r\n- Huacatay\r\n- Chincho\r\n- Paico (opcional)\r\n- ½ taza de chicha de jora o vino blanco\r\n- 2 cdas de aceite\r\n\r\nPreparación\r\n\r\n1. Licúa o pica finamente las hierbas con ajo, comino, sal, pimienta y chicha.\r\n2. Unta el cuy con esta mezcla.\r\n3. Marina mínimo 3 horas.\r\n4. Cocínalo al horno a 180 °C o a la parrilla.\r\n5. Hornea por 50–60 minutos o asa hasta que esté bien dorado.\r\n6. El aroma de las hierbas es clave: queda súper sabroso.";           
            lblGustativo.Text = "Sabor:\r\n- Salado\r\n- Herbal / aromático\r\n- Suave, fresco\r\n- Menos picante\r\nTextura:\r\n- Jugoso\r\n- Tiernito\r\n- Menos crocante";
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
            lblNombreReceta.Text = "Cuy al horno tradicional";
            txtReceta1.Text = "Ingredientes\r\n\r\n- 1 cuy entero, limpio y abierto\r\n- 4–5 dientes de ajo molidos\r\n- 1 cda de comino\r\n- 1 cda de ají panca molido\r\n- Sal al gusto\r\n- Pimienta al gusto\r\n- ½ taza de cerveza o chicha de jora\r\n- 2 cdas de aceite o manteca\r\n- Papas y ensalada (para acompañar)\r\n\r\nPreparación\r\n\r\n1. Lava bien el cuy y sécalo.\r\n2. En un bol mezcla ajo, comino, ají panca, sal, pimienta y cerveza.\r\n3. Unta el cuy por dentro y por fuera con este aderezo.\r\n4. Déjalo marinar mínimo 2 horas (mejor si es toda la noche).\r\n5. Colócalo en una fuente engrasada.\r\n6. Hornea a 180 °C por 50–60 minutos, dándole vuelta a la mitad del tiempo.\r\n7. Debe quedar dorado y crocante.\r\n";
            lblGustativo.Text = "Sabor:\r\nSalado\r\nEspeciado (ajo, comino, ají panca)}\r\nLigeramente ácido y fermentado (por la cerveza o chicha)\r\n\r\nTextura:\r\nJugoso por dentro\r\nCrocante por fuera";
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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
