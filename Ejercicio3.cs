using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrincipal
{
    public class Ejercicio3
    {

        public void Ejercicio()
        {
            const int edadMinima = 18;

            Console.WriteLine("Proporciona tu edad: ");
            var edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= edadMinima)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else if (edad < 0)
            {
                Console.WriteLine("Edad erronea");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
        }

        public void Ejercicio2()
        {
            Console.WriteLine("Proporciona dia de la semana (1-7): ");
            var dia = Convert.ToInt32(Console.ReadLine());

            if (dia == 1)
                Console.WriteLine("Lunes");
            else if (dia == 2) 
                Console.WriteLine("Martes");
            else if (dia == 3)
                Console.WriteLine("Miercoles");
            else if (dia == 4)
                Console.WriteLine("Jueves");
            else if (dia == 5)
                Console.WriteLine("Viernes");
            else if (dia == 6)
                Console.WriteLine("Sabado");
            else if (dia == 7)
                Console.WriteLine("Domingo");
            else
                Console.WriteLine("Dia no valido");
        }
    }
}
