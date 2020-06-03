using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFigura
{
    abstract class Figura
    {
        protected Pen pluma;
        private Color _color;
        public Color color
        {
            get => _color;
            set
            {
                _color = value;
                brocha.Color = value;
            }
        }
        protected SolidBrush brocha;
        protected int x, y;
        protected int ancho, alto;

        public Figura(int x, int y, int ancho, int alto)
        {
            this.x = x;
            this.y = y;
            this.ancho = ancho;
            this.alto = alto;
            _color = Color.Orange;
            pluma = new Pen(color);
            brocha = new SolidBrush(Color.Yellow);

        }
        abstract public void Dibuja(Form Forma);

        public bool EstaContenido(int A, int B)
        {
            return (A >= x && A <= x + ancho) && (B >= y && B <= y + alto);
        }

    }
    

    class Rectangulo : Figura
    {
        

        public Rectangulo(int x, int y, int ancho, int alto):base(x, y, ancho, alto)
        {
            
            
        }

        public override void Dibuja(Form forma)
        {
            Graphics graphics = forma.CreateGraphics();

            graphics.DrawRectangle(pluma, x, y, ancho, alto);
            graphics.FillRectangle(brocha, x, y, ancho, alto);
        }
            

    }
    class Elipse : Figura
    {


        public Elipse(int x, int y, int ancho, int alto) : base(x, y, ancho, alto)
        {
            

        }

        public override void Dibuja(Form forma)
        {
            Graphics graphics = forma.CreateGraphics();

            graphics.FillEllipse(brocha, x, y, ancho, alto);
            graphics.DrawEllipse(pluma, x, y, ancho, alto);

        }


    }
    class Polygon : Figura
    {


        public Polygon(int x, int y, int ancho, int alto) : base(x, y, ancho, alto)
        {


        }

        public override void Dibuja(Form forma)
        {
            Graphics graphics = forma.CreateGraphics();

            graphics.FillPolygon(brocha, x, y, ancho, alto);
            graphics.DrawPolygon(pluma, x, y, ancho, alto);

        }


    }
}
