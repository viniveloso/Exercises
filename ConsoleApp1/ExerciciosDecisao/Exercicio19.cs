using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio19
    {
        public void Menor1000()
        {
            Console.WriteLine("Digite um numero inteiro menor que 1000: ");
            var numero = Convert.ToInt32(Console.ReadLine());

            var centena = numero / 100;
            var resto = numero % 100;
            var dezena = resto / 10;
            var unidade = resto % 10;

            Console.WriteLine(+centena + " centenas," + dezena + " dezenas e " + unidade + " unidades");
        }
    }
}
