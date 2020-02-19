using System;
using System.Collections.Generic;
using System.Text;

namespace Integruotos_programavimo_aplinkos
{
    class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public Grades grades;
        public double ExamGrade
        {
            get
            {
                if(grades != null)
                {
                    return grades.exam;
                }

                return -1;
            }
            set
            {
                grades.exam = value;
            }
        }
        public double Grade
        {
            get
            {
                if (grades != null)
                {
                    return grades.grade;
                }

                return -1;
            }
            set
            {
                grades.grade = value;
            }
        }
        public Student()
        {

        }
        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public Student(string name, string surname, double grade, double exam)
        {
            this.name = name;
            this.surname = surname;
            grades.grade = grade;
            grades.exam = exam;
        }

    }
}
