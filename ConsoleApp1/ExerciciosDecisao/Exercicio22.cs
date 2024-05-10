using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio22
    {
        public void ParOuImpar()
        {
            Console.WriteLine("Digite um numero inteiro para descobrir se é par ou impar: ");
            var numero = Convert.ToInt32(Console.ReadLine());

            var a = numero % 2;

            if (a == 1)
            {
                Console.WriteLine("O numero é impar");
            }
            if (a == 0)
            {
                Console.WriteLine("O numero é par");
            }
        }
    }
}
