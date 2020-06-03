using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFigura
{
    enum EstadoActual {Seleccionando, rectangulo, elipse, polygon}
    
    public partial class Form1 : Form
    {
        List<Figura> figuras;
        EstadoActual estado = EstadoActual.Seleccionando;
        bool Dibujando = false;
        int temp_x, temp_y;

        public Form1()
        {
            InitializeComponent();
            figuras = new List<Figura>();
        }

        Figura GetFigura(int X, int Y)
        {
            foreach (Figura F in figuras)
            {
                if (F.EstaContenido(X, Y))
                {
                    return F;
                }
            }

            return null;
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //this.label1.Text = string.Format("{0},{1}",e.X, e.Y);

            if (e.Button == MouseButtons.Left && this.estado == EstadoActual.Seleccionando)
            {
                Figura Seleccionada = null;
                Seleccionada = GetFigura(e.X, e.Y);

                MessageBox.Show(Seleccionada.color.ToString());

                if (Seleccionada != null)
                {
                    Seleccionada.color = Color.Red;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                Elipse E = new Elipse(e.X, e.Y, 100, 100);
                E.Dibuja(this);
                figuras.Add(E);
            }



        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura F in figuras)
                F.Dibuja(this);
        }

        private void Elipse_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.elipse;
        }

        private void Rectangulo_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.rectangulo;
        }

        private void Seleccion_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.Seleccionando;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(estado == EstadoActual.rectangulo && Dibujando == true)
            {
                Rectangulo r = new Rectangulo(temp_x, temp_y, e.X - temp_x, e.Y - temp_y);
                figuras.Add(r);
                r.Dibuja(this);
                Dibujando = false;
                
            }else

            if (estado == EstadoActual.elipse && Dibujando == true)
            {
                Elipse Elipse = new Elipse(temp_x, temp_y, e.X - temp_x, e.Y - temp_y);
                figuras.Add(Elipse);
                Elipse.Dibuja(this);
                Dibujando = false;
            }else

            if (estado == EstadoActual.polygon && Dibujando == true)
            {
                Polygon Polygon = new Polygon(temp_x, temp_y, e.X - temp_x, e.Y - temp_y);
                figuras.Add(Polygon);
                Polygon.Dibuja(this);
                Dibujando = false;
            }
            

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (estado == EstadoActual.rectangulo && Dibujando == true)
            {
                Graphics graphics = CreateGraphics();
                graphics.DrawRectangle(new Pen(Color.Black), temp_x, temp_y, e.X - temp_x, e.Y - temp_y);
                
            }
             
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.polygon;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((estado == EstadoActual.rectangulo || estado == EstadoActual.elipse || estado == EstadoActual.polygon) && Dibujando == false)
            {
                Dibujando = true;
                temp_x = e.X;
                temp_y = e.Y;
            }
        }
    }
}
