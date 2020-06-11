﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoProducto
{   
    //Creamos la clase Productos
    class Producto
    {
     //Declaracion de variables
     public string Codigo;
     public string Descripcion;
     public double Precio;
     public int Departamento;
     public int Likes;
    
    //Creacion de constructor
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
    class ProductoDB
    {
        //Lista para la utilizacion de getdepartamento y ordenarlikes
        public List<Producto> productos =new List<Producto>();

        //Escribir productos en formato texto   
       public static void ProductosTXTOUT(string datos,List<Producto> productos)
        {  

           try
           {
            //Permite crear y abrir un archivo
            FileStream FileS1 = new FileStream(datos, FileMode.OpenOrCreate, FileAccess.Write);
            //Permite escribir en el archivo forma txt
            StreamWriter TXTOUT = new StreamWriter(FileS1);
            
            foreach (Producto p in productos)
            {
              TXTOUT.WriteLine("{0}|{1}|{2}|{3}|{4}", p.Codigo, p.Descripcion, p.Precio, p.Departamento, p.Likes);
            }
              TXTOUT.Close();
        }
       catch(FileNotFoundException)
        {
        Console.Write("Archivo no encontrado");
        }
        catch(DirectoryNotFoundException)
        {
        Console.Write("Directorio no encontrado");
        }
        catch(IOException )
        {
        Console.Write("IOException");
        }
                 
    }

    
    //Metodo para poder leer archivos txt
    public static List<Producto> ProductosTXTIN(string datos)
    {  
    //Permite abrir y leer archivos ya existentes
    StreamReader TXTIN=new StreamReader(new FileStream(datos,FileMode.Open,FileAccess.Read));
    //Permite crear lista de tipo Producto
    List<Producto> productos =new List<Producto>();
    //Permite realizar un ciclo mientras hay atributos 
    while (TXTIN.Peek()!= -1)
    {  
       //Permite partir ala mitad los strings
       string row=TXTIN.ReadLine();
       string[] columna= row.Split('|');
       //Creacion del objeto tipo Producto
       Producto producto =new Producto();
       //Agrega cada uno de los variables en los objetos producto
       producto.Codigo= columna[0];
       producto.Descripcion= columna[1];
       producto.Precio= Convert.ToDouble(columna[2]);
       producto.Departamento= Convert.ToInt32(columna[3]);
       producto.Likes=Convert.ToInt32(columna[4]);
       productos.Add(producto);
    }
    //regresa los productos en producto
    return productos;
    }
    
    
    
    //Metodo que permite imprimir solo el departmento seleccionado
    public void GetDepartment(int depo)
    {   
        //Permite enumerar los productos y permitir solo imprimir el departamento seleccionado
        IEnumerable<Producto> dep =
        from p in productos
        where p.Departamento == depo
        select p;
        Console.WriteLine(" Departamento seleccionado : "+ depo);
        Console.WriteLine("----------------------------");
        foreach(Producto p in dep)
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", p.Codigo, p.Descripcion,p.Precio, p.Departamento,p.Likes);
        }

    }

    //Metodo que permite ordenar por likes
    public void OrdenarLikes()
    { 
    //Enumera los productos en base a sus likes
    IEnumerable<Producto> likes=
    from p in productos
    orderby p.Likes
    select p;
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
        //Lista para poder ordenar por likes 
        ProductoDB pro=new ProductoDB();
        pro.productos.Add(new Producto("1","Libreta Scribe",40.52d,1,50));
        pro.productos.Add(new Producto("2","Pluma Negra Bic",5.53d,2,30));
        pro.productos.Add(new Producto("3","Lapiz Bic",4.42d,3,60));
        pro.productos.Add(new Producto("4","Libreta Norma",11.54d,4,20));
        //lista de productos para imprimir en txt 
        productos.Add(new Producto("1", "Libreta Scribe", 40.52d, 1, 50));
        productos.Add(new Producto("2", "Pluma Negra Bic", 5.53d, 2, 30));
        productos.Add(new Producto("3", "Lapiz Bic", 4.42d, 3, 60));
        productos.Add(new Producto("4", "Libreta Norma", 11.54d, 4, 20));
        
       
        
        //permite imprimir el txt y crear el archivo
        ProductoDB.ProductosTXTOUT(@"Producto.txt", productos);
        Console.WriteLine("Datos guardados en formato txt");
        Console.WriteLine("--------------------------------");
        List<Producto> ProductoINT = ProductoDB.ProductosTXTIN(@"Producto.txt");
        foreach(Producto PT in ProductoINT)
        {
         Console.WriteLine("{0} {1} {2} {3} {4}",PT.Codigo,PT.Descripcion,PT.Precio,PT.Departamento,PT.Likes);
        }

        //Permite que obtengas el departamento ingresado ,en este caso 4 
        pro.GetDepartment(4);
        //Permite ordenar los 
        pro.OrdenarLikes();

        }
    }
}
