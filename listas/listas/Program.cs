using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(4);
            lista.Add(8);
            lista.Add(10);
            lista.Add(12);
            lista.Add(5);

            foreach(int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
