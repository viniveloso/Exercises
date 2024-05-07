using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio15
    {
        public void Triangulo()
        {
            Console.WriteLine("Digite 3 lados de um triangulo: ");
            Console.WriteLine("Primeiro lado: ");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo lado: ");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Terceiro lado: ");
            var c = Convert.ToInt32(Console.ReadLine());

            var soma1 = a + b;
            var soma2 = b + c;
            var soma3 = a + c;

            if (soma1 > c && soma2 > a && soma3 > b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Triângulo Equilátero"); //Iguais
                }
                else if (a != b && a != c && c != b)
                {
                    Console.WriteLine("Triângulo Escaleno"); //Diferentes
                }
                else                
                {
                    Console.WriteLine("Triângulo Isósceles"); //Dois iguais e um diferente
                }
            }
        }
    }
}
