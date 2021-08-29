using System;

namespace enum_grades_abcd
{
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
            Console.WriteLine("Excellent grade is grade {0}", Grade.A);
            Console.WriteLine("Very good grade is grade {0}", Grade.B);
            Console.WriteLine("Acceptable grade is grade {0}", Grade.C);
            Console.WriteLine("Needs improvment grade is grade {0}", Grade.D);
            Console.WriteLine("Failure grade is grade {0}", Grade.F);

           

            
        }
    }
}
