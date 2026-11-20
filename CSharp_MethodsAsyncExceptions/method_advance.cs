using System;
using System.Xml.Linq;

namespace MethodsAAdvance
{
    class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public string subject { get; set; }

    }
    class StudentOperations
    {
        public static Student GetStudent()
        {
            //Student student = new Student()
            //{
            //    name = "Raj",
            //    age = 28,
            //    subject = "CSharp"
            //};
            //return student;

            // or 
            return new Student()
            {
                name = "Raj",
                age = 28,
                subject = "CSharp"
            };
        }
        public static Student[] GetMultipleStudents()
        {

            return new Student[]
            {
                new Student() { name = "Raj",age = 28,subject = "CSharp" },
                new Student() { name = "sha",age = 21,subject = "CSharp" },
                new Student() { name = "fathi",age = 29,subject = "CSharp"}
            };
        }
        public static Student updateStudents(Student stu)
        {
            stu.subject = stu.subject + "Asp.Net Core";
            return stu;
        }
        public static Student[] updateAllStudents(Student[] stu)
        {
            foreach(Student allstu in stu)
            {
                allstu.subject = allstu.subject + " - Advance";

            }
            return stu;
        }
    }
    class Program
    {
        static void Main()
        {
            // first method calling
            Student s1 = StudentOperations.GetStudent();
            Console.WriteLine($"name is {s1.name} and age {s1.age} and subject {s1.subject}");


            // second method calling
            Student[] students = StudentOperations.GetMultipleStudents();
            foreach(Student s2 in students)
            {
                Console.WriteLine($"name is {s2.name} and age {s2.age} and subject {s2.subject}");

            }
            // third method calling
            Student stuupdate = StudentOperations.updateStudents(s1);
            Console.WriteLine($"the updated student is {stuupdate.name} and age {stuupdate.age} and subject {stuupdate.subject}");
            
            // forth method calling
            Student[] Allstuupdate = StudentOperations.updateAllStudents(students);
            foreach(Student s2 in students)
            {
                Console.WriteLine($"name is {s2.name} and age {s2.age} and subject {s2.subject}");

            }
            

        }
    }
}
