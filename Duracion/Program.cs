using System;

namespace Duracion
{
    class Duracion
    {
        //Declaracion de atributos

        public int Horas;
        public int Minutos;
        public int Segundos;

        //Constructor
        public Duracion(int H, int M, int S)
        {
            Horas = H;
            Minutos = M;
            Segundos = S;
        }

        public Duracion()
        {

        }

        //Metodo imprimir
        public void print()
        {
            Console.WriteLine("{0}:{1}:{2}" , Horas, Minutos, Segundos);
        }

        public void Conversion()
        {
            int hora = Horas*60;
            Console.WriteLine("Horas a Minutos");
            Console.WriteLine("{0}" ,Horas);
            int segundos = Horas*3600;
            Console.WriteLine("Horas a Segundos");
            Console.WriteLine("{0}" ,Segundos);
            int minutos = Minutos*60;
        }
        public static int operator + (Duracion Tiempo1, Duracion Tiempo2)
        {
            return ((Tiempo1.Horas + Tiempo2.Horas) * 3600) + ((Tiempo1.Minutos + Tiempo2.Minutos) *60) + ((Tiempo1.Segundos + Tiempo2.Segundos));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("D1: ");
            Duracion Tiempo = new Duracion(4 , 16, 48);
            Tiempo.print();
            Tiempo.Conversion();

            Console.WriteLine("D2: ");
            Duracion Tiempo0 = new Duracion(8 , 32, 96);
            Tiempo0.print();
            Tiempo0.Conversion();

            Console.WriteLine("Suma de las 2 Duraciones: " + (Tiempo + Tiempo0));
        }
    }
}
