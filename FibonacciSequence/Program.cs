using System;
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
        public int ValidatedNumber()
        {
            // Declaro la variable number y le asigno un valor inicial
            int number = 0;

            // Solicito por consola un número con unas condiciones
            Console.WriteLine("Por favor , introduzca un número comprendido entre 7 y 22, ambos valores incluidos");

            // 1-  asigno un nuevo valor a number cuyo valor será asignado por entrada de teclado

            //2-  Compruebo que el nuevo valor de number cumpla las condiciones establecidas, en caso contrario, vuelvo a llamar a la misma función para reiniciar el proceso (función recursiva)

            if (int.TryParse(Console.ReadLine(), out number) && (number > 6 || number < 23)) { return number; }
            else
            {
                // Incluyo un return 0 al que nunca se accederá, pues es obligatorio devolver algo en una funcion que no sea void.

                Console.WriteLine("Número incorrecto, por favor escriba un número válido");
                ValidatedNumber();
                return 0;
            }
        }

        // Creo la función principal con la lógica Fibonacci

        public int ReturnFibonnaciSecuence()
        {
        }

        private static void Main(string[] args)
        {
        }
    }
}