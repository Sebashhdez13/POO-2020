using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoFinalProducto
{
    //Creacion de la clase Producto
    class Producto
    {
        //Declaracion de variables
        public string Codigo;
        public string Descripcion;
        public double Precio;
        public int Departamento;
        public int Likes;

        //Realizamos el constructor
        public Producto(string Cod,string Des,double Pre,int Dep,int L)
        {
            this.Codigo=Cod;
            this.Descripcion=Des;
            this.Precio=Pre;
            this.Departamento=Dep;
            this.Likes=L;
        }
        //Utilizamos sobre carga para el constructor
        public Producto()
        {

        }
    }
    //Creacion de la clase ProductoDB
    class ProductoDB
    {
        //Lista para la utilizacion de getdepartamento y ordenarlikes
        public List<Producto> productos =new List<Producto>();
    
        //Escribir productos en formato texto   
        public static void ProductosTXTOUT(string datos,List<Producto> productos)
        {
             //try Preeve las excepciones en el transcurso de la ejecucion del programa
            try
            {
                //Crear y abrir un archivo
                FileStream FileS1 = new FileStream(datos, FileMode.OpenOrCreate, FileAccess.Write);
                //Permite escribir en el archivo forma texto
                StreamWriter TXTOUT = new StreamWriter(FileS1);

                foreach (Producto p in productos)
                {
                    TXTOUT.WriteLine("{0}|{1}|{2}|{3}|{4}", p.Codigo, p.Descripcion, p.Precio, p.Departamento, p.Likes);
                }
                TXTOUT.Close();
            }
            //Se realiza la excepcion
            catch(FileNotFoundException)
            {
                Console.Write("Archivo no fue encontrado");
            }
            catch(DirectoryNotFoundException)
            {
                Console.Write("Directorio no fue encontrado");
            }
            catch(IOException)
            {
                Console.Write("IOException");
            }
        
        }
        //Leer archivos texto
        public static List<Producto> ProductosTXTIN(string datos)
        {
            //Funciona para abrir y leer archivos ya existentes
            StreamReader TXTIN=new StreamReader(new FileStream(datos,FileMode.Open,FileAccess.Read));

            //Realizar lista de tipo Producto
            List<Producto> productos =new List<Producto>();

            //Realiza un ciclo mientras hay atributos 
            while (TXTIN.Peek()!= -1)
            {
                //Permite divir los strings en dos
                string row=TXTIN.ReadLine();
                string[] columna= row.Split('|');

                //Creacion del objeto Producto
                Producto producto =new Producto();

                //Agregacion de las variables en los objetos producto
                producto.Codigo= columna[0];
                producto.Descripcion= columna[1];
                producto.Precio= Convert.ToDouble(columna[2]);
                producto.Departamento= Convert.ToInt32(columna[3]);
                producto.Likes=Convert.ToInt32(columna[4]);
                productos.Add(producto);
            }

            //retorne los productos en producto
            return productos;
        }

        //Imprimir el departmento seleccionado
        public void GetDepartment(int depo)
        {
            //Hacer que el programa enumere los productos y permita imprimir el departamento seleccionado
            IEnumerable<Producto> dep = from p in productos
            where p.Departamento == depo select p;
            Console.WriteLine(" Departamento seleccionado : "+ depo);
            Console.WriteLine("----------------------------");
            foreach(Producto p in dep)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", p.Codigo, p.Descripcion,p.Precio, p.Departamento,p.Likes);
            }
        }

        //Ordenar y imprimir likes
        public void OrdenarLikes()
        {
        IEnumerable<Producto> likes= from p in productos
        orderby p.Likes select p;
        Console.WriteLine("Productos ordenados por likes: " + likes);
        Console.WriteLine("----------------------------");
        foreach (Producto p in likes)
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", p.Codigo, p.Descripcion, p.Precio, p.Departamento, p.Likes);
        }
    }

    //Creamos la clase Precio Fecha
    class PrecioFecha
    {
        //Declaracion de variables
        DateTime FechaInicio;
        DateTime FechaFinal;
        Decimal Precio;

        //Realizamos el constructor
        public PrecioFecha(DateTime FI, DateTime FF, Decimal P)
        {
            this.FechaInicio=FI;
            this.FechaFinal=FF;
            this.Precio=P;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto tipo Productos
            List<Producto> productos =new List<Producto>();

            //Lista para poder ordenar por likes
            ProductoDB pro=new ProductoDB();
            pro.productos.Add(new Producto("45496882174","Nintendo Switch",9000,6,800));
            pro.productos.Add(new Producto("711719524144","Playstation 4 Pro",11000,10,1000));
            pro.productos.Add(new Producto("889842408836","Xbox One X",10300,5,600));
            pro.productos.Add(new Producto("818279024425","GoPro Hero 8 ",9000,4,200));

            //lista de productos para imprimir en texto
            productos.Add(new Producto("45496882174","Nintendo Switch",9000,6,800));
            productos.Add(new Producto("711719524144","Playstation 4 Pro",11000,10,1000));
            productos.Add(new Producto("889842408836","Xbox One X",10300,5,600));
            productos.Add(new Producto("818279024425","GoPro Hero 8 ",9000,4,200));

            //Imprimir el texto y crear el archivo
            ProductoDB.ProductosTXTOUT(@"Producto.txt", productos);
            Console.WriteLine("Datos guardados en formato txt");
            Console.WriteLine("--------------------------------");
            List<Producto> ProductoINT = ProductoDB.ProductosTXTIN(@"Producto.txt");
            foreach(Producto PT in ProductoINT)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}",PT.Codigo,PT.Descripcion,PT.Precio,PT.Departamento,PT.Likes);
            }

            //Obtener el departamento ingresado 
            pro.GetDepartment(4);

            //Permite ordenar los likes
            pro.OrdenarLikes();
        }
    }
    }
}

