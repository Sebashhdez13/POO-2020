using System;
using System.Collections.Generic;

namespace ListadePeliculas
{
     class ListadePeliculas
    {
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            List <String> Lista = new List<String>();
            
            Lista.Add("1.Kick Ass 2");
            Lista.Add("2.Avengers End Game");
            Lista.Add("3.Just Go With It");
            Lista.Add("4.Toy Story 3");
            Lista.Add("5.Captain America Civil War");

            foreach (String Pelicula in Lista)
            Console.WriteLine(Pelicula);
        }
    }
}
