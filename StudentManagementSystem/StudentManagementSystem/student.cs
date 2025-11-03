using System;


namespace StudentManagementSystem
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public Student() { }
        public Student(string name, int age, string className)
        {
            Name = name;
            Age = age;
            Class = className;
        }
    }
}
