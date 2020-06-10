using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        int ContadorMovimiento = 1;
        bool VolarArriba = false;
        int Distancia = 0;
        Random PosicionRandom = new Random();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            IniciarJuego();
        }
        public void IniciarJuego()
        {
            MarioPlayer.Location = new Point(98, 279);
            Distancia = PosicionRandom.Next(-160, 118);
            PlantaArriba.Location = new Point(212, -37 - Distancia);
            PlantaAbajo.Location = new Point(212, 425 - Distancia);
            Puntaje.Text = "0";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int CantidadMovimientos = 5;
            if (ContadorMovimiento <= CantidadMovimientos)
            {
                MarioPlayer.Image = Properties.Resources.Captura2;
                ContadorMovimiento++;
            }
            if ((ContadorMovimiento > CantidadMovimientos / 2) && (ContadorMovimiento <= CantidadMovimientos * 2))
            {
                MarioPlayer.Image = Properties.Resources.Captura2;
                ContadorMovimiento++;
            }

            ContadorMovimiento = (ContadorMovimiento > CantidadMovimientos * 2) ? 0 : ContadorMovimiento;

            int ly = MarioPlayer.Location.Y;
            int lx = MarioPlayer.Location.X;

            if (VolarArriba)
            {
                ly = ly - 15;
                VolarArriba = false;
            }
            else
            {
                ly++;
            }

            MarioPlayer.Location = new Point(MarioPlayer.Location.X, ly);

            if ((MarioPlayer.Bounds.IntersectsWith(Barrera.Bounds)) || (MarioPlayer.Bounds.IntersectsWith(PlantaArriba.Bounds)) || (MarioPlayer.Bounds.IntersectsWith(PlantaAbajo.Bounds)))
            {
                IniciarJuego();
            }

            Puntaje.Location = new Point(MarioPlayer.Location.X + 30, MarioPlayer.Location.Y - 25);
            Puntaje.Text = (PlantaArriba.Location.X == MarioPlayer.Location.X) ? Convert.ToString((Convert.ToInt32(Puntaje.Text) + 1)).ToString() : Puntaje.Text;

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Space))
            {
                VolarArriba = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(PlantaAbajo.Location.X > -140)
            {
                PlantaAbajo.Location = new Point((PlantaAbajo.Location.X) - 1, PlantaAbajo.Location.Y);
                PlantaArriba.Location = new Point((PlantaArriba.Location.X) - 1, PlantaArriba.Location.Y);

            }
            else
            {
                Distancia = PosicionRandom.Next(-170, 118);
                PlantaAbajo.Location = new Point(300, 250 + Distancia);
                PlantaArriba.Location = new Point(300, -170 + Distancia);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
