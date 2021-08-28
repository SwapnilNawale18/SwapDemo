using System;

namespace SwapDemo
{
    class Swap
    {
        void swapping(ref int a, ref int b)
        {
            //Using 3rd variable
            int c = a;
            a = b;
            b = c;
            /*a += b;
            b = a - b;
            a -= b;*/
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter value of x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Swap s = new Swap();
            s.swapping(ref x, ref y);
            Console.WriteLine("After Swapping");
            Console.WriteLine("Value of x is: " + x);
            Console.WriteLine("Value of y is: " + y);
        }
    }
}
