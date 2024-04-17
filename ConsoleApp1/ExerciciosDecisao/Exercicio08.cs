using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio08
    {
        public void ProdutoBarato()
        {
            Console.WriteLine("Digite o valor do primeiro produto: ");
            var produto1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo produto: ");
            var produto2 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digite o valor do terceiro produto: ");
            var produto3 = Convert.ToInt64(Console.ReadLine());

            var produtoBarato = produto1;

            if(produto2 < produtoBarato)
            {
                produtoBarato = produto2;
            }
            if(produto3 < produtoBarato)
            {
                produtoBarato = produto3;
            }

            Console.WriteLine("Você pode comprar o produto de valor: "+ produtoBarato.ToString("C"));
        }
    }
}
