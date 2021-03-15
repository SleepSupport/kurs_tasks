using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_6
{
    class Students
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<int> Marks { get; set; } = new List<int>();

        public double AverageMark
        {
            get
            {
                return Marks.Average();
            }
        }
        public void PrintMarks()
        {
            foreach (var mark in Marks)
            {
                Console.WriteLine(mark);
            }
        }
        class GroupsWithStudents
        {
            public string NameGroup { get; set; }
            public List<Students> Student { get; set; } = new List<Students>();

            public void PrintAverageMark()
            {
                foreach (var student in Student)
                {
                    Console.WriteLine($"{student.Name} {student.Surname}:{student.AverageMark}");
                }
            }
            public void PrintMarks()
            {
                foreach (var student in Student)
                {
                    var marksStudent = string.Join("  ", student.Marks);
                    Console.WriteLine($"{student.Name} {student.Surname}:{marksStudent}");
                }
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                List<int> rating = new List<int>() { 2, 5, 7, 2, 8, 9, 7, 8, 9, 6, 4, 10, 6, 4, 5, 3, 2, 9, 1, 4 };

                var studentsInGroup = new List<GroupsWithStudents>();

                 var test1=new GroupsWithStudents()
                {
                    NameGroup = "Engineers",
                    Student = new List<Students>
                    {
                       new Students
                       {
                        Name="Tom",
                        Surname= "Black",
                        Marks=new List<int>(){ 2, 5, 7, 2 }

                       },
                        new Students
                       {
                        Name="Sasha",
                        Surname= "Red",
                        Marks=new List<int> (){ 8, 9, 7, 8 }
                        }
                    }
                };
                var test2 =new GroupsWithStudents()
                {
                    NameGroup = "Linguists",
                    Student = new List<Students>
                    {
                    new Students
                         {
                             Name = "Kate",
                             Surname = "Ostin",
                             Marks = new List<int>() { 9, 6, 4, 10 }

                         },
                          new Students
                          {
                              Name = "Dima",
                              Surname = "Ivanov",
                              Marks = new List<int>() { 6, 4, 5, 3 }

                          },
                    }
                };
                var test3 =new GroupsWithStudents()
                {
                    NameGroup = "Medics",
                    Student = new List<Students>
                    {
                         new Students
                         {
                               Name = "Robin",
                               Surname = "Morris",
                               Marks = new List<int>() { 2, 9, 1, 4 }
                         }

                    }
                };
                studentsInGroup.Add(test1);
                studentsInGroup.Add(test2);
                studentsInGroup.Add(test3);
                foreach (GroupsWithStudents groups in studentsInGroup)
                {
                    groups.PrintMarks();
                    groups.PrintAverageMark();
                }

                Console.WriteLine();

            }

        }
    }
}
