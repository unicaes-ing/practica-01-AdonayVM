using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica1
{
    class Ej4
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un número positivo:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("La raíz cuadrada de su número es: {0}", Math.Sqrt(num));
            }
            else
            {
                Console.WriteLine("El número ingresado no es positivo:");
            }
            Console.ReadKey();
        }
    }
}
