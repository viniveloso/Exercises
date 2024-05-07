using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ExerciciosDecisao
{
    public class Exercicio18
    {
        public void Data()
        {
            Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
            string dataInput = Console.ReadLine();

            if (ValidarData(dataInput))
            {
                Console.WriteLine("Data valida!");
            }
            else
            {
                Console.WriteLine("Data Invalida");
            }

            static bool ValidarData(string data)
            {
                DateTime result;
                return DateTime.TryParseExact(data, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out result);
            }
        }
    }
}
