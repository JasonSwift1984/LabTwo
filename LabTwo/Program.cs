using System;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!" + "\n" + "Enter Length:");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width:");
                double width = double.Parse(Console.ReadLine());

                double area = length * width;
                double perimeter = 2 * area;

                Console.WriteLine(area);
                Console.WriteLine(perimeter);

                Console.WriteLine("Continue? y/n");
                string answer = Console.ReadLine();

                if (answer == "y" || answer == "Y")
                {

                }
                else
                {


                }


            } while (true);
        }
    }
}
