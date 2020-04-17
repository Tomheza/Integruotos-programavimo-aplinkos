using Integruotos_programavimo_aplinkos.helper;
using Integruotos_programavimo_aplinkos.LinkedList;
using Integruotos_programavimo_aplinkos.Queue;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Integruotos_programavimo_aplinkos
{
    class Program
    {
        // Regular lists
        public static List<Student> good_guys = new List<Student>();
        public static List<Student> bad_guys = new List<Student>();

        // Linkedlists
        public static LinkedList<StudentLinkedList> good_guys_LinkedList = new LinkedList<StudentLinkedList>();
        public static LinkedList<StudentLinkedList> bad_guys_LinkedList = new LinkedList<StudentLinkedList>();

        //Queue
        public static Queue<StudentQueue> good_guys_Queue = new Queue<StudentQueue>();
        public static Queue<StudentQueue> bad_guys_Queue = new Queue<StudentQueue>();

        public static Stopwatch watch;

        public static void NewTimer()
        {
            if(Settings.debug_timers)
                watch = Stopwatch.StartNew();
        }

        public static void StopTimer(string variable)
        {
            if(Settings.debug_timers)
            {
                watch.Stop();
                var ms = watch.Elapsed.Milliseconds;
                var sec = watch.Elapsed.Seconds;
                var min = watch.Elapsed.Minutes;
                Console.WriteLine();
                Console.Write(" ");
                for (int i = 0; i < 59; i++)
                    Console.Write("-");
                Console.WriteLine();
                Console.WriteLine("| {0, 29} {1, 29}", variable, "|");
                Console.Write(" ");
                for (int i = 0; i < 59; i++)
                    Console.Write("-");
                Console.WriteLine();
                if (ms > 0)
                    Console.WriteLine("| {0, -57} |", "Elapsed miliseconds: " + ms);
                if (sec > 0)
                    Console.WriteLine("| {0, -57} |", "Elapsed seconds: " + sec);
                if (min > 0)
                    Console.WriteLine("| {0, -57} |", "Elapsed minutes: " + min);
                Console.Write(" ");
                for (int i = 0; i < 59; i++)
                    Console.Write("-");
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.Title = Settings.program_title;
            Console.WriteLine();
            Console.Write(" ");
            for (int i = 0; i < 59; i++)
                Console.Write("-");
            Console.WriteLine();
            Console.WriteLine("| {2, 10} {0} {1, 14}", "Please choose the type of program", "|", "");
            Console.Write(" ");
            for (int i = 0; i < 59; i++)
                Console.Write("-");
            Console.WriteLine();
            Console.WriteLine("| {0, -57} |", "1. List<T>");
            Console.WriteLine("| {0, -57} |", "2. LinkedList<T>");
            Console.WriteLine("| {0, -57} |", "3. Queue<T>");
            for (int i = 0; i < 59; i++)
                Console.Write("-");
            Console.WriteLine();
            Console.Write(" -> ");

            switch(Console.ReadLine())
            {
                case "1":
                    ScreenManager screen = new ScreenManager();
                    break;
                case "2":
                    ScreenManagerLinkedList screenLinkdeList = new ScreenManagerLinkedList();
                    break;
                case "3":
                    ScreenManagerQueue screenQueue = new ScreenManagerQueue();
                    break;
                default:
                    Console.WriteLine("Bloga komanda..");
                    Main(args);
                    break;
            }
        }

    }
}
