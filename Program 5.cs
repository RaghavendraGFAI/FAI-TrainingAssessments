using System;

namespace Program5
{
    class Interest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principle Amount");
            double Amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rate of Interest");
            double Rate = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter time period");
            double Time = double.Parse(Console.ReadLine());
            double SInterest=SimpleInterest(Amount,Rate,Time);
            Console.WriteLine($"The Interest is {SInterest}");
        }
        static double SimpleInterest(double amt,double roi,double time)
        {
            double Interest = ((amt*roi*time)/100);
            return Interest;
        }
    }
}