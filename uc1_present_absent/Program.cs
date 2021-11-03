using System;

namespace uc1_present_absent
{
    class Program
    {
        static void Main(string[] args)
        {

  
        
            {
                int IsFullTime = 1;

                Random random = new Random();

                int empCheck = random.Next(0, 2);

                if (empCheck == IsFullTime)
                {
                    Console.WriteLine("Employee is present");

                }

                else
                {
                    Console.WriteLine("Employee is absent");

                }


            }
        }


    }

}
