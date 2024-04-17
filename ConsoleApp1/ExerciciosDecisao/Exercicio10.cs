using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio10
    {
        public void Turno()
        {
            Console.WriteLine("Digite em qual horario você estuda, sendo: M-matutino, V-Vespertino ou N-Noturno");
            var turno = Console.ReadLine();

            if (turno != null)
            {
                if (turno.ToUpper() == "M")
                {
                    Console.WriteLine("Bom dia!");
                }
                else if (turno.ToUpper() == "V")
                {
                    Console.WriteLine("Boa tarde!");
                }
                else if(turno.ToUpper() == "N")
                {
                    Console.WriteLine("Boa noite!");
                }
                else
                {
                    Console.WriteLine("Valor Inválido!");
                }
            }
        }
    }
}
