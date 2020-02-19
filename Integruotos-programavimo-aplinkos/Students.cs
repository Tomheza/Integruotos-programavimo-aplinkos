using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integruotos_programavimo_aplinkos
{
    class Students
    {
        public List<Student> students = new List<Student>();

        public void AddStudent(Student stud)
        {
            if(!students.Contains(stud))
                students.Add(stud);
        }

        public void RemoveStudent(string name, string surname)
        {
            foreach (var item in students)
            {
                if (item.name.Equals(name) && item.surname.Equals(surname))
                {
                    students.Remove(item);
                    break;
                }
            }
        }

        public void ChangeExamGrade(string name, string surname, double grade)
        {
            foreach (var item in students)
            {
                if (item.name.Equals(name) && item.surname.Equals(surname))
                {
                    item.ExamGrade = grade;
                    break;
                }
            }
        }

        public void ChangeGrade(string name, string surname, double grade)
        {
            foreach (var item in students)
            {
                if (item.name.Equals(name) && item.surname.Equals(surname))
                {
                    item.Grade = grade;
                    break;
                }
            }
        }

        public void AddStudent(string name, string surname)
        {
            students.Add(new Student(name, surname));
        }

        public void AddStudent(string name, string surname, double grade, double exam)
        {
            students.Add(new Student(name, surname, grade, exam));
        }

        public void ChangeStudentName(string name, string surname, string newname)
        {
            foreach (var item in students)
            {
                if (item.name.Equals(name) && item.surname.Equals(surname))
                {
                    item.name = newname;
                    break;
                }
            }
        }

        public void ChangeStudentSurname(string name, string surname, string newsurname)
        {
            foreach (var item in students)
            {
                if (item.name.Equals(name) && item.surname.Equals(surname))
                {
                    item.surname = newsurname;
                    break;
                }
            }
        }

    }
}
