using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OperacionesBasicasMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, resultado= 0.0M;
            byte opcion;

            // Desplegamos el Menu
            Console.WriteLine("Opcion 1");
            Console.WriteLine("Opcion 2");
            Console.WriteLine("Opcion 3");
            Console.WriteLine("Opcion 4");

            // indicamos al usuario escoger una opcion
            Console.Write("Por Favor escoja una opcion:  ");
            opcion = Convert.ToByte(Console.ReadLine());


            // indicamos al usuario ungrear el primer valor
            Console.Write("Por favor ingresa el el primer numero:  ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            // indicamos al usuario ungrear el primer valor
            Console.Write("Por favor ingresa el segundo numero:  ");
            num2 = Convert.ToDecimal(Console.ReadLine());
            
            

            //Suma
            if (opcion == 1)
            {
                resultado = num1 + num2;
            }
            //Resta
            if (opcion == 2)
            {
                resultado = num1 - num2;
            }
            //Multiplicacion
            if(opcion == 3)
            {
                resultado = num1 * num2;
            }
            //Division
            if ((opcion == 4))
            {
                try
                {
                    resultado = num1 / num2;

                    if (num1 == 0 || num2 == 0)
                    {
                        Console.WriteLine("No se pueden dividir números entre cero");
                    }
                    else
                    {
                        Console.WriteLine("El resultado es {0}", resultado);
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("No se pueden dividir números entre cero");
                }




            }




        }
    }
}
