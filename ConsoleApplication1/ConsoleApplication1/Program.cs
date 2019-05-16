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
            //invertir numero
            //int numero = Convert.ToInt32( Console.ReadLine());
            //int invertido = 0;
            //int unidad = numero % 10;
            //numero = numero / 10;
            //invertido = invertido * 10 + unidad;
            //int decena = numero % 10;
            //numero = numero / 10;
            //invertido = invertido * 10 + decena;
            //int centena = numero % 10;
            //numero = numero / 10;
            //invertido = invertido * 10 + centena;
            //Console.WriteLine("La suma es {0}", (unidad + decena + centena));
            //Console.WriteLine("El invertido es {0}", invertido);

            //encontrar el mayor de un numero
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int numero3 = Convert.ToInt32(Console.ReadLine());
            //int numero4 = Convert.ToInt32(Console.ReadLine());
            //int mayor = 0;
            //if (numero1 > numero2 && numero1 > numero3 && numero1 > numero4)
            //    mayor = numero1;
            //else if (numero2 > numero1 && numero2 > numero3 && numero2 > numero4)
            //    mayor = numero2;
            //else if (numero3 > numero1 && numero3 > numero2 && numero3 > numero4)
            //    mayor = numero3;
            //else if (numero4 > numero1 && numero4 > numero2 && numero4 > numero3)
            //    mayor = numero4;
            //Console.WriteLine("El mayor de todos es {0}",mayor);

            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int numero3 = Convert.ToInt32(Console.ReadLine());
            //int numero4 = Convert.ToInt32(Console.ReadLine());
            //int mayor = 0;
            //if (numero1 > mayor)
            //    mayor = numero1;
            //if (numero2 > mayor)
            //    mayor = numero2;
            //if (numero3 > mayor)
            //    mayor = numero3;
            //if (numero4 > mayor)
            //    mayor = numero4;
            //Console.WriteLine("El mayor de todos es {0}", mayor);

            //calcular el primer mayor y segundo mayor
            //int mayor = 0;
            //int segundoMayor = 0;
            //int numero;
            //string message;
            //do
            //{
            //    Console.WriteLine("Ingrese un numero");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //    if (numero > mayor)
            //    {
            //        segundoMayor = mayor;
            //        mayor = numero;
            //    }
            //    else if (numero > segundoMayor)
            //    {
            //        segundoMayor = numero;
            //    }                    
            //} while (numero > 0);

            //message = mayor != 0 ? string.Format("El mayor es {0} el segundo mayor es {1}",
            //    mayor, segundoMayor):"No se ingresaron datos validos";
            //Console.WriteLine(message);

            //dado un intervalo mostrar los multiplos de un numero en el rango
            //int limiteInferior = Convert.ToInt32(Console.ReadLine());
            //int limiteSuperior = Convert.ToInt32(Console.ReadLine());
            //int numeroMultiplo = Convert.ToInt32(Console.ReadLine());
            //if(limiteInferior % numeroMultiplo != 0)
            //    limiteInferior = ((limiteInferior/numeroMultiplo) + 1) * numeroMultiplo;

            //for (; limiteInferior <= limiteSuperior; limiteInferior = limiteInferior + numeroMultiplo)
            //{
            //    Console.WriteLine(limiteInferior);
            //}

            //encontrar la mayor repeticion
            int cantidadMayor = 0;
            int numeroMayor = 0;
            int cantidad = 1;
            int anteriorNumero = 0;
            int numero;
            do
            {
                numero = Convert.ToInt32(Console.ReadLine());
                //if (numero == anteriorNumero)
                //{
                //    cantidad++;
                //    numeroMayor = numero;
                //}
                //else
                //{
                //    cantidad = 1;
                //}
                cantidad = numero == anteriorNumero ? cantidad + 1 : 1;
                if (cantidad > cantidadMayor)
                {
                    cantidadMayor = cantidad;
                    numeroMayor = numero;
                }
                anteriorNumero = numero;
            } while (numero > 0);
            Console.WriteLine("el numero {0} se repitio {1}", numeroMayor, cantidadMayor);
        }
    }
}
