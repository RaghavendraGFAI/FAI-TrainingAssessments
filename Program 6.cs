using System;
namespace Program6
{
    class Calender
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Date");
            int date = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Year");
            int year = int.Parse(Console.ReadLine());
            bool a = IsValidDate(year, month, date);
            Console.WriteLine(a);
        }
        public static bool IsValidDate(int year, int month, int date)
        {
            int lastdate;
            bool c = true;
            if (year > 0)

            {

                switch (month)
                {
                    case 1:
                        c = checkdate(date, lastdate = 31);
                        break;
                    case 2:
                        int lep = feb(year);
                        if (date > 0 && date <= lep)
                        {
                            c = true;
                        }
                        else
                        {
                            c = false;
                        }
                        break;
                    case 3: c = checkdate(date, lastdate = 31); break;
                    case 4: c = checkdate(date, lastdate = 30); break;
                    case 5: c = checkdate(date, lastdate = 31); break;
                    case 6: c = checkdate(date, lastdate = 30); break;
                    case 7: c = checkdate(date, lastdate = 31); break;
                    case 8: c = checkdate(date, lastdate = 31); break;
                    case 9: c = checkdate(date, lastdate = 30); break;
                    case 10: c = checkdate(date, lastdate = 31); break;
                    case 11: c = checkdate(date, lastdate = 30); break;
                    case 12: c = checkdate(date, lastdate = 31); break;
                    default: c = false; break;
                }

            }
            return c;
        }



        public static bool checkdate(int date1, int odate1)
        {
            if (date1 > 0 && date1 <= odate1)
            {
                return true;

            }
            else
            {
                return false;

            }

        }
        public static int feb(int yer)
        {
            if ((yer % 400) == 0)
                return (29);
            else if ((yer % 100) == 0)
                return (28);

            else if ((yer % 4) == 0)
                return (29);
            else
                return (28);

        }

    }

}