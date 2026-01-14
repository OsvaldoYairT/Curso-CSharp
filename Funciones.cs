using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrincipal
{
    public  class Funciones
    {
        public void LongitudCadena()
        {
            var cadena = "Hola, este es un ejemplo de funcion que retorna un valor.";
            Console.WriteLine($"Largo cadena: {cadena.Length}");

            for(int i=0; i <cadena.Length; i++)
            {
                Console.WriteLine($"Caracter {i} - {cadena[i]}");
            }
        }

        public void SubCadena()
        {
            var cadena = "Hola, este es un ejemplo de funcion que retorna un valor.";
            var subcadena = cadena.Substring(18, 7);
            Console.WriteLine($"Subcadena: {subcadena}");
        }

        public void ConcatenarCadenas()
        {
            var cadena1 = "Hola, ";
            var cadena2 = "mundo!";
            var resultado = string.Concat(cadena1, cadena2);
            Console.WriteLine($"Cadenas concatenadas: {resultado}");

            int numero1 = 20;
            int numero2 = 24;
            var resultado2 = string.Concat("El resultado de la suma es: ", (numero1 + numero2).ToString());

        }

        public void ConvertirMayusculasMinusculas()
        {
            var cadena = "Hola, este es un ejemplo de funcion que retorna un valor.";
            var mayusculas = cadena.ToUpper();
            var minusculas = cadena.ToLower();
            Console.WriteLine($"Mayusculas: {mayusculas}");
            Console.WriteLine($"Minusculas: {minusculas}");
        }

        public void ReemplazarCaracteres()
        {
            var cadena = "Hola, este es un ejemplo de funcion que retorna un valor.";
            var nuevaCadena = cadena.Replace("funcion", "metodo");
            Console.WriteLine($"Cadena original: {cadena}");
            Console.WriteLine($"Cadena modificada: {nuevaCadena}");
        }

        public void BuscarCaracteres()
        {
            var cadena = "Hola, este es un ejemplo de funcion que retorna un valor.";
            var indice = cadena.IndexOf("ejemplo");
            if (indice >= 0)
            {
                Console.WriteLine($"La palabra 'ejemplo' se encuentra en el indice: {indice}");
            }
            else
            {
                Console.WriteLine("La palabra 'ejemplo' no se encuentra en la cadena.");
            }
        }

        public void DividirCadenas()
        {
            var cadena = "Hola,este,es,un,ejemplo,de,funcion,que,retorna,un,valor";
            var partes = cadena.Split(',');
            Console.WriteLine("Cadenas divididas:");
            foreach (var parte in partes)
            {
                Console.WriteLine(parte);
            }
        }

        public void EliminarEspacios()
        {
            var cadena = "   Hola, este es un ejemplo de funcion que retorna un valor.   ";
            var cadenaTrim = cadena.Trim();
            Console.WriteLine($"Cadena original: '{cadena}'");
            Console.WriteLine($"Cadena sin espacios: '{cadenaTrim}'");
        }

        public void InsertarCadena()
        {
            var cadena = "Hola, este es un ejemplo de funcion que retorna un valor.";
            var nuevaCadena = cadena.Insert(18, "simple ");
            Console.WriteLine($"Cadena original: {cadena}");
            Console.WriteLine($"Cadena modificada: {nuevaCadena}");
        }

        public void CompararCadenas()
        {
            var cadena1 = "Hola, este es un ejemplo de funcion que retorna un valor.";
            var cadena2 = "Hola, este es un ejemplo de funcion que retorna un valor.";
            var sonIguales = string.Equals(cadena1, cadena2);
            Console.WriteLine($"¿Las cadenas son iguales? {sonIguales}");
        }

        public void FormatearCadenas()
        {
            var nombre = "Juan";
            var edad = 30;
            var cadenaFormateada = string.Format("Mi nombre es {0} y tengo {1} años.", nombre, edad);
            Console.WriteLine(cadenaFormateada);
        }

        public void ConvertirCadenaNumero()
        {
            //Una forma
            var cadenaNumero = "12345";
            if (int.TryParse(cadenaNumero, out int numero))
            {
                Console.WriteLine($"La cadena '{cadenaNumero}' convertida a numero es: {numero}");
            }
            else
            {
                Console.WriteLine($"No se pudo convertir la cadena '{cadenaNumero}' a numero.");
            }

            //Dos forma
            int resultado = Convert.ToInt32(cadenaNumero);
            Console.WriteLine($"Conversion usando Convert.ToInt32: {resultado}");
        }

        public void ConvertirNumeroCadena()
        {
            int numero = 67890;
            var cadenaNumero = numero.ToString();
            Console.WriteLine($"El numero {numero} convertido a cadena es: '{cadenaNumero}'");
        }


        public void NumeroAleatorio()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101); // Genera un número aleatorio entre 1 y 100
            Console.WriteLine($"Número aleatorio generado: {numeroAleatorio}");
        }

        public void ValorAbsoluto()
        {
            int numeroNegativo = -50;
            int valorAbsoluto = Math.Abs(numeroNegativo);
            Console.WriteLine($"El valor absoluto de {numeroNegativo} es: {valorAbsoluto}");
        }

        public void RedondearNumero()
        {
            double numero = 5.67;
            double numeroRedondeado = Math.Round(numero);
            Console.WriteLine($"El número {numero} redondeado es: {numeroRedondeado}");
        }
    }
}
