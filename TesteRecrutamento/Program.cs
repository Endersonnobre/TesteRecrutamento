using System;
using TesteRecrutamento.src.Entities;

namespace TesteRecrutamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números você quer incluir?");
            int amount = int.Parse(Console.ReadLine());

            FindTarget findTarget = new FindTarget(amount);

            for (int i = 0; i < findTarget.Numbers.Length; i++)
            {
                Console.WriteLine($"Digite o {i+1}ª número");
                findTarget.insertNumber(int.Parse(Console.ReadLine()), i);
            }

            Console.Clear();

            Console.WriteLine($"Digite o número alvo");
            int targert = int.Parse(Console.ReadLine());

            string combinations = findTarget.Find(targert);

            if (string.IsNullOrEmpty(combinations))
            {
                Console.WriteLine("Não há combinações possíveis que deem o número alvo");
            }
            else 
            {
                Console.WriteLine($"As combinações que, somados, dão o número alvo são:\n{combinations}");
            }
            
            
        }
    }
}
