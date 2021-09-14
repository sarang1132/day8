using System;

namespace day8
{   


    class fact
    {
        public long getfactorial(int number)
        {

            if(number == 0)
            {
                return 1;

            }
            else
            {

                return number * getfactorial(number - 1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            fact f = new fact();
            Console.WriteLine("Factorial uing recursive method/n Enter any number");
            int number = Convert.ToInt32(Console.ReadLine());
            long fact = f.getfactorial(number);
            Console.WriteLine("factorial of {0} is {1}", number, fact);

        }
    }
}
