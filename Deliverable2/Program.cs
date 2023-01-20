using System;

namespace Deliverable_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");

            try
            {

                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is an A.");
                }
                else if (grade >= 80)
                {
                    letter = "B";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is a B.");
                }
                else if (grade >= 70)
                {
                    letter = "C";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is a C.");
                }
                else if (grade >= 60)
                {
                    letter = "D";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is a D.");
                }
                else
                {
                    letter = "F";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is an F.");
                }
            }
            catch
            {
                Console.WriteLine("Enter a numeric value.");
            }
        }
    }
}

    
