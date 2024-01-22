using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Operacion objop = new Operacion();
            //Console.WriteLine($"5.2 * 9.1 = {objop.multiplicacion(5.2, 9.1)}");

            Console.Write("Introduce un numero");
            objop.Parametro1= Double.Parse(Console.ReadLine());

            Console.Write("Introduce un numero");
            objop.Parametro2 = Double.Parse(Console.ReadLine());

            Console.Write("El resultado es: " +  objop.multiplicacion());

            Console.ReadLine();
        }
    }
}
