using System;
using System.Collections.Generic;
using System.Text;

namespace Integruotos_programavimo_aplinkos.Queue
{
    class GradesQueue
    {
        public double grade { get; set; }
        public double exam { get; set; }
        public Queue<double> grades { get; set; }
    }
}
