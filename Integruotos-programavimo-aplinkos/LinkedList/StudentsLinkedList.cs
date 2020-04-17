using Integruotos_programavimo_aplinkos.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integruotos_programavimo_aplinkos.LinkedList
{
    class StudentsLinkedList
    {
        public void SortStudents()
        {
            try
            {
                // bulky but reasonable method... but to much casts....
                var temp = Program.good_guys_LinkedList.ToList();
                temp = temp.OrderBy(o => o.name).OrderBy(o => o.surname).ToList();
                Program.good_guys_LinkedList.Clear();

                foreach (var item in temp)
                {
                    Program.good_guys_LinkedList.AddLast(item);
                }

                temp = Program.bad_guys_LinkedList.ToList();
                temp = temp.OrderBy(o => o.name).OrderBy(o => o.surname).ToList();
                Program.bad_guys_LinkedList.Clear();

                foreach(var item in temp)
                {
                    Program.bad_guys_LinkedList.AddLast(item);
                }

                //clear mem
                temp.Clear();                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not sort: " + ex);
                Console.WriteLine("Try again? [yes / no]");
                if (Console.ReadLine().Contains("yes"))
                    SortStudents();
            }
        }

        public void AddStudent(StudentLinkedList stud)
        {
           
            if (Formulas.Galutinis(stud.grade, stud.exam) < 5.0 && !Program.bad_guys_LinkedList.Contains(stud))
            {
                Program.bad_guys_LinkedList.AddLast(stud);
            }
            else if (Formulas.Galutinis(stud.grade, stud.exam) >= 5.0 && !Program.good_guys_LinkedList.Contains(stud))
            {
                Program.good_guys_LinkedList.AddLast(stud);
            }
        }

        public void RemoveStudent(string name, string surname)
        {
            foreach (var item in Program.good_guys_LinkedList)
            {
                if(item.name.Equals(name) && item.surname.Equals(surname))
                {
                    Program.good_guys_LinkedList.Remove(item);
                }
            }

            foreach (var item in Program.bad_guys_LinkedList)
            {
                if (item.name.Equals(name) && item.surname.Equals(surname))
                {
                    Program.bad_guys_LinkedList.Remove(item);
                }
            }
        }


        public void AddStudent(string name, string surname, double grade, double exam, LinkedList<double> grades)
        {
            try
            {
                StudentLinkedList student = new StudentLinkedList(name, surname, grade, exam, grades);

                if(Formulas.Galutinis(student.grade, student.exam) < 5.0 && !Program.bad_guys_LinkedList.Contains(student))
                {
                    Program.bad_guys_LinkedList.AddLast(student);
                }
                else if(Formulas.Galutinis(student.grade, student.exam) >= 5.0 && !Program.bad_guys_LinkedList.Contains(student))
                {
                    Program.good_guys_LinkedList.AddLast(student);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad student data: " + ex);
            }
        }    
    }
}
