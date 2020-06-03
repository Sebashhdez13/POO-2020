using System;
using System.Collections.Generic;

namespace IlustradorI
{
    interface IFiguras:IComparable
    {
        int X {get; set;}
        int Y {get; set;}
        string color {get; set;}
        void Dibuja();
        void ImprimirColor();
    }

    class Circulo:IFiguras
    {
        int x, y;
        string color;

        public Circulo(int x, int y, string c)
        {
            this.x = x;
            this.y = y;
            this.color = c;
        }
        public int X {get => x; set => x = value;}
        public int Y {get => y; set => y = value;}
        public string Color {get => color; set => color = value;}
        string IFiguras.color { get => color; set => color = value;}

        public void Dibuja()
        {
            Console.WriteLine("Se dibuja un circulo {0}", Color);
        }
        public int CompareTo(object Obj)
        {
            IFiguras Otro = Obj as IFiguras;
            return Color.CompareTo(Otro.color);
        }
        public void ImprimirColor()
        {
            Console.WriteLine("El color es {0}",Color);
        }
    }

    class Rect:IFiguras
    {
        int x, y;
        string color;
        public Rect(int x, int y, string c)
        {
            this.x = x;
            this.y = y;
            this.color = c;
        }
        public int X {get => x; set => x = value;}
        public int Y {get => y; set => y = value;}
        public string Color {get => color; set => color = value;}
        string IFiguras.color { get => color; set => color = value; }

        public int CompareTo(object Obj)
        {
            IFiguras Otro = Obj as IFiguras;
            return color.CompareTo(Otro.color);
        }
        public void Dibuja()
        {
            Console.WriteLine("Se dibuja un rectangulo {0}", color);
        }
        public void ImprimirColor()
        {
            Console.WriteLine("El Color es {0}", color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<IFiguras> figuras = new List<IFiguras>();
            figuras.Add(new Circulo(12,13,"Verde")) ;
            figuras.Add(new Rect(12,13,"Azul")) ;
            figuras.Add(new Rect(12,13,"Rojo")) ;
            figuras.Add(new Circulo(12,13,"Amarillo")) ;
            foreach (var item in figuras)
            {
                item.Dibuja();
            }
        }
    }
}