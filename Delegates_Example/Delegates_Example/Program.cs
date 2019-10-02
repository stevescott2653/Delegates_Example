using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Example
{
    delegate int Calculator(int n); //declaring delegat
    public class DelegateExample
    {
        static int number = 100;

        public static int add(int n)
        {
            number = number + n;
            return number;
        }

        public static int mul(int n)
        {
            number = number * n;
            return number;
        }

        public static int getNumber()
        {
            return number;
        }
        public static void Main(string[] args)
        {
            Calculator c1 = new Calculator(add); // instantiating delegate
            Calculator c2 = new Calculator(mul);
            c1(20); // Calling method using delegate
            Console.WriteLine("After c1 delegate, Number is: " + getNumber());
            c2(3);
            Console.WriteLine("After c2 delegate, Number is: " + getNumber());
        }
    }
}
