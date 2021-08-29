using System;
using System.Collections.Generic;
using System.IO;

//7.Invent a format to represent the student-to-grade dictionary in a text file.
class Program
{
    static void Main()
    {
        while (true)
        {
            List<string> studentNames = new List<string> { "santa maria de la burrit", "horhe", "3Pac", "The god emperor", "z_pee-pee-oh", "mrzim programiranje" };

            Dictionary<string, Grade> mappedStudentDictionary = MapStudentsToGrades(studentNames);

            var path = @"C:\Users\Luka\Desktop\StudentsToGradesDictionary.txt";

            //format of txt file is $"Grade of student {item.Key} is {item.Value}"
            using (var sw = new StreamWriter(path))
            {
                foreach (var item in mappedStudentDictionary)
                {
                
                    sw.WriteLine($"Grade of student {item.Key} is {item.Value}");
                }

            }
            return;
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



