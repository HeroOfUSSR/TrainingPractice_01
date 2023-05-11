using System;

namespace IAA_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool deal;

            Console.WriteLine("Добро пожаловать в магазин");

            Console.WriteLine("Стоимость кристаллов: 15 золотых монет");

            int crystalPrice = 15;

            Console.WriteLine("Что у нас по финансам?");
            int gold = int.Parse(Console.ReadLine());

            Console.WriteLine("Сколько кристалов хотим купить?");
            int crystalCount = int.Parse(Console.ReadLine());

            deal = gold >= crystalCount * crystalPrice;
            crystalCount *= Convert.ToInt32(deal);
            gold -= crystalCount * crystalPrice;

            Console.WriteLine($"У вас осталось золота {gold} и кристаллов {crystalCount}");



        }
    }
}
