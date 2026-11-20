
using System;

namespace CSharp_MethodsRevision
{
    class Program
    {
        static string[] ProcessArray(int[] fnumber)
        {
            string[] box = new string[fnumber.Length];
            for(int i=0;i< fnumber.Length;i++)
            {
                if (fnumber[i] % 2 == 0)
                {
                    box[i] = $" the number {fnumber[i]} is odd";
                }
                else
                {
                    box[i] = $" the number {fnumber[i]} is even";
                }
            }
            return box;
        }
        static void Main()
        {
            int[] funnumber = {10,20,30,35,11};
            string [] args = ProcessArray(funnumber);
            Console.WriteLine(args);
            foreach(string mnum in args)
            {
                Console.WriteLine($" the number {mnum} is odd");
            }
        }
    }
}
