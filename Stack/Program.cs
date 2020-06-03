using System;

namespace Stack
{
    public class Stack<T>
    {
        readonly int m_Size;
        int m_StackPointer = 0;
        public T[] m_Items;
        public Stack() : this(100)
        {

        }
        public Stack (int size)
        {
            m_Size = size;
            m_Items = new T[m_Size];
        }
        public void Push(T item)
        {
            if (m_StackPointer >= m_Size)
            {
                Console.WriteLine("Error StackOverFlow");
            }
            else
            {
                m_Items[m_StackPointer] = item;
                m_StackPointer++;
            }
        }
        public T Pop()
        {
            m_StackPointer--;
            
            if (m_StackPointer >= 0)
            {
                return m_Items[m_StackPointer];
            }
            else
            {
                m_StackPointer = 0;
                throw new InvalidOperationException("Cannot pop an empity stack");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack <string> Pila = new Stack <string>();
            Pila.Push("12");
            Pila.Push("2");
            Pila.Push("4");
            Pila.Push("5");

            foreach(var item in Pila.m_Items)
            Console.WriteLine(item);

            Console.WriteLine(Pila.Pop());
            Console.WriteLine(Pila.Pop());
            Console.WriteLine(Pila.Pop());

            foreach(var item in Pila.m_Items)
            Console.WriteLine(item);
        }
    }
}