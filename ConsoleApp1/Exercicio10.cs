using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Exercicio10
    {
        public void Fahrenheit()
        {
            Console.WriteLine("Digite a temperatura em Celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double f = c * 9 / 5 + 32;

            Console.WriteLine("A temperatura em Fahrenheit é: "+f);
        }
    }
}
