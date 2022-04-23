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
    public partial class EscPalabra : Form
    {
        private AHORCADOEntities hotsonjornetGuardar;
        public EscPalabra()
        {
            InitializeComponent();
            hotsonjornetGuardar = new AHORCADOEntities();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            validarCampo();
            String PalSelect = textBox1.Text.ToUpper();
            MessageBox.Show("Se guardo la palabra ");
            Jugador2 nuevo = new Jugador2(PalSelect);
            this.Guardar(PalSelect);
            nuevo.Visible = true;
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            EligJu nuevo = new EligJu();
            nuevo.Visible = true;
            this.Hide();
        }

        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(textBox1.Text);
            button1.Enabled = vr;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.PasswordChar = '*';
            validarCampo();
            try
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            
            }catch
            {

            }
            
        }

        public void Guardar(String LtsPalabra)
        {
            TBL_PALABRA apex = new TBL_PALABRA();
            apex.PALABRA = LtsPalabra;
            var Palabra = LtsPalabra.Length;

 
            if (Palabra >= 1 && Palabra <= 5)
            {
                apex.DIFICULTAD = 1;
            }
            else if (Palabra >= 6 && Palabra <= 11)
            {
                apex.DIFICULTAD = 2;
            }
            else if (Palabra >= 12)
            {
                apex.DIFICULTAD = 3;
            }
            this.hotsonjornetGuardar.TBL_PALABRA.Add(apex);
            this.hotsonjornetGuardar.SaveChanges();
        }
    }
     
}
