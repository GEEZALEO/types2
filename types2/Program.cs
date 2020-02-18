using System;

namespace types
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = "George";
            int grade = 98;
            char lettergrade = 'A';
            double costofTuition = 15.00;


            Console.WriteLine($"{firstname} is the student, {grade} is the grade earned. which is an {lettergrade} and it cost {costofTuition}");
            Console.ReadLine();

        }
    }
}

