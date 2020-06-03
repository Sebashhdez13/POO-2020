using System;

namespace Domino
{
    class Domino
    {
        //Declaracion de atributos 
        public int Espacio1;
        public int Espacio2;

        //Sobre carga
        public Domino(int Espacio1, int Espacio2)
        {
            this.Espacio1=Espacio1;
            this.Espacio2=Espacio2;
        }

        //Sobre carga de operador
        public static int operator + (Domino Espacio1, Domino Espacio2) => (Espacio1.Espacio1 + Espacio1.Espacio2 + Espacio2.Espacio1 + Espacio2.Espacio2);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Domino Espacio1 = new Domino (6,8);
            Domino Espacio2 = new Domino (3,2);

            Console.WriteLine("Suma de los 2 Dominos : " + (Espacio1 + Espacio2));
        }
    }
}
