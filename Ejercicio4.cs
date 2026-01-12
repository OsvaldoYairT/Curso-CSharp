using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrincipal
{
    public class Ejercicio4
    {
        public void Ejercicio()
        {
            var maximo = 5;
            var acomuladorSuma = 0;

            for (int numero = 1; numero <= maximo; numero++)
            {
                Console.WriteLine("(acomuladorSuma + numero) -> " + $"{acomuladorSuma} + {numero}");

                acomuladorSuma += numero;

                Console.WriteLine("suma parcial acumulada: " + acomuladorSuma);
            }
            Console.WriteLine("La suma de los primeros 5 números es: " + acomuladorSuma);

        }
    }
}
