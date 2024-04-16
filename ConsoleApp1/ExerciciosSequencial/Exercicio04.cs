using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosSequencial
{
    public class Exercicio04
    {
        public void MediaSemestre()
        {
            Console.WriteLine("Digite sua nota do primeiro bimestre: ");
            var nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua nota do segundo bimestre: ");
            var nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua nota do terceiro bimestre: ");
            var nota3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua nota do quarto bimestre: ");
            var nota4 = Convert.ToInt32(Console.ReadLine());


            var media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("Sua média é: " + media);
        }
    }
}
