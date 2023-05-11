using System;
using System.Threading;

namespace IAA_Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random rnd = new Random();
            int enemyHPs = rnd.Next(350, 800);
            int enemyDMG;
            int playerHPs = rnd.Next(200, 350);
            bool Playthrough = true;
            string skill;
            int bladecon = 0;
            int bladeDmg = 120;
            int dashDmg = 90;

            Console.WriteLine("Вы прибываете в Мидтаун");
            Console.Write("Загрузка.");
            Thread.Sleep(1200);
            Console.Write('.');
            Thread.Sleep(1200);
            Console.WriteLine('.');
            Thread.Sleep(1200);
            Console.WriteLine("");

            Console.WriteLine("На вас прыгнул Уинстон, приготовьтесь к бою\n \nВаши варианты действий: \n" +
                "0. lifesteal - Пассивная способность, возвращающая вам 10% от нанесённого противнику урона\n" +
                "1. dash - Рывок наносящий 90 урона.\n" +
                "2. shuriken - Наносит 40-120 урона.\n" +
                "3. dragonblade - Обнажает клинок дракона, позволяет 2 раза использовать slash.\n" +
                "4. slash - Можно использовать только после обнажения клинка с dragonblade, наносит 120 урона.\n" +
                "5. nanoblade - Усиливает следующую атаку с slash в полтора раза, дарует дополнительное здоровье, " +
                "урон становится 180, хп увеличивается на 40-80 ед.\n" +
                "Если клинок не находится в боевом состоянии - усиливает следующий dash на 20 урона, восстанавливает 60-120 хп. \n" 
                );

            while (Playthrough)
            {
                enemyDMG = rnd.Next(15, 90);
                Console.WriteLine($"\nСтатистика Уинстона: \n Здоровье: {enemyHPs} , Урон: {enemyDMG} \n\nСтатистика игрока: \n Здоровье: {playerHPs} \n");
    


                if (enemyHPs <= 0 && playerHPs > 0)
                {
                    Playthrough = false;
                    Console.WriteLine("\nУинстон погиб, вы победили");
                }
                else if (playerHPs <= 0 && enemyHPs > 0)
                {
                    Playthrough = false;
                    Console.WriteLine("\nИгрок погиб, вы проиграли");
                }
                else if (playerHPs <= 0 && enemyHPs <= 0)
                {
                    Playthrough = false;
                    Console.WriteLine("\nУинстон и игрок оба пали на поле брани, ничья");
                }
                else
                {
                    Console.Write("Выберите скилл, который будете использовать: ");
                    skill = Console.ReadLine();
                    switch (skill)
                    {
                        case "1":
                            {
                                enemyHPs -= 90;
                                playerHPs += dashDmg * 10/100;
                                Console.WriteLine($"\nУинстон получает {dashDmg }единиц урона. Вы восстановили себе {dashDmg * 10/100} единиц здоровья.");
                                playerHPs -= enemyDMG;
                                Console.Write($"\nУинстон атаковал игрока электричеством, вы потеряли {enemyDMG} здоровья\n");
                                dashDmg = 90;
                            }
                            break;
                        case "2":
                            {
                                int shurikenDmg = rnd.Next(40, 120);
                                enemyHPs -= shurikenDmg;
                                playerHPs += shurikenDmg * 10/100;
                                Console.WriteLine($"\nУинстон получает {shurikenDmg} единиц урона от броска сюрикенов.");
                                playerHPs -= enemyDMG + rnd.Next(10, 20);
                                Console.Write($"\nУинстон швырнул игрока об стену, вы потеряли {enemyDMG} здоровья\n");
                                Console.WriteLine($"\nВы восстановили {shurikenDmg * 10 / 100}. Ваше текущее здоровье равно: {playerHPs}");
                            }
                            break;
                        case "3":
                            {
                                bladecon = 2;
                                Console.WriteLine("\nВы обнажили клинок дракона. Достал нож - режь!");
                                playerHPs -= enemyDMG + rnd.Next(5, 15);
                                Console.Write($"\nУинстон ударил игрока лапой, вы потеряли {enemyDMG} здоровья\n");

                            }
                            break;
                        case "4":
                            {
                                if (bladecon > 0)
                                {
                                    bladecon--;
                                    playerHPs += bladeDmg * 10/100;
                                    enemyHPs -= bladeDmg;
                                    Console.WriteLine($"\nВы взмахнули мечом и нанесли этим {bladeDmg} урона");
                                    playerHPs -= enemyDMG;
                                    Console.Write($"\nУинстон атаковал вас пушкой Тесла, вы потеряли {enemyDMG} здоровья\n");
                                    bladeDmg = 120;
                                }
                                else
                                {
                                    Console.WriteLine("\n Чтобы орудовать мечом, необходимо его достать!");
                                }

                            }
                            break;
                        case "5":
                            {
                                if (bladecon > 0)
                                {
                                    bladeDmg += 60;
                                    playerHPs += rnd.Next(40, 80);
                                    Console.WriteLine($"\nВаш клинок светится от нано усиления");
                                    playerHPs -= enemyDMG;
                                    Console.Write($"\nУинстон атаковал вас пушкой Тесла, вы потеряли {enemyDMG} здоровья\n");
                                }
                                else
                                {
                                    dashDmg += 20;
                                    playerHPs += rnd.Next(80, 120);
                                    Console.WriteLine($"\nВы чувствуете как сквозь вас струится незамутнённый POWER");
                                    playerHPs -= enemyDMG;
                                    Console.Write($"\nУинстон атаковал вас пушкой Тесла, вы потеряли {enemyDMG} здоровья\n");
                                }

                            }
                            break;

                        default:
                            Console.WriteLine("Некорректный ввод скилла, киберниндзя так не умеет(");
                            break;
                    }

                }
            }
        }
    }
}
