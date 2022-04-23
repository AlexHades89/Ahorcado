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
    public partial class EligJu : Form
    {
        public EligJu()
        {
            InitializeComponent();
        }

        private void Jugadores_1_Click(object sender, EventArgs e)
        {
            Dificultad kante = new Dificultad();
            kante.Visible = true;
            this.Hide();
        }

        private void Jugadores_2_Click(object sender, EventArgs e)
        {
            EscPalabra nuevo = new EscPalabra();
            nuevo.Visible = true;
            this.Hide();
        }
    }
}
