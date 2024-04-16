using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosSequencial
{
    public class Exercicio06
    {
        public void AreaCirculo()
        {
            Console.WriteLine("Digite o raio: ");
            var raio = Convert.ToInt32(Console.ReadLine());

            var area = 3.14 * (raio * raio);

            Console.WriteLine("A área é: " + area);
        }
    }
}
