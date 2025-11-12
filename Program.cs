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
            Console.WriteLine("3.- Ejercicio 2");

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
                case 3:
                    Ejercicio2 ejercicio2 = new Ejercicio2();
                    ejercicio2.Ejercicio();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}