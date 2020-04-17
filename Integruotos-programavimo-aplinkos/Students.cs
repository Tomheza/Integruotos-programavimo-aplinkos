using Integruotos_programavimo_aplinkos.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integruotos_programavimo_aplinkos
{
    class Students
    {

        public void SortStudents()
        {
            try
            {
                Program.good_guys = Program.good_guys.OrderBy(o => o.name).OrderBy(o => o.surname).ToList();
                Program.bad_guys = Program.bad_guys.OrderBy(o => o.name).OrderBy(o => o.surname).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not sort: " + ex);
                Console.WriteLine("Try again? [yes / no]");
                if (Console.ReadLine().Contains("yes"))
                    SortStudents();
            }
        }

        public void AddStudent(Student stud)
        {
            if (Formulas.Galutinis(stud.grade, stud.exam) < 5.0 && !Program.bad_guys.Contains(stud))
            {
                Program.bad_guys.Add(stud);
            }
            else if (Formulas.Galutinis(stud.grade, stud.exam) >= 5.0 && !Program.good_guys.Contains(stud))
            {
                Program.good_guys.Add(stud);
            }
        }

        public void RemoveStudent(string name, string surname)
        {
            foreach (var item in Program.good_guys)
            {
                if(item.name.Equals(name) && item.surname.Equals(surname))
                {
                    Program.good_guys.Remove(item);
                    break;
                }
            }

            foreach (var item in Program.bad_guys)
            {
                if(item.name.Equals(name) && item.surname.Equals(surname))
                {
                    Program.bad_guys.Remove(item);
                    break;
                }
            }
        }
       
        public void AddStudent(string name, string surname, double grade, double exam, List<double> grades)
        {
            try
            {
                Student student = new Student(name, surname, grade, exam, grades);

                if(Formulas.Galutinis(student.grade, student.exam) < 5.0 && !Program.bad_guys.Contains(student))
                {
                    Program.bad_guys.Add(student);
                }
                else if(Formulas.Galutinis(student.grade, student.exam) >= 5.0 && !Program.bad_guys.Contains(student))
                {
                    Program.good_guys.Add(student);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad student data: " + ex);
            }
        }
    }
}
