//using System;

using System.Runtime.InteropServices.Marshalling;
using ProeyctoPrincipal;

namespace ProyectoPrincipal
{
    class ClasePrimcipal
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Menu");
            Console.WriteLine("1.- Conceptos Basicos");
            Console.WriteLine("2.- Ejercicio 1");

            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Conceptos conceptos = new Conceptos();
                    conceptos.ConceptosBasicos();

                    break;
                case 2:
                    Ejercicio1 ejercicio = new Ejercicio1();
                    ejercicio.Ejercicio();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}