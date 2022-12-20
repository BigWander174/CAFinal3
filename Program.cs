using CA_3_Final;
using System.Linq;
using System;

namespace CA_3_Final
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите логическое выражение: ");
            string logicalInput = Console.ReadLine();

            Console.WriteLine(new CellMachine().Cycle(logicalInput));


            Console.WriteLine("Введите числа для расчета суммы: ");
            string input = Console.ReadLine();

            var numbers = input.Split("+").Select(number => number.ToEightBitBinary()).ToArray();

            var summator = new Summator(numbers);
            summator.Work();

            Console.WriteLine(summator.Result);
        }
    }
}