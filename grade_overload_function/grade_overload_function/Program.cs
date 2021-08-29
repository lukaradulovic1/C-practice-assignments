using System;
using System.Collections.Generic;
using System.Collections;
//3.Overload the Grade function -- this one should take an array of student names,
//and return an array of letter grades, one for each student, in the same order.

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
    private static Grade GradeAStudent(string name)
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

    static void Main()
    {
        List<string> studentNameList = new List<string> { "Zika", "Mika", "Pera", "Laza" };
        string[] namesArray = studentNameList.ToArray();

        for (int i = 0; i < studentNameList.Count; i++)
        {
            string name = studentNameList[i];
            Grade studentGrade = GradeAStudent(name);
            Console.WriteLine("{0}'s grade is {1}.", name, studentGrade.ToString());
        }

        Grade[] gradesArray = GradeAStudent(namesArray);
        Console.WriteLine("Grades array is: \n");
        for (int i = 0; i < gradesArray.Length; i++)
        {
            Console.WriteLine("{0}'s grade is {1}.",  namesArray[i], gradesArray[i]);
        }
    }
}

