using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio09
    {
        public void Celsius()
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            var f = Convert.ToInt32(Console.ReadLine());

            var c = 5 * ((f - 32) / 9);

            Console.WriteLine("A temperatura em Celsius é: "+c);
        }
    }
}
