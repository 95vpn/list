using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Object> lista = new List<Object>();
            List<String> lista2 = new List<String>();
            lista.Add(32);
            lista.Add("Alex");
            lista.Add('a');
            lista.Add(true);
            lista.Add("Alex");
            lista.Add(false);
            lista.Add("Alex");
            //lista.Remove(32);
            /*
            lista.ForEach(item =>
            {
                Console.WriteLine(item);
            });
            */
            lista.Insert(2, "Joel");
            //lista.Clear();
            lista.Reverse();
            Console.WriteLine(lista.Contains(329));
            //Console.WriteLine(lista.LastIndexOf("Alex", 3));
            //lista.LastIndexOf("Alex")
            //Console.WriteLine(lista.IndexOf(32,0,4));
            foreach(var item in lista)
            {
                Console.WriteLine(item);
            }

            /*
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            
            */
            /*
            int j = 0;

            for (; ; )
            {
                if(j < lista.Count)
                {
                    Console.WriteLine(lista[j]);
                    j++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(lista.Count());
            */
        }
    }
}
