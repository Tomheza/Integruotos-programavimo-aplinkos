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

        #region unused

        //public Grades grades;

        /*public double ExamGrade
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
        */
        #endregion
    }
}
