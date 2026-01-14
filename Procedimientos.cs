using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrincipal
{
    public class Procedimientos
    {
        public void Saludar(string mensaje)
        {
            Console.WriteLine("Mensaje: " + mensaje);
        }

        public void Saludo()
        {
            Console.WriteLine("Proporciona el mensaje a mostrar: ");
            string mensaje = Console.ReadLine();

            Saludar(mensaje);
        }

        //funcion de suma 
        public int sumar(int a, int b)
        {
            int suma = a + b;
            return suma;
        }

        public void Suma()
        {
            Console.WriteLine("Proporciona el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Proporciona el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = sumar(num1, num2);
            Console.WriteLine("El resultado de la suma es: " + resultado);
        }

        //Referencia por valor
        public void IncrementarValor(int numero)
        {
            numero = 20;
        }
        public void ReferenciaValor()
        {
            int numero = 10;
            Console.WriteLine("Valor antes de llamar al procedimiento: " + numero);

            IncrementarValor(numero);
            Console.WriteLine("Valor despues de llamar al procedimiento: " + numero);
        }

        //Referencia por referencia
        public void IncrementarReferencia(ref int numero)
        {
            numero = 20;
        }
        public void ReferenciaReferencia()
        {
            int numero = 10;
            Console.WriteLine("Valor antes de llamar al procedimiento: " + numero);

            IncrementarReferencia(ref numero);
            Console.WriteLine("Valor despues de llamar al procedimiento: " + numero);
        }

        //Referencia por Cadena
        public void ModificarCadena(string cadena)
        {
            cadena=" Mundo";
        }
        public void ReferenciaCadena()
        {
            string cadena = "Hola";
            Console.WriteLine("Cadena antes de llamar al procedimiento: " + cadena);

            ModificarCadena(cadena);
            Console.WriteLine("Cadena despues de llamar al procedimiento: " + cadena);
        }
        public void ModificarCadenaRef(ref string cadena)
        {
            cadena=" Mundo";
        }
        public void ReferenciaCadenaref()
        {
            string cadena = "Hola";
            Console.WriteLine("Cadena antes de llamar al procedimiento: " + cadena);

            ModificarCadenaRef(ref cadena);
            Console.WriteLine("Cadena despues de llamar al procedimiento: " + cadena);
        }

        //Referencia de arreglos
        public void ReferenciaArreglo(int[] numero)
        {
            numero[0] = 20;
        }
        public void ReferenciaArreglos()
        {
            int[] numero = { 10 };
            Console.WriteLine("Valor antes de llamar al procedimiento: " + numero);

            ReferenciaArreglo(numero);
            Console.WriteLine("Valor despues de llamar al procedimiento: " + numero);
        }


        //funcion recursiva
        public int Factorial(int numero)
        {
            if (numero == 0)
            {
                return 1;
            }
            else
            {
                return numero * Factorial(numero - 1);
            }
        }
        public void CalcularFactorial()
        {
            Console.WriteLine("Proporciona un numero para calcular su factorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int resultado = Factorial(numero);
            Console.WriteLine("El factorial de " + numero + " es: " + resultado);
        }
    }

}
