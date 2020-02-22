using System;

namespace Pelicula
{
    class Pelicula
    {
        //Atributos
        private string titulo;
        private Int16 año;
        private string pais;
        private string director;

        //Metodos
        public void Settitulo(string T)
        {
            titulo = T;
        }
        public string Gettitulo()
        {
            return this.titulo;
        }
        public void Setaño(Int16 A)
        {
            año = A;
        }
        public Int16 Getaño()
        {
            return this.año;
        }
         public void Setpais(string P)
        {
            pais = P;
        }
        public string Getpais()
        {
            return this.pais;
        }
         public void Setdirector(string D)
        {
            director = D;
        }
        public string Getdirector()
        {
            return this.director;
        }
        //Constructor
        public Pelicula()
        {

        }
        public Pelicula(String titulo , Int16 año)
        {
            this.titulo = titulo;
            this.año = año;
        }
        //Imprimir
        public void Imprime()
        {
            Console.WriteLine("{0}({1})", this.titulo, this.año);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //Objetos
            Pelicula P1 = new Pelicula();
            P1.Settitulo("La forma del agua");
            P1.Setaño(2018);
            Console.WriteLine("{0}({1})" , P1.Gettitulo(), P1.Getaño());

            Pelicula P2 = new Pelicula();
            P2.Settitulo("Argo");
            P2.Setaño(2013);
            Console.WriteLine("{0}({1})" , P2.Gettitulo(), P2.Getaño());
        }
    }
}

