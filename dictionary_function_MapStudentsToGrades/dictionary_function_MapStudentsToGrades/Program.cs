using System;
using System.Collections.Generic;
//5. Define a static function MapStudentsToGrades, which takes a unique list of student names,
//and returns a dictionary which maps each student name to the letter grade they received.
class Program
    {

    enum Grade
    {
        A,
        B,
        C,
        D,
        F
    }


    private static Dictionary<string, Grade> MapStudentsToGrades (List<String> studentNames)
    {
       
        Dictionary<string, Grade> studentsWhoAreGraded = new Dictionary<string, Grade>();
        for (int i = 0; i < studentNames.Count; i++)
        {
            Random rnd = new Random();
            Grade studentGrade = (Grade)rnd.Next(0, 4);
            studentsWhoAreGraded.Add(studentNames[i], studentGrade);
        }

        return studentsWhoAreGraded;
    }
    static void Main()
        {
        List<string> studentNames = new List<string> { "Mika", "Zika", "Pera", "Laza" };

        Console.WriteLine("Type in student name to check the grade: ");
        string nameOfStudent = Console.ReadLine();

        Dictionary<string, Grade> mappedStudentDictionary = new Dictionary<string, Grade>();
        mappedStudentDictionary = MapStudentsToGrades(studentNames);
        if (mappedStudentDictionary.ContainsKey(nameOfStudent))
        {
            Console.WriteLine(mappedStudentDictionary[nameOfStudent]);
        }
        else
        {
            Console.WriteLine("Type in a proper student name.");
        }

    }
    }

