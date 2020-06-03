using System;
using System.Collections.Generic;

namespace MusicosAbstractos
{
    abstract class Musico
    {
        protected string Nombre;

        public Musico(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public abstract void Afina();
        
        public abstract void Saluda();
        
        public abstract void Toca();

        public void PrintMusico()
        {
            Console.WriteLine(Nombre);
        }
        
    }

    class Baterista : Musico
    {
        protected string Bateria;

        public Baterista(string Nombre, string Bateria):base(Nombre)
        {
            this.Bateria = Bateria;
        }

        public override void Afina()
        {
            Console.WriteLine("{0} Afina su bateria la cual es {1} " ,Nombre,Bateria);
        }

        public override void Saluda()
        {
            Console.WriteLine("Hola mi nombre es {0}" ,Nombre);
        }

        public override void Toca()
        {
            Console.WriteLine("{0} Empezo a tocar su bateria la cual es {1} " ,Nombre,Bateria);
        }
    }

    class Bajista : Musico
    {
        protected string Bajo;

        public Bajista(string Nombre, string Bajo):base(Nombre)
        {
            this.Bajo = Bajo;
        }

        public override void Afina()
        {
            Console.WriteLine("{0} Afina su bajo el cual es {1} " ,Nombre,Bajo);
        }

        public override void Saluda()
        {
            Console.WriteLine("Hola mi nombre es {0}" ,Nombre);
        }

        public override void Toca()
        {
            Console.WriteLine("{0} Empezo a tocar su bajo la cual es {1} " ,Nombre,Bajo);
        }

    }

    class Guitarrista : Musico
    {
        protected string Guitarra;

        public Guitarrista(string Nombre, string Guitarra):base(Nombre)
        {
            this.Guitarra = Guitarra;
        }

        public override void Afina()
        {
            Console.WriteLine("{0} Afina su guitarra la cual es {1} " ,Nombre,Guitarra);
        }

        public override void Saluda()
        {
            Console.WriteLine("Hola mi nombre es {0}" ,Nombre);
        }

        public override void Toca()
        {
            Console.WriteLine("{0} Empezo a tocar su guitarra la cual es {1} " ,Nombre,Guitarra);
        }

    }

    class GuitarristaR : Musico
    {
        protected string GRitmitca;

        public GuitarristaR(string Nombre, string GRitmitca):base(Nombre)
        {
            this.GRitmitca = GRitmitca;
        }

        public override void Afina()
        {
            Console.WriteLine("{0} Afina su Microfono el cual es {1} " ,Nombre,GRitmitca);
        }

        public override void Saluda()
        {
            Console.WriteLine("Hola mi nombre es {0}" ,Nombre);
        }

        public override void Toca()
        {
            Console.WriteLine("{0} Empezo a cantar con su Microfono el cual es {1} " ,Nombre,GRitmitca);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Baterista Ringo = new Baterista("Ringo", "Yamaha");
            Ringo.Afina();
            Ringo.Saluda();
            Ringo.Toca();

            Bajista Paul = new Bajista("Paul","Fender");
            Paul.Afina();
            Paul.Saluda();
            Paul.Toca();

            Guitarrista George = new Guitarrista("George","Gibson");
            George.Afina();
            George.Saluda();
            George.Toca();

            GuitarristaR John = new GuitarristaR("John","Ibanez");
            John.Afina();
            John.Saluda();
            John.Toca();

            Console.WriteLine("Imprimir por medio de List");
            List<Musico> TheBeatles = new List<Musico>();
            TheBeatles.Add(Ringo);
            TheBeatles.Add(Paul);
            TheBeatles.Add(George);
            TheBeatles.Add(John);
            foreach(Musico miembros in TheBeatles)
            {
                miembros.Afina();
                miembros.Saluda();
                miembros.Toca();

            }
        }
    }
}
