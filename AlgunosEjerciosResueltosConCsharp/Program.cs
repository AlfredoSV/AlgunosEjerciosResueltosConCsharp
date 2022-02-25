﻿using System;
using System.Linq;

namespace AlgunosEjerciosResueltosConCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1(5, 3);
            //Ejercicio2(24, 5);
            //Ejercicio3();
            //Ejercicio4();
            Ejercicio5();
        }

        /*1) El usuario tecleará dos números (x e y), y el programa 
        deberá calcular cual es el resultado de su 
        división y el resto de esa división.
        */
        private static void Ejercicio1(decimal x, decimal y)
        {
            var div = Math.Round(x / y, 2);
            var res = x % y;

            Console.WriteLine($"El resultado de la división es:{div}");
            Console.WriteLine($"El resto de la división es:{res}");


        }

        /*2) Crear un programa que pida al usuario dos números enteros y 
        diga si el primero es múltiplo del 
        segundo (pista: igual que antes, habrá que ver si el 
        resto de la división es cero: a % b == 0).*/
        private static void Ejercicio2(int x, int y)
        {
            var mult = x % y == 0 ? "es múltipo" : "no es múltiplo";
            Console.WriteLine($"{x} {mult} de {y}");
        }


        /*3) Crear un programa que multiplique dos números enteros de la siguiente forma: pedirá al usuario un 
        primer número entero. Si el número que se que teclee es 0, escribirá en pantalla "El producto de 0 por 
        cualquier número es 0". Si se ha tecleado un número distinto de cero, se pedirá al usuario un segundo 
        número y se mostrará el producto de ambos.
        */
        private static void Ejercicio3()
        {
            int x, y;

            x = Int32.Parse(Console.ReadLine());

            if (x == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier número es 0");
            }
            else
            {
                y = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"El producto de {x} por {y} es:{x * y}");
            }

        }

        /*4) Crear un programa que pida al usuario dos números reales. Si el segundo no es cero, mostrará el 
        resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo número es cero, 
        escribirá “Error: No se puede dividir entre cero”.*/
        public static void Ejercicio4()
        {
            decimal x = 0.00m, y = 0.00m;

            y = Math.Round(decimal.Parse(Console.ReadLine()), 2);

            if (y == 0.00m)
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }
            else
            {
                x = Math.Round(decimal.Parse(Console.ReadLine()), 2);
                Console.WriteLine($"Resultado de divisón de {x} / {y} es:{Math.Round(x / y, 2)}");
            }

        }

        //5) Crear un programa que pida una letra al usuario y diga si se trata de una vocal.
        public static void Ejercicio5()
        {
            var letra = Console.ReadLine().ToLower();

            var vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var esVocal = false;

            if (letra.Length > 1 || letra.Equals(""))
            {
                Console.WriteLine("Solo está permitido ingresar una letra");
            }
            else
            {
                esVocal = vocales.Contains(Convert.ToChar(letra));
                Console.WriteLine($"Es vocal:{esVocal}");
            }

        }
    }
}
