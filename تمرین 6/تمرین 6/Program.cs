using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public string Name;
    public int Age;
}

class Program
{
    static Dictionary<int, Student> students = new Dictionary<int, Student>();
    static string path = @"C:\UNI.txt";

    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("1- Add Student");
            Console.WriteLine("2- Show Students");
            Console.WriteLine("3- Remove Student");
            Console.WriteLine("4- Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    ShowStudents();
                    break;
                case 3:
                    RemoveStudent();
                    break;
            }

        } while (choice != 4);
    }

    static void AddStudent()
    {
        Console.Write("Student ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        students[id] = new Student { Name = name, Age = age };
        SaveToFile();
    }

    static void ShowStudents()
    {
        foreach (var s in students)
            Console.WriteLine(s.Key + " " + s.Value.Name + " " + s.Value.Age);
    }

    static void RemoveStudent()
    {
        Console.Write("Student ID: ");
        int id = int.Parse(Console.ReadLine());

        if (students.Remove(id))
            SaveToFile();
    }

    static void SaveToFile()
    {
        using (StreamWriter sw = new StreamWriter(path))
        {
            foreach (var s in students)
                sw.WriteLine(s.Key + "," + s.Value.Name + "," + s.Value.Age);
        }
    }
}
