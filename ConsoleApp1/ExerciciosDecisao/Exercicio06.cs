using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio06
    {
        public void TresNumeros()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var numero1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            var numero2 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            var numero3 = Convert.ToInt64(Console.ReadLine());

            var numeroMaior = numero1;

            if (numero2 > numeroMaior)
            {
                numeroMaior = numero2;
            }
            if (numero3 > numeroMaior)
            {
                numeroMaior = numero3;
            }

            Console.WriteLine("O numero maior é: " + numeroMaior);
            


        }
    }
}
