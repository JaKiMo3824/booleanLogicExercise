using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanLogicExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please answer the following questions in order to determine whether you qualify for car insurance: ");
            Console.WriteLine("What is your age?");
            string customerAge = Console.ReadLine();
            int custAge = Convert.ToInt32(customerAge);

            Console.WriteLine("Have you ever had a DUI? Answer TRUE or FALSE");
            string customerDui = Console.ReadLine();
            bool custDui = Convert.ToBoolean(customerDui);

            Console.WriteLine("How many speeding tickets do you have? ");
            string customerTickets = Console.ReadLine();
            int custTic = Convert.ToInt32(customerTickets);

            bool age = custAge > 15;
            bool dui = custDui == false;
            bool tic = custTic <= 3;

            bool qualify = age && dui && tic;

            Console.WriteLine("Do you qualify? ");
            Console.WriteLine(qualify);
            Console.ReadLine();
          

        }
    }
}
