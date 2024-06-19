using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammUnderPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triesCount = 3;

            string password = "password12345qwerty";
            string protectInformation = "Город под подшвой, а программа под паролем";

            for (int i = 0; i < triesCount; i++)
            {
                Console.WriteLine("Введите пароль:");
                string userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine($"Пароль принят.\n" +
                        $"{protectInformation}");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильный пароль,\n" +
                        "У вас осталось " + (triesCount - (i + 1)) + " попыток");
                }
            }
        }
    }
}



