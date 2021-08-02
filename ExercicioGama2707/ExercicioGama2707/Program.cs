using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExercicioGama2707
{
    class Program
    {
        static void Main(string[] args)
        {
            //codificaçao feita dia 28/07/2021
            string pedido,copia;
            double precoKG, precoG, total = 0;
            precoKG = 1.50;
            precoG = precoKG / 1000;

            Console.WriteLine("Digite o peso que voce deseja comprar:\n" + "utilize o padrao KG(quilo) ou G(grama)");
            pedido =Console.ReadLine();
            copia = pedido.ToLower();

            if (copia.Contains("kg"))
            {
                copia = copia.Replace("kg", "");
                copia = copia.Trim();
                total = precoKG * Convert.ToDouble(copia);
                Console.WriteLine("Foi solicitado " + pedido + " dando o total de:R$:" + total + " real(is).  \n");
            } else if (copia.Contains("g"))
            {
                copia = copia.Replace("g", "");
                copia = copia.Trim();
                total = precoG * Convert.ToDouble(copia);
                Console.WriteLine("Foi solicitado " + pedido + " dando o total de:R$:" + total + " real(is).  \n");
            }
            else
            {
                Console.WriteLine("Não foi digitado o padrao solicitado.");
            }
            Console.ReadKey();
        }
    }
}
