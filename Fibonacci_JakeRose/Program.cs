using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_JakeRose
{
    class Program
    {
        static void Main(string[] args)
        {
            //try block
            try
            {
                //Asks user to enter number. 92 is the largest sequence number long data type can handle
                Console.WriteLine("Please write the sequence number for the Fibonacci number you would like to see and press enter.");
                //takes user input, converts to int datatype
                long sequenceNum = Convert.ToInt64(Console.ReadLine());
                //uses formula to calculate Fibonacci numbers using a close approximation of the golden ratio, converts to double type variable fibNum
                double fibNum = ( (Math.Pow (1.618033988749, sequenceNum)) - (Math.Pow (.618033988749, sequenceNum))) / (Math.Sqrt(5));
                //Takes fibNum and rounds up to nearest integer, converts to int datatype
                long roundedNum = Convert.ToInt64(Math.Ceiling(fibNum));
                //write number to console
                Console.WriteLine("Your number is " + roundedNum);
                Console.ReadLine();
             }
            //catch for exceptions if user enters a decimal, string, or number larger than long data type can handle
            catch
            {
                Console.WriteLine("Please enter a whole number no larger than 92.");
                Console.ReadLine();
            }           
        }
    }
}
