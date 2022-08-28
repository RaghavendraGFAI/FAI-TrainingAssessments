using System;
namespace Program3
{
    class EvenandOddSum
    {
        static void Sum()
        {
            int[] array = new int[1000];
            int evensum = 0;
            int oddsum = 0;
            Console.WriteLine("Enter the total Number of Elements");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Elements: ");
            for (int i=0; i<count; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] % 2 == 0)
                {

                    evensum += array[i];
                }
                else
                {
                    oddsum += array[i];
                }
            }
            Console.WriteLine($"Sum Of Even Numbers in the list of elements are : {evensum}");
            Console.WriteLine($"Sum Of Odd Numbers in the list of elements are {oddsum}");


        }
        static void Main(string[] args)
        {
            Sum();
        }
    }
}