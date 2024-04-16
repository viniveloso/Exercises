using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosSequencial
{
    public class Exercicio14
    {
        public void Peixe()
        {
            Console.WriteLine("Digite o peso do peixe: ");
            var peso = Convert.ToDouble(Console.ReadLine());

            var excesso = 0.0;
            const double taxa = 4.0;
            var multa = 0.0;

            if (peso > 50)
            {
                excesso = peso - 50;
                multa = excesso * taxa;
                Console.WriteLine("O valor da multa é: " + multa);
            }
            else
            {
                Console.WriteLine("Dentro do peso permitido.");
            }
        }
    }
}
