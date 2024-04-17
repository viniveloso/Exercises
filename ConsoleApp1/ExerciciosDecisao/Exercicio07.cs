using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio07
    {
        public void MaiorEMenor()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var numero1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            var numero2 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            var numero3 = Convert.ToInt64(Console.ReadLine());

            var numeroMaior = numero1;

            var numeroMenor = numero2;

            if(numero1 < numeroMenor)
            {
                numeroMenor = numero1;
            }
            if(numero3 < numeroMenor)
            {
                numeroMenor=numero3;
            }

            if (numero2 > numeroMaior)
            {
                numeroMaior = numero2;
            }
            if (numero3 > numeroMaior)
            {
                numeroMaior = numero3;
            }

            Console.WriteLine("O numero maior é: " + numeroMaior);
            Console.WriteLine("O numero menor é: " + numeroMenor);


        }
    }
}
