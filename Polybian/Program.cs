using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polybian
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Нажмите С, если хотите зашифровать сообщение или D, если расшифровать");
                if (Console.ReadKey().Key != ConsoleKey.D)
                {
                    Console.WriteLine("Введите сообщение: ");
                    DecryptPolybian();
                }
                else if (Console.ReadKey().Key != ConsoleKey.C)
                {
                    Console.WriteLine("Введите сообщение: ");
                    CryptPolybian();
                }
                
                Console.WriteLine("Нажмите Esc для завершения работы программы или Enter для продолжения");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static void CryptPolybian()
        {
            char[,] rus =
            {
                {'А', 'Б', 'В', 'Г', 'Д', 'Е'},
                {'Ё', 'Ж', 'З', 'И', 'Й', 'К'},
                {'Л', 'М', 'Н', 'О', 'П', 'Р'},
                {'С', 'Т', 'У', 'Ф', 'Х', 'Ц'},
                {'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь'},
                {'Э', 'Ю', 'Я', ' ', '.', ','},
            };

            string message = Console.ReadLine();
            string message2 = "";

            for (int i = 0; i < message.Length; i++)
            {
                if (((message[i] >= 'A') && (message[i] <= 'Z')) || ((message[i] >= 'a') && (message[i] <= 'z')))
                {
                    Console.WriteLine("Пишите на русском языке");
                    break;
                }
                else
                {
                    for (int j = 0; j < rus.GetLength(0); j++)
                    {
                        for (int k = 0; k < rus.GetLength(1); k++)
                        {
                            if ((j == 5) && (Char.ToUpper(rus[j, k]) == message[i]))
                                message2 += Char.ToUpper(rus[j - 5, k]);
                            else if ((j == 5) && (Char.ToLower(rus[j, k]) == message[i]))
                                message2 += Char.ToLower(rus[j - 5, k]);
                            else if (Char.ToUpper(rus[j, k]) == message[i])
                                message2 += Char.ToUpper(rus[j + 1, k]);
                            else if (Char.ToLower(rus[j, k]) == message[i])
                                message2 += Char.ToLower(rus[j + 1, k]);
                        }
                    }
                }
            }
            Console.WriteLine(message2);
        }

        static void DecryptPolybian()
        {
            char[,] rus =
            {
                {'А', 'Б', 'В', 'Г', 'Д', 'Е'},
                {'Ё', 'Ж', 'З', 'И', 'Й', 'К'},
                {'Л', 'М', 'Н', 'О', 'П', 'Р'},
                {'С', 'Т', 'У', 'Ф', 'Х', 'Ц'},
                {'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь'},
                {'Э', 'Ю', 'Я', ' ', '.', ','},
            };

            string message = Console.ReadLine();
            string message2 = "";

            for (int i = 0; i < message.Length; i++)
            {
                if (((message[i] >= 'A') && (message[i] <= 'Z')) || ((message[i] >= 'a') && (message[i] <= 'z')))
                {
                    Console.WriteLine("Пишите на русском языке");
                    break;
                }
                else
                {
                    for (int j = 0; j < rus.GetLength(0); j++)
                    {
                        for (int k = 0; k < rus.GetLength(1); k++)
                        {
                            if ((j == 0) && (Char.ToUpper(rus[j, k]) == message[i]))
                                message2 += Char.ToUpper(rus[j + 5, k]);
                            else if ((j == 0) && (Char.ToLower(rus[j, k]) == message[i]))
                                message2 += Char.ToLower(rus[j + 5, k]);
                            else if (Char.ToUpper(rus[j, k]) == message[i])
                                message2 += Char.ToUpper(rus[j - 1, k]);
                            else if (Char.ToLower(rus[j, k]) == message[i])
                                message2 += Char.ToLower(rus[j - 1, k]);
                        }
                    }
                }
            }
            Console.WriteLine(message2);
        }
    }
}
