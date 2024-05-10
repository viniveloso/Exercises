using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio20
    {
        public void NotasParciais()
        {
            Console.WriteLine("Digite sua primeira nota: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua primeira nota: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua primeira nota: ");
            var nota3 = Convert.ToDouble(Console.ReadLine());

            var media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                Console.WriteLine("Sua nota é: "+media);
                Console.WriteLine("Aprovado");
            }
            if (media < 7)
            {
                Console.WriteLine("Sua nota é: " + media);
                Console.WriteLine("Reprovado");
            }
            if (media == 10)
            {
                Console.WriteLine("Sua nota é: " + media);
                Console.WriteLine("Aprovado com Distinção");
            }
        }
    }
}
