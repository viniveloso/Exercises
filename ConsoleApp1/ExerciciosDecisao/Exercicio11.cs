using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio11
    {
        public void AumentoSalarial()
        {
            Console.WriteLine("Digite o valor do seu salario para ser reajustado");
            var salarioAtual = Convert.ToDouble(Console.ReadLine());

            var aumentoPercentual20 = salarioAtual * 0.20;
            var aumento20 = salarioAtual * 1.20;

            var aumentoPercentual15 = salarioAtual * 0.15;
            var aumento15 = salarioAtual * 1.15;

            var aumentoPercentual10 = salarioAtual * 0.10;
            var aumento10 = salarioAtual * 1.10;

            var aumentoPercentual5 = salarioAtual * 0.05;
            var aumento5 = salarioAtual * 1.05;


            if (salarioAtual < 280)
            {
                Console.WriteLine("O seu salario é: " + salarioAtual.ToString("C"));
                Console.WriteLine("Você obteve um reajuste de 20%");
                Console.WriteLine("Vôcê obteve um aumento de: " + aumentoPercentual20.ToString("C"));
                Console.WriteLine("O seu salario será: " + aumento20.ToString("C"));
            }

            if (salarioAtual >= 280 && salarioAtual <= 750)
            {
                Console.WriteLine("O seu salario é: " + salarioAtual.ToString("C"));
                Console.WriteLine("Você obteve um reajuste de 15%");
                Console.WriteLine("Você obteve um aumento de: " + aumentoPercentual15.ToString("C"));
                Console.WriteLine("O seu salario será: " + aumento15.ToString("C"));
            }

            if (salarioAtual >= 750 && salarioAtual <= 1500)
            {
                Console.WriteLine("O seu salario é: " + salarioAtual.ToString("C"));
                Console.WriteLine("Você obteve um reajuste de 10%");
                Console.WriteLine("Você obteve um aumento de: " + aumentoPercentual10.ToString("C"));
                Console.WriteLine("O seu salario será: " + aumento10.ToString("C"));
            }

            if (salarioAtual > 1500)
            {
                Console.WriteLine("O seu salario é: " + salarioAtual.ToString("C"));
                Console.WriteLine("Você obteve um reajuste de 5%");
                Console.WriteLine("Você obteve um aumento de: " + aumentoPercentual5.ToString("C"));
                Console.WriteLine("O seu salario será: " + aumento5.ToString("C"));
            }

        }
    }
}
