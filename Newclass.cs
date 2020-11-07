using System;

namespace newC
{
    class Newclass
    {
        public calcPercentage(double CurrentScore, double PointsAvailable)
        {
            Program myclass = new Program();
            double division = myclass.Divide(CurrentScore, PointsAvailable);
            double Percent = division * 100;
            Console.WriteLine("Your final score is " + CurrentScore + " out of " + PointsAvailable + " leaving you with " + Percent + "%");
            return Percent;
        }

    }
}