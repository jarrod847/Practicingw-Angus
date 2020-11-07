using System;

namespace newC
{
    class Program
    {
        public static void Main()
        {
            int Count = 0;
            int TotalExercises = 0;
            int CurrentScore = 0;
            int TotalScore = 0;
            int PointsAvailable = 0;
            int TotalPossibleScore = 0;
            double Percent = 0;


            Newclass myclass = new Newclass();

            Console.WriteLine("How many exercies were done?");
            TotalExercises = int.Parse(Console.ReadLine());

            while (Count < TotalExercises)
            {
                Count++;
                Console.WriteLine("Enter score received for Exercise " + Count);
                CurrentScore = int.Parse(Console.ReadLine());

                Console.WriteLine("Total Score possible for exercise " + Count);
                PointsAvailable = int.Parse(Console.ReadLine());

                TotalScore += CurrentScore;
                TotalPossibleScore += PointsAvailable;
            }

        }
        public Divide(double num1, double num2)
        {
            double division = num1 / num2;
            if (num2 <= 0)
            {
                Console.WriteLine("Can not divide by 0");
            }

            return;
        }
    }
}
