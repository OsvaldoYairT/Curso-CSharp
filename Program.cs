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
            Console.WriteLine("4.- Sentencias");

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
                case 4:
                    Console.WriteLine("Sentencias if-else");
                    Sentencia sentencia = new Sentencia();
                    sentencia.SentenciasIf();

                    Console.WriteLine("Sentencias if-else");
                    sentencia.Sentenciaifelseifelse();

                    Console.WriteLine("Sentencias Ternaria");
                    sentencia.SentenciaTernaria();

                    break;
                case 5:
                    Console.WriteLine("Ejercicio edad minima");
                    Ejercicio3 ejercicio3 = new Ejercicio3();
                    ejercicio3.Ejercicio();

                    Console.WriteLine("Ejercicio dia de la semana");
                    ejercicio3.Ejercicio2();

                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}