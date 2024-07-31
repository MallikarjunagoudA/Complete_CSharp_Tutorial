using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntro
{
    public class ParameterTypes
    {

        //value type
        public void Calculate(int a)
        {
            a = 100;
            Console.WriteLine($"value a is {a}");
        }

        //reference type
        public void CalculateRef(ref int b)
        {
            b = 100;
            Console.WriteLine($" reference b is {b}");
        }

        //out parameter type
        public void CalculateOut(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }

        // parameter array type
        public void ParameterArray(int a, params int[] arr)
        {
            Console.WriteLine(arr.Length);
            foreach (int i in arr) Console.WriteLine(i * a);
        }
    }
}
