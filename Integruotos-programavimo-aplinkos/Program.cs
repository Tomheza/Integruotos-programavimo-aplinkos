using Integruotos_programavimo_aplinkos.helper;
using System;

namespace Integruotos_programavimo_aplinkos
{
    class Program
    {
        static void Main(string[] args)
        {
            ScreenManager screen = new ScreenManager();
            screen.printResults(new System.Collections.Generic.List<Student>());
        }

    }
}
