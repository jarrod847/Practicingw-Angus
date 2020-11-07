using System;

namespace newC
{
    class Program
    {
        static void Main(string[] args)
        {
            Newclass myclass = new Newclass();
            int one = 4;
            int two = 2;
            string[] cars = { "Angus", "smells", "like", "shit" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Console.WriteLine(myclass.divide(one, two));
        }
    }
}
