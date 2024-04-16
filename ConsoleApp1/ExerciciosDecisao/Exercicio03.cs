using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio03
    {
        public void FouM()
        {
            Console.WriteLine("Digite F ou M para identificar seu sexo");
            var sexo = Console.ReadLine();

            if(sexo != null)
            {
                if (sexo.ToUpper() == "F")
                {
                    Console.WriteLine("Sexo feminino");
                }
                else if (sexo.ToUpper() == "M")
                {
                    Console.WriteLine("Sexo Masculino");
                }
                else
                {
                    Console.WriteLine("Sexo invalido");
                }
            }            
        }
    }
}
