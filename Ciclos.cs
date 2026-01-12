using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrincipal
{
    public class Ciclos
    {

        public void CicloWhile()
        {
            int contador = 0;
            int repeticiones = 5;
            while (contador < repeticiones)
            {
                Console.WriteLine("Buenos días.... " + contador);
                contador++;
            }
        }

        public void CicloWhileNumer()
        {
            var contador = 0;
            var maximo = 5;

            while (contador < maximo)
            {
                Console.WriteLine("El numero es: " + contador);
                contador++;
            }
        }

        public void CicloDoWhile()
        {
            int numero = 0;
            do
            {
                Console.WriteLine("Proporciona un valor positivo: ");
                numero = Convert.ToInt32(Console.ReadLine());
                
            } while (numero <= 0);

            Console.WriteLine("Valor positivo: " + numero);
        }
        public void CicloFor()
        {
            for (int contador = 0; contador < 5; contador++)
            {
                Console.WriteLine("Buenos díoas.... " + contador);
            }
        }
    }
}
