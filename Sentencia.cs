using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrincipal
{
    public class Sentencia
    {
        public void SentenciasIf()
        {
            Console.WriteLine("Proporciona un numero: ");
            var numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }
        }

        public void Sentenciaifelseifelse()
        {
            Console.WriteLine("Proporciona un numero: ");
            var numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
            else
            {
                Console.WriteLine("El numero es cero");
            }
        }

        public void SentenciaTernaria()
        {
            Console.WriteLine("Proporciona un numero: ");
            var numero = Convert.ToInt32(Console.ReadLine());
            var resultado = (numero > 0) ? "El numero es positivo" : "El numero es negativo o cero";
            Console.WriteLine(resultado);
        }

        public void SentenciaSwitch()
        {
            Console.WriteLine("Proporciona un dia de la semana (1-7): ");
            var dia = Convert.ToInt32(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Dia no valido");
                    break;
            }
        }
    }
}
