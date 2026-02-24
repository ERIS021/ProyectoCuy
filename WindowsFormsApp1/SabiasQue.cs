using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace cuy
{
    public partial class SabiasQue : Form
    {
        public SabiasQue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecetasApartado gastronomia = new RecetasApartado();
            this.Close();
            gastronomia.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //variable para randomizar
        Random datoRandom = new Random();

        //lista para randomizar los datos
        List<int> datosCurioso = new List<int> { 1, 2, 3, 4, 5 };

        //variables para llamar a preguntar
        bool preguntarDato1 = false;
        bool preguntarDato2 = false;
        bool preguntarDato3 = false;
        bool preguntarDato4 = false;
        bool preguntarDato5 = false;

        //borra la respuesta del dato
        private void DatoCuriosoNOCompleto()
        {
            string textoDato1 = dtcurioso1.Text;
            textoDato1 = textoDato1.Replace("colesterol", "...");
            dtcurioso1.Text = textoDato1;

            string textoDato2 = dtcurioso2.Text;
            textoDato2 = textoDato2.Replace("proteínas", "...");
            dtcurioso2.Text = textoDato2;

            string textoDato3 = dtcurioso3.Text;
            textoDato3 = textoDato3.Replace("colágeno", "...");
            dtcurioso3.Text = textoDato3;

            string textoDato4 = dtcurioso4.Text;
            textoDato4 = textoDato4.Replace("complejo B", "...");
            dtcurioso4.Text = textoDato4;

            string textoDato5 = dtcurioso5.Text;
            textoDato5 = textoDato5.Replace("cardiovasculares", "...");
            dtcurioso5.Text = textoDato5;
        }

        //muestra nuevamente el dato completo
        private void MostrarDatoCuriosoCompleto()
        {
            string textoDato1 = dtcurioso1.Text;
            textoDato1 = textoDato1.Replace("...", "colesterol");
            dtcurioso1.Text = textoDato1;

            string textoDato2 = dtcurioso2.Text;
            textoDato2 = textoDato2.Replace("...", "proteínas");
            dtcurioso2.Text = textoDato2;

            string textoDato3 = dtcurioso3.Text;
            textoDato3 = textoDato3.Replace("...", "colágeno");
            dtcurioso3.Text = textoDato3;

            string textoDato4 = dtcurioso4.Text;
            textoDato4 = textoDato4.Replace("...", "complejo B");
            dtcurioso4.Text = textoDato4;

            string textoDato5 = dtcurioso5.Text;
            textoDato5 = textoDato5.Replace("...", "cardiovasculares");
            dtcurioso5.Text = textoDato5;
        }

        //metodo para ocultar los label de los datos
        private void OcultarDatos()
        {
            dtcurioso1.Visible = false;
            dtcurioso2.Visible = false;
            dtcurioso3.Visible = false;
            dtcurioso4.Visible = false;
            dtcurioso5.Visible = false;
            sabiasQuePregunta.Visible = false;

            //reincia a false todos para que dejen de ser true
            preguntarDato1 = false;
            preguntarDato2 = false;
            preguntarDato3 = false;
            preguntarDato4 = false;
            preguntarDato5 = false;
        }

        //metodo para ocultar los textos de respuestas
        private void OcultarRespuestas()
        {
            respuestaDato1.Visible = false;     respuestaDato1.Text = "";
            respuestaDato2.Visible = false;     respuestaDato2.Text = "";
            respuestaDato3.Visible = false;     respuestaDato3.Text = "";
            respuestaDato4.Visible = false;     respuestaDato4.Text = "";
            respuestaDato5.Visible = false;     respuestaDato5.Text = "";
        }

        private void SabiasQue_Load(object sender, EventArgs e)
        {
            OcultarDatos();
            OcultarRespuestas();

            panelInstrucciones.Location = new Point(0, 0);
            comprobar.Visible = false;
        }

        private void dtcurioso5_Click(object sender, EventArgs e)
        {

        }

        private void comprobarRespuesta()
        {
            string dato1 = respuestaDato1.Text.ToLower().Trim();
            string dato2 = respuestaDato2.Text.ToLower().Trim();
            string dato3 = respuestaDato3.Text.ToLower().Trim();
            string dato4 = respuestaDato4.Text.ToLower().Trim();
            string dato5 = respuestaDato5.Text.ToLower().Trim();

            if (preguntarDato1)
            {
                if (dato1 == "colesterol")
                {
                    MessageBox.Show("CORRECTO");
                }
                else
                {
                    MessageBox.Show("INCORRECTO\n-Colesterol-");
                }
            }

            if (preguntarDato2)
            {
                if (dato2 == "proteinas")
                {
                    MessageBox.Show("CORRECTO");
                }
                else
                {
                    MessageBox.Show("INCORRECTO\n-Proteinas-");
                }
            }

            if (preguntarDato3)
            {
                if (dato3 == "colageno")
                {
                    MessageBox.Show("CORRECTO");
                }
                else
                {
                    MessageBox.Show("INCORRECTO\n-Colageno-");
                }
            }

            if (preguntarDato4)
            {
                if (dato4 == "complejo b")
                {
                    MessageBox.Show("CORRECTO");
                }
                else
                {
                    MessageBox.Show("INCORRECTO\n-Complejo B-");
                }

            }

            if (preguntarDato5)
            {
                if (dato5 == "cardiovasculares")
                {
                    MessageBox.Show("CORRECTO");
                }
                else
                {
                    MessageBox.Show("INCORRECTO\n-Cardiovasculares-");
                }
            }
        }
        private void comprobarRespuesta_Click(object sender, EventArgs e)
        {
            comprobarRespuesta();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            RecetasApartado volver = new RecetasApartado();
            this.Close();
            volver.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            DatoCuriosoNOCompleto();
            comprobar.Visible = true;

            //oculta el boton de preguntos y muestra el de Datos
            sabiasqueRandom.Visible = true;
            sabiasQuePregunta.Visible = false;

            if (preguntarDato1)
            {
                respuestaDato1.Visible = true;
            }

            if (preguntarDato2)
            {
                respuestaDato2.Visible = true;
            }

            if (preguntarDato3)
            {
                respuestaDato3.Visible = true;
            }

            if (preguntarDato4)
            {
                respuestaDato4.Visible = true;
            }

            if (preguntarDato5)
            {
                respuestaDato5.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //llama para ocultar los datos y los Text de las respuestas
            OcultarDatos();
            OcultarRespuestas();
            MostrarDatoCuriosoCompleto();
            comprobar.Visible = false;

            //elige un indice aleatorio de la lista datosCurioso
            int dato = datoRandom.Next(datosCurioso.Count);

            if (dato == 0)
            {
                dtcurioso1.Visible = true;
                preguntarDato1 = true;
            }
            if (dato == 1)
            {
                dtcurioso2.Visible = true;
                preguntarDato2 = true;
            }
            if (dato == 2)
            {
                dtcurioso3.Visible = true;
                preguntarDato3 = true;
            }
            if (dato == 3)
            {
                dtcurioso4.Visible = true;
                preguntarDato4 = true;
            }
            if (dato == 4)
            {
                dtcurioso5.Visible = true;
                preguntarDato5 = true;
            }

            //oculta el boton de los datos y muestra el de las preguntas
            sabiasqueRandom.Visible = false;
            sabiasQuePregunta.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelInstrucciones.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panelInstrucciones.Visible = true;
        }

        private void panelInstrucciones_Paint(object sender, PaintEventArgs e)
        {

        }
    }    
}
