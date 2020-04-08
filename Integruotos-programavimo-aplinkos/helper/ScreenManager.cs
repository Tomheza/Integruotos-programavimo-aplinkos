﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Integruotos_programavimo_aplinkos.helper
{
    class ScreenManager
    {
        public Students studentsController = new Students();
        public ScreenManager()
        {
            menu();
        }

        //List<Student> students
        public void printResultsAvg()
        {
            Console.WriteLine("{0, -15} {1, -15} {2, -20}", "Vardas", "Pavardė", "Galutinis (Vid.)");
            for (int i = 0; i <= 48; i++)
                Console.Write("-");
            Console.WriteLine("-");
            foreach (var item in Program.students)
            {
                Console.WriteLine("{0, -15} {1, -15} {2, -20}", item.name, item.surname, Formulas.Galutinis(item.grade, item.exam).ToString("0.00"));
            }
        }

        public void printResults()
        {
            Console.WriteLine("{0, -15} {1, -15} {2, -20} {3, -20}", "Vardas", "Pavardė", "Galutinis (Vid.)", "Galutinis (Med.)");
            for (int i = 0; i <= 68; i++)
                Console.Write("-");
            Console.WriteLine("-");
            foreach (var item in Program.students)
            {
                Console.WriteLine("{0, -15} {1, -15} {2, -20} {3, -20}", item.name, item.surname, Formulas.Galutinis(item.grade, item.exam).ToString("0.00"), Formulas.Galutinis_mediana(item.grades, item.exam).ToString("0.00"));
            }
        }


        public void printResultsMediana()
        {
            Console.WriteLine("{0, -15} {1, -15} {2, -20}", "Vardas", "Pavardė", "Galutinis (Med.)");
            for (int i = 0; i <= 48; i++)
                Console.Write("-");
            Console.WriteLine("-");
            foreach (var item in Program.students)
            {
                Console.WriteLine("{0, -15} {1, -15} {2, -20}", item.name, item.surname, Formulas.Galutinis_mediana(item.grades, item.exam).ToString("0.00"));
            }
        }

        public void printMenu()
        {
            Console.WriteLine(Settings.version);
            Thread.Sleep(1000);
            Console.WriteLine("help - shows general help information");
            Console.WriteLine("exit - exits this program");
            Console.WriteLine("add - adds a new student to the list");
            Console.WriteLine("addstudentsio - adds students from file: studentai.txt");
            Console.WriteLine("addrnd - adds a new student with random data");
            Console.WriteLine("printMediana - prints data from List mediana");
            Console.WriteLine("print - prints data for students");
            //pause();
        }

        public void pause()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        public void pauseClear()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public void printHelp()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine(Settings.version);
            Thread.Sleep(1000);
            Console.WriteLine("help - shows general help information");
            Console.WriteLine("exit - exits this program");
            Console.WriteLine("add - adds a new student to the list");
            Console.WriteLine("addstudentsio - adds students from file: studentai.txt");
            Console.WriteLine("addrnd - adds a new student with random data");
            Console.WriteLine("printMediana - prints data from List mediana");
            Console.WriteLine("printAvg - prints data from List with avg");
            Console.WriteLine("print - prints data for students");

            pauseClear();
        }

        public void addStudent()
        {
            try
            {
                Console.WriteLine("Iveskite studento duomenis: Vardas Pavarde [[n]-balai] [egz balas]");
                Console.WriteLine("Pvz: Vardas1                 Pavarde1                      9         1         9        10         8         7         5");
                string data = Console.ReadLine();
                //string data = @"Vardas1                 Pavarde1                      9         1         9        10         8         7         5";
                var stud_data = data.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                string name = stud_data[0];
                string surname = stud_data[1];

                double exam = double.Parse(stud_data.Last());

                List<double> grades = new List<double>();

                for (int i = 2; i < stud_data.Length - 1; i++)
                    grades.Add(double.Parse(stud_data[i]));
                studentsController.AddStudent(new Student(name, surname, 0, exam, grades));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic error:" + ex.Message);
                Console.WriteLine("Try again? [yes / no]");
                if (Console.ReadLine().Contains("yes"))
                    addStudent();
            }
        }
        public void addStudentRnd()
        {
            try
            {
                string data = null;
                string name = null;
                string surname = null;

                Console.WriteLine("Iveskite studento duomenis: Vardas Pavarde");
                try
                {
                    data = Console.ReadLine();
                    var stud_data = data.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                    name = stud_data[0];
                    surname = stud_data[1];
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Blogai suvesti duomenys: Vardas Pavarde");
                    Console.WriteLine(ex.Message);

                    Console.WriteLine("Try again? [yes / no]");
                    if (Console.ReadLine().Contains("yes"))
                        addStudentRnd();
                    
                    return;
                }

                Random rnd = new Random();

                double exam = rnd.Next(0, 11);


                List<double> grades = new List<double>
            {
                rnd.Next(0, 11),
                rnd.Next(0, 11),
                rnd.Next(0, 11),
                rnd.Next(0, 11),
                rnd.Next(0, 11),
                rnd.Next(0, 11)
            };

                studentsController.AddStudent(new Student(name, surname, 0, exam, grades));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic exception: " + ex.Message);
                Console.WriteLine("Try again? [yes / no]");
                if(Console.ReadLine().Contains("yes"))
                    addStudentRnd();
            }
            
        }

        public void addstudentsIO()
        {
            try
            {
                string[] lines = null;
                try
                {
                    lines = File.ReadAllLines("studentai.txt");
                }
                catch (Exception)
                {
                    Console.WriteLine("studentai.txt file not found, please enter the new file path");
                    try
                    {
                        lines = File.ReadAllLines(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Try agian? [yes / no]");
                        if(Console.ReadLine().Contains("yes"))
                            addstudentsIO(); //recursion
                        
                        return;
                    }
                }

                lines = lines.Skip(1).ToArray(); // remove first
                Console.WriteLine("Found: " + lines.Length);
                Console.WriteLine("Loading...");
                foreach (string line in lines)
                {
                    try
                    {
                        var stud_data = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                        string name = stud_data[0];
                        string surname = stud_data[1];

                        double exam = double.Parse(stud_data.Last());

                        List<double> grades = new List<double>();

                        for (int i = 2; i < stud_data.Length - 1; i++)
                            grades.Add(double.Parse(stud_data[i]));
                        studentsController.AddStudent(new Student(name, surname, 0, exam, grades));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Bad student row...");
                        Console.WriteLine(ex.Message);
                    }
                }

                studentsController.SortStudents();

                Console.WriteLine("Done");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: {0}", ex.Message);
            }
            catch(IOException ex)
            {
                Console.WriteLine("IO exception: {0}", ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Generic execption: {0}", ex.Message);
            }
        }

        public static void GenerateSudentsIO(string filename, int count)
        {
            List<string> data = new List<string>() { "Vardas                   Pavarde                    ND1       ND2       ND3       ND4       ND5       ND6      Egz." };

            for(int i = 0; i < count; i++)
            {
                Random rnd = new Random();
                string vardas = "Vardas" + i;
                string pavarde = "Pavarde" + i;
                double exam = rnd.Next(0,11);
                List<double> grades = new List<double>
                {
                    rnd.Next(0,11),
                    rnd.Next(0,11),
                    rnd.Next(0,11),
                    rnd.Next(0,11),
                    rnd.Next(0,11),
                    rnd.Next(0,11),
                };

                string duom = vardas + "    " + pavarde + "    ";
                foreach(double grade in grades)
                {
                    duom += grade + "    ";
                }

                duom += exam + "";
                data.Add(duom);
            }

            string temp = "";

            foreach (var item in data)
            {
                temp += item + "\n";
            }

            File.WriteAllText(filename + ".txt", temp);
        }

        public void GenerateStudentFiles()
        {
            Console.WriteLine("Select number of students to generate:");
            Console.WriteLine("1 - 1000");
            Console.WriteLine("2 - 10000");
            Console.WriteLine("3 - 100000");
            Console.WriteLine("4 - 1000000");
            Console.WriteLine("5 - 10000000");
            Console.WriteLine("6 - your wanted number");
            try 
            {
                switch(Console.ReadLine())
                {
                    case"1":
                        GenerateSudentsIO("1", 1000);
                        break;
                    case"2":
                        GenerateSudentsIO("2", 10000);
                        break;
                    case"3":
                        GenerateSudentsIO("3", 100000);
                        break;
                    case"4":
                        GenerateSudentsIO("4", 1000000);
                        break;
                    case"5":
                        GenerateSudentsIO("5", 10000000);
                        break;
                    case"6":
                        break;

                    default:
                        Console.WriteLine("Bad command... Try again? [yes / no]");
                        if(Console.ReadLine().Contains("yes"))
                            GenerateStudentFiles(); //recursion
                    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception has occured:" + ex.Message);
                Console.WriteLine("Try agian? [yes / no]");
                if(Console.ReadLine().Contains("yes"))
                    GenerateStudentFiles(); //recursion
                        return;
            }
        }

        public void menu()
        {
            bool running = true;
            
            printHelp();

            while (running)
            {
                switch (Console.ReadLine())
                {
                    case "add":
                        addStudent();
                        break;

                    case "addrnd":
                        addStudentRnd();
                        break;

                    case "addstudentsio":
                        addstudentsIO();
                        break;

                    case "genstudFile":
                        GenerateStudentFiles();
                        break;

                    case "printMediana":
                        printResultsMediana();
                        break;
                    case "printAvg":
                        printResultsAvg();
                        break;
                    case "print":
                        printResults();
                        break;

                    case "help":
                        printMenu();
                        break;
                    case "clear":
                        Console.Clear();
                        break;

                    case "exit":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Bad request");
                        break;
                }
            }
        }

    }
}
