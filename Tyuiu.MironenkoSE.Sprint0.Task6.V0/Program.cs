using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MironenkoSE.Sprint0.Task6.V0.Lib;
namespace Tyuiu.MironenkoSE.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = { 1, 2, 3, 4, 5};
            Console.Write("Сумма элементов массива = "  + DataService.AdditionArray(numsArray));

            Console.Write("Разность элементов массива = " + DataService.SubstractionArray(numsArray));

            Console.Write("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
