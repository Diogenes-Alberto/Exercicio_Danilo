using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGama1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Alunos = new string[4];
            Double[,] NotasAlunos = new double[4, 4];
            for (int x=0; x<4;x++)
            {
                Console.WriteLine("Digite o nome d(X) "+(x+1)+"º aluno:");
                Alunos[x] = Console.ReadLine();
                NotasAlunos[x, 3] = 0;
                for(int y=0;y<3;y++)
                {
                    Console.WriteLine("Digite a "+(y+1)+"ª nota:");
                    NotasAlunos[x, y] =Convert.ToDouble(Console.ReadLine());
                }
                NotasAlunos[x, 3] = (NotasAlunos[x, 0]+NotasAlunos[x, 1]+ NotasAlunos[x, 2]) / 3;
            }
            for(int x=0;x<4;x++)
            {
                Console.WriteLine("O Alun(X): "+ Alunos[x] +" obteve a media total de: "+NotasAlunos[x,3]+ " Pontos.\n");
            }
            Console.ReadKey();
        }
    }
}
