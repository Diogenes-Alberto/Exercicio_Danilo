using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDynamic3107
{

    class Program
    {
        static void Main(string[] args)
        {
            Double[] VetorNotas = new double [4];
            double mediaTemporaria=0;
            List<dynamic> Cadastro = new List<dynamic>();
            String nome, matricula, aprovado,resposta;
            Boolean continuar = true;
            while(continuar)
            {
                Console.WriteLine("Digite o nome d(x) Aluno:");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a matrícula");
                matricula = Console.ReadLine();
                for (int x = 0; x < 4; x++)
                {
                    Console.WriteLine("Digite a "+(x+1)+"ª nota");
                    VetorNotas[x] = Convert.ToDouble( Console.ReadLine());
                    mediaTemporaria += VetorNotas[x];
                }
                mediaTemporaria = Math.Round(mediaTemporaria /4,2);
                if(mediaTemporaria>=7)
                {
                    aprovado = "Aprovado";
                }
                else
                {
                    aprovado = "Reprovado";
                }
                Cadastro.Add(new { Nome = nome, Matricula = matricula,
                    Media = mediaTemporaria, Status=aprovado,
                Notas = new List<Double>() { VetorNotas[0],
                VetorNotas[1], VetorNotas[2], VetorNotas[3] } }); 

                Console.WriteLine("Deseja registra mais um aluno (S)im ou (N)ão:");
                resposta = Console.ReadLine();
                resposta.ToLower();
                
                if(resposta =="n")
                {
                    continuar = false;
                }
                mediaTemporaria = 0;

            }

            Console.WriteLine("Segue a lista dos alunos:");
            Console.WriteLine("--------------------------");

            foreach(var cadastrado in Cadastro)
            {
                Console.WriteLine("Nome: "+cadastrado.Nome);
                Console.WriteLine("Matricula:"+cadastrado.Matricula);
                Console.Write("Notas: ");
                foreach (var valor in cadastrado.Notas)
                {
                    Console.Write(valor+"; ");
                }
                Console.WriteLine("\nMedia: " + cadastrado.Media);
                Console.WriteLine("Status: " + cadastrado.Status);
                Console.WriteLine("--------------------------");
            }
            Console.ReadKey();
        }
    }
}
