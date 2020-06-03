using System;

namespace Cola
{
	public class Cola < T >
	{
		readonly int m_Size;
		int m_ColaPointer = 0;
		T[] m_Items;
		public Cola() : this(100)
		{}
		public Cola(int size)
		{
			m_Size = size;
			m_Items = new T[m_Size];
		}
		public void Push(T item)
		{
			if (m_ColaPointer >= m_Size)
				throw new StackOverflowException();
			m_Items[m_ColaPointer] = item;
			m_ColaPointer++;
		}
		public T Pop()
		{			
			if (m_ColaPointer > 0)
			{
				T item=m_Items[0];
				for (int i=1; i < m_ColaPointer; i++)
				{
					m_Items[i-1]=m_Items[i];					
				}
				m_ColaPointer--;
				return item;
			}
			else
			{
				m_ColaPointer = 0;
				throw new InvalidOperationException("Stack vacio");
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Cola<string> lista = new Cola<string>(7);
			lista.Push("Prueba");
			lista.Push(" ");
			lista.Push("Del");
			lista.Push(" ");
			lista.Push("Programa");
			lista.Push(" ");
			lista.Push("Cola");
			
			for(int i = 0; i < 7; i++) {
				Console.Write(lista.Pop());
			}
		}
	}
}