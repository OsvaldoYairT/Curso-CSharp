using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrincipal
{
    public class Conceptos
    {
        public void ConceptosBasicos()
        {
            //Tipos de datos estaticos
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

            decimal Decimal = 15.5m;
            Console.WriteLine($"Mi double: {Decimal}");

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
            Console.WriteLine($"Mi texto en cadena de número : {Convert.ToInt32(cadenaNum)}");
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

            //Oepradores de Asignacion

            //operador igual = es para asignar un valor a una variable
            var numero1 = 10;
            Console.WriteLine("El valor de numero1 es: " + numero1);
            numero1 = 20;
            Console.WriteLine($"el nuevo valor es : {numero1} ");

            numero1 += 5; // numero1 = numero1 + 5
            Console.WriteLine("El valor de numero1 con suma es: " + numero1);

            //operador resta -=
            numero1 -= 3; // numero1 = numero1 - 3
            Console.WriteLine("El valor de numero1 con resta es: " + numero1);

            //operador multiplicacion *=
            numero1 *= 2; // numero1 = numero1 * 2
            Console.WriteLine("El valor de numero1 con multiplicacion es: " + numero1);

            //operador division /=
            numero1 /= 4; // numero1 = numero1 / 4
            Console.WriteLine("El valor de numero1 con division es: " + numero1);

            //operador residuo %=
            numero1 %= 3; // numero1 = numero1 % 3
            Console.WriteLine("El valor de numero1 con residuo es: " + numero1);


            //Operadores relacionales
            var valor1 = 5;
            var valor2 = 6;
            Console.WriteLine("Valor a: " + valor1);
            Console.WriteLine("Valor b: " + valor2);

            //operador de igualdad ==
            var igualdad = valor1 == valor2;
            Console.WriteLine("¿Los valores son iguales? : " + igualdad);

            //operador de diferente que !=
            var diferente = valor1 != valor2;
            Console.WriteLine("¿Los valores son diferentes? : " + diferente);

            //operador mayor que >
            var mayor = valor1 > valor2;
            Console.WriteLine("¿Valor1 es mayor que Valor2? : " + mayor);

            //operador mayor que >=
            var mayorIgual = valor1 > valor2;
            Console.WriteLine("¿Valor1 es mayor que Valor2? : " + mayorIgual);

            //operador menor que <
            var menor = valor1 < valor2;
            Console.WriteLine("¿Valor1 es menor que Valor2? : " + menor);

            //operador menor que <=
            var menorIgual = valor1 <= valor2;
            Console.WriteLine("¿Valor1 es menor o igual que Valor2? : " + menorIgual);

            //Operadores logicos
            var condicion1 = true;
            var condicion2 = false;

            //operador AND &&
            var operadorAND = condicion1 && condicion2;
            Console.WriteLine("El resultado del operador AND es: " + operadorAND);

            //operador OR ||
            var operadorOR = condicion1 || condicion2;
            Console.WriteLine("El resultado del operador OR es: " + operadorOR);

            //operador NOT !
            var operadorNOT = !condicion1;
            var operadorNOT2 = !condicion2;
            Console.WriteLine("El resultado del operador NOT es: " + operadorNOT);
            Console.WriteLine("El resultado del operador NOT es: " + operadorNOT2);

            //Precedencia de operadores
            //1- Parecentecis y corchetes ()
            //2- Operadores uniarios -,++, -- !
            //3- Operadores aritmeticos *, /, %
            //4- Operadores aritmeticos +, -
            //5- Operadores relacionales <, <=, >, >=
            //6- Operadores de igualdad ==, !=
            //7- Operadores logicos AND && y OR ||
            //8- Adignacion =, +=, -=, *=, /=, %=

            //Ejemplo. Se revisa de izquierda a derecha
            var resultado = 12 / 3 + 2 * 3 - 1;
            // Paso 1: division 12 / 3 = 4
            // Paso 2: multiplicación 2 * 3 = 6
            // Paso 3: suma 4 + 6 = 10
            // Paso 4: resta 10 - 1 = 9
            Console.WriteLine("El resultado de la precedencia de operadores es: " + resultado);


        }
    }
}
