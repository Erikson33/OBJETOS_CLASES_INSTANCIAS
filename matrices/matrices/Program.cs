using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabla = new string[3, 2];
            tabla[0, 0] = "erikson";
            tabla[0, 1] = "alex";
            tabla[1, 0] = "pedro";
            tabla[1, 1] = "carlos";
            tabla[2, 0] = "julio";
            tabla[2, 1] = "juan";
            imprimirmatriz(tabla);
            Console.ReadKey();
        }


            public static void imprimirmatriz(string[,] matriz)
        {
            var filas = matriz.GetLength(0);
            var columnas = matriz.GetLength(1);
            var sb = new StringBuilder();
            var tmpfila = new string[matriz.GetLength(0)];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    tmpfila[j] = matriz[i, j];
                }
                sb.AppendLine(string.Join("\t \t \t", tmpfila));
                sb.AppendLine("");
            }
            Console.WriteLine(sb.ToString());
        }

    }
        
 }