using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Integruotos_programavimo_aplinkos.helper
{
    class ScreenManager
    {
        public ScreenManager()
        {
            menu();
        }

        public void printResults(List<Student> students)
        {
            Console.WriteLine("{0, 5} {1, 15} {2, 20}", "Vardas", "Pavardė", "Galutinis (Vid.)");
            for (int i = 0; i <= 41; i++)
                Console.Write("-");
            Console.WriteLine("-");
            foreach (var item in students)
            {
                Console.WriteLine("{0, 5} {1, 15} {2, 20}", item.name, item.surname, "Galutinis (Vid.)");

            }
        }

        public void printMenu()
        {

        }

        public void pause()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        public void pauseClear()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public void printHelp()
        {
            Console.WriteLine(Settings.version);
            Thread.Sleep(1000);
            Console.WriteLine("help - shows general help information");
            Console.WriteLine("help addstudent");
            pauseClear();
        }

        public void addStudent()
        {
            Console.WriteLine("Please enter student name and surname");
            var commands = Console.ReadLine().Split(" ");

        }

        public void menu()
        {
            printHelp();
            bool running = true;
            while (running)
            {
                switch (Console.ReadLine())
                {
                    case "add":
                        Console.WriteLine("jam");
                        break;
                    case "exit":
                        running = false;
                        break;
                    case "help":
                        printMenu();
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Bad request");
                        break;
                }
            }
        }

    }
}
