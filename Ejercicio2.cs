using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrincipal
{
    public class Ejercicio2
    {

        public void Ejercicio()
        {
            var minimo = 00;
            var maximo = 5;

            Console.WriteLine("Proporciona  un dato entre 0 y 5: ");
            var radio = Convert.ToInt32(Console.ReadLine());
            
            var dentroRango = (radio >= minimo) && (radio <= maximo);
            Console.WriteLine("¿El numero esta dentro del rango? " + dentroRango);
        }
    }
}
