using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio16
    {
        public void RaizSegundoGrau()
        {
            Console.WriteLine("Digite o primeiro valor");
            double a = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("A equação não é de segundo grau");
                return;
            } 

            Console.WriteLine("Digite o segundo valor");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("A equação não possui raizes reais");
                return;
            }
            else if (delta == 0)
            {
                double raiz = -b / (2 * a);
                Console.WriteLine("A equação possui apenas uma raiz real: " + delta);
            }
            else
            {
                double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("A equação possui duas raízes reais: " + raiz1 + " e " + raiz2);
            }
        }
    }
}
