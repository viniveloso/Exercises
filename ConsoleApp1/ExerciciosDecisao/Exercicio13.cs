using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio13
    {
        public void Semana()
        {
            Console.WriteLine("Digite um numero de 1 a 7: ");
            var numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 1)
            {
                Console.WriteLine("1-Domingo");
            }
            if (numero == 2)
            {
                Console.WriteLine("2-Segunda-Feira");
            }
            if (numero == 3)
            {
                Console.WriteLine("3-Terça-Feira");
            }
            if (numero == 4)
            {
                Console.WriteLine("4-Quarta-Feira");
            }
            if (numero == 5)
            {
                Console.WriteLine("5-Quinta-Feira");
            }
            if (numero == 6)
            {
                Console.WriteLine("6-Sexta-Feira");
            }
            if (numero == 7)
            {
                Console.WriteLine("7-Sabado");
            }
            if (numero > 7)
            {
                Console.WriteLine("Valor Invalido");
            }
        }
    }
}
