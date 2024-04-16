using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosSequencial
{
    public class Exercicio03
    {
        public void Soma()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            var numero2 = Convert.ToInt32(Console.ReadLine());

            var soma = numero1 + numero2;

            Console.WriteLine("A soma dos dois números é: " + soma);
        }
    }
}
