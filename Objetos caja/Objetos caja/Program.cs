using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_caja
{
    class Program
    {
        static void Main(string[] args)
        {
            caja caja1 = new caja(10, 15, 10);
            caja1.MostrarDatos1();
            caja caja2 = new caja(20, 25, 20, "negro");
            caja2.MostrarDatos2();
            caja caja3 = new caja(30, 35, 30, "rojo", "solapa");
            caja3.MostrarDatos3();
            caja caja4 = new caja(40, 45, 40, "cafes", "tapa");
            caja4.MostrarDatos4();
            Console.ReadKey();
        }
    }
    public class caja
    {
        public caja(double altura, double ancho, double profundidad)
        {
            this.altura = altura;
            this.ancho = ancho;
            this.profundida = profundidad;
            this.color = color;
        }
        public caja(double altura, double ancho, double profundidad, string color)
        {
            this.altura = altura;
            this.ancho = ancho;
            this.profundida = profundidad;
            this.color = color;
        }
        public caja(double altura, double ancho, double profundidad, string color, string estructura)
        {
            this.altura = altura;
            this.ancho = ancho;
            this.profundida = profundidad;
            this.color = color;
            this.estructura = estructura;

            if (color == "rojo" || material == "metal")
            {
                material = "metal";
                dqladoabre = "a la derecha";

            }
            else if (color == "cafes" || material == "carton")
            {
                material = "carton";
                dqladoabre = "arriba";
            }
            else
            {
                material = "no asignado";
                dqladoabre = "no asignado";
            }
        }
        private string Empresa_ = " LOS CUATES";
        public string color { get; set; }
        public double altura { get; set; }
        public double ancho { get; set; }
        public double profundida { get; set; }
        public string estructura { get; set; }
        public string dqladoabre { get; }
        public string material { get; }

        public void MostrarDatos1()
        {
            Console.WriteLine("CAJA 1\n" + "Altura: " + altura + "\nAncho: " + ancho + "\nProfundidad: " + profundida);
            Console.WriteLine();
        }
        public void MostrarDatos2()
        {
            Console.WriteLine("CAJA 2 \n" + "Altura: " + altura + "\nAncho: " + ancho + "\nProfundidad: " + profundida + "\ncolor: " + color);
            Console.WriteLine();
        }
        public void MostrarDatos3()
        {
            Console.WriteLine("CAJA 3\n" + "Altura: " + altura + "\nAncho: " + ancho + "\nProfundidad: " + profundida + "\ncolor: " + color + "\nEstructura: " + estructura + "\nDe que lado abre: " + dqladoabre + "\nMaterial: " + material + "\nEmpresa: " + Empresa_);
            Console.WriteLine();
        }
        public void MostrarDatos4()
        {
            Console.WriteLine("CAJA 4\n" + "Altura: " + altura + "\nAncho: " + ancho + "\nProfundidad: " + profundida + "\ncolor: " + color + "\nEstructura: " + estructura + "\nDe que lado abre: " + dqladoabre + "\nMaterial: " + material + "\nEmpresa: " + Empresa_);
            Console.WriteLine();
        }
    }
}
