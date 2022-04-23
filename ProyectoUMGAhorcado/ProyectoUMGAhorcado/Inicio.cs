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
    public partial class Inicio : Form
    {
        public AHORCADOEntities hola;
        public Inicio()

        {
            hola = new AHORCADOEntities();
            
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            EligJu auba = new EligJu();
            auba.Visible = true;
            this.Hide();
        }
       

}
}
