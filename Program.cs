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
            Console.WriteLine("5.- Ejercicio 3");
            Console.WriteLine("6.- Ciclos");
            Console.WriteLine("7.- Ejercicio 4");
            Console.WriteLine("8.- Arreglos");
            Console.WriteLine("9.- Matrices");

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
                case 6:
                    Console.WriteLine("Ciclos");
                    Ciclos ciclos = new Ciclos();
                    ciclos.CicloWhile();
                    ciclos.CicloWhileNumer();
                    ciclos.CicloDoWhile();
                    ciclos.CicloFor();
                    break;
                case 7:
                    Console.WriteLine("Ejercicio 7");
                    Ejercicio4 ejercicio4 = new Ejercicio4();
                    ejercicio4.Ejercicio();
                    break;
                case 8:
                    Console.WriteLine("Arreglos");
                    Arreglo arreglo = new Arreglo();
                    arreglo.Arreglos();
                    arreglo.ArregloDeclarativo();
                    arreglo.ArregloFor();
                    arreglo.ArreglosValore();
                    break;
                case 9:
                    Console.WriteLine("Matrices");
                    Matrices matrices = new Matrices();
                    matrices.Matrice();
                    matrices.MatriceSimplificada();
                    matrices.MatriceIterar();
                    matrices.MatriceIntroducirDatos();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}