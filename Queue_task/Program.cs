using System;
using System.Collections.Generic;
using System.Linq;
namespace kurs_task_Students
{
    class Student
    {
        private string _name;
        private string _surname;
        private List<int> _marks = new List<int>();

        public Student(string name, string surname, List<int> marks)
        {
            Name = name;
            Surname = surname;
            this.Marks = marks;
        }
        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            RandomMarks();
        }
        public Student()
        {
            Name = "Неизвестно";
            Surname = "Неизвестно";
            RandomMarks();
        }

        public void RandomMarks()
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Marks.Add(r.Next(4, 11));
            }
        }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public List<int> Marks { get => _marks; set => _marks = value; }
        public void AverageScore()
        {
            Console.WriteLine(Marks.Average());
        }
        public void ShowMarks()
        {

            foreach (int i in Marks)
            {
                Console.WriteLine(i);
            }
        }
       
    }
    class Group 
    {
        private int _groupNumber;
        private List<Student> _studentsList = new List<Student>();

        public Group(int groupNumber, List<Student> studentsList)
        {
            GroupNumber = groupNumber;
            StudentsList = studentsList;
        }

        public int GroupNumber { get => _groupNumber; set => _groupNumber = value; }
        internal List<Student> StudentsList { get => _studentsList; set => _studentsList = value; }

        public void ShowGroupScoreAverage()
        {
            foreach (Student i in StudentsList)
            {
                Console.Write($"Средняя оценка {i.Name} {i.Surname}:");
                i.AverageScore();
            }
        }

        public void ShowGroupMarks()
        {
            foreach (Student i in StudentsList)
            {
                Console.WriteLine($"Средняя оценка {i.Name} {i.Surname}:");
                i.ShowMarks();
            }
        }
        public void ChangeGroup(int studentNumber, Group i, Group a)
        {
            Console.WriteLine("метод перевода студента у студента");
            a.StudentsList.Add(a.StudentsList[studentNumber]);
            i.StudentsList.RemoveAt(studentNumber);

        }


    }

    class Program
    {

        static void Main(string[] args)
        {

            Queue<Student> testStack = new Queue<Student>() { };
            testStack.Enqueue(new Student("Глеб", "Криткович"));
            testStack.Enqueue(new Student("Вова", "Жуковский"));
            testStack.Enqueue(new Student("Коля", "Лисовский"));
            testStack.Enqueue(new Student("Никита", "Кухарев"));
            foreach (Student p in testStack)
            {
                Console.WriteLine("Task from " + p.Name + " " + p.Surname + " is received ");
            }
            while (testStack.Count > 0)
            {
                Student help = testStack.Dequeue();
                Console.WriteLine($"{help.Name} {help.Surname} got a cup of coffee");
            }






        }
    }
}
