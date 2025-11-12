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
            while (contador < 5)
            {
                Console.WriteLine("Contador es: " + contador);
                contador++;
            }
        }
    }
}
