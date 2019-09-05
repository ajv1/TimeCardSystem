using System;

namespace TimeCardSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How many days of leave would you like to take off?: ");
                int days = int.Parse(Console.ReadLine());

                if (days < 7 &&  days > 1)
                {
                    Console.WriteLine("You can take off!");
                }
                else Console.WriteLine("You aren't eligible for the days requested.");
                }
            catch
            {
                Console.WriteLine("You have an error!");
            }
        }
    }
}
