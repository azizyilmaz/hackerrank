using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "12:00:00AM";
            string result = timeConversion(s);
            System.Console.WriteLine(result);
        }

        /*
         * Complete the timeConversion function below.
         */
        static string timeConversion(string s)
        {
            string[] arr = s.Split(':');
            int hh = Int32.Parse(arr[0]);
            int mm = Int32.Parse(arr[1]);
            int ss = Int32.Parse(arr[2].Substring(0, 2));
            string ampm = arr[2].Substring(2, 2);
            if ("PM".Equals(ampm) && hh < 12)
                hh += 12;
            else if ("AM".Equals(ampm) && hh == 12)
                hh = 0;
            return string.Format("{0:00}:{1:00}:{2:00}", hh, mm, ss);
        }
    }
}
