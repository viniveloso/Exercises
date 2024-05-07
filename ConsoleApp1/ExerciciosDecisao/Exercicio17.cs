using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio17
    {
        public void Bissexto()
        {
            Console.WriteLine("Digite o ano para saber se ele é bissexto: ");
            var ano = Convert.ToInt32(Console.ReadLine());

            if (ano % 4 == 0) 
            {
                Console.WriteLine("O ano " + ano + " é bissexto");
            }
            else
            {
                Console.WriteLine("O ano não é bissexto");
            }
        }
    }
}
