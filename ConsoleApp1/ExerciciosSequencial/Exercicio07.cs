using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosSequencial
{
    public class Exercicio07
    {
        public void AreaQuadrado()
        {
            Console.WriteLine("Digite a área de um quadrado");
            var quadrado = Convert.ToInt64(Console.ReadLine());

            var area = quadrado * quadrado * 2;

            Console.WriteLine("O Dobro da área desse quadrado é: " + area);
        }
    }
}
