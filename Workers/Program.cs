using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkersLibary;

namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Добро пожаловать в нашу компанию.");
            Console.WriteLine("Сейчас Вам будет предложен список вакансий, свободных на данный момент.");
            Vacancies vacancy = new Vacancies();
            Console.WriteLine(vacancy);
            Console.ReadLine();
        }
    }
}
