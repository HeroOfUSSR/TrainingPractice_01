using System;

namespace IAA_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Комплиментарная программа V 1.03");
            Console.WriteLine("Чтобы закончить повышать себе самооценку, введите exit");
            Console.WriteLine("");

            string exit = "open";
            string input;
            Random rnd = new Random();

            while (exit != "exit")
            {
                string[] nice = new string[] { "Вы прекрасны", "Вы очаровательны", "Вы умны", "Вы стройны", "Вы в хорошей форме", "Вы отлично выглядите" };

                Console.WriteLine(nice[rnd.Next(0, nice.Length)]);

                input = Console.ReadLine();
                exit = input.ToLower();


            }
        }
    }
}
