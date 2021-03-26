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
 
            do
            {
               Console.WriteLine("Presione las teclas que requiere: ");
               teclas= Console.ReadLine();
               Console.WriteLine("\r");

               Console.WriteLine("Las teclas que escribio son: " + teclas);
               Console.WriteLine("\r");
               
               Console.WriteLine("Para finalizar el programa, debe ingresar la letra 'x'");
               Console.WriteLine("\r");

               teclas = Console.ReadLine();   
            } 
            while (teclas.ToUpper () != "X");
        }

    }
}
