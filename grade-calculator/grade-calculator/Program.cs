/*
 Presley Smith
IGME 201
Grade Calculator
10/13/2024
 */
namespace grade_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Presley";
            int[] grades = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };
            int average = 82;


            Console.WriteLine($"Welcome, " + name);
            Console.WriteLine("Here are your grades:\n");

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
                if(grades[i] <= 100 && grades[i] >= 90)
                {
                    Console.WriteLine("This Grade is an A!\n");
                    if (grades[i] == 100)
                    {
                        Console.WriteLine("WOW! A perfect score!\n");
                    }
                }
                else if (grades[i] <= 89 && grades[i] >= 80)
                {
                    Console.WriteLine("This grade is a B!\n");
                }
                else if (grades[i] <= 79 && grades[i] >= 70)
                {
                    Console.WriteLine("This grade is a C!\n");
                }
                else if (grades[i] <= 69 && grades[i] >= 65)
                {
                    Console.WriteLine("This grade is a D!\n");
                }
                else if (grades[i] <= 64 && grades[i] >= 0)
                {
                    Console.WriteLine("This grade is a F!\n");
                }
                else
                {
                    Console.WriteLine("This is out of range of 0-100.");
                    Console.WriteLine("How did you even get this grade???\n");
                }
            }

            Console.WriteLine("Your average Grade is " + average);
            Console.WriteLine("Good Job!\n");

            Console.WriteLine("All grades have been displayed");

        }
    }
}
