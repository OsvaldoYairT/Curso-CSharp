using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrincipal
{
    public class Arreglo
    {

        public void Arreglos()
        {
            int[] numeros = new int[5];

            numeros[0] = 13;
            numeros[1] = 21;
            numeros[4] = 62;

            Console.WriteLine("Valor 1 Arreglo[0]: " + numeros[0]);
            Console.WriteLine("Valor 2 Arreglo[1]: " + numeros[1]);
            Console.WriteLine("Valor 3 Arreglo[2]: " + numeros[2]);
            Console.WriteLine("Valor 4 Arreglo[3]: " + numeros[3]);
            Console.WriteLine("Valor 5 Arreglo[4]: " + numeros[4]);
        }
        public void ArregloDeclarativo()
        {
            int[] numeros = { 100, 100, 300, 400 };


            Console.WriteLine("Valor 1 Arreglo[0]: " + numeros[0]);
            Console.WriteLine("Valor 2 Arreglo[1]: " + numeros[1]);
            Console.WriteLine("Valor 3 Arreglo[2]: " + numeros[2]);
            Console.WriteLine("Valor 4 Arreglo[3]: " + numeros[3]);
            //Console.WriteLine("Valor 5 Arreglo[4]: " + numeros[4]);
        }
        public void ArregloFor()
        {
            int[] numeros = { 100, 100, 300, 400 };


            Console.WriteLine("Largo arreglo: " + numeros.Length);

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Entero {i} = + {numeros[i]}");
            }

            Console.WriteLine("for each");
            foreach (var numero in numeros)
            {
                Console.WriteLine($"Entero = + {numero}");
            }
        }

        public void ArreglosValore()
        {
            Console.WriteLine("Arreglo de valores");

            Console.WriteLine("Proporciona el tamaño del arreglo: ");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            int[] enteros = new int[tamaño];

            for (int i = 0; i < enteros.Length; i++)
            {
                Console.WriteLine($"Enteros [{i}] = ");
                enteros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Los valores del arreglo son: ");

            for (int i = 0; i < enteros.Length; i++)
            {
                Console.WriteLine($"Enteros [{i}] = {enteros[i]}");
            }
        }
    }
}
