using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InteGastronomia : Form
    {
        public InteGastronomia()
        {
            InitializeComponent();
        }
        //variable para la condicion de si las opciones son correctas
        int a = 0;

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            InteGasNiveles a = new InteGasNiveles();
            InteGasNiveles.Progreso.nivel1 = false;
            InteGasNiveles.Progreso.nivel2 = false;
            InteGasNiveles.Progreso.nivel3 = false;
            a.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Close();    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
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
        
        private void Nivel()
        {
            if(InteGasNiveles.Progreso.nivel1)
            {
                lblnivel.Text = "Nivel 1";
                lblDificultad.Text = "Basico";
                lblDificultad.ForeColor = Color.Green;
                btt1.Text = "Cuy al Horno";
                btt2.Text = "Cuy frito";
                btt3.Text = "Cuy guisado";
                btt4.Text = "Cuy chactado";
                btt5.Text = "Aplanado y frito en aceite";
                btt6.Text = "Cocido lentamente en aceite caliente";
                btt7.Text = "Sumergido en aceite caliente";
                btt8.Text = "Coccion en horno con aderezo previo";
                lblInteMax.Text = "10";
            }

            if (InteGasNiveles.Progreso.nivel2)
            {
                lblnivel.Text = "Nivel 2";
                lblDificultad.Text = "Intermedio";
                lblDificultad.ForeColor = Color.Yellow;
                btt1.Text = "Ajo";
                btt2.Text = "Aji panca";
                btt3.Text = "Comino";
                btt4.Text = "Sal";
                btt5.Text = "Da color rojo y sabor caracteristico";
                btt6.Text = "Intensifica el sabor del aderezo";
                btt7.Text = "Potencia el gusto general";
                btt8.Text = "Aporta aroma y sabor base";
                lblInteMax.Text = "8";
            }

            if (InteGasNiveles.Progreso.nivel3)
            {
                lblnivel.Text = "Nivel 3";
                lblDificultad.Text = "Avanzado";
                lblDificultad.ForeColor = Color.Red;
                btt1.Text = "Alto en proteina";
                btt2.Text = "Bajo en grasa";
                btt3.Text = "Rico en hierro";
                btt4.Text = "Contiene Omega 3";
                btt5.Text = "Ideal para dietas saludables";
                btt6.Text = "Previene la anemia";
                btt7.Text = "Beneficio cardiovascular";
                btt8.Text = "Ayuda al desarrollo muscular";
                lblInteMax.Text = "6";
            }
        }
        private void InteGastronomia_Load(object sender, EventArgs e)
        {
            //llamamos los metodos de posiciones para guardar las posiciones y luego randomizar
            PosicionesDerecha();
            PosicionesIzquierda();

            //los randomiza
            MezclarIzquieda();
            MezclarDerecha();

            //elije el nivel a mostrar
            Nivel();
        }
        
        //verifica si a hecho los movimientos maximos
        private void MovimientosMaximo()
        {
            if (InteGasNiveles.Progreso.nivel1)
            {
                if (moves > 10)
                {
                    MessageBox.Show("HAS PERDIDO\nINTENTA DE NUEVO");
                    btt1.Enabled = false; btt2.Enabled = false; btt3.Enabled = false; btt4.Enabled = false; btt5.Enabled = false; btt6.Enabled = false; btt7.Enabled = false; btt8.Enabled = false;
                }
            }

            if (InteGasNiveles.Progreso.nivel2)
            {
                if (moves > 8)
                {
                    MessageBox.Show("HAS PERDIDO\nINTENTA DE NUEVO");
                    btt1.Enabled = false; btt2.Enabled = false; btt3.Enabled = false; btt4.Enabled = false; btt5.Enabled = false; btt6.Enabled = false; btt7.Enabled = false; btt8.Enabled = false;
                }
            }

            if (InteGasNiveles.Progreso.nivel3)
            {
                if (moves > 6)
                {
                    MessageBox.Show("HAS PERDIDO\nINTENTA DE NUEVO");
                    btt1.Enabled = false; btt2.Enabled = false; btt3.Enabled = false; btt4.Enabled = false; btt5.Enabled = false; btt6.Enabled = false; btt7.Enabled = false; btt8.Enabled = false;
                }
            }
        }

        //metodo para verificar si a ganado
        private void Ganador()
        {            
            if (btt1.Enabled == false && btt2.Enabled == false && btt3.Enabled == false && btt4.Enabled == false)
            {
                MessageBox.Show("HAS GANADO\nFELICITACIONES!");

                //verifica que nivel a sido sleccionado para marcarlo como completado 
                if (InteGasNiveles.Progreso.nivel1)
                {
                    InteGasNiveles.Progreso.nivel1_completado = true;
                }

                if (InteGasNiveles.Progreso.nivel2)
                {
                    InteGasNiveles.Progreso.nivel2_completado = true;
                }

                if (InteGasNiveles.Progreso.nivel3)
                {
                    InteGasNiveles.Progreso.nivel3_completado = true;
                }
            }
            else
            {
                MovimientosMaximo();
            }
        }

        //variables para verificar que haya seleccionado cada columna para contar el movimiento
        bool columnA = false;
        bool columnB = false;

        // Variable para saber si es el mismo boton clickeado
        Button ultimoBotonClickeado = null;


        //verifica que no sea el mismo boton clicleado para contar moves
        private bool OpSeleccionada(object sender, EventArgs e)
        {
            Button botonActual = sender as Button;

            //verifica que sea distinto del último clickeado 
            if (botonActual != ultimoBotonClickeado)
            {                
                //actualiza el último botón clickeado
                ultimoBotonClickeado = botonActual;
                return true;
            }
            return false;
        }
        private void btt1_Click(object sender, EventArgs e)
        {
            columnA = true;
            //obtiene la posicion +76 en X
            puntoInicio1 = new Point(btt1.Location.X + 141, btt1.Location.Y + 35);
            if (OpSeleccionada(sender, e))
            {
                Comprobarbtt1();
            }
            DibujarLinea();            
        }

        private void btt2_Click(object sender, EventArgs e)
        {
            columnA = true;
            puntoInicio2 = new Point(btt2.Location.X + 141, btt2.Location.Y + 35);
            if (OpSeleccionada(sender, e))
            {
                Comprobarbtt2();
            }
            DibujarLinea();            
        }

        private void btt3_Click(object sender, EventArgs e)
        {
            columnA = true;
            puntoInicio3 = new Point(btt3.Location.X + 141, btt3.Location.Y + 35);
            if (OpSeleccionada(sender, e))
            {
                Comprobarbtt3();
            }
            DibujarLinea();
        }

        private void btt4_Click(object sender, EventArgs e)
        {
            columnA = true;
            puntoInicio4 = new Point(btt4.Location.X + 141, btt4.Location.Y + 35);
            if (OpSeleccionada(sender, e))
            {
                Comprobarbtt4();
            }
            DibujarLinea();
        }

        private void btt5_Click(object sender, EventArgs e)
        {
            columnB = true;
            puntoFin2 = new Point(btt5.Location.X, btt5.Location.Y + 35);
            if (OpSeleccionada(sender, e))
            {
                Comprobarbtt2();
            }
            DibujarLinea();
        }

        private void btt6_Click(object sender, EventArgs e)
        {
            columnB = true;
            puntoFin3 = new Point(btt6.Location.X, btt6.Location.Y + 35);
            if (OpSeleccionada(sender, e))
            {
                Comprobarbtt3();
            }
            DibujarLinea();
        }

        private void btt7_Click(object sender, EventArgs e)
        {
            columnB = true;
            puntoFin4 = new Point(btt7.Location.X, btt7.Location.Y + 35);
            if (OpSeleccionada(sender, e))
            {
                Comprobarbtt4();
            }
            DibujarLinea();
        }

        private void btt8_Click(object sender, EventArgs e)
        {
            columnB = true;
            puntoFin1 = new Point(btt8.Location.X, btt8.Location.Y + 35);
            if (OpSeleccionada(sender, e))
            {
                Comprobarbtt1();
            }
            DibujarLinea();
        }

        //boton volver a jugar
        private void bttjugar_Click(object sender, EventArgs e)
        {
            //habilita los button
            btt1.Enabled = true;
            btt2.Enabled = true;
            btt3.Enabled = true;
            btt4.Enabled = true;
            btt5.Enabled = true;
            btt6.Enabled = true;
            btt7.Enabled = true;
            btt8.Enabled = true;

            //los randomiza
            MezclarIzquieda();
            MezclarDerecha();

            //vuelve a su color original
            PropiedadesBttDefecto();

            //borra las lineas
            dibujarLinea1 = false;
            dibujarLinea2 = false;
            dibujarLinea3 = false;
            dibujarLinea4 = false;
            Invalidate();

            //asigna los bttDibujar en false para que no se dibujen lineas inesperadas
            btt1Dibujar = false;
            btt2Dibujar = false;
            btt3Dibujar = false;
            btt4Dibujar = false;
            btt5Dibujar = false;
            btt6Dibujar = false;
            btt7Dibujar = false;
            btt8Dibujar = false;

            //reinicia el contador de movimientos
            moves = 1;

            //reincia la seleccion de boton
            a = 0;
        }

        //lista para guardar las posiciones izquierdas
        List<Point> posicionizquierda;

        //metodo para guardar las posiciones de los botones (izquierda)
        private void PosicionesIzquierda()
        {
            posicionizquierda = new List<Point>
            {
                btt1.Location,
                btt2.Location,
                btt3.Location,
                btt4.Location
            };
        }
        //se crea una variable con la clase predefinida "Random"
        Random random = new Random();

        //metodo para randomizar las posiciones
        private void MezclarIzquieda()
        {
            //cambia las posiciones y las guarda en otra variable
            List<Point> mezclar = posicionizquierda.OrderBy(x => random.Next()).ToList();

            btt1.Location = mezclar[0];
            btt2.Location = mezclar[1];
            btt3.Location = mezclar[2];
            btt4.Location = mezclar[3];
        }

        //lista para guardar las posiciones derecha
        List<Point> posicionderecha;

        //metodo para guardar las localizaciones de los botones (derecha)
        private void PosicionesDerecha()
        {
            //se guardan las localizaciones en una Lista de Point
            posicionderecha = new List<Point>
            {
                btt5.Location,
                btt6.Location,
                btt7.Location,
                btt8.Location
            };
        }
        private void MezclarDerecha()
        {
            //cambia las posiciones y las guarda en otra variable
            List<Point> mezclar = posicionderecha.OrderBy(x => random.Next()).ToList();

            btt5.Location = mezclar[0];
            btt6.Location = mezclar[1];
            btt7.Location = mezclar[2];
            btt8.Location = mezclar[3];
        }

        int moves = 1;
        private void ContMovimientos()
        {
            if(columnA && columnB)
            {                
                lblMoves.Text = $"{moves++}";
                columnA = false;
                columnB = false;
            }
            if (InteGasNiveles.Progreso.nivel1)
            {
                if (moves <= 5)
                {
                    lblMoves.ForeColor = Color.Green;
                }
                else if (moves <= 8)
                {
                    lblMoves.ForeColor = Color.Goldenrod;
                }
                else
                {
                    lblMoves.ForeColor = Color.Red;
                }
            }
            if (InteGasNiveles.Progreso.nivel2)
            {
                if (moves <= 4)
                {
                    lblMoves.ForeColor = Color.Green;
                }
                else if (moves <= 6)
                {
                    lblMoves.ForeColor = Color.Goldenrod;
                }
                else
                {
                    lblMoves.ForeColor = Color.Red;
                }
            }
            if (InteGasNiveles.Progreso.nivel3)
            {
                if (moves <= 4)
                {
                    lblMoves.ForeColor = Color.Green;
                }
                else if (moves <= 5)
                {
                    lblMoves.ForeColor = Color.Goldenrod;
                }
                else
                {
                    lblMoves.ForeColor = Color.Red;
                }
            }
        }

        private void Comprobarbtt1()
        {
            if (a == 1)
            {
                MessageBox.Show("CORRECTO");
                btt1.Enabled = false;
                btt8.Enabled = false;
                a = 0;
                btt1.FlatAppearance.BorderSize = 0;
                btt1.BackColor = Color.LightGreen;
                btt1Dibujar = true;
                btt8Dibujar = true;
                ContMovimientos();
            }
            else
            {
                if (a == 0)
                {
                    a = 1;
                }
                else
                {                 
                    MessageBox.Show("INCORRECTO, INTENTE OTRA VEZ");
                    a = 0;
                    ContMovimientos();
                    columnA = false;
                    columnB = false;
                }
            }
            Ganador();
        }
        private void Comprobarbtt2()
        {
            if (a == 2)
            {
                MessageBox.Show("CORRECTO");
                btt5.Enabled = false;
                btt2.Enabled = false;
                a = 0;
                btt2.FlatAppearance.BorderSize = 0;
                btt2.BackColor = Color.LightGreen;
                btt2Dibujar = true;
                btt5Dibujar = true;
                ContMovimientos();
            }
            else
            {
                if (a == 0)
                {
                    a = 2;
                }
                else
                {                   
                    MessageBox.Show("INCORRECTO, INTENTE OTRA VEZ");
                    a = 0;
                    ContMovimientos();
                    columnA = false;
                    columnB = false;
                }
            }
            Ganador();
        }
        private void Comprobarbtt3()
        {
            if (a == 3)
            {
                MessageBox.Show("CORRECTO");
                btt6.Enabled = false;
                btt3.Enabled = false;
                a = 0;
                btt3.FlatAppearance.BorderSize = 0;
                btt3.BackColor = Color.LightGreen;
                btt3Dibujar = true;
                btt6Dibujar = true;
                ContMovimientos();
            }
            else
            {
                if (a == 0)
                {
                    a = 3;
                }
                else
                {
                    MessageBox.Show("INCORRECTO, INTENTE OTRA VEZ");
                    a = 0;
                    ContMovimientos();
                    columnA = false;
                    columnB = false;
                }
            }
            Ganador();
        }
        private void Comprobarbtt4()
        {
            if (a == 4)
            {
                MessageBox.Show("CORRECTO");
                btt4.Enabled = false;
                btt7.Enabled = false;
                a = 0;                
                btt4.FlatAppearance.BorderSize = 0;
                btt4.BackColor = Color.LightGreen;
                btt4Dibujar = true;
                btt7Dibujar = true;
                ContMovimientos();
            }
            else
            {
                if (a == 0)
                {
                    a = 4;
                }
                else
                {
                    MessageBox.Show("INCORRECTO, INTENTE OTRA VEZ");
                    a = 0;
                    ContMovimientos();
                    columnA = false;
                    columnB = false;
                }
            }
            Ganador();
        }

        //variables para dibujar las lineas
        bool dibujarLinea1 = false;
        bool dibujarLinea2 = false;
        bool dibujarLinea3 = false;
        bool dibujarLinea4 = false;

        //variables para guardar los puntos para dibujar la linea
        Point puntoInicio1;
        Point puntoFin1;
        Point puntoInicio2;
        Point puntoFin2;
        Point puntoInicio3;
        Point puntoFin3;
        Point puntoInicio4;
        Point puntoFin4;

        //variables para llamar a dibujar las lineas
        bool btt1Dibujar = false;
        bool btt2Dibujar = false;
        bool btt3Dibujar = false;
        bool btt4Dibujar = false;
        bool btt5Dibujar = false;
        bool btt6Dibujar = false;
        bool btt7Dibujar = false;
        bool btt8Dibujar = false;

        //metodo de Paint del Form para dibujar las lineas 
        private void InteGastronomia_Paint(object sender, PaintEventArgs e)
        {
            if (dibujarLinea1)
            {
                using (Pen lapiz = new Pen(Color.Black, 4))
                {
                    e.Graphics.DrawLine(lapiz, puntoInicio1, puntoFin1);
                }
            }
            if (dibujarLinea2)
            {
                using (Pen lapiz = new Pen(Color.Black, 4))
                {
                    e.Graphics.DrawLine(lapiz, puntoInicio2, puntoFin2);
                }
            }
            if (dibujarLinea3)
            {
                using (Pen lapiz = new Pen(Color.Black, 4))
                {
                    e.Graphics.DrawLine(lapiz, puntoInicio3, puntoFin3);
                }
            }
            if (dibujarLinea4)
            {
                using (Pen lapiz = new Pen(Color.Black, 4))
                {
                    e.Graphics.DrawLine(lapiz, puntoInicio4, puntoFin4);
                }
            }
        }

        //metodo para comprobar si las opciones son correctas y dibujar la linea
        private void DibujarLinea()
        {
            if (btt1Dibujar && btt8Dibujar)
            {
                dibujarLinea1 = true;   //activa el dibujo de linea
                Invalidate();   //refrezca el form para que aparezca la linea
            }
            if (btt2Dibujar && btt5Dibujar)
            {
                dibujarLinea2 = true;
                Invalidate();
            }
            if (btt3Dibujar && btt6Dibujar)
            {
                dibujarLinea3 = true;
                Invalidate();
            }
            if (btt4Dibujar && btt7Dibujar)
            {
                dibujarLinea4 = true;
                Invalidate();
            }
        }

        private void PropiedadesBttDefecto()
        {
            btt1.BackColor = Color.FromArgb(208, 118, 55);
            btt1.FlatAppearance.BorderSize = 1;
            btt1.FlatAppearance.BorderColor = Color.Black;
            btt2.BackColor = Color.FromArgb(227, 157, 98);
            btt2.FlatAppearance.BorderSize = 1;
            btt2.FlatAppearance.BorderColor = Color.Black;
            btt3.BackColor = Color.FromArgb(208, 118, 55);
            btt3.FlatAppearance.BorderSize = 1;
            btt3.FlatAppearance.BorderColor = Color.Black;
            btt4.BackColor = Color.FromArgb(227, 157, 98);
            btt4.FlatAppearance.BorderSize = 1;
            btt4.FlatAppearance.BorderColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
