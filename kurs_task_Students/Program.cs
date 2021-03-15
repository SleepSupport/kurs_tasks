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
        public virtual void ChangeGroup(int studentNumber, Group i, Group a)
        {
            Console.WriteLine("метод перевода студента у студента");
            a.StudentsList.Add(a.StudentsList[studentNumber]);
            i.StudentsList.RemoveAt(studentNumber);

        }
    }
    class Group : Student
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
        public override void ChangeGroup(int studentNumber, Group i, Group a)
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
            Student test = new Student("Вася", "Петров");
            List<Student> testList = new List<Student>() {
                new Student("Глеб", "Криткович"),
                new Student("Вова", "Жуковский"),
                new Student("Коля", "Лисовский"),
                new Student("Никита", "Кухарев") };
            Console.WriteLine("Проверка класса Студента");
            test.AverageScore();
            test.ShowMarks();
            Group testGroup = new Group(481, testList);
            Group testGroup2 = new Group(481, testList);

            Console.WriteLine("Проверка класса группы");

            testGroup.ShowGroupMarks();
            testGroup.ShowGroupScoreAverage();
            testGroup.ChangeGroup(1, testGroup, testGroup2);



        }
    }
}
