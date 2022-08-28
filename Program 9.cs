using System;
namespace Program9
{
    class Reverse
    {
        public static string reverseByWords(string Input)
        {
            char[] charArray = Input.ToCharArray();
            string word = String.Empty;
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                word += charArray[i];
            }


            return word;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            string rev = reverseByWords(str);
            Console.WriteLine("Reversed String is");
            Console.WriteLine(rev);

        }
    }
}