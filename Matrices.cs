using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrincipal
{
    public  class Matrices
    {
        public void Matrice()
        {
            const int filas = 2;
            const int columnas = 3;

            int [,] matriz = new int[filas, columnas];

            matriz[0, 0] = 100;
            matriz[0, 1] = 200;
            matriz[0, 2] = 300;
            matriz[1, 0] = 400;
            matriz[1, 1] = 500;
            matriz[1, 2] = 600;

            Console.WriteLine("Matriz bidimensional");
            Console.WriteLine("Valor fila 0 columna 0: " + matriz[0,0]);
            Console.WriteLine("Valor fila 0 columna 1: " + matriz[0,1]);
        }
        public void MatriceSimplificada()
        {
            int [,] matriz = {
                { 100, 200, 300 },
                { 400, 500, 600 }
            };
            Console.WriteLine("Matriz bidimensional");
            Console.WriteLine("Valor fila 0 columna 0: " + matriz[0,0]);
            Console.WriteLine("Valor fila 0 columna 1: " + matriz[0,1]);
        }
        public void MatriceIterar()
        {
            int[,] matriz = {
                { 100, 200, 300 },
                { 400, 500, 600 }
            };
            Console.WriteLine("Iteramos Matriz");

            for(int ren = 0; ren < matriz.GetLength(0); ren++)
            {
                for(int col = 0; col < matriz.GetLength(1); col++)
                {
                    Console.WriteLine($"Matriz [{ren},{col}]=  {matriz[ren, col]}");
                }
                Console.WriteLine("-------------------");
            }
        }
        public void MatriceIntroducirDatos()
        {
            Console.WriteLine("Proporciona el numero de filas de la matriz: ");
            var filas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Proporciona el numero de columnas de la matriz: ");
            var columnas = Convert.ToInt32(Console.ReadLine());
            
            int[,] matriz = new int[filas, columnas];

            for (int ren = 0; ren < filas; ren++)
            {
                for (int col = 0; col < columnas; col++)
                {
                    Console.WriteLine($"Proporciona el valor para la posicion [{ren},{col}]: ");
                    matriz[ren, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine(" Iteramos Matriz:");
            for (int ren = 0; ren < matriz.GetLength(0); ren++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    Console.WriteLine($"Matriz [{ren},{col}]=  {matriz[ren, col]}");
                }
                Console.WriteLine("-------------------");
            }
        }
    }
}
