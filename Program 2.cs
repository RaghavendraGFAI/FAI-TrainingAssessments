using System;
namespace Program 2
{
    class EvenAndOdd
    {
        public static void OddorEven()
        {


            int[] array = new int[1000];
            Console.WriteLine("Enter the total number of Elements");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Elements:");
            for (int i = 0; i < count; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] Evenlist = new int[1000];
            int[] Oddlist = new int[1000];
            int EvenCount = 0;
            int OddCount = 0;

            for (int i = 0; i < count; i++)
            {

                if (array[i] % 2 == 0)
                {
                    Evenlist[EvenCount] = array[i];
                    EvenCount++;

                }
                else
                {
                    Oddlist[OddCount] = array[i];
                    OddCount++;

                }
            }

            Console.WriteLine("Even Numbers in the list of Elements are:");
            for (int i = 0; i < EvenCount; i++)
            {
                Console.WriteLine(Evenlist[i]);
            }
            Console.WriteLine("Odd Numbers in the list of Elements are:");
            for (int i = 0; i < OddCount; i++)
            {
                Console.WriteLine(Oddlist[i]);
            }


        }
        static void Main(string[] args)
        {
            OddorEven();
        }
    }
}