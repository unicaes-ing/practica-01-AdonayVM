using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica1
{
    class Ej3
    {
        static void Main(string[] args)
        {
            double num1, num2, suma, resta, multi, divi;
            Console.WriteLine("Ingrese un número decimal:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro número decimal:");
            num2 = Convert.ToDouble(Console.ReadLine());
            suma = num1 + num2;
            resta = num1 - num2;
            multi = num1 * num2;
            divi = num1 / num2;
            Console.WriteLine("La suma de ambos números es: {0}", Math.Round(suma, 1));
            Console.WriteLine("La resta de ambos números es: {0}", Math.Round(resta));
            Console.WriteLine("La multiplicación de ambos números es: {0}", Math.Round(multi));
            Console.WriteLine("La división de ambos números es: {0}", Math.Round(divi));
            Console.ReadKey();
        }
    }
}
