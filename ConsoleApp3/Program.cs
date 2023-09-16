using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static bool IsValid(string binary) //check
        {
            foreach (char c in binary)
            {
                if (c < '0' || c > '5')
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите двоичное число: ");
            string _bNumber = Console.ReadLine();

            if (IsValid(_bNumber))
            {
                foreach (char c in _bNumber)
                {
                    int _number = int.Parse(c.ToString());
                    switch (c)
                    {
                        case '1':
                            Console.WriteLine("Большой палец");
                                break;
                        case '2':
                            Console.WriteLine("Указательный");
                                break;
                        case '3':
                            Console.WriteLine("Средний");
                            break;
                        case '4':
                            Console.WriteLine("Безымянный");
                            break;
                        case '5':
                            Console.WriteLine("Мизинец");
                            break;
                        default:
                            Console.WriteLine("пришелец ^^ ");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Введите другое число");
            }

        }
    }
}
