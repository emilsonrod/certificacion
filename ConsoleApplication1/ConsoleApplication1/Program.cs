using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = Convert.ToInt32( Console.ReadLine());
            int invertido = 0;
            int unidad = numero % 10;
            numero = numero / 10;
            invertido = invertido * 10 + unidad;
            int decena = numero % 10;
            numero = numero / 10;
            invertido = invertido * 10 + decena;
            int centena = numero % 10;
            numero = numero / 10;
            invertido = invertido * 10 + centena;
            Console.WriteLine("La suma es {0}", (unidad + decena + centena));
            Console.WriteLine("El invertido es {0}", invertido); 
        }
    }
}
