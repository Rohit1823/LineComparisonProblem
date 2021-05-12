using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Line Comparison Problem!");
            Console.Write("Enter x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x1 : " + x1);
            Console.WriteLine("x2 : " + x2);
            Console.WriteLine("y1 : " + y1);
            Console.WriteLine("y2 : " + y2);
            double Length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of Line 1 is Equal to : " + Length1);


            Console.Write("Enter x3:");
            int x3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter x4:");
            int x4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y3:");
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y4:");
            int y4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x1 : " + x1);
            Console.WriteLine("x2 : " + x2);
            Console.WriteLine("y1 : " + y1);
            Console.WriteLine("y2 : " + y2);
            double Length2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Length of Line 2 is Equal to : " + Length2);

            //Equal Line Check
            if (Length1 == Length2)
            {
                Console.WriteLine("Two Lines are Equal");
            }
            else if (Length1 >= Length2)
            {
                Console.WriteLine("Line 1 is Greater than Line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is Smaller than Line 2");
            }

            //CompareTo Method

            if (Length1.CompareTo(Length2) == 0)
            {
                Console.WriteLine("Line 1 is Equal to Line 2");
            }
            else if (Length1.CompareTo(Length2) > 0)
            {
                Console.WriteLine("Line 1 is Greater than Line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is Smaller than Line 2");
            }

        }
    }
}
