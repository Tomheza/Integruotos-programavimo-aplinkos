using Integruotos_programavimo_aplinkos.helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Integruotos_programavimo_aplinkos
{
    class Program
    {
        public static List<Student> students = new List<Student>();
        public static List<Student> good_guys = new List<Student>();
        public static List<Student> bad_guys = new List<Student>();
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
            Console.Title = Settings.program_title;
            ScreenManager screen = new ScreenManager();
        }

    }
}
