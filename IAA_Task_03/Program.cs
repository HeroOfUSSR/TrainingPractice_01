using System;

namespace IAA_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "aboba";
            string input;


            for (int i = 0; i<3; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Введите пароль:");

                input = Console.ReadLine();
                if (pass == input)
                {
                    Console.WriteLine("Секретная фраза (Распространение этой конфиденциальной информации строго запрещено)");
                    break;
                }
                else
                {
                    Console.WriteLine("Пароль неверный");
                }

             

            }
        }
    }
}
