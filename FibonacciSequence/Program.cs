﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    internal class Program
    {
        //Creo una función que comprobará el número introducido y lo retornará
        public static int ValidatedNumber()
        {
            // Declaro la variable number 
            int number;

            // Solicito por consola un número con unas condiciones
            Console.WriteLine("Por favor , introduzca un número comprendido entre 7 y 22, ambos valores incluidos");
            Console.WriteLine();

            // 1-  asigno un nuevo valor a number cuyo valor será asignado por entrada de teclado

            //2-  Compruebo que el nuevo valor de number cumpla las condiciones establecidas, en caso contrario, vuelvo a llamar a la misma función para reiniciar el proceso (función recursiva)

            if (int.TryParse(Console.ReadLine(), out number) && (number > 6 && number < 23)) { return number; }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Número incorrecto, debe escribir un número válido");
                Console.WriteLine();

                return ValidatedNumber();
            }
        }

        // Creo la función principal con la lógica Fibonacci

        public static void ReturnFibonnaciSecuence()
        {
            //Asigno a number el valor devuelto de la funcion ValidatedNumber

            int number = ValidatedNumber();


            // Declaro un array con la longitud del number

            int[] fiboArray = new int[number];

            //asigno los valores correspondientes a cada elemento del array

            int fiboNumber = 0;
            int fiboNumberPrev = 1;
            int temp = 0;

            for (int i = 0; i < number; i++)
            {
                fiboArray[i] = fiboNumber;

                //Almaceno el actual valor en la variable temp para no perder su valor
                temp = fiboNumber;

                // Actualizo el valor del próximo número de Fibonacci

                fiboNumber = fiboNumber + fiboNumberPrev;

                //Ahora actualizo el valor del anterior numero de fibonacci, utilizando la variable temp.
                fiboNumberPrev = temp;
            }

            // Creo fiboArrayReverse a partir de fiboArray

            int[] fiboArrayReverse = new int[number];
            int j = 0;

            for (int i = number-1; i >= 0; i--)
            {
                fiboArrayReverse[j] = fiboArray[i];
                j++;
            };

            //!  Muestro Los 2 array separados por el método String.Join
            Console.WriteLine();
            Console.WriteLine("A continuación se muestra la secuencia de Fibonacci con {0} numeros en orden ascendente y descendente:",number);
            Console.WriteLine();
            Console.WriteLine(String.Join(" ", fiboArray));
            Console.WriteLine(String.Join(" ", fiboArrayReverse));


            //Pregunto  al usuario si quierere reiniciar la app o finalizarla
            // Voy a usar ConsoleKeyInfo porque es el tipo que devuelve Console.ReadKey

            Console.WriteLine();
            Console.WriteLine("Pulse cualquier tecla para reiniciar o Escape para salir");
            

            ConsoleKeyInfo pressedKey = Console.ReadKey();

            // Si pulso cualquier boton que no sea el de escape, se limpiara la consola y se volverá a ejecutar el programa, en caso contrario finalizará

            if (pressedKey.Key != ConsoleKey.Escape) {

                Console.Clear();
                ReturnFibonnaciSecuence(); }
            
        }

        private static void Main(string[] args)
        {

            ReturnFibonnaciSecuence();

        }
    }
}