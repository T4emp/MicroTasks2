using System;

namespace MicroTasks2
{
    class Program
    {
        public string s1;
        public int i1;
        public float f1, f2, f3;

        static void Main()
        {
            var needToContinue = true;
            while (needToContinue)
            {
                Menu();
                Console.WriteLine("Начать заново? (Ent)");
                var key = Console.ReadKey().Key;
                do
                {
                    if (key == ConsoleKey.Escape)
                    {
                        needToContinue = false;
                    }
                    else if (key != ConsoleKey.Enter)
                    {
                        Console.WriteLine("Неправильная клавиша! Начать заного? (Ent)");
                        key = Console.ReadKey().Key;
                    }
                }
                while (needToContinue && key != ConsoleKey.Enter);
                Console.Clear();
            }
        }

        public static void Menu()
        {
            Program program = new Program();
            Console.WriteLine("Номер задачи: ");
            program.s1 = Console.ReadLine();
            program.i1 = Convert.ToInt32(program.s1);
            switch (program.i1)
            {
                case 1:
                    Ticker();
                    break;
                case 2:
                    Mass();
                    break;
            }
        }

        public static void Ticker()
        {
            Program program = new Program();
            program.f1 = 1;
            program.f2 = 25;
            program.f3 = 12;
            Console.WriteLine($"1. Количество колебаний: {(program.f3 / (program.f1 / program.f2))}");
            program.f2 = 35;
            program.f3 = 7;
            Console.WriteLine($"2. Количество колебаний: {(program.f3 / (program.f1 / program.f2))}");
            Console.WriteLine("Время колебаний: ");
            program.s1 = Console.ReadLine();
            program.i1 = Convert.ToInt32(program.s1);
            program.f2 = 12;
            Console.WriteLine($"3. Количество колебаний: {(program.i1 / (program.f1 / program.f2))}");
        }

        public static void Mass()
        {
            int[] mass = new int[6] {7, 5, 2, 3, 9, 6};
            int temp;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                    }
                }
            }
            Console.WriteLine("После сортировки:");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
        }
    }
}
