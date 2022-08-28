using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class DatatypeRange
    {
        static void Main(string[] args)
        {
            range();
        }
        static void range()
        {
            Console.WriteLine("The range of byte is from:" + byte.MinValue + " to " + byte.MaxValue);
            Console.WriteLine("The range of short is from:" + short.MinValue + " to " + short.MaxValue);
            Console.WriteLine("The range of unsigned short is from:" + ushort.MinValue + " to " + ushort.MaxValue);
            Console.WriteLine("The range of int is from:" + int.MinValue + " to " + int.MaxValue);
            Console.WriteLine("The range of unsigned int is from:" + uint.MinValue + " to " + uint.MaxValue);
            Console.WriteLine("The range of long is from:" + long.MinValue + " to " + long.MaxValue);
            Console.WriteLine("The range of float is from:" + float.MinValue + " to " + float.MaxValue);
            Console.WriteLine("The range of double is from:" + double.MinValue + " to " + double.MaxValue);

        }

    }
}