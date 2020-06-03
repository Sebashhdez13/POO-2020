using System;

namespace Alumnos
{
    class Alumnos
    {
        //Declaracion de atributos
        protected string Nombre;
        protected string Carrera;

        public Alumnos(string Nombre, string Carrera)
        {
            this.Nombre = Nombre;
            this.Carrera = Carrera;
        }

        public virtual void Print()
        {
            Console.WriteLine("Mi Nombre es {0} , Mi Carrera es :{1} :" ,Nombre,Carrera);
        }

    }
    
    class Licenciatura : Alumnos
    {
        //Declaracion de atributos
        protected string ServicioS;
        protected string Residencia;

      public Licenciatura(string Nombre, string Carrera, string ServicioS, string Residencia):base(Nombre, Carrera)
       {
        this.ServicioS = ServicioS;
        this.Residencia = Residencia;
       }

       public override void Print()
       {
           Console.WriteLine("Mi Nombre es {0} , Mi Carrera es :{1} ,Realizare mi Servicio en :{2} ,Realizare mi Residencia en :{3} :" ,Nombre,Carrera,ServicioS,Residencia);
       }

    }
    class Posgrado : Alumnos
    {
        protected string Investigacion;

        public Posgrado(string Nombre, string Carrera, string Investigacion):base(Nombre,Carrera)
        {
            this.Investigacion = Investigacion;
        }

        public override void Print()
        {
            Console.WriteLine("Mi Nombre es {0} , Mi Carrera es :{1} ,Realizare una Investigacion sobre :{2} :" ,Nombre,Carrera,Investigacion);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Licenciatura Martin = new Licenciatura("Martin","Sistemas","Samsung","INVOLVE");
            Posgrado Jesus = new Posgrado("Jesus","Sistemas","Inteligencia artificial");
            Alumnos Veranda = new Alumnos("Veranda","Sistemas");

            Martin.Print();
            Jesus.Print();
            Veranda.Print();
        }
    }
}
