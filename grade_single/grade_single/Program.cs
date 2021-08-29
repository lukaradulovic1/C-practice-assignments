using System;
using System.Collections.Generic;

//2. Initialize a list of four students, each represented as a name string:
//{"Zika", "Mika", "Pera", "Laza"}. Define a static function Grade which takes the name of a student,
//grades them in some bullshit way based on their name, and returns the letter grade.

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

    static void Main()
    {
        List<string> studentNameList = new List<string> { "Zika", "Mika", "Pera", "Laza" };
        for (int i = 0; i < studentNameList.Count; i++)
        {
            string name = studentNameList[i];
            Grade studentGrade = GradeAStudent(name);
            Console.WriteLine("{0}'s grade is {1}.", name, studentGrade.ToString());
        }
    }
}

