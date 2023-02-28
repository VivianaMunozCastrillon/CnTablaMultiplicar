using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnTablaMultiplicar
{
    internal class Program
    {
        /// <summary>
        /// Nombre:Viviana Muñoz
        /// Fecha:26/02/2023
        /// Descripcion:Este programa solicita un numero y imprime la tabla de multiplicar de ese valor y ademas se cierra si se ingresa el -1.
        /// </summary>
        
        static void Main(string[] args)
        {
            //Solicita dato
            Console.WriteLine("Por favor ingrese un numero");
            int Numero = int.Parse(Console.ReadLine());

            //Condicion
            if (Numero == -1)
            {
                Console.WriteLine("Lo lamento este valor no es permitido");
            }

            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(Numero + "x" + i + "=" + Numero * i);
                }
            }
            Console.ReadKey();

        }
    }
}
