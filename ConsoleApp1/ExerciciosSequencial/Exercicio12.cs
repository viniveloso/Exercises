using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosSequencial
{
    public class Exercicio12
    {
        public void PesoIdeal()
        {
            Console.WriteLine("Digite sua altura: ");
            var altura = Convert.ToDouble(Console.ReadLine());

            var pesoIdeal = 72.7 * altura - 58;

            Console.WriteLine("O seu peso ideal é: " + pesoIdeal);
        }
    }
}
