using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExpressãoNumerica
{
    class Program
    {
        static void Main(string[] args)
        {
            Double resultado, x, y, d;
            Console.WriteLine("Digite o valor de X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de D:");
            d = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Round((x + y + d + (5 * 77) + 8 - (10 * ((Double)8 / 3))), 2);
            Console.WriteLine("O valor da empressão e: " + resultado);
            Console.ReadKey();
        }
    }
}
