using System;
using System.Collections.Generic;

public class Student
{
    public string Name;
    public int Age;
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
         
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> studentlist = new List<Student>();

        studentlist.Add(new Student("Alice", 20));
        studentlist.Add(new Student("Bob", 22));
        studentlist.Add(new Student("Charlie", 21));

        foreach (var student in studentlist)
        {
            student.DisplayInfo();
        }
    }
}