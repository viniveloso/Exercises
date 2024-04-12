using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio11
    {
        public void InteirosEReais()
        {
            Console.WriteLine("Digite um número inteiro: ");
            var numero1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digite um número inteiro: ");
            var numero2 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digite um número quebrado: ");
            var numero3 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Os numeros são: "+numero1 + numero2 + numero3);

            var soma1 = (numero1 * 2) + (numero2 / 2);
            Console.WriteLine("o produto do dobro do primeiro com metade do segundo = "+soma1);

            var soma2 = (numero1 * 3 + numero3);
            Console.WriteLine("a soma do triplo do primeiro com o terceiro = "+soma2);

            var soma3 = Math.Pow(numero3, 3);
            Console.WriteLine("o terceiro elevado ao cubo = "+soma3);


        }
    }
}
