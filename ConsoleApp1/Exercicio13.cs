using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio13
    {
        public void IMC()
        {
            Console.WriteLine("Digite sua altura: ");
            var altura = Convert.ToDouble(Console.ReadLine());

            var pesoIdealHomem = (72.7 * altura) - 58;
            var pesoIdealMulher = (62.1 * altura) - 44.7;

            Console.WriteLine("\nQual é o seu sexo? (Digite 'M' para masculino ou 'F' para feminino)");
            char sexo = char.ToUpper(Console.ReadKey().KeyChar);

            if (sexo == 'M')
            {
                Console.WriteLine("\nO seu peso ideal é: " + pesoIdealHomem);
            }
            else if (sexo == 'F')
            {
                Console.WriteLine("\nO seu peso ideal é: " + pesoIdealMulher);
            }
            else
            {
                Console.WriteLine("\nSexo não reconhecido.");
            }
        }
    }
}
