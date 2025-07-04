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
            lista.Add('a');
            lista.Add(true);
            //lista.Remove(32);
            lista.ForEach(item =>
            {
                Console.WriteLine(item);
            });

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine(lista.Count());
        }
    }
}
