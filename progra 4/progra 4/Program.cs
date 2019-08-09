using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progra_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new vector(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 5 });
            Console.WriteLine(v.componentes.ToString()); //1

            Console.WriteLine(v.Dimencion); //2
            v.nombre = "mi vector";
            Console.WriteLine(v.nombre); //3
            //v.recorrido();
            v.recorrido();

            Console.ReadKey();

        }
    }
    class vector
    {

        //explicar por constructor 
        private List<int> _componentes;
        public List<int> componentes
        {
            get
            {
                return _componentes;
            }
        }

        //constructor
        public vector(List<int> componentes)
        {
            _componentes = componentes;
        }

        public int Dimencion { get { return _componentes.Count; } }
        public string nombre { get; set; }

        //public void Remover(int num)
        //{
        //    for (int i = 0;i < _componentes.Count; i++)
        //    {
        //        if (i == num)
        //        {
        //            _componentes.Remove(i);
        //            continue;
        //        }
        //        Console.WriteLine(_componentes[i]);
        //    }
        //}
        public void recorrido()
        {
            for (int i = 0; i < _componentes.Count; i++)
            {
                Console.WriteLine(_componentes[i]);
            }

        }

    }
}
