using System;

namespace Lab_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher treacher = new Teacher("Maria Skłodowska", 50);
            Student student1 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student2 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student3 = new Student("Jaś Fasola", 23, "LAB-02");

            Console.WriteLine("Student1 == Student2 "+student1.Equals(student2));
            Console.WriteLine("Student2 == Student3 " + student1.Equals(student3));

            
         


        }
        public class Student
        {
            public string name;
            public int age;
            public string group;
            public Student(string name, int age, string group)
            {
                this.name = name;
                this.age = age;
                this.group = group;
            }
            public override string ToString()
            {
                string obj = $"{this.name}, {this.age}, {this.group}";
                return obj;
            }
            public bool Equals(Student other)
            {
                if (other == null) return false;
                if (other == this) return true;

                return Object.Equals(this.name, other.name) && Object.Equals(this.age, other.age);
            }
        }
        public class Teacher
        {
            public string name;
            public int age;
        public Teacher(string name, int age)
        {
                this.name = name;
                this.age = age;
        }
        public override string ToString()
        {
                string obj = $"{this.name}, {this.age}";
                return obj;
        }
        }
        public class Person
        {
            public string name;
            public int age;
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public override string ToString()
            {
                string obj = $"{this.name}, {this.age}";
                return obj;
            }
            public bool Equals(Person other)
            {
                if (other == null) return false;
                if (other == this) return true;

                return Object.Equals(this.name, other.name) && Object.Equals(this.age, other.age);
            }
        }
        
        




    }
}
