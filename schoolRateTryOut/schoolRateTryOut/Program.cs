using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. preparations
            string errorMessage = "incorrect input";
            int mathematics, informationTechnology, science, english;
            bool hasUnexcusedAbsences;

            // 2. Inputs
            try
            {
                Console.WriteLine("Enter grades from individual subjects:");

                Console.Write("Mathematics: ");
                string input = Console.ReadLine();
                mathematics = Convert.ToInt32(input);
                if (mathematics < 1 || mathematics > 5)
                {
                    Console.WriteLine(errorMessage);
                    return;
                }

                Console.Write("Information technology: ");
                input = Console.ReadLine();
                informationTechnology = Convert.ToInt32(input);
                if (informationTechnology < 1 || informationTechnology > 5)
                {
                    Console.WriteLine(errorMessage);
                    return;
                }

                Console.Write("Science: ");
                input = Console.ReadLine();
                science = Convert.ToInt32(input);
                if (science < 1 || science > 5)
                {
                    Console.WriteLine(errorMessage);
                    return;
                }

                Console.Write("English: ");
                input = Console.ReadLine();
                english = Convert.ToInt32(input);
                if (english < 1 || english > 5)
                {
                    Console.WriteLine(errorMessage);
                    return;
                }

                Console.Write("Any unexcused absences? (yes/no): ");
                input = Console.ReadLine();
                input = input.ToLower(); // not distinguishing upper/lower
                if (input != "yes" && input != "no")
                {
                    Console.WriteLine(errorMessage);
                    return;
                }
                hasUnexcusedAbsences = input == "yes";
            }
            catch (Exception)
            {
                Console.WriteLine(errorMessage);
                return;
            }

            // 3. Evaluation
            // You need arithemtic average of all the grades
            double average = (mathematics + informationTechnology + science + english) / 4.0;
            string message;

            // Testing all conditions for excellence
            if (average < 1.5001 && mathematics <= 2 && informationTechnology <= 2 && science <= 2 && english <= 2 && !hasUnexcusedAbsences)
            {
                message = "Excellent";
            }
            else
            {
                // here you know the result is not excellent, so testing the other possiblities
                if (mathematics == 5 || informationTechnology == 5 || science == 5 || english == 5)
                {
                    message = "Failed";
                }
                else
                {
                    message = "Good";
                }
            }
            // 4. Output
            Console.WriteLine("Summary evaluation: " + message);
        }
    }
}
