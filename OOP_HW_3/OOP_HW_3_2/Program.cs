using System;

namespace OOP_HW_3_2
{
    class Program
    {
        static void Main(string[] args)

        {   System.Collections.Generic.Dictionary<string, Group> groupList = new System.Collections.Generic.Dictionary<string, Group>();

            while (true)
            {
                
                int opt = Program.Menu();

                if (opt == 1)
                {
                    Console.WriteLine("Enter group name: ");
                    string groupName = Console.ReadLine();
                    if (groupList.ContainsKey(groupName))
                    {
                        Console.WriteLine("Group is already existing");
                    }
                    else
                    {
                        groupList.Add(groupName, new Group(groupName));
                        Console.WriteLine("Done");
                    }
                }
                else if (opt == 2)
                {

                    Console.WriteLine("Enter group name: ");
                    string groupName = Console.ReadLine();
                    if (!groupList.ContainsKey(groupName))
                    {
                        Console.WriteLine("Group with such name isn't existing");
                        continue;
                    }
                    Console.WriteLine("Enter student name: ");
                    string studentName = Console.ReadLine();
                    Console.WriteLine("Is it good or bad student?");
                    string studentFeature = "";
                    while (studentFeature != "good" && studentFeature != "bad")
                    {
                        Console.WriteLine("Enter \"good\" or \"bad\": ");
                        studentFeature = Console.ReadLine();
                    }
                    
                    if (studentFeature == "good")
                        groupList[groupName].AddStudent(new GoodStudent(studentName));
                    else
                        groupList[groupName].AddStudent(new BadStudent(studentName));
                    Console.WriteLine("Done");
                }
                else if (opt == 3)
                {

                    Console.WriteLine("Enter group name: ");
                    string groupName = Console.ReadLine();
                    if (!groupList.ContainsKey(groupName))
                    {
                        Console.WriteLine("Group with such name isn't existing");
                        continue;
                    }

                    Console.WriteLine("Enter an option: ");
                    Console.WriteLine("1 -- Information");
                    Console.WriteLine("2 -- Full information");
                    int optInfo = Convert.ToInt32(Console.ReadLine());
                    if (optInfo == 1)
                        groupList[groupName].GetInfo();
                    else
                        groupList[groupName].GetFullInfo();
                }
                else
                {
                    return;
                }
            }
        }
        static int Menu()
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Enter an option: ");
            Console.WriteLine("1 -- Add a new group");
            Console.WriteLine("2 -- Add a new student in an existing group");
            Console.WriteLine("3 -- Show info about an existing group");
            Console.WriteLine("other number -- Exit");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
    
    abstract class Student
    {
        protected Student(string _name)
        {
            name = _name;
            state = "";
        }
        public string name;
        public string state;
        public void Relax()
        {
            state += "Relax ";
        }
        public void Read()
        {
            state += "Read ";
        }
        public void Write()
        {
            state += "Write ";
        }
        public abstract void Study();


    }

    class GoodStudent : Student
    {
        public GoodStudent(string _name) : base(_name)
        {
            state += "good ";
        }
        public override void Study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
    }

    class BadStudent : Student
    {
        public BadStudent(string _name) : base(_name)
        {
            state += "bad ";
        }
        public override void Study()
        {
            Relax();
            Relax();
            Relax();
            Relax();
            Read();
        }
    }

    class Group
    {
        public Group(string _groupName)
        {
            groupName = _groupName;
            students = new System.Collections.Generic.List<Student>();
        }
        public string groupName;
        public System.Collections.Generic.List<Student> students;
        public void AddStudent(Student st)
        {
            students.Add(st);
        }
        public void GetInfo()
        {
            Console.WriteLine(groupName);
            foreach(Student student in students)
            {
                Console.WriteLine(student.name);
            }
        }
        public void GetFullInfo()
        {
            Console.WriteLine(groupName);
            foreach (Student student in students)
            {
                Console.WriteLine(student.name + " " + student.state);
            }
        }
    }
}
