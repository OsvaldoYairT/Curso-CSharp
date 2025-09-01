//using System;

using System.Runtime.InteropServices.Marshalling;
using ProeyctoPrincipal;

namespace ProyectoPrincipal
{
    class ClasePrimcipal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            int x = 20;
            string y = "osvaldo";
            Console.WriteLine($"el valor es : {x}");
            Console.WriteLine("el valor es : " + y);
            Console.WriteLine("el valor es : {0} ", x);

            //Tipos de datos 

            int entero = 20;
            Console.WriteLine($"Mi entero: {entero}");

            long log = 200L;
            Console.WriteLine($"Mi Log: {log}");

            float flotante = 40.5F;
            Console.WriteLine($"Mi Flotante: {flotante}");

            double Double = 15.5;
            Console.WriteLine($"Mi double: {Double}");

            char caracter = 'P';
            Console.WriteLine($"Mi caracter: {caracter}");

            string caracteres = "Palabras";
            Console.WriteLine($"Mis caracteres: {caracteres}");

            bool boleano = true;
            Console.WriteLine($"Mi boleano: {boleano}");


            //Tipos de datos dinamicos 

            var enteros = 34; //no se puede cambair su tipo de dato 
            dynamic dynamic = "texto"; //Se puede cambiar su tipo de dato al igual que su valor 
            Console.WriteLine($"el numero es: {enteros}");
            Console.WriteLine($"el texto  es: {dynamic}");
            Console.WriteLine($"el texto  es: {dynamic}");

            //Convertir tipos de datos 

            //tipo entero a cadena 
            var num = 10;
            var text = "15";
            var text2 = 1;

            var cadenaText = Convert.ToString(num);
            Console.WriteLine($"Mi entero en cadena de texto : {Convert.ToString(cadenaText)}");
            var cadenaNum = Convert.ToInt32(text);
            Console.WriteLine($"Mi entero en cadena de texto : {Convert.ToInt32(cadenaNum)}");
            Console.WriteLine($"Mi string en cadena de bool : {Convert.ToBoolean(text2)}");


            //Constantes
            const int n = 10;
            Console.WriteLine("constante es: " + n);

            //introduccion de datos de usuario
            Console.WriteLine("Proporciona un nombre");
            var nome = Console.ReadLine();
            Console.WriteLine("Tu nombre es: " + nome);


            Console.WriteLine("Proporciona un edad");
            var edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tu edad es: " + edad);

            //Ejercicio

            //Ejercicio1 ejercicio = new Ejercicio1();

            //Operadores aritmeticos
            
            var suma = 3 + 4;
            Console.WriteLine("Suma: " + suma);

            var resta = 8 - 4;
            Console.WriteLine("Resta: " + resta);

            var multiplicacion = 3 * 4;
            Console.WriteLine("Multi: " + multiplicacion);

            var division = 24 / 4;
            Console.WriteLine("Division: " + division);

            var residio = 3 % 4;
            Console.WriteLine("Residuo: " + residio);

            var potencia = Math.Pow(4, 2);
            Console.WriteLine("Potencia: " + potencia);

            //Operadores aritmeticos incremento y decremento 

            var a = 0;
            Console.WriteLine("Antes de incrementar: " + a);
            a++;
            Console.WriteLine("Despues de incrementar: " + a);

            var b = 5;
            Console.WriteLine("Antes de pre-incrementar: " + b);
            ++b;
            Console.WriteLine("Despues de pre-incrementar: " + b);

            var c = 10;
            Console.WriteLine("Antes de decrementar: " + c);
            c--;
            Console.WriteLine("Despues de decrementar: " + c);

            var d = 15;
            Console.WriteLine("Antes de pre-decrementar: " + d);
            --d;
            Console.WriteLine("Despues de pre-decrementar: " + d);

            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i);
                if (i == 10)
                {
                    for (int j = 0; i <= 10; j--)
                    {
                        Console.Write(j);
                    }
                }
            }
        }
    }
}