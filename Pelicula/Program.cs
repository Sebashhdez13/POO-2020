using System;

namespace Pelicula
{
    class Pelicula
    {
        //Atributos
        public string titulo;
        public Int16 año;
        public string pais;
        public string director;

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

    }
    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}

