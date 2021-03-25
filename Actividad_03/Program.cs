using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lea las teclas presionadas y finalice al presionar la tecla “X”.
            string teclas;
            string finalizar;
            do
            {
                Console.WriteLine("Presione las teclas que requiere: ");
                teclas = Console.ReadLine();
                Console.WriteLine("\r");

                Console.WriteLine("Las teclas que escribio son: " + teclas);
                Console.ReadLine();
                Console.WriteLine("\r");

                Console.WriteLine("¿Desea finalizar el programa? (X = No)");
                finalizar = Console.ReadLine();

            } while (finalizar == " x ");
        }

    }
}
