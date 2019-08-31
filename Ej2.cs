using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica1
{
    class Ej2
    {
        static void Main(string[] args)
        {
            string nombre = "Elí Adonay Valencia Machado", cargo = "Administrador de ventas", correo = "adonayvm32♦gmail.com", fecha = "10 de Septiembre de 2001";
            int edad = 38;
            double sueldo = 650;
            Console.WriteLine("Nombre: {0} \nEdad: {1} \nCorreo: {2} \nCargo: {3} \nSueldo: {4} \nFecha de contratación: {5}", nombre, edad, correo, cargo, sueldo, fecha);
            Console.ReadKey();
        }
    }
}
