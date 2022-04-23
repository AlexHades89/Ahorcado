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
    public partial class Dificultad : Form
    {
        public AHORCADOEntities ElegirDif;
        public int Manco;
        

     
        public Dificultad()
        {
            InitializeComponent();
        }

        private void ComboDif_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DIFF();
            Jugador1 hotsonjornet = new Jugador1(Manco);
            hotsonjornet.Visible = true;
            this.Hide();
        }

        public void DIFF()
        {
            //var tecun = this.ElegirDif.TBL_DIFICULTAD.ToList();
            var hotsonjornet = ComboDif.Text;
            MessageBox.Show(hotsonjornet);
            if(hotsonjornet == "Facil")
            {
                Manco = 1;
            }else if(hotsonjornet == "Medio")
            {
                Manco = 2;
            }else if(hotsonjornet == "Dificil")
            {
                Manco = 3;
            }
            
        }

        private void Dificultad_Load(object sender, EventArgs e)
        {

        }
    }
}
