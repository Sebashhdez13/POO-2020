using System;
using System.IO;
using System.Collections.Generic;

namespace ProyectoProducto
{
    //Creamos la clase Producto
    class Producto
    {
        //Declaracion de Variables
        public string Codigo;
        public string Descripcion;
        public double Precio;
        public int Departamento;
        public int Likes;

        //Creamos el constructor
        public Producto(string Cod, string Des, double Pre, int Dep, int L)
        {
            Codigo = Cod;
            Descripcion = Des;
            Precio = Pre;
            Departamento = Dep;
            Likes = L;
        }
    }
    //Creamos la clase ProductoDB
    class ProductoDB
    {
        public List<Producto> productos =new List<Producto>();

        //Escribir los productos en formato tipo texto
        public static void ProductosTXTOUT(string datos,List<Producto> productos)
        {
            try
            {
                FileStream FileS1 = new FileStream(datos, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter TXTOUT = new StreamWriter(FileS1);

                foreach (Producto p in productos)
                {
                    TXTOUT.WriteLine("{0}|{1}|{2}|{3}|{4}", p.Codigo, p.Descripcion, p.Precio, p.Departamento, p.Likes);
                }
                TXTOUT.Close();
            }
            catch(FileNotFoundException)
            {
                Console.Write("El Archivo no fue encontrado");
            } 
            catch(DirectoryNotFoundException)
            {
                Console.Write("El Directorio no fue encontrado");
            }
            catch(IOException)
            {
                Console.Write("IOException");
            }
        }
        //Leer Archivos texto
        public static List<Producto> ProductosTXTIN(string datos)
        {
            StreamReader TXTIN=new StreamReader(new FileStream(datos,FileMode.Open,FileAccess.Read));
            List<Producto> productos =new List<Producto>();

            while (TXTIN.Peek()!= -1)
            {
                string row=TXTIN.ReadLine();
                string[] columna= row.Split('|');

                Producto producto =new Producto();

                producto.Codigo= columna[0];
                producto.Descripcion= columna[1];
                producto.Precio= Convert.ToDouble(columna[2]);
                producto.Departamento= Convert.ToInt32(columna[3]);
                producto.Likes=Convert.ToInt32(columna[4]);
                productos.Add(producto);
            }
            //retorna los productos en producto
            return productos;
        }
        //Imprimir Departamento seleccionado
        public void GetDepartment(int depo)
        {
            IEnumerable<Producto> dep = from p in productos
            where p.Departamento == depo select p;
            Console.WriteLine(" Departamento seleccionado : "+ depo);
            Console.WriteLine("----------------------------");
            foreach(Producto p in dep)
            {
               Console.WriteLine("{0} {1} {2} {3} {4}", p.Codigo, p.Descripcion,p.Precio, p.Departamento,p.Likes); 
            }
        }

        //Ordenar por likes
        public void OrdenarLikes()
        {
            //Enumera los productos en base a sus likes
            IEnumerable<Producto> likes= from p in productos
            orderby p.Likes select p;
            Console.WriteLine("Productos ordenados por likes: " + likes);
            Console.WriteLine("----------------------------");
            foreach (Producto p in likes)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", p.Codigo, p.Descripcion, p.Precio, p.Departamento, p.Likes);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           List<Producto> productos =new List<Producto>(); 
        }
    }
}
