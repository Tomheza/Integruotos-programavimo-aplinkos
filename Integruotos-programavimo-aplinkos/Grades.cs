using System;
using System.Collections.Generic;
using System.Text;

namespace Integruotos_programavimo_aplinkos
{
    class Grades
    {
        public double grade { get; set; }
        public double exam { get; set; }
        public Grades()
        {

        }

        public Grades(double grade, double exam)
        {
            this.grade = grade;
            this.exam = exam;
        }

 
    }
}
