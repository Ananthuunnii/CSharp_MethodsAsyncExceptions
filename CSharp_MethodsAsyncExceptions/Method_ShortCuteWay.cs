using System;
namespace Method_in_ShortCut_Way
{
    class Demo
    {
        public static void Printnumber()
        {
            Console.WriteLine("the number is 10");
        }
        public static int Multiplication(int number)
        {
            return number * number;
        }
    }
    class Program
    {
        static void Main()
        {
            // -------------------- lambda function  method shortcut- arrow - ()=>{}
            // first function
            //Demo.Printnumber();
            var PrintNumber = () =>             // lambda function with arrow
            {
                Console.WriteLine("the number is 10");
            };
            PrintNumber();  // calling the arrow method


            // second method
            //int num = Demo.Multiplication(8);
            //Console.WriteLine($"the number is {num}");

            var MultiplayNumber = (int number) =>
            {
                return number * number;
            };

            int result1 = MultiplayNumber(2);
            int result2 = MultiplayNumber(7);

            Console.WriteLine($"the number is {result1}");
            Console.WriteLine($"the number is {result2}");
        }

    }
}
