using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUMGAhorcado
{
    public partial class Jugador2 : Form
    {

        public String palabra;
        public int Oportunidades;
        public char[] alfabeto;
        public int jamenja = 0;
        public Jugador2(String PalSelect)
        {
            palabra = PalSelect;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void IniciarJuego()
        {
            //valores iniciales
            flFichas.Controls.Clear();
            flFichas.Enabled = true;
            picAhorcado.Image = null;
            lblMensaje.Visible = false;
            Oportunidades = 1; //fallos
            BTNiniciar.Image = Properties.Resources.inicio;


            alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();



            //ciclo que carga el alfabeto

            foreach (char LetraAlfabeto in alfabeto)
            {
                Button btnLetra = new Button();
                btnLetra.Tag = "";
                btnLetra.Text = LetraAlfabeto.ToString();
                btnLetra.Width = 60;
                btnLetra.Height = 40;
                btnLetra.Click += Compara;
                btnLetra.ForeColor = Color.White;
                btnLetra.Font = new Font(btnLetra.Font.Name, 15, FontStyle.Bold);
                btnLetra.BackgroundImageLayout = ImageLayout.Center;
                btnLetra.BackColor = Color.Black;
                btnLetra.Name = LetraAlfabeto.ToString();
                flFichas.Controls.Add(btnLetra);
            }

            flPalabra.Controls.Clear();


            for (int IndiceValorLetra = 0; IndiceValorLetra < palabra.Length; IndiceValorLetra++)
            {
                Button Letra = new Button();
                Letra.Tag = palabra[IndiceValorLetra].ToString();
                Letra.Width = 46;
                Letra.Height = 80;
                Letra.ForeColor = Color.Purple;
                Letra.Text = "-";
                Letra.Font = new Font(Letra.Font.Name, 32, FontStyle.Bold);
                Letra.BackgroundImageLayout = ImageLayout.Center;
                Letra.BackColor = Color.White;
                Letra.Name = "adivinado" + IndiceValorLetra.ToString();
                flPalabra.Controls.Add(Letra);

            }


        }
        void Compara(object sender, EventArgs e)
        {

            bool encontrado = false;
            //boton presionado
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;

            //Compara la letra seleccionada con las letras de la palabra
            for (int indiceRevisar = 0; indiceRevisar < palabra.Length; indiceRevisar++)
            {
                if (palabra[indiceRevisar] == char.Parse(btn.Text))
                {
                    Button tbx = this.Controls.Find("Adivinado" + indiceRevisar, true).FirstOrDefault() as Button;
                    tbx.Text = palabra[indiceRevisar].ToString();
                    jamenja += 1;
                    encontrado = true;
                }
                if (jamenja == palabra.Length)
                {
                    jamenja = 0;
                    MessageBox.Show("ganaste");
                }
            }


            //verificar si todas las letras de la palabra estan destapadas
            bool Ganaste = true;

            for (int indiceAnalizadorGanador = 0; indiceAnalizadorGanador < palabra.Length; indiceAnalizadorGanador++)
            {
                //si el usuario tiene letras pendientes por destapar se cambia el estatus
                if (palabra[indiceAnalizadorGanador] != '-')
                {
                    Ganaste = false;
                }
            }
            //si el estatus de la variable no cambia quiere decir el usuario gano
            if (Ganaste) 
            {
                MessageBox.Show("Ganaste");
            }
            
            //si no se encontro ninguna letra
            if (!encontrado)
            {
                Oportunidades = Oportunidades + 1;
                picAhorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("ahorcado" + Oportunidades);

                //si las oportunidades se acabaron
                if (Oportunidades == 5)
                {
                    lblMensaje.Visible = true;
                    MessageBox.Show("Perdiste"); BTNiniciar.Image = Properties.Resources.inicio;
                    //muestra la palabra que el usuario intento adivinar
                    for (int IndiceValorLetra = 0; IndiceValorLetra < palabra.Length; IndiceValorLetra++)
                    {
                        Button btnLetra = this.Controls.Find("Adivinado" + IndiceValorLetra, true).FirstOrDefault() as Button;
                        btnLetra.Text = btnLetra.Tag.ToString();
                    }
                    //Desactivar las fichas y cambiar boton de reinicio
                    EscPalabra regresar = new EscPalabra();
                    regresar.Visible = true;
                    this.Hide();

                }
               
            }
            
        }

        private void BTNiniciar_Click(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EscPalabra regresar = new EscPalabra();
            regresar.Visible = true;
            this.Hide();
        }
    }
}
