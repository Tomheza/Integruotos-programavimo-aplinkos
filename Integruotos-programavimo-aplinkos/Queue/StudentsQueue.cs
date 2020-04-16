using Integruotos_programavimo_aplinkos.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integruotos_programavimo_aplinkos.Queue
{
    class StudentsQueue
    {

        public void SortStudents()
        {
            try
            {
                var temp = Program.studentsQueue.ToList();
                temp = temp.OrderBy(o => o.name).OrderBy(o => o.surname).ToList();

                Program.studentsQueue.Clear();

                foreach (var item in temp)
                {
                    Program.studentsQueue.Enqueue(item);
                }

                temp = Program.good_guys_Queue.ToList();
                temp = temp.OrderBy(o => o.name).OrderBy(o => o.surname).ToList();

                Program.good_guys_Queue.Clear();

                foreach(var item in temp)
                {
                    Program.good_guys_Queue.Enqueue(item);
                }

                temp = Program.bad_guys_Queue.ToList();
                temp = temp.OrderBy(o => o.name).OrderBy(o => o.surname).ToList();

                Program.bad_guys_Queue.Clear();

                foreach(var item in temp)
                {
                    Program.bad_guys_Queue.Enqueue(item);
                }

                // clear cache
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

        public void AddStudent(StudentQueue stud)
        {
            if(!Program.studentsQueue.Contains(stud))
                Program.studentsQueue.Enqueue(stud);

            if (Formulas.Galutinis(stud.grade, stud.exam) < 5.0)
            {
                Program.bad_guys_Queue.Enqueue(stud);
            }
            else if (Formulas.Galutinis(stud.grade, stud.exam) >= 5.0)
            {
                Program.good_guys_Queue.Enqueue(stud);
            }
        }

        public void RemoveStudent(string name, string surname)
        {
            var temp = Program.studentsQueue;
            Program.studentsQueue.Clear();

            foreach (var item in Program.studentsQueue)
            {
                if (!item.name.Equals(name) && !item.surname.Equals(surname))
                {
                    temp.Enqueue(item);
                }
            }

            Program.studentsQueue = temp;
            temp.Clear();

        }
        


        public void AddStudent(string name, string surname, double grade, double exam, Queue<double> grades)
        {
            try
            {
                StudentQueue student = new StudentQueue(name, surname, grade, exam, grades);
                Program.studentsQueue.Enqueue(student);

                if(Formulas.Galutinis(student.grade, student.exam) < 5.0)
                {
                    Program.bad_guys_Queue.Enqueue(student);
                }
                else if(Formulas.Galutinis(student.grade, student.exam) >= 5.0)
                {
                    Program.good_guys_Queue.Enqueue(student);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad student data: " + ex);
            }
        }
    }
}
