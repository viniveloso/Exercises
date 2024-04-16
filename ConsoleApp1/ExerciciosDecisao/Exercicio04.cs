using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio04
    {
        public void VogalOuConsoante()
        {
            Console.WriteLine("Digite uma letra: ");
            char letra = Console.ReadKey().KeyChar;
            letra = char.ToUpper(letra);

            if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
            {
                Console.WriteLine("\nVocê digitou uma vogal");
            }
            else if (!char.IsLetter(letra))
            {
                Console.WriteLine("\nVocê digitou um numero ou caracter especial");
            }
            else
            {
                Console.WriteLine("\nVocê digitou uma consoante");
            }
        }
    }
}
