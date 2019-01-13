using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdHomeWork
{
    //1.Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. Программа должна сосчитать количество введенных пользователем пробелов.
    class Program
    {
        static void Main(string[] args)
        {
            int countSpaces = 0;
            char Space = ' ';

            while (Space != '.')
            {
                Space = (char)Console.Read();
                if (Space == ' ')
                    countSpaces++;
            }

            Console.WriteLine("Количество введенных пробелов: " + countSpaces);
        }
    }
}
