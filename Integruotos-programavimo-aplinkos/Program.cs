using Integruotos_programavimo_aplinkos.helper;
using System;
using System.Collections.Generic;

namespace Integruotos_programavimo_aplinkos
{
    class Program
    {
        public static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Console.Title = Settings.program_title;
            ScreenManager screen = new ScreenManager();
            //screen.printResults(new System.Collections.Generic.List<Student>());
        }

    }
}
