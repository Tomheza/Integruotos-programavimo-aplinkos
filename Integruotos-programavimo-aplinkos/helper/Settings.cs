using System;
using System.Collections.Generic;
using System.Text;

namespace Integruotos_programavimo_aplinkos.helper
{
    public static class Settings
    {
        public static string version { get; set; } = "v0.5";
        public static string program_title { get; set; } = "Integruotos programavimo aplinkos " + version;
        public static bool debug_timers { get; set; } = true;
    }
}
