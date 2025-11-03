using System;

namespace StudentManagementSystem
{
    public static class DataStorage
    {
        public static List<Student> Students = new List<Student>();

      
        static DataStorage()
        {
            Students.Add(new Student("Ali Khan", 20, "CS-101"));
            Students.Add(new Student("Sara Ahmed", 19, "CS-102"));
            Students.Add(new Student("Usman Malik", 21, "CS-103"));
        }
    }
}