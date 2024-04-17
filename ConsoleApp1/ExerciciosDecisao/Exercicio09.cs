using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio09
    {
        public void Decrescente()
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("Digite um número: ");
            numeros.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Digite um número: ");
            numeros.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Digite um número: ");
            numeros.Add(Convert.ToInt32(Console.ReadLine()));

            numeros.Sort((a, b) => b.CompareTo(a));

            foreach (int numero in numeros)
            {
                Console.WriteLine("");
                Console.WriteLine(numero);
            }
        }
    }
}
