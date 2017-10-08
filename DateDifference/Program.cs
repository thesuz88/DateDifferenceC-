using System;

namespace DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date: ");
            String date1 = Console.ReadLine();

            Console.WriteLine("Enter a second date: ");
            String date2 = Console.ReadLine();

            DateTime zeroDate = new DateTime(1, 1, 1);
            DateTime newDate1 = DateTime.Parse(date1);
            DateTime newDate2 = DateTime.Parse(date2);

            TimeSpan ts = (newDate1.Subtract(newDate2)).Duration();
            
       
            

            int years = (zeroDate + ts).Year - 1;
            int months = (zeroDate + ts).Month - 1;
            int days = (zeroDate + ts).Day - 1;

            Console.WriteLine("Difference between the dates is " + years + " years, " + months + " months, " + days + " days.");
         
            

            Console.ReadKey(true);
        }
    }
}
