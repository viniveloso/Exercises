using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio05
    {
        public void MediaAluno()
        {
            Console.WriteLine("Digite sua primeira nota: ");
            var nota1 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Digite sua sgunda nota: ");
            var nota2 = Convert.ToInt64(Console.ReadLine());

            var media = (nota1 + nota2) / 2;

            if(media >= 7)
            {
                Console.WriteLine("Sua nota foi: "+media);
                Console.WriteLine("Aprovado");
            }
            else if (media < 7)
            {
                Console.WriteLine("Sua nota foi: " + media);
                Console.WriteLine("Reprovado");
            }
            else if (media == 10)
            {
                Console.WriteLine("Sua nota foi: " + media);
                Console.WriteLine("Aprovado com distinção");
            }

        }
    }
}
