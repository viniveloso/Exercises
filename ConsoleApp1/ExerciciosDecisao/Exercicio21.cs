using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio21
    {
        public void CaixaEletronica()
        {
            Console.WriteLine("Qual o valor do saque?");
            var valor = Convert.ToInt32(Console.ReadLine());

            if (valor < 10 || valor > 600)
            {
                Console.WriteLine("Valor não permitido.");
                return;
            }

            var nota100 = valor / 100;
            var nota50 = (valor % 100) / 50;
            var nota10 = ((valor % 100) % 50) / 10;
            var nota5 = (((valor % 100) % 50) % 10) / 5;
            var nota1 = ((((valor % 100) % 50) % 10) % 5);

            Console.WriteLine("Para sacar a quantidade " + valor);
            Console.WriteLine("O caixa oferece: ");
            Console.WriteLine(+nota100 + " notas de 100, ");
            Console.WriteLine(+nota50 + " notas de 50, ");
            Console.WriteLine(+nota10 + " notas de 10, ");
            Console.WriteLine(+nota5 + " notas de 5, ");
            Console.WriteLine(+nota1 + " notas de 1.");
        }
    }
}
