using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProeyctoPrincipal
{
    public class Ejercicio1
    {
        public void Ejercicio()
        {

            Console.WriteLine("--Proporciona tus datos --");

            Console.Write("Proporciona tu nombre: ");
            var name = Console.ReadLine();

            Console.Write("Proporciona tu edad: ");
            var edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Proporciona tu sueldo: ");
            var sueldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Eres un empleado de confianza (true/false): ");
            var empleado = Convert.ToBoolean(Console.ReadLine());
            //var empleados = int.Parse(Console.ReadLine()) ;

            //impresion

            Console.WriteLine("Tu datos son los siguiente:");
            Console.WriteLine("Tu nombre es: " + name);
            Console.WriteLine("Tu edad es: " + edad);
            Console.WriteLine($"Tu sueldo es: {sueldo:C2}" ); //Currency - moneda
            var respuesta = "";
            if (empleado == true) { respuesta = "Si"; } else { respuesta = "No"; }
            Console.WriteLine("es un emplado de confianza : " + respuesta);

           
            
        }
    }
}
