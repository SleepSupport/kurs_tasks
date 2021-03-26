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
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        /*public virtual void ChangeGroup(int studentNumber, Group i, Group a)
        {
            Console.WriteLine("метод перевода студента у студента");
            a.StudentsList.Add(a.StudentsList[studentNumber]);
            i.StudentsList.RemoveAt(studentNumber);

        }*/
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
        public Group(int groupNumber)
        {
            string[] names = { "Вася", "Вова", "Коля", "Никита", "Даша", "Настя", "Женька", "Аня", "Влад", "Глеб" };
            string[] surNames = { "Рябов", "Кузнецов", "Маслов", "Исаков", "Котов", "Нестеров", "Брагин", "Дьячков" };
            Random r = new Random();
            GroupNumber = groupNumber;
            for (int i = 0; i < 5; i++)
            {
                StudentsList.Add(new Student(names[r.Next(0, names.Length)], surNames[r.Next(0, surNames.Length)]));
            }
        }
        public Group(int groupNumber, int studentNum)
        {
            GroupNumber = groupNumber;
            string newName;
            string newSurame;
            for (int i = 0; i < studentNum; i++)
            {
                Console.WriteLine($"Студент {i}: ");
                newName = Console.ReadLine();
                newSurame = Console.ReadLine();
                StudentsList.Add(new Student(newName, newSurame));
            }
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
                Console.WriteLine($"Оценки студента {i.Name} {i.Surname}:");
                i.ShowMarks();
            }
        }
        public void ShowStudentsInGroup()
        {
            foreach (Student i in StudentsList)
            {
                Console.WriteLine($"Студент {i.Name} {i.Surname} cредння оценка студента: {i.Marks.Average()}");

            }
        }
        public void ChangeGroup(int studentNumber, Group i, Group a)
        {

            a.StudentsList.Add(a.StudentsList[studentNumber]);
            i.StudentsList.RemoveAt(studentNumber);

        }


    }

    class Program
    {

        static void Main(string[] args)
        {
                        Student test = new Student("Вася", "Кузнецов");
            List<Student> testList = new List<Student>() {
                new Student("Глеб", "Криткович"),
                new Student("Вова", "Жуковский"),
                new Student("Коля", "Лисовский"),
                new Student("Никита", "Кухарев") };
            List<Group> groups = new List<Group>();
            Group testGroup = new Group(481, testList);
            Group testGroup2 = new Group(485, testList);
            groups.Add(testGroup);
            groups.Add(testGroup2);
            string name, surname;
            bool end = true, studentEnd = true, groupEnd = true;
            int choose, gropChoose, studentChoose, groupNumber, studentsNum;
            for (; end;)
            {
                Console.WriteLine("-----------------==============Выберите пункт меню:==============----------------- \n1-Студенты\n2-Группы\n3-Завершить программу");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            studentEnd = true;
                            for (; studentEnd;)
                            {

                                Console.WriteLine("\n======================Выберите пункт меню студентов:====================== \n1-Создать студента\n2-Поставить оценку студенту\n3-Удалить студента\n4-Редактировать студента\n5-Вернуться обратно");
                                choose = Convert.ToInt32(Console.ReadLine());
                                switch (choose)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("---------------------============Выберите группу:============---------------------");
                                            for (int i = 0; i < groups.Count; i++)
                                            {
                                                Console.WriteLine($"{i}-{groups[i].GroupNumber}");
                                            }
                                            gropChoose = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Введите имя и фамилию студента");
                                            name = Console.ReadLine();
                                            surname = Console.ReadLine();
                                            groups[gropChoose].StudentsList.Add(new Student(name, surname));
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("---------------------============Выберите группу:============---------------------");
                                            for (int i = 0; i < groups.Count; i++)
                                            {
                                                Console.WriteLine($"{i}-{groups[i].GroupNumber}");
                                            }
                                            gropChoose = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Выберите Студента в группе:");
                                            for (int i = 0; i < groups[gropChoose].StudentsList.Count; i++)
                                            {
                                                Console.WriteLine($"{i}-{groups[gropChoose].StudentsList[i].Name} {groups[gropChoose].StudentsList[i].Surname}");
                                            }
                                            studentChoose = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine($"Введите какую оценку хотите поставить студенту {groups[gropChoose].StudentsList[studentChoose].Name} {groups[gropChoose].StudentsList[studentChoose].Surname}");

                                            groups[gropChoose].StudentsList[studentChoose].Marks.Add(Convert.ToInt32(Console.ReadLine()));
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("---------------------============Выберите группу:============---------------------");
                                            for (int i = 0; i < groups.Count; i++)
                                            {
                                                Console.WriteLine($"{i}-{groups[i].GroupNumber}");
                                            }
                                            gropChoose = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Выберите Студента в группе:");
                                            for (int i = 0; i < groups[gropChoose].StudentsList.Count; i++)
                                            {
                                                Console.WriteLine($"{i}-{groups[gropChoose].StudentsList[i].Name} {groups[gropChoose].StudentsList[i].Surname}");
                                            }
                                            studentChoose = Convert.ToInt32(Console.ReadLine());
                                            groups[gropChoose].StudentsList.RemoveAt(studentChoose);
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.WriteLine("---------------------============Выберите группу:============---------------------");
                                            for (int i = 0; i < groups.Count; i++)
                                            {
                                                Console.WriteLine($"{i}-{groups[i].GroupNumber}");
                                            }
                                            gropChoose = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Выберите Студента в группе:");
                                            for (int i = 0; i < groups[gropChoose].StudentsList.Count; i++)
                                            {
                                                Console.WriteLine($"{i}-{groups[gropChoose].StudentsList[i].Name} {groups[gropChoose].StudentsList[i].Surname}");
                                            }
                                            studentChoose = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Выберите:\n1-Изменить имя\n2-Изменить Фамилию\n3-Изменить оценку");
                                            choose = Convert.ToInt32(Console.ReadLine());
                                            switch (choose)
                                            {
                                                case 1:
                                                    {
                                                        groups[gropChoose].StudentsList[studentChoose].Name = Console.ReadLine();
                                                        break;
                                                    }
                                                case 2:
                                                    {
                                                        groups[gropChoose].StudentsList[studentChoose].Surname = Console.ReadLine();
                                                        break;
                                                    }
                                                case 3:
                                                    {
                                                        Console.WriteLine("Выберите оценку которую хотите редактировать");
                                                        for (int i = 0; i < groups[gropChoose].StudentsList[studentChoose].Marks.Count; i++)
                                                        {
                                                            Console.WriteLine($"Оценка:{groups[gropChoose].StudentsList[studentChoose].Marks[i]} Номер оценки для редактирования: {i}");
                                                        }
                                                        choose = Convert.ToInt32(Console.ReadLine());
                                                        groups[gropChoose].StudentsList[studentChoose].Marks[choose] = Convert.ToInt32(Console.ReadLine());
                                                        break;
                                                    }
                                                default:
                                                    {
                                                        break;
                                                    }
                                            }
                                            break;
                                        }
                                    case 5:
                                        {
                                            studentEnd = false;
                                            break;
                                        }
                                    default:
                                        {
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            groupEnd = true;
                            for (; groupEnd;)
                            {
                                Console.WriteLine("\n======================Выберите пункт меню Групп:====================== \n1-Создать Группу\n2-Редактировать группу\n3-Удалить группу\n4-Посмотреть список всех групп\n5-Вывод Информации о группе\n6-Вернуться обратно");
                                choose = Convert.ToInt32(Console.ReadLine());
                                switch (choose)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("1-Создать группу случайным заполением\n2-Создать группу вручаную");
                                            choose = Convert.ToInt32(Console.ReadLine());
                                            switch (choose)
                                            {
                                                case 1:
                                                    {
                                                        Console.WriteLine("Введите номер группы");
                                                        groupNumber = Convert.ToInt32(Console.ReadLine());

                                                        groups.Add(new Group(groupNumber));
                                                        break;
                                                    }
                                                case 2:
                                                    {
                                                        Console.WriteLine("Введите номер группы");
                                                        groupNumber = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Введите количество студентов в группе");
                                                        studentsNum = Convert.ToInt32(Console.ReadLine());
                                                        groups.Add(new Group(groupNumber, studentsNum));
                                                        break;
                                                    }
                                                default:
                                                    {
                                                        break;
                                                    }
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("1-Изменить номер группы\n2-Удалить студента из группы");
                                            choose = Convert.ToInt32(Console.ReadLine());
                                            switch (choose)
                                            {
                                                case 1:
                                                    {
                                                        Console.WriteLine("---------------------============Выберите группу:============---------------------");
                                                        for (int i = 0; i < groups.Count; i++)
                                                        {
                                                            Console.WriteLine($"{i}-{groups[i].GroupNumber}");
                                                        }
                                                        gropChoose = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Введите новый номер группы:");
                                                        groups[gropChoose].GroupNumber = Convert.ToInt32(Console.ReadLine());


                                                        break;
                                                    }
                                                case 2:
                                                    {
                                                        Console.WriteLine("---------------------============Выберите группу:============---------------------");
                                                        for (int i = 0; i < groups.Count; i++)
                                                        {
                                                            Console.WriteLine($"{i}-{groups[i].GroupNumber}");
                                                        }
                                                        gropChoose = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Введите новый номер группы:");

                                                        Console.WriteLine("Выберите Студента в группе:");
                                                        for (int i = 0; i < groups[gropChoose].StudentsList.Count; i++)
                                                        {
                                                            Console.WriteLine($"{i}-{groups[gropChoose].StudentsList[i].Name} {groups[gropChoose].StudentsList[i].Surname}");
                                                        }
                                                        studentChoose = Convert.ToInt32(Console.ReadLine());
                                                        groups[gropChoose].StudentsList.RemoveAt(studentChoose);
                                                        break;
                                                    }

                                                default:
                                                    break;
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("---------------------============Выберите группу:============---------------------");
                                            for (int i = 0; i < groups.Count; i++)
                                            {
                                                Console.WriteLine($"{i}-{groups[i].GroupNumber}");
                                            }
                                            gropChoose = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Введите новый номер группы:");
                                            groups.RemoveAt(gropChoose);
                                            break;
                                        }
                                    case 4:
                                        {
                                            foreach (Group item in groups)
                                            {
                                                Console.WriteLine($"Группа - {item.GroupNumber}");
                                                item.ShowStudentsInGroup();
                                            }
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.WriteLine("---------------------============Выберите группу:============---------------------");
                                            for (int i = 0; i < groups.Count; i++)
                                            {
                                                Console.WriteLine($"{i}-{groups[i].GroupNumber}");
                                            }
                                            gropChoose = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine($"Группа - {groups[gropChoose].GroupNumber}");
                                            groups[gropChoose].ShowStudentsInGroup();
                                            break;
                                        }
                                    case 6:
                                        {
                                            groupEnd = false;
                                            break;
                                        }
                                    default:
                                        {
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            end = false;
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }


        }
    }
}
