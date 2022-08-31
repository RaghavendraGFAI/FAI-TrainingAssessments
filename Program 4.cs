using System;
namespace Program4
{
    class EvenandOddSum
    {
        static void Main(string[] args)
        {
            int[] arr = new int[1000];
            Console.WriteLine("Enter the total Number of Elements");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Elements: ");
            for (int i = 0; i < count; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                Sum(arr,count);
            }


        }
        static void Sum(int[] array,int countt)
        {
            int oddcount=0;
            int evencount=0;
            for (int j = 0; j < countt; j++)
            {
                if (array[j] % 2 == 0)
                {
                    evencount += array[j];
                }
                else
                {
                    oddcount += array[j];

                }
            }
            Console.WriteLine("Sum of even elements :" + evencount);
            Console.WriteLine("Sum of Odd elements:" + oddcount);

        }
    }
}
        
