using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

//14.Implement method AddStudentGradeLineToDictionary to take lines from the new format
//and add them to a grade-to-students dictionary.

class Program
{
    static void Main()
    {


        List<string> studentNames = new List<string> { "santa maria de la burritz", "horhe", "3Pac", "The god emperor", "z_pee-pee-oh", "mrzim programiranje" };

        Dictionary<string, Grade> mappedStudentDictionary = MapStudentsToGrades(studentNames);

        var path = @"C:\Users\Luka\Desktop\StudentsToGradesDictionary.txt";

        CreateTxtFileFromDictionaryValues(path, mappedStudentDictionary);

        Dictionary<string, Grade> proccessedNamesGradesDictionary = new Dictionary<string, Grade>();

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

    private static void AddStudentGradeLineToDictionary(string studentReportGrade, Dictionary<string, Grade> OpenDictionary)
    {

        var studentNameGradeDictionary = OpenDictionary;
        string phrase = studentReportGrade;

        var words = phrase.Split("Student ");

        var restOfPhrase = words[1];
        words = restOfPhrase.Split(" grade is ");
        var studentName = words[0];
        var gradeString = words[1];

        var grade = Enum.Parse<Grade>(gradeString);
        studentNameGradeDictionary.Add(studentName, grade);


    }

    private static void CreateTxtFileFromDictionaryValues(string path, Dictionary<string, Grade> mappedDictionaryWithNamesAndGrades)
    {
        Dictionary<string, Grade> dictionaryToPrint = new Dictionary<string, Grade>(mappedDictionaryWithNamesAndGrades);
        //format of txt file is $"Grade of student {item.Key} is {item.Value}"
        using (var sw = new StreamWriter(path))
        {
            foreach (var item in dictionaryToPrint)
            {
                sw.WriteLine($"Student {item.Key} grade is {item.Value}");
            }

        }

    }

    enum Grade
    {
        A,
        B,
        C,
        D,
        F
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



