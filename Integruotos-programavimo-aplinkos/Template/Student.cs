using System;
using System.Collections.Generic;
using System.Text;

namespace Integruotos_programavimo_aplinkos
{
    class Student : Grades
    {
        public string name { get; set; }
        public string surname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Student name</param>
        /// <param name="surname">Student surname</param>
        /// <param name="grade">Student laboratory grade</param>
        /// <param name="exam">Student exam grade</param>
        /// <param name="grades">Grades list</param>
        public Student(string name, string surname, double grade, double exam, List<double> grades)
        {
            if (!string.IsNullOrEmpty(name))
                this.name = name;
            
            if(!string.IsNullOrEmpty(surname))
                this.surname = surname;
            
            if(grade >= 0)
                this.grade = grade;
            
            if(exam >= 0)
                this.exam = exam;

            if(grades != null)
            {
                this.grades = grades;

                foreach (var item in grades)
                    this.grade += item;

                this.grade /= grades.Count;
            }
        }
    }
}
