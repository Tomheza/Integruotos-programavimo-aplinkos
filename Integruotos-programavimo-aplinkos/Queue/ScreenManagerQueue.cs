using Integruotos_programavimo_aplinkos.helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Integruotos_programavimo_aplinkos.Queue
{
    class ScreenManagerQueue
    {
        public StudentsQueue studentsController = new StudentsQueue();
        public ScreenManagerQueue()
        {
            menu();
        }

        public void printResultsAvg()
        {
            Program.NewTimer();
            Console.WriteLine("{0, -15} {1, -15} {2, -20}", "Vardas", "Pavardė", "Galutinis (Vid.)");
            for (int i = 0; i <= 48; i++)
                Console.Write("-");
            Console.WriteLine("-");
            foreach (var item in Program.good_guys_Queue)
            {
                Console.WriteLine("{0, -15} {1, -15} {2, -20}", item.name, item.surname, Formulas.Galutinis(item.grade, item.exam).ToString("0.00"));
            }
            foreach (var item in Program.bad_guys_Queue)
            {
                Console.WriteLine("{0, -15} {1, -15} {2, -20}", item.name, item.surname, Formulas.Galutinis(item.grade, item.exam).ToString("0.00"));
            }
            Program.StopTimer("printAvg");
        }

        public void printResults()
        {
            Console.WriteLine("Select what to print:");
            Console.WriteLine("1 - print all students");
            Console.WriteLine("2 - print 'Good guys'");
            Console.WriteLine("3 - print 'Bad guys'");
            switch(Console.ReadLine())
            {
                case "1":
                    Program.NewTimer();
                    Console.WriteLine("{0, -15} {1, -15} {2, -20} {3, -20}", "Vardas", "Pavardė", "Galutinis (Vid.)", "Galutinis (Med.)");
                    for (int i = 0; i <= 68; i++)
                        Console.Write("-");
                    Console.WriteLine("-");
                    foreach (var item in Program.good_guys_Queue)
                    {
                        Console.WriteLine("{0, -15} {1, -15} {2, -20} {3, -20}", item.name, item.surname, Formulas.Galutinis(item.grade, item.exam).ToString("0.00"), Formulas.Galutinis_mediana(item.grades.ToList(), item.exam).ToString("0.00"));
                    }
                    foreach (var item in Program.bad_guys_Queue)
                    {
                        Console.WriteLine("{0, -15} {1, -15} {2, -20} {3, -20}", item.name, item.surname, Formulas.Galutinis(item.grade, item.exam).ToString("0.00"), Formulas.Galutinis_mediana(item.grades.ToList(), item.exam).ToString("0.00"));
                    }
                    Program.StopTimer("print - 1");
                    break;
                case "2":
                    Console.WriteLine("Save output to file? [yes / no]");
                    if(Console.ReadLine().Contains("yes"))
                    {
                        Program.NewTimer();
                        string data = "Vardas    Pavarde    ND1    ND2    ND3    ND4    ND5    ND6    Egz.\n";
                        foreach(var item in Program.good_guys)
                        {
                            data += item.name + "    " + item.surname + "    ";
                            foreach (var gr in item.grades)
                                data += gr + "    ";
                            data += item.exam + "\n";
                        }
                        try
                        {
                            File.WriteAllText("GoodGuys.txt", data);
                            Console.WriteLine("File saved: GoodGuys.txt");
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Generic exception: " + ex.Message);
                        }
                        Program.StopTimer("print - 2 save to file");
                        
                    }
                    else
                    {
                        Program.NewTimer();
                        Console.WriteLine("~printing good guys~");
                        Console.WriteLine("{0, -15} {1, -15} {2, -20} {3, -20}", "Vardas", "Pavardė", "Galutinis (Vid.)", "Galutinis (Med.)");
                        for (int i = 0; i <= 68; i++)
                            Console.Write("-");
                        Console.WriteLine("-");
                        foreach (var item in Program.good_guys)
                        {
                            Console.WriteLine("{0, -15} {1, -15} {2, -20} {3, -20}", item.name, item.surname, Formulas.Galutinis(item.grade, item.exam).ToString("0.00"), Formulas.Galutinis_mediana(item.grades, item.exam).ToString("0.00"));
                        }
                        Program.StopTimer("print - 2");
                    }
                    break;
                case "3":
                    Console.WriteLine("Save output to file? [yes / no]");
                    if(Console.ReadLine().Contains("yes"))
                    {
                        Program.NewTimer();
                        string data = "Vardas    Pavarde    ND1    ND2    ND3    ND4    ND5    ND6    Egz.\n";
                        foreach(var item in Program.good_guys)
                        {
                            data += item.name + "    " + item.surname + "    ";
                            foreach (var gr in item.grades)
                                data += gr + "    ";
                            data += item.exam + "\n";
                        }
                        try
                        {
                            File.WriteAllText("BadGuys.txt", data);
                            Console.WriteLine("File saved: BadGuys.txt");
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Generic exception: " + ex.Message);
                        }
                        Program.StopTimer("print - 3 save to file");
                        
                    }
                    else    
                    {
                        Program.NewTimer();
                        Console.WriteLine("~printing bad guys~");
                        Console.WriteLine("{0, -15} {1, -15} {2, -20} {3, -20}", "Vardas", "Pavardė", "Galutinis (Vid.)", "Galutinis (Med.)");
                        for (int i = 0; i <= 68; i++)
                            Console.Write("-");
                        Console.WriteLine("-");
                        foreach (var item in Program.bad_guys)
                        {
                            Console.WriteLine("{0, -15} {1, -15} {2, -20} {3, -20}", item.name, item.surname, Formulas.Galutinis(item.grade, item.exam).ToString("0.00"), Formulas.Galutinis_mediana(item.grades, item.exam).ToString("0.00"));
                        }
                        Program.StopTimer("print - 3");
                    }
                   
                    break;
                default:
                    Console.WriteLine("Bad command: Try again? [yes / no]");
                    if(Console.ReadLine().Contains("yes"))
                        printResults();
                    break;
            }
            Console.WriteLine();
            
        }

        public void printResultsMediana()
        {
            Program.NewTimer();
            Console.WriteLine("{0, -15} {1, -15} {2, -20}", "Vardas", "Pavardė", "Galutinis (Med.)");
            for (int i = 0; i <= 48; i++)
                Console.Write("-");
            Console.WriteLine("-");
            foreach (var item in Program.good_guys_Queue)
            {
                Console.WriteLine("{0, -15} {1, -15} {2, -20}", item.name, item.surname, Formulas.Galutinis_mediana(item.grades.ToList(), item.exam).ToString("0.00"));
            }
            foreach (var item in Program.bad_guys_Queue)
            {
                Console.WriteLine("{0, -15} {1, -15} {2, -20}", item.name, item.surname, Formulas.Galutinis_mediana(item.grades.ToList(), item.exam).ToString("0.00"));
            }
            Program.StopTimer("printMediana");
        }

        public void printMenu()
        {
            Console.Write(" ");
            for (int i = 0; i < 59; i++)
                Console.Write("-");
            Console.WriteLine();
            Console.WriteLine("| {0, 29} {1, 29}", "Menu Queue<T> ["+ Settings.version + "]", "|");
            Console.Write(" ");
            for (int i = 0; i < 59; i++)
                Console.Write("-");
            Console.WriteLine();
            Console.WriteLine("| {0, -57} |", "help - shows general help information");
            Console.WriteLine("| {0, -57} |", "exit - exits this program");
            Console.WriteLine("| {0, -57} |", "add - adds a new student to the list");
            Console.WriteLine("| {0, -57} |", "addstudentsio - adds students from file of your choice");
            Console.WriteLine("| {0, -57} |", "addrnd - adds a new student with random data");
            Console.WriteLine("| {0, -57} |", "genstudFile - generates a new student file");
            Console.WriteLine("| {0, -57} |", "printMediana - prints data from List mediana");
            Console.WriteLine("| {0, -57} |", "printAvg - prints data from List with avg");
            Console.WriteLine("| {0, -57} |", "print - prints data for students");
            Console.Write(" ");
            for (int i = 0; i < 59; i++)
                Console.Write("-");
            Console.WriteLine();
            Console.Write(" -> ");
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
            Console.Write(" ");
            for (int i = 0; i < 59; i++)
                Console.Write("-");
            Console.WriteLine();
            Console.WriteLine("| {0, 29} {1, 29}", "Menu Queue<T> [" + Settings.version + "]", "|");
            Console.Write(" ");
            for (int i = 0; i < 59; i++)
                Console.Write("-");
            Console.WriteLine();
            Console.WriteLine("| {0, -57} |", "help - shows general help information");
            Console.WriteLine("| {0, -57} |", "exit - exits this program");
            Console.WriteLine("| {0, -57} |", "add - adds a new student to the list");
            Console.WriteLine("| {0, -57} |", "addstudentsio - adds students from file of your choice");
            Console.WriteLine("| {0, -57} |", "addrnd - adds a new student with random data");
            Console.WriteLine("| {0, -57} |", "genstudFile - generates a new student file");
            Console.WriteLine("| {0, -57} |", "printMediana - prints data from List mediana");
            Console.WriteLine("| {0, -57} |", "printAvg - prints data from List with avg");
            Console.WriteLine("| {0, -57} |", "print - prints data for students");
            Console.Write(" ");
            for (int i = 0; i < 59; i++)
                Console.Write("-");
            Console.WriteLine();
            Console.Write(" -> ");


            //pauseClear();
        }

        public void addStudent()
        {
            try
            {
                Program.NewTimer();

                Console.WriteLine("Iveskite studento duomenis: Vardas Pavarde [[n]-balai] [egz balas]");
                Console.WriteLine("Pvz: Vardas1                 Pavarde1                      9         1         9        10         8         7         5");
                string data = Console.ReadLine();
                //string data = @"Vardas1                 Pavarde1                      9         1         9        10         8         7         5";
                var stud_data = data.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                string name = stud_data[0];
                string surname = stud_data[1];

                double exam = double.Parse(stud_data.Last());

                Queue<double> grades = new Queue<double>();

                for (int i = 2; i < stud_data.Length - 1; i++)
                    grades.Enqueue(double.Parse(stud_data[i]));
                studentsController.AddStudent(new StudentQueue(name, surname, 0, exam, grades));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic error:" + ex.Message);
                Console.WriteLine("Try again? [yes / no]");
                if (Console.ReadLine().Contains("yes"))
                    addStudent();
            }

            Program.StopTimer("addstudent");
        }
        public void addStudentRnd()
        {
            Program.NewTimer();
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


                Queue<double> grades = new Queue<double>();
                grades.Enqueue(rnd.Next(0, 11));
                grades.Enqueue(rnd.Next(0, 11));
                grades.Enqueue(rnd.Next(0, 11));
                grades.Enqueue(rnd.Next(0, 11));
                grades.Enqueue(rnd.Next(0, 11));
                grades.Enqueue(rnd.Next(0, 11));

                studentsController.AddStudent(new StudentQueue(name, surname, 0, exam, grades));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic exception: " + ex.Message);
                Console.WriteLine("Try again? [yes / no]");
                if(Console.ReadLine().Contains("yes"))
                    addStudentRnd();
            }

            Program.StopTimer("addrnd");
        }

        public void addstudentsIO()
        {
            try
            {
                string[] lines = null;
                Console.WriteLine("Please enter file name to read... [ex. student]");

                DirectoryInfo dinfo = new DirectoryInfo(Directory.GetCurrentDirectory());
                FileInfo[] Files = dinfo.GetFiles("*.txt");
                if (Files.Length > 0)
                    Console.WriteLine("Found files:");
                foreach (FileInfo file in Files)
                {
                    Console.WriteLine(file.Name);
                }

                string file_name = Console.ReadLine();

                try
                {
                    Program.NewTimer();
                    lines = File.ReadAllLines(file_name + ".txt");
                    Program.StopTimer("Read: " + file_name + ".txt");

                }
                catch (Exception)
                {
                    Console.WriteLine(file_name + ".txt file not found, please enter the new file path");
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

                Program.NewTimer();
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

                        Queue<double> grades = new Queue<double>();

                        for (int i = 2; i < stud_data.Length - 1; i++)
                            grades.Enqueue(double.Parse(stud_data[i]));
                        
                        studentsController.AddStudent(new StudentQueue(name, surname, 0, exam, grades));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Bad student row...");
                        Console.WriteLine(ex.Message);
                    }
                }
                Program.StopTimer("Txt file parse");

                Program.NewTimer();
                studentsController.SortStudents();
                Program.StopTimer("Sort all lists...");

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
            Program.NewTimer();
            Queue<string> data = new Queue<string>();
            data.Enqueue("Vardas    Pavarde    ND1    ND2    ND3    ND4    ND5    ND6    Egz.");

            for(int i = 0; i < count; i++)
            {
                Random rnd = new Random();
                string vardas = "Vardas" + i;
                string pavarde = "Pavarde" + i;
                double exam = rnd.Next(0,11);
                Queue<double> grades = new Queue<double>();
                grades.Enqueue(rnd.Next(0, 11));

                string duom = vardas + "    " + pavarde + "    ";
                foreach(double grade in grades)
                {
                    duom += grade + "    ";
                }

                duom += exam + "";
                data.Enqueue(duom);
            }

            string temp = "";

            foreach (var item in data)
            {
                temp += item + "\n";
            }
            Program.StopTimer("Generate students ["+filename+".txt, "+ count +"] cycle");
            Program.NewTimer();
            File.WriteAllText(filename + ".txt", temp);
            Console.WriteLine("Succesfully wrote to: " + filename + ".txt");
            Program.StopTimer("write to file: " + filename + ".txt");
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
                        try 
                        {
                            Console.WriteLine("Please enter your wanted students count [ex 10]");
                            int data = int.Parse(Console.ReadLine());
                            GenerateSudentsIO(data + "", data);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Generic exception: " + ex.Message);
                        }
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
