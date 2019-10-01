using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double n1, n2, n3, n4, r;
            Console.Write("Digite o nome do aluno:");
            nome = Console.ReadLine();
            Console.Write("Digite a 1° nota:");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a 2° nota: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a 3° nota:");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Digite a 4° nota: ");
            n4 = int.Parse(Console.ReadLine());
            r= n1 + n2 + n3 + n4;
            r = r / 4;
            if (r>7)
            {
                Console.Write(nome + " aprovado com media " + r);
            }
            else
            {
                Console.Write(nome + " reprovado com media " + r);

            }

            Console.ReadKey(); 
        }
    }
}
