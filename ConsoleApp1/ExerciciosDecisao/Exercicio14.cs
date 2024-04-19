using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio14
    {
        public void MediaSemestre()
        {
            Console.WriteLine("Digite sua primeira nota: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua primeira nota: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());

            var media = nota1 + nota2 / 2;

            if (media > 9.0 && media < 10.0)
            {
                Console.WriteLine("Sua primeira nota: " + nota1);
                Console.WriteLine("Sua segunda nota: " + nota2);
                Console.WriteLine("Sua media: " + media);
                Console.WriteLine("Conceito: A");
                Console.WriteLine("Aprovado!");
            }

            if (media > 7.5 && media < 9.0)
            {
                Console.WriteLine("Sua primeira nota: " + nota1);
                Console.WriteLine("Sua segunda nota: " + nota2);
                Console.WriteLine("Sua media: " + media);
                Console.WriteLine("Conceito: B");
                Console.WriteLine("Aprovado!");
            }

            if (media > 6.0 && media < 7.5)
            {
                Console.WriteLine("Sua primeira nota: " + nota1);
                Console.WriteLine("Sua segunda nota: " + nota2);
                Console.WriteLine("Sua media: " + media);
                Console.WriteLine("Conceito: C");
                Console.WriteLine("Aprovado!");
            }

            if (media > 4.0 && media < 6.0)
            {
                Console.WriteLine("Sua primeira nota: " + nota1);
                Console.WriteLine("Sua segunda nota: " + nota2);
                Console.WriteLine("Sua media: " + media);
                Console.WriteLine("Conceito: D");
                Console.WriteLine("Reprovado!");
            }

            if (media < 4.0)
            {
                Console.WriteLine("Sua primeira nota: " + nota1);
                Console.WriteLine("Sua segunda nota: " + nota2);
                Console.WriteLine("Sua media: " + media);
                Console.WriteLine("Conceito: E");
                Console.WriteLine("Reprovado!");
            }
        }
    }
}
