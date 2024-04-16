using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio02
    {
        public void PositivoOuNegativo()
        {
            Console.WriteLine("Digite um número (positivo ou negativo): ");
            var numero = Console.ReadLine();

            if(int.TryParse(numero, out int numero2))
            {
                if (numero2 > 0)
                {
                    Console.WriteLine("O numero é positivo");
                }
                else if (numero2 == 0)
                {
                    Console.WriteLine("O numero é neutro");
                }
                else
                {
                    Console.WriteLine("O numero é negativo");
                }
            }
            else
            {
                Console.WriteLine("Você não digitou um número");
            }            
        }
    }
}
