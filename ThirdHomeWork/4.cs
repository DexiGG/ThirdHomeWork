using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Home
{
   //4.	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его значению. Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
		//3 3 3
    //4 4 4 4
    //5 5 5 5 5
    //6 6 6 6 6 6
    //7 7 7 7 7 7 7
    class Program
    {
        static void Main(string[] args)
        {
            bool isInt;
            int numberA, numberB;
            Console.WriteLine("Введите числа А и В. (A < B)");
            do
            {
                Console.Write("A: ");
                isInt = int.TryParse(Console.ReadLine(), out numberA);
                if (!isInt) Console.WriteLine("Не корректное число");

            } while (!isInt);

            do
            {
                Console.Write("B: ");
                isInt = int.TryParse(Console.ReadLine(), out numberB);
                if (!isInt || numberB < numberA) Console.WriteLine("Не корректное число");

            } while (!isInt || numberB < numberA);

            Console.Clear();
            Console.WriteLine("A: {0};\tB: {1}\n", numberA, numberB);

            for(;numberA <= numberB; numberA++)
            {
                for(int i = 0; i < numberA; i++)
                {
                    Console.Write(numberA + " ");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
