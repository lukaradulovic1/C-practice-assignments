using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

//12. Invent a format to represent the grade-to-students dictionary from assignment 6 in a text file.

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

    static void Main()
    {
        while (true)
        {
            List<string> studentNames = new List<string> { "Mika", "Zika", "Pera", "Laza" };

            var mapGradesToNames = MapGradesToStudents(studentNames);

            Dictionary<string, Grade> proccessedNamesGradesDictionary = new Dictionary<string, Grade>();

            var path = @"C:\Users\Luka\Desktop\StudentsToGradesDictionary.txt";

            CreateTxtFileFromDictionaryValues(path, proccessedNamesGradesDictionary);

            string[] lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                ParseStudentGradeLineToDictionary(line, proccessedNamesGradesDictionary);
            }

            foreach (var item in proccessedNamesGradesDictionary)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

        }

    }

    private static void ParseStudentGradeLineToDictionary(string studentReportGrade, Dictionary<string, Grade> dictionary)
    {
        Regex reg = new Regex("Student ([A-Za-z 0-9_-]+) grade is ([A-DF])");

        if (reg.IsMatch(studentReportGrade))
        {
            var groups = reg.Match(studentReportGrade).Groups;
            var studentName = groups[1].Value;
            var gradeString = groups[2].Value;

            var grade = Enum.Parse<Grade>(gradeString);
            dictionary.Add(studentName, grade);
        }


    }

    private static void CreateTxtFileFromDictionaryValues(string path, Dictionary<string, Grade> dictionary)
    {
        Dictionary<string, Grade> dictionaryToPrint = new Dictionary<string, Grade>(dictionary);
        //format of txt file is $"Grade of student {item.Key} is {item.Value}"
        using (var sw = new StreamWriter(path))
        {
            foreach (var item in dictionaryToPrint)
            {
                sw.WriteLine($"Student {item.Key} grade is {item.Value}");
            }

        }

    }

    private static Dictionary<Grade, List<string>> MapGradesToStudents(List<string> studentNames)
    {
        // 0. Create empty dictionary
        // 1. Create empty list for each grade and add to dictionary
        // 2. Go through all student names and add each one to the right list 
        // 3. Return the dictionary

        Dictionary<Grade, List<string>> mappedGradesToStudentList = new Dictionary<Grade, List<string>>();

        foreach (Grade grade in Enum.GetValues(typeof(Grade)))
        {
            List<string> emptyList = new List<string>();
            mappedGradesToStudentList.Add(grade, emptyList);
        }

        foreach (var student in studentNames)
        {
            Grade studentGrade = GradeAStudent(student);
            List<string> theCorrectList = mappedGradesToStudentList[studentGrade];
            theCorrectList.Add(student);
        }

        return mappedGradesToStudentList;

    }

    private static Grade GradeAStudent(string student)
    {
        Random rnd = new Random();
        Grade studentGrade = (Grade)rnd.Next(0, 4);
        return studentGrade;
    }

    private static Grade[] GradeAStudent(string[] namesArray)
    {

        Grade[] studentGradesArray = new Grade[namesArray.Length];
        for (int i = 0; i < namesArray.Length; i++)
        {
            studentGradesArray[i] = GradeAStudent(namesArray[i]);
        }
        return studentGradesArray;
    }

    private static List<Grade> GradeAStudent(List<string> namesList)
    {

        List<Grade> studentGradesList = new List<Grade>();
        for (int i = 0; i < namesList.Count; i++)
        {
            studentGradesList.Add(GradeAStudent(namesList[i]));
        }
        return studentGradesList;
    }

    private static Dictionary<string, Grade> MapStudentsToGrades(List<String> studentNames)
    {

        Dictionary<string, Grade> studentsWhoAreGraded = new Dictionary<string, Grade>();
        for (int i = 0; i < studentNames.Count; i++)
        {
            var studentName = studentNames[i];
            Grade studentGrade = GradeAStudent(studentName);
            studentsWhoAreGraded.Add(studentName, studentGrade);
        }

        return studentsWhoAreGraded;
    }
}

